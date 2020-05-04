using Microsoft.Office.Interop.Word;
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
    public partial class FormPayment : Form
    {
        public FormPayment()
        {
            InitializeComponent();
        }

        private void FormPayment_Load(object sender, EventArgs e)
        {
            dateTimepickerDOB.MaxDate = DateTime.Now;
            dateTimePickerPass2DOB.MaxDate = DateTime.Now;
            dateTimePickerPass3DOB.MaxDate = DateTime.Now;
            dateTimePickerPass4DOB.MaxDate = DateTime.Now;
            dateTimePickerPass5DOB.MaxDate = DateTime.Now;
            lblNumPassengersOutput.Text = Global.guest.ToString();
            Global.finaltick = Global.guest * Global.totaltick;
            lblTotalTicketPriceOutput.Text = (Global.finaltick).ToString("c1");
            lblTicketPricePassengerOutput.Text = (Global.outticket + Global.returnticket).ToString("C1");
            lblServiceFeeOutput.Text = Global.servicefee.ToString("c1");
            lblAirportFeeOutput.Text = Global.airportfee.ToString("c1");
            lblTaxOutput.Text= Global.tax.ToString("c1");
            lblTotalPricePassengerOutput.Text =( Global.totaltick).ToString("c1");
            Global.finaltick = Global.totaltick * Global.guest;
            lblTotalTicketPriceOutput.Text = Global.finaltick.ToString("c1");

            if (Global.guest == 1)
            { panelOtherPassInfo.Visible = false; }
            if (Global.guest == 2)
            {
                panelOtherPassInfo.Visible = true;
                panelPass3.Visible = false;
                panelPass4.Visible = false;
                panelPass5.Visible = false; 
            }
            if (Global.guest == 3)
            {
                panelOtherPassInfo.Visible = true;
                panelPass3.Visible = true;
                panelPass4.Visible = false;
                panelPass5.Visible = false;
            }
            if (Global.guest == 4)
            {
                panelOtherPassInfo.Visible = true;
                panelPass3.Visible = true;
                panelPass4.Visible = true;
                panelPass5.Visible = false;
            }
        }

        private void btnConfirmPayment_Click(object sender, EventArgs e)
        {
            if (txtBoxName.Text == "")
            { txtBoxName.BackColor = Color.IndianRed; }
            if (txtBoxPassportNum.Text == "")
            { txtBoxPassportNum.BackColor = Color.IndianRed; }
            if (textBoxCard1.Text == "")
            { textBoxCard1.BackColor = Color.IndianRed; }
            if (textBoxCard2.Text == "")
            { textBoxCard2.BackColor = Color.IndianRed; }
            if (textBoxCard3.Text == "")
            { textBoxCard3.BackColor = Color.IndianRed; }
            if (textBoxCard4.Text == "")
            { textBoxCard4.BackColor = Color.IndianRed; }
            if (txtBoxEmail.Text == "" || txtBoxEmail.Text.Contains("@")==false)
            { txtBoxEmail.BackColor = Color.IndianRed; }
           
            if (txtBoxCardholderName.Text == "")
            { txtBoxCardholderName.BackColor = Color.IndianRed; }
            if (comboBoxExpirationMonth.Text == "")
            { comboBoxExpirationMonth.BackColor = Color.IndianRed; }
            if (comboBoxYear.Text == "")
            { comboBoxYear.BackColor = Color.IndianRed; }
            if (maskedTextBoxCVV.Text == "")
            { maskedTextBoxCVV.BackColor = Color.IndianRed; }

            if (maskedTextBoxPhone.Text== "(   )    -")
            { maskedTextBoxPhone.BackColor = Color.IndianRed; }
            if (txtBoxPass2Name.Text == "")
            { txtBoxPass2Name.BackColor = Color.IndianRed; }
            if (txtBoxPass3Name.Text == "")
            { txtBoxPass3Name.BackColor = Color.IndianRed; }
            if (txtBoxPass4Name.Text == "")
            { txtBoxPass4Name.BackColor = Color.IndianRed; }

            if (txtBoxPass5Name.Text == "")
            { txtBoxPass5Name.BackColor = Color.IndianRed; }

            if (txtBoxPass2PassportNum.Text == "")
            { txtBoxPass2PassportNum.BackColor = Color.IndianRed; }

            if (txtBoxPass3PassportNum.Text == "")
            { txtBoxPass3PassportNum.BackColor = Color.IndianRed; }

            if (txtBoxPass4PassportNum.Text == "")
            { txtBoxPass4PassportNum.BackColor = Color.IndianRed; }
            if (txtBoxPass5PassportNum.Text == "")
            { txtBoxPass5PassportNum.BackColor = Color.IndianRed; }


            Global.servicefee = Global.meal + Global.insurance + Global.bag + Global.upseat;
            if (txtBoxEmail.TextLength > 1)
            {if (txtBoxEmail.Text.Contains( "@"))
                {

                }
                else 
                {
                    MessageBox.Show("Please enter valid email address", Global.appTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return ; 
                }     
            }

            if (txtBoxName.TextLength < 1 || txtBoxPassportNum.TextLength < 1 || txtBoxEmail.TextLength < 1 || maskedTextBoxPhone.TextLength < 1 || textBoxCard1.TextLength < 1 || textBoxCard2.TextLength < 1 || textBoxCard3.TextLength < 1 || textBoxCard4.TextLength < 1 || maskedTextBoxCVV.TextLength < 1 || txtBoxCardholderName.TextLength < 1 || comboBoxExpirationMonth.SelectedIndex == -1 || comboBoxYear.SelectedIndex == -1 )
            {
                MessageBox.Show("Please input all Customer Information and Payment to proceed", Global.appTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Global.guest ==2)
            {
                if (txtBoxPass2Name.Text == "" || txtBoxPass2PassportNum.Text == "")
                {
                    MessageBox.Show("Please input Information for all Passengers", Global.appTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if (Global.guest ==3)
            {
                if (txtBoxPass3Name.Text == "" || txtBoxPass3PassportNum.Text == "" || txtBoxPass2Name.Text == "" || txtBoxPass2PassportNum.Text == "")
                {
                    MessageBox.Show("Please input Information for all Passengers", Global.appTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if (Global.guest ==4)
            {
                if (txtBoxPass4Name.Text == "" || txtBoxPass4PassportNum.Text == ""|| txtBoxPass3Name.Text == "" || txtBoxPass3PassportNum.Text == "" || txtBoxPass2Name.Text == "" || txtBoxPass2PassportNum.Text == "")
                {
                    MessageBox.Show("Please input Information for all Passengers", Global.appTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if (Global.guest ==5)
            {
                if (txtBoxPass5Name.Text == "" || txtBoxPass5PassportNum.Text == ""|| txtBoxPass4Name.Text == "" || txtBoxPass4PassportNum.Text == "" || txtBoxPass3Name.Text == "" || txtBoxPass3PassportNum.Text == "" || txtBoxPass2Name.Text == "" || txtBoxPass2PassportNum.Text == "")
                {
                    MessageBox.Show("Please input Information for all Passengers", Global.appTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }



            FormConfirmed f7 = new FormConfirmed();
            Global.p1name = txtBoxName.Text;
            Global.p1pp = txtBoxPassportNum.Text;
            Global.p1email = txtBoxEmail.Text;
            
            Global.expmonth = comboBoxExpirationMonth.Text;
            Global.expyear = comboBoxYear.Text;
            Global.cardname = txtBoxCardholderName.Text;
            Global.p2name = txtBoxPass2Name.Text;
            Global.p2pp = txtBoxPass2PassportNum.Text;
            Global.p3name = txtBoxPass3Name.Text;
            Global.p3pp = txtBoxPass3PassportNum.Text;
            Global.p4name = txtBoxPass4Name.Text;
            Global.p4pp = txtBoxPass4PassportNum.Text;
            Global.p5name = txtBoxPass5Name.Text;
            Global.p5pp = txtBoxPass5PassportNum.Text;
            
            Global.p1dob = dateTimepickerDOB.Value;
            Global.p2dob = dateTimePickerPass2DOB.Value;
            Global.p3dob = dateTimePickerPass3DOB.Value;
            Global.p4dob = dateTimePickerPass4DOB.Value;
            Global.p5dob = dateTimePickerPass5DOB.Value;
            Global.phone = maskedTextBoxPhone.Text;
            f7.lblRouteOutput.Text = lblRouteOutput.Text;
            f7.lblDurationOutput.Text = lblDurationOutput.Text;
            f7.lblDateOutput.Text = lblDateOutput.Text;
            f7.lblLengthOutput.Text = lblLengthOutput.Text;
            f7.lblDurationOutput.Text = lblDurationOutput.Text;
            f7.lblCabinOutput.Text = lblCabinOutput.Text;
            f7.lblGuestOutput.Text = lblPassengersOutput.Text;

            f7.lblCardNumOutput.Text = "**** " + textBoxCard4.Text;

            try
            {
                Global.card1 = double.Parse(textBoxCard1.Text);
                Global.card2 = double.Parse(textBoxCard2.Text);
                Global.card3 = double.Parse(textBoxCard3.Text);
                Global.card4= double.Parse(textBoxCard4.Text);

                Global.cvv = double.Parse(maskedTextBoxCVV.Text);
                
                this.Hide();
                f7.Show();
            }
            catch
            {
                MessageBox.Show("Please input 16-digit Card Number, 3-digit CVV number and Phone number", Global.appTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            FormPayment f6 = new FormPayment();
            DialogResult res = new DialogResult();
            res = MessageBox.Show("Are you sure to Reset ?", "Reset prompt", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                txtBoxName.Text = "";
                txtBoxEmail.Text = "";
                txtBoxPassportNum.Text = "";
                textBoxCard1.Text = "";
                textBoxCard2.Text = "";
                textBoxCard3.Text = "";
                textBoxCard4.Text = "";
                txtBoxCardholderName.Text = "";
                txtBoxPass2Name.Text = "";
                txtBoxPass4Name.Text = "";
                txtBoxPass3Name.Text = "";
                txtBoxPass5Name.Text = "";
                txtBoxPass2PassportNum.Text = "";
                txtBoxPass3PassportNum.Text = "";
                txtBoxPass4PassportNum.Text = "";
                txtBoxPass5PassportNum.Text = "";
                maskedTextBoxCVV.Text = "";
                maskedTextBoxPhone.Text = "";
                checkBoxSame.Checked = false;
                comboBoxExpirationMonth.SelectedIndex = -1;
                comboBoxYear.SelectedIndex = -1;
            }
        }

        // Reset backcolor if user enters text
        private void checkBoxSame_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSame.Checked)
            {
                txtBoxCardholderName.Text = txtBoxName.Text;
                txtBoxCardholderName.Enabled = false;
            }
            else
            {
                txtBoxCardholderName.Enabled = true;
            }
        }

        private void txtBoxEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxEmail.Text != "" && txtBoxEmail.Text.Contains("@") == true)

            { txtBoxEmail.BackColor = Color.White; }
        }

        private void textBoxCard1_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCard1.TextLength == 4)
            { textBoxCard2.Focus(); }

            if (textBoxCard1.Text != "")

            { textBoxCard1.BackColor = Color.White; }
        }

        private void textBoxCard2_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCard2.TextLength == 4)
            { textBoxCard3.Focus(); }
            if (textBoxCard2.Text != "")

            { textBoxCard2.BackColor = Color.White; }
        }

        private void textBoxCard3_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCard3.TextLength == 4)
            { textBoxCard4.Focus(); }
            if (textBoxCard3.Text != "")

            { textBoxCard3.BackColor = Color.White; }
        }

        private void textBoxCard4_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCard4.Text != "")

            { textBoxCard4.BackColor = Color.White; }
        }

        private void txtBoxName_TextChanged(object sender, EventArgs e)
        {
            if (checkBoxSame.Checked==true) 
            { txtBoxCardholderName.Text = txtBoxName.Text;  }
            else { txtBoxCardholderName.Text = ""; }
            if (txtBoxName.Text != "")

            { txtBoxName.BackColor = Color.White; }
        }

        private void txtBoxPassportNum_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxPassportNum.Text != "")

            { txtBoxPassportNum.BackColor = Color.White; }
        }

        private void maskedTextBoxPhone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (maskedTextBoxPhone.Text != "")

            { maskedTextBoxPhone.BackColor = Color.White; }
        }
        private void maskedTextBoxPhone_TextChange(object sender, EventArgs e)
        {
            if (maskedTextBoxPhone.Text != "")

            { maskedTextBoxPhone.BackColor = Color.White; }
        }

        private void maskedTextBoxCVV_TextChange(object sender, EventArgs e)
        {
            if (maskedTextBoxCVV.Text != "")

            { maskedTextBoxCVV.BackColor = Color.White; }
        }

        private void comboBoxExpirationMonth_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBoxExpirationMonth.SelectedIndex != -1)

            { comboBoxExpirationMonth.BackColor = Color.White; }
        }

        private void comboBoxYear_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBoxYear.SelectedIndex != -1)

            { comboBoxYear.BackColor = Color.White; }
        }

        private void txtBoxCardholderName_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxCardholderName.Text != "")

            { txtBoxCardholderName.BackColor = Color.White; }
        }

        private void txtBoxPass2Name_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxPass2Name.Text != "" )

            { txtBoxPass2Name.BackColor = Color.White; }
        }

        private void txtBoxPass3Name_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxPass3Name.Text != "")

            { txtBoxPass3Name.BackColor = Color.White; }
        }

        private void txtBoxPass4Name_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxPass4Name.Text != "")

            { txtBoxPass4Name.BackColor = Color.White; }
        }

        private void txtBoxPass5Name_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxPass5Name.Text != "")

            { txtBoxPass5Name.BackColor = Color.White; }
        }

        private void txtBoxPass3PassportNum_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxPass3PassportNum.Text != "")

            { txtBoxPass3PassportNum.BackColor = Color.White; }
        }

        private void txtBoxPass4PassportNum_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxPass4PassportNum.Text != "")

            { txtBoxPass4PassportNum.BackColor = Color.White; }
        }

        private void txtBoxPass5PassportNum_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxPass5PassportNum.Text != "")

            { txtBoxPass5PassportNum.BackColor = Color.White; }
        }

        private void txtBoxPass2PassportNum_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxPass2PassportNum.Text != "")

            { txtBoxPass2PassportNum.BackColor = Color.White; }
        }

        // Painting for fancy transparency & outlines
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

        private void panelPaymentInfo_Paint(object sender, PaintEventArgs e)
        {
            panelPaymentInfo.BackColor = Color.FromArgb(220, Color.White);
            ControlPaint.DrawBorder(e.Graphics, panelPaymentInfo.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void panelOtherPassInfo_Paint(object sender, PaintEventArgs e)
        {
            panelOtherPassInfo.BackColor = Color.FromArgb(220, Color.White);
            ControlPaint.DrawBorder(e.Graphics, panelOtherPassInfo.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void panelSummaryPrice_Paint(object sender, PaintEventArgs e)
        {
            panelSummaryPrice.BackColor = Color.FromArgb(180, Color.White);
        }

        private void panelPaymentOptions_Paint(object sender, PaintEventArgs e)
        {
            panelPaymentOptions.BackColor = Color.FromArgb(180, Color.White);
        }

        private void panelPriPassengerInfo_Paint(object sender, PaintEventArgs e)
        {
            panelPriPassengerInfo.BackColor = Color.FromArgb(220, Color.White);
            ControlPaint.DrawBorder(e.Graphics, panelPriPassengerInfo.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }
    }
}
    

