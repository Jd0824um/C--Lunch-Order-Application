namespace Lunch_Order
{
    partial class formLunchOrder
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
            this.gbMainCourse = new System.Windows.Forms.GroupBox();
            this.rbSalad = new System.Windows.Forms.RadioButton();
            this.rbPizza = new System.Windows.Forms.RadioButton();
            this.rbHamburger = new System.Windows.Forms.RadioButton();
            this.gbOrderTotal = new System.Windows.Forms.GroupBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.tbTax = new System.Windows.Forms.TextBox();
            this.tbSubtotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.gbAddOn = new System.Windows.Forms.GroupBox();
            this.cbAddOn3 = new System.Windows.Forms.CheckBox();
            this.cbAddOn2 = new System.Windows.Forms.CheckBox();
            this.cbAddOn1 = new System.Windows.Forms.CheckBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbMainCourse.SuspendLayout();
            this.gbOrderTotal.SuspendLayout();
            this.gbAddOn.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMainCourse
            // 
            this.gbMainCourse.Controls.Add(this.rbSalad);
            this.gbMainCourse.Controls.Add(this.rbPizza);
            this.gbMainCourse.Controls.Add(this.rbHamburger);
            this.gbMainCourse.Location = new System.Drawing.Point(18, 25);
            this.gbMainCourse.Name = "gbMainCourse";
            this.gbMainCourse.Size = new System.Drawing.Size(136, 106);
            this.gbMainCourse.TabIndex = 0;
            this.gbMainCourse.TabStop = false;
            this.gbMainCourse.Text = "Main Course";
            // 
            // rbSalad
            // 
            this.rbSalad.AutoSize = true;
            this.rbSalad.Location = new System.Drawing.Point(7, 67);
            this.rbSalad.Name = "rbSalad";
            this.rbSalad.Size = new System.Drawing.Size(88, 17);
            this.rbSalad.TabIndex = 2;
            this.rbSalad.TabStop = true;
            this.rbSalad.Text = "Salad - $4.95";
            this.rbSalad.UseVisualStyleBackColor = true;
            this.rbSalad.Click += new System.EventHandler(this.saladAddOns);
            // 
            // rbPizza
            // 
            this.rbPizza.AutoSize = true;
            this.rbPizza.Location = new System.Drawing.Point(7, 44);
            this.rbPizza.Name = "rbPizza";
            this.rbPizza.Size = new System.Drawing.Size(86, 17);
            this.rbPizza.TabIndex = 1;
            this.rbPizza.TabStop = true;
            this.rbPizza.Text = "Pizza - $5.95";
            this.rbPizza.UseVisualStyleBackColor = true;
            this.rbPizza.Click += new System.EventHandler(this.pizzaAddOns);
            // 
            // rbHamburger
            // 
            this.rbHamburger.AutoSize = true;
            this.rbHamburger.Location = new System.Drawing.Point(7, 20);
            this.rbHamburger.Name = "rbHamburger";
            this.rbHamburger.Size = new System.Drawing.Size(113, 17);
            this.rbHamburger.TabIndex = 0;
            this.rbHamburger.TabStop = true;
            this.rbHamburger.Text = "Hamburger - $6.95";
            this.rbHamburger.UseVisualStyleBackColor = true;
            this.rbHamburger.Click += new System.EventHandler(this.hamburgerAddOns);
            // 
            // gbOrderTotal
            // 
            this.gbOrderTotal.Controls.Add(this.tbTotal);
            this.gbOrderTotal.Controls.Add(this.tbTax);
            this.gbOrderTotal.Controls.Add(this.tbSubtotal);
            this.gbOrderTotal.Controls.Add(this.lblTotal);
            this.gbOrderTotal.Controls.Add(this.lblTax);
            this.gbOrderTotal.Controls.Add(this.lblSubtotal);
            this.gbOrderTotal.Location = new System.Drawing.Point(18, 151);
            this.gbOrderTotal.Name = "gbOrderTotal";
            this.gbOrderTotal.Size = new System.Drawing.Size(199, 98);
            this.gbOrderTotal.TabIndex = 1;
            this.gbOrderTotal.TabStop = false;
            this.gbOrderTotal.Text = "Order Total";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(74, 69);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(100, 20);
            this.tbTotal.TabIndex = 3;
            // 
            // tbTax
            // 
            this.tbTax.Location = new System.Drawing.Point(74, 43);
            this.tbTax.Name = "tbTax";
            this.tbTax.ReadOnly = true;
            this.tbTax.Size = new System.Drawing.Size(100, 20);
            this.tbTax.TabIndex = 2;
            // 
            // tbSubtotal
            // 
            this.tbSubtotal.Location = new System.Drawing.Point(74, 17);
            this.tbSubtotal.Name = "tbSubtotal";
            this.tbSubtotal.ReadOnly = true;
            this.tbSubtotal.Size = new System.Drawing.Size(100, 20);
            this.tbSubtotal.TabIndex = 1;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(4, 76);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(63, 13);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Order Total:";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(4, 50);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(66, 13);
            this.lblTax.TabIndex = 1;
            this.lblTax.Text = "Tax (7.75%):";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(6, 24);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(49, 13);
            this.lblSubtotal.TabIndex = 0;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // gbAddOn
            // 
            this.gbAddOn.Controls.Add(this.cbAddOn3);
            this.gbAddOn.Controls.Add(this.cbAddOn2);
            this.gbAddOn.Controls.Add(this.cbAddOn1);
            this.gbAddOn.Location = new System.Drawing.Point(160, 28);
            this.gbAddOn.Name = "gbAddOn";
            this.gbAddOn.Size = new System.Drawing.Size(165, 103);
            this.gbAddOn.TabIndex = 2;
            this.gbAddOn.TabStop = false;
            this.gbAddOn.Text = "Add on Items ($.75/each)";
            // 
            // cbAddOn3
            // 
            this.cbAddOn3.AutoSize = true;
            this.cbAddOn3.Location = new System.Drawing.Point(7, 65);
            this.cbAddOn3.Name = "cbAddOn3";
            this.cbAddOn3.Size = new System.Drawing.Size(81, 17);
            this.cbAddOn3.TabIndex = 2;
            this.cbAddOn3.Text = "French fries";
            this.cbAddOn3.UseVisualStyleBackColor = true;
            this.cbAddOn3.Click += new System.EventHandler(this.clearTextBoxes);
            // 
            // cbAddOn2
            // 
            this.cbAddOn2.AutoSize = true;
            this.cbAddOn2.Location = new System.Drawing.Point(7, 41);
            this.cbAddOn2.Name = "cbAddOn2";
            this.cbAddOn2.Size = new System.Drawing.Size(158, 17);
            this.cbAddOn2.TabIndex = 1;
            this.cbAddOn2.Text = "Kechup, mustard, and mayo";
            this.cbAddOn2.UseVisualStyleBackColor = true;
            this.cbAddOn2.Click += new System.EventHandler(this.clearTextBoxes);
            // 
            // cbAddOn1
            // 
            this.cbAddOn1.AutoSize = true;
            this.cbAddOn1.Location = new System.Drawing.Point(7, 17);
            this.cbAddOn1.Name = "cbAddOn1";
            this.cbAddOn1.Size = new System.Drawing.Size(158, 17);
            this.cbAddOn1.TabIndex = 0;
            this.cbAddOn1.Text = "Lettuce, tomato, and onions";
            this.cbAddOn1.UseVisualStyleBackColor = true;
            this.cbAddOn1.Click += new System.EventHandler(this.clearTextBoxes);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(231, 151);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 1;
            this.btnOrder.Text = "Place Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(231, 217);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // formLunchOrder
            // 
            this.AcceptButton = this.btnOrder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(337, 261);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.gbAddOn);
            this.Controls.Add(this.gbOrderTotal);
            this.Controls.Add(this.gbMainCourse);
            this.Name = "formLunchOrder";
            this.Text = "Lunch Order";
            this.gbMainCourse.ResumeLayout(false);
            this.gbMainCourse.PerformLayout();
            this.gbOrderTotal.ResumeLayout(false);
            this.gbOrderTotal.PerformLayout();
            this.gbAddOn.ResumeLayout(false);
            this.gbAddOn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMainCourse;
        private System.Windows.Forms.RadioButton rbSalad;
        private System.Windows.Forms.RadioButton rbPizza;
        private System.Windows.Forms.RadioButton rbHamburger;
        private System.Windows.Forms.GroupBox gbOrderTotal;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.TextBox tbTax;
        private System.Windows.Forms.TextBox tbSubtotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.GroupBox gbAddOn;
        private System.Windows.Forms.CheckBox cbAddOn3;
        private System.Windows.Forms.CheckBox cbAddOn2;
        private System.Windows.Forms.CheckBox cbAddOn1;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnExit;
    }
}

