using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using Microsoft.Office;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.Word;
using WordApplication = Microsoft.Office.Interop.Word.Application;
using System.IO;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Reflection;
using Xceed.Words.NET;

namespace flight1
{
    public partial class FormConfirmed : Form
    {
        public FormConfirmed()
        {
            InitializeComponent();
        }

        private void FormConfirmed_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            Global.booknum  = rand.Next(100000, 999999);
            lblBookingNumber.Text = "Your Booking number is : " + Global.booknum;


            lblPassFullNameOutput.Text = Global.p1name;
            lblDOBOutput.Text = Global.p1dob.ToShortDateString();
            lblPassportNumOutput.Text = Global.p1pp;
            lblEmailOutput.Text = Global.p1email;
            lblPhoneOutput.Text = Global.phone.ToString();
            lblCardNameOutput.Text = Global.cardname;
            
            
            lblPass2NameOutput.Text = Global.p2name;
            lblPass3NameOutput.Text = Global.p3name;
            lblPass4NameOutput.Text = Global.p4name;
            lblPass5NameOutput.Text = Global.p5name;

            lblPass2PassportOutput.Text = Global.p2pp;
            lblPass3PassportOutput.Text = Global.p3pp;
            lblPass4PassportOutput.Text = Global.p4pp;
            lblPass5PassportOutput.Text = Global.p5pp;

            if (Global.guest == 1)
            {
                panelOtherPassInfo.Visible = false;
            }
            if (Global.guest == 2)
            { panelOtherPassInfo.Visible = true;
                panelPass2.Visible = true;
                panelPass3.Visible = false;
                panelPass4.Visible = false;
                panelPass5.Visible = false;
            }
            if (Global.guest == 3)
            {
                panelOtherPassInfo.Visible = true;
                panelPass2.Visible = true;
                panelPass3.Visible = true;
                panelPass4.Visible = false;
                panelPass5.Visible = false;
            }
            if (Global.guest == 4)
            {
                panelOtherPassInfo.Visible = true;
                panelPass2.Visible = true;
                panelPass3.Visible = true;
                panelPass4.Visible = true;
                panelPass5.Visible = false;
            }
            if (Global.guest == 5)
            {
                panelOtherPassInfo.Visible = true;
                panelPass2.Visible = true;
                panelPass3.Visible = true;
                panelPass4.Visible = true;
                panelPass5.Visible = true;
            }

            lblTicketPricePassengerOutput.Text = (Global.outticket + Global.returnticket).ToString ("C1");
            lblServiceFeeOutput.Text = Global.servicefee.ToString("C1");
            lblAirportFeeOutput.Text = Global.airportfee.ToString("C1");
            lblTaxOutput.Text = Global.tax.ToString("C1");
            lblTotalPricePassengerOutput.Text = Global.totaltick.ToString("C1");
            lblNumPassengersOutput.Text = Global.guest.ToString();
            lblTotalTicketPriceOutput.Text = Global.finaltick.ToString("C1");



            Global.outandreturnticket = Global.outticket + Global.returnticket;

            // Save ticket to data.txt so user can look it up on FormSearchTicket
            StreamWriter stream;
            if (File.Exists("data.txt"))
            {
                stream = File.AppendText("data.txt");
            }
            else
            {
                stream = File.CreateText("data.txt");
            }
            stream.WriteLine("," + Global.booknum + "," + Global.p1name + "," + Global.p1dob.ToShortDateString() + "," + Global.p1pp + "," + Global.p1email + "," + Global.phone + "," + Global.card4 + "," + Global.cardname + "," + Global.p2name + "," + Global.p2pp + "," + Global.p3name + "," + Global.p3pp + "," + Global.p4name + "," + Global.p4pp + "," + Global.p5name + "," + Global.p5pp + "," + Global.flightfrom + "," + Global.flightto + "," + Global.fromdate.ToShortDateString() + "," + Global.todate.ToShortDateString() + "," + Global.cabinupgrade + "," + Global.guest + "," + Global.outandreturnticket + "," + Global.servicefee + "," + Global.airportfee + "," + Global.tax + "," + Global.totaltick + "," + Global.finaltick + ",");
            stream.Close();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            // export ticket
            object oMissing = System.Reflection.Missing.Value;
            object oEndOfDoc = "\\endofdoc";

            Microsoft.Office.Interop.Word._Application oWord;
            Microsoft.Office.Interop.Word._Document oDoc;
            oWord = new Microsoft.Office.Interop.Word.Application();
            oWord.Visible = true;
            oDoc = oWord.Documents.Add(ref oMissing, ref oMissing, ref oMissing, ref oMissing);


            Range range = oDoc.Range();

