namespace Lab06
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelIP = new Label();
            labelUsername = new Label();
            labelPassword = new Label();
            labelRemoteSite = new Label();
            textBoxIP = new TextBox();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            buttonConnect = new Button();
            buttonUpload = new Button();
            buttonDownload = new Button();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // labelIP
            // 
            labelIP.AutoSize = true;
            labelIP.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelIP.Location = new Point(58, 35);
            labelIP.Name = "labelIP";
            labelIP.Size = new Size(116, 23);
            labelIP.TabIndex = 0;
            labelIP.Text = "IP FTP Server";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelUsername.Location = new Point(58, 87);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(92, 23);
            labelUsername.TabIndex = 1;
            labelUsername.Text = "UserName";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelPassword.Location = new Point(58, 148);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(85, 23);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Password";
            // 
            // labelRemoteSite
            // 
            labelRemoteSite.AutoSize = true;
            labelRemoteSite.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelRemoteSite.Location = new Point(56, 274);
            labelRemoteSite.Name = "labelRemoteSite";
            labelRemoteSite.Size = new Size(108, 23);
            labelRemoteSite.TabIndex = 3;
            labelRemoteSite.Text = "Remote Site";
            // 
            // textBoxIP
            // 
            textBoxIP.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxIP.Location = new Point(189, 35);
            textBoxIP.Margin = new Padding(3, 4, 3, 4);
            textBoxIP.Name = "textBoxIP";
            textBoxIP.Size = new Size(319, 30);
            textBoxIP.TabIndex = 4;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxUsername.Location = new Point(189, 87);
            textBoxUsername.Margin = new Padding(3, 4, 3, 4);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(319, 30);
            textBoxUsername.TabIndex = 5;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(189, 142);
            textBoxPassword.Margin = new Padding(3, 4, 3, 4);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(319, 30);
            textBoxPassword.TabIndex = 6;
            // 
            // buttonConnect
            // 
            buttonConnect.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonConnect.Location = new Point(58, 194);
            buttonConnect.Margin = new Padding(3, 4, 3, 4);
            buttonConnect.Name = "buttonConnect";
            buttonConnect.Size = new Size(127, 65);
            buttonConnect.TabIndex = 7;
            buttonConnect.Text = "Connect";
            buttonConnect.UseVisualStyleBackColor = true;
            buttonConnect.Click += buttonConnect_Click;
            // 
            // buttonUpload
            // 
            buttonUpload.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUpload.Location = new Point(777, 298);
            buttonUpload.Margin = new Padding(3, 4, 3, 4);
            buttonUpload.Name = "buttonUpload";
            buttonUpload.Size = new Size(111, 57);
            buttonUpload.TabIndex = 8;
            buttonUpload.Text = "Upload";
            buttonUpload.UseVisualStyleBackColor = true;
            buttonUpload.Click += buttonUpload_Click;
            // 
            // buttonDownload
            // 
            buttonDownload.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDownload.Location = new Point(777, 425);
            buttonDownload.Margin = new Padding(3, 4, 3, 4);
            buttonDownload.Name = "buttonDownload";
            buttonDownload.Size = new Size(111, 57);
            buttonDownload.TabIndex = 9;
            buttonDownload.Text = "Download";
            buttonDownload.UseVisualStyleBackColor = true;
            buttonDownload.Click += buttonDownload_Click;
            // 
            // listView1
            // 
            listView1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            listView1.Location = new Point(12, 298);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(741, 183);
            listView1.TabIndex = 10;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(listView1);
            Controls.Add(buttonDownload);
            Controls.Add(buttonUpload);
            Controls.Add(buttonConnect);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(textBoxIP);
            Controls.Add(labelRemoteSite);
            Controls.Add(labelPassword);
            Controls.Add(labelUsername);
            Controls.Add(labelIP);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelIP;
        private Label labelUsername;
        private Label labelPassword;
        private Label labelRemoteSite;
        private TextBox textBoxIP;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Button buttonConnect;
        private Button buttonUpload;
        private Button buttonDownload;
        private ListView listView1;
    }
}