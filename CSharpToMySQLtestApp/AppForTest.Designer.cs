namespace CSharpToMySQLtestApp
{
    partial class AppForTest
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTag = new System.Windows.Forms.TextBox();
            this.textBoxPlace = new System.Windows.Forms.TextBox();
            this.buttonDodajUBazu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDatasource = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxDatabase = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonTestConn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tag (hex) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Place (0-6) :";
            // 
            // textBoxTag
            // 
            this.textBoxTag.Location = new System.Drawing.Point(355, 116);
            this.textBoxTag.Name = "textBoxTag";
            this.textBoxTag.Size = new System.Drawing.Size(355, 38);
            this.textBoxTag.TabIndex = 5;
            // 
            // textBoxPlace
            // 
            this.textBoxPlace.Location = new System.Drawing.Point(355, 185);
            this.textBoxPlace.Name = "textBoxPlace";
            this.textBoxPlace.Size = new System.Drawing.Size(355, 38);
            this.textBoxPlace.TabIndex = 6;
            // 
            // buttonDodajUBazu
            // 
            this.buttonDodajUBazu.Location = new System.Drawing.Point(355, 258);
            this.buttonDodajUBazu.Name = "buttonDodajUBazu";
            this.buttonDodajUBazu.Size = new System.Drawing.Size(355, 91);
            this.buttonDodajUBazu.TabIndex = 7;
            this.buttonDodajUBazu.Text = "Dodaj u bazu sada!";
            this.buttonDodajUBazu.UseVisualStyleBackColor = true;
            this.buttonDodajUBazu.Click += new System.EventHandler(this.buttonDodajUBazu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1132, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(342, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Postavi konekciju i testiraj";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(904, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Datasource:";
            // 
            // textBoxDatasource
            // 
            this.textBoxDatasource.Location = new System.Drawing.Point(1138, 116);
            this.textBoxDatasource.Name = "textBoxDatasource";
            this.textBoxDatasource.Size = new System.Drawing.Size(506, 38);
            this.textBoxDatasource.TabIndex = 10;
            this.textBoxDatasource.Text = "127.0.0.1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(904, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "Port:";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(1138, 188);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(506, 38);
            this.textBoxPort.TabIndex = 12;
            this.textBoxPort.Text = "3306";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(904, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 32);
            this.label6.TabIndex = 13;
            this.label6.Text = "Username:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(1138, 267);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(506, 38);
            this.textBoxUsername.TabIndex = 14;
            this.textBoxUsername.Text = "root";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(1138, 344);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(506, 38);
            this.textBoxPassword.TabIndex = 15;
            // 
            // textBoxDatabase
            // 
            this.textBoxDatabase.Location = new System.Drawing.Point(1138, 428);
            this.textBoxDatabase.Name = "textBoxDatabase";
            this.textBoxDatabase.Size = new System.Drawing.Size(506, 38);
            this.textBoxDatabase.TabIndex = 16;
            this.textBoxDatabase.Text = "diplomski";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(904, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 32);
            this.label7.TabIndex = 17;
            this.label7.Text = "Password:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(904, 434);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 32);
            this.label8.TabIndex = 18;
            this.label8.Text = "Database:";
            // 
            // buttonTestConn
            // 
            this.buttonTestConn.Location = new System.Drawing.Point(1138, 531);
            this.buttonTestConn.Name = "buttonTestConn";
            this.buttonTestConn.Size = new System.Drawing.Size(506, 91);
            this.buttonTestConn.TabIndex = 19;
            this.buttonTestConn.Text = "Testiraj s ovom konekcijom!";
            this.buttonTestConn.UseVisualStyleBackColor = true;
            this.buttonTestConn.Click += new System.EventHandler(this.buttonTestConn_Click);
            // 
            // AppForTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1725, 841);
            this.Controls.Add(this.buttonTestConn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxDatabase);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxDatasource);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonDodajUBazu);
            this.Controls.Add(this.textBoxPlace);
            this.Controls.Add(this.textBoxTag);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AppForTest";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.Text = "AppForTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTag;
        private System.Windows.Forms.TextBox textBoxPlace;
        private System.Windows.Forms.Button buttonDodajUBazu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDatasource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxDatabase;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonTestConn;
    }
}

