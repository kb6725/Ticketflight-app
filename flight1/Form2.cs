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
        
        Form4 f4 = new Form4();
        Form5 f5 = new Form5();
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
            panel1.BackColor = Color.FromArgb(180, Color.White);
            panel8.BackColor = Color.FromArgb(120, Color.White);
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
           
                
                
                f4.label49.Text = (Global.duration*2).ToString();
                f4.labelsum.Text = labelsum.Text;
                f4.label4.Text = label4.Text;
                f4.label6.Text = label6.Text;
                f4.label10.Text = label10.Text;
                f4.label9.Text = label9.Text;

                f4.label13.Text = "Flight Duration: " + Global.duration + " hours";
                f4.label24.Text = "Flight Duration: " + Global.duration + " hours";
                f4.label30.Text = "Flight Duration: " + Global.duration + " hours";
                f4.label36.Text = "Flight Duration: " + Global.duration + " hours";
                f4.label42.Text = "Flight Duration: " + Global.duration + " hours";

                f4.label15.Text = 6 + Global.duration + " : 00";
                f4.label22.Text = 10 + Global.duration + " : 00";

                if (Global.duration + 14>23)
                { f4.label28.Text = 14 + Global.duration - 24 + " : 00"; 
                f4.label26.Text = "Non-stop flight (+1 day)";}
                else f4.label28.Text = 14 + Global.duration + " : 00";

                if (Global.duration + 17 > 23)
                { f4.label34.Text = 17 + Global.duration - 24 + " : 00";
                    f4.label32.Text = "Non-stop flight (+1 day)";
                }
                else f4.label34.Text = 17 + Global.duration + " : 00";

                if (Global.duration + 23 > 23)
                { f4.label40.Text = 23 + Global.duration - 24 + " : 00";
                    f4.label38.Text = "Non-stop flight (+1 day)";
                }
                else f4.label40.Text = 23 + Global.duration + " : 00";



                f4.label16.Text = "Flight number: RT " + Global.fnumber;
                f4.label21.Text = "Flight number: RT " + (Global.fnumber + 15);
                f4.label27.Text = "Flight number: RT " + (Global.fnumber + 19);
                f4.label33.Text = "Flight number: RT " + (Global.fnumber + 35);
                f4.label39.Text = "Flight number: RT " + (Global.fnumber + 51);

                f4.label18.Text = "Boeing " + Global.fjet;
                f4.label19.Text = "Boeing " + (Global.fjet + 28);
                f4.label25.Text = "Boeing " + (Global.fjet + 33);
                f4.label31.Text = "Boeing " + (Global.fjet + 38);
                f4.label37.Text = "Boeing " + (Global.fjet + 44);

                f4.label57.Text = label56.Text;
                f4.label52.Text = label57.Text;
                f4.label53.Text = label58.Text;
                f4.label54.Text = label59.Text;
                f4.label55.Text = label60.Text;


                if (Global.cabin == "Economy")
                { Global.outticket = Global.e1; }
                if (Global.cabin == "Business")
                { Global.outticket = Global.b1; }
                if (Global.cabin == "First Class")
                { Global.outticket = Global.f1; }

                Global.airportfee = (Global.outticket * 5 / 100);
                Global.tax= (Global.outticket * 10 / 100);

                Global.totaltick = Global.tax + Global.outticket + Global.returnticket + Global.servicefee + Global.airportfee;
                f4.label56.Text = Global.outticket.ToString("c1");
                f4.label59.Text = (Global.airportfee).ToString("c1");
                f4.label58.Text = (Global.tax).ToString("c1");
                f4.label61.Text = (Global.totaltick).ToString("c1");
            if (Global.returnflight == true)
            {
                this.Hide();
                f4.Show();
            }
            else {
                this.Hide();
                f5.Show();
                f5.labelsum.Text = labelsum.Text;
                f5.label49.Text = label49.Text;
                f5.label4.Text = label4.Text;
                f5.label6.Text = label6.Text;
                f5.label10.Text = label10.Text;
                f5.label9.Text = label9.Text;


            }
        }

        private void label54_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            button1.PerformClick();
            Global.outticket = 0;
            Global.tax = 0;
            Global.airportfee = 0;
            Global.totaltick = 0;
            if (Global.cabin == "Economy")
            { Global.outticket = Global.e2; }
            if (Global.cabin == "Business")
            { Global.outticket = Global.b2; }
            if (Global.cabin == "First Class")
            { Global.outticket = Global.f2; }
            Global.airportfee = (Global.outticket * 5 / 100);
            Global.tax = (Global.outticket * 10 / 100);

            Global.totaltick = Global.tax + Global.outticket + Global.airportfee;

            f4.label56.Text = Global.outticket.ToString("c1");
            f4.label59.Text = (Global.airportfee).ToString("c1");
            f4.label58.Text = (Global.tax).ToString("c1");
            f4.label61.Text = (Global.totaltick).ToString("c1");



            if (Global.returnflight == true)
            {
                this.Hide();
                f4.Show();
            }
            else
            {
                this.Hide();
                f5.Show();
                f5.labelsum.Text = labelsum.Text;
                f5.label49.Text = label49.Text;
                f5.label4.Text = label4.Text;
                f5.label6.Text = label6.Text;
                f5.label10.Text = label10.Text;
                f5.label9.Text = label9.Text;

                f5.label62.Text = Global.outticket.ToString("c1");
                f5.label53.Text = (Global.airportfee).ToString("c1");
                f5.label54.Text = (Global.tax).ToString("c1");
                f5.label55.Text = (Global.totaltick).ToString("c1");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.PerformClick();

            Global.outticket = 0;
            Global.tax = 0;
            Global.airportfee = 0;
            Global.totaltick = 0;
            if (Global.cabin == "Economy")
            { Global.outticket = Global.e3; }
            if (Global.cabin == "Business")
            { Global.outticket = Global.b3; }
            if (Global.cabin == "First Class")
            { Global.outticket = Global.f3; }
            Global.airportfee = (Global.outticket * 5 / 100);
            Global.tax = (Global.outticket * 10 / 100);

            Global.totaltick = Global.tax + Global.outticket + Global.returnticket + Global.servicefee + Global.airportfee;

            f4.label56.Text = Global.outticket.ToString("c1");
            f4.label59.Text = (Global.airportfee).ToString("c1");
            f4.label58.Text = (Global.tax).ToString("c1");
            f4.label61.Text = (Global.totaltick).ToString("c1");

            if (Global.returnflight == true)
            {
                this.Hide();
                f4.Show();
            }
            else
            {
                this.Hide();
                f5.Show();
                f5.labelsum.Text = labelsum.Text;
                f5.label49.Text = label49.Text;
                f5.label4.Text = label4.Text;
                f5.label6.Text = label6.Text;
                f5.label10.Text = label10.Text;
                f5.label9.Text = label9.Text;

                f5.label62.Text = Global.outticket.ToString("c1");
                f5.label53.Text = (Global.airportfee).ToString("c1");
                f5.label54.Text = (Global.tax).ToString("c1");
                f5.label55.Text = (Global.totaltick).ToString("c1");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.PerformClick();
            Global.outticket = 0;
            Global.tax = 0;
            Global.airportfee = 0;
            Global.totaltick = 0;
            if (Global.cabin == "Economy")
            { Global.outticket = Global.e4; }
            if (Global.cabin == "Business")
            { Global.outticket = Global.b4; }
            if (Global.cabin == "First Class")
            { Global.outticket = Global.f4; }
            Global.airportfee = (Global.outticket * 5 / 100);
            Global.tax = (Global.outticket * 10 / 100);

            Global.totaltick = Global.tax + Global.outticket + Global.returnticket + Global.servicefee + Global.airportfee;
            f4.label56.Text = Global.outticket.ToString("c1");
            f4.label59.Text = (Global.airportfee).ToString("c1");
            f4.label58.Text = (Global.tax).ToString("c1");
            f4.label61.Text = (Global.totaltick).ToString("c1");

            if (Global.returnflight == true)
            {
                this.Hide();
                f4.Show();
            }
            else
            {
                this.Hide();
                f5.Show();
                f5.labelsum.Text = labelsum.Text;
                f5.label49.Text = label49.Text;
                f5.label4.Text = label4.Text;
                f5.label6.Text = label6.Text;
                f5.label10.Text = label10.Text;
                f5.label9.Text = label9.Text;

                f5.label62.Text = Global.outticket.ToString("c1");
                f5.label53.Text = (Global.airportfee).ToString("c1");
                f5.label54.Text = (Global.tax).ToString("c1");
                f5.label55.Text = (Global.totaltick).ToString("c1");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.PerformClick();
            Global.outticket = 0;
            Global.tax = 0;
            Global.airportfee = 0;
            Global.totaltick = 0;
            if (Global.cabin == "Economy")
            { Global.outticket = Global.e5; }
            if (Global.cabin == "Business")
            { Global.outticket = Global.b5; }
            if (Global.cabin == "First Class")
            { Global.outticket = Global.f5; }
            Global.airportfee = (Global.outticket * 5 / 100);
            Global.tax = (Global.outticket * 10 / 100);

            Global.totaltick = Global.tax + Global.outticket + Global.returnticket + Global.servicefee + Global.airportfee;

            f4.label56.Text = Global.outticket.ToString("c1");
            f4.label59.Text = (Global.airportfee).ToString("c1");
            f4.label58.Text = (Global.tax).ToString("c1");
            f4.label61.Text = (Global.totaltick).ToString("c1");

            if (Global.returnflight == true)
            {
                this.Hide();
                f4.Show();
            }
            else
            {
                this.Hide();
                f5.Show();
                f5.labelsum.Text = labelsum.Text;
                f5.label49.Text = label49.Text;
                f5.label4.Text = label4.Text;
                f5.label6.Text = label6.Text;
                f5.label10.Text = label10.Text;
                f5.label9.Text = label9.Text;

                f5.label62.Text = Global.outticket.ToString("c1");
                f5.label53.Text = (Global.airportfee).ToString("c1");
                f5.label54.Text = (Global.tax).ToString("c1");
                f5.label55.Text = (Global.totaltick).ToString("c1");
            }
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
