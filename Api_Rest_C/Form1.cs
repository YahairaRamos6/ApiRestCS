using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Api_Rest_C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_consultar_Click_1(object sender, EventArgs e)
        {
            DBApi api = new DBApi();
            string url = "https://api.openweathermap.org/data/2.5/weather?lat=" + txt_lat.Text + "&lon=" + txt_lon.Text + "&units=metric&lang=es&appid=15a203f469c6350d478c797e331fc6c6";

            dynamic consulta = api.Get(url);
            txt_Hum.Text = consulta.main.humidity;
            txt_presion.Text = consulta.main.pressure;
            txt_temp.Text = consulta.main.temp;
        }
    }
}
