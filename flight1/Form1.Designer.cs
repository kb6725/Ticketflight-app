namespace flight1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.comboTo = new System.Windows.Forms.ComboBox();
            this.placesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flightDataSet = new flight1.flightDataSet();
            this.combocabin = new System.Windows.Forms.ComboBox();
            this.comboFrom = new System.Windows.Forms.ComboBox();
            this.placesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.flightDataSet1 = new flight1.flightDataSet1();
            this.labelto = new System.Windows.Forms.Label();
            this.labelguest = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.placesTableAdapter = new flight1.flightDataSetTableAdapters.PlacesTableAdapter();
            this.placesTableAdapter1 = new flight1.flightDataSet1TableAdapters.PlacesTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dateTimereturn = new System.Windows.Forms.DateTimePicker();
            this.dateTimeout = new System.Windows.Forms.DateTimePicker();
            this.labelreturn = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonsearch = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.placesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightDataSet1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 725);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.comboTo);
            this.panel1.Controls.Add(this.combocabin);
            this.panel1.Controls.Add(this.comboFrom);
            this.panel1.Controls.Add(this.labelto);
            this.panel1.Controls.Add(this.labelguest);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(451, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 355);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(473, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 40);
            this.button2.TabIndex = 5;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(600, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Calibri", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(618, 39);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(112, 31);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "One-way";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Calibri", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(487, 39);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(92, 31);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Return";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // comboTo
            // 
            this.comboTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboTo.DataSource = this.placesBindingSource;
            this.comboTo.DisplayMember = "Place";
            this.comboTo.Font = new System.Drawing.Font("Calibri", 16.27826F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboTo.FormattingEnabled = true;
            this.comboTo.IntegralHeight = false;
            this.comboTo.ItemHeight = 32;
            this.comboTo.Location = new System.Drawing.Point(466, 140);
            this.comboTo.Name = "comboTo";
            this.comboTo.Size = new System.Drawing.Size(260, 40);
            this.comboTo.TabIndex = 1;
            this.comboTo.ValueMember = "Place";
            // 
            // placesBindingSource
            // 
            this.placesBindingSource.DataMember = "Places";
            this.placesBindingSource.DataSource = this.flightDataSet;
            // 
            // flightDataSet
            // 
            this.flightDataSet.DataSetName = "flightDataSet";
            this.flightDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // combocabin
            // 
            this.combocabin.AutoCompleteCustomSource.AddRange(new string[] {
            "Economy",
            "Business",
            "First"});
            this.combocabin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combocabin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combocabin.DropDownHeight = 150;
            this.combocabin.Font = new System.Drawing.Font("Calibri", 16.27826F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combocabin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.combocabin.FormattingEnabled = true;
            this.combocabin.IntegralHeight = false;
            this.combocabin.ItemHeight = 32;
            this.combocabin.Items.AddRange(new object[] {
            "First Class",
            "Business",
            "Economy"});
            this.combocabin.Location = new System.Drawing.Point(57, 290);
            this.combocabin.Name = "combocabin";
            this.combocabin.Size = new System.Drawing.Size(260, 40);
            this.combocabin.TabIndex = 1;
            this.combocabin.Text = "Select Cabin ...";
            this.combocabin.SelectedIndexChanged += new System.EventHandler(this.comboFrom_SelectedIndexChanged);
            // 
            // comboFrom
            // 
            this.comboFrom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboFrom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboFrom.DataSource = this.placesBindingSource1;
            this.comboFrom.DisplayMember = "Place";
            this.comboFrom.DropDownHeight = 150;
            this.comboFrom.Font = new System.Drawing.Font("Calibri", 16.27826F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboFrom.FormattingEnabled = true;
            this.comboFrom.IntegralHeight = false;
            this.comboFrom.ItemHeight = 32;
            this.comboFrom.Location = new System.Drawing.Point(57, 137);
            this.comboFrom.Name = "comboFrom";
            this.comboFrom.Size = new System.Drawing.Size(260, 40);
            this.comboFrom.TabIndex = 1;
            this.comboFrom.ValueMember = "Place";
            this.comboFrom.SelectedIndexChanged += new System.EventHandler(this.comboFrom_SelectedIndexChanged);
            // 
            // placesBindingSource1
            // 
            this.placesBindingSource1.DataMember = "Places";
            this.placesBindingSource1.DataSource = this.flightDataSet1;
            // 
            // flightDataSet1
            // 
            this.flightDataSet1.DataSetName = "flightDataSet1";
            this.flightDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelto
            // 
            this.labelto.AutoSize = true;
            this.labelto.BackColor = System.Drawing.Color.Transparent;
            this.labelto.Font = new System.Drawing.Font("Calibri", 18.15652F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelto.Location = new System.Drawing.Point(425, 93);
            this.labelto.Name = "labelto";
            this.labelto.Size = new System.Drawing.Size(41, 36);
            this.labelto.TabIndex = 0;
            this.labelto.Text = "To";
            // 
            // labelguest
            // 
            this.labelguest.AllowDrop = true;
            this.labelguest.BackColor = System.Drawing.Color.Transparent;
            this.labelguest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelguest.Font = new System.Drawing.Font("Calibri", 18.15652F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelguest.Location = new System.Drawing.Point(529, 293);
            this.labelguest.Name = "labelguest";
            this.labelguest.Size = new System.Drawing.Size(56, 40);
            this.labelguest.TabIndex = 0;
            this.labelguest.Text = "1";
            this.labelguest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelguest.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 18.15652F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(425, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 36);
            this.label4.TabIndex = 0;
            this.label4.Text = "Guest";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 18.15652F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cabin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 18.15652F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "From";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 28.17391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book a Flight";
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(450, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 69);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select ticket type";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // placesTableAdapter
            // 
            this.placesTableAdapter.ClearBeforeFill = true;
            // 
            // placesTableAdapter1
            // 
            this.placesTableAdapter1.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dateTimereturn);
            this.panel3.Controls.Add(this.dateTimeout);
            this.panel3.Controls.Add(this.labelreturn);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(451, 522);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(784, 120);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // dateTimereturn
            // 
            this.dateTimereturn.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateTimereturn.Font = new System.Drawing.Font("Calibri", 16.27826F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimereturn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimereturn.Location = new System.Drawing.Point(466, 48);
            this.dateTimereturn.MinDate = new System.DateTime(2020, 3, 20, 0, 0, 0, 0);
            this.dateTimereturn.Name = "dateTimereturn";
            this.dateTimereturn.Size = new System.Drawing.Size(260, 39);
            this.dateTimereturn.TabIndex = 0;
            this.dateTimereturn.Value = new System.DateTime(2020, 3, 20, 0, 0, 0, 0);
            this.dateTimereturn.ValueChanged += new System.EventHandler(this.dateTimereturn_ValueChanged);
            // 
            // dateTimeout
            // 
            this.dateTimeout.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateTimeout.Font = new System.Drawing.Font("Calibri", 16.27826F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeout.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeout.Location = new System.Drawing.Point(57, 48);
            this.dateTimeout.MinDate = new System.DateTime(2020, 3, 20, 0, 0, 0, 0);
            this.dateTimeout.Name = "dateTimeout";
            this.dateTimeout.Size = new System.Drawing.Size(260, 39);
            this.dateTimeout.TabIndex = 0;
            this.dateTimeout.Value = new System.DateTime(2020, 3, 20, 0, 0, 0, 0);
            this.dateTimeout.ValueChanged += new System.EventHandler(this.dateTimeout_ValueChanged);
            // 
            // labelreturn
            // 
            this.labelreturn.AutoSize = true;
            this.labelreturn.BackColor = System.Drawing.Color.Transparent;
            this.labelreturn.Font = new System.Drawing.Font("Calibri", 18.15652F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelreturn.Location = new System.Drawing.Point(425, 8);
            this.labelreturn.Name = "labelreturn";
            this.labelreturn.Size = new System.Drawing.Size(94, 36);
            this.labelreturn.TabIndex = 0;
            this.labelreturn.Text = "Return";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 18.15652F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 36);
            this.label5.TabIndex = 0;
            this.label5.Text = "Outbound";
            // 
            // buttonsearch
            // 
            this.buttonsearch.AllowDrop = true;
            this.buttonsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(172)))), ((int)(((byte)(69)))));
            this.buttonsearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonsearch.Font = new System.Drawing.Font("Calibri", 16.27826F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsearch.ForeColor = System.Drawing.Color.Black;
            this.buttonsearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonsearch.Image")));
            this.buttonsearch.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.buttonsearch.Location = new System.Drawing.Point(508, 671);
            this.buttonsearch.Name = "buttonsearch";
            this.buttonsearch.Size = new System.Drawing.Size(264, 54);
            this.buttonsearch.TabIndex = 4;
            this.buttonsearch.Text = "Search Flight";
            this.buttonsearch.UseVisualStyleBackColor = false;
            this.buttonsearch.Click += new System.EventHandler(this.buttonsearch_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button4.Font = new System.Drawing.Font("Calibri", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(901, 672);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 53);
            this.button4.TabIndex = 5;
            this.button4.Text = "Reset";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Font = new System.Drawing.Font("Calibri", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1051, 671);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 54);
            this.button3.TabIndex = 5;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1223, 725);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonsearch);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.placesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightDataSet1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private flightDataSet flightDataSet;
        private System.Windows.Forms.BindingSource placesBindingSource;
        private flightDataSetTableAdapters.PlacesTableAdapter placesTableAdapter;
        private System.Windows.Forms.ComboBox comboFrom;
        private flightDataSet1 flightDataSet1;
        private System.Windows.Forms.BindingSource placesBindingSource1;
        private flightDataSet1TableAdapters.PlacesTableAdapter placesTableAdapter1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ComboBox comboTo;
        private System.Windows.Forms.Label labelto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox combocabin;
        private System.Windows.Forms.Label labelguest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dateTimereturn;
        private System.Windows.Forms.DateTimePicker dateTimeout;
        private System.Windows.Forms.Label labelreturn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonsearch;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.RadioButton radioButton1;
    }
}

