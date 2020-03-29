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
using System.Collections;
using System.Runtime.Remoting;

namespace flight1
{
    public partial class Form5 : Form
    {

        ArrayList firstclassseat = new ArrayList { "A6", "A7", "A8", "B6", "B7", "B8", "C6", "C7", "C8", "D6", "D7", "D8" };
        ArrayList bussclassseat = new ArrayList { "A9","A10","A11","A12","A13","B9","B10",
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
                "D13", };

        ArrayList ecoclassseat = new ArrayList {  "A14",
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
        };

        public Form5()
        {
            InitializeComponent();


        }

        private void Form5_Load(object sender, EventArgs e)
        {   if (Global.returnflight == true)

            { Global.duration = Global.duration * 2; }
            label49.Text = Global.duration.ToString();
            label62.Text = (Global.outticket + Global.returnticket).ToString("c1");
            // add dropdown selection 
            if (Global.cabin == "Economy")
            {

                comboBox1.Items.AddRange(new object[]
                {
                    "No, Keep my selection",
                    "Upgrade to Business (+250)",
                    "Upgrade to First Class (+800)"
                });

                label22.Visible = true;
                comboBox1.Visible = true;
                label24.Visible = true;

            }

            if (Global.cabin == "Business")
            {
                comboBox1.Items.AddRange(new object[]
                {
                    "No, Keep my selection",
                    "Upgrade to First Class (+500)"
                });
                label22.Visible = true;
                comboBox1.Visible = true;
                label24.Visible = true;

            }
            //First class have No upgrade
            if (Global.cabin == "First Class")
            {
                Global.cabinupgrade = "First Class";
                label22.Visible = false;
                comboBox1.Visible = false;
                comboBox1.SelectedText = "No, Keep my selection";
                label24.Visible = false;

                comboBox6.DataSource = firstclassseat.ToArray();
                comboBox2.DataSource = firstclassseat.ToArray();
                comboBox8.DataSource = firstclassseat.ToArray();
                comboBox9.DataSource = firstclassseat.ToArray();
                comboBox7.DataSource = firstclassseat.ToArray();

                if (Global.guest == 1)
                {
                    label13.Visible = true;
                    label25.Visible = false;
                    label26.Visible = false;
                    label27.Visible = false;
                    label28.Visible = false;
                    comboBox2.Visible = true;
                    comboBox6.Visible = false;
                    comboBox7.Visible = false;
                    comboBox8.Visible = false;
                    comboBox9.Visible = false;
                }
                if (Global.guest == 2)
                {
                    label13.Visible = true;
                    comboBox2.Visible = true;
                    label25.Visible = true;
                    label26.Visible = false;
                    label27.Visible = false;
                    label28.Visible = false;
                    comboBox6.Visible = true;
                    comboBox7.Visible = false;
                    comboBox8.Visible = false;
                    comboBox9.Visible = false;
                }
                if (Global.guest == 3)
                {
                    label13.Visible = true;
                    comboBox2.Visible = true;
                    label25.Visible = true;
                    label26.Visible = true;
                    label27.Visible = false;
                    label28.Visible = false;
                    comboBox6.Visible = true;
                    comboBox7.Visible = true;
                    comboBox8.Visible = false;
                    comboBox9.Visible = false;
                }
                if (Global.guest == 4)
                {
                    label13.Visible = true;
                    comboBox2.Visible = true;
                    label25.Visible = true;
                    label26.Visible = true;
                    label27.Visible = true;
                    label28.Visible = false;
                    comboBox6.Visible = true;
                    comboBox7.Visible = true;
                    comboBox8.Visible = true;
                    comboBox9.Visible = false;
                }
                if (Global.guest == 5)
                {
                    label13.Visible = true;
                    comboBox2.Visible = true;
                    label25.Visible = true;
                    label26.Visible = true;
                    label27.Visible = true;
                    label28.Visible = true;
                    comboBox6.Visible = true;
                    comboBox7.Visible = true;
                    comboBox8.Visible = true;
                    comboBox9.Visible = true;
                }
                comboBox6.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                comboBox8.SelectedIndex = -1;
                comboBox9.SelectedIndex = -1;
                comboBox7.SelectedIndex = -1;
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
            
            

            if (Global.cabin == "Economy")
            {
                if (comboBox1.Text == "Upgrade to First Class (+800)")
                {
                    Global.cabinupgrade = "First Class";
                    Global.upseat = 800 ;
                    label29.Visible = true;
                   
                }

                if (comboBox1.Text == "Upgrade to Business (+250)")
                {

                    Global.upseat = 250;
                    Global.cabinupgrade = "Business";
                    label29.Visible = true;
                }

                if (comboBox1.Text == "No, Keep my selection")
                {
                    Global.upseat = 0;
                    Global.cabinupgrade = "Economy";
                }

            }

            if (Global.cabin == "Business")
            {
                if (comboBox1.Text == "Upgrade to First Class (+500)")
                {

                    Global.cabinupgrade = "First Class";
                    Global.upseat = 500;
                    label29.Visible = true;
                }

                    if (comboBox1.Text == "No, Keep my selection")
                    {
                        Global.upseat = 0;
                    
                    Global.cabinupgrade = "Business";

                    }
                
            }
            if (Global.cabin == "First Class")
            { Global.cabinupgrade = "First Class"; }

                if (Global.cabinupgrade == "First Class")
                {
                    comboBox6.DataSource = firstclassseat.ToArray();
                    comboBox2.DataSource = firstclassseat.ToArray();
                    comboBox8.DataSource = firstclassseat.ToArray();
                    comboBox9.DataSource = firstclassseat.ToArray();
                    comboBox7.DataSource = firstclassseat.ToArray();
                    comboBox6.SelectedIndex = -1;
                    comboBox2.SelectedIndex = -1;
                    comboBox8.SelectedIndex = -1;
                    comboBox9.SelectedIndex = -1;
                    comboBox7.SelectedIndex = -1;
                }
                if (Global.cabinupgrade == "Business")
                {
                    comboBox6.DataSource = bussclassseat.ToArray();
                    comboBox2.DataSource = bussclassseat.ToArray();
                    comboBox8.DataSource = bussclassseat.ToArray();
                    comboBox9.DataSource = bussclassseat.ToArray();
                    comboBox7.DataSource = bussclassseat.ToArray();

                    comboBox6.SelectedIndex = -1;
                    comboBox2.SelectedIndex = -1;
                    comboBox8.SelectedIndex = -1;
                    comboBox9.SelectedIndex = -1;
                    comboBox7.SelectedIndex = -1;
                }
                if (Global.cabinupgrade == "Economy")
                {
                    comboBox6.DataSource = ecoclassseat.ToArray();
                    comboBox2.DataSource = ecoclassseat.ToArray();
                    comboBox8.DataSource = ecoclassseat.ToArray();
                    comboBox9.DataSource = ecoclassseat.ToArray();
                    comboBox7.DataSource = ecoclassseat.ToArray();

                    comboBox6.SelectedIndex = -1;
                    comboBox2.SelectedIndex = -1;
                    comboBox8.SelectedIndex = -1;
                    comboBox9.SelectedIndex = -1;
                    comboBox7.SelectedIndex = -1;
                }


                if (Global.guest == 1)
                {
                    label13.Visible = true;
                comboBox2.Visible = true;
                label25.Visible = false;
                label26.Visible = false;
                    label27.Visible = false;
                    label28.Visible = false;
                    comboBox2.Visible = true;
                    comboBox6.Visible = false;
                    comboBox7.Visible = false;
                    comboBox8.Visible = false;
                    comboBox9.Visible = false;
                }
                if (Global.guest == 2)
                {
                label13.Visible = true;
                comboBox2.Visible = true;
                label25.Visible = true;
                label26.Visible = false;
                    label27.Visible = false;
                    label28.Visible = false;
                    comboBox6.Visible = true;
                    comboBox7.Visible = false;
                    comboBox8.Visible = false;
                    comboBox9.Visible = false;
                }
                if (Global.guest == 3)
                {
                label13.Visible = true;
                comboBox2.Visible = true;
                label25.Visible = true;
                label26.Visible = true;
                    label27.Visible = false;
                    label28.Visible = false;
                    comboBox6.Visible = true;
                    comboBox7.Visible = true;
                    comboBox8.Visible = false;
                    comboBox9.Visible = false;
                }
                if (Global.guest == 4)
                {
                label13.Visible = true;
                comboBox2.Visible = true;
                label25.Visible = true;
                label26.Visible = true;
                    label27.Visible = true;
                    label28.Visible = false;
                    comboBox6.Visible = true;
                    comboBox7.Visible = true;
                    comboBox8.Visible = true;
                    comboBox9.Visible = false;
                }
                if (Global.guest == 5)
                {
                label13.Visible = true;
                comboBox2.Visible = true;
                label25.Visible = true;
                label26.Visible = true;
                    label27.Visible = true;
                    label28.Visible = true;
                    comboBox6.Visible = true;
                    comboBox7.Visible = true;
                    comboBox8.Visible = true;
                    comboBox9.Visible = true;
                }




                Global.servicefee = Global.meal + Global.insurance + Global.bag + Global.upseat;
                label52.Text = Global.servicefee.ToString("c1");

                label53.Text = (Global.airportfee).ToString("c1");
                label54.Text = (Global.tax).ToString("c1");


                label55.Text = Global.totaltick.ToString("c1");

            
        }
        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            panel8.BackColor = Color.FromArgb(120, Color.White);
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            Global.insurance = 0;

            if (comboBox4.Text == "No insurance - $0")
            { Global.insurance = 0;
               
            }
            if (comboBox4.Text == "Basic coverage - $15")
            { Global.insurance = 15;
                
            }
            if (comboBox4.Text == "Premium coverage - $30")
            { Global.insurance = 30;
               
            }

            Global.servicefee = Global.insurance + Global.bag + Global.meal + Global.upseat;
            label52.Text = Global.servicefee.ToString("c1");

            Global.totaltick = Global.outticket + Global.returnticket + Global.servicefee + Global.tax + Global.airportfee;
            label55.Text = Global.totaltick.ToString("c1");


        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            Global.bag = 0;
            if (comboBox5.Text == "Carry on - $0")
            
            Global.bag = 0; 
            if (comboBox5.Text == "1 bag - $20")
            { Global.bag = 20;
                
            }
            if (comboBox5.Text == "2 bags - $45")
            { Global.bag = 45;
                
            }
            if (comboBox5.Text == "3 bags - $70")
            { Global.bag = 70;
                
            }

            Global.servicefee = Global.insurance + Global.bag + Global.meal + Global.upseat;
            label52.Text = Global.servicefee.ToString("c1");

            Global.totaltick = Global.outticket + Global.returnticket + Global.servicefee + Global.tax + Global.airportfee;
            label55.Text = Global.totaltick.ToString("c1");



        }

