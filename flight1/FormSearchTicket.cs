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
    public partial class FormSearchTicket : Form
    {
        public FormSearchTicket()
        {
            InitializeComponent();
        }

        private void FormSearchTicket_Load(object sender, EventArgs e)
        {
            panelPriPassengerInfo.Visible = false;
            panelPaymentInfo.Visible = false;
            panelOtherInfo.Visible = false;
            panelSummaryPrice.Visible = false;
            panelOtherPass3.Visible = false;
            panelOtherPass4.Visible = false;
            panelOtherPass5.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (maskedTxtBoxBookingNum.Text == "")
            {
                maskedTxtBoxBookingNum.BackColor = Color.IndianRed;
                return;
            }

            string[] words = File.ReadAllText("data.txt").Split(',');
            string search = maskedTxtBoxBookingNum.Text;
            
            for (int i = 0; i < words.Length; i = i + 1)
            {
                if (words[i]==search)
                {
                    lblRecordError.Text = "";
                    lblPassFullNameOutput.Text = words[i+1];
                    lblDOBOutput.Text = words[i+2];
                    lblPassportNumOutput.Text = words[i + 3];
                    lblEmailOutput.Text = words[i + 4];
                    lblCardNumOutput.Text = words[i + 6];
                    lblPhoneNumOutput.Text = words[i + 5];
                    lblCardNameOutput.Text = words[i + 7];
                    lblPass2NameOutput.Text = words[i + 8];
                    lblPass2PassportOutput.Text = words[i + 9];
                    lblPass3NameOutput.Text = words[i + 10];
                    lblPass3PassportOutput.Text = words[i +11];
                    lblPass4NameOutput.Text = words[i +12];
                    lblPass4PassportOutput.Text = words[i + 13];
                    lblPass5NameOutput.Text = words[i + 14];
                    lblPass5PassportOutput.Text = words[i + 15];
                    lblRouteOutput.Text= (words[i + 16]+" - " +words[i+17]).ToString();
                    
                    lblDateOutput.Text = (words[i + 18] + " - " + words[i + 19]).ToString();
                    lblCabinOutput.Text= words[i + 20];
                    lblGuestOutput.Text = words[i + 21];
                    lblTicketPricePassengerOutput.Text = "$"+words[i + 22];
                    lblServiceFeeOutput.Text = "$" + words[i + 23];
                    lblAirportFeeOutput.Text = "$" + words[i + 24];
                    lblTaxOutput.Text = "$" + words[i + 25];
                    lblTotalPricePassengerOutput.Text = "$" + words[i + 26];

                    lblNumPassengersOutput.Text = words[i + 21];
                    lblTotalTicketPriceOutput.Text = "$" + words[i + 27];
                    Global.guest = int.Parse(words[i + 21]);
                    panelPriPassengerInfo.Visible = true;
                    panelPaymentInfo.Visible = true;

                    if (Global.guest == 2)
                    {
                        panelOtherInfo.Visible = true;
                        panelOtherPass2.Visible = true;

                        panelOtherPass3.Visible = false;
                        panelOtherPass4.Visible = false;
                        panelOtherPass5.Visible = false;
                    }
                    else if (Global.guest == 3)
                    {
                        panelOtherInfo.Visible = true;
                        panelOtherPass3.Visible = true;
                        panelOtherPass2.Visible = true;
                        panelOtherPass4.Visible = false;
                        panelOtherPass5.Visible = false;
                    }
                    else if (Global.guest == 4)
                    {
                        panelOtherInfo.Visible = true;
                        panelOtherPass3.Visible = true;
                        panelOtherPass2.Visible = true;
                        panelOtherPass4.Visible = true;
                        panelOtherPass5.Visible = false;
                    }
                    else if (Global.guest == 5)
                    {
                        panelOtherInfo.Visible = true;
                        panelOtherPass3.Visible = true;
                        panelOtherPass2.Visible = true;
                        panelOtherPass4.Visible = true;
                        panelOtherPass5.Visible = true;
                    }

                    panelSummaryPrice.Visible = true;
                    return;
                }
                else
                {
                    lblRecordError.Text = "Record Not Found";
                    panelPriPassengerInfo.Visible = false;
                    panelPaymentInfo.Visible = false;
                    panelOtherInfo.Visible = false;
                    panelSummaryPrice.Visible = false;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maskedTxtBoxBookingNum_TextChanged(object sender, EventArgs e)
        {
            if (maskedTxtBoxBookingNum.Text != "")
            {
                maskedTxtBoxBookingNum.BackColor = Color.White;
            }
        }

        // Painting for fancy transparency & outlines
        private void panelSummaryPrice_Paint(object sender, PaintEventArgs e)
        {
            panelSummaryPrice.BackColor = Color.FromArgb(180, Color.White);
        }

        private void panelSearch_Paint(object sender, PaintEventArgs e)
        {
            panelSearch.BackColor = Color.FromArgb(120, Color.White);
        }

        private void panelPriPassengerInfo_Paint(object sender, PaintEventArgs e)
        {
            panelPriPassengerInfo.BackColor = Color.FromArgb(200, Color.White);
            ControlPaint.DrawBorder(e.Graphics, panelPriPassengerInfo.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void panelPaymentInfo_Paint(object sender, PaintEventArgs e)
        {
            panelPaymentInfo.BackColor = Color.FromArgb(200, Color.White);
            ControlPaint.DrawBorder(e.Graphics, panelPaymentInfo.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void panelOtherInfo_Paint(object sender, PaintEventArgs e)
        {
            panelOtherInfo.BackColor = Color.FromArgb(200, Color.White);
            ControlPaint.DrawBorder(e.Graphics, panelOtherInfo.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void panelTotals_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panelTotals.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void panelPrice_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panelPrice.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void panelSummary_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panelSummary.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }
    }
} 
    
    
    

