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
    public partial class FormOutboundFlight : Form
    {
        
        FormReturnFlight f4 = new FormReturnFlight();
        Form5 f5 = new Form5();
      
        public FormOutboundFlight()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(180, Color.White);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
                f4.lblDurationOutput.Text = (Global.duration*2).ToString();
                f4.lblRouteOutput.Text = labelsum.Text;
                f4.lblDateOutput.Text = label4.Text;
                f4.lblLengthOutput.Text = label6.Text;
                f4.lblCabinOutput.Text = label10.Text;
                f4.lblPassengersOutput.Text = label9.Text;

                f4.lblFlight1DurationOutput.Text = "Flight Duration: " + Global.duration + " hours";
                f4.lblFlight2DurationOutput.Text = "Flight Duration: " + Global.duration + " hours";
                f4.lblFlight3DurationOutput.Text = "Flight Duration: " + Global.duration + " hours";
                f4.lblFlight4DurationOutput.Text = "Flight Duration: " + Global.duration + " hours";
                f4.lblFlight5DurationOutput.Text = "Flight Duration: " + Global.duration + " hours";

                f4.lblFlight1TimeTo.Text = 6 + Global.duration + " : 00";
                f4.lblFlight2TimeTo.Text = 10 + Global.duration + " : 00";

                if (Global.duration + 14>23)
                { f4.lblFlight3TimeTo.Text = 14 + Global.duration - 24 + " : 00"; 
                f4.lblFlight3Type.Text = "Non-stop flight (+1 day)";}
                else f4.lblFlight3TimeTo.Text = 14 + Global.duration + " : 00";

                if (Global.duration + 17 > 23)
                { f4.lblFlight4TimeTo.Text = 17 + Global.duration - 24 + " : 00";
                    f4.lblFlight4Type.Text = "Non-stop flight (+1 day)";
                }
                else f4.lblFlight4TimeTo.Text = 17 + Global.duration + " : 00";

                if (Global.duration + 23 > 23)
                { f4.lblFlight5TimeTo.Text = 23 + Global.duration - 24 + " : 00";
                    f4.lblFlight5Type.Text = "Non-stop flight (+1 day)";
                }
                else f4.lblFlight5TimeTo.Text = 23 + Global.duration + " : 00";



                f4.lblFlight1NumOutput.Text = "Flight number: RT " + Global.fnumber;
                f4.lblFlight2NumOutput.Text = "Flight number: RT " + (Global.fnumber + 15);
                f4.lblFlight3NumOutput.Text = "Flight number: RT " + (Global.fnumber + 19);
                f4.lblFlight4NumOutput.Text = "Flight number: RT " + (Global.fnumber + 35);
                f4.lblFlight5NumOutput.Text = "Flight number: RT " + (Global.fnumber + 51);

                f4.lblPlane1Output.Text = "Boeing " + Global.fjet;
                f4.lblPlane2Output.Text = "Boeing " + (Global.fjet + 28);
                f4.lblPlane3Output.Text = "Boeing " + (Global.fjet + 33);
                f4.lblPlane4Output.Text = "Boeing " + (Global.fjet + 38);
                f4.lblPlane5Output.Text = "Boeing " + (Global.fjet + 44);

                f4.lblFlight1PriceOutput.Text = label56.Text;
                f4.lblFlight2PriceOutput.Text = label57.Text;
                f4.lblFlight3PriceOutput.Text = label58.Text;
                f4.lblFlight4PriceOutput.Text = label59.Text;
                f4.lblFlight5PriceOutput.Text = label60.Text;


                if (Global.cabin == "Economy")
                { Global.outticket = Global.e1; }
                if (Global.cabin == "Business")
                { Global.outticket = Global.b1; }
                if (Global.cabin == "First Class")
                { Global.outticket = Global.f1; }

                Global.airportfee = (Global.outticket * 5 / 100);
                Global.tax= (Global.outticket * 10 / 100);

                Global.totaltick = Global.tax + Global.outticket + Global.returnticket + Global.servicefee + Global.airportfee;
                f4.lblTicketPricePassengerOutput.Text = Global.outticket.ToString("c1");
                f4.lblAirportFeeOutput.Text = (Global.airportfee).ToString("c1");
                f4.lblTaxOutput.Text = (Global.tax).ToString("c1");
                f4.lblTotalPricePassengerOutput.Text = (Global.totaltick).ToString("c1");
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

            f4.lblTicketPricePassengerOutput.Text = Global.outticket.ToString("c1");
            f4.lblAirportFeeOutput.Text = (Global.airportfee).ToString("c1");
            f4.lblTaxOutput.Text = (Global.tax).ToString("c1");
            f4.lblTotalPricePassengerOutput.Text = (Global.totaltick).ToString("c1");



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

            f4.lblTicketPricePassengerOutput.Text = Global.outticket.ToString("c1");
            f4.lblAirportFeeOutput.Text = (Global.airportfee).ToString("c1");
            f4.lblTaxOutput.Text = (Global.tax).ToString("c1");
            f4.lblTotalPricePassengerOutput.Text = (Global.totaltick).ToString("c1");

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
            f4.lblTicketPricePassengerOutput.Text = Global.outticket.ToString("c1");
            f4.lblAirportFeeOutput.Text = (Global.airportfee).ToString("c1");
            f4.lblTaxOutput.Text = (Global.tax).ToString("c1");
            f4.lblTotalPricePassengerOutput.Text = (Global.totaltick).ToString("c1");

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

            f4.lblTicketPricePassengerOutput.Text = Global.outticket.ToString("c1");
            f4.lblAirportFeeOutput.Text = (Global.airportfee).ToString("c1");
            f4.lblTaxOutput.Text = (Global.tax).ToString("c1");
            f4.lblTotalPricePassengerOutput.Text = (Global.totaltick).ToString("c1");

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
            panel8.BackColor = Color.FromArgb(180, Color.White);
            
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

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain f1 = new FormMain();
            f1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult res = new DialogResult();
            res = MessageBox.Show("Are you sure to Exit ?", "Exit prompt", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
