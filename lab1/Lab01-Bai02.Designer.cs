namespace Lab01
{
    partial class Form1
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
            textBoxSoThuNhat = new TextBox();
            textBoxSoThuHai = new TextBox();
            textBoxSoThuBa = new TextBox();
            labelSoThuNhat = new Label();
            labelSoThuHai = new Label();
            labelSoThuBa = new Label();
            buttonTim = new Button();
            buttonXoa = new Button();
            buttonThoat = new Button();
            textBoxSoNhoNhat = new TextBox();
            textBoxSoLonNhat = new TextBox();
            labelSoLonNhat = new Label();
            labelSoNhoNhat = new Label();
            SuspendLayout();
            // 
            // textBoxSoThuNhat
            // 
            textBoxSoThuNhat.Location = new Point(20, 43);
            textBoxSoThuNhat.Margin = new Padding(2, 2, 2, 2);
            textBoxSoThuNhat.Name = "textBoxSoThuNhat";
            textBoxSoThuNhat.Size = new Size(104, 23);
            textBoxSoThuNhat.TabIndex = 0;
            // 
            // textBoxSoThuHai
            // 
            textBoxSoThuHai.Location = new Point(180, 43);
            textBoxSoThuHai.Margin = new Padding(2, 2, 2, 2);
            textBoxSoThuHai.Name = "textBoxSoThuHai";
            textBoxSoThuHai.Size = new Size(104, 23);
            textBoxSoThuHai.TabIndex = 1;
            // 
            // textBoxSoThuBa
            // 
            textBoxSoThuBa.Location = new Point(333, 43);
            textBoxSoThuBa.Margin = new Padding(2, 2, 2, 2);
            textBoxSoThuBa.Name = "textBoxSoThuBa";
            textBoxSoThuBa.Size = new Size(104, 23);
            textBoxSoThuBa.TabIndex = 2;
            // 
            // labelSoThuNhat
            // 
            labelSoThuNhat.AutoSize = true;
            labelSoThuNhat.Location = new Point(32, 14);
            labelSoThuNhat.Margin = new Padding(2, 0, 2, 0);
            labelSoThuNhat.Name = "labelSoThuNhat";
            labelSoThuNhat.Size = new Size(68, 15);
            labelSoThuNhat.TabIndex = 3;
            labelSoThuNhat.Text = "Số thứ nhất";
            // 
            // labelSoThuHai
            // 
            labelSoThuHai.AutoSize = true;
            labelSoThuHai.Location = new Point(195, 14);
            labelSoThuHai.Margin = new Padding(2, 0, 2, 0);
            labelSoThuHai.Name = "labelSoThuHai";
            labelSoThuHai.Size = new Size(60, 15);
            labelSoThuHai.TabIndex = 4;
            labelSoThuHai.Text = "Số thứ hai";
            // 
            // labelSoThuBa
            // 
            labelSoThuBa.AutoSize = true;
            labelSoThuBa.Location = new Point(355, 14);
            labelSoThuBa.Margin = new Padding(2, 0, 2, 0);
            labelSoThuBa.Name = "labelSoThuBa";
            labelSoThuBa.Size = new Size(57, 15);
            labelSoThuBa.TabIndex = 5;
            labelSoThuBa.Text = "Số thứ ba";
            // 
            // buttonTim
            // 
            buttonTim.Location = new Point(46, 108);
            buttonTim.Margin = new Padding(2, 2, 2, 2);
            buttonTim.Name = "buttonTim";
            buttonTim.Size = new Size(76, 20);
            buttonTim.TabIndex = 6;
            buttonTim.Text = "Tìm";
            buttonTim.UseVisualStyleBackColor = true;
            buttonTim.Click += button1_Click;
            // 
            // buttonXoa
            // 
            buttonXoa.Location = new Point(195, 108);
            buttonXoa.Margin = new Padding(2, 2, 2, 2);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(76, 20);
            buttonXoa.TabIndex = 7;
            buttonXoa.Text = "Xóa";
            buttonXoa.UseVisualStyleBackColor = true;
            buttonXoa.Click += button2_Click;
            // 
            // buttonThoat
            // 
            buttonThoat.Location = new Point(349, 108);
            buttonThoat.Margin = new Padding(2, 2, 2, 2);
            buttonThoat.Name = "buttonThoat";
            buttonThoat.Size = new Size(76, 20);
            buttonThoat.TabIndex = 8;
            buttonThoat.Text = "Thoát";
            buttonThoat.UseVisualStyleBackColor = true;
            buttonThoat.Click += button3_Click;
            // 
            // textBoxSoNhoNhat
            // 
            textBoxSoNhoNhat.Location = new Point(331, 188);
            textBoxSoNhoNhat.Margin = new Padding(2, 2, 2, 2);
            textBoxSoNhoNhat.Name = "textBoxSoNhoNhat";
            textBoxSoNhoNhat.ReadOnly = true;
            textBoxSoNhoNhat.Size = new Size(104, 23);
            textBoxSoNhoNhat.TabIndex = 9;
            // 
            // textBoxSoLonNhat
            // 
            textBoxSoLonNhat.Location = new Point(84, 188);
            textBoxSoLonNhat.Margin = new Padding(2, 2, 2, 2);
            textBoxSoLonNhat.Name = "textBoxSoLonNhat";
            textBoxSoLonNhat.ReadOnly = true;
            textBoxSoLonNhat.Size = new Size(104, 23);
            textBoxSoLonNhat.TabIndex = 10;
            // 
            // labelSoLonNhat
            // 
            labelSoLonNhat.AutoSize = true;
            labelSoLonNhat.Location = new Point(10, 189);
            labelSoLonNhat.Margin = new Padding(2, 0, 2, 0);
            labelSoLonNhat.Name = "labelSoLonNhat";
            labelSoLonNhat.Size = new Size(67, 15);
            labelSoLonNhat.TabIndex = 11;
            labelSoLonNhat.Text = "Số lớn nhất";
            // 
            // labelSoNhoNhat
            // 
            labelSoNhoNhat.AutoSize = true;
            labelSoNhoNhat.Location = new Point(254, 189);
            labelSoNhoNhat.Margin = new Padding(2, 0, 2, 0);
            labelSoNhoNhat.Name = "labelSoNhoNhat";
            labelSoNhoNhat.Size = new Size(71, 15);
            labelSoNhoNhat.TabIndex = 12;
            labelSoNhoNhat.Text = "Số nhỏ nhất";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 225);
            Controls.Add(labelSoNhoNhat);
            Controls.Add(labelSoLonNhat);
            Controls.Add(textBoxSoLonNhat);
            Controls.Add(textBoxSoNhoNhat);
            Controls.Add(buttonThoat);
            Controls.Add(buttonXoa);
            Controls.Add(buttonTim);
            Controls.Add(labelSoThuBa);
            Controls.Add(labelSoThuHai);
            Controls.Add(labelSoThuNhat);
            Controls.Add(textBoxSoThuBa);
            Controls.Add(textBoxSoThuHai);
            Controls.Add(textBoxSoThuNhat);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Lab01-Bai02";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxSoThuNhat;
        private TextBox textBoxSoThuHai;
        private TextBox textBoxSoThuBa;
        private Label labelSoThuNhat;
        private Label labelSoThuHai;
        private Label labelSoThuBa;
        private Button buttonTim;
        private Button buttonXoa;
        private Button buttonThoat;
        private TextBox textBoxSoNhoNhat;
        private TextBox textBoxSoLonNhat;
        private Label labelSoLonNhat;
        private Label labelSoNhoNhat;
    }
}