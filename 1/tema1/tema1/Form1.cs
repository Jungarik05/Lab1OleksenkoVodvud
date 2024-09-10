using System;
using System.Drawing;
using System.Windows.Forms;
using tema1ClassLibrary;

namespace tema1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            double a;
            double z1;
            double z2;
            a = Convert.ToDouble(alfaTextBox.Text);

            if (gradRadioButton.Checked)
            {
                if ((a * 3) % 360 == 90 || (a * 3) % 360 == 270)
                {
                    z1Label.Text = "z1 = не определён";
                    z2Label.Text = "z2 = не определён";
                    return;
                }
                else
                {                  
                    a = Class1.GradToRad(a % 360);
                }              
            }
            else
            {
                a = a % (2 * Math.PI);              
            }
            z1 = Class1.CalculateZ1(a);
            z2 = Class1.CalculateZ2(a);
            z1Label.Text = "z1 = " + Convert.ToString(z1);
            z2Label.Text = "z2 = " + Convert.ToString(z2);
        }

        private void alfaTextBox_TextChanged(object sender, EventArgs e)
        {
            // Проверяем, содержат ли текст пробел или является пустым
            if (string.IsNullOrWhiteSpace(alfaTextBox.Text) || 
                alfaTextBox.Text == "-" || alfaTextBox.Text == "," || alfaTextBox.Text == "-,")
            {
                calcButton.Enabled = false;
            }
            else
            {
                // Проверяем, содержит ли текст только '-' и/или ','
                string text = alfaTextBox.Text;
                if (string.IsNullOrEmpty(text))
                {
                    calcButton.Enabled = false;
                }
                else
                {
                    calcButton.Enabled = true;
                }
            }
        }

        private void alfaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == '-' || e.KeyChar == ',' || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
           
            if ((e.KeyChar == '-' && alfaTextBox.Text.Contains("-")) ||
                (e.KeyChar == ',' && alfaTextBox.Text.Contains(",")))
            {
                e.Handled = true;
                return;
            }
          
            if ((e.KeyChar == '-' && alfaTextBox.SelectionStart != 0) ||
                (e.KeyChar == ',' && alfaTextBox.SelectionStart == 0))
            {
                e.Handled = true;
                return;
            }
        }       

        private void z1Label_MouseMove(object sender, MouseEventArgs e)
        {
            z1Label.BackColor = Color.Lavender;
        }

        private void z1Label_MouseLeave(object sender, EventArgs e)
        {
            z1Label.BackColor = Color.Thistle;
        }

        private void z2Label_MouseMove(object sender, MouseEventArgs e)
        {
            z2Label.BackColor = Color.Lavender;
        }

        private void z2Label_MouseLeave(object sender, EventArgs e)
        {
            z2Label.BackColor = Color.Thistle;
        }
    }
}