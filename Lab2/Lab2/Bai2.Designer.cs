namespace Lab2
{
    partial class Bai2
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.size = new System.Windows.Forms.TextBox();
            this.url = new System.Windows.Forms.TextBox();
            this.linecount = new System.Windows.Forms.TextBox();
            this.wordcount = new System.Windows.Forms.TextBox();
            this.charcount = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(370, 13);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(418, 425);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "File Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "URL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Line count";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Word count";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Character count";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(175, 54);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(189, 22);
            this.name.TabIndex = 7;
            // 
            // size
            // 
            this.size.Location = new System.Drawing.Point(175, 118);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(189, 22);
            this.size.TabIndex = 8;
            // 
            // url
            // 
            this.url.Location = new System.Drawing.Point(175, 186);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(189, 22);
            this.url.TabIndex = 9;
            // 
            // linecount
            // 
            this.linecount.Location = new System.Drawing.Point(175, 248);
            this.linecount.Name = "linecount";
            this.linecount.Size = new System.Drawing.Size(189, 22);
            this.linecount.TabIndex = 10;
            // 
            // wordcount
            // 
            this.wordcount.Location = new System.Drawing.Point(175, 312);
            this.wordcount.Name = "wordcount";
            this.wordcount.Size = new System.Drawing.Size(189, 22);
            this.wordcount.TabIndex = 11;
            // 
            // charcount
            // 
            this.charcount.Location = new System.Drawing.Point(175, 376);
            this.charcount.Name = "charcount";
            this.charcount.Size = new System.Drawing.Size(189, 22);
            this.charcount.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 36);
            this.button1.TabIndex = 13;
            this.button1.Text = "Đọc FIle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.charcount);
            this.Controls.Add(this.wordcount);
            this.Controls.Add(this.linecount);
            this.Controls.Add(this.url);
            this.Controls.Add(this.size);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Bai2";
            this.Text = "Bai2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox size;
        private System.Windows.Forms.TextBox url;
        private System.Windows.Forms.TextBox linecount;
        private System.Windows.Forms.TextBox wordcount;
        private System.Windows.Forms.TextBox charcount;
        private System.Windows.Forms.Button button1;
    }
}