﻿using System;
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
        ArrayList destination = new ArrayList { "Alabama", "Alaska", "Arizona", "Arkansas", "California", "Colorado", "Connecticut", "Delaware", "Florida", "Georgia", "Hawaii",
            "Idaho", "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky", "Lousiana", "Maine", "Maryland", "Massachusetts", "Michigan", "Minnesota", "Mississippi", "Missouri", "Montana",
            "Nebraska", "Nevada", "New Hempshire", "New Jersey", "New Mexico", "New York", "North Carolina", "North Dakota", "Ohio", "Oklahoma", "Oregon", "Pennsylvania", "Rhode Island",
            "South Carolina", "South Dakota", "Tennese", "Texas", "Utah", "Vermont", "Virginia", "Washington", "West Virginia", "Wisconsin", "Wyoming"};
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
            comboFrom.DataSource = destination.ToArray();
            comboTo.DataSource = destination.ToArray();
            comboFrom.Focus();

            radioButtonReturn.Checked = true;

            dateTimeOut.MinDate = DateTime.Today;
            dateTimeReturn.MinDate = DateTime.Today;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panelBookFlight.BackColor = Color.FromArgb(150, Color.White);
            ControlPaint.DrawBorder(e.Graphics, panelBookFlight.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void radioButtonOneWay_CheckedChanged(object sender, EventArgs e)
        {
            lblTo.Hide();
            
            lblReturn.Hide();
            dateTimeReturn.Hide();
            Global.returnflight = false;
        }

        private void radioButtonReturn_CheckedChanged(object sender, EventArgs e)
        {
            lblTo.Show();
            comboTo.Show();
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panelDates.BackColor = Color.FromArgb(150, Color.White);
            ControlPaint.DrawBorder(e.Graphics, panelDates.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show("Are you sure you want to exit?", Global.appTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (response == DialogResult.OK)
            {
                // Close the program
                this.Close();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show("Are you sure you want to reset?", Global.appTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (response == DialogResult.OK)
            {
                comboFrom.Text = "Select Departure...";
                comboTo.Text = "Select Arrival...";
                comboCabin.Text = "Select Cabin...";
                lblGuestCount.Text = "1"; Global.guest = 1;
                radioButtonReturn.Checked = true;
                dateTimeOut.Value = DateTime.Today;
                dateTimeReturn.Value = DateTime.Today;
            }
        }
        private void btnSearchFlight_Click(object sender, EventArgs e)
        {
            if (comboFrom.Text == comboTo.Text)
            {
                MessageBox.Show("Please select a different destination from departure", "Departure / Destination duplicate", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                comboFrom.ForeColor = Color.IndianRed;
                comboFrom.ForeColor = Color.Black;
                return;
            }

            if (comboFrom.SelectedIndex < 0)
            {
                MessageBox.Show("Please select Destination to proceed", "Invalid Departure / Destination", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                comboFrom.ForeColor = Color.IndianRed;
                if (comboTo.SelectedIndex < 0)
                { comboTo.ForeColor = Color.IndianRed; }
                    return;
            }
            else { comboFrom.ForeColor = Color.Black; }
            if (comboTo.SelectedIndex < 0)

            { MessageBox.Show("Please select Arrival to proceed", "Invalid Departure / Destination", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                MessageBox.Show("Outbound Date cannot be later than Return Date", "Invalidate Date selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FormOutboundFlight f2 = new FormOutboundFlight();
            Form8 f8 = new Form8();
            this.Hide();
            f2.Show();
            f2.labelsum.Text = Global.flightfrom + " - " + Global.flightto;
            f2.label4.Text = dateTimeOut.Text + " - " + dateTimeReturn.Text;
            if (radioButtonOneWay.Checked)
            { f2.label6.Text = "One way flight"; }
            else
            { f2.label6.Text = len.Days.ToString() + " day(s)"; }
            f2.label9.Text = Global.guest.ToString();
            f2.label10.Text = Global.cabin.ToString();



           

            int destinationindex;
            string dur,price;
            
            destinationindex = comboFrom.SelectedIndex ;
            dur = flightduration[destinationindex].ToString();
            Global.duration = int.Parse(dur) ;
            price = pricelist[destinationindex].ToString();
            Global.coreticket = int.Parse(price);


            if (f2.label10.Text == "Economy")
            {
                Global.e1= Global.coreticket;
                Global.e2 = (Global.coreticket + 70);
                Global.e3 = (Global.coreticket + 120);
                Global.e4 = (Global.coreticket + 150);
                Global.e5 = (Global.coreticket - 30);
            }
            if (f2.label10.Text == "Business")
            {
                Global.b1 = (Global.coreticket * 2);
                Global.b2 = (Global.coreticket * 2 + 70);
                Global.b3 = (Global.coreticket * 2 + 120);
                Global.b4 = (Global.coreticket * 2 + 150);
                Global.b5 = (Global.coreticket * 2 - 30);

            }
            if (f2.label10.Text == "First Class")
            {
                Global.f1 = (Global.coreticket * 4);
                Global.f2= (Global.coreticket * 4 + 70);
                Global.f3 = (Global.coreticket * 4 + 120);
                Global.f4 = (Global.coreticket * 4 + 150);
                Global.f5 = (Global.coreticket * 4 - 30);


            }
            if (f2.label10.Text == "Economy")
            {
                f2.label56.Text = Global.e1.ToString("n0");
                f2.label57.Text = Global.e2.ToString("n0");
                f2.label58.Text = Global.e3.ToString("n0");
                f2.label59.Text = Global.e4.ToString("n0");
                f2.label60.Text = Global.e5.ToString("n0");
            }
            if (f2.label10.Text == "Business")
            {
                f2.label56.Text = Global.b1.ToString("n0");
                f2.label57.Text = Global.b2.ToString("n0");
                f2.label58.Text = Global.b3.ToString("n0");
                f2.label59.Text = Global.b4.ToString("n0");
                f2.label60.Text = Global.b5.ToString("n0");
            }
            if (f2.label10.Text == "First Class")
            {
                f2.label56.Text = Global.f1.ToString("n0");
                f2.label57.Text = Global.f2.ToString("n0");
                f2.label58.Text = Global.f3.ToString("n0");
                f2.label59.Text = Global.f4.ToString("n0");
                f2.label60.Text = Global.f5.ToString("n0");
            }

            //duration = int.Parse(dur);
            f2.label13.Text = "Flight Duration: " + Global.duration + " hours";
            f2.label24.Text = "Flight Duration: " + Global.duration + " hours";
            f2.label36.Text = "Flight Duration: " + Global.duration + " hours";
            f2.label42.Text = "Flight Duration: " + Global.duration + " hours";
            f2.label30.Text = "Flight Duration: " + Global.duration + " hours";

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

            f2.label49.Text = dur.ToString();

            if (to4 > 23)
            {
                to4 = to4 - 24;
                f2.label32.Text = "Non-stop flight (+1 day)";
            }
            if (to5 > 23)
            {
                to5 = to5 - 24;
                f2.label38.Text = "Non-stop flight (+1 day)";
            }

            f2.label15.Text = to1.ToString() + " : 00";
            f2.label16.Text = "Flight number: BN " + Global.fnumber.ToString();
            f2.label18.Text = "Airbus " + Global.fjet.ToString();

            f2.label22.Text = to2.ToString() + " : 00";
            f2.label21.Text = "Flight number: BN " + (Global.fnumber + 20).ToString();
            f2.label19.Text = "Airbus " + (Global.fjet + 12).ToString();

            f2.label28.Text = to3.ToString() + " : 00";
            f2.label27.Text = "Flight number: BN " + (Global.fnumber + 35).ToString();
            f2.label25.Text = "Airbus " + (Global.fjet + 22).ToString();

            f2.label34.Text = to4.ToString() + " : 00";
            f2.label33.Text = "Flight number: BN " + (Global.fnumber + 46).ToString();
            f2.label31.Text = "Airbus " + (Global.fjet + 32).ToString();

            f2.label40.Text = to5.ToString() + " : 00";
            f2.label39.Text = "Flight number: BN " + (Global.fnumber + 550).ToString();
            f2.label37.Text = "Airbus " + (Global.fjet + 42).ToString();

            if (Global.returnflight == true)
            {
                f2.label1.Text = "Two-way Route";
            }
            else
            {
                f2.label1.Text = "One-way Route";
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panelNews.BackColor = Color.FromArgb(150, Color.White);
            ControlPaint.DrawBorder(e.Graphics, panelNews.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            panelTicketSearch.BackColor = Color.FromArgb(150, Color.White);
            ControlPaint.DrawBorder(e.Graphics, panelTicketSearch.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void btnSearchTicket_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f8 = new Form8();
            f8.ShowDialog();
            this.Show();
        }
    }
}
