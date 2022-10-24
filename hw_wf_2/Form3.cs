using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace hw_wf_2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            Stop.Enabled = false;
            timer.Tick += new EventHandler(ShowTimer);
        }

        Timer timer = new Timer();

        private void Start_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 0)
            {
                MessageBox.Show("Ошибка ввода.");
            }
            Stop.Enabled = true;
            timer.Interval = Decimal.ToInt32(numericUpDown1.Value) * 1000;
            timer.Start();

        }

        private void ShowTimer(object sender, EventArgs e)
        {
            timer.Stop();
            Stop.Enabled = false;
            MessageBox.Show("Время вышло.");
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            MessageBox.Show("Время еще не вышло.");
            Stop.Enabled = false;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            Form1 Form1 = new Form1();
            Form1.ShowDialog();
            this.Close();

        }

        }
}
