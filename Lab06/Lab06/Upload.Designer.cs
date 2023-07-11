namespace Lab06
{
    partial class Upload
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
            labelFile = new Label();
            textBox1 = new TextBox();
            buttonBrowse = new Button();
            buttonUpload = new Button();
            label1 = new Label();
            status = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            SuspendLayout();
            // 
            // labelFile
            // 
            labelFile.AutoSize = true;
            labelFile.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelFile.Location = new Point(166, 33);
            labelFile.Name = "labelFile";
            labelFile.Size = new Size(50, 28);
            labelFile.TabIndex = 0;
            labelFile.Text = "File:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(230, 29);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(362, 34);
            textBox1.TabIndex = 1;
            // 
            // buttonBrowse
            // 
            buttonBrowse.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBrowse.Location = new Point(626, 29);
            buttonBrowse.Margin = new Padding(3, 4, 3, 4);
            buttonBrowse.Name = "buttonBrowse";
            buttonBrowse.Size = new Size(39, 31);
            buttonBrowse.TabIndex = 2;
            buttonBrowse.Text = "...";
            buttonBrowse.UseVisualStyleBackColor = true;
            buttonBrowse.Click += buttonBrowse_Click;
            // 
            // buttonUpload
            // 
            buttonUpload.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUpload.Location = new Point(709, 29);
            buttonUpload.Margin = new Padding(3, 4, 3, 4);
            buttonUpload.Name = "buttonUpload";
            buttonUpload.Size = new Size(160, 59);
            buttonUpload.TabIndex = 3;
            buttonUpload.Text = "Upload";
            buttonUpload.UseVisualStyleBackColor = true;
            buttonUpload.Click += buttonUpload_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(54, 91);
            label1.Name = "label1";
            label1.Size = new Size(211, 28);
            label1.TabIndex = 4;
            label1.Text = "(Chon file de upload)";
            // 
            // status
            // 
            status.AutoSize = true;
            status.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            status.Location = new Point(409, 308);
            status.Name = "status";
            status.Size = new Size(0, 28);
            status.TabIndex = 6;
            status.Click += label2_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            flowLayoutPanel1.Location = new Point(54, 153);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(618, 345);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(709, 123);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(160, 59);
            button1.TabIndex = 8;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Upload
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(button1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(status);
            Controls.Add(label1);
            Controls.Add(buttonUpload);
            Controls.Add(buttonBrowse);
            Controls.Add(textBox1);
            Controls.Add(labelFile);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Upload";
            Text = "Upload";
            Load += Upload_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFile;
        private TextBox textBox1;
        private Button buttonBrowse;
        private Button buttonUpload;
        private Label label1;
        private Label status;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
    }
}