using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ZenithDB
{
    public class ZenithDatabase
    {
        public string FilePath = String.Empty;
        public char Delimiter;
        public bool isDBOpen = false;

        internal string[] FileStringArray;
        internal List<string> FileData = new List<string>();
        internal List<string[]> FileDataArray = new List<string[]>();
        internal List<string> EncodedFileData = new List<string>();

        public ZenithDatabase()
        {
        }

        public bool CreateDatabase(string FilePath, bool OverrideExisting = false, char Delimiter = '#')
        {
            this.FilePath = FilePath;
            this.Delimiter = Delimiter;
            if (!String.IsNullOrEmpty(FilePath))
            {
                if (!File.Exists(FilePath))
                {
                    Console.WriteLine("No Existing Database Discovered. Creating New Database.");
                    FileStream temp_fs = File.Create(FilePath);
                    temp_fs.Close();
                    return true;
                }
                else if (File.Exists(FilePath) && OverrideExisting)
                {
                    Console.WriteLine("Existing Database Discovered. Overriding Database.");
                    FileStream temp_fs = File.Create(FilePath);
                    temp_fs.Close();
                    return true;
                }
                else
                {
                    Console.WriteLine("Existing Database Discovered. Ceasing operation.");
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool OpenDatabase(string FilePath, char Delimiter = '#')
        {
            if(FilePath != String.Empty)
            {
                this.FilePath = FilePath;
            }
            else
            {
                Console.WriteLine("File Path cannot be blank.");
                return false;
            }

            if (!Char.IsWhiteSpace(Delimiter))
            {
                this.Delimiter = Delimiter;
            }
            else
            {
                Console.WriteLine("Delimiter cannot be blank.");
                return false;
            }
            
            if (isDBOpen)
            {
                Console.WriteLine("This Database is already open.");
                return false;
            }
            else
            {
                Console.WriteLine("Opening Database...");
            }

            try
            {
                Console.WriteLine("Reading Data...");
                FileStringArray = File.ReadAllLines(FilePath);
                Console.WriteLine("Decoding Data...");
                DecodeDatabase();
                Console.WriteLine("Parsing Data...");
                ParseDatabase();
                Console.WriteLine("Database Successfully Opened.");
                isDBOpen = true;
                return true;
            }
            catch(Exception ex)
            {
                isDBOpen = false;
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool CloseDatabase(bool SaveChanges)
        {
            if (isDBOpen)
            {
                Console.WriteLine("Closing Database...");
            }
            else
            {
                Console.WriteLine("No Database is currently open.");
                return false;
            }

            try
            {
                if (SaveChanges)
                {
                    UpdateDatabase();
                }
                
                FileStringArray = new string[] { String.Empty };
                FileData.Clear();
                FileDataArray.Clear();

                isDBOpen = false;
                Console.WriteLine("Database Successfully Closed.");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool ParseDatabase()
        {
            try
            {
                foreach(string Data in FileData)
                {
                    FileDataArray.Add(ParseData(Data));
                }
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool InsertData(string Key, string Value)
        {
            if (!isDBOpen)
            {
                Console.WriteLine("No Database is currently open.");
                return false;
            }

            if(Key.Contains(Delimiter.ToString()) || Value.Contains(Delimiter.ToString()))
            {
                Console.WriteLine("Delimeter cannot be used in the Key or Value string.");
                return false;
            }

            try
            {
                if (!KeyExists(Key))
                {
                    FileDataArray.Add(new string[] { Key, Value });
                    return true;
                }
                else
                {
                    foreach (string[] DataArray in FileDataArray)
                    {
                        if (DataArray[0] == Key)
                        {
                            DataArray[1] = Value;
                        }
                    }
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteData(string Key)
        {
            if (!isDBOpen)
            {
                Console.WriteLine("No Database is currently open.");
                return false;
            }

            try
            {
                List<string[]> EntriesToDelete = new List<string[]>();

                foreach(string[] DataArray in FileDataArray)
                {
                    if(DataArray[0] == Key)
                    {
                        EntriesToDelete.Add(DataArray);
                    }
                }

                foreach (string[] Entry in EntriesToDelete)
                {
                    FileDataArray.Remove(Entry);
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        internal string[] ParseData(string Data)
        {
            try
            {
                if(Data.Count(c => c == Delimiter) > 1)
                {
                    return new string[] { String.Empty, String.Empty };
                }
                else
                {
                    return Data.Split('#');
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return new string[] { String.Empty, String.Empty };
            }
        }

        internal string FormatData(string Key, string Value)
        {
            return Key + Delimiter.ToString() + Value;
        }

        public bool KeyExists(string Key)
        {
            if (!isDBOpen)
            {
                Console.WriteLine("No Database is currently open.");
                return false;
            }
            foreach (string[] DataArray in FileDataArray)
            {
                if(DataArray[0] == Key)
                {
                    return true;
                }
            }
            return false;
        }

        public string ReadData(string Key)
        {
            if (!isDBOpen)
            {
                Console.WriteLine("No Database is currently open.");
                return String.Empty;
            }
            if (KeyExists(Key))
            {
                foreach (string[] DataArray in FileDataArray)
                {
                    if (DataArray[0] == Key)
                    {
                        return DataArray[1];
                    }
                }
                return String.Empty;
            }
            else
            {
                Console.WriteLine("The Key does not exist.");
                return String.Empty;
            }
        }

        public bool UpdateDatabase()
        {
            if (!isDBOpen)
            {
                Console.WriteLine("No Database is currently open.");
                return false;
            }
            try
            {
                Console.WriteLine("Updating Database...");
                FileData.Clear();

                foreach(string[] DataArray in FileDataArray)
                {
                    FileData.Add(FormatData(DataArray[0], DataArray[1]));
                }

                EncodeDatabase();

                TextWriter txtWriter = new StreamWriter(FilePath);

                foreach(string EncodedDataString in EncodedFileData)
                {
                    txtWriter.WriteLine(EncodedDataString);
                }

                txtWriter.Close();
                Console.WriteLine("Database Successfully Updated.");
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        internal bool EncodeDatabase()
        {
            try
            {
                EncodedFileData.Clear();
                foreach (string DataString in FileData)
                {
                    EncodedFileData.Add(Base64Encode(DataString));
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        internal bool DecodeDatabase()
        {
            try
            {
                FileData.Clear();
                foreach(string FileStringData in FileStringArray)
                {
                    FileData.Add(Base64Decode(FileStringData));
                }
                return true;
            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        internal static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        internal static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
    }
}
