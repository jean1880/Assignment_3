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
    /// <summary>
    /// This form allows user to select the movie they wish to order
    /// </summary>
    /// <author>Jean-Luc Desroches</author>
    public partial class MovieSelection : Form
    {
        private splash_screen splashScreen; // Splash screen
        private OrderForm orderForm; // Next form
        private List<String> purchasedMovies = new List<string>();
        
        private int prev_movieSelection = -1; // variable to store the previous selected image
        private decimal cost; // variable to store cost

        private XmlDocument doc = new XmlDocument(); // Variable to store xml document into
        private String[] titleList, descriptionList, genreList; // String array variables to hold information about each movie
        private Image[] imageList;
        private Dictionary<string, decimal> costList = new Dictionary<string, decimal> { 
            { "Comedy"      , 1.99m }, 
            { "Sci-Fi"      , 2.99m }, 
            { "Drama"       , 1.99m }, 
            { "Action"      , 2.99m }, 
            { "Horror"      , 2.99m }, 
            { "Thriller"    , 1.99m }, 
            { "Family"      , 0.99m }, 
            { "New Release" , 4.99m } 
        }; // Dictionary list of movie types and their asociated costs

        /// <summary>
        /// Basic Constructor, to be used with no splash screen
        /// </summary>
        public MovieSelection()
        {
            InitializeComponent();

            this.orderForm = new OrderForm();

            loadXML();
        }

        /// <summary>
        /// Main constructor takes the splash screen and next form in construction for preperation of display
        /// </summary>
        /// <param name="splashScreen"></param>
        /// <param name="orderForm"></param>
        public MovieSelection(splash_screen splashScreen, OrderForm orderForm)
        {
            InitializeComponent();           

            this.splashScreen = splashScreen; // pass the splashScreen
            this.orderForm = orderForm; // Pass the next form to the main form

            loadXML();
            
            splashTimer.Enabled = true;
        }
        
        /// <summary>
        /// Loads data from the xml resource file into movie data variables
        /// </summary>
        private void loadXML()
        {
            // Load xml data file
            doc.LoadXml(Properties.Resources.moviesList); // load the xml file intot her doc variable
            XmlNodeList xList = doc.SelectNodes("/movielist/movie"); // Create nodelist of movies from xml file
            titleList = new String[xList.Count]; // set array length to node count
            descriptionList = new String[xList.Count]; // set array length to node count
            imageList = new Image[xList.Count]; // set array length to node count
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
                        imageList[i] = (Image)Properties.Resources.ResourceManager.GetObject(value);
                    }
                    else if (title == "genre")
                    {
                        genreList[i] = value;
                    }
                }// end child node loop
                i++;
            }// end xList loop

            moviePicture.InitialImage = Properties.Resources.loader; // set initial image to loader in the even that system takes a while to display the movie image

            movieList.DataSource = titleList; // load the movie list from the array of movie titles
        }

        /// <summary>
        /// On movie selection update labels and movie image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void movie_selection(object sender, EventArgs e)
        {
            int i = movieList.SelectedIndex; // variable to store the index value of the selected movie
            if (prev_movieSelection != i) // check if reivous photo, do nothing if same photo selected
            {
                // Set labels and image from loaded list index
                movieLabel.Text = titleList[i];
                categoryLabel.Text = genreList[i];
                // Get the cost of the movie bassed on the genre from the costList dictionary
                if (costList.TryGetValue(genreList[i], out this.cost))
                {
                    costLabel.Text = cost.ToString("C");
                }
                else
                {
                    MessageBox.Show("Error, the movie you have selected has failed to load");
                    Application.Exit();
                }
                descriptionBox.Text = descriptionList[i];
                moviePicture.Image = imageList[i];
            }
        }

        /// <summary>
        /// Set the purchased movies list
        /// </summary>
        /// <param name="purchasedMovies">List of movies previously purchased in the form</param>
        public void setPurchasedMovies(List<String> purchasedMovies)
        {
            this.purchasedMovies = purchasedMovies;
        }

        /// <summary>
        /// Ticker to cloase the splash screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void splashTimer_Tick(object sender, EventArgs e)
        {
            splashTimer.Enabled = false;
            // Call splashscreen close command
            this.splashScreen.Close();
            this.Show();            
        }

        /// <summary>
        /// Loads the next form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextButton_Click(object sender, EventArgs e)
        {
            int i = movieList.SelectedIndex; // variable to store the index value of the selected movie
            String[] tempVar = { titleList[i], genreList[i], descriptionList[i] };
            this.Hide();
            orderForm.passForm(this);
            orderForm.passSelection(tempVar, cost, moviePicture.Image);
            if (purchasedMovies != null && purchasedMovies.Count > 0)
            {
                if(purchasedMovies.Contains(titleList[i]))
                {
                    orderForm.setPurchasedMovies(purchasedMovies);
                }
            }
            orderForm.Show();
        }

        /// <summary>
        /// On form close exit the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void form_Closing(object sender, FormClosingEventArgs e)
        {
            cancelToolStripMenuItem_Click(sender, e);
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
        /// Exits the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Prints the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printForm.Print();
        }
    }
}
