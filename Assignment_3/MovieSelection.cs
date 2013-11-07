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
    public partial class MovieSelection1 : Form
    {
        private bool firstLoad = true; // first load indicator for splashcreen display
        private splash_screen splashScreen;
        private XmlDocument doc = new XmlDocument(); // Variable to store xml document into
        private String[] titleList, descriptionList, imageList, genreList; // String array variables to hold information about each movie
        private Dictionary<string, decimal> costList = new Dictionary<string, decimal> { 
            { "Comedy", 1.99m }, 
            { "Sci-Fi", 2.99m }, 
            { "Drama", 1.99m }, 
            { "Action", 2.99m }, 
            { "Horror", 2.99m }, 
            { "Thriller", 1.99m }, 
            { "Family", 0.99m }, 
            { "New Releases", 4.99m } 
        }; // Dictionary list of movie types and their asociated costs

        public MovieSelection1(splash_screen splashScreen)
        {
            InitializeComponent();           
            this.splashScreen = splashScreen; // pass the splashScreen

            // Load xml data file
            doc.LoadXml(Properties.Resources.moviesList);
            XmlNodeList xList = doc.SelectNodes("/movielist/movie");
            


            titleList = new String[xList.Count]; // set array length to node count
            descriptionList = new String[xList.Count]; // set array length to node count
            imageList = new String[xList.Count]; // set array length to node count
            genreList = new String[xList.Count]; // set array length to node count

            int i = 0; // initialise counter for iterator

            foreach (XmlElement item in xList)// Loop through the array of xml node list
            {
                foreach (XmlElement element in item.ChildNodes) // loop through the child nodes of the xList
                {
                    String value = element.InnerText;
                    String title = element.Name;

                    // Identify data type and assign its value to the appropriate array
                    if (title == "title")
                    {
                        titleList[i] = value;
                    }
                    else if (title == "description")
                    {
                        descriptionList[i] = value;
                    }
                    else if (title == "image")
                    {
                        imageList[i] = value;
                    }
                    else if (title == "genre")
                    {
                        genreList[i] = value;
                    }
                }// end child node loop
                i++;
            }// end xList loop
        }

        /*
         * On loading of the form, set timer for splash screen close and hide this form until splash screen is closed
         */
        private void MovieSelection_Load(object sender, EventArgs e)
        {
            movieList.DataSource = titleList;
            splashTimer.Enabled = true;
        }

        private void movie_selection(object sender, EventArgs e)
        {
            int i = movieList.SelectedIndex; // variable to store the index value of the selected movie
            decimal cost; // variable to store cost

            // Set labels from loaded list index
            moviePicture.Image = Properties.Resources.loader;
            moviePicture.LoadAsync(imageList[i]);            
            movieLabel.Text     = titleList[i];
            categoryLabel.Text  = genreList[i];

            // Get the cost of the movie bassed on the genre from the costList dictionary
            if (costList.TryGetValue(genreList[i], out cost))
            {
                costLabel.Text = cost.ToString("C");
            }
            else
            {
                MessageBox.Show("Error, the movie you have selected has failed to load");
                Application.Exit();
            }
            descriptionBox.Text = descriptionList[i];            
        }

        private void splashTimer_Tick(object sender, EventArgs e)
        {
            // Call splashscreen close command
            this.splashScreen.Close();
            this.Show();
        }

        private void first_run(object sender, EventArgs e)
        {
            if (firstLoad)
            {
                this.Hide();
                this.firstLoad = false;
            }
        }

    }
}
