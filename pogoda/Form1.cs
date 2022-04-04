using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pogoda
{
    public partial class Form1 : Form
    {   
        const string API_KEY = "9152c2ba1c9b3c8546f73355913d6a47";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*try
            {
                Api api = new Api();
                Root weather = api.LoadData("Pies", API_KEY);
                textBox1.Text = (weather.main.temp.ToString());
            }
            catch(e : )
            {

            }*/

            Api api = new Api();
            Root weather = api.LoadData("gowno13234", API_KEY);
            textBox1.Text = (weather.main.temp.ToString());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
