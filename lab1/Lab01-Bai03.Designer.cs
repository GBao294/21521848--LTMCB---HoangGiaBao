namespace Lab01
{
    partial class Lab01_Bai03
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
            textBoxNhapSoNguyen = new TextBox();
            labelNhapSoNguyen = new Label();
            labelKetQua = new Label();
            textBoxKetQua = new TextBox();
            buttonDoc = new Button();
            buttonXoa = new Button();
            buttonThoat = new Button();
            SuspendLayout();
            // 
            // textBoxNhapSoNguyen
            // 
            textBoxNhapSoNguyen.Location = new Point(224, 20);
            textBoxNhapSoNguyen.Margin = new Padding(2, 2, 2, 2);
            textBoxNhapSoNguyen.Name = "textBoxNhapSoNguyen";
            textBoxNhapSoNguyen.Size = new Size(104, 23);
            textBoxNhapSoNguyen.TabIndex = 0;
            // 
            // labelNhapSoNguyen
            // 
            labelNhapSoNguyen.AutoSize = true;
            labelNhapSoNguyen.Location = new Point(38, 22);
            labelNhapSoNguyen.Margin = new Padding(2, 0, 2, 0);
            labelNhapSoNguyen.Name = "labelNhapSoNguyen";
            labelNhapSoNguyen.Size = new Size(149, 15);
            labelNhapSoNguyen.TabIndex = 1;
            labelNhapSoNguyen.Text = "Nhập số nguyên từ 0 đến 9";
            // 
            // labelKetQua
            // 
            labelKetQua.AutoSize = true;
            labelKetQua.Location = new Point(38, 110);
            labelKetQua.Margin = new Padding(2, 0, 2, 0);
            labelKetQua.Name = "labelKetQua";
            labelKetQua.Size = new Size(47, 15);
            labelKetQua.TabIndex = 2;
            labelKetQua.Text = "Kết quả";
            // 
            // textBoxKetQua
            // 
            textBoxKetQua.Location = new Point(38, 146);
            textBoxKetQua.Margin = new Padding(2, 2, 2, 2);
            textBoxKetQua.Name = "textBoxKetQua";
            textBoxKetQua.ReadOnly = true;
            textBoxKetQua.Size = new Size(104, 23);
            textBoxKetQua.TabIndex = 3;
            // 
            // buttonDoc
            // 
            buttonDoc.Location = new Point(360, 30);
            buttonDoc.Margin = new Padding(2, 2, 2, 2);
            buttonDoc.Name = "buttonDoc";
            buttonDoc.Size = new Size(76, 20);
            buttonDoc.TabIndex = 4;
            buttonDoc.Text = "Đọc";
            buttonDoc.UseVisualStyleBackColor = true;
            buttonDoc.Click += button1_Click;
            // 
            // buttonXoa
            // 
            buttonXoa.Location = new Point(360, 83);
            buttonXoa.Margin = new Padding(2, 2, 2, 2);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(76, 20);
            buttonXoa.TabIndex = 5;
            buttonXoa.Text = "Xóa";
            buttonXoa.UseVisualStyleBackColor = true;
            buttonXoa.Click += button2_Click;
            // 
            // buttonThoat
            // 
            buttonThoat.Location = new Point(360, 135);
            buttonThoat.Margin = new Padding(2, 2, 2, 2);
            buttonThoat.Name = "buttonThoat";
            buttonThoat.Size = new Size(76, 20);
            buttonThoat.TabIndex = 6;
            buttonThoat.Text = "Thoát";
            buttonThoat.UseVisualStyleBackColor = true;
            buttonThoat.Click += button3_Click;
            // 
            // Lab01_Bai03
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 225);
            Controls.Add(buttonThoat);
            Controls.Add(buttonXoa);
            Controls.Add(buttonDoc);
            Controls.Add(textBoxKetQua);
            Controls.Add(labelKetQua);
            Controls.Add(labelNhapSoNguyen);
            Controls.Add(textBoxNhapSoNguyen);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Lab01_Bai03";
            Text = "Lab01_Bai03";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNhapSoNguyen;
        private Label labelNhapSoNguyen;
        private Label labelKetQua;
        private TextBox textBoxKetQua;
        private Button buttonDoc;
        private Button buttonXoa;
        private Button buttonThoat;
    }
}