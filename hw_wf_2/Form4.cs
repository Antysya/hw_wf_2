using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Windows.Forms.VisualStyles;
using static hw_wf_2.Form4;

namespace hw_wf_2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form1 = new Form1();
            Form1.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strMessage = "ФИО:" + LN.Text + " " + FN.Text + " " + Patr.Text + "\n";
            //strMessage += "Место проживания:" + textBoxCountry.Text + ", г." + textBoxCity.Text + "\n";
            strMessage += "Телефон: " + Phone.Text + "\n";
            strMessage += "Дата рождения: " + dateTimePicker1.Value.ToShortDateString() +"\n";
            if (radioButton1.Checked == true)
            {
                strMessage += "Пол: мужской";
            }
            else
            {
                strMessage += "Пол: женский";
            }
            MessageBox.Show(strMessage,"Анкетные данные");
            string st_json = JsonSerializer.Serialize(strMessage);
        }

         public class CountryCity
        {
            public string Country { get; set; }
            public string City { get; set; }
        }

        private void City_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<CountryCity> countryCities = new List<CountryCity>
        {
            new CountryCity{Country="Россия", City = "Москва"},
            new CountryCity{Country="Россия", City = "Санкт-Петербург"},
            new CountryCity{Country="Россия", City = "Владивосток"},
            new CountryCity{Country="Россия", City = "Ярославль"},
            new CountryCity{Country="Китай", City = "Шанхай"},
            new CountryCity{Country="Китай", City = "Пекин"},
            new CountryCity{Country="Китай", City = "Сиань"},
            new CountryCity{Country="Китай", City = "Ухань"},
        };
            List<string> City = new List<string>();
            foreach (CountryCity item in countryCities)
            {
                if (item.Country == Coyntry.Text)
                    City.Add(item.City);
            }
            
           
        }
    }
}
