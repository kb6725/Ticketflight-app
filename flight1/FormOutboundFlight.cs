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
        FormFlightSeatExtra f5 = new FormFlightSeatExtra();
      
        public FormOutboundFlight()
        {
            InitializeComponent();
        }

        private void btnSelectFlight1_Click(object sender, EventArgs e)
        {
                f4.lblDurationOutput.Text = (Global.duration*2).ToString();
                f4.lblRouteOutput.Text = lblRouteOutput.Text;
                f4.lblDateOutput.Text = lblDateOutput.Text;
                f4.lblLengthOutput.Text = lblLengthOutput.Text;
                f4.lblCabinOutput.Text = lblCabinOutput.Text;
                f4.lblPassengersOutput.Text = lblPassengersOutput.Text;

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

                f4.lblFlight1PriceOutput.Text = lblFlight1PriceOutput.Text;
                f4.lblFlight2PriceOutput.Text = lblFlight2PriceOutput.Text;
                f4.lblFlight3PriceOutput.Text = lblFlight3PriceOutput.Text;
                f4.lblFlight4PriceOutput.Text = lblFlight4PriceOutput.Text;
                f4.lblFlight5PriceOutput.Text = lblFlight5PriceOutput.Text;


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
                f5.lblRouteOutput.Text = lblRouteOutput.Text;
                f5.lblDurationOutput.Text = lblDurationOutput.Text;
                f5.lblDateOutput.Text = lblDateOutput.Text;
                f5.lblLengthOutput.Text = lblLengthOutput.Text;
                f5.lblCabinOutput.Text = lblCabinOutput.Text;
                f5.lblPassengersOutput.Text = lblPassengersOutput.Text;
            }
        }

        private void btnSelectFlight2_Click(object sender, EventArgs e)
        {
            btnSelectFlight1.PerformClick();
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
                f5.lblRouteOutput.Text = lblRouteOutput.Text;
                f5.lblDurationOutput.Text = lblDurationOutput.Text;
                f5.lblDateOutput.Text = lblDateOutput.Text;
                f5.lblLengthOutput.Text = lblLengthOutput.Text;
                f5.lblCabinOutput.Text = lblCabinOutput.Text;
                f5.lblPassengersOutput.Text = lblPassengersOutput.Text;

                f5.lblTicketPricePassengerOutput.Text = Global.outticket.ToString("c1");
                f5.lblAirportFeeOutput.Text = (Global.airportfee).ToString("c1");
                f5.lblTaxOutput.Text = (Global.tax).ToString("c1");
                f5.lblTotalPricePassengerOutput.Text = (Global.totaltick).ToString("c1");

            }
        }

        private void btnSelectFlight3_Click(object sender, EventArgs e)
        {
            btnSelectFlight1.PerformClick();

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
                f5.lblRouteOutput.Text = lblRouteOutput.Text;
                f5.lblDurationOutput.Text = lblDurationOutput.Text;
                f5.lblDateOutput.Text = lblDateOutput.Text;
                f5.lblLengthOutput.Text = lblLengthOutput.Text;
                f5.lblCabinOutput.Text = lblCabinOutput.Text;
                f5.lblPassengersOutput.Text = lblPassengersOutput.Text;

                f5.lblTicketPricePassengerOutput.Text = Global.outticket.ToString("c1");
                f5.lblAirportFeeOutput.Text = (Global.airportfee).ToString("c1");
                f5.lblTaxOutput.Text = (Global.tax).ToString("c1");
                f5.lblTotalPricePassengerOutput.Text = (Global.totaltick).ToString("c1");
            }
        }

        private void btnSelectFlight4_Click(object sender, EventArgs e)
        {
            btnSelectFlight1.PerformClick();
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
                f5.lblRouteOutput.Text = lblRouteOutput.Text;
                f5.lblDurationOutput.Text = lblDurationOutput.Text;
                f5.lblDateOutput.Text = lblDateOutput.Text;
                f5.lblLengthOutput.Text = lblLengthOutput.Text;
                f5.lblCabinOutput.Text = lblCabinOutput.Text;
                f5.lblPassengersOutput.Text = lblPassengersOutput.Text;

                f5.lblTicketPricePassengerOutput.Text = Global.outticket.ToString("c1");
                f5.lblAirportFeeOutput.Text = (Global.airportfee).ToString("c1");
                f5.lblTaxOutput.Text = (Global.tax).ToString("c1");
                f5.lblTotalPricePassengerOutput.Text = (Global.totaltick).ToString("c1");
            }
        }

        private void btnSelectFlight5_Click(object sender, EventArgs e)
        {
            btnSelectFlight1.PerformClick();
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
                f5.lblRouteOutput.Text = lblRouteOutput.Text;
                f5.lblDurationOutput.Text = lblDurationOutput.Text;
                f5.lblDateOutput.Text = lblDateOutput.Text;
                f5.lblLengthOutput.Text = lblLengthOutput.Text;
                f5.lblCabinOutput.Text = lblCabinOutput.Text;
                f5.lblPassengersOutput.Text = lblPassengersOutput.Text;

                f5.lblTicketPricePassengerOutput.Text = Global.outticket.ToString("c1");
                f5.lblAirportFeeOutput.Text = (Global.airportfee).ToString("c1");
                f5.lblTaxOutput.Text = (Global.tax).ToString("c1");
                f5.lblTotalPricePassengerOutput.Text = (Global.totaltick).ToString("c1");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult res = new DialogResult();
            res = MessageBox.Show("Are you sure to Exit ?", "Exit prompt", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        // Painting for fancy transparency & outlines
        private void panelOutboundFlight_Paint(object sender, PaintEventArgs e)
        {
            panelOutboundFlight.BackColor = Color.FromArgb(180, Color.White);
        }

        private void panelFlight1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panelFlight1.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void panelFlight2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panelFlight2.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void panelFlight3_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panelFlight3.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void panelFlight4_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panelFlight4.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void panelFlight5_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panelFlight5.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void panelFlightSummary_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panelFlightSummary.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void panelPrice_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panelPrice.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void panelTotals_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panelTotals.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void panelFlightSummaryPrice_Paint(object sender, PaintEventArgs e)
        {
            panelFlightSummaryPrice.BackColor = Color.FromArgb(180, Color.White);
        }
    }
}
