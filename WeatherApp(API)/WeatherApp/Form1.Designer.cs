namespace WeatherApp
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
            this.Close = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.city = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sunset = new System.Windows.Forms.Label();
            this.ss = new System.Windows.Forms.Label();
            this.sunrise = new System.Windows.Forms.Label();
            this.windspeed = new System.Windows.Forms.Label();
            this.ws = new System.Windows.Forms.Label();
            this.sr = new System.Windows.Forms.Label();
            this.condi = new System.Windows.Forms.Label();
            this.hu = new System.Windows.Forms.Label();
            this.pr = new System.Windows.Forms.Label();
            this.P_icon = new System.Windows.Forms.PictureBox();
            this.country = new System.Windows.Forms.Label();
            this.Temp = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FL = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.P_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.ForeColor = System.Drawing.Color.Gainsboro;
            this.Close.Location = new System.Drawing.Point(1105, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(47, 38);
            this.Close.TabIndex = 0;
            this.Close.Text = "X";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(753, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 68);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // city
            // 
            this.city.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city.Location = new System.Drawing.Point(433, 123);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(287, 39);
            this.city.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(296, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 62);
            this.label1.TabIndex = 3;
            this.label1.Text = "CITY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sunset
            // 
            this.sunset.BackColor = System.Drawing.Color.Transparent;
            this.sunset.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunset.ForeColor = System.Drawing.Color.White;
            this.sunset.Location = new System.Drawing.Point(491, 579);
            this.sunset.Name = "sunset";
            this.sunset.Size = new System.Drawing.Size(535, 34);
            this.sunset.TabIndex = 4;
            this.sunset.Text = "N/A";
            this.sunset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ss
            // 
            this.ss.BackColor = System.Drawing.Color.Transparent;
            this.ss.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ss.ForeColor = System.Drawing.Color.White;
            this.ss.Location = new System.Drawing.Point(356, 579);
            this.ss.Name = "ss";
            this.ss.Size = new System.Drawing.Size(111, 34);
            this.ss.TabIndex = 5;
            this.ss.Text = "Sunset:";
            this.ss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sunrise
            // 
            this.sunrise.BackColor = System.Drawing.Color.Transparent;
            this.sunrise.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunrise.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.sunrise.Location = new System.Drawing.Point(491, 500);
            this.sunrise.Name = "sunrise";
            this.sunrise.Size = new System.Drawing.Size(535, 34);
            this.sunrise.TabIndex = 7;
            this.sunrise.Text = "N/A";
            this.sunrise.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // windspeed
            // 
            this.windspeed.BackColor = System.Drawing.Color.Transparent;
            this.windspeed.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windspeed.ForeColor = System.Drawing.Color.White;
            this.windspeed.Location = new System.Drawing.Point(347, 429);
            this.windspeed.Name = "windspeed";
            this.windspeed.Size = new System.Drawing.Size(153, 34);
            this.windspeed.TabIndex = 8;
            this.windspeed.Text = "N/A";
            this.windspeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ws
            // 
            this.ws.BackColor = System.Drawing.Color.Transparent;
            this.ws.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ws.ForeColor = System.Drawing.Color.White;
            this.ws.Location = new System.Drawing.Point(166, 429);
            this.ws.Name = "ws";
            this.ws.Size = new System.Drawing.Size(175, 34);
            this.ws.TabIndex = 9;
            this.ws.Text = "WindSpeed:";
            this.ws.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sr
            // 
            this.sr.BackColor = System.Drawing.Color.Transparent;
            this.sr.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sr.ForeColor = System.Drawing.Color.White;
            this.sr.Location = new System.Drawing.Point(347, 500);
            this.sr.Name = "sr";
            this.sr.Size = new System.Drawing.Size(129, 34);
            this.sr.TabIndex = 10;
            this.sr.Text = "Sunrise:";
            this.sr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // condi
            // 
            this.condi.BackColor = System.Drawing.Color.Transparent;
            this.condi.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.condi.ForeColor = System.Drawing.Color.White;
            this.condi.Location = new System.Drawing.Point(521, 290);
            this.condi.Name = "condi";
            this.condi.Size = new System.Drawing.Size(199, 34);
            this.condi.TabIndex = 11;
            this.condi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // hu
            // 
            this.hu.BackColor = System.Drawing.Color.Transparent;
            this.hu.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hu.ForeColor = System.Drawing.Color.White;
            this.hu.Location = new System.Drawing.Point(656, 429);
            this.hu.Name = "hu";
            this.hu.Size = new System.Drawing.Size(118, 34);
            this.hu.TabIndex = 12;
            this.hu.Text = "N/A";
            this.hu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hu.Click += new System.EventHandler(this.pr_Click);
            // 
            // pr
            // 
            this.pr.BackColor = System.Drawing.Color.Transparent;
            this.pr.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pr.ForeColor = System.Drawing.Color.White;
            this.pr.Location = new System.Drawing.Point(506, 429);
            this.pr.Name = "pr";
            this.pr.Size = new System.Drawing.Size(144, 34);
            this.pr.TabIndex = 13;
            this.pr.Text = "Humidity:";
            this.pr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // P_icon
            // 
            this.P_icon.BackColor = System.Drawing.Color.Transparent;
            this.P_icon.Location = new System.Drawing.Point(383, 212);
            this.P_icon.Name = "P_icon";
            this.P_icon.Size = new System.Drawing.Size(120, 98);
            this.P_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.P_icon.TabIndex = 14;
            this.P_icon.TabStop = false;
            // 
            // country
            // 
            this.country.BackColor = System.Drawing.Color.Transparent;
            this.country.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.country.ForeColor = System.Drawing.Color.White;
            this.country.Location = new System.Drawing.Point(433, 175);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(301, 34);
            this.country.TabIndex = 16;
            this.country.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Temp
            // 
            this.Temp.BackColor = System.Drawing.Color.Transparent;
            this.Temp.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Temp.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Temp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Temp.Location = new System.Drawing.Point(509, 222);
            this.Temp.Name = "Temp";
            this.Temp.Size = new System.Drawing.Size(153, 75);
            this.Temp.TabIndex = 17;
            this.Temp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(780, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 34);
            this.label2.TabIndex = 18;
            this.label2.Text = "Feels like:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FL
            // 
            this.FL.BackColor = System.Drawing.Color.Transparent;
            this.FL.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FL.ForeColor = System.Drawing.Color.White;
            this.FL.Location = new System.Drawing.Point(955, 429);
            this.FL.Name = "FL";
            this.FL.Size = new System.Drawing.Size(115, 34);
            this.FL.TabIndex = 19;
            this.FL.Text = "N/A";
            this.FL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTime
            // 
            this.dateTime.BackColor = System.Drawing.Color.Transparent;
            this.dateTime.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime.ForeColor = System.Drawing.Color.White;
            this.dateTime.Location = new System.Drawing.Point(460, 335);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(260, 27);
            this.dateTime.TabIndex = 20;
            this.dateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = global::WeatherApp.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1152, 763);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.FL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Temp);
            this.Controls.Add(this.country);
            this.Controls.Add(this.P_icon);
            this.Controls.Add(this.pr);
            this.Controls.Add(this.hu);
            this.Controls.Add(this.condi);
            this.Controls.Add(this.sr);
            this.Controls.Add(this.ws);
            this.Controls.Add(this.windspeed);
            this.Controls.Add(this.sunrise);
            this.Controls.Add(this.ss);
            this.Controls.Add(this.sunset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.city);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WEATHER APP";
            ((System.ComponentModel.ISupportInitialize)(this.P_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sunset;
        private System.Windows.Forms.Label ss;
        private System.Windows.Forms.Label sunrise;
        private System.Windows.Forms.Label windspeed;
        private System.Windows.Forms.Label ws;
        private System.Windows.Forms.Label sr;
        private System.Windows.Forms.Label condi;
        private System.Windows.Forms.Label hu;
        private System.Windows.Forms.Label pr;
        private System.Windows.Forms.PictureBox P_icon;
        private System.Windows.Forms.Label country;
        private System.Windows.Forms.Label Temp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label FL;
        private System.Windows.Forms.Label dateTime;
    }
}

