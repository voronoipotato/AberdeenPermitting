namespace BuildingPermit
{
    partial class frmPropertyLookup
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
            this.btnPropertyAccept = new System.Windows.Forms.Button();
            this.cmbPropertyResults = new System.Windows.Forms.ComboBox();
            this.txtPropertyDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLookUp = new System.Windows.Forms.Button();
            this.txtLRK = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPropertyOwner = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPropertyAccept
            // 
            this.btnPropertyAccept.Location = new System.Drawing.Point(440, 94);
            this.btnPropertyAccept.Name = "btnPropertyAccept";
            this.btnPropertyAccept.Size = new System.Drawing.Size(75, 23);
            this.btnPropertyAccept.TabIndex = 221;
            this.btnPropertyAccept.Text = "Accept";
            this.btnPropertyAccept.UseVisualStyleBackColor = true;
            // 
            // cmbPropertyResults
            // 
            this.cmbPropertyResults.FormattingEnabled = true;
            this.cmbPropertyResults.Items.AddRange(new object[] {
            "*pull from query"});
            this.cmbPropertyResults.Location = new System.Drawing.Point(15, 94);
            this.cmbPropertyResults.Name = "cmbPropertyResults";
            this.cmbPropertyResults.Size = new System.Drawing.Size(399, 21);
            this.cmbPropertyResults.TabIndex = 220;
            // 
            // txtPropertyDescription
            // 
            this.txtPropertyDescription.Location = new System.Drawing.Point(282, 17);
            this.txtPropertyDescription.Name = "txtPropertyDescription";
            this.txtPropertyDescription.Size = new System.Drawing.Size(233, 20);
            this.txtPropertyDescription.TabIndex = 219;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 218;
            this.label1.Text = "Property Description";
            // 
            // btnLookUp
            // 
            this.btnLookUp.Location = new System.Drawing.Point(440, 43);
            this.btnLookUp.Name = "btnLookUp";
            this.btnLookUp.Size = new System.Drawing.Size(75, 23);
            this.btnLookUp.TabIndex = 217;
            this.btnLookUp.Text = "Look Up";
            this.btnLookUp.UseVisualStyleBackColor = true;
            this.btnLookUp.Click += new System.EventHandler(this.btnLookUp_Click);
            // 
            // txtLRK
            // 
            this.txtLRK.Location = new System.Drawing.Point(53, 20);
            this.txtLRK.Name = "txtLRK";
            this.txtLRK.Size = new System.Drawing.Size(96, 20);
            this.txtLRK.TabIndex = 216;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 215;
            this.label9.Text = "LRK#";
            // 
            // txtPropertyOwner
            // 
            this.txtPropertyOwner.Location = new System.Drawing.Point(104, 46);
            this.txtPropertyOwner.Name = "txtPropertyOwner";
            this.txtPropertyOwner.Size = new System.Drawing.Size(310, 20);
            this.txtPropertyOwner.TabIndex = 223;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 222;
            this.label2.Text = "Property Owner";
            // 
            // frmPropertyLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 138);
            this.Controls.Add(this.txtPropertyOwner);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPropertyAccept);
            this.Controls.Add(this.cmbPropertyResults);
            this.Controls.Add(this.txtPropertyDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLookUp);
            this.Controls.Add(this.txtLRK);
            this.Controls.Add(this.label9);
            this.Name = "frmPropertyLookup";
            this.Text = "Property";
            this.Load += new System.EventHandler(this.frmPropertyLookup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPropertyAccept;
        private System.Windows.Forms.ComboBox cmbPropertyResults;
        internal System.Windows.Forms.TextBox txtPropertyDescription;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLookUp;
        internal System.Windows.Forms.TextBox txtLRK;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.TextBox txtPropertyOwner;
        internal System.Windows.Forms.Label label2;
    }
}