        private void label10_Click(object sender, EventArgs e)
        {
            panel10.BackColor = Color.FromArgb(90, Color.White);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Global.meal = 0;
            if (comboBox3.Text == "No Meal - $0")
            { Global.meal = 0;
                
            }
            if (comboBox3.Text == "Regular Meal - $20")
            { Global.meal = 20;
                
            }
            if (comboBox3.Text == "Vegetarian Meal - $22")
            { Global.meal = 22;
                
            }

            Global.servicefee = Global.insurance + Global.bag + Global.meal + Global.upseat;
            label52.Text = Global.servicefee.ToString("c1");

            Global.totaltick = Global.outticket + Global.returnticket + Global.servicefee + Global.tax + Global.airportfee;
            label55.Text = Global.totaltick.ToString("c1");

        }
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();

            if (Global.guest == 5)
            {
                if (comboBox2.SelectedIndex != comboBox6.SelectedIndex && comboBox2.SelectedIndex != comboBox7.SelectedIndex && comboBox2.SelectedIndex != comboBox8.SelectedIndex && comboBox2.SelectedIndex != comboBox9.SelectedIndex && comboBox6.SelectedIndex != comboBox7.SelectedIndex && comboBox6.SelectedIndex != comboBox8.SelectedIndex && comboBox6.SelectedIndex != comboBox9.SelectedIndex && comboBox7.SelectedIndex != comboBox8.SelectedIndex && comboBox7.SelectedIndex != comboBox9.SelectedIndex && comboBox7.SelectedIndex != comboBox8.SelectedIndex && comboBox8.SelectedIndex != comboBox9.SelectedIndex)
                {
                    this.Hide();
                   
                    f6.Show();

                }


                else
                {
                    MessageBox.Show("Passengers' seats cannot be duplicated or blank","Invalid Seat Selection",MessageBoxButtons.OK, MessageBoxIcon.Warning );
                    comboBox2.SelectedIndex = -1;
                    comboBox6.SelectedIndex = -1;
                    comboBox7.SelectedIndex = -1;
                    comboBox8.SelectedIndex = -1;
                    comboBox9.SelectedIndex = -1;

                    return;
                }
            }

