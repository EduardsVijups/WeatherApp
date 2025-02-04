using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;


namespace weatherapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showButtn_Click(object sender, EventArgs e)
        {
            var cityName = city.Text;
            var requestUrl = $"http://api.weatherapi.com/v1/forecast.xml?key=ecdaff50705e449ab6311843250302&q={cityName}&days=1";
            String getData(XDocument doc, String q)
            {
                String data = (string)doc.Descendants(q).FirstOrDefault();
                return data;
            }
            String translateMoon(string phase)
            {
                string newPhase = "";
                if (phase is "New Moon") { newPhase = "Jauns Mçness"; }
                if (phase is "Waxing Crescent" or "First Quarter" or "Waxing Gibbous") { newPhase = "Augoðs Mçness"; }
                if (phase is "Full Moon") { newPhase = "Pilns Mçness"; }
                if (phase is "Waning Gibbous" or "Third Quarter" or "Waning Crescent") { newPhase = "Dilstoðs Mçness"; }
                return newPhase;
            }
            try
            {
                XDocument doc = XDocument.Load(requestUrl);
                string moonPhase = getData(doc, "moon_phase");
                string tempMax = getData(doc, "maxtemp_c");
                string tempMin = getData(doc, "mintemp_c");
                string humidity = getData(doc, "humidity");
                string windSp = getData(doc, "wind_kph");
                string atm = getData(doc, "pressure_mb");
                string pic = getData(doc, "icon");
                string teksts = getData(doc, "text");
                mnF.Text = translateMoon(moonPhase);
                tMax.Text = tempMax + "°C";
                tMin.Text = tempMin + "°C";
                mitr.Text = humidity + "%";
                wSpd.Text = windSp + "km/h";
                press.Text = atm + "mb";
                pictureIcon.Load("http:"+pic);
                apraksts.Text = teksts;
            }
            catch (Exception HttpRequestException) {
                MessageBox.Show("Nezinâma Pilsçta");
            }
            return;
        }
    }
}
