using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Assignment_3
{
    public partial class MovieSelection : Form
    {
        public MovieSelection()
        {
            InitializeComponent();
        }

        private void MovieSelection_Load(object sender, EventArgs e)
        {
            XmlTextReader reader = new XmlTextReader();
        }
    }
}
