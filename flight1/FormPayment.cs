﻿using Microsoft.Office.Interop.Word;
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

namespace flight1
{
    public partial class Form6 : Form
    {
        public Form6()
        {

            InitializeComponent();
            Cursor.Current = Cursors.WaitCursor;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            dateTimepicker.MaxDate = DateTime.Now;
            dateTimePicker1.MaxDate = DateTime.Now;
            dateTimePicker2.MaxDate = DateTime.Now;
            dateTimePicker3.MaxDate = DateTime.Now;
            dateTimePicker4.MaxDate = DateTime.Now;
            label30.Text = Global.guest.ToString();
            Global.finaltick = Global.guest * Global.totaltick;
            label40.Text = (Global.finaltick).ToString("c1");
            label51.Text = (Global.outticket + Global.returnticket).ToString("C1");
            label52.Text = Global.servicefee.ToString("c1");
            label53.Text = Global.airportfee.ToString("c1");
            label54.Text= Global.tax.ToString("c1");
            label55.Text =( Global.totaltick).ToString("c1");
            Global.finaltick = Global.totaltick * Global.guest;
            label40.Text = Global.finaltick.ToString("c1");

            if (Global.guest == 1)
            { panel5.Visible = false; }
            if (Global.guest == 2)
            {
                panel5.Visible = true;
                panel7.Visible = false;
                panel11.Visible = false;
                panel12.Visible = false; 
            }
            if (Global.guest == 3)
            {
                panel5.Visible = true;
                panel7.Visible = true;
                panel11.Visible = false;
                panel12.Visible = false;
            }
            if (Global.guest == 4)
            {
                panel5.Visible = true;
                panel7.Visible = true;
                panel11.Visible = true;
                panel12.Visible = false;
            }
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
            panel8.BackColor = Color.FromArgb(180, Color.White);
            
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panel3.BackColor = Color.FromArgb(220, Color.White);
            ControlPaint.DrawBorder(e.Graphics, panel3.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            { textBox1.BackColor = Color.IndianRed; }
            if (textBox3.Text == "")
            { textBox3.BackColor = Color.IndianRed; }
            if (textBox8.Text == "")
            { textBox8.BackColor = Color.IndianRed; }
            if (textBox10.Text == "")
            { textBox10.BackColor = Color.IndianRed; }
            if (textBox13.Text == "")
            { textBox13.BackColor = Color.IndianRed; }
            if (textBox16.Text == "")
            { textBox16.BackColor = Color.IndianRed; }
            if (textBox2.Text == "" || textBox2.Text.Contains("@")==false)
            { textBox2.BackColor = Color.IndianRed; }
           
            if (textBox4.Text == "")
            { textBox4.BackColor = Color.IndianRed; }
            if (comboBox1.Text == "")
            { comboBox1.BackColor = Color.IndianRed; }
            if (comboBox2.Text == "")
            { comboBox2.BackColor = Color.IndianRed; }
            if (maskedTextBox2.Text == "")
            { maskedTextBox2.BackColor = Color.IndianRed; }

            if (maskedTextBox1.Text== "(   )    -")
            { maskedTextBox1.BackColor = Color.IndianRed; }
            if (textBox11.Text == "")
            { textBox11.BackColor = Color.IndianRed; }
            if (textBox7.Text == "")
            { textBox7.BackColor = Color.IndianRed; }
            if (textBox14.Text == "")
            { textBox14.BackColor = Color.IndianRed; }

            if (textBox17.Text == "")
            { textBox17.BackColor = Color.IndianRed; }

            if (textBox5.Text == "")
            { textBox5.BackColor = Color.IndianRed; }

            if (textBox12.Text == "")
            { textBox12.BackColor = Color.IndianRed; }

            if (textBox15.Text == "")
            { textBox15.BackColor = Color.IndianRed; }
            if (textBox18.Text == "")
            { textBox18.BackColor = Color.IndianRed; }


            Global.servicefee = Global.meal + Global.insurance + Global.bag + Global.upseat;
            if (textBox2.TextLength > 1)
            {if (textBox2.Text.Contains( "@"))
                {

                }
                else 
                {
                    MessageBox.Show("Please enter valid email address", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return ; 
                }     
            }

            if (textBox1.TextLength < 1 || textBox3.TextLength < 1 || textBox2.TextLength < 1 || maskedTextBox1.TextLength < 1 || textBox8.TextLength < 1 || textBox10.TextLength < 1 || textBox13.TextLength < 1 || textBox16.TextLength < 1 || maskedTextBox2.TextLength < 1 || textBox4.TextLength < 1 || comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1 )
            {
                MessageBox.Show("Please input all Customer Information and Payment to proceed", "Missing Required Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Global.guest ==2)
            {
                if (textBox11.Text == "" || textBox5.Text == "")
                {
                    MessageBox.Show("Please input Information for all Passengers", "Missing Required Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if (Global.guest ==3)
            {
                if (textBox7.Text == "" || textBox12.Text == "" || textBox11.Text == "" || textBox5.Text == "")
                {
                    MessageBox.Show("Please input Information for all Passengers", "Missing Required Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if (Global.guest ==4)
            {
                if (textBox14.Text == "" || textBox15.Text == ""|| textBox7.Text == "" || textBox12.Text == "" || textBox11.Text == "" || textBox5.Text == "")
                {
                    MessageBox.Show("Please input Information for all Passengers", "Missing Required Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if (Global.guest ==5)
            {
                if (textBox17.Text == "" || textBox18.Text == ""|| textBox14.Text == "" || textBox15.Text == "" || textBox7.Text == "" || textBox12.Text == "" || textBox11.Text == "" || textBox5.Text == "")
                {
                    MessageBox.Show("Please input Information for all Passengers", "Missing Required Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }



            Form7 f7 = new Form7();
            Global.p1name = textBox1.Text;
            Global.p1pp = textBox3.Text;
            Global.p1email = textBox2.Text;
            
            Global.expmonth = comboBox1.Text;
            Global.expyear = comboBox2.Text;
            Global.cardname = textBox4.Text;
            Global.p2name = textBox11.Text;
            Global.p2pp = textBox5.Text;
            Global.p3name = textBox7.Text;
            Global.p3pp = textBox12.Text;
            Global.p4name = textBox14.Text;
            Global.p4pp = textBox15.Text;
            Global.p5name = textBox17.Text;
            Global.p5pp = textBox18.Text;
            
            Global.p1dob = dateTimepicker.Value;
            Global.p2dob = dateTimePicker1.Value;
            Global.p3dob = dateTimePicker2.Value;
            Global.p4dob = dateTimePicker3.Value;
            Global.p5dob = dateTimePicker4.Value;
            Global.phone = maskedTextBox1.Text;
            f7.labelsum.Text = labelsum.Text;
            f7.label49.Text = label49.Text;
            f7.label4.Text = label4.Text;
            f7.label6.Text = label6.Text;
            f7.label49.Text = label49.Text;
            f7.label10.Text = label10.Text;
            f7.label9.Text = label9.Text;

            f7.label56.Text = "**** " + textBox16.Text;

            try
            {
                Global.card1 = double.Parse(textBox8.Text);
                Global.card2 = double.Parse(textBox10.Text);
                Global.card3 = double.Parse(textBox13.Text);
                Global.card4= double.Parse(textBox16.Text);

                Global.cvv = double.Parse(maskedTextBox2.Text);
                
                this.Hide();
                f7.Show();
            }
            catch
            {
                MessageBox.Show("Please input 16-digit Card Number, 3-digit CVV number and Phone number", "Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
            }




        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            panel4.BackColor = Color.FromArgb(220, Color.White);
            ControlPaint.DrawBorder(e.Graphics, panel4.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            panel5.BackColor = Color.FromArgb(220, Color.White);
            ControlPaint.DrawBorder(e.Graphics, panel5.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox2.Text.Contains("@") == true)

            { textBox2.BackColor = Color.White; }

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox8.TextLength == 4)
            { textBox10.Focus(); }
          
            if (textBox8.Text != "")

            { textBox8.BackColor = Color.White; }

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.TextLength == 4)
            { textBox13.Focus(); }
            if (textBox10.Text != "")

            { textBox10.BackColor = Color.White; }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            if (textBox13.TextLength == 4)
            { textBox16.Focus(); }
            if (textBox13.Text != "")

            { textBox13.BackColor = Color.White; }
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            if (textBox16.Text != "")

            { textBox16.BackColor = Color.White; }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Text = textBox1.Text;
                textBox4.Enabled = false;
            }

            else
            { textBox4.Enabled = true; }
        }

        private void dateTimepicker_ValueChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true) 
            { textBox4.Text = textBox1.Text;  }
            else { textBox4.Text = ""; }
            if (textBox1.Text != "")

            { textBox1.BackColor = Color.White; }

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

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            this.Hide();
            f5.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            DialogResult res = new DialogResult();
            res = MessageBox.Show("Are you sure to Reset ?", "Reset prompt", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox8.Text = "";
                textBox10.Text = "";
                textBox13.Text = "";
                textBox16.Text = "";
                textBox4.Text = "";
                textBox11.Text = "";
                textBox14.Text = "";
                textBox7.Text = "";
                textBox17.Text = "";
                textBox5.Text = "";
                textBox12.Text = "";
                textBox15.Text = "";
                textBox18.Text = "";
                maskedTextBox2.Text = "";
                maskedTextBox1.Text = "";
                checkBox1.Checked = false;
                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;


            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != "")

            { textBox3.BackColor = Color.White; }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (maskedTextBox1.Text != "")

            { maskedTextBox1.BackColor = Color.White; }
        }
        private void maskedTextBox1_TextChange(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != "")

            { maskedTextBox1.BackColor = Color.White; }
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void maskedTextBox2_TextChange(object sender, EventArgs e)
        {
            if (maskedTextBox2.Text != "")

            { maskedTextBox2.BackColor = Color.White; }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)

            { comboBox1.BackColor = Color.White; }
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != -1)

            { comboBox2.BackColor = Color.White; }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text != "")

            { textBox4.BackColor = Color.White; }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (textBox11.Text != "" )

            { textBox11.BackColor = Color.White; }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text != "")

            { textBox7.BackColor = Color.White; }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            if (textBox14.Text != "")

            { textBox14.BackColor = Color.White; }
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            if (textBox17.Text != "")

            { textBox17.BackColor = Color.White; }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            if (textBox12.Text != "")

            { textBox12.BackColor = Color.White; }
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            if (textBox15.Text != "")

            { textBox15.BackColor = Color.White; }
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            if (textBox18.Text != "")

            { textBox18.BackColor = Color.White; }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text != "")

            { textBox5.BackColor = Color.White; }
        }
    } 
    
    }
    
