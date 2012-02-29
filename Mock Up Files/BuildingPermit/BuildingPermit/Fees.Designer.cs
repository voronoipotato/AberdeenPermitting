namespace BuildingPermit
{
    partial class Fees
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cmbFeeNames = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Items = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAddPayment = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddItem);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.cmbFeeNames);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 146);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Item";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(79, 116);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 23);
            this.btnAddItem.TabIndex = 216;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 20);
            this.textBox1.TabIndex = 215;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 214;
            this.label2.Text = "Item Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 213;
            this.label1.Text = "Item Info";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 212;
            this.label9.Text = "Item";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(79, 46);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(473, 37);
            this.textBox2.TabIndex = 211;
            // 
            // cmbFeeNames
            // 
            this.cmbFeeNames.FormattingEnabled = true;
            this.cmbFeeNames.Items.AddRange(new object[] {
            "Residential Building (Including Additions) ",
            "Residential Building (Remodel/Alterations) ",
            "Commercial Building ",
            "Commercial Upfit ",
            "NCHORF (required by State of NC) ",
            "Insulation ",
            "Commercial Insulation ",
            "Shed – Prefabricated ",
            "Deck ",
            "-------------------------------------------------",
            "Temporary Pole - Residential ",
            "Temporary Pole - Commercial ",
            "Electrical 100 Amp Service (1 Phase) ",
            "Electrical 200 Amp Service (1 Phase) ",
            "Electrical 320 Amp Service (1 Phase) ",
            "Electrical 400 Amp Service (1 Phase) ",
            "Electrical 600 Amp Service (1 Phase) ",
            "Electrical 600/+ Amp Service (1 Phase) ",
            "Electrical 200 Amp Service (3 Phase) ",
            "Electrical 400 Amp Service (3 Phase) ",
            "Electrical 600 Amp Service (3 Phase) ",
            "Electrical 800 Amp Service (3 Phase) ",
            "Electrical 1000 Amp Service (3 Phase) ",
            "Panel/Mtr. Base Replacement ",
            "Panel Replacement with service change ",
            "Alterations (remodel or addition) ",
            "Service Change Only ",
            "Load Control / Disconnect ",
            "-------------------------------------------------",
            "Plumbing Residential ",
            "Plumbing Commercial ",
            "Hot-Water Heater Change-out ",
            "Sprinkler System – Irrigation ",
            "Water/Sewer Tap ",
            "-------------------------------------------------",
            "Mechanical ",
            "Mechanical – Commercial units ",
            "New Gas Line ",
            "Commercial Range, Grease Hood, Etc. ",
            "Smoke Test – over 5 tons ",
            "Duct Work for alterations ",
            "Refrigeration ",
            "-------------------------------------------------",
            "Demolition ",
            "Pool – includes electrical ",
            "Petroleum Tanks (above/below) ",
            "Petroleum Product Dispenser ",
            "Fire Alarm System (includes plan review) ",
            "Fire Sprinkler Systems: New/Renovations ",
            "Fence ",
            "Day Care Special Inspection ",
            "Singlewide/Doublewide ",
            "-------------------------------------------------",
            "Re-inspection fee ",
            "Failure to obtain permit ",
            "Building Inspector Plan Review ",
            "Site Plan (Single Family/No Fee) ",
            "Rezoning ",
            "Special Use ",
            "Conditional Use - Planned Development ",
            "Conditional Use – Other ",
            "Subdivision – Major/Minor subdivisions ",
            "Preliminary/Final Plat ",
            "Text Amendment ",
            "Board of Adjustment ",
            "Commercial Building Reuse Inspection ",
            "Certificate of Appropriateness ",
            "Special Events ",
            "Zoning Permit ",
            "Zoning Permit New Use and Change of Use ",
            "Zoning Permit Ownership Change or No Change in Use ",
            "Zoning Compliance Letter ",
            "-------------------------------------------------",
            "Sign Permit ",
            "Master Sign Plan ",
            "Banner Permit ",
            "ABC Permit ",
            "-------------------------------------------------",
            "Standard 8.5 x 11 Map ",
            "Standard 11 x 17 Map ",
            "Standard 34 X 44 Map ",
            "Custom Mapping ",
            "Custom Aerial Maps 8.5 x 11 ",
            "Custom Aerial Maps 34 x 44 "});
            this.cmbFeeNames.Location = new System.Drawing.Point(79, 19);
            this.cmbFeeNames.Name = "cmbFeeNames";
            this.cmbFeeNames.Size = new System.Drawing.Size(473, 21);
            this.cmbFeeNames.TabIndex = 210;
            this.cmbFeeNames.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRemove);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Items);
            this.groupBox2.Location = new System.Drawing.Point(13, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(564, 138);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Items";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(406, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 223;
            this.label8.Text = "xxx.xx";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(398, 95);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(141, 20);
            this.textBox5.TabIndex = 222;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(305, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 221;
            this.label7.Text = "Balance Due";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(305, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 219;
            this.label6.Text = "Amount Paid";
            // 
            // Items
            // 
            this.Items.FormattingEnabled = true;
            this.Items.Location = new System.Drawing.Point(14, 20);
            this.Items.Name = "Items";
            this.Items.Size = new System.Drawing.Size(525, 43);
            this.Items.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAddPayment);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(13, 309);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(564, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Payment";
            // 
            // btnAddPayment
            // 
            this.btnAddPayment.Location = new System.Drawing.Point(101, 75);
            this.btnAddPayment.Name = "btnAddPayment";
            this.btnAddPayment.Size = new System.Drawing.Size(83, 23);
            this.btnAddPayment.TabIndex = 225;
            this.btnAddPayment.Text = "Add Payment";
            this.btnAddPayment.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(343, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 224;
            this.label5.Text = "Received By";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(422, 51);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(117, 21);
            this.comboBox2.TabIndex = 223;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(419, 25);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(30, 13);
            this.label22.TabIndex = 222;
            this.label22.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(455, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(84, 20);
            this.dateTimePicker1.TabIndex = 221;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 220;
            this.label4.Text = "Pay Type";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(101, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(141, 21);
            this.comboBox1.TabIndex = 219;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(101, 22);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(141, 20);
            this.textBox3.TabIndex = 218;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 217;
            this.label3.Text = "Payment Amount";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCancel);
            this.groupBox4.Controls.Add(this.btnSubmit);
            this.groupBox4.Location = new System.Drawing.Point(13, 415);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(564, 52);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Finalize";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(319, 19);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 23);
            this.btnCancel.TabIndex = 227;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(179, 19);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(83, 23);
            this.btnSubmit.TabIndex = 226;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(11, 95);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 217;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // Fees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 471);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Fees";
            this.Text = "Fees";
            this.Load += new System.EventHandler(this.Fees_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbFeeNames;
        internal System.Windows.Forms.TextBox textBox2;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAddItem;
        internal System.Windows.Forms.TextBox textBox1;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        internal System.Windows.Forms.TextBox textBox3;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.TextBox textBox5;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox Items;
        private System.Windows.Forms.Button btnAddPayment;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
        internal System.Windows.Forms.Label label22;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnRemove;
    }
}