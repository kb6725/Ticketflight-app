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
    public partial class Form5 : Form
    {


       
        decimal price2=0,tick = 0,airfee=0,tax=0,total=0;

        decimal meal = 0, insu = 0, bag = 0, servicefee=0;


        public Form5()
        {
            InitializeComponent();
            tick = price2;
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = label10.Text;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(90, Color.White);


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

        private void button1_Click_1(object sender, EventArgs e)
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

            
            
            
            label10.Text = comboBox1.Text;

            if (label10.Text == "First Class")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(new object[]
                {
                 "A6",
                "A7",
                "A8",
                "B6",
                "B7",
                "B8",
                "C6",
                "C7",
                "C8",
                "D6",
                "D7",
                "D8",
                });



                label51.Text = (tick * 4).ToString("C1");
                
            }




            if (label10.Text == "Business")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(new object[]
                {
                "A9",
                "A10",
                "A11",
                "A12",
                "A13",
                "B9",
               "B10",
                "B11",
                "B12",
                "B13",
                "C9",
                "C10",
                "C11",
                "C12",
                "C13",
                "D9",
                "D10",
                "D11",
                "D12",
                "D13",
                });

                label51.Text = (tick * 2).ToString("C1");




            }



            if (label10.Text == "Economy")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(new object[]
 {

                "A14",
                "A15",
                "A16",
                "A17",
                "A18",
                "A19",
                "A20",
                "A21",
                "B14",
                "B15",
                "B16",
                "B17",
                "B18",
                "B19",
                "B20",
                "B21",
                "C14",
                "C15",
                "C16",
                "C17",
                "C18",
                "C19",
                "C20",
                "C21",
                "D14",
                "D15",
                "D16",
                "D17",
                "D18",
                "D19",
                "D20",
                "D21",
                 });

                label51.Text = (tick).ToString("C1");
            }
                
            

                servicefee = meal + insu + bag;
                label52.Text = servicefee.ToString("c1");



                label53.Text = (tick * 5 / 100).ToString("c1");
                label54.Text = (tick * 10/ 100).ToString("c1");
                total = tick + servicefee + (tick * 15 / 100);
             
                label55.Text = total.ToString("c1");

            
        }
            private void panel8_Paint(object sender, PaintEventArgs e)
            {
                panel8.BackColor = Color.FromArgb(90, Color.White);
            }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.Text == "No insurance - $0")
            { insu = 0; }
            if (comboBox4.Text == "Basic coverage - $15")
            { insu = 15; }
            if (comboBox4.Text == "Premium coverage - $30")
            { insu = 30; }
            servicefee = meal + insu + bag;
            label52.Text = servicefee.ToString("c1");
            tick = decimal.Parse(label51.Text.Substring(1));

            airfee = decimal.Parse(label53.Text.Substring(1));
            tax = decimal.Parse(label54.Text.Substring(1));
            total = tick + servicefee + airfee + tax;
            label55.Text = total.ToString("c1");

            
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.Text == "Carry on - $0")
            { bag = 0; }
            if (comboBox5.Text == "1 bag - $20")
            { bag = 20; }
            if (comboBox5.Text == "2 bags - $45")
            { bag = 45; }
            if (comboBox5.Text == "3 bags - $70")
            { bag = 70; }
            servicefee = meal + insu + bag;
            label52.Text = servicefee.ToString("c1");
            tick = decimal.Parse(label51.Text.Substring(1));
            airfee = decimal.Parse(label53.Text.Substring(1));
            tax = decimal.Parse(label54.Text.Substring(1));
            total = tick + servicefee + airfee + tax;
            label55.Text = total.ToString("c1");


            
        }

        private void label10_Click(object sender, EventArgs e)
            {
                panel10.BackColor = Color.FromArgb(90, Color.White);
            }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBox3.Text == "No Meal - $0")
            { meal = 0;}
            if (comboBox3.Text == "Regular Meal - $20")
            { meal = 20; }
            if (comboBox3.Text == "Vegetarian Meal - $22")
            { meal = 22; }
            servicefee = meal + insu + bag;


            tick = decimal.Parse(label51.Text.Substring(1));
            
            airfee = decimal.Parse(label53.Text.Substring(1));
            tax = decimal.Parse(label54.Text.Substring(1));
            total = tick + servicefee + airfee + tax;
            label55.Text = total.ToString("c1");


            label52.Text = servicefee.ToString("c1");
        }
    } 
    
    }
    

