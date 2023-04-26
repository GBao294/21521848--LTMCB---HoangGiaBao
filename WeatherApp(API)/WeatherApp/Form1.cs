using System;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pr_Click(object sender, EventArgs e)
        {

        }

        string APIkey = "ba37fcc05129e93402549ecfc51e567b";
        private void button1_Click(object sender, EventArgs e)
        {
            getWeather();
        }

        private void getWeather()
        {
            WebClient web = new WebClient();
            string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", city.Text, APIkey);
            var json = web.DownloadString(url);
            Info.root Info = JsonConvert.DeserializeObject<Info.root>(json);
            P_icon.ImageLocation = "http://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
            condi.Text = Info.weather[0].main;
            sunset.Text = covertDatetime(Info.sys.sunset).ToString();
            sunrise.Text = covertDatetime(Info.sys.sunrise).ToString();
            windspeed.Text = Info.wind.speed.ToString() + "m/s";
            hu.Text = Info.main.humidity.ToString() + "%";
            country.Text = city.Text +", " + Info.sys.country.ToString();
            Info.main.temp = Math.Round((Info.main.temp - 273.15),1); // Chuyển đổi độ K thành độ C
            Info.main.feels_like = Math.Round((Info.main.feels_like - 273.15), 1);
            Temp.Text = Info.main.temp.ToString() + "°C";
            FL.Text = Info.main.feels_like.ToString() + "°C";
            dateTime.Text = "Updated as of "+DateTime.Now.ToString("H:mm");
            city.Text = "";
          }
        DateTime covertDatetime(long millisec)
        {
            DateTime Day = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            Day = Day.AddSeconds(millisec);
            return Day;
        }
    }
}
