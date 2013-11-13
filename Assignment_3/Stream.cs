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
        /// On form close, exit entire application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void form_closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Stream_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void show_controls(object sender, EventArgs e)
        {
            backControl.Visible = true;
        }
    }
}
