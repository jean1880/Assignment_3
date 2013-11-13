using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Assignment_3
{
    /// <summary>
    /// Collects credit card information from the user and ensures it is valid
    /// Credit card regular expressions from http://www.regular-expressions.info/creditcard.html
    /// </summary>
    /// <Author>Jean-Luc Desroches</Author>
    public partial class paymentForm : Form
    {
        private OrderForm prevForm; // variable stores previous form
        private String creditRegExp; // variable to store credit card regular expression
        private Boolean success; // form succes variable

        private String[] paymentList = new String[3]{
            "Visa",
            "Master Card",
            "American Express"
        }; // payment options

        /// <summary>
        /// Main constructor
        /// </summary>
        public paymentForm()
        {
            InitializeComponent();

            // set form settings
            paymentComboBox.DataSource = paymentList;
            expiryDate.CustomFormat = "MM/yy";
            expiryDate.Format = DateTimePickerFormat.Custom;
        }

        /// <summary>
        /// As form is closed show previous form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void form_closing(object sender, FormClosingEventArgs e)
        {
            cancel_click(sender, e);
        }

        /// <summary>
        /// This method stores the form that called this form so that it can be reopened on completion
        /// </summary>
        /// <param name="prevForm">Variable to store the form that called this form</param>
        public void passForm(OrderForm prevForm)
        {
            this.prevForm = prevForm;
        }

        /// <summary>
        /// Check whether credit card processing was succesful
        /// </summary>
        /// <returns>success variable</returns>
        public Boolean checkSuccess()
        {
            return success;
        }

        /// <summary>
        /// Checks that credit information provided is valid, if it passes opens the previous form, and sets succes variable to true
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submitButton_Click(object sender, EventArgs e)
        {
            int verificationTmp;
            if (fNameBox.Text != "" && lNameBox.Text != "" && cardNumBox.Text != "" && CCVBox.Text != "") // ensure all fields are filled out on the form
            {
                if (Regex.IsMatch(cardNumBox.Text, creditRegExp)) // verify the credit card from the regex method for the chosen credit type
                {
                    if (expiryDate.Value > DateTime.Now) // verify card is not expired
                    {
                        if (CCVBox.Text.Length == 3 && int.TryParse(CCVBox.Text, out verificationTmp))
                        {
                            this.success = true;
                            this.Hide();
                            prevForm.Show();
                            MessageBox.Show("Payment processed successfully, enjoy your movie!", "Payment Success");
                        }
                        else
                        {
                            MessageBox.Show("CCV number is invalid", "Error"); // output error to user
                        }
                    }
                    else
                    {
                        MessageBox.Show("Credit Card is expired", "Error"); // output error to user
                    }// end expiry check
                }
                else
                {
                    MessageBox.Show("Credit Card is not Valid", "Error"); // output error to user
                }// end credit verification
            }
            else
            {
                MessageBox.Show("Please fill in all fields on the form", "Error"); // output error to user
            }// end field verification
        }

        /// <summary>
        /// When payment option is chosen update the payment type picture, and the regular expression for theat type
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void paymentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (paymentComboBox.SelectedItem.ToString() == "Visa")
            {
                paymentPicture.Image = Properties.Resources.visa_logo;
                creditRegExp = "^4[0-9]{12}(?:[0-9]{3})?$";
            }
            else if (paymentComboBox.SelectedItem.ToString() == "Master Card")
            {
                paymentPicture.Image = Properties.Resources.mastercard;
                creditRegExp = "^5[1-5][0-9]{14}$";
            }
            else if (paymentComboBox.SelectedItem.ToString() == "American Express")
            {
                paymentPicture.Image = Properties.Resources.americanexpress;
                creditRegExp = "^3[47][0-9]{13}$";
            }            
        }

        private void cancel_click(object sender, EventArgs e)
        {
            prevForm.Show();
            prevForm.CreatePurchaseForm();
        }
    }

}
