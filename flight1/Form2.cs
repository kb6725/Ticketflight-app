using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flight1
{
    public partial class Form2 : Form
    {
        decimal price;
        Form4 f4 = new Form4();

        public Form2()
        {
            InitializeComponent();
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(90, Color.White);
            panel8.BackColor = Color.FromArgb(90, Color.White);
            panel3.BackColor = Color.FromArgb(240, Color.White);
            panel4.BackColor = Color.FromArgb(240, Color.White);
            panel5.BackColor = Color.FromArgb(240, Color.White);
            panel6.BackColor = Color.FromArgb(240, Color.White);
            panel7.BackColor = Color.FromArgb(240, Color.White);


        }

        private void labelsum_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (label1.Text == "Two-way Route")
            { 
                this.Hide();
                
                f4.Show();
                int duration = int.Parse(label49.Text);
                f4.label49.Text = (duration*2).ToString();
                f4.labelsum.Text = labelsum.Text;
                f4.label4.Text = label4.Text;
                f4.label6.Text = label6.Text;
                f4.label10.Text = label10.Text;
                f4.label9.Text = label9.Text;

                f4.label13.Text = "Flight Duration: " + duration + " hours";
                f4.label24.Text = "Flight Duration: " + duration + " hours";
                f4.label30.Text = "Flight Duration: " + duration + " hours";
                f4.label36.Text = "Flight Duration: " + duration + " hours";
                f4.label42.Text = "Flight Duration: " + duration + " hours";

                f4.label15.Text = 6 + duration + " : 00";
                f4.label22.Text = 10 + duration + " : 00";

                if (duration + 14>23)
                { f4.label28.Text = 14 + duration -24 + " : 00"; 
                f4.label26.Text = "Non-stop flight (+1 day)";}
                else f4.label28.Text = 14 + duration + " : 00";

                if (duration + 17 > 23)
                { f4.label34.Text = 17 + duration - 24 + " : 00";
                    f4.label32.Text = "Non-stop flight (+1 day)";
                }
                else f4.label34.Text = 17 + duration + " : 00";

                if (duration + 23 > 23)
                { f4.label40.Text = 23 + duration - 24 + " : 00";
                    f4.label38.Text = "Non-stop flight (+1 day)";
                }
                else f4.label40.Text = 23 + duration + " : 00";

                int fn;
                Random rd = new Random();
                fn = rd.Next(100, 930);
                int jet;
                Random rd1 = new Random();
                jet = rd1.Next(200, 700);

                f4.label16.Text = "Flight number: RT " + fn;
                f4.label21.Text = "Flight number: RT " + (fn+15);
                f4.label27.Text = "Flight number: RT " + (fn+19);
                f4.label33.Text = "Flight number: RT " + (fn+35);
                f4.label39.Text = "Flight number: RT " + (fn+51);

                f4.label18.Text = "Boeing " + jet;
                f4.label19.Text = "Boeing " + (jet+28);
                f4.label25.Text = "Boeing " + (jet+33);
                f4.label31.Text = "Boeing " + (jet+38);
                f4.label37.Text = "Boeing " + (jet+44);

                f4.label57.Text = label56.Text;
                f4.label52.Text = label57.Text;
                f4.label53.Text = label58.Text;
                f4.label54.Text = label59.Text;
                f4.label55.Text = label60.Text;

                
                price = decimal.Parse(label56.Text);

                

                f4.label56.Text = price.ToString("c1");
                f4.label59.Text = (price * 5 / 100).ToString("c1");
                f4.label58.Text = (price * 10 / 100).ToString("c1");
                f4.label61.Text = (price + (price * 15 / 100)).ToString("c1");




            }
        }

        private void label54_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            button1.PerformClick();

            price = decimal.Parse(label57.Text);
            f4.label56.Text = price.ToString("c1");
            f4.label59.Text = (price * 5 / 100).ToString("c1");
            f4.label58.Text = (price * 10 / 100).ToString("c1");
            f4.label61.Text = (price + (price * 15 / 100)).ToString("c1");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.PerformClick();


            price = decimal.Parse(label58.Text);
            f4.label56.Text = price.ToString("c1");
            f4.label59.Text = (price * 5 / 100).ToString("c1");
            f4.label58.Text = (price * 10 / 100).ToString("c1");
            f4.label61.Text = (price + (price * 15 / 100)).ToString("c1");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.PerformClick();
            price = decimal.Parse(label59.Text);
            f4.label56.Text = price.ToString("c1");
            f4.label59.Text = (price * 5 / 100).ToString("c1");
            f4.label58.Text = (price * 10 / 100).ToString("c1");
            f4.label61.Text = (price + (price * 15 / 100)).ToString("c1");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.PerformClick();
            price = decimal.Parse(label60 .Text);
            f4.label56.Text = price.ToString("c1");
            f4.label59.Text = (price * 5 / 100).ToString("c1");
            f4.label58.Text = (price * 10 / 100).ToString("c1");
            f4.label61.Text = (price + (price * 15 / 100)).ToString("c1");
        }
    }
}
