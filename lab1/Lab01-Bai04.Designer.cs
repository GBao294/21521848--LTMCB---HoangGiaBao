namespace Lab01
{
    partial class Lab01_Bai04
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
            labelSoTienCanDoi = new Label();
            labelSoTienDaDoi = new Label();
            labelTyGiaQuyDoi = new Label();
            textBoxSoTienCanDoi = new TextBox();
            textBoxSoTienDaDoi = new TextBox();
            textBoxTyGiaQuyDoi = new TextBox();
            buttonChuyenDoi = new Button();
            comboBoxChonLoaiTien = new ComboBox();
            SuspendLayout();
            // 
            // labelSoTienCanDoi
            // 
            labelSoTienCanDoi.AutoSize = true;
            labelSoTienCanDoi.Location = new Point(22, 30);
            labelSoTienCanDoi.Margin = new Padding(2, 0, 2, 0);
            labelSoTienCanDoi.Name = "labelSoTienCanDoi";
            labelSoTienCanDoi.Size = new Size(85, 15);
            labelSoTienCanDoi.TabIndex = 0;
            labelSoTienCanDoi.Text = "Số tiền cần đổi";
            // 
            // labelSoTienDaDoi
            // 
            labelSoTienDaDoi.AutoSize = true;
            labelSoTienDaDoi.Location = new Point(22, 125);
            labelSoTienDaDoi.Margin = new Padding(2, 0, 2, 0);
            labelSoTienDaDoi.Name = "labelSoTienDaDoi";
            labelSoTienDaDoi.Size = new Size(79, 15);
            labelSoTienDaDoi.TabIndex = 1;
            labelSoTienDaDoi.Text = "Số tiền đã đổi";
            // 
            // labelTyGiaQuyDoi
            // 
            labelTyGiaQuyDoi.AutoSize = true;
            labelTyGiaQuyDoi.Location = new Point(22, 184);
            labelTyGiaQuyDoi.Margin = new Padding(2, 0, 2, 0);
            labelTyGiaQuyDoi.Name = "labelTyGiaQuyDoi";
            labelTyGiaQuyDoi.Size = new Size(81, 15);
            labelTyGiaQuyDoi.TabIndex = 2;
            labelTyGiaQuyDoi.Text = "Tỷ giá quy đổi";
            // 
            // textBoxSoTienCanDoi
            // 
            textBoxSoTienCanDoi.Location = new Point(126, 28);
            textBoxSoTienCanDoi.Margin = new Padding(2);
            textBoxSoTienCanDoi.Name = "textBoxSoTienCanDoi";
            textBoxSoTienCanDoi.Size = new Size(104, 23);
            textBoxSoTienCanDoi.TabIndex = 4;
            // 
            // textBoxSoTienDaDoi
            // 
            textBoxSoTienDaDoi.Location = new Point(126, 124);
            textBoxSoTienDaDoi.Margin = new Padding(2);
            textBoxSoTienDaDoi.Name = "textBoxSoTienDaDoi";
            textBoxSoTienDaDoi.ReadOnly = true;
            textBoxSoTienDaDoi.Size = new Size(104, 23);
            textBoxSoTienDaDoi.TabIndex = 5;
            // 
            // textBoxTyGiaQuyDoi
            // 
            textBoxTyGiaQuyDoi.BackColor = SystemColors.ButtonFace;
            textBoxTyGiaQuyDoi.BorderStyle = BorderStyle.None;
            textBoxTyGiaQuyDoi.Location = new Point(126, 183);
            textBoxTyGiaQuyDoi.Margin = new Padding(2);
            textBoxTyGiaQuyDoi.Name = "textBoxTyGiaQuyDoi";
            textBoxTyGiaQuyDoi.Size = new Size(120, 16);
            textBoxTyGiaQuyDoi.TabIndex = 6;
            // 
            // buttonChuyenDoi
            // 
            buttonChuyenDoi.Location = new Point(22, 66);
            buttonChuyenDoi.Margin = new Padding(2);
            buttonChuyenDoi.Name = "buttonChuyenDoi";
            buttonChuyenDoi.Size = new Size(184, 20);
            buttonChuyenDoi.TabIndex = 7;
            buttonChuyenDoi.Text = "Chuyển đổi";
            buttonChuyenDoi.UseVisualStyleBackColor = true;
            buttonChuyenDoi.Click += buttonChuyenDoi_Click;
            // 
            // comboBoxChonLoaiTien
            // 
            comboBoxChonLoaiTien.FormattingEnabled = true;
            comboBoxChonLoaiTien.Items.AddRange(new object[] { "USD (Đô-la Mỹ)", "EUR (EURO)", "GBP (Bảng Anh)", "SGD (Đô-la Singapore)", "JPY (Yên Nhật)" });
            comboBoxChonLoaiTien.Location = new Point(279, 26);
            comboBoxChonLoaiTien.Margin = new Padding(2);
            comboBoxChonLoaiTien.Name = "comboBoxChonLoaiTien";
            comboBoxChonLoaiTien.Size = new Size(125, 23);
            comboBoxChonLoaiTien.TabIndex = 8;
            // 
            // Lab01_Bai04
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 225);
            Controls.Add(comboBoxChonLoaiTien);
            Controls.Add(buttonChuyenDoi);
            Controls.Add(textBoxTyGiaQuyDoi);
            Controls.Add(textBoxSoTienDaDoi);
            Controls.Add(textBoxSoTienCanDoi);
            Controls.Add(labelTyGiaQuyDoi);
            Controls.Add(labelSoTienDaDoi);
            Controls.Add(labelSoTienCanDoi);
            Margin = new Padding(2);
            Name = "Lab01_Bai04";
            Text = "Lab01_Bai04";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSoTienCanDoi;
        private Label labelSoTienDaDoi;
        private Label labelTyGiaQuyDoi;
        private TextBox textBoxSoTienCanDoi;
        private TextBox textBoxSoTienDaDoi;
        private TextBox textBoxTyGiaQuyDoi;
        private Button buttonChuyenDoi;
        private ComboBox comboBoxChonLoaiTien;
    }
}