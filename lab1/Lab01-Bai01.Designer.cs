namespace Lab01
{
    partial class Form2
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
            textBoxKetQua = new TextBox();
            labelSoThuNhat = new Label();
            labelSoThuHai = new Label();
            labelKetQua = new Label();
            buttonTinh = new Button();
            SuspendLayout();
            // 
            // textBoxSoThuNhat
            // 
            textBoxSoThuNhat.Location = new Point(171, 33);
            textBoxSoThuNhat.Margin = new Padding(2, 2, 2, 2);
            textBoxSoThuNhat.Name = "textBoxSoThuNhat";
            textBoxSoThuNhat.Size = new Size(190, 23);
            textBoxSoThuNhat.TabIndex = 0;
            // 
            // textBoxSoThuHai
            // 
            textBoxSoThuHai.Location = new Point(171, 82);
            textBoxSoThuHai.Margin = new Padding(2, 2, 2, 2);
            textBoxSoThuHai.Name = "textBoxSoThuHai";
            textBoxSoThuHai.Size = new Size(190, 23);
            textBoxSoThuHai.TabIndex = 1;
            // 
            // textBoxKetQua
            // 
            textBoxKetQua.Location = new Point(171, 126);
            textBoxKetQua.Margin = new Padding(2, 2, 2, 2);
            textBoxKetQua.Name = "textBoxKetQua";
            textBoxKetQua.ReadOnly = true;
            textBoxKetQua.Size = new Size(190, 23);
            textBoxKetQua.TabIndex = 2;
            // 
            // labelSoThuNhat
            // 
            labelSoThuNhat.AutoSize = true;
            labelSoThuNhat.Location = new Point(94, 34);
            labelSoThuNhat.Margin = new Padding(2, 0, 2, 0);
            labelSoThuNhat.Name = "labelSoThuNhat";
            labelSoThuNhat.Size = new Size(68, 15);
            labelSoThuNhat.TabIndex = 3;
            labelSoThuNhat.Text = "Số thứ nhất";
            // 
            // labelSoThuHai
            // 
            labelSoThuHai.AutoSize = true;
            labelSoThuHai.Location = new Point(94, 82);
            labelSoThuHai.Margin = new Padding(2, 0, 2, 0);
            labelSoThuHai.Name = "labelSoThuHai";
            labelSoThuHai.Size = new Size(60, 15);
            labelSoThuHai.TabIndex = 4;
            labelSoThuHai.Text = "Số thứ hai";
            // 
            // labelKetQua
            // 
            labelKetQua.AutoSize = true;
            labelKetQua.Location = new Point(94, 126);
            labelKetQua.Margin = new Padding(2, 0, 2, 0);
            labelKetQua.Name = "labelKetQua";
            labelKetQua.Size = new Size(47, 15);
            labelKetQua.TabIndex = 5;
            labelKetQua.Text = "Kết quả";
            // 
            // buttonTinh
            // 
            buttonTinh.Location = new Point(345, 176);
            buttonTinh.Margin = new Padding(2, 2, 2, 2);
            buttonTinh.Name = "buttonTinh";
            buttonTinh.Size = new Size(76, 20);
            buttonTinh.TabIndex = 6;
            buttonTinh.Text = "Tính";
            buttonTinh.UseVisualStyleBackColor = true;
            buttonTinh.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 225);
            Controls.Add(buttonTinh);
            Controls.Add(labelKetQua);
            Controls.Add(labelSoThuHai);
            Controls.Add(labelSoThuNhat);
            Controls.Add(textBoxKetQua);
            Controls.Add(textBoxSoThuHai);
            Controls.Add(textBoxSoThuNhat);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form2";
            Text = "Lab01-Bai01";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxSoThuNhat;
        private TextBox textBoxSoThuHai;
        private TextBox textBoxKetQua;
        private Label labelSoThuNhat;
        private Label labelSoThuHai;
        private Label labelKetQua;
        private Button buttonTinh;
    }
}