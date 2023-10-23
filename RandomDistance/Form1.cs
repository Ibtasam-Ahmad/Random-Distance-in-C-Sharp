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

namespace RandomDistance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Distnace parallel to X Axis
            //float x1 = float.Parse(textBox1.Text);
            //float x2 = float.Parse(textBox1.Text);
            //float actualDistance = x2 - x1;
            //float randomDistance;
            //double r;

            //float xmin = x1 - 10, xmax = x2 + 10;
            //int n = 1000, n1 = 0;     // n = total values from xmin to xmax

            //Random obj = new Random();

            //Graphics gg = CreateGraphics();
            //SolidBrush sb = new SolidBrush(Color.Blue);
            //SolidBrush sb1 = new SolidBrush(Color.Red);

            //for (int i = 0; i < n; i++)
            //{
            //    r = xmin + (xmax-xmin)*obj.NextDouble();
            //    // for every loop one value is generated in between x1 & x2
               
            //    if(r >= x1 && r <= x2)
            //    {
            //        n1++;
            //        gg.FillEllipse(sb, 200 + (float)r*5, 300, 5, 5);
            //    }
            //    else
            //    {
            //        gg.FillEllipse(sb1, 200 + (float)r*5, 300, 5, 5);
            //    }
            //    Thread.Sleep(20);

            //    textBox3.Text = " Counter = " + (i++);
            //    textBox3.Refresh();
            //}
            //randomDistance = ((float)n1 / (float)n) * (xmax - xmin);

            //// Absolute Error
            //float error = Math.Abs(actualDistance - randomDistance);
            //MessageBox.Show(" The Absolute Error is " + error);

            this.Refresh();
            // THIS DIStance is parallel to x axis
            float x1 = float.Parse(textBox1.Text);
            float x2 = float.Parse(textBox2.Text);
            float actualDistance = x2 - x1;
            float randomd; double r;
            float xmin = x1 - 10, xmax = x2 + 10;
            int n = 1000, n1 = 0;
            Random obj = new Random();
            Graphics gg = CreateGraphics();
            SolidBrush rb = new SolidBrush(Color.Red);
            SolidBrush bb = new SolidBrush(Color.Blue);
            for (int i = 0; i < n; i++)
            {
                r = xmin + (xmax - xmin) * obj.NextDouble();
                if (r >= x1 && r <= x2)
                {
                    n1++;
                    gg.FillEllipse(rb, 200 + (float)r * 5, 400, 5, 5);
                }
                else
                {
                    gg.FillEllipse(bb, 200 + (float)r * 5, 400, 5, 5);
                }
                Thread.Sleep(2);
                textBox3.Text = "counter=" + (i++);
                textBox3.Refresh();
            }
            randomd = (float)n1 / (float)n * (xmax - xmin);
            float error = Math.Abs(actualDistance - randomd);
            MessageBox.Show("the absolutue error is =" + error);
        }
    }
}
