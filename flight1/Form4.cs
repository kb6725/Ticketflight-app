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


    public partial class Form4 : Form
    {
        Form5 f5 = new Form5();



        public Form4()
        {
            InitializeComponent();


        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
           


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(90, Color.White);
            panel8.BackColor = Color.FromArgb(90, Color.White);
            panel3.BackColor = Color.FromArgb(240, Color.White);
            panel4.BackColor = Color.FromArgb(240, Color.White);
            panel5.BackColor = Color.FromArgb(240, Color.White);
            panel6.BackColor = Color.FromArgb(240, Color.White);
            panel7.BackColor = Color.FromArgb(240, Color.White);


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
            this.Hide();

            
            decimal price2 = 0, outboundprice = 0, returnprice = 0;

            outboundprice = decimal.Parse(label56.Text.Substring(1));
            returnprice = decimal.Parse(label57.Text);
            price2 = returnprice + outboundprice;

            f5.label51.Text = price2.ToString("c1");
            f5.label53.Text = ((decimal)price2 * 5 / 100).ToString("c1");
            f5.label54.Text = ((decimal)price2 * 10 / 100).ToString("c1");
            f5.label55.Text = (price2 + ((decimal)price2 * 15 / 100)).ToString("c1");



            f5.Show();
            f5.label10.Text = label10.Text;
            f5.comboBox1.SelectedItem = label10.Text;
            if (f5.label10.Text == "First Class")
            {
                f5.comboBox2.Items.Clear();
                f5.comboBox2.Items.AddRange(new object[]
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

            }




            if (f5.label10.Text == "Business")
            {
                f5.comboBox2.Items.Clear();
                f5.comboBox2.Items.AddRange(new object[]
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


            }



            if (f5.label10.Text == "Economy")
            {
               f5.comboBox2.Items.Clear();
                f5.comboBox2.Items.AddRange(new object[]
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

            }

            f5.labelsum.Text = labelsum.Text;
            f5.label49.Text = label49.Text;
            f5.label6.Text = label6.Text;
            f5.label10.Text= label10.Text;
            f5.label9.Text = label9.Text;
            f5.label4.Text = label4.Text;

           


            

        }

        private void button2_Click(object sender, EventArgs e)
        {

            button1.PerformClick();
            ;
            decimal price2 = 0, outboundprice = 0, returnprice = 0;
            outboundprice = decimal.Parse(label56.Text.Substring(1));
            returnprice = decimal.Parse(label52.Text);
            price2 = returnprice + outboundprice;
            f5.label51.Text = price2.ToString("c1");
            f5.label53.Text = ((decimal)price2 * 5 / 100).ToString("c1");
            f5.label54.Text = ((decimal)price2 * 10 / 100).ToString("c1");
            f5.label55.Text = (price2 + ((decimal)price2 * 15 / 100)).ToString("c1");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.PerformClick();

            decimal price2 = 0, outboundprice = 0, returnprice = 0;
            outboundprice = decimal.Parse(label56.Text.Substring(1));
            returnprice = decimal.Parse(label53.Text);
            price2 = returnprice + outboundprice;
            f5.label51.Text = price2.ToString("c1");
            f5.label53.Text = ((decimal)price2 * 5 / 100).ToString("c1");
            f5.label54.Text = ((decimal)price2 * 10 / 100).ToString("c1");
            f5.label55.Text = (price2 + ((decimal)price2 * 15 / 100)).ToString("c1");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.PerformClick();

            decimal price2 = 0, outboundprice = 0, returnprice = 0;
            outboundprice = decimal.Parse(label54.Text.Substring(1));
            returnprice = decimal.Parse(label54.Text);
            price2 = returnprice + outboundprice;
            f5.label51.Text = price2.ToString("c1");
            f5.label53.Text = ((decimal)price2 * 5 / 100).ToString("c1");
            f5.label54.Text = ((decimal)price2 * 10 / 100).ToString("c1");
            f5.label55.Text = (price2 + ((decimal)price2 * 15 / 100)).ToString("c1");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.PerformClick();

            decimal price2 = 0, outboundprice = 0, returnprice = 0;
            outboundprice = decimal.Parse(label56.Text.Substring(1));
            returnprice = decimal.Parse(label55.Text);
            price2 = returnprice + outboundprice;
            f5.label51.Text = price2.ToString("c1");
            f5.label53.Text = ((decimal)price2 * 5 / 100).ToString("c1");
            f5.label54.Text = ((decimal)price2 * 10 / 100).ToString("c1");
            f5.label55.Text = (price2 + ((decimal)price2 * 15 / 100)).ToString("c1");
        }
    }
}
