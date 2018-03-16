using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lunch_Order
{
    public partial class formLunchOrder : Form
    {

        public formLunchOrder()
        {
            InitializeComponent();
        }

        //Event that clears the check boxes if a different main course is selected
        private void clearChecked()
        {
            cbAddOn1.Checked = false;
            cbAddOn2.Checked = false;
            cbAddOn3.Checked = false;
            tbSubtotal.Clear();
            tbTax.Clear();
            tbTotal.Clear();
        }

        private void clearTextBoxes(object sender, EventArgs e)
        {
            tbSubtotal.Clear();
            tbTax.Clear();
            tbTotal.Clear();
        }

        //Changes the checkboxes text to hamburger add on choices
        private void hamburgerAddOns(object sender, EventArgs e)
        {
            cbAddOn1.Text = "Lettuce, tomato, and onions";
            cbAddOn2.Text = "Ketchup, mustard, and mayo";
            cbAddOn3.Text = "French fries";
            gbAddOn.Text = "Add on items ($.75/each)";
            clearChecked();
        }

        //Changes the checkboxes text to pizza add on choices
        private void pizzaAddOns(object sender, EventArgs e)
        {
            cbAddOn1.Text = "Pepperoni";
            cbAddOn2.Text = "Sausage";
            cbAddOn3.Text = "Olives";
            gbAddOn.Text = "Add on items ($.50/each)";
            clearChecked();
        }

        //Changes the checkboxes text to salad add on choices
        private void saladAddOns(object sender, EventArgs e)
        {
            cbAddOn1.Text = "Crutons";
            cbAddOn2.Text = "Bacon bits";
            cbAddOn3.Text = "Bread Sticks";
            gbAddOn.Text = "Add on items ($.25/each)";
            clearChecked();
        }

        //Closes the program
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Calculates the order with the subtotal given as an argument. Output goes to corrisponding text boxes
        private void calculateOrder(Decimal subtotal)
        {
            Decimal baseTax = 0.0775m;
            Decimal total;
            Decimal calculateTax;

            calculateTax = subtotal * baseTax;
            total = subtotal + calculateTax;
            tbSubtotal.Text = subtotal.ToString("c");
            tbTax.Text = calculateTax.ToString("c");
            tbTotal.Text = total.ToString("c");
        }

        //Place order even that gets the checked main course and calculates the total
        private void btnOrder_Click(object sender, EventArgs e)
        {
            Decimal subtotal;

            if (rbHamburger.Checked)
            {
                decimal addOnPrice = 0.75m;
                subtotal = 6.95m;

                foreach (Control c in gbAddOn.Controls) //Loops through the group boxes and and adds the add on price for each checked box
                {
                    CheckBox addOn = c as CheckBox;
                    if (addOn.Checked)
                    {
                        subtotal += addOnPrice;
                    }
                }
            } else if (rbPizza.Checked)
            {
                decimal addOnPrice = 0.50m;
                subtotal = 5.95m;

                foreach (Control c in gbAddOn.Controls)
                {
                    CheckBox addOn = c as CheckBox;
                    if (addOn.Checked)
                    {
                        subtotal += addOnPrice;
                    }
                }
            } else
            {
                decimal addOnPrice = 0.25m;
                subtotal = 4.95m;

                foreach (Control c in gbAddOn.Controls)
                {
                    CheckBox addOn = c as CheckBox;
                    if (addOn.Checked)
                    {
                        subtotal += addOnPrice;
                    }
                }
            }

            calculateOrder(subtotal);
        }
    }
}
