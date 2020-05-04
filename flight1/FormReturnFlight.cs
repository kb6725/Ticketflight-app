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
    public partial class FormReturnFlight : Form
    {
        FormFlightSeatExtra f5 = new FormFlightSeatExtra();

        public FormReturnFlight()
        {
            InitializeComponent();
        }

        private void btnSelectFlight1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global.returnticket = 0;
            Global.airportfee = 0;
            Global.tax = 0;

            if (Global.cabin == "Economy")
            {
                Global.returnticket = Global.e1;
            }
            else if (Global.cabin == "Business")
            {
                Global.returnticket = Global.b1;
            }
            else if (Global.cabin == "First Class")
            {
                Global.returnticket = Global.f1;
            }

            Global.airportfee = (Global.outticket + Global.returnticket) * 5 / 100;
            Global.tax= (Global.outticket + Global.returnticket) * 10 / 100;
            Global.totaltick = Global.tax + Global.outticket + Global.returnticket + Global.servicefee + Global.airportfee;

            f5.lblTicketPricePassengerOutput.Text = (Global.outticket+Global.returnticket).ToString("c1");
            f5.lblAirportFeeOutput.Text = Global.airportfee.ToString("c1");
            f5.lblTaxOutput.Text = Global.tax.ToString("c1");
            
            f5.lblTotalPricePassengerOutput.Text = (Global.totaltick.ToString("c1"));

            f5.Show();
            f5.lblCabinOutput.Text = Global.cabin;
            f5.comboBoxSeatUpgrade.SelectedItem = Global.cabin;
           
            f5.lblRouteOutput.Text = lblRouteOutput.Text;
            f5.lblDurationOutput.Text = Global.duration.ToString();
            f5.lblLengthOutput.Text = lblLengthOutput.Text;
            f5.lblCabinOutput.Text= Global.cabin;
            f5.lblPassengersOutput.Text = Global.guest.ToString() ;
            f5.lblDateOutput.Text = lblDateOutput.Text;
        }

        private void btnSelectFlight2_Click(object sender, EventArgs e)
        {
            btnSelectFlight1.PerformClick();
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

            f5.lblTicketPricePassengerOutput.Text = (Global.outticket + Global.returnticket).ToString("c1");
            f5.lblAirportFeeOutput.Text = Global.airportfee.ToString("c1");
            f5.lblTaxOutput.Text = Global.tax.ToString("c1");

            f5.lblTotalPricePassengerOutput.Text = (Global.totaltick.ToString("c1"));
        }

        private void btnSelectFlight3_Click(object sender, EventArgs e)
        {
            btnSelectFlight1.PerformClick();

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

            f5.lblTicketPricePassengerOutput.Text = (Global.outticket + Global.returnticket).ToString("c1");
            f5.lblAirportFeeOutput.Text = Global.airportfee.ToString("c1");
            f5.lblTaxOutput.Text = Global.tax.ToString("c1");

            f5.lblTotalPricePassengerOutput.Text = (Global.totaltick.ToString("c1"));
        }
        private void btnSelectFlight4_Click(object sender, EventArgs e)
        {
            btnSelectFlight1.PerformClick();
            
            Global.returnticket = 0;
            Global.airportfee = 0;
            Global.tax = 0;
            Global.totaltick = 0;

            if (Global.cabin == "Economy")
            {
                Global.returnticket = Global.e4;
            }
            else if (Global.cabin == "Business")
            {
                Global.returnticket = Global.b4;
            }
            else if (Global.cabin == "First Class")
            {
                Global.returnticket = Global.f4;
            }

            Global.airportfee = (Global.outticket + Global.returnticket) * 5 / 100;
            Global.tax = (Global.outticket + Global.returnticket) * 10 / 100;
            Global.totaltick = Global.tax + Global.outticket + Global.returnticket + Global.servicefee + Global.airportfee;

            f5.lblTicketPricePassengerOutput.Text = (Global.outticket + Global.returnticket).ToString("c1");
            f5.lblAirportFeeOutput.Text = Global.airportfee.ToString("c1");
            f5.lblTaxOutput.Text = Global.tax.ToString("c1");

            f5.lblTotalPricePassengerOutput.Text = (Global.totaltick.ToString("c1"));
        }

        private void btnSelectFlight5_Click(object sender, EventArgs e)
        {
            btnSelectFlight1.PerformClick();

            Global.returnticket = 0;
            Global.airportfee = 0;
            Global.tax = 0;
            Global.totaltick = 0;

            if (Global.cabin == "Economy")
            {
                Global.returnticket = Global.e5;
            }
            else if (Global.cabin == "Business")
            {
                Global.returnticket = Global.b5;
            }
            else if (Global.cabin == "First Class")
            {
                Global.returnticket = Global.f5;
            }

            Global.airportfee = (Global.outticket + Global.returnticket) * 5 / 100;
            Global.tax = (Global.outticket + Global.returnticket) * 10 / 100;
            Global.totaltick = Global.tax + Global.outticket + Global.returnticket + Global.servicefee + Global.airportfee;
            
            f5.lblTicketPricePassengerOutput.Text = (Global.outticket + Global.returnticket).ToString("c1");
            f5.lblAirportFeeOutput.Text = Global.airportfee.ToString("c1");
            f5.lblTaxOutput.Text = Global.tax.ToString("c1");
            
            f5.lblTotalPricePassengerOutput.Text = (Global.totaltick.ToString("c1"));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show("Are you sure you want to exit?", Global.appTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (response == DialogResult.OK)
            {
                // Close the program
                Application.Exit();
            }
        }

        // Painting for fancy transparency & outlines
        private void panelReturnFlight_Paint(object sender, PaintEventArgs e)
        {
            panelReturnFlight.BackColor = Color.FromArgb(150, Color.White);
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

        private void panelTotal_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panelTotal.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void panelSummaryPrice_Paint(object sender, PaintEventArgs e)
        {
            panelSummaryPrice.BackColor = Color.FromArgb(180, Color.White);
            ControlPaint.DrawBorder(e.Graphics, panelSummaryPrice.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }
    }
}
