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
    public partial class FormFlightSeatExtra : Form
    {
        ArrayList firstclassseat = new ArrayList { "A6", "A7", "A8", "B6", "B7", "B8", "C6", "C7", "C8", "D6", "D7", "D8" };
        ArrayList bussclassseat = new ArrayList { "A9", "A10", "A11", "A12", "A13", "B9", "B10", "B11", "B12", "B13", "C9",
            "C10", "C11", "C12", "C13", "D9", "D10", "D11", "D12", "D13" };
        ArrayList ecoclassseat = new ArrayList { "A14", "A15", "A16", "A17", "A18", "A19", "A20", "A21", "B14", "B15", "B16",
            "B17", "B18", "B19", "B20", "B21", "C14", "C15", "C16", "C17", "C18", "C19", "C20", "C21", "D14", "D15", "D16",
            "D17", "D18", "D19", "D20", "D21" };

        public FormFlightSeatExtra()
        {
            InitializeComponent();
        }

        private void FormFlightSeatExtra_Load(object sender, EventArgs e)
        {
            if (Global.returnflight == true)

            { Global.duration = Global.duration * 2; }
            lblDurationOutput.Text = Global.duration.ToString();
            
            lblTicketPricePassengerOutput.Text = (Global.outticket + Global.returnticket).ToString("c1");
            // add dropdown selection 
            if (Global.cabin == "Economy")
            {
                comboBoxSeatUpgrade.Items.AddRange(new object[]
                {
                    "No, Keep my selection",
                    "Upgrade to Business (+250)",
                    "Upgrade to First Class (+800)"
                });

                lblSeatUpgrade.Visible = true;
                comboBoxSeatUpgrade.Visible = true;
                lblSeatInfo.Visible = true;
            }

            if (Global.cabin == "Business")
            {
                comboBoxSeatUpgrade.Items.AddRange(new object[]
                {
                    "No, Keep my selection",
                    "Upgrade to First Class (+500)"
                });
                lblSeatUpgrade.Visible = true;
                comboBoxSeatUpgrade.Visible = true;
                lblSeatInfo.Visible = true;
            }
            //First class have No upgrade
            if (Global.cabin == "First Class")
            {
                Global.cabinupgrade = "First Class";
                lblSeatUpgrade.Visible = false;
                comboBoxSeatUpgrade.Visible = false;
                comboBoxSeatUpgrade.SelectedText = "No, Keep my selection";
                lblSeatInfo.Visible = false;

                comboBoxPass2Seat.DataSource = firstclassseat.ToArray();
                comboBoxPass1Seat.DataSource = firstclassseat.ToArray();
                comboBoxPass4Seat.DataSource = firstclassseat.ToArray();
                comboBoxPass5Seat.DataSource = firstclassseat.ToArray();
                comboBoxPass3Seat.DataSource = firstclassseat.ToArray();

                if (Global.guest == 1)
                {
                    lblPass1Seat.Visible = true;
                    lblPass2Seat.Visible = false;
                    lblPass3Seat.Visible = false;
                    lblPass4Seat.Visible = false;
                    lblPass5Seat.Visible = false;
                    comboBoxPass1Seat.Visible = true;
                    comboBoxPass2Seat.Visible = false;
                    comboBoxPass3Seat.Visible = false;
                    comboBoxPass4Seat.Visible = false;
                    comboBoxPass5Seat.Visible = false;
                }
                if (Global.guest == 2)
                {
                    lblPass1Seat.Visible = true;
                    comboBoxPass1Seat.Visible = true;
                    lblPass2Seat.Visible = true;
                    lblPass3Seat.Visible = false;
                    lblPass4Seat.Visible = false;
                    lblPass5Seat.Visible = false;
                    comboBoxPass2Seat.Visible = true;
                    comboBoxPass3Seat.Visible = false;
                    comboBoxPass4Seat.Visible = false;
                    comboBoxPass5Seat.Visible = false;
                }
                if (Global.guest == 3)
                {
                    lblPass1Seat.Visible = true;
                    comboBoxPass1Seat.Visible = true;
                    lblPass2Seat.Visible = true;
                    lblPass3Seat.Visible = true;
                    lblPass4Seat.Visible = false;
                    lblPass5Seat.Visible = false;
                    comboBoxPass2Seat.Visible = true;
                    comboBoxPass3Seat.Visible = true;
                    comboBoxPass4Seat.Visible = false;
                    comboBoxPass5Seat.Visible = false;
                }
                if (Global.guest == 4)
                {
                    lblPass1Seat.Visible = true;
                    comboBoxPass1Seat.Visible = true;
                    lblPass2Seat.Visible = true;
                    lblPass3Seat.Visible = true;
                    lblPass4Seat.Visible = true;
                    lblPass5Seat.Visible = false;
                    comboBoxPass2Seat.Visible = true;
                    comboBoxPass3Seat.Visible = true;
                    comboBoxPass4Seat.Visible = true;
                    comboBoxPass5Seat.Visible = false;
                }
                if (Global.guest == 5)
                {
                    lblPass1Seat.Visible = true;
                    comboBoxPass1Seat.Visible = true;
                    lblPass2Seat.Visible = true;
                    lblPass3Seat.Visible = true;
                    lblPass4Seat.Visible = true;
                    lblPass5Seat.Visible = true;
                    comboBoxPass2Seat.Visible = true;
                    comboBoxPass3Seat.Visible = true;
                    comboBoxPass4Seat.Visible = true;
                    comboBoxPass5Seat.Visible = true;
                }
                comboBoxPass2Seat.SelectedIndex = -1;
                comboBoxPass1Seat.SelectedIndex = -1;
                comboBoxPass4Seat.SelectedIndex = -1;
                comboBoxPass5Seat.SelectedIndex = -1;
                comboBoxPass3Seat.SelectedIndex = -1;
            }
        }

        private void comboBoxPass1Seat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSeatUpgrade.SelectedIndex != -1)
            { lblPass1Seat.ForeColor = Color.Black; }
        }

        private void comboBoxSeatUpgrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSeatUpgrade.SelectedIndex!= - 1)
            { lblSeatUpgrade.ForeColor = Color.Black; }


            if (Global.cabin == "Economy")
            {
                if (comboBoxSeatUpgrade.Text == "Upgrade to First Class (+800)")
                {
                    Global.cabinupgrade = "First Class";
                    Global.upseat = 800;
                    lblSeatFeePerPass.Visible = true;

                }

                if (comboBoxSeatUpgrade.Text == "Upgrade to Business (+250)")
                {

                    Global.upseat = 250;
                    Global.cabinupgrade = "Business";
                    lblSeatFeePerPass.Visible = true;
                }

                if (comboBoxSeatUpgrade.Text == "No, Keep my selection")
                {
                    Global.upseat = 0;
                    Global.cabinupgrade = "Economy";
                }

            }

            if (Global.cabin == "Business")
            {
                if (comboBoxSeatUpgrade.Text == "Upgrade to First Class (+500)")
                {

                    Global.cabinupgrade = "First Class";
                    Global.upseat = 500;
                    lblSeatFeePerPass.Visible = true;
                }

                if (comboBoxSeatUpgrade.Text == "No, Keep my selection")
                {
                    Global.upseat = 0;

                    Global.cabinupgrade = "Business";

                }

            }
            if (Global.cabin == "First Class")
            { Global.cabinupgrade = "First Class"; }

            if (Global.cabinupgrade == "First Class")
            {
                comboBoxPass2Seat.DataSource = firstclassseat.ToArray();
                comboBoxPass1Seat.DataSource = firstclassseat.ToArray();
                comboBoxPass4Seat.DataSource = firstclassseat.ToArray();
                comboBoxPass5Seat.DataSource = firstclassseat.ToArray();
                comboBoxPass3Seat.DataSource = firstclassseat.ToArray();
                comboBoxPass2Seat.SelectedIndex = -1;
                comboBoxPass1Seat.SelectedIndex = -1;
                comboBoxPass4Seat.SelectedIndex = -1;
                comboBoxPass5Seat.SelectedIndex = -1;
                comboBoxPass3Seat.SelectedIndex = -1;
                
            }
            if (Global.cabinupgrade == "Business")
            {
                comboBoxPass2Seat.DataSource = bussclassseat.ToArray();
                comboBoxPass1Seat.DataSource = bussclassseat.ToArray();
                comboBoxPass4Seat.DataSource = bussclassseat.ToArray();
                comboBoxPass5Seat.DataSource = bussclassseat.ToArray();
                comboBoxPass3Seat.DataSource = bussclassseat.ToArray();

                comboBoxPass2Seat.SelectedIndex = -1;
                comboBoxPass1Seat.SelectedIndex = -1;
                comboBoxPass4Seat.SelectedIndex = -1;
                comboBoxPass5Seat.SelectedIndex = -1;
                comboBoxPass3Seat.SelectedIndex = -1;
                

            }
            if (Global.cabinupgrade == "Economy")
            {
                comboBoxPass2Seat.DataSource = ecoclassseat.ToArray();
                comboBoxPass1Seat.DataSource = ecoclassseat.ToArray();
                comboBoxPass4Seat.DataSource = ecoclassseat.ToArray();
                comboBoxPass5Seat.DataSource = ecoclassseat.ToArray();
                comboBoxPass3Seat.DataSource = ecoclassseat.ToArray();

                comboBoxPass2Seat.SelectedIndex = -1;
                comboBoxPass1Seat.SelectedIndex = -1;
                comboBoxPass4Seat.SelectedIndex = -1;
                comboBoxPass5Seat.SelectedIndex = -1;
                comboBoxPass3Seat.SelectedIndex = -1;
                
            }


            if (Global.guest == 1)
            {
                lblPass1Seat.Visible = true;
                comboBoxPass1Seat.Visible = true;
                lblPass2Seat.Visible = false;
                lblPass3Seat.Visible = false;
                lblPass4Seat.Visible = false;
                lblPass5Seat.Visible = false;
                comboBoxPass1Seat.Visible = true;
                comboBoxPass2Seat.Visible = false;
                comboBoxPass3Seat.Visible = false;
                comboBoxPass4Seat.Visible = false;
                comboBoxPass5Seat.Visible = false;
            }
            if (Global.guest == 2)
            {
                lblPass1Seat.Visible = true;
                comboBoxPass1Seat.Visible = true;
                lblPass2Seat.Visible = true;
                lblPass3Seat.Visible = false;
                lblPass4Seat.Visible = false;
                lblPass5Seat.Visible = false;
                comboBoxPass2Seat.Visible = true;
                comboBoxPass3Seat.Visible = false;
                comboBoxPass4Seat.Visible = false;
                comboBoxPass5Seat.Visible = false;
            }
            if (Global.guest == 3)
            {
                lblPass1Seat.Visible = true;
                comboBoxPass1Seat.Visible = true;
                lblPass2Seat.Visible = true;
                lblPass3Seat.Visible = true;
                lblPass4Seat.Visible = false;
                lblPass5Seat.Visible = false;
                comboBoxPass2Seat.Visible = true;
                comboBoxPass3Seat.Visible = true;
                comboBoxPass4Seat.Visible = false;
                comboBoxPass5Seat.Visible = false;
            }
            if (Global.guest == 4)
            {
                lblPass1Seat.Visible = true;
                comboBoxPass1Seat.Visible = true;
                lblPass2Seat.Visible = true;
                lblPass3Seat.Visible = true;
                lblPass4Seat.Visible = true;
                lblPass5Seat.Visible = false;
                comboBoxPass2Seat.Visible = true;
                comboBoxPass3Seat.Visible = true;
                comboBoxPass4Seat.Visible = true;
                comboBoxPass5Seat.Visible = false;
            }
            if (Global.guest == 5)
            {
                lblPass1Seat.Visible = true;
                comboBoxPass1Seat.Visible = true;
                lblPass2Seat.Visible = true;
                lblPass3Seat.Visible = true;
                lblPass4Seat.Visible = true;
                lblPass5Seat.Visible = true;
                comboBoxPass2Seat.Visible = true;
                comboBoxPass3Seat.Visible = true;
                comboBoxPass4Seat.Visible = true;
                comboBoxPass5Seat.Visible = true;
            }




            Global.servicefee = Global.meal + Global.insurance + Global.bag + Global.upseat;
            lblServiceFeeOutput.Text = Global.servicefee.ToString("c1");

            lblAirportFeeOutput.Text = (Global.airportfee).ToString("c1");
            lblTaxOutput.Text = (Global.tax).ToString("c1");


            lblTotalPricePassengerOutput.Text = Global.totaltick.ToString("c1");
        }

        private void comboBoxInsurance_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxInsurance.SelectedIndex != -1)
            { lblInsuranceDesc.ForeColor = Color.Black; }
            Global.insurance = 0;

            if (comboBoxInsurance.Text == "No insurance - $0")
            {
                Global.insurance = 0;

            }
            if (comboBoxInsurance.Text == "Basic coverage - $15")
            {
                Global.insurance = 15;

            }
            if (comboBoxInsurance.Text == "Premium coverage - $30")
            {
                Global.insurance = 30;

            }

            Global.servicefee = Global.insurance + Global.bag + Global.meal + Global.upseat;
            lblServiceFeeOutput.Text = Global.servicefee.ToString("c1");

            Global.totaltick = Global.outticket + Global.returnticket + Global.servicefee + Global.tax + Global.airportfee;
            lblTotalPricePassengerOutput.Text = Global.totaltick.ToString("c1");
        }

        private void comboBoxBaggage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxBaggage.SelectedIndex != -1)
            { lblBaggageDesc.ForeColor = Color.Black; }
            Global.bag = 0;
            if (comboBoxBaggage.Text == "Carry on - $0")
            {
                Global.bag = 0;
            }
            if (comboBoxBaggage.Text == "1 bag - $20")
            {
                Global.bag = 20;
            }
            if (comboBoxBaggage.Text == "2 bags - $45")
            {
                Global.bag = 45;
            }
            if (comboBoxBaggage.Text == "3 bags - $70")
            {
                Global.bag = 70;
            }

            Global.servicefee = Global.insurance + Global.bag + Global.meal + Global.upseat;
            lblServiceFeeOutput.Text = Global.servicefee.ToString("c1");

            Global.totaltick = Global.outticket + Global.returnticket + Global.servicefee + Global.tax + Global.airportfee;
            lblTotalPricePassengerOutput.Text = Global.totaltick.ToString("c1");
        }

        private void comboBoxMealOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMealOptions.SelectedIndex != -1)
            { lblMealOptionsDesc.ForeColor = Color.Black; }
            Global.meal = 0;
            if (comboBoxMealOptions.Text == "No Meal - $0")
            {
                Global.meal = 0;
            }
            if (comboBoxMealOptions.Text == "Regular Meal - $20")
            {
                Global.meal = 20;
            }
            if (comboBoxMealOptions.Text == "Vegetarian Meal - $22")
            {
                Global.meal = 22;
            }

            Global.servicefee = Global.insurance + Global.bag + Global.meal + Global.upseat;
            lblServiceFeeOutput.Text = Global.servicefee.ToString("c1");

            Global.totaltick = Global.outticket + Global.returnticket + Global.servicefee + Global.tax + Global.airportfee;
            lblTotalPricePassengerOutput.Text = Global.totaltick.ToString("c1");
        }


        private void btnPayment_Click(object sender, EventArgs e)
        {

            if (comboBoxSeatUpgrade.SelectedIndex == -1)
            { lblSeatUpgrade.ForeColor = Color.IndianRed; }
            else { lblSeatUpgrade.ForeColor = Color.Black; }
            if (comboBoxPass1Seat.SelectedIndex == -1)
            { lblPass1Seat.ForeColor = Color.IndianRed; }
            else { lblPass1Seat.ForeColor = Color.Black; }
           if(comboBoxPass2Seat.SelectedIndex == -1)
            { lblPass2Seat.ForeColor = Color.IndianRed; }
            else { lblPass2Seat.ForeColor = Color.Black; }

            if (comboBoxPass3Seat.SelectedIndex == -1)
            { lblPass3Seat.ForeColor = Color.IndianRed; }
            else { lblPass3Seat.ForeColor = Color.Black; }
            if (comboBoxPass4Seat.SelectedIndex == -1)
            { lblPass4Seat.ForeColor = Color.IndianRed; }
            else { lblPass4Seat.ForeColor = Color.Black; }
            if (comboBoxPass5Seat.SelectedIndex == -1)
            { lblPass5Seat.ForeColor = Color.IndianRed; }
            else { lblPass5Seat.ForeColor = Color.Black; }
            if (comboBoxMealOptions.SelectedIndex == -1)
            { lblMealOptionsDesc.ForeColor = Color.IndianRed; }
            else { lblMealOptionsDesc.ForeColor = Color.Black; }
            if (comboBoxInsurance.SelectedIndex == -1)
            { lblInsuranceDesc.ForeColor = Color.IndianRed; }
            else { lblInsuranceDesc.ForeColor = Color.Black; }
            if (comboBoxBaggage.SelectedIndex == -1)
            { lblBaggageDesc.ForeColor = Color.IndianRed; }
            else { lblBaggageDesc.ForeColor = Color.Black; }


            FormPayment f6 = new FormPayment();

            if (Global.guest == 5)
            {
                if (comboBoxPass1Seat.SelectedIndex == -1 || comboBoxPass2Seat.SelectedIndex == -1 || comboBoxPass3Seat.SelectedIndex == -1 || comboBoxPass4Seat.SelectedIndex == -1 || comboBoxPass5Seat.SelectedIndex == -1)
                {
                    MessageBox.Show("Please pick seat selection. Seat allocation should not be unselected", Global.appTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (comboBoxPass1Seat.SelectedIndex != comboBoxPass2Seat.SelectedIndex && comboBoxPass1Seat.SelectedIndex != comboBoxPass3Seat.SelectedIndex && comboBoxPass1Seat.SelectedIndex != comboBoxPass4Seat.SelectedIndex && comboBoxPass1Seat.SelectedIndex != comboBoxPass5Seat.SelectedIndex && comboBoxPass2Seat.SelectedIndex != comboBoxPass3Seat.SelectedIndex && comboBoxPass2Seat.SelectedIndex != comboBoxPass4Seat.SelectedIndex && comboBoxPass2Seat.SelectedIndex != comboBoxPass5Seat.SelectedIndex && comboBoxPass3Seat.SelectedIndex != comboBoxPass4Seat.SelectedIndex && comboBoxPass3Seat.SelectedIndex != comboBoxPass5Seat.SelectedIndex && comboBoxPass3Seat.SelectedIndex != comboBoxPass4Seat.SelectedIndex && comboBoxPass4Seat.SelectedIndex != comboBoxPass5Seat.SelectedIndex)
                {
                    

                }
                else
                {
                    MessageBox.Show("Passengers' seats cannot be duplicated or blank", Global.appTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (Global.guest == 4)
            {
                if ( comboBoxPass1Seat.SelectedIndex == -1 || comboBoxPass2Seat.SelectedIndex == -1 || comboBoxPass3Seat.SelectedIndex == -1 || comboBoxPass4Seat.SelectedIndex == -1)
                {
                    MessageBox.Show("Please pick seat selection for all passengers", Global.appTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (comboBoxPass1Seat.SelectedIndex != comboBoxPass2Seat.SelectedIndex && comboBoxPass1Seat.SelectedIndex != comboBoxPass3Seat.SelectedIndex && comboBoxPass1Seat.SelectedIndex != comboBoxPass4Seat.SelectedIndex && comboBoxPass2Seat.SelectedIndex != comboBoxPass3Seat.SelectedIndex && comboBoxPass2Seat.SelectedIndex != comboBoxPass4Seat.SelectedIndex && comboBoxPass3Seat.SelectedIndex != comboBoxPass4Seat.SelectedIndex)
                {
                    

                }
                else
                {
                    MessageBox.Show("Passengers' seats cannot be duplicated or blank", Global.appTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
                    return;
                }
            }

            if (Global.guest == 3)
            {
                if (comboBoxPass1Seat.SelectedIndex == -1 || comboBoxPass2Seat.SelectedIndex == -1 || comboBoxPass3Seat.SelectedIndex == -1)
                {
                    MessageBox.Show("Please pick seat selection for all passengers", Global.appTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (comboBoxPass1Seat.SelectedIndex != comboBoxPass2Seat.SelectedIndex && comboBoxPass1Seat.SelectedIndex != comboBoxPass3Seat.SelectedIndex && comboBoxPass2Seat.SelectedIndex != comboBoxPass3Seat.SelectedIndex)
                {
                  

                }
                else
                {
                    MessageBox.Show("Passengers' seats cannot be duplicated or blank", Global.appTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (Global.guest == 2)
            {
                if ( comboBoxPass1Seat.SelectedIndex == -1 || comboBoxPass2Seat.SelectedIndex == -1)
                {
                    MessageBox.Show("Please pick seat selection for all passengers", Global.appTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (comboBoxPass1Seat.SelectedIndex != comboBoxPass2Seat.SelectedIndex)
                {
                    
                }
                else
                {
                    MessageBox.Show("Passengers' seats cannot be duplicated or blank", Global.appTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (Global.guest == 1)
            {
                if ( comboBoxPass1Seat.SelectedIndex == -1)
                {
                    MessageBox.Show("Please pick seat selection for all passengers", Global.appTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            
            if (comboBoxMealOptions.SelectedIndex == -1 || comboBoxInsurance.SelectedIndex == -1 || comboBoxBaggage.SelectedIndex == -1)
            {
                MessageBox.Show("Please confirm Meal , Insurance and Baggage option", Global.appTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (comboBoxMealOptions.SelectedIndex != -1 && comboBoxInsurance.SelectedIndex != -1 && comboBoxBaggage.SelectedIndex != -1)
            {
                this.Hide();

                f6.Show();


                f6.lblRouteOutput.Text = lblRouteOutput.Text;
                f6.lblDurationOutput.Text = lblDurationOutput.Text;
                f6.lblDateOutput.Text = lblDateOutput.Text;
                f6.lblLengthOutput.Text = lblLengthOutput.Text;
                f6.lblCabinOutput.Text = lblCabinOutput.Text;
                f6.lblPassengersOutput.Text = lblPassengersOutput.Text;

            }
            Global.servicefee = Global.meal + Global.insurance + Global.bag + Global.upseat;
        }

        private void comboBoxPass5Seat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPass5Seat.SelectedIndex != -1)
            { lblPass5Seat.ForeColor = Color.Black; }
        }

        private void comboBoxPass2Seat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPass2Seat.SelectedIndex != -1)
            { lblPass2Seat.ForeColor = Color.Black; }
        }

        private void comboBoxPass3Seat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPass3Seat.SelectedIndex != -1)
            { lblPass3Seat.ForeColor = Color.Black; }
        }

        private void comboBoxPass4Seat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPass4Seat.SelectedIndex != -1)
            { lblPass4Seat.ForeColor = Color.Black; }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show("Are you sure you want to reset?", Global.appTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (response == DialogResult.OK)
            {
                comboBoxSeatUpgrade.SelectedIndex = -1;
                comboBoxPass1Seat.SelectedIndex = -1;
                comboBoxPass2Seat.SelectedIndex = -1;
                comboBoxPass3Seat.SelectedIndex = -1;
                comboBoxPass4Seat.SelectedIndex = -1;
                comboBoxPass5Seat.SelectedIndex = -1;
                comboBoxMealOptions.SelectedIndex = -1;
                comboBoxInsurance.SelectedIndex = -1;
                comboBoxBaggage.SelectedIndex = -1;

                comboBoxPass1Seat.Visible = false;
                comboBoxPass2Seat.Visible = false;
                comboBoxPass3Seat.Visible = false;
                comboBoxPass4Seat.Visible = false;
                comboBoxPass5Seat.Visible = false;
                lblPass1Seat.Visible = false;
                lblPass2Seat.Visible = false;
                lblPass3Seat.Visible = false;
                lblPass4Seat.Visible = false;
                lblPass5Seat.Visible = false;
                if (Global.cabin == "First Class")
                {
                    if (Global.guest == 1)
                    {
                        lblPass1Seat.Visible = true;
                        lblPass2Seat.Visible = false;
                        lblPass3Seat.Visible = false;
                        lblPass4Seat.Visible = false;
                        lblPass5Seat.Visible = false;
                        comboBoxPass1Seat.Visible = true;
                        comboBoxPass2Seat.Visible = false;
                        comboBoxPass3Seat.Visible = false;
                        comboBoxPass4Seat.Visible = false;
                        comboBoxPass5Seat.Visible = false;
                    }
                    if (Global.guest == 2)
                    {
                        lblPass1Seat.Visible = true;
                        comboBoxPass1Seat.Visible = true;
                        lblPass2Seat.Visible = true;
                        lblPass3Seat.Visible = false;
                        lblPass4Seat.Visible = false;
                        lblPass5Seat.Visible = false;
                        comboBoxPass2Seat.Visible = true;
                        comboBoxPass3Seat.Visible = false;
                        comboBoxPass4Seat.Visible = false;
                        comboBoxPass5Seat.Visible = false;
                    }
                    if (Global.guest == 3)
                    {
                        lblPass1Seat.Visible = true;
                        comboBoxPass1Seat.Visible = true;
                        lblPass2Seat.Visible = true;
                        lblPass3Seat.Visible = true;
                        lblPass4Seat.Visible = false;
                        lblPass5Seat.Visible = false;
                        comboBoxPass2Seat.Visible = true;
                        comboBoxPass3Seat.Visible = true;
                        comboBoxPass4Seat.Visible = false;
                        comboBoxPass5Seat.Visible = false;
                    }
                    if (Global.guest == 4)
                    {
                        lblPass1Seat.Visible = true;
                        comboBoxPass1Seat.Visible = true;
                        lblPass2Seat.Visible = true;
                        lblPass3Seat.Visible = true;
                        lblPass4Seat.Visible = true;
                        lblPass5Seat.Visible = false;
                        comboBoxPass2Seat.Visible = true;
                        comboBoxPass3Seat.Visible = true;
                        comboBoxPass4Seat.Visible = true;
                        comboBoxPass5Seat.Visible = false;
                    }
                    if (Global.guest == 5)
                    {
                        lblPass1Seat.Visible = true;
                        comboBoxPass1Seat.Visible = true;
                        lblPass2Seat.Visible = true;
                        lblPass3Seat.Visible = true;
                        lblPass4Seat.Visible = true;
                        lblPass5Seat.Visible = true;
                        comboBoxPass2Seat.Visible = true;
                        comboBoxPass3Seat.Visible = true;
                        comboBoxPass4Seat.Visible = true;
                        comboBoxPass5Seat.Visible = true;
                    }
                }
            }
        }

        // Painting for fancy transparency & outlines
        private void panelSeating_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panelSeating.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void panelFlightSummary_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panelFlightSummary.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void panelPrice_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panelPrice.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void panelTotals_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panelTotals.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void panelMeals_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panelMeals.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void panelInsurance_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panelInsurance.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void panelBaggage_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panelBaggage.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }
        private void panelSeatsFlightOptions_Paint(object sender, PaintEventArgs e)
        {
            panelSeatsFlightOptions.BackColor = Color.FromArgb(120, Color.White);
        }

        private void panelFlightSummaryPrice_Paint(object sender, PaintEventArgs e)
        {
            panelFlightSummaryPrice.BackColor = Color.FromArgb(180, Color.White);
        }
    }
} 
    
    
    

