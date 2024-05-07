using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private void btnAdd_Click(object sender, EventArgs e)
        {
            double num1, num2, result;
            if (double.TryParse(textBox1.Text, out num1) && double.TryParse(textBox2.Text, out num2))
            {
                result = num1 + num2;
                textBox3.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Please enter valid numbers");
            }
        }

    }
