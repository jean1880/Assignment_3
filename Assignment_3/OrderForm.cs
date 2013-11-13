﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3
{
    /// <summary>
    /// Displays users choice and the cost for the movie that they have selected
    /// </summary>
    /// <author>Jean-Luc Desroches</author>
    public partial class OrderForm : Form
    {
        private List<String> purchasedMovies = new List<string>();
        private MovieSelection movieForm;
        private Stream movieStream = new Stream();
        private paymentForm payment_form = new paymentForm();
        private string title, genre, description;
        private decimal cost, total;
        private static decimal TAX_MULTIPLIER = 0.13m;
        private Image image;

        /// <summary>
        /// Main constructor
        /// </summary>
        public OrderForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Create order form with purchased movies list
        /// </summary>
        /// <param name="purchasedMovies"></param>
        public OrderForm(List<String> purchasedMovies)
        {
            InitializeComponent();
            this.purchasedMovies = purchasedMovies;
        }

        /// <summary>
        /// Recreate a purchase form
        /// </summary>
        public void CreatePurchaseForm()
        {
            payment_form = new paymentForm();
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="movieSelection"></param>
        public void passForm(MovieSelection movieSelection)
        {
            this.movieForm = movieSelection;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="title"></param>
        /// <param name="genre"></param>
        /// <param name="cost"></param>
        /// <param name="description"></param>
        /// <param name="image"></param>
        public void passSelection(String[] tempVar, decimal cost, Image image)
        {
            decimal taxTotal; // Variable to store calculated tax

            // Set variables
            this.title = tempVar[0];
            this.genre = tempVar[1];
            this.description = tempVar[2];
            this.cost = cost;
            this.image = image;

            taxTotal = cost * TAX_MULTIPLIER; // calculate tax
            this.total = cost + taxTotal; // calculate total

            // Set displays to the user
            moviePicture.Image  = image;
            movieLabel.Text     = this.title;
            categoryLabel.Text  = this.genre;
            costLabel.Text      = this.cost.ToString("C");
            descriptionBox.Text = this.description;
            GSTOutputLabel.Text = (taxTotal).ToString("C");
            totalBox.Text       = (this.total).ToString("C");
        }

        /// <summary>
        /// Opens previous form and hides this form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            movieForm.Show();
        }

        /// <summary>
        /// On form closing exit entire application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void form_closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Opens next form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            payment_form.passForm(this);
            payment_form.Show();
        }

        /// <summary>
        /// opens movie stream if payment was succesful
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void check_Payment(object sender, EventArgs e)
        {
            if (payment_form.checkSuccess())
            {
                CreatePurchaseForm();
                purchasedMovies.Add(this.title);
                streamButton.Enabled = true;        
            }
            else if (checkMoviePurchased())
            {
                streamButton.Enabled = true;
            }
            else
            {
                streamButton.Enabled = false;   
            }
        }

        /// <summary>
        /// Opens the about form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutForm = new About(); // About Form
            aboutForm.ShowDialog();
        }

        /// <summary>
        /// Open Streaming with selected movie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void streamButton_Click(object sender, EventArgs e)
        {
            movieStream.initialize(new String[] { title, description, genre }, purchasedMovies);
            movieStream.Show();
            this.Hide();
        }

        public void setPurchasedMovies(List<String> purchasedMovies)
        {
            this.purchasedMovies = purchasedMovies;
        }

        private Boolean checkMoviePurchased()
        {
            if (purchasedMovies != null && purchasedMovies.Contains(title))
            {
                return true;
            }
            return false;
        }
    }
}