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
    public partial class Form7 : Form
    {
       
        public Form7()
        {

            InitializeComponent();
            Cursor.Current = Cursors.WaitCursor;
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            
            Random rd = new Random();
            Global.booknum  = rd.Next(100000, 999999);
            label20.Text = "Your Booking number is : " + Global.booknum;


            label22.Text = Global.p1name;
            label23.Text = Global.p1dob.ToShortDateString();
            label27.Text = Global.p1pp;
            label31.Text = Global.p1email;
            label35.Text = Global.phone.ToString();
            label57.Text = Global.cardname;
            
            
            label58.Text = Global.p2name;
            label59.Text = Global.p3name;
            label60.Text = Global.p4name;
            label62.Text = Global.p5name;

            label63.Text = Global.p2pp;
            label64.Text = Global.p3pp;
            label65.Text = Global.p4pp;
            label66.Text = Global.p5pp;

            if (Global.guest == 1)
            { panel5.Visible = false; }
            if (Global.guest == 2)
            { panel5.Visible = true;
                panel6.Visible = true;
                panel7.Visible = false;
                panel11.Visible = false;
                panel12.Visible = false;

            }
            if (Global.guest == 3)
            {
                panel5.Visible = true;
                panel6.Visible = true;
                panel7.Visible = true;
                panel11.Visible = false;
                panel12.Visible = false;

            }
            if (Global.guest == 4)
            {
                panel5.Visible = true;
                panel6.Visible = true;
                panel7.Visible = true;
                panel11.Visible = true;
                panel12.Visible = false;

            }
            if (Global.guest == 5)
            {
                panel5.Visible = true;
                panel6.Visible = true;
                panel7.Visible = true;
                panel11.Visible = true;
                panel12.Visible = true;

            }

            label51.Text = (Global.outticket + Global.returnticket).ToString ("C1");
            label52.Text = Global.servicefee.ToString("C1");
            label53.Text = Global.airportfee.ToString("C1");
            label54.Text = Global.tax.ToString("C1");
            label55.Text = Global.totaltick.ToString("C1");
            label30.Text = Global.guest.ToString();
            label40.Text = Global.finaltick.ToString("C1");
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

        private void label54_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {



        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            

           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

   
        }
            private void panel8_Paint(object sender, PaintEventArgs e)
            {
            panel8.BackColor = Color.FromArgb(120, Color.White);
             }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
          

        }

        private void label10_Click(object sender, EventArgs e)
            {
                
            }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
        

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panel3.BackColor = Color.FromArgb(200, Color.White);
            ControlPaint.DrawBorder(e.Graphics, panel3.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            panel4.BackColor = Color.FromArgb(200, Color.White);
            ControlPaint.DrawBorder(e.Graphics, panel4.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            panel5.BackColor = Color.FromArgb(200, Color.White);
            ControlPaint.DrawBorder(e.Graphics, panel5.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel10.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel9.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel2.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

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
            oPara16.Range.Text = "Flight Route : " + labelsum.Text + "\t\t\t" + "Flight Date : " + label4.Text;
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
            oWord.Quit();



        }
            
        }
    } 
    
    
    

