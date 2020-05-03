namespace flight1
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelBookFlight = new System.Windows.Forms.Panel();
            this.btnGuestMinus = new System.Windows.Forms.Button();
            this.btnGuestPlus = new System.Windows.Forms.Button();
            this.radioButtonOneWay = new System.Windows.Forms.RadioButton();
            this.radioButtonReturn = new System.Windows.Forms.RadioButton();
            this.comboTo = new System.Windows.Forms.ComboBox();
            this.comboCabin = new System.Windows.Forms.ComboBox();
            this.comboFrom = new System.Windows.Forms.ComboBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblGuestCount = new System.Windows.Forms.Label();
            this.lblGuest = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblBookFlight = new System.Windows.Forms.Label();
            this.groupBoxTicketType = new System.Windows.Forms.GroupBox();
            this.placesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.placesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panelDates = new System.Windows.Forms.Panel();
            this.dateTimeReturn = new System.Windows.Forms.DateTimePicker();
            this.dateTimeOut = new System.Windows.Forms.DateTimePicker();
            this.lblReturn = new System.Windows.Forms.Label();
            this.lblOutbound = new System.Windows.Forms.Label();
            this.btnSearchFlight = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelTicketSearch = new System.Windows.Forms.Panel();
            this.btnSearchTicket = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBoxNews2 = new System.Windows.Forms.PictureBox();
            this.lblNews = new System.Windows.Forms.Label();
            this.lblNewsDesc2 = new System.Windows.Forms.Label();
            this.pictureBoxNews1 = new System.Windows.Forms.PictureBox();
            this.lblNewsDesc1 = new System.Windows.Forms.Label();
            this.pictureBoxNews3 = new System.Windows.Forms.PictureBox();
            this.lblNewsDesc3 = new System.Windows.Forms.Label();
            this.panelNews = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelBookFlight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.placesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placesBindingSource1)).BeginInit();
            this.panelDates.SuspendLayout();
            this.panelTicketSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNews2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNews1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNews3)).BeginInit();
            this.panelNews.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBookFlight
            // 
            this.panelBookFlight.BackColor = System.Drawing.Color.White;
            this.panelBookFlight.Controls.Add(this.btnGuestMinus);
            this.panelBookFlight.Controls.Add(this.btnGuestPlus);
            this.panelBookFlight.Controls.Add(this.radioButtonOneWay);
            this.panelBookFlight.Controls.Add(this.radioButtonReturn);
            this.panelBookFlight.Controls.Add(this.comboTo);
            this.panelBookFlight.Controls.Add(this.comboCabin);
            this.panelBookFlight.Controls.Add(this.comboFrom);
            this.panelBookFlight.Controls.Add(this.lblTo);
            this.panelBookFlight.Controls.Add(this.lblGuestCount);
            this.panelBookFlight.Controls.Add(this.lblGuest);
            this.panelBookFlight.Controls.Add(this.lblClass);
            this.panelBookFlight.Controls.Add(this.lblFrom);
            this.panelBookFlight.Controls.Add(this.lblBookFlight);
            this.panelBookFlight.Controls.Add(this.groupBoxTicketType);
            this.panelBookFlight.Location = new System.Drawing.Point(356, 93);
            this.panelBookFlight.Margin = new System.Windows.Forms.Padding(2);
            this.panelBookFlight.Name = "panelBookFlight";
            this.panelBookFlight.Size = new System.Drawing.Size(588, 288);
            this.panelBookFlight.TabIndex = 1;
            this.panelBookFlight.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBookFlight_Paint);
            // 
            // btnGuestMinus
            // 
            this.btnGuestMinus.Font = new System.Drawing.Font("Calibri", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuestMinus.Location = new System.Drawing.Point(355, 223);
            this.btnGuestMinus.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuestMinus.Name = "btnGuestMinus";
            this.btnGuestMinus.Size = new System.Drawing.Size(32, 32);
            this.btnGuestMinus.TabIndex = 5;
            this.btnGuestMinus.Text = "-";
            this.btnGuestMinus.UseVisualStyleBackColor = true;
            this.btnGuestMinus.Click += new System.EventHandler(this.btnGuestMinus_Click);
            // 
            // btnGuestPlus
            // 
            this.btnGuestPlus.Font = new System.Drawing.Font("Calibri", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuestPlus.Location = new System.Drawing.Point(450, 223);
            this.btnGuestPlus.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuestPlus.Name = "btnGuestPlus";
            this.btnGuestPlus.Size = new System.Drawing.Size(32, 32);
            this.btnGuestPlus.TabIndex = 5;
            this.btnGuestPlus.Text = "+";
            this.btnGuestPlus.UseVisualStyleBackColor = true;
            this.btnGuestPlus.Click += new System.EventHandler(this.btnGuestPlus_Click);
            // 
            // radioButtonOneWay
            // 
            this.radioButtonOneWay.AutoSize = true;
            this.radioButtonOneWay.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonOneWay.Font = new System.Drawing.Font("Calibri", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonOneWay.Location = new System.Drawing.Point(464, 32);
            this.radioButtonOneWay.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonOneWay.Name = "radioButtonOneWay";
            this.radioButtonOneWay.Size = new System.Drawing.Size(98, 27);
            this.radioButtonOneWay.TabIndex = 3;
            this.radioButtonOneWay.TabStop = true;
            this.radioButtonOneWay.Text = "One-way";
            this.radioButtonOneWay.UseVisualStyleBackColor = false;
            this.radioButtonOneWay.CheckedChanged += new System.EventHandler(this.radioButtonOneWay_CheckedChanged);
            // 
            // radioButtonReturn
            // 
            this.radioButtonReturn.AutoSize = true;
            this.radioButtonReturn.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonReturn.Checked = true;
            this.radioButtonReturn.Font = new System.Drawing.Font("Calibri", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonReturn.Location = new System.Drawing.Point(365, 32);
            this.radioButtonReturn.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonReturn.Name = "radioButtonReturn";
            this.radioButtonReturn.Size = new System.Drawing.Size(80, 27);
            this.radioButtonReturn.TabIndex = 2;
            this.radioButtonReturn.TabStop = true;
            this.radioButtonReturn.Text = "Return";
            this.radioButtonReturn.UseVisualStyleBackColor = false;
            this.radioButtonReturn.CheckedChanged += new System.EventHandler(this.radioButtonReturn_CheckedChanged);
            // 
            // comboTo
            // 
            this.comboTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboTo.DisplayMember = "Place";
            this.comboTo.DropDownHeight = 150;
            this.comboTo.Font = new System.Drawing.Font("Calibri", 15.02609F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboTo.FormattingEnabled = true;
            this.comboTo.IntegralHeight = false;
            this.comboTo.ItemHeight = 24;
            this.comboTo.Items.AddRange(new object[] {
            "Alabama",
            "Alaska",
            "Arizona",
            "Arkansas",
            "California",
            "Colorado",
            "Connecticut",
            "Delaware",
            "Florida",
            "Georgia",
            "Hawaii",
            "Idaho",
            "Illinois",
            "Indiana",
            "Iowa",
            "Kansas",
            "Kentucky",
            "Louisiana",
            "Maine",
            "Maryland",
            "Massachusetts",
            "Michigan",
            "Minnesota",
            "Mississippi",
            "Missouri",
            "Montana",
            "Nebraska",
            "Nevada",
            "New Hampshire",
            "New Jersey",
            "New Mexico",
            "New York",
            "North Carolina",
            "North Dakota",
            "Ohio",
            "Oklahoma",
            "Oregon",
            "Pennsylvania",
            "Rhode Island",
            "South Carolina",
            "South Dakota",
            "Tennessee",
            "Texas",
            "Utah",
            "Vermont",
            "Virginia",
            "Washington",
            "West Virginia",
            "Wisconsin",
            "Wyoming"});
            this.comboTo.Location = new System.Drawing.Point(350, 114);
            this.comboTo.Margin = new System.Windows.Forms.Padding(2);
            this.comboTo.Name = "comboTo";
            this.comboTo.Size = new System.Drawing.Size(196, 32);
            this.comboTo.TabIndex = 1;
            this.comboTo.Text = "Select Destination...";
            this.comboTo.ValueMember = "Place";
            // 
            // comboCabin
            // 
            this.comboCabin.AutoCompleteCustomSource.AddRange(new string[] {
            "Economy",
            "Business",
            "First"});
            this.comboCabin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboCabin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboCabin.DropDownHeight = 150;
            this.comboCabin.Font = new System.Drawing.Font("Calibri", 15.02609F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCabin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboCabin.FormattingEnabled = true;
            this.comboCabin.IntegralHeight = false;
            this.comboCabin.ItemHeight = 24;
            this.comboCabin.Items.AddRange(new object[] {
            "First Class",
            "Business",
            "Economy"});
            this.comboCabin.Location = new System.Drawing.Point(43, 220);
            this.comboCabin.Margin = new System.Windows.Forms.Padding(2);
            this.comboCabin.Name = "comboCabin";
            this.comboCabin.Size = new System.Drawing.Size(196, 32);
            this.comboCabin.TabIndex = 1;
            this.comboCabin.Text = "Select Cabin...";
            // 
            // comboFrom
            // 
            this.comboFrom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboFrom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboFrom.DisplayMember = "Place";
            this.comboFrom.DropDownHeight = 150;
            this.comboFrom.Font = new System.Drawing.Font("Calibri", 15.02609F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboFrom.FormattingEnabled = true;
            this.comboFrom.IntegralHeight = false;
            this.comboFrom.ItemHeight = 24;
            this.comboFrom.Items.AddRange(new object[] {
            "Alabama",
            "Alaska",
            "Arizona",
            "Arkansas",
            "California",
            "Colorado",
            "Connecticut",
            "Delaware",
            "Florida",
            "Georgia",
            "Hawaii",
            "Idaho",
            "Illinois",
            "Indiana",
            "Iowa",
            "Kansas",
            "Kentucky",
            "Louisiana",
            "Maine",
            "Maryland",
            "Massachusetts",
            "Michigan",
            "Minnesota",
            "Mississippi",
            "Missouri",
            "Montana",
            "Nebraska",
            "Nevada",
            "New Hampshire",
            "New Jersey",
            "New Mexico",
            "New York",
            "North Carolina",
            "North Dakota",
            "Ohio",
            "Oklahoma",
            "Oregon",
            "Pennsylvania",
            "Rhode Island",
            "South Carolina",
            "South Dakota",
            "Tennessee",
            "Texas",
            "Utah",
            "Vermont",
            "Virginia",
            "Washington",
            "West Virginia",
            "Wisconsin",
            "Wyoming"});
            this.comboFrom.Location = new System.Drawing.Point(43, 111);
            this.comboFrom.Margin = new System.Windows.Forms.Padding(2);
            this.comboFrom.Name = "comboFrom";
            this.comboFrom.Size = new System.Drawing.Size(196, 32);
            this.comboFrom.TabIndex = 1;
            this.comboFrom.Text = "Select Departure...";
            this.comboFrom.ValueMember = "Place";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.BackColor = System.Drawing.Color.Transparent;
            this.lblTo.Font = new System.Drawing.Font("Calibri", 16.27826F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(319, 76);
            this.lblTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(33, 27);
            this.lblTo.TabIndex = 0;
            this.lblTo.Text = "To";
            // 
            // lblGuestCount
            // 
            this.lblGuestCount.AllowDrop = true;
            this.lblGuestCount.BackColor = System.Drawing.Color.White;
            this.lblGuestCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGuestCount.Font = new System.Drawing.Font("Calibri", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestCount.Location = new System.Drawing.Point(397, 223);
            this.lblGuestCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGuestCount.Name = "lblGuestCount";
            this.lblGuestCount.Size = new System.Drawing.Size(42, 33);
            this.lblGuestCount.TabIndex = 0;
            this.lblGuestCount.Text = "1";
            this.lblGuestCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGuest
            // 
            this.lblGuest.AutoSize = true;
            this.lblGuest.BackColor = System.Drawing.Color.Transparent;
            this.lblGuest.Font = new System.Drawing.Font("Calibri", 16.27826F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuest.Location = new System.Drawing.Point(319, 186);
            this.lblGuest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGuest.Name = "lblGuest";
            this.lblGuest.Size = new System.Drawing.Size(65, 27);
            this.lblGuest.TabIndex = 0;
            this.lblGuest.Text = "Guest";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.BackColor = System.Drawing.Color.Transparent;
            this.lblClass.Font = new System.Drawing.Font("Calibri", 16.27826F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(4, 184);
            this.lblClass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(58, 27);
            this.lblClass.TabIndex = 0;
            this.lblClass.Text = "Class";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.BackColor = System.Drawing.Color.Transparent;
            this.lblFrom.Font = new System.Drawing.Font("Calibri", 16.27826F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(2, 73);
            this.lblFrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(60, 27);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "From";
            // 
            // lblBookFlight
            // 
            this.lblBookFlight.AutoSize = true;
            this.lblBookFlight.BackColor = System.Drawing.Color.Transparent;
            this.lblBookFlight.Font = new System.Drawing.Font("Calibri", 28.17391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookFlight.Location = new System.Drawing.Point(2, 11);
            this.lblBookFlight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookFlight.Name = "lblBookFlight";
            this.lblBookFlight.Size = new System.Drawing.Size(222, 46);
            this.lblBookFlight.TabIndex = 0;
            this.lblBookFlight.Text = "Book a Flight";
            // 
            // groupBoxTicketType
            // 
            this.groupBoxTicketType.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxTicketType.Font = new System.Drawing.Font("Calibri", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTicketType.Location = new System.Drawing.Point(338, 11);
            this.groupBoxTicketType.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxTicketType.Name = "groupBoxTicketType";
            this.groupBoxTicketType.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxTicketType.Size = new System.Drawing.Size(230, 56);
            this.groupBoxTicketType.TabIndex = 4;
            this.groupBoxTicketType.TabStop = false;
            this.groupBoxTicketType.Text = "Select ticket type";
            // 
            // placesBindingSource
            // 
            this.placesBindingSource.DataMember = "Places";
            // 
            // placesBindingSource1
            // 
            this.placesBindingSource1.DataMember = "Places";
            // 
            // panelDates
            // 
            this.panelDates.BackColor = System.Drawing.Color.White;
            this.panelDates.Controls.Add(this.dateTimeReturn);
            this.panelDates.Controls.Add(this.dateTimeOut);
            this.panelDates.Controls.Add(this.lblReturn);
            this.panelDates.Controls.Add(this.lblOutbound);
            this.panelDates.Location = new System.Drawing.Point(356, 418);
            this.panelDates.Margin = new System.Windows.Forms.Padding(2);
            this.panelDates.Name = "panelDates";
            this.panelDates.Size = new System.Drawing.Size(588, 98);
            this.panelDates.TabIndex = 3;
            this.panelDates.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDates_Paint);
            // 
            // dateTimeReturn
            // 
            this.dateTimeReturn.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateTimeReturn.Font = new System.Drawing.Font("Calibri", 15.02609F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeReturn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeReturn.Location = new System.Drawing.Point(350, 39);
            this.dateTimeReturn.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeReturn.MinDate = new System.DateTime(2020, 3, 20, 0, 0, 0, 0);
            this.dateTimeReturn.Name = "dateTimeReturn";
            this.dateTimeReturn.Size = new System.Drawing.Size(196, 32);
            this.dateTimeReturn.TabIndex = 0;
            this.dateTimeReturn.Value = new System.DateTime(2020, 3, 31, 0, 0, 0, 0);
            // 
            // dateTimeOut
            // 
            this.dateTimeOut.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateTimeOut.Font = new System.Drawing.Font("Calibri", 15.02609F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeOut.Location = new System.Drawing.Point(43, 39);
            this.dateTimeOut.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeOut.MinDate = new System.DateTime(2020, 3, 20, 0, 0, 0, 0);
            this.dateTimeOut.Name = "dateTimeOut";
            this.dateTimeOut.Size = new System.Drawing.Size(196, 32);
            this.dateTimeOut.TabIndex = 0;
            this.dateTimeOut.Value = new System.DateTime(2020, 3, 31, 0, 0, 0, 0);
            // 
            // lblReturn
            // 
            this.lblReturn.AutoSize = true;
            this.lblReturn.BackColor = System.Drawing.Color.Transparent;
            this.lblReturn.Font = new System.Drawing.Font("Calibri", 16.27826F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturn.Location = new System.Drawing.Point(319, 6);
            this.lblReturn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReturn.Name = "lblReturn";
            this.lblReturn.Size = new System.Drawing.Size(74, 27);
            this.lblReturn.TabIndex = 0;
            this.lblReturn.Text = "Return";
            // 
            // lblOutbound
            // 
            this.lblOutbound.AutoSize = true;
            this.lblOutbound.BackColor = System.Drawing.Color.Transparent;
            this.lblOutbound.Font = new System.Drawing.Font("Calibri", 16.27826F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutbound.Location = new System.Drawing.Point(4, 6);
            this.lblOutbound.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOutbound.Name = "lblOutbound";
            this.lblOutbound.Size = new System.Drawing.Size(106, 27);
            this.lblOutbound.TabIndex = 0;
            this.lblOutbound.Text = "Outbound";
            // 
            // btnSearchFlight
            // 
            this.btnSearchFlight.AllowDrop = true;
            this.btnSearchFlight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(172)))), ((int)(((byte)(69)))));
            this.btnSearchFlight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchFlight.Font = new System.Drawing.Font("Calibri", 16.27826F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchFlight.ForeColor = System.Drawing.Color.Black;
            this.btnSearchFlight.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchFlight.Image")));
            this.btnSearchFlight.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnSearchFlight.Location = new System.Drawing.Point(356, 549);
            this.btnSearchFlight.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchFlight.Name = "btnSearchFlight";
            this.btnSearchFlight.Size = new System.Drawing.Size(248, 58);
            this.btnSearchFlight.TabIndex = 4;
            this.btnSearchFlight.Text = "Search Flight";
            this.btnSearchFlight.UseVisualStyleBackColor = false;
            this.btnSearchFlight.Click += new System.EventHandler(this.btnSearchFlight_Click);
            // 
            // btnReset
            // 
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnReset.Font = new System.Drawing.Font("Calibri", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(651, 555);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(142, 44);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(801, 555);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(142, 44);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelTicketSearch
            // 
            this.panelTicketSearch.Controls.Add(this.btnSearchTicket);
            this.panelTicketSearch.Controls.Add(this.label14);
            this.panelTicketSearch.Location = new System.Drawing.Point(23, 405);
            this.panelTicketSearch.Margin = new System.Windows.Forms.Padding(2);
            this.panelTicketSearch.Name = "panelTicketSearch";
            this.panelTicketSearch.Size = new System.Drawing.Size(188, 135);
            this.panelTicketSearch.TabIndex = 12;
            this.panelTicketSearch.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTicketSearch_Paint);
            // 
            // btnSearchTicket
            // 
            this.btnSearchTicket.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearchTicket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchTicket.Font = new System.Drawing.Font("Calibri", 11.26957F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchTicket.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearchTicket.Location = new System.Drawing.Point(38, 67);
            this.btnSearchTicket.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchTicket.Name = "btnSearchTicket";
            this.btnSearchTicket.Size = new System.Drawing.Size(113, 39);
            this.btnSearchTicket.TabIndex = 2;
            this.btnSearchTicket.Text = "Search Ticket";
            this.btnSearchTicket.UseVisualStyleBackColor = false;
            this.btnSearchTicket.Click += new System.EventHandler(this.btnSearchTicket_Click);
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Calibri", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 42);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(174, 23);
            this.label14.TabIndex = 0;
            this.label14.Text = "Look up Booking Number";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBoxNews2
            // 
            this.pictureBoxNews2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNews2.Image")));
            this.pictureBoxNews2.Location = new System.Drawing.Point(21, 254);
            this.pictureBoxNews2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxNews2.Name = "pictureBoxNews2";
            this.pictureBoxNews2.Size = new System.Drawing.Size(225, 162);
            this.pictureBoxNews2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNews2.TabIndex = 7;
            this.pictureBoxNews2.TabStop = false;
            // 
            // lblNews
            // 
            this.lblNews.AutoSize = true;
            this.lblNews.BackColor = System.Drawing.Color.Transparent;
            this.lblNews.Font = new System.Drawing.Font("Calibri", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNews.Location = new System.Drawing.Point(111, 9);
            this.lblNews.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNews.Name = "lblNews";
            this.lblNews.Size = new System.Drawing.Size(55, 23);
            this.lblNews.TabIndex = 0;
            this.lblNews.Text = "News";
            // 
            // lblNewsDesc2
            // 
            this.lblNewsDesc2.BackColor = System.Drawing.Color.Transparent;
            this.lblNewsDesc2.Font = new System.Drawing.Font("Calibri", 11.26957F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewsDesc2.Location = new System.Drawing.Point(22, 417);
            this.lblNewsDesc2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNewsDesc2.Name = "lblNewsDesc2";
            this.lblNewsDesc2.Size = new System.Drawing.Size(220, 40);
            this.lblNewsDesc2.TabIndex = 9;
            this.lblNewsDesc2.Text = "Special assistance for elderly or disabled passengers";
            // 
            // pictureBoxNews1
            // 
            this.pictureBoxNews1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNews1.Image")));
            this.pictureBoxNews1.Location = new System.Drawing.Point(21, 44);
            this.pictureBoxNews1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxNews1.Name = "pictureBoxNews1";
            this.pictureBoxNews1.Size = new System.Drawing.Size(225, 162);
            this.pictureBoxNews1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNews1.TabIndex = 6;
            this.pictureBoxNews1.TabStop = false;
            // 
            // lblNewsDesc1
            // 
            this.lblNewsDesc1.BackColor = System.Drawing.Color.Transparent;
            this.lblNewsDesc1.Font = new System.Drawing.Font("Calibri", 11.26957F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewsDesc1.Location = new System.Drawing.Point(23, 209);
            this.lblNewsDesc1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNewsDesc1.Name = "lblNewsDesc1";
            this.lblNewsDesc1.Size = new System.Drawing.Size(223, 43);
            this.lblNewsDesc1.TabIndex = 8;
            this.lblNewsDesc1.Text = "Self check in: a seamless experience";
            // 
            // pictureBoxNews3
            // 
            this.pictureBoxNews3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNews3.Image")));
            this.pictureBoxNews3.Location = new System.Drawing.Point(26, 476);
            this.pictureBoxNews3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxNews3.Name = "pictureBoxNews3";
            this.pictureBoxNews3.Size = new System.Drawing.Size(225, 162);
            this.pictureBoxNews3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNews3.TabIndex = 7;
            this.pictureBoxNews3.TabStop = false;
            // 
            // lblNewsDesc3
            // 
            this.lblNewsDesc3.BackColor = System.Drawing.Color.Transparent;
            this.lblNewsDesc3.Font = new System.Drawing.Font("Calibri", 11.26957F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewsDesc3.Location = new System.Drawing.Point(28, 641);
            this.lblNewsDesc3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNewsDesc3.Name = "lblNewsDesc3";
            this.lblNewsDesc3.Size = new System.Drawing.Size(218, 40);
            this.lblNewsDesc3.TabIndex = 10;
            this.lblNewsDesc3.Text = "Enjoy your flight with a wide selection of meals and wines";
            // 
            // panelNews
            // 
            this.panelNews.Controls.Add(this.lblNewsDesc3);
            this.panelNews.Controls.Add(this.pictureBoxNews3);
            this.panelNews.Controls.Add(this.lblNewsDesc1);
            this.panelNews.Controls.Add(this.pictureBoxNews1);
            this.panelNews.Controls.Add(this.lblNewsDesc2);
            this.panelNews.Controls.Add(this.lblNews);
            this.panelNews.Controls.Add(this.pictureBoxNews2);
            this.panelNews.Location = new System.Drawing.Point(1076, 31);
            this.panelNews.Margin = new System.Windows.Forms.Padding(2);
            this.panelNews.Name = "panelNews";
            this.panelNews.Size = new System.Drawing.Size(266, 685);
            this.panelNews.TabIndex = 11;
            this.panelNews.Paint += new System.Windows.Forms.PaintEventHandler(this.panelNews_Paint);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Image = global::flight1.Properties.Resources.logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(11, 8);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(258, 292);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // FormMain
            // 
            this.AcceptButton = this.btnSearchFlight;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1424, 800);
            this.Controls.Add(this.panelTicketSearch);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSearchFlight);
            this.Controls.Add(this.panelDates);
            this.Controls.Add(this.panelBookFlight);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.panelNews);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Bamboo Airways Flight Booking";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelBookFlight.ResumeLayout(false);
            this.panelBookFlight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.placesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placesBindingSource1)).EndInit();
            this.panelDates.ResumeLayout(false);
            this.panelDates.PerformLayout();
            this.panelTicketSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNews2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNews1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNews3)).EndInit();
            this.panelNews.ResumeLayout(false);
            this.panelNews.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelBookFlight;
        private System.Windows.Forms.Label lblBookFlight;
        //private flightDataSet flightDataSet;
        private System.Windows.Forms.BindingSource placesBindingSource;
        //private flightDataSetTableAdapters.PlacesTableAdapter placesTableAdapter;
        private System.Windows.Forms.ComboBox comboFrom;
        //private flightDataSet1 flightDataSet1;
        private System.Windows.Forms.BindingSource placesBindingSource1;
        //private flightDataSet1TableAdapters.PlacesTableAdapter placesTableAdapter1;
        private System.Windows.Forms.RadioButton radioButtonOneWay;
        private System.Windows.Forms.ComboBox comboTo;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Button btnGuestMinus;
        private System.Windows.Forms.Button btnGuestPlus;
        private System.Windows.Forms.ComboBox comboCabin;
        private System.Windows.Forms.Label lblGuestCount;
        private System.Windows.Forms.Label lblGuest;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.GroupBox groupBoxTicketType;
        private System.Windows.Forms.Panel panelDates;
        private System.Windows.Forms.DateTimePicker dateTimeReturn;
        private System.Windows.Forms.DateTimePicker dateTimeOut;
        private System.Windows.Forms.Label lblReturn;
        private System.Windows.Forms.Label lblOutbound;
        private System.Windows.Forms.Button btnSearchFlight;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.RadioButton radioButtonReturn;
        private System.Windows.Forms.Panel panelTicketSearch;
        private System.Windows.Forms.Button btnSearchTicket;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBoxNews2;
        private System.Windows.Forms.Label lblNews;
        private System.Windows.Forms.Label lblNewsDesc2;
        private System.Windows.Forms.PictureBox pictureBoxNews1;
        private System.Windows.Forms.Label lblNewsDesc1;
        private System.Windows.Forms.PictureBox pictureBoxNews3;
        private System.Windows.Forms.Label lblNewsDesc3;
        private System.Windows.Forms.Panel panelNews;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}

