using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flight1
{


    public partial class Form4 : Form
    {
        Form5 f5 = new Form5();
        
            

        public Form4()
        {
            InitializeComponent();


        }

        private void Form4_Load(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.Default;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(180, Color.White);
            

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
            this.Hide();
            Global.returnticket = 0;
            Global.airportfee = 0;
            Global.tax = 0;

            if (Global.cabin == "Economy")
            { Global.returnticket = Global.e1; }
            if (Global.cabin == "Business")
            { Global.returnticket = Global.b1; }
            if (Global.cabin == "First Class")
            { Global.returnticket = Global.f1; }


            Global.airportfee = (Global.outticket + Global.returnticket) * 5 / 100;
            Global.tax= (Global.outticket + Global.returnticket) * 10 / 100;
            Global.totaltick = Global.tax + Global.outticket + Global.returnticket + Global.servicefee + Global.airportfee;

            f5.label62.Text = (Global.outticket+Global.returnticket).ToString("c1");
            f5.label53.Text = Global.airportfee.ToString("c1");
            f5.label54.Text = Global.tax.ToString("c1");
            
            f5.label55.Text = (Global.totaltick.ToString("c1"));

            f5.Show();
            f5.label10.Text = Global.cabin;
            f5.comboBox1.SelectedItem = Global.cabin;
           
            f5.labelsum.Text = labelsum.Text;
            f5.label49.Text = Global.duration.ToString();
            f5.label6.Text = label6.Text;
            f5.label10.Text= Global.cabin;
            f5.label9.Text = Global.guest.ToString() ;
            f5.label4.Text = label4.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {

            button1.PerformClick();
            Global.returnticket = 0;
            Global.airportfee = 0;
            Global.tax = 0;
            Global.totaltick = 0;

            if (Global.cabin == "Economy")
            { Global.returnticket = Global.e2; }
            if (Global.cabin == "Business")
            { Global.returnticket = Global.b2; }
            if (Global.cabin == "First Class")
            { Global.returnticket = Global.f2; }


            Global.airportfee = (Global.outticket + Global.returnticket) * 5 / 100;
            Global.tax = (Global.outticket + Global.returnticket) * 10 / 100;
            Global.totaltick = Global.tax + Global.outticket + Global.returnticket +  Global.airportfee;

            f5.label62.Text = (Global.outticket + Global.returnticket).ToString("c1");
            f5.label53.Text = Global.airportfee.ToString("c1");
            f5.label54.Text = Global.tax.ToString("c1");

            f5.label55.Text = (Global.totaltick.ToString("c1"));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.PerformClick();

            Global.returnticket = 0;
            Global.airportfee = 0;
            Global.tax = 0;
            Global.totaltick = 0;

            if (Global.cabin == "Economy")
            { Global.returnticket = Global.e3; }
            if (Global.cabin == "Business")
            { Global.returnticket = Global.b3; }
            if (Global.cabin == "First Class")
            { Global.returnticket = Global.f3; }
            Global.airportfee = (Global.outticket + Global.returnticket) * 5 / 100;
            Global.tax = (Global.outticket + Global.returnticket) * 10 / 100;
            Global.totaltick = Global.tax + Global.outticket + Global.returnticket + Global.servicefee + Global.airportfee;

            f5.label62.Text = (Global.outticket + Global.returnticket).ToString("c1");
            f5.label53.Text = Global.airportfee.ToString("c1");
            f5.label54.Text = Global.tax.ToString("c1");

            f5.label55.Text = (Global.totaltick.ToString("c1"));
        }
            private void button4_Click(object sender, EventArgs e)
        {
            button1.PerformClick();

                Global.returnticket = 0;
                Global.airportfee = 0;
                Global.tax = 0;
                Global.totaltick = 0;

            if (Global.cabin == "Economy")
            { Global.returnticket = Global.e4; }
            if (Global.cabin == "Business")
            { Global.returnticket = Global.b4; }
            if (Global.cabin == "First Class")
            { Global.returnticket = Global.f4; }
            Global.airportfee = (Global.outticket + Global.returnticket) * 5 / 100;
                Global.tax = (Global.outticket + Global.returnticket) * 10 / 100;
                Global.totaltick = Global.tax + Global.outticket + Global.returnticket + Global.servicefee + Global.airportfee;

                f5.label62.Text = (Global.outticket + Global.returnticket).ToString("c1");
                f5.label53.Text = Global.airportfee.ToString("c1");
                f5.label54.Text = Global.tax.ToString("c1");

                f5.label55.Text = (Global.totaltick.ToString("c1"));
            }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.PerformClick();

                Global.returnticket = 0;
                Global.airportfee = 0;
                Global.tax = 0;
                Global.totaltick = 0;

            if (Global.cabin == "Economy")
            { Global.returnticket = Global.e5; }
            if (Global.cabin == "Business")
            { Global.returnticket = Global.b5; }
            if (Global.cabin == "First Class")
            { Global.returnticket = Global.f5; }
            Global.airportfee = (Global.outticket + Global.returnticket) * 5 / 100;
                Global.tax = (Global.outticket + Global.returnticket) * 10 / 100;
                Global.totaltick = Global.tax + Global.outticket + Global.returnticket + Global.servicefee + Global.airportfee;

                f5.label62.Text = (Global.outticket + Global.returnticket).ToString("c1");
                f5.label53.Text = Global.airportfee.ToString("c1");
                f5.label54.Text = Global.tax.ToString("c1");

                f5.label55.Text = (Global.totaltick.ToString("c1"));
            }

        private void button8_Click(object sender, EventArgs e)
        {
           
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            
            panel8.BackColor = Color.FromArgb(150, Color.White);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel3.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel4.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel5.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel6.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel7.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel1.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel2.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel9.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel10.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }
    }
}
