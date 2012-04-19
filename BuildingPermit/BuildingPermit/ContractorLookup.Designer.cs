namespace BuildingPermit
{
    partial class ContractorLookup
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
            this.btnLookUp = new System.Windows.Forms.Button();
            this.txtContractorName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textLicenseNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTypeList = new System.Windows.Forms.ComboBox();
            this.btnContractorAccept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLookUp
            // 
            this.btnLookUp.Location = new System.Drawing.Point(542, 17);
            this.btnLookUp.Name = "btnLookUp";
            this.btnLookUp.Size = new System.Drawing.Size(75, 23);
            this.btnLookUp.TabIndex = 210;
            this.btnLookUp.Text = "Look Up";
            this.btnLookUp.UseVisualStyleBackColor = true;
            // 
            // txtContractorName
            // 
            this.txtContractorName.Location = new System.Drawing.Point(83, 21);
            this.txtContractorName.Name = "txtContractorName";
            this.txtContractorName.Size = new System.Drawing.Size(214, 20);
            this.txtContractorName.TabIndex = 209;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 208;
            this.label9.Text = "Contractor";
            // 
            // textLicenseNumber
            // 
            this.textLicenseNumber.Location = new System.Drawing.Point(383, 19);
            this.textLicenseNumber.Name = "textLicenseNumber";
            this.textLicenseNumber.Size = new System.Drawing.Size(130, 20);
            this.textLicenseNumber.TabIndex = 212;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 211;
            this.label1.Text = "License #";
            // 
            // cmbTypeList
            // 
            this.cmbTypeList.FormattingEnabled = true;
            this.cmbTypeList.Items.AddRange(new object[] {
            "*pull from query"});
            this.cmbTypeList.Location = new System.Drawing.Point(83, 65);
            this.cmbTypeList.Name = "cmbTypeList";
            this.cmbTypeList.Size = new System.Drawing.Size(430, 21);
            this.cmbTypeList.TabIndex = 213;
            // 
            // btnContractorAccept
            // 
            this.btnContractorAccept.Location = new System.Drawing.Point(542, 63);
            this.btnContractorAccept.Name = "btnContractorAccept";
            this.btnContractorAccept.Size = new System.Drawing.Size(75, 23);
            this.btnContractorAccept.TabIndex = 214;
            this.btnContractorAccept.Text = "Accept";
            this.btnContractorAccept.UseVisualStyleBackColor = true;
            // 
            // ContractorLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 102);
            this.Controls.Add(this.btnContractorAccept);
            this.Controls.Add(this.cmbTypeList);
            this.Controls.Add(this.textLicenseNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLookUp);
            this.Controls.Add(this.txtContractorName);
            this.Controls.Add(this.label9);
            this.Name = "ContractorLookup";
            this.Text = "Contractor Lookup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLookUp;
        internal System.Windows.Forms.TextBox txtContractorName;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.TextBox textLicenseNumber;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTypeList;
        private System.Windows.Forms.Button btnContractorAccept;
    }
}