            Microsoft.Office.Interop.Word.Paragraph oPara1;
            oPara1 = oDoc.Content.Paragraphs.Add(ref oMissing);
            oPara1.Range.Text = "Ticket Summary";
            oPara1.Range.Font.Bold = 1;
            oPara1.Range.Font.Size = 20;
            oPara1.Format.SpaceAfter = 4;

            oPara1.Range.InsertParagraphAfter();
            Microsoft.Office.Interop.Word.Paragraph oPara13;
            oPara13 = oDoc.Content.Paragraphs.Add(ref oMissing);
            oPara13.Range.Text = "Booking Number : " + Global.booknum;
            oPara13.Range.Font.Bold = 0;
            oPara13.Range.Font.Size = 12;
            oPara13.Format.SpaceAfter = 4;
            oPara13.Range.InsertParagraphAfter();

            Microsoft.Office.Interop.Word.Paragraph oPara14;
            oPara14 = oDoc.Content.Paragraphs.Add(ref oMissing);
            oPara14.Range.Text = "Payment Status : Confirmed" + "\n" + "Amount Paid : $" + Global.finaltick;
            oPara14.Range.Font.Bold = 0;
            oPara14.Range.Font.Size = 12;

            oPara14.Format.SpaceAfter = 40;
            oPara14.Range.InsertParagraphAfter();

            Microsoft.Office.Interop.Word.Paragraph oPara15;
            oPara15 = oDoc.Content.Paragraphs.Add(ref oMissing);
            oPara15.Range.Text = "Flight Information";
            oPara15.Range.Font.Bold = 1;
            oPara15.Range.Font.Size = 14;
            oPara15.Format.SpaceAfter = 12;
            oPara15.Range.InsertParagraphAfter();
            Microsoft.Office.Interop.Word.Paragraph oPara16;
            oPara16 = oDoc.Content.Paragraphs.Add(ref oMissing);
            oPara16.Range.Text = "Flight Route : " + lblRouteOutput.Text + "\t\t\t" + "Flight Date : " + lblDateOutput.Text;
            oPara16.Range.Font.Bold = 0;
            oPara16.Range.Font.Size = 12;
            oPara16.Format.SpaceAfter = 4;
            oPara16.Range.InsertParagraphAfter();
            Microsoft.Office.Interop.Word.Paragraph oPara17;
            oPara17 = oDoc.Content.Paragraphs.Add(ref oMissing);
            oPara17.Range.Text = "Cabin : " + Global.cabin + "\t\t\t\t\t" + "Guest : " + Global.guest;
            oPara17.Range.Font.Bold = 0;
            oPara17.Range.Font.Size = 12;
            oPara17.Format.SpaceAfter = 24;
            oPara17.Range.InsertParagraphAfter();

            Microsoft.Office.Interop.Word.Paragraph oPara2;
            oPara2 = oDoc.Content.Paragraphs.Add(ref oMissing);
            oPara2.Range.Text = "Primary Passenger Information";
            oPara2.Range.Font.Bold = 1;
            oPara2.Range.Font.Size = 14;
            oPara2.Format.SpaceAfter = 12;
            oPara2.Range.InsertParagraphAfter();
            Microsoft.Office.Interop.Word.Paragraph oPara3;
            oPara3 = oDoc.Content.Paragraphs.Add(ref oMissing);
            oPara3.Range.Text = "Passenger's Full Name : " + Global.p1name;


            oPara3.Range.Font.Bold = 0;
            oPara3.Range.Font.Size = 12;
            oPara3.Format.SpaceAfter = 4;


            oPara3.Range.InsertParagraphAfter();
            Microsoft.Office.Interop.Word.Paragraph oPara4;
            oPara4 = oDoc.Content.Paragraphs.Add(ref oMissing);
            oPara4.Range.Text = "Date of Birth :  " + Global.p1dob.ToShortDateString() + "\t\t\t\t\t" + "Phone number : " + Global.phone;
            oPara4.Range.Font.Bold = 0;
            oPara4.Range.Font.Size = 12;
            oPara4.Format.SpaceAfter = 4;
            oPara4.Range.InsertParagraphAfter();
            Microsoft.Office.Interop.Word.Paragraph oPara5;
            oPara5 = oDoc.Content.Paragraphs.Add(ref oMissing);
            oPara5.Range.Text = "Passport Number :  " + Global.p1pp;
            oPara5.Range.Font.Bold = 0;
            oPara5.Range.Font.Size = 12;
            oPara5.Format.SpaceAfter = 24;
            oPara5.Range.InsertParagraphAfter();

