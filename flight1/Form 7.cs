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
    public partial class Form7 : Form
    {
        public Form7()
        {

            InitializeComponent();

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            
            Random rd = new Random();
            Global.booknum  = rd.Next(100000, 999999);
            label20.Text = "Your Booking number is : " + Global.booknum;


            label22.Text = Global.p1name;
            label23.Text = Global.p1dob.ToString();
            label27.Text = Global.p1pp;
            label31.Text = Global.p1email;
            label35.Text = Global.phone.ToString();
            label57.Text = Global.cardname;
            label56.Text = "**** "+Global.card4.ToString();
            
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
            panel3.BackColor = Color.FromArgb(220, Color.White);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            panel4.BackColor = Color.FromArgb(220, Color.White);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            panel5.BackColor = Color.FromArgb(220, Color.White);
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
    } 
    
    }
    

