using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bezier_Egrisi
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private PointF[] Noktalar = new PointF[4];

        private void Cizim_Paint(object sender, PaintEventArgs e)
        {
            Noktalar[0].X = 100;        //sol çizgi
            Noktalar[0].Y = 60;
            Noktalar[1].X = 100;
            Noktalar[1].Y = 160;

            e.Graphics.DrawLine(Pens.Red, Noktalar[0], Noktalar[1]);


            Noktalar[0].X = 300;        //sağ çizgi
            Noktalar[0].Y = 60;
            Noktalar[1].X = 300;
            Noktalar[1].Y = 160;

            e.Graphics.DrawLine(Pens.Red, Noktalar[0], Noktalar[1]);

            //yıldız çizgileri

            Noktalar[0].X = 200;
            Noktalar[0].Y = 105;
            Noktalar[1].X = 212;
            Noktalar[1].Y = 105;

            e.Graphics.DrawLine(Pens.Red, Noktalar[0], Noktalar[1]);

            Noktalar[0].X = 222;
            Noktalar[0].Y = 105;
            Noktalar[1].X = 234;
            Noktalar[1].Y = 105;

            e.Graphics.DrawLine(Pens.Red, Noktalar[0], Noktalar[1]);

            Noktalar[0].X = 212;
            Noktalar[0].Y = 105;
            Noktalar[1].X = 217;
            Noktalar[1].Y = 95;

            e.Graphics.DrawLine(Pens.Red, Noktalar[0], Noktalar[1]);

            Noktalar[0].X = 217;
            Noktalar[0].Y = 95;
            Noktalar[1].X = 222;
            Noktalar[1].Y = 105;

            e.Graphics.DrawLine(Pens.Red, Noktalar[0], Noktalar[1]);

            Noktalar[0].X = 200;
            Noktalar[0].Y = 105;
            Noktalar[1].X = 208;
            Noktalar[1].Y = 113;

            e.Graphics.DrawLine(Pens.Red, Noktalar[0], Noktalar[1]);

            Noktalar[0].X = 208;
            Noktalar[0].Y = 113;
            Noktalar[1].X = 206;
            Noktalar[1].Y = 125;

            e.Graphics.DrawLine(Pens.Red, Noktalar[0], Noktalar[1]);

            Noktalar[0].X = 206;
            Noktalar[0].Y = 125;
            Noktalar[1].X = 217;
            Noktalar[1].Y = 117;

            e.Graphics.DrawLine(Pens.Red, Noktalar[0], Noktalar[1]);

            Noktalar[0].X = 234;
            Noktalar[0].Y = 105;
            Noktalar[1].X = 226;
            Noktalar[1].Y = 113;

            e.Graphics.DrawLine(Pens.Red, Noktalar[0], Noktalar[1]);

            Noktalar[0].X = 217;
            Noktalar[0].Y = 117;
            Noktalar[1].X = 228;
            Noktalar[1].Y = 125;

            e.Graphics.DrawLine(Pens.Red, Noktalar[0], Noktalar[1]);

            Noktalar[0].X = 228;
            Noktalar[0].Y = 125;
            Noktalar[1].X = 226;
            Noktalar[1].Y = 113;

            e.Graphics.DrawLine(Pens.Red, Noktalar[0], Noktalar[1]);

            // yıldızlar bitiş

            Noktalar[0].X = 300;
            Noktalar[0].Y = 60;
            Noktalar[1].X = 280;   // bayrak sağ üst 
            Noktalar[1].Y = 40;
            Noktalar[2].X = 220;
            Noktalar[2].Y = 40;
            Noktalar[3].X = 200;
            Noktalar[3].Y = 60;
            Bezier_Egrisi.Bezier_Ciz(e.Graphics, Pens.Red, 0.01f,
                    Noktalar[0], Noktalar[1], Noktalar[2], Noktalar[3]);

            Noktalar[0].X = 300;
            Noktalar[0].Y = 160;   // bayrak sağ alt 
            Noktalar[1].X = 280;
            Noktalar[1].Y = 140;
            Noktalar[2].X = 220;
            Noktalar[2].Y = 140;
            Noktalar[3].X = 200;
            Noktalar[3].Y = 160;
            Bezier_Egrisi.Bezier_Ciz(e.Graphics, Pens.Red, 0.01f,
                    Noktalar[0], Noktalar[1], Noktalar[2], Noktalar[3]);

            Noktalar[0].X = 200;
            Noktalar[0].Y = 60;
            Noktalar[1].X = 180;  // bayrak sol üst 
            Noktalar[1].Y = 80;
            Noktalar[2].X = 120;
            Noktalar[2].Y = 80;
            Noktalar[3].X = 100;
            Noktalar[3].Y = 60;
            Bezier_Egrisi.Bezier_Ciz(e.Graphics, Pens.Red, 0.01f,
                    Noktalar[0], Noktalar[1], Noktalar[2], Noktalar[3]);

            Noktalar[0].X = 200;
            Noktalar[0].Y = 160;
            Noktalar[1].X = 180;       // bayrak sol alt
            Noktalar[1].Y = 180;
            Noktalar[2].X = 120;
            Noktalar[2].Y = 180;
            Noktalar[3].X = 100;
            Noktalar[3].Y = 160;
            Bezier_Egrisi.Bezier_Ciz(e.Graphics, Pens.Red, 0.01f,
                    Noktalar[0], Noktalar[1], Noktalar[2], Noktalar[3]);

            Noktalar[0].X = 190;
            Noktalar[0].Y = 90;
            Noktalar[1].X = 140;       // ay dış çeper
            Noktalar[1].Y = 100;
            Noktalar[2].X = 130;
            Noktalar[2].Y = 140;
            Noktalar[3].X = 190;
            Noktalar[3].Y = 140;
            Bezier_Egrisi.Bezier_Ciz(e.Graphics, Pens.Red, 0.01f,
                    Noktalar[0], Noktalar[1], Noktalar[2], Noktalar[3]);

            Noktalar[0].X = 190;
            Noktalar[0].Y = 90;
            Noktalar[1].X = 155;       // ay iç çeper
            Noktalar[1].Y = 110;
            Noktalar[2].X = 155;
            Noktalar[2].Y = 130;
            Noktalar[3].X = 190;
            Noktalar[3].Y = 140;
            Bezier_Egrisi.Bezier_Ciz(e.Graphics, Pens.Red, 0.01f,
                    Noktalar[0], Noktalar[1], Noktalar[2], Noktalar[3]);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cizim.Invalidate();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Noktalar[0].X = 0;
            Noktalar[0].Y = 0;
            Noktalar[1].X = 0;
            Noktalar[1].Y = 0;
            Noktalar[2].X = 0;
            Noktalar[2].Y = 0;
            Noktalar[3].X = 0;
            Noktalar[3].Y = 0;

            Cizim.Invalidate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != '\b' && e.KeyChar != ',')
            {
                e.KeyChar = '\0';
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != '\b' && e.KeyChar != ',')
            {
                e.KeyChar = '\0';
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != '\b' && e.KeyChar != ',')
            {
                e.KeyChar = '\0';
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != '\b' && e.KeyChar != ',')
            {
                e.KeyChar = '\0';
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != '\b' && e.KeyChar != ',')
            {
                e.KeyChar = '\0';
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != '\b' && e.KeyChar != ',')
            {
                e.KeyChar = '\0';
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != '\b' && e.KeyChar != ',')
            {
                e.KeyChar = '\0';
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != '\b' && e.KeyChar != ',')
            {
                e.KeyChar = '\0';
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "")
            {
                button1.Enabled = true;
            }
            else button1.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "")
            {
                button1.Enabled = true;
            }
            else button1.Enabled = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "")
            {
                button1.Enabled = true;
            }
            else button1.Enabled = false;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "")
            {
                button1.Enabled = true;
            }
            else button1.Enabled = false;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "")
            {
                button1.Enabled = true;
            }
            else button1.Enabled = false;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "")
            {
                button1.Enabled = true;
            }
            else button1.Enabled = false;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "")
            {
                button1.Enabled = true;
            }
            else button1.Enabled = false;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "")
            {
                button1.Enabled = true;
            }
            else button1.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Cizim.Invalidate();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (textBox9.Text != "")
            {
                button4.Enabled = true;

                textBox10.Text = (int.Parse(textBox9.Text) * int.Parse(textBox9.Text) * int.Parse(textBox9.Text)).ToString();
                textBox11.Text = (int.Parse(textBox9.Text) * int.Parse(textBox9.Text)).ToString();
                textBox12.Text = (int.Parse(textBox9.Text)).ToString();
                textBox13.Text = "1";
            }
            else
            {
                button4.Enabled = false;
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != '\b' && e.KeyChar != ',')
            {
                e.KeyChar = '\0';
            }
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            float[] q = { float.Parse(textBox9.Text) };
            float[,] t = new float[1, 4];
            t[0, 0] = float.Parse(textBox10.Text);
            t[0, 1] = float.Parse(textBox11.Text);
            t[0, 2] = float.Parse(textBox12.Text);
            t[0, 3] = float.Parse(textBox13.Text);
            float[,] m = new float[4, 4];
            m[0, 0] = float.Parse(textBox17.Text);
            m[0, 1] = float.Parse(textBox16.Text);
            m[0, 2] = float.Parse(textBox15.Text);
            m[0, 3] = float.Parse(textBox14.Text);
            m[1, 0] = float.Parse(textBox21.Text);
            m[1, 1] = float.Parse(textBox20.Text);
            m[1, 2] = float.Parse(textBox19.Text);
            m[1, 3] = float.Parse(textBox18.Text);
            m[2, 0] = float.Parse(textBox25.Text);
            m[2, 1] = float.Parse(textBox24.Text);
            m[2, 2] = float.Parse(textBox23.Text);
            m[2, 3] = float.Parse(textBox22.Text);
            m[3, 0] = float.Parse(textBox29.Text);
            m[3, 1] = float.Parse(textBox28.Text);
            m[3, 2] = float.Parse(textBox27.Text);
            m[3, 3] = float.Parse(textBox26.Text);
        }
    }
}
