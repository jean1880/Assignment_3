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
        /// <summary>
        /// Main Constructor
        /// </summary>
        public Stream()
        {
            InitializeComponent();

            movieBox.Image = Properties.Resources.loader; /// display loader gif while stream is 'prepared'
        }
        
        /// <summary>
        ///  output success message to the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void success_Output(object sender, EventArgs e)
        {
            MessageBox.Show("Payment processed successfully, enjoy your movie!", "Payment Success");
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
    }
}