            Microsoft.Office.Interop.Word.Paragraph oPara6;
            oPara6 = oDoc.Content.Paragraphs.Add(ref oMissing);
            oPara6.Range.Text = "Payment Information";
            oPara6.Range.Font.Bold = 1;
            oPara6.Range.Font.Size = 14;
            oPara6.Format.SpaceAfter = 12;
            oPara6.Range.InsertParagraphAfter();
            Microsoft.Office.Interop.Word.Paragraph oPara7;
            oPara7 = oDoc.Content.Paragraphs.Add(ref oMissing);
            oPara7.Range.Text = "Card Number : **** " + Global.card4 + "\t\t\t\t\t" + "Cardholder's Name : " + Global.cardname;
            oPara7.Range.Font.Bold = 0;
            oPara7.Range.Font.Size = 12;
            oPara7.Format.SpaceAfter = 24;
            oPara7.Range.InsertParagraphAfter();
            if (Global.guest > 1)
            {
                Microsoft.Office.Interop.Word.Paragraph oPara8;
                oPara8 = oDoc.Content.Paragraphs.Add(ref oMissing);
                oPara8.Range.Text = "Other Passenger Information";
                oPara8.Range.Font.Bold = 1;
                oPara8.Range.Font.Size = 14;
                oPara8.Format.SpaceAfter = 12;
                oPara8.Range.InsertParagraphAfter();
                Microsoft.Office.Interop.Word.Paragraph oPara9;
                oPara9 = oDoc.Content.Paragraphs.Add(ref oMissing);
                oPara9.Range.Text = "Passenger 2 Name : " + Global.p2name + "\t\t\t\t" + "Passport : " + Global.p2pp;
                oPara9.Range.Font.Bold = 0;
                oPara9.Range.Font.Size = 12;
                oPara9.Format.SpaceAfter = 12;
                oPara9.Range.InsertParagraphAfter();
                if (Global.guest > 2)
                {
                    Microsoft.Office.Interop.Word.Paragraph oPara10;
                    oPara10 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara10.Range.Text = "Passenger 3 Name : " + Global.p3name + "\t\t\t\t" + "Passport : " + Global.p3pp;
                    oPara10.Range.Font.Bold = 0;
                    oPara10.Range.Font.Size = 12;
                    oPara10.Format.SpaceAfter = 12;
                    oPara10.Range.InsertParagraphAfter();

                    if (Global.guest > 3)
                    {
                        Microsoft.Office.Interop.Word.Paragraph oPara11;
                        oPara11 = oDoc.Content.Paragraphs.Add(ref oMissing);
                        oPara11.Range.Text = "Passenger 4 Name : " + Global.p4name + "\t\t\t\t" + "Passport : " + Global.p4pp;
                        oPara11.Range.Font.Bold = 0;
                        oPara11.Range.Font.Size = 12;
                        oPara11.Format.SpaceAfter = 12;
                        oPara11.Range.InsertParagraphAfter();

                        if (Global.guest > 4)
                        {
                            Microsoft.Office.Interop.Word.Paragraph oPara12;
                            oPara12 = oDoc.Content.Paragraphs.Add(ref oMissing);
                            oPara12.Range.Text = "Passenger 5 Name : " + Global.p5name + "\t\t\t\t" + "Passport : " + Global.p5pp;
                            oPara12.Range.Font.Bold = 0;
                            oPara12.Range.Font.Size = 12;
                            oPara12.Format.SpaceAfter = 12;
                            oPara12.Range.InsertParagraphAfter();
                        }
                    }
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show("Are you sure you want to go to the homepage?", Global.appTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (response == DialogResult.OK)
            {
                FormMain f1 = new FormMain();
                f1.Show();
                this.Hide();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show("Are you sure you want to exit?", Global.appTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (response == DialogResult.OK)
            {
                // Close the program
                System.Windows.Forms.Application.Exit();
            }
        }

        // Painting for fancy transparency & outlines
        private void panelSummaryPrice_Paint(object sender, PaintEventArgs e)
        {
            panelSummaryPrice.BackColor = Color.FromArgb(180, Color.White);

        }
        private void panelConfirmed_Paint(object sender, PaintEventArgs e)
        {
            panelConfirmed.BackColor = Color.FromArgb(120, Color.White);
        }

        private void panelPrimaryPassInfo_Paint(object sender, PaintEventArgs e)
        {
            panelPrimaryPassInfo.BackColor = Color.FromArgb(200, Color.White);
            ControlPaint.DrawBorder(e.Graphics, panelPrimaryPassInfo.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void panelPaymentInfo_Paint(object sender, PaintEventArgs e)
        {
            panelPaymentInfo.BackColor = Color.FromArgb(200, Color.White);
            ControlPaint.DrawBorder(e.Graphics, panelPaymentInfo.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void panelOtherPassInfo_Paint(object sender, PaintEventArgs e)
        {
            panelOtherPassInfo.BackColor = Color.FromArgb(200, Color.White);
            ControlPaint.DrawBorder(e.Graphics, panelOtherPassInfo.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void panelTotals_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panelTotals.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void panelPrice_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panelPrice.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void panelFlightSummary_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panelFlightSummary.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }
    }
} 
    
    
    

