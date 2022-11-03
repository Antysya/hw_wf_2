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
        string[] countries = {"Россия", "Китай", "Япония" };
        string[] RF = { "Москва", "Санкт-Петербург", "Владивосток", "Ярославль" };
        string[] CH = { "Шанхай", "Пекин", "Сиань", "Ухань" };
        string[] Jap = { "Токио", "Кобо" };

        public Form4()
        {
            InitializeComponent();
            CountryF.Items.AddRange(countries);
            CityF.Items.AddRange(RF);
            CountryF.SelectedIndexChanged += City_SelectedIndexChanged;

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
            strMessage += "Место проживания:" + CountryF.SelectedItem.ToString() + ", г." + CityF.SelectedItem.ToString() + "\n";
            strMessage += "Телефон: " + Phone.Text + "\n";
            strMessage += "Дата рождения: " + dateTimePicker1.Value.ToShortDateString() + "\n";
            if (radioButton1.Checked == true)
            {
                strMessage += "Пол: мужской";
            }
            else
            {
                strMessage += "Пол: женский";
            }
            MessageBox.Show(strMessage, "Анкетные данные");
            string st_json = JsonSerializer.Serialize(strMessage);
        }

       private void City_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CountryF.SelectedItem.ToString() == "Россия") {
                CityF.Items.Clear();
                CityF.Items.AddRange(RF); }
            else if (CountryF.SelectedItem.ToString() == "Китай")
            {
                CityF.Items.Clear();
                CityF.Items.AddRange(CH);
            }
            else
            {
                CityF.Items.Clear();
                CityF.Items.AddRange(Jap);
            }
        }
    }
}
