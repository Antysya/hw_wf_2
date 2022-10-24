using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw_wf_2
{
    public partial class Form1 : Form
    {
        public Form1 ()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = DialogResult.Yes;
            while (result == DialogResult.Yes)
            {
                //1
                string message = "Сообщение от программиста";
                MessageBox.Show(message);

                //2
                string caption = "Это заглавие";
                result = MessageBox.Show(message, caption, MessageBoxButtons.OK);

                //3

                string caption2 = "Выбор";
                result = MessageBox.Show(message, caption2, MessageBoxButtons.YesNoCancel);

                //4
                string button = result.ToString();
                result = MessageBox.Show("Вы выбрали " + button , button, MessageBoxButtons.OK);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 Form2 = new Form2();
            Form2.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 Form3 = new Form3();
            Form3.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 Form4 = new Form4();
            Form4.ShowDialog();
            this.Close();

        }

    }
}
