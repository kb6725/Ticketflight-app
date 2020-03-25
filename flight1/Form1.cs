using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;

namespace flight1
{
    public partial class Form1 : Form
    {


        int guest = 0;
        bool returnflag = true;

        public OleDbConnection con;
        public OleDbDataAdapter dad;
        public OleDbCommand com;
        public DataSet ds;



        public Form1()
        {
            InitializeComponent();



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'flightDataSet1.Places' table. You can move, or remove it, as needed.
            this.placesTableAdapter1.Fill(this.flightDataSet1.Places);
            // TODO: This line of code loads data into the 'flightDataSet.Places' table. You can move, or remove it, as needed.
            this.placesTableAdapter.Fill(this.flightDataSet.Places);
            radioButton1.Checked = true;


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(90, Color.White);

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            labelto.Hide();
            comboTo.Hide();
            labelreturn.Hide();
            dateTimereturn.Hide();
            returnflag = false;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            labelto.Show();
            comboTo.Show();
            labelreturn.Show();
            dateTimereturn.Show();

            returnflag = true;

        }

        private void comboFrom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            guest = int.Parse(labelguest.Text);
            if (guest > 0)
            { guest = guest + 1; }
            labelguest.Text = guest.ToString("n0");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (guest > 1)
            { guest = guest - 1; }
            labelguest.Text = guest.ToString("n0");
        }

        private void dateTimeout_ValueChanged(object sender, EventArgs e)
        {


        }

        private void dateTimereturn_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panel3.BackColor = Color.FromArgb(90, Color.White);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboFrom.Text = "Select Departure";
            comboTo.Text = "Select Arrival";
            combocabin.Text = "Select Cabin";
            labelguest.Text = "1";
            radioButton1.Checked = true;
            dateTimeout.Value = DateTime.Today;

        }

        private void buttonsearch_Click(object sender, EventArgs e)
        {


            this.Cursor = Cursors.WaitCursor;
            Form2 f2 = new Form2();




            this.Hide();





            f2.Show();




            f2.labelsum.Text = comboFrom.Text + " - " + comboTo.Text;
            f2.label4.Text = dateTimeout.Text + " - " + dateTimereturn.Text;
            DateTime from1;
            from1 = dateTimeout.Value;
            DateTime to11;
            to11 = dateTimereturn.Value;
            System.TimeSpan len = to11 - from1;

            f2.label6.Text = len.Days.ToString() + " day(s)";
            f2.label9.Text = labelguest.Text;
            f2.label10.Text = combocabin.Text;

            string dur, price;
            int duration;
            con = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\RICHA\Google Drive\Sem 4\MIS C#\ClassApps\Project\flight1\flight.mdb");
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Places where Place='" + comboFrom.Text + "'";
            cmd.ExecuteNonQuery();

            DataSet dt = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            dur = dt.Tables[0].Rows[0]["ID"].ToString();
            price = dt.Tables[0].Rows[0]["price"].ToString();
            con.Close();

            decimal prices;
            prices = decimal.Parse(price);

            if (f2.label10.Text == "Economy")
            {
                f2.label56.Text = prices.ToString();
                f2.label57.Text = (prices + 70).ToString();
                f2.label58.Text = (prices + 120).ToString();
                f2.label59.Text = (prices + 150).ToString();
                f2.label60.Text = (prices - 30).ToString();
            }
            if (f2.label10.Text == "Business")
            {
                f2.label56.Text = (prices*2).ToString();
                f2.label57.Text = (prices * 2 + 70).ToString();
                f2.label58.Text = (prices * 2 + 120).ToString();
                f2.label59.Text = (prices * 2 + 150).ToString();
                f2.label60.Text = (prices * 2 - 30).ToString();

            }
            if (f2.label10.Text == "First Class")
            {
                f2.label56.Text = (prices*4).ToString();
                f2.label57.Text = (prices * 4 + 70).ToString();
                f2.label58.Text = (prices * 4 + 120).ToString();
                f2.label59.Text = (prices * 4 + 150).ToString();
                f2.label60.Text = (prices * 4 - 30).ToString();
            }

            duration = int.Parse(dur);
            f2.label13.Text = "Flight Duration: " + dur + " hours";
            f2.label24.Text = "Flight Duration: " + dur + " hours";
            f2.label36.Text = "Flight Duration: " + dur + " hours";
            f2.label42.Text = "Flight Duration: " + dur + " hours";
            f2.label30.Text = "Flight Duration: " + dur + " hours";

            int fn;
            Random rd = new Random();
            fn = rd.Next(100, 930);
            int jet;
            Random rd1 = new Random();
            jet = rd1.Next(200, 700);

            int to1, to2, to3, to4, to5;
            to1 = duration + 5;
            to2 = duration + 9;
            to3 = duration + 13;
            to4 = duration + 16;
            to5 = duration + 22;

            f2.label49.Text = duration.ToString();

            if (to4 > 23)
            {
                to4 = to4 - 24;
                f2.label32.Text = "Non-stop flight (+1 day)";

            }
            if (to5 > 23)
            {
                to5 = to5 - 24;
                f2.label38.Text = "Non-stop flight (+1 day)";

            }


            f2.label15.Text = to1.ToString() + " : 00";
            f2.label16.Text = "Flight number: BN " + fn.ToString();
            f2.label18.Text = "Airbus " + jet.ToString();







            f2.label22.Text = to2.ToString() + " : 00";
            f2.label21.Text = "Flight number: BN " + (fn + 20).ToString();
            f2.label19.Text = "Airbus " + (jet + 12).ToString();



            f2.label28.Text = to3.ToString() + " : 00";
            f2.label27.Text = "Flight number: BN " + (fn + 35).ToString();
            f2.label25.Text = "Airbus " + (jet + 22).ToString();




            f2.label34.Text = to4.ToString() + " : 00";
            f2.label33.Text = "Flight number: BN " + (fn + 46).ToString();
            f2.label31.Text = "Airbus " + (jet + 32).ToString();



            f2.label40.Text = to5.ToString() + " : 00";
            f2.label39.Text = "Flight number: BN " + (fn + 550).ToString();
            f2.label37.Text = "Airbus " + (jet + 42).ToString();



            if (returnflag == true)
            {
                f2.label1.Text = "Two-way Route";

            }
            else
            {
                f2.label1.Text = "One-way Route";

            }


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

