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

        private void Form8_Load(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panelSummaryPrice.Visible = false;
            panel7.Visible = false;
            panel11.Visible = false;
            panel12.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panelSummaryPrice.BackColor = Color.FromArgb(180, Color.White);

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
            panelSearch.BackColor = Color.FromArgb(120, Color.White);
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
            ControlPaint.DrawBorder(e.Graphics, panelPrice.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panelSummary.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }
       
        private void button1_Click_2(object sender, EventArgs e)
        {
            if (maskedTxtBoxBookingNum.Text == "")
            { maskedTxtBoxBookingNum.BackColor = Color.IndianRed;return; }
            // search 
            string[] words = File.ReadAllText("data.txt").Split(',');
            string search = maskedTxtBoxBookingNum.Text;
            
            for (int i = 0; i < words.Length; i = i + 1)
            {
                if (words[i]==search)
                {
                    label12.Text = "";
                    label22.Text = words[i+1];
                    label23.Text = words[i+2];
                    label27.Text = words[i + 3];
                    label31.Text = words[i + 4];
                    label56.Text = words[i + 6];
                    label35.Text = words[i + 5];
                    label57.Text = words[i + 7];
                    label58.Text = words[i + 8];
                    label63.Text = words[i + 9];
                    label59.Text = words[i + 10];
                    label64.Text = words[i +11];
                    label60.Text = words[i +12];
                    label65.Text = words[i + 13];
                    label62.Text = words[i + 14];
                    label66.Text = words[i + 15];
                    labelsum.Text= (words[i + 16]+" - " +words[i+17]).ToString();
                    
                    label4.Text = (words[i + 18] + " - " + words[i + 19]).ToString();
                    label10.Text= words[i + 20];
                    label9.Text = words[i + 21];
                    label51.Text = "$"+words[i + 22];
                    label52.Text = "$" + words[i + 23];
                    label53.Text = "$" + words[i + 24];
                    label54.Text = "$" + words[i + 25];
                    label55.Text = "$" + words[i + 26];

                    label30.Text = words[i + 21];
                    label40.Text = "$" + words[i + 27];
                    Global.guest = int.Parse(words[i + 21]);
                    panel3.Visible = true;
                    panel4.Visible = true;

                    if (Global.guest == 2)
                    {
                        panel5.Visible = true;
                        panel6.Visible = true;

                        panel7.Visible = false;
                        panel11.Visible = false;
                        panel12.Visible = false;
                    }

                    if (Global.guest == 3)
                    {
                        panel5.Visible = true;
                        panel7.Visible = true;
                        panel6.Visible = true;
                        panel11.Visible = false;
                        panel12.Visible = false;
                    }

                    if (Global.guest == 4)
                    {
                        panel5.Visible = true;
                        panel7.Visible = true;
                        panel6.Visible = true;
                        panel11.Visible = true;
                        panel12.Visible = false;

                    }
                    if (Global.guest == 5)
                    {
                        panel5.Visible = true;
                        panel7.Visible = true;
                        panel6.Visible = true;
                        panel11.Visible = true;
                        panel12.Visible = true;
                    }


                    panelSummaryPrice.Visible = true;

                    break;
                }
                else
                {
                    label12.Text = "Record Not Found";
                    panel3.Visible = false;
                    panel4.Visible = false;
                    panel5.Visible = false;
                    panelSummaryPrice.Visible = false;
                }
                

            }




        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, EventArgs e)
        {
            
        }
        private void maskedTextBox1_textchange(object sender, EventArgs e)
        {
            if (maskedTxtBoxBookingNum.Text != "")
            { maskedTxtBoxBookingNum.BackColor = Color.White; }
        }
    }
    } 
    
    
    

