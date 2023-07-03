namespace A05_01
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
            this.chkHamburger = new System.Windows.Forms.CheckBox();
            this.chkFries = new System.Windows.Forms.CheckBox();
            this.chkDrink = new System.Windows.Forms.CheckBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.lstHamburger = new System.Windows.Forms.CheckedListBox();
            this.cmbFries = new System.Windows.Forms.ComboBox();
            this.cmbDrink = new System.Windows.Forms.ComboBox();
            this.cmbDrink2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // chkHamburger
            // 
            this.chkHamburger.AutoSize = true;
            this.chkHamburger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHamburger.Location = new System.Drawing.Point(129, 348);
            this.chkHamburger.Name = "chkHamburger";
            this.chkHamburger.Size = new System.Drawing.Size(219, 41);
            this.chkHamburger.TabIndex = 0;
            this.chkHamburger.Text = "Hamburger";
            this.chkHamburger.UseVisualStyleBackColor = true;
            this.chkHamburger.CheckedChanged += new System.EventHandler(this.chkHamburger_CheckedChanged);
            // 
            // chkFries
            // 
            this.chkFries.AutoSize = true;
            this.chkFries.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFries.Location = new System.Drawing.Point(495, 348);
            this.chkFries.Name = "chkFries";
            this.chkFries.Size = new System.Drawing.Size(125, 41);
            this.chkFries.TabIndex = 1;
            this.chkFries.Text = "Fries";
            this.chkFries.UseVisualStyleBackColor = true;
            this.chkFries.CheckedChanged += new System.EventHandler(this.chkFries_CheckedChanged);
            // 
            // chkDrink
            // 
            this.chkDrink.AutoSize = true;
            this.chkDrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDrink.Location = new System.Drawing.Point(802, 348);
            this.chkDrink.Name = "chkDrink";
            this.chkDrink.Size = new System.Drawing.Size(129, 41);
            this.chkDrink.TabIndex = 2;
            this.chkDrink.Text = "Drink";
            this.chkDrink.UseVisualStyleBackColor = true;
            this.chkDrink.CheckedChanged += new System.EventHandler(this.chkDrink_CheckedChanged);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.SystemColors.Window;
            this.lblHeader.Font = new System.Drawing.Font("ROG Fonts", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(-44, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(1562, 77);
            this.lblHeader.TabIndex = 3;
            this.lblHeader.Text = "  Bob\'s Burgers                                       ";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(129, 174);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(295, 44);
            this.txtName.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(124, 136);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(228, 25);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "[Enter Name for Order]";
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToOrder.Location = new System.Drawing.Point(703, 797);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(283, 73);
            this.btnAddToOrder.TabIndex = 6;
            this.btnAddToOrder.Text = "Place Order";
            this.btnAddToOrder.UseVisualStyleBackColor = true;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // lstHamburger
            // 
            this.lstHamburger.CheckOnClick = true;
            this.lstHamburger.Enabled = false;
            this.lstHamburger.FormattingEnabled = true;
            this.lstHamburger.Items.AddRange(new object[] {
            "  Cheese",
            "  Pickles",
            "  Onions",
            "  Lettuce",
            "  Tomato",
            "  Ketchup",
            "  Mustard",
            "  Bacon ($1.50 Extra)"});
            this.lstHamburger.Location = new System.Drawing.Point(140, 395);
            this.lstHamburger.Name = "lstHamburger";
            this.lstHamburger.Size = new System.Drawing.Size(248, 256);
            this.lstHamburger.TabIndex = 7;
            this.lstHamburger.Visible = false;
            // 
            // cmbFries
            // 
            this.cmbFries.FormattingEnabled = true;
            this.cmbFries.Items.AddRange(new object[] {
            "Sm   :  $1.00",
            "Med :  $1.50",
            "Lrg   :  $1.75"});
            this.cmbFries.Location = new System.Drawing.Point(495, 395);
            this.cmbFries.Name = "cmbFries";
            this.cmbFries.Size = new System.Drawing.Size(193, 33);
            this.cmbFries.TabIndex = 8;
            this.cmbFries.Text = "Select A Size";
            this.cmbFries.Visible = false;
            // 
            // cmbDrink
            // 
            this.cmbDrink.FormattingEnabled = true;
            this.cmbDrink.Items.AddRange(new object[] {
            "Sm   :  $1.00",
            "Med :  $1.50",
            "Lrg   :  $1.75"});
            this.cmbDrink.Location = new System.Drawing.Point(793, 395);
            this.cmbDrink.Name = "cmbDrink";
            this.cmbDrink.Size = new System.Drawing.Size(193, 33);
            this.cmbDrink.TabIndex = 9;
            this.cmbDrink.Text = "Select a Size";
            this.cmbDrink.Visible = false;
            // 
            // cmbDrink2
            // 
            this.cmbDrink2.FormattingEnabled = true;
            this.cmbDrink2.Items.AddRange(new object[] {
            "Cola",
            "Diet Cola",
            "LemonLime Soda",
            "Mr. Pepper",
            "Sweet Tea",
            "Water (Free)"});
            this.cmbDrink2.Location = new System.Drawing.Point(793, 454);
            this.cmbDrink2.Name = "cmbDrink2";
            this.cmbDrink2.Size = new System.Drawing.Size(193, 33);
            this.cmbDrink2.TabIndex = 10;
            this.cmbDrink2.Text = "Select a Drink";
            this.cmbDrink2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1103, 983);
            this.Controls.Add(this.cmbDrink2);
            this.Controls.Add(this.cmbDrink);
            this.Controls.Add(this.cmbFries);
            this.Controls.Add(this.lstHamburger);
            this.Controls.Add(this.btnAddToOrder);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.chkDrink);
            this.Controls.Add(this.chkFries);
            this.Controls.Add(this.chkHamburger);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkHamburger;
        private System.Windows.Forms.CheckBox chkFries;
        private System.Windows.Forms.CheckBox chkDrink;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.CheckedListBox lstHamburger;
        private System.Windows.Forms.ComboBox cmbFries;
        private System.Windows.Forms.ComboBox cmbDrink;
        private System.Windows.Forms.ComboBox cmbDrink2;
    }
}

