namespace project_pizza_ordering
{
    partial class frmMenuOrder
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
            this.grpBoxPizza = new System.Windows.Forms.GroupBox();
            this.txtSupremeQuantity = new System.Windows.Forms.TextBox();
            this.txtCheeseQuantity = new System.Windows.Forms.TextBox();
            this.txtPepQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.chkSupreme = new System.Windows.Forms.CheckBox();
            this.chkCheese = new System.Windows.Forms.CheckBox();
            this.chkPepp = new System.Windows.Forms.CheckBox();
            this.grpSides = new System.Windows.Forms.GroupBox();
            this.txtPastaQuantity = new System.Windows.Forms.TextBox();
            this.txtBreadQuantity = new System.Windows.Forms.TextBox();
            this.lblOrders = new System.Windows.Forms.Label();
            this.chkBread = new System.Windows.Forms.CheckBox();
            this.chkPasta = new System.Windows.Forms.CheckBox();
            this.grpDesserts = new System.Windows.Forms.GroupBox();
            this.txtCookieQuantity = new System.Windows.Forms.TextBox();
            this.txtBrownieQuantity = new System.Windows.Forms.TextBox();
            this.lolOrderDes = new System.Windows.Forms.Label();
            this.chkBrownie = new System.Windows.Forms.CheckBox();
            this.chkCookie = new System.Windows.Forms.CheckBox();
            this.btnPrices = new System.Windows.Forms.Button();
            this.grpDrinks = new System.Windows.Forms.GroupBox();
            this.txt20OzQuantity = new System.Windows.Forms.TextBox();
            this.txtTwoLiterQuantity = new System.Windows.Forms.TextBox();
            this.lblMany = new System.Windows.Forms.Label();
            this.chk2Liter = new System.Windows.Forms.CheckBox();
            this.chkCola20oz = new System.Windows.Forms.CheckBox();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.grpBoxPizza.SuspendLayout();
            this.grpSides.SuspendLayout();
            this.grpDesserts.SuspendLayout();
            this.grpDrinks.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxPizza
            // 
            this.grpBoxPizza.Controls.Add(this.txtSupremeQuantity);
            this.grpBoxPizza.Controls.Add(this.txtCheeseQuantity);
            this.grpBoxPizza.Controls.Add(this.txtPepQuantity);
            this.grpBoxPizza.Controls.Add(this.lblQuantity);
            this.grpBoxPizza.Controls.Add(this.chkSupreme);
            this.grpBoxPizza.Controls.Add(this.chkCheese);
            this.grpBoxPizza.Controls.Add(this.chkPepp);
            this.grpBoxPizza.Location = new System.Drawing.Point(12, 9);
            this.grpBoxPizza.Name = "grpBoxPizza";
            this.grpBoxPizza.Size = new System.Drawing.Size(291, 189);
            this.grpBoxPizza.TabIndex = 1;
            this.grpBoxPizza.TabStop = false;
            this.grpBoxPizza.Text = "Pizza";
            // 
            // txtSupremeQuantity
            // 
            this.txtSupremeQuantity.Enabled = false;
            this.txtSupremeQuantity.Location = new System.Drawing.Point(150, 139);
            this.txtSupremeQuantity.Name = "txtSupremeQuantity";
            this.txtSupremeQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtSupremeQuantity.TabIndex = 9;
            this.txtSupremeQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCheeseQuantity
            // 
            this.txtCheeseQuantity.Enabled = false;
            this.txtCheeseQuantity.Location = new System.Drawing.Point(150, 101);
            this.txtCheeseQuantity.Name = "txtCheeseQuantity";
            this.txtCheeseQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtCheeseQuantity.TabIndex = 8;
            this.txtCheeseQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPepQuantity
            // 
            this.txtPepQuantity.Enabled = false;
            this.txtPepQuantity.Location = new System.Drawing.Point(150, 58);
            this.txtPepQuantity.Name = "txtPepQuantity";
            this.txtPepQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtPepQuantity.TabIndex = 7;
            this.txtPepQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(163, 32);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(63, 13);
            this.lblQuantity.TabIndex = 6;
            this.lblQuantity.Text = "How many?";
            // 
            // chkSupreme
            // 
            this.chkSupreme.AutoSize = true;
            this.chkSupreme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSupreme.Location = new System.Drawing.Point(26, 141);
            this.chkSupreme.Name = "chkSupreme";
            this.chkSupreme.Size = new System.Drawing.Size(75, 17);
            this.chkSupreme.TabIndex = 5;
            this.chkSupreme.Text = "Supreme";
            this.chkSupreme.UseVisualStyleBackColor = true;
            this.chkSupreme.CheckedChanged += new System.EventHandler(this.chkSupreme_CheckedChanged);
            // 
            // chkCheese
            // 
            this.chkCheese.AutoSize = true;
            this.chkCheese.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCheese.Location = new System.Drawing.Point(26, 103);
            this.chkCheese.Name = "chkCheese";
            this.chkCheese.Size = new System.Drawing.Size(67, 17);
            this.chkCheese.TabIndex = 4;
            this.chkCheese.Text = "cheese";
            this.chkCheese.UseVisualStyleBackColor = true;
            this.chkCheese.CheckedChanged += new System.EventHandler(this.chkCheese_CheckedChanged);
            // 
            // chkPepp
            // 
            this.chkPepp.AutoSize = true;
            this.chkPepp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPepp.Location = new System.Drawing.Point(26, 60);
            this.chkPepp.Name = "chkPepp";
            this.chkPepp.Size = new System.Drawing.Size(83, 17);
            this.chkPepp.TabIndex = 3;
            this.chkPepp.Text = "Pepperoni";
            this.chkPepp.UseVisualStyleBackColor = true;
            this.chkPepp.CheckedChanged += new System.EventHandler(this.chkPepp_CheckedChanged);
            // 
            // grpSides
            // 
            this.grpSides.Controls.Add(this.txtPastaQuantity);
            this.grpSides.Controls.Add(this.txtBreadQuantity);
            this.grpSides.Controls.Add(this.lblOrders);
            this.grpSides.Controls.Add(this.chkBread);
            this.grpSides.Controls.Add(this.chkPasta);
            this.grpSides.Location = new System.Drawing.Point(334, 12);
            this.grpSides.Name = "grpSides";
            this.grpSides.Size = new System.Drawing.Size(293, 189);
            this.grpSides.TabIndex = 2;
            this.grpSides.TabStop = false;
            this.grpSides.Text = "Sides";
            // 
            // txtPastaQuantity
            // 
            this.txtPastaQuantity.Enabled = false;
            this.txtPastaQuantity.Location = new System.Drawing.Point(165, 127);
            this.txtPastaQuantity.Name = "txtPastaQuantity";
            this.txtPastaQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtPastaQuantity.TabIndex = 13;
            // 
            // txtBreadQuantity
            // 
            this.txtBreadQuantity.Enabled = false;
            this.txtBreadQuantity.Location = new System.Drawing.Point(165, 69);
            this.txtBreadQuantity.Name = "txtBreadQuantity";
            this.txtBreadQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtBreadQuantity.TabIndex = 12;
            // 
            // lblOrders
            // 
            this.lblOrders.AutoSize = true;
            this.lblOrders.Location = new System.Drawing.Point(170, 32);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(95, 13);
            this.lblOrders.TabIndex = 10;
            this.lblOrders.Text = "How many orders?";
            // 
            // chkBread
            // 
            this.chkBread.AutoSize = true;
            this.chkBread.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBread.Location = new System.Drawing.Point(20, 72);
            this.chkBread.Name = "chkBread";
            this.chkBread.Size = new System.Drawing.Size(131, 17);
            this.chkBread.TabIndex = 10;
            this.chkBread.Text = "Breadsticks (6pcs)";
            this.chkBread.UseVisualStyleBackColor = true;
            this.chkBread.CheckedChanged += new System.EventHandler(this.chkBread_CheckedChanged);
            // 
            // chkPasta
            // 
            this.chkPasta.AutoSize = true;
            this.chkPasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPasta.Location = new System.Drawing.Point(20, 129);
            this.chkPasta.Name = "chkPasta";
            this.chkPasta.Size = new System.Drawing.Size(128, 17);
            this.chkPasta.TabIndex = 11;
            this.chkPasta.Text = "Pasta (24oz Bowl)";
            this.chkPasta.UseVisualStyleBackColor = true;
            this.chkPasta.CheckedChanged += new System.EventHandler(this.chkPasta_CheckedChanged);
            // 
            // grpDesserts
            // 
            this.grpDesserts.Controls.Add(this.txtCookieQuantity);
            this.grpDesserts.Controls.Add(this.txtBrownieQuantity);
            this.grpDesserts.Controls.Add(this.lolOrderDes);
            this.grpDesserts.Controls.Add(this.chkBrownie);
            this.grpDesserts.Controls.Add(this.chkCookie);
            this.grpDesserts.Location = new System.Drawing.Point(12, 211);
            this.grpDesserts.Name = "grpDesserts";
            this.grpDesserts.Size = new System.Drawing.Size(293, 154);
            this.grpDesserts.TabIndex = 14;
            this.grpDesserts.TabStop = false;
            this.grpDesserts.Text = "Desserts";
            // 
            // txtCookieQuantity
            // 
            this.txtCookieQuantity.Enabled = false;
            this.txtCookieQuantity.Location = new System.Drawing.Point(165, 99);
            this.txtCookieQuantity.Name = "txtCookieQuantity";
            this.txtCookieQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtCookieQuantity.TabIndex = 13;
            // 
            // txtBrownieQuantity
            // 
            this.txtBrownieQuantity.Enabled = false;
            this.txtBrownieQuantity.Location = new System.Drawing.Point(165, 55);
            this.txtBrownieQuantity.Name = "txtBrownieQuantity";
            this.txtBrownieQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtBrownieQuantity.TabIndex = 12;
            // 
            // lolOrderDes
            // 
            this.lolOrderDes.AutoSize = true;
            this.lolOrderDes.Location = new System.Drawing.Point(170, 32);
            this.lolOrderDes.Name = "lolOrderDes";
            this.lolOrderDes.Size = new System.Drawing.Size(95, 13);
            this.lolOrderDes.TabIndex = 10;
            this.lolOrderDes.Text = "How many orders?";
            // 
            // chkBrownie
            // 
            this.chkBrownie.AutoSize = true;
            this.chkBrownie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBrownie.Location = new System.Drawing.Point(20, 58);
            this.chkBrownie.Name = "chkBrownie";
            this.chkBrownie.Size = new System.Drawing.Size(116, 17);
            this.chkBrownie.TabIndex = 10;
            this.chkBrownie.Text = "Brownies (6pcs)";
            this.chkBrownie.UseVisualStyleBackColor = true;
            this.chkBrownie.CheckedChanged += new System.EventHandler(this.chkBrownie_CheckedChanged);
            // 
            // chkCookie
            // 
            this.chkCookie.AutoSize = true;
            this.chkCookie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCookie.Location = new System.Drawing.Point(20, 101);
            this.chkCookie.Name = "chkCookie";
            this.chkCookie.Size = new System.Drawing.Size(125, 17);
            this.chkCookie.TabIndex = 11;
            this.chkCookie.Text = "Oversized Cookie";
            this.chkCookie.UseVisualStyleBackColor = true;
            this.chkCookie.CheckedChanged += new System.EventHandler(this.chkCookie_CheckedChanged);
            // 
            // btnPrices
            // 
            this.btnPrices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrices.Location = new System.Drawing.Point(12, 371);
            this.btnPrices.Name = "btnPrices";
            this.btnPrices.Size = new System.Drawing.Size(167, 34);
            this.btnPrices.TabIndex = 14;
            this.btnPrices.Text = "&Click here for Prices!";
            this.btnPrices.UseVisualStyleBackColor = true;
            this.btnPrices.Click += new System.EventHandler(this.btnPrices_Click);
            // 
            // grpDrinks
            // 
            this.grpDrinks.Controls.Add(this.txt20OzQuantity);
            this.grpDrinks.Controls.Add(this.txtTwoLiterQuantity);
            this.grpDrinks.Controls.Add(this.lblMany);
            this.grpDrinks.Controls.Add(this.chk2Liter);
            this.grpDrinks.Controls.Add(this.chkCola20oz);
            this.grpDrinks.Location = new System.Drawing.Point(334, 211);
            this.grpDrinks.Name = "grpDrinks";
            this.grpDrinks.Size = new System.Drawing.Size(293, 154);
            this.grpDrinks.TabIndex = 16;
            this.grpDrinks.TabStop = false;
            this.grpDrinks.Text = "Drinks";
            // 
            // txt20OzQuantity
            // 
            this.txt20OzQuantity.Enabled = false;
            this.txt20OzQuantity.Location = new System.Drawing.Point(165, 99);
            this.txt20OzQuantity.Name = "txt20OzQuantity";
            this.txt20OzQuantity.Size = new System.Drawing.Size(100, 20);
            this.txt20OzQuantity.TabIndex = 13;
            // 
            // txtTwoLiterQuantity
            // 
            this.txtTwoLiterQuantity.Enabled = false;
            this.txtTwoLiterQuantity.Location = new System.Drawing.Point(165, 55);
            this.txtTwoLiterQuantity.Name = "txtTwoLiterQuantity";
            this.txtTwoLiterQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtTwoLiterQuantity.TabIndex = 12;
            // 
            // lblMany
            // 
            this.lblMany.AutoSize = true;
            this.lblMany.Location = new System.Drawing.Point(170, 32);
            this.lblMany.Name = "lblMany";
            this.lblMany.Size = new System.Drawing.Size(63, 13);
            this.lblMany.TabIndex = 10;
            this.lblMany.Text = "How many?";
            // 
            // chk2Liter
            // 
            this.chk2Liter.AutoSize = true;
            this.chk2Liter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk2Liter.Location = new System.Drawing.Point(20, 58);
            this.chk2Liter.Name = "chk2Liter";
            this.chk2Liter.Size = new System.Drawing.Size(99, 17);
            this.chk2Liter.TabIndex = 10;
            this.chk2Liter.Text = "Cola (2 Liter)";
            this.chk2Liter.UseVisualStyleBackColor = true;
            this.chk2Liter.CheckedChanged += new System.EventHandler(this.chk2Liter_CheckedChanged);
            // 
            // chkCola20oz
            // 
            this.chkCola20oz.AutoSize = true;
            this.chkCola20oz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCola20oz.Location = new System.Drawing.Point(20, 101);
            this.chkCola20oz.Name = "chkCola20oz";
            this.chkCola20oz.Size = new System.Drawing.Size(126, 17);
            this.chkCola20oz.TabIndex = 11;
            this.chkCola20oz.Text = "Cola (20oz bottle)";
            this.chkCola20oz.UseVisualStyleBackColor = true;
            this.chkCola20oz.CheckedChanged += new System.EventHandler(this.chkCola20oz_CheckedChanged);
            // 
            // btnCheckout
            // 
            this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.Location = new System.Drawing.Point(460, 371);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(167, 34);
            this.btnCheckout.TabIndex = 17;
            this.btnCheckout.Text = "&Proceed to Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // frmMenuOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 413);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.grpDrinks);
            this.Controls.Add(this.btnPrices);
            this.Controls.Add(this.grpDesserts);
            this.Controls.Add(this.grpSides);
            this.Controls.Add(this.grpBoxPizza);
            this.Name = "frmMenuOrder";
            this.Text = "Menu";
            this.grpBoxPizza.ResumeLayout(false);
            this.grpBoxPizza.PerformLayout();
            this.grpSides.ResumeLayout(false);
            this.grpSides.PerformLayout();
            this.grpDesserts.ResumeLayout(false);
            this.grpDesserts.PerformLayout();
            this.grpDrinks.ResumeLayout(false);
            this.grpDrinks.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpBoxPizza;
        private System.Windows.Forms.TextBox txtSupremeQuantity;
        private System.Windows.Forms.TextBox txtCheeseQuantity;
        private System.Windows.Forms.TextBox txtPepQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.CheckBox chkSupreme;
        private System.Windows.Forms.CheckBox chkCheese;
        private System.Windows.Forms.CheckBox chkPepp;
        private System.Windows.Forms.GroupBox grpSides;
        private System.Windows.Forms.TextBox txtPastaQuantity;
        private System.Windows.Forms.TextBox txtBreadQuantity;
        private System.Windows.Forms.Label lblOrders;
        private System.Windows.Forms.CheckBox chkBread;
        private System.Windows.Forms.CheckBox chkPasta;
        private System.Windows.Forms.GroupBox grpDesserts;
        private System.Windows.Forms.TextBox txtCookieQuantity;
        private System.Windows.Forms.TextBox txtBrownieQuantity;
        private System.Windows.Forms.Label lolOrderDes;
        private System.Windows.Forms.CheckBox chkBrownie;
        private System.Windows.Forms.CheckBox chkCookie;
        private System.Windows.Forms.Button btnPrices;
        private System.Windows.Forms.GroupBox grpDrinks;
        private System.Windows.Forms.TextBox txt20OzQuantity;
        private System.Windows.Forms.TextBox txtTwoLiterQuantity;
        private System.Windows.Forms.Label lblMany;
        private System.Windows.Forms.CheckBox chk2Liter;
        private System.Windows.Forms.CheckBox chkCola20oz;
        private System.Windows.Forms.Button btnCheckout;
    }
}