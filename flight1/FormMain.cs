using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using System.Collections;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace flight1
{
    public partial class FormMain : Form
    {
        ArrayList flightduration = new ArrayList { "3", "2", "5", "6", "5", "3", "6", "4", "6", "7", "6", "7", "9", "6", "4", "7", "7", "9", "6", "8", "4", "4", "10", "2", "8",
            "9", "7", "4", "6", "4", "7", "6", "2", "7", "8", "6", "7", "4", "6", "1", "2", "3", "7", "6", "7", "5", "6", "7", "8", "9"};
        ArrayList pricelist = new ArrayList { "580", "774", "445", "784", "986", "779", "350", "1350", "1125", "646", "1058", "466", "1057", "554", "1400", "174", "346", "1244",
            "1564", "742", "1422", "866", "662", "668", "115", "166", "643", "1577", "1259", "2155","126", "164", "995", "264", "648", "979", "464", "1444", "621", "597", "442",
            "1024", "879", "646", "584", "250", "315", "668", "994", "194"};
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            comboFrom.Focus();

            dateTimeOut.MinDate = DateTime.Today;
            dateTimeReturn.MinDate = DateTime.Today;
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show("Are you sure you want to reset?", Global.appTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (response == DialogResult.OK)
            {
                // Reset combo boxes
                comboFrom.SelectedIndex = -1; comboTo.SelectedIndex = -1; comboCabin.SelectedIndex = -1;
                comboFrom.Text = "Select Departure..."; comboTo.Text = "Select Destination..."; comboCabin.Text = "Select Cabin...";

                // Reset guest counter
                lblGuestCount.Text = "1"; Global.guest = 1;

                // Reset ticket type radio button
                radioButtonReturn.Checked = true;

                // Reset date boxes
                dateTimeOut.Value = DateTime.Today;
                dateTimeReturn.Value = DateTime.Today;
            }
        }

        private void btnSearchTicket_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSearchTicket FormSearchTicket = new FormSearchTicket();
            FormSearchTicket.ShowDialog();
            this.Show();
        }

        private void radioButtonOneWay_CheckedChanged(object sender, EventArgs e)
        {
            lblReturn.Hide();
            dateTimeReturn.Hide();
            Global.returnflight = false;
        }

        private void radioButtonReturn_CheckedChanged(object sender, EventArgs e)
        {
            lblReturn.Show();
            dateTimeReturn.Show();
            Global.returnflight = true;
        }

        private void btnGuestPlus_Click(object sender, EventArgs e)
        {
            // Make sure # guests selected is < 5 before adding
            if (Global.guest < 5)
            {
                Global.guest++;
                lblGuestCount.Text = Global.guest.ToString();
            }
        }

        private void btnGuestMinus_Click(object sender, EventArgs e)
        {
            // Make sure # guests selected is > 1 before subtracting
            if (Global.guest > 1)
            {
                Global.guest--;
                lblGuestCount.Text = Global.guest.ToString();
            }
        }

        private void btnSearchFlight_Click(object sender, EventArgs e)
        {
            // Error checking
            // Error if destination & departure are the same
            if (comboFrom.Text == comboTo.Text)
            {
                MessageBox.Show("Please select a different destination from departure!", Global.appTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                comboFrom.ForeColor = Color.IndianRed;
                comboFrom.ForeColor = Color.Black;
                return;
            }

            // Error if no departure is selected
            if (comboFrom.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a departure location!", Global.appTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                comboFrom.ForeColor = Color.IndianRed;
                if (comboTo.SelectedIndex < 0)
                { comboTo.ForeColor = Color.IndianRed; }
                    return;
            }
            else { comboFrom.ForeColor = Color.Black; }
            
            // Error if no destination is selected
            if (comboTo.SelectedIndex < 0)

            { MessageBox.Show("Please select a destination location to proceed!", Global.appTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                comboTo.ForeColor = Color.IndianRed;
                return;
            }
            else { comboTo.ForeColor = Color.Black; }

            Global.flightfrom = comboFrom.Text;
            Global.flightto = comboTo.Text;
            Global.cabin = comboCabin.Text;

            Global.fromdate  = dateTimeOut.Value;

            Global.todate = dateTimeReturn.Value;
            System.TimeSpan len = Global.todate - Global.fromdate;
            int compare = DateTime.Compare(Global.todate, Global.fromdate);
            if (compare >= 0)
            { }
            else
            {
                MessageBox.Show("Outbound Date cannot be later than Return Date", Global.appTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FormOutboundFlight FormOutboundFlight = new FormOutboundFlight();
            this.Hide();
            FormOutboundFlight.Show();
            FormOutboundFlight.lblRouteOutput.Text = Global.flightfrom + " - " + Global.flightto;
            FormOutboundFlight.lblDateOutput.Text = dateTimeOut.Text + " - " + dateTimeReturn.Text;
            if (radioButtonOneWay.Checked)
            { FormOutboundFlight.lblLengthOutput.Text = "One way flight"; }
            else
            { FormOutboundFlight.lblLengthOutput.Text = len.Days.ToString() + " day(s)"; }
            FormOutboundFlight.lblPassengersOutput.Text = Global.guest.ToString();
            FormOutboundFlight.lblCabinOutput.Text = Global.cabin.ToString();

            int destinationindex;
            string dur,price;
            
            destinationindex = comboFrom.SelectedIndex;
            dur = flightduration[destinationindex].ToString();
            Global.duration = int.Parse(dur) ;
            price = pricelist[destinationindex].ToString();
            Global.coreticket = int.Parse(price);

            if (FormOutboundFlight.lblCabinOutput.Text == "Economy")
            {
                Global.e1= Global.coreticket;
                Global.e2 = (Global.coreticket + 70);
                Global.e3 = (Global.coreticket + 120);
                Global.e4 = (Global.coreticket + 150);
                Global.e5 = (Global.coreticket - 30);
            }
            if (FormOutboundFlight.lblCabinOutput.Text == "Business")
            {
                Global.b1 = (Global.coreticket * 2);
                Global.b2 = (Global.coreticket * 2 + 70);
                Global.b3 = (Global.coreticket * 2 + 120);
                Global.b4 = (Global.coreticket * 2 + 150);
                Global.b5 = (Global.coreticket * 2 - 30);

            }
            if (FormOutboundFlight.lblCabinOutput.Text == "First Class")
            {
                Global.f1 = (Global.coreticket * 4);
                Global.f2= (Global.coreticket * 4 + 70);
                Global.f3 = (Global.coreticket * 4 + 120);
                Global.f4 = (Global.coreticket * 4 + 150);
                Global.f5 = (Global.coreticket * 4 - 30);


            }
            if (FormOutboundFlight.lblCabinOutput.Text == "Economy")
            {
                FormOutboundFlight.lblFlight1PriceOutput.Text = Global.e1.ToString("n0");
                FormOutboundFlight.lblFlight2PriceOutput.Text = Global.e2.ToString("n0");
                FormOutboundFlight.lblFlight3PriceOutput.Text = Global.e3.ToString("n0");
                FormOutboundFlight.lblFlight4PriceOutput.Text = Global.e4.ToString("n0");
                FormOutboundFlight.lblFlight5PriceOutput.Text = Global.e5.ToString("n0");
            }
            if (FormOutboundFlight.lblCabinOutput.Text == "Business")
            {
                FormOutboundFlight.lblFlight1PriceOutput.Text = Global.b1.ToString("n0");
                FormOutboundFlight.lblFlight2PriceOutput.Text = Global.b2.ToString("n0");
                FormOutboundFlight.lblFlight3PriceOutput.Text = Global.b3.ToString("n0");
                FormOutboundFlight.lblFlight4PriceOutput.Text = Global.b4.ToString("n0");
                FormOutboundFlight.lblFlight5PriceOutput.Text = Global.b5.ToString("n0");
            }
            if (FormOutboundFlight.lblCabinOutput.Text == "First Class")
            {
                FormOutboundFlight.lblFlight1PriceOutput.Text = Global.f1.ToString("n0");
                FormOutboundFlight.lblFlight2PriceOutput.Text = Global.f2.ToString("n0");
                FormOutboundFlight.lblFlight3PriceOutput.Text = Global.f3.ToString("n0");
                FormOutboundFlight.lblFlight4PriceOutput.Text = Global.f4.ToString("n0");
                FormOutboundFlight.lblFlight5PriceOutput.Text = Global.f5.ToString("n0");
            }

            FormOutboundFlight.lblFlight1DurationOutput.Text = "Flight Duration: " + Global.duration + " hours";
            FormOutboundFlight.lblFlight2DurationOutput.Text = "Flight Duration: " + Global.duration + " hours";
            FormOutboundFlight.lblFlight4DurationOutput.Text = "Flight Duration: " + Global.duration + " hours";
            FormOutboundFlight.lblFlight5DurationOutput.Text = "Flight Duration: " + Global.duration + " hours";
            FormOutboundFlight.lblFlight3DurationOutput.Text = "Flight Duration: " + Global.duration + " hours";

            Random rd = new Random();
            Global.fnumber = rd.Next(100, 930);
            
            Random rd1 = new Random();
            Global.fjet = rd1.Next(200, 700);

            int to1, to2, to3, to4, to5;
            to1 = Global.duration + 5;
            to2 = Global.duration + 9;
            to3 = Global.duration + 13;
            to4 = Global.duration + 16;
            to5 = Global.duration + 22;

            FormOutboundFlight.lblDurationOutput.Text = dur.ToString();

            if (to4 > 23)
            {
                to4 = to4 - 24;
                FormOutboundFlight.lblFlight4Type.Text = "Non-stop flight (+1 day)";
            }
            if (to5 > 23)
            {
                to5 = to5 - 24;
                FormOutboundFlight.lblFlight5Type.Text = "Non-stop flight (+1 day)";
            }

            FormOutboundFlight.lblFlight1TimeTo.Text = to1.ToString() + " : 00";
            FormOutboundFlight.lblFlight1NumOutput.Text = "Flight number: BN " + Global.fnumber.ToString();
            FormOutboundFlight.lblPlane1Output.Text = "Airbus " + Global.fjet.ToString();

            FormOutboundFlight.lblFlight2TimeTo.Text = to2.ToString() + " : 00";
            FormOutboundFlight.lblFlight2NumOutput.Text = "Flight number: BN " + (Global.fnumber + 20).ToString();
            FormOutboundFlight.lblPlane2Output.Text = "Airbus " + (Global.fjet + 12).ToString();

            FormOutboundFlight.lblFlight3TimeTo.Text = to3.ToString() + " : 00";
            FormOutboundFlight.lblFlight3NumOutput.Text = "Flight number: BN " + (Global.fnumber + 35).ToString();
            FormOutboundFlight.lblPlane3Output.Text = "Airbus " + (Global.fjet + 22).ToString();

            FormOutboundFlight.lblFlight4TimeTo.Text = to4.ToString() + " : 00";
            FormOutboundFlight.lblFlight4NumOutput.Text = "Flight number: BN " + (Global.fnumber + 46).ToString();
            FormOutboundFlight.lblPlane4Output.Text = "Airbus " + (Global.fjet + 32).ToString();

            FormOutboundFlight.lblFlight5TimeTo.Text = to5.ToString() + " : 00";
            FormOutboundFlight.lblFlight5NumOutput.Text = "Flight number: BN " + (Global.fnumber + 550).ToString();
            FormOutboundFlight.lblPlane5Output.Text = "Airbus " + (Global.fjet + 42).ToString();

            if (Global.returnflight == true)
            {
                FormOutboundFlight.lblRoute.Text = "Two-way Route";
            }
            else
            {
                FormOutboundFlight.lblRoute.Text = "One-way Route";
            }
        }

        // Painting for fancy transparency & outlines
        private void panelNews_Paint(object sender, PaintEventArgs e)
        {
            panelNews.BackColor = Color.FromArgb(150, Color.White);
            ControlPaint.DrawBorder(e.Graphics, panelNews.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void panelTicketSearch_Paint(object sender, PaintEventArgs e)
        {
            panelTicketSearch.BackColor = Color.FromArgb(150, Color.White);
            ControlPaint.DrawBorder(e.Graphics, panelTicketSearch.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void panelBookFlight_Paint(object sender, PaintEventArgs e)
        {
            panelBookFlight.BackColor = Color.FromArgb(150, Color.White);
            ControlPaint.DrawBorder(e.Graphics, panelBookFlight.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void panelDates_Paint(object sender, PaintEventArgs e)
        {
            panelDates.BackColor = Color.FromArgb(150, Color.White);
            ControlPaint.DrawBorder(e.Graphics, panelDates.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }
    }
}