            if (Global.guest == 4)
            {
                if (comboBox2.SelectedIndex != comboBox6.SelectedIndex && comboBox2.SelectedIndex != comboBox7.SelectedIndex && comboBox2.SelectedIndex != comboBox8.SelectedIndex && comboBox6.SelectedIndex != comboBox7.SelectedIndex && comboBox6.SelectedIndex != comboBox8.SelectedIndex &&  comboBox7.SelectedIndex != comboBox8.SelectedIndex)
                {
                    this.Hide();
                   
                    f6.Show();

                }


                else
                {
                    MessageBox.Show("Passengers' seats cannot be duplicated");
                    comboBox2.SelectedIndex = -1;
                    comboBox6.SelectedIndex = -1;
                    comboBox7.SelectedIndex = -1;
                    comboBox8.SelectedIndex = -1;
                    comboBox9.SelectedIndex = -1;

                    return;
                }
            }
            if (Global.guest == 3)
            {
                if (comboBox2.SelectedIndex != comboBox6.SelectedIndex && comboBox2.SelectedIndex != comboBox7.SelectedIndex && comboBox6.SelectedIndex != comboBox7.SelectedIndex)
                {
                    this.Hide();
                    
                    f6.Show();

                }


                else
                {
                    MessageBox.Show("Passengers' seats cannot be duplicated");
                    comboBox2.SelectedIndex = -1;
                    comboBox6.SelectedIndex = -1;
                    comboBox7.SelectedIndex = -1;
                    comboBox8.SelectedIndex = -1;
                    comboBox9.SelectedIndex = -1;

                    return;
                }
            }
                if (Global.guest == 2)
                {
                    if (comboBox2.SelectedIndex != comboBox6.SelectedIndex )
                    {
                        this.Hide();
                        
                        f6.Show();

                    }


                    else
                    {
                        MessageBox.Show("Passengers' seats cannot be duplicated");
                        comboBox2.SelectedIndex = -1;
                        comboBox6.SelectedIndex = -1;
                        comboBox7.SelectedIndex = -1;
                        comboBox8.SelectedIndex = -1;
                        comboBox9.SelectedIndex = -1;

                        return;
                    }

                }
                if (Global.guest ==1)
            {
                this.Hide();
                
                f6.Show();
            }

               f6.labelsum.Text  = labelsum.Text;
            f6.label49.Text = label49.Text;
           f6.label4.Text  =  label4.Text;
           f6.label6.Text  = label6.Text;
           f6.label10.Text  = label10.Text;
           f6.label9.Text  = label9.Text;



        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        public void Combo()
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label51_Click(object sender, EventArgs e)
        {

        }
    }
} 
    
    
    

