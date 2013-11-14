using System;
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
    /// False streaming window
    /// </summary>
    /// <author>Jean-Luc Desroches</author>
    public partial class Stream : Form
    {
        private String title, description, genre;
        private List<String> purchasedMovies;

        /// <summary>
        /// Main Constructor
        /// </summary>
        public Stream()
        {
            InitializeComponent();

            movieBox.Image = Properties.Resources.loader; // display loader gif while stream is 'prepared'
        }
        

        /// <summary>
        /// On form close, exit entire application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void form_closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// On loading of the stream page set the title for the movie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Stream_Load(object sender, EventArgs e)
        {
            titleLabel.Text = title;
        }

        /// <summary>
        /// Shows control interface and movie info on user moving the mouse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void show_controls(object sender, MouseEventArgs e)
        {
            backControl.Visible = true;
            titleBox.Visible = true;
            controlTimer.Enabled = true;
        }

        /// <summary>
        /// Hides the control interface after set interval and disables itself until user moves mouse again
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void controlTimer_Tick(object sender, EventArgs e)
        {
            backControl.Visible = false;
            titleBox.Visible = false;
            controlTimer.Enabled = false;
        }

        /// <summary>
        /// Clicking the back button will close the current application thread and reopen the movie selection form on a seperate thread
        /// This will ensure a clean exit of all current forms and variable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backControl_Click(object sender, EventArgs e)
        {
            System.Threading.ThreadStart main = new System.Threading.ThreadStart(openNewApp);
            System.Threading.Thread sys2 = new System.Threading.Thread(main);
            sys2.Start();
            Application.ExitThread();
        }

        /// <summary>
        /// Open new movie selection
        /// </summary>
        private void openNewApp()
        {
            MovieSelection movieSelection = new MovieSelection();
            movieSelection.setPurchasedMovies(purchasedMovies);
            Application.Run(movieSelection);
        }

        /// <summary>
        /// Initializes the info for the stream
        /// </summary>
        /// <param name="movieInfo"></param>
        /// <param name="purchasedMovies"></param>
        public void initialize(String[] movieInfo, List<String> purchasedMovies)
        {
            this.title = movieInfo[0];
            this.description = movieInfo[1];
            this.genre = movieInfo[2];

            this.purchasedMovies = purchasedMovies;
        }
    }
}
