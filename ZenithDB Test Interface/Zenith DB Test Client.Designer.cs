namespace ZenithDB_Test_Interface
{
    partial class ZenithDBTestClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.createDbBtn = new System.Windows.Forms.Button();
            this.openDbBtn = new System.Windows.Forms.Button();
            this.addDbEntryBtn = new System.Windows.Forms.Button();
            this.keyField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.delKeyField = new System.Windows.Forms.TextBox();
            this.deleteEntryBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.valueField = new System.Windows.Forms.TextBox();
            this.DataBaseViewer = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createDbBtn
            // 
            this.createDbBtn.Location = new System.Drawing.Point(12, 12);
            this.createDbBtn.Name = "createDbBtn";
            this.createDbBtn.Size = new System.Drawing.Size(180, 36);
            this.createDbBtn.TabIndex = 1;
            this.createDbBtn.Text = "Create New Database";
            this.createDbBtn.UseVisualStyleBackColor = true;
            this.createDbBtn.Click += new System.EventHandler(this.CreateDbBtn_Click);
            // 
            // openDbBtn
            // 
            this.openDbBtn.Location = new System.Drawing.Point(12, 54);
            this.openDbBtn.Name = "openDbBtn";
            this.openDbBtn.Size = new System.Drawing.Size(180, 36);
            this.openDbBtn.TabIndex = 2;
            this.openDbBtn.Text = "Open Existing Database";
            this.openDbBtn.UseVisualStyleBackColor = true;
            this.openDbBtn.Click += new System.EventHandler(this.OpenDbBtn_Click);
            // 
            // addDbEntryBtn
            // 
            this.addDbEntryBtn.Location = new System.Drawing.Point(12, 138);
            this.addDbEntryBtn.Name = "addDbEntryBtn";
            this.addDbEntryBtn.Size = new System.Drawing.Size(180, 36);
            this.addDbEntryBtn.TabIndex = 3;
            this.addDbEntryBtn.Text = "Add Database Entry";
            this.addDbEntryBtn.UseVisualStyleBackColor = true;
            this.addDbEntryBtn.Click += new System.EventHandler(this.AddDbEntryBtn_Click);
            // 
            // keyField
            // 
            this.keyField.Location = new System.Drawing.Point(198, 154);
            this.keyField.Name = "keyField";
            this.keyField.Size = new System.Drawing.Size(100, 20);
            this.keyField.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Key";
            // 
            // delKeyField
            // 
            this.delKeyField.Location = new System.Drawing.Point(198, 196);
            this.delKeyField.Name = "delKeyField";
            this.delKeyField.Size = new System.Drawing.Size(100, 20);
            this.delKeyField.TabIndex = 9;
            // 
            // deleteEntryBtn
            // 
            this.deleteEntryBtn.Location = new System.Drawing.Point(12, 180);
            this.deleteEntryBtn.Name = "deleteEntryBtn";
            this.deleteEntryBtn.Size = new System.Drawing.Size(180, 36);
            this.deleteEntryBtn.TabIndex = 8;
            this.deleteEntryBtn.Text = "Delete Database Entry";
            this.deleteEntryBtn.UseVisualStyleBackColor = true;
            this.deleteEntryBtn.Click += new System.EventHandler(this.DeleteEntryBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Value";
            // 
            // valueField
            // 
            this.valueField.Location = new System.Drawing.Point(304, 154);
            this.valueField.Name = "valueField";
            this.valueField.Size = new System.Drawing.Size(100, 20);
            this.valueField.TabIndex = 11;
            // 
            // DataBaseViewer
            // 
            this.DataBaseViewer.Location = new System.Drawing.Point(12, 264);
            this.DataBaseViewer.Multiline = true;
            this.DataBaseViewer.Name = "DataBaseViewer";
            this.DataBaseViewer.ReadOnly = true;
            this.DataBaseViewer.Size = new System.Drawing.Size(392, 174);
            this.DataBaseViewer.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 36);
            this.button1.TabIndex = 14;
            this.button1.Text = "Close Current Database";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Value";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(198, 238);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 36);
            this.button2.TabIndex = 15;
            this.button2.Text = "Read Database Entry";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // ZenithDBTestClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DataBaseViewer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.valueField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.delKeyField);
            this.Controls.Add(this.deleteEntryBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.keyField);
            this.Controls.Add(this.addDbEntryBtn);
            this.Controls.Add(this.openDbBtn);
            this.Controls.Add(this.createDbBtn);
            this.Name = "ZenithDBTestClient";
            this.Text = "ZenithDB Test Interface";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createDbBtn;
        private System.Windows.Forms.Button openDbBtn;
        private System.Windows.Forms.Button addDbEntryBtn;
        private System.Windows.Forms.TextBox keyField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox delKeyField;
        private System.Windows.Forms.Button deleteEntryBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox valueField;
        private System.Windows.Forms.TextBox DataBaseViewer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
    }
}

