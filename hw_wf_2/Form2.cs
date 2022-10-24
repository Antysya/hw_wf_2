using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw_wf_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

       private void Form2_MouseClick(object sender, MouseEventArgs e)
        {
            string but_mes ="";
            if(e.Button == MouseButtons.Left && ModifierKeys == Keys.Control)
            {
                but_mes = "Была нажата кнопка Control, что привело к закрытию программы";
                Close();
            }
            else if (e.Button == MouseButtons.Left)
            {

                if ((e.X < 51 || e.X > ClientRectangle.Size.Width - 51) || (e.Y < 51 || e.Y > ClientRectangle.Size.Height -51))
                {
                    but_mes = "Клик снаружи прямоугольника!";
                }
                else if ((e.X == 51 || e.X == ClientRectangle.Size.Width - 51) || (e.Y == 51 || e.Y == ClientRectangle.Size.Height - 51))
                {
                    but_mes = "Клик на границе прямоугольника!";
                }
                else
                {
                    but_mes = "Клик внутри прямоугольника!";
                }
                
            }
            if (e.Button == MouseButtons.Right)
            {
                but_mes = $"Размеры клиентской области окна! Ширина = {ClientSize.Width}, Высота = {ClientSize.Height}";
                
            }
            MessageBox.Show(but_mes, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private string Coordinat_mouse(MouseEventArgs e)
        {
            return "Координаты мыши: х= " + e.X.ToString() + " y= " + e.Y.ToString();
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            Text = Coordinat_mouse(e);
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
