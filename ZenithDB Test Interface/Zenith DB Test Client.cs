using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZenithDB;

namespace ZenithDB_Test_Interface
{
    public partial class ZenithDBTestClient : Form
    {
        ZenithDatabase testDB = new ZenithDatabase();

        public ZenithDBTestClient()
        {
            InitializeComponent();
        }

        private void CreateDbBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf_dialog = new SaveFileDialog();
            sf_dialog.Filter = "ZenithDB files (*.zen)|*.zen|All files (*.*)|*.*";

            sf_dialog.FilterIndex = 2;
            sf_dialog.RestoreDirectory = true;

            if (sf_dialog.ShowDialog() == DialogResult.OK)
            {
                testDB.CreateDatabase(sf_dialog.FileName, false, '#');
                MessageBox.Show("Database Created at : " + sf_dialog.FileName);
            }
        }

        private void OpenDbBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "ZenithDB files (*.zen)|*.zen|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                testDB.OpenDatabase(openFileDialog.FileName);
                MessageBox.Show(openFileDialog.FileName);
                if (testDB.isDBOpen)
                {
                    MessageBox.Show("DB is open.");
                }
            }

        }

        private void AddDbEntryBtn_Click(object sender, EventArgs e)
        {
            testDB.InsertData(keyField.Text, valueField.Text);
            testDB.UpdateDatabase();
        }

        private void DeleteEntryBtn_Click(object sender, EventArgs e)
        {
            testDB.DeleteData(delKeyField.Text);
            testDB.UpdateDatabase();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            testDB.CloseDatabase(true);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(testDB.ReadData(textBox1.Text));
        }
    }
}
