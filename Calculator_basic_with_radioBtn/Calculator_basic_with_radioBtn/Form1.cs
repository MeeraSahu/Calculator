using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_basic_with_radioBtn
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            Double data1 = Double.Parse(textBox1.Text);
            Double data2 = Double.Parse(textBox2.Text);
            Double data3 = 0;

            if (Plus.Checked == true)
                data3 = data1 + data2;
            if (Minus.Checked == true)
                data3 = data1 - data2;
            if (Multi.Checked == true)
                data3 = data1 * data2;
            if (Divide.Checked == true)
                data3 = data1 / data2;

            textBox3.Text = Convert.ToString(data3);

        }

        private void ClearData(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
        }
    }
}
