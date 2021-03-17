using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Data.OleDb;
//Team: Keerthi Kiran, Lieth Shehadeh, Angelo Osama, Francesca Avancena
//Date: May 29 - June 12
//Cpt: MyMoviesList
//Purpose: Provides netflix users a space to create personal watchlists, rate, sort and discover movies.
namespace CPTWinformCrawling
{
    public partial class frmWebcrawl : Form
    {
        //Constructors
        private OleDbConnection connection = new OleDbConnection();
        //Variables
        int Watched1 = 0;//var for storing the number of movies in array of watched movies
        int Watched2 = 0; //var for storing the number of movies in array of plan to watch movies
        List<string> result = new List<string>();//list for the names of the movies that are watched
        List<string> result1 = new List<string>();//list for the names of the movies that are plan to watch
        public class MovieInformation
        {
            //class used in a list inorder to store movie info
            public string Title = "";
            public string Duration = "";
            public string Rating = "";
            public string ImgUrl = "";
            public string Year = "";
            public int Position;
        }

        public static class NetflixHtml
        {
            //holds mic variables
            public static bool Signedin = false;
            public static Point Test;
            public static string Html;
        }

        public frmWebcrawl()
        {
            InitializeComponent();
            //default screen is netflix website for login
            openNetflixGUI();

            //ConnectionString of Database 
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MoviesList.accdb;Persist Security Info=False";
        }
        //just a public list of movie information class
        public List<frmWebcrawl.MovieInformation> MovieList = new List<frmWebcrawl.MovieInformation>();
        //creates an array of movieitem
        public MovieItem[] MovieContainer;


        //runs when a page is done loading
        void BadNavigating(object sender, WebBrowserNavigatedEventArgs e)
        {
            //incase any connection errors occur
            try
            {
                if (NetflixHtml.Signedin)
                {
                    //restricts navigation by looking at urls
                    if (webCrawling.Url.ToString() == "https://www.netflix.com/browse/genre/34399")
                    {
                        openMainMenu();
                        movieCollection();
                    }
                    else if (webCrawling.Url.ToString() == "https://www.netflix.com/ca/logout")
                    {
                        //checks if they wanna logout and resests things
                        NetflixHtml.Signedin = false;
                        openNetflixGUI();
                        webCrawling.Navigate("https://www.netflix.com/ca/Login");
                    }
                    else if (webCrawling.Url.ToString() != "https://www.netflix.com/browse/genre/34399" && webCrawling.Url.ToString() != "https://www.netflix.com/ProfilesGate")
                    {
                        webCrawling.Navigate("https://www.netflix.com/browse/genre/34399");
                    }
                    else if (webCrawling.Url.ToString() == "https://www.netflix.com/ca/Login")
                    {
                        //backup check logout
                        NetflixHtml.Signedin = false;
                        webCrawling.Navigate("https://www.netflix.com/ca/Login");
                    }
                }
                else
                {
                    //checks if they logged in
                    if (webCrawling.Url.ToString() == "https://www.netflix.com/browse")
                    {
                        NetflixHtml.Signedin = true;
                        openMainMenu();
                        webCrawling.Navigate("https://www.netflix.com/browse/genre/34399");
                    }
                    else if (webCrawling.Url.ToString() == "https://www.netflix.com/browse/genre/34399")
                    {
                        NetflixHtml.Signedin = true;
                        openMainMenu();
                        webCrawling.Navigate("https://www.netflix.com/browse/genre/34399");
                    }
                    else if (webCrawling.Url.ToString() != "https://www.netflix.com/ca/Login")
                    {
                        //if not then make sure they stay at the login page
                        webCrawling.Navigate("https://www.netflix.com/ca/Login");
                        openNetflixGUI();
                    }
                }
                //remove movie containers that are already watched 
                Lists.ArrWatched = new int[MovieList.Count()];//arr for storing the movie container number for watched 
                Lists.ArrPlantoWatch = new int[MovieList.Count()];//arr for storing the movie container number for plan to watch 
                for (int i = 0; i < MovieList.Count; i++)//make all the values equal to -1 cuz if nothing is inputed it will be 0 but there is a movie container at 0 
                {
                    Lists.ArrWatched[i] = -1;
                    Lists.ArrPlantoWatch[i] = -1;
                }
                //Watched
                for (int i = 0; i < Lists.ArrW1.Length; i++)
                {
                    for (int k = 0; k < MovieList.Count; k++)
                    {
                        if (MovieList[k].Title.ToLower().Contains(Lists.ArrW1[i].ToLower()))//checks with all movie container if they have the title in the arr with data from the database
                        {
                            flwMovies.Controls.Remove(MovieContainer[k]);
                            Lists.ArrWatched[Watched1] = k;
                            Watched1++;
                            break;
                        }
                    }
                }

                //Plan to Watch
                for (int i = 0; i < Lists.ArrP1.Length; i++)
                {
                    for (int k = 0; k < MovieList.Count; k++)
                    {
                        if (MovieList[k].Title.ToLower().Contains(Lists.ArrP1[i].ToLower()))
                        {
                            Lists.ArrPlantoWatch[Watched2] = k;
                            Watched2++;
                        }
                    }
                }
            }
            catch
            {
                //tells user that there is a network error and closes app
                MessageBox.Show("There seems to be a connection problem, this problem maybe be from you or Netflix.\r\nPlease try again Later", "Connection Error");
                Application.Exit();
            }
        }

        private void btnNetflixGUI_Click(object sender, EventArgs e)
        {
            if (NetflixHtml.Signedin)
            {
                //if signed in it runs the method that opens the right gui
                if (panelWebHolder.Visible == false)
                {
                    openNetflixGUI();
                }
                else
                {
                    openMainMenu();
                }
            }
            else
            {
                MessageBox.Show("Please Sign in first!", "Permission Required");
            }
        }

        public void openMainMenu()
        {
            //opens main menu
            btnNetflixGUI.Text = "Open Netflix GUI";
            panelWebHolder.Visible = false;
            panelWebHolder.Dock = DockStyle.Bottom;
            panelWebHolder.Size = new Size(panelWebHolder.Width, 0);
            panelMainMenu.Dock = DockStyle.Fill;
            panelMainMenu.Visible = true;
        }

        public void openNetflixGUI()
        {
            btnNetflixGUI.Text = "Close Netflix GUI";
            panelMainMenu.Visible = false;
            panelMainMenu.Dock = DockStyle.Top;
            panelMainMenu.Size = new Size(panelMainMenu.Width, 0);
            panelWebHolder.Dock = DockStyle.Fill;
            panelWebHolder.Visible = true;
        }


        private void frmWebcrawl_Load(object sender, EventArgs e)
        {
            //stores info from database from previous use
            Lists.ArrW1 = new string[MovieList.Count()];
            Lists.ArrP1 = new string[MovieList.Count()];
            //data from last use
            connection.Open();
            OleDbCommand com = new OleDbCommand();
            com.Connection = connection;
            com.CommandText = "SELECT Title FROM [Watched]";
            OleDbDataReader rdr = com.ExecuteReader();
            while (rdr.Read())
            {
                result.Add(rdr["Title"].ToString());
            }
            connection.Close();
            Lists.ArrW1 = result.ToArray();
            connection.Open();
            OleDbCommand comm = new OleDbCommand();
            comm.Connection = connection;
            comm.CommandText = "SELECT Title FROM [Plan to Watch]";
            OleDbDataReader rdrr = comm.ExecuteReader();
            while (rdrr.Read())
            {
                result1.Add(rdrr["Title"].ToString());
            }
            connection.Close();
            Lists.ArrP1 = result1.ToArray();
        }
        public void movieCollection()
        {
            //clears list for a refresh
            MovieList.Clear();
            //holds html
            NetflixHtml.Html = webCrawling.DocumentText;
            int StartPos;//start index
            int EndPos;//end index

            //the rest is just parsing of the html and formatting the info for the movie into the list
            StartPos = NetflixHtml.Html.IndexOf("navigation-menu-profile-name") + "navigation-menu-profile-name".Length + 28;
            EndPos = NetflixHtml.Html.IndexOf("navigation-menu-profile-text") - 20 - StartPos;
            lblUserName.Text = NetflixHtml.Html.Substring(StartPos, EndPos);

            StartPos = NetflixHtml.Html.IndexOf("has-inline-left-gutter navigation-menu-profile") + "has-inline-left-gutter navigation-menu-profile".Length + 12;
            EndPos = NetflixHtml.Html.IndexOf("navigation-menu-profile-text") - 20 - StartPos;
            picProfile.Load(NetflixHtml.Html.Substring(StartPos, EndPos));

            while (NetflixHtml.Html.Contains("watch-title watch-title") && NetflixHtml.Html.Contains("m</span></span></p></a>"))
            {
                string MovieInfo = "";
                string MovieTitle = "";
                string MovieDuration = "";
                string MovieRating = "";
                string MovieImage = "";
                string MovieYear = "";
                int MovieNum;

                StartPos = NetflixHtml.Html.IndexOf("watch-title watch-title");
                EndPos = NetflixHtml.Html.IndexOf("m</span></span></p></a>") + 23 - NetflixHtml.Html.IndexOf("watch-title watch-title");
                MovieInfo = NetflixHtml.Html.Substring(StartPos, EndPos);
                NetflixHtml.Html = NetflixHtml.Html.Replace(MovieInfo, "");

                StartPos = MovieInfo.IndexOf("watch-page-link-year") + "watch-page-link-year".Length + 2;
                EndPos = MovieInfo.IndexOf("watch-page-link-maturity") - StartPos - "</span><span class=".Length - 1;
                MovieYear = MovieInfo.Substring(StartPos, EndPos);

                StartPos = MovieInfo.IndexOf("background-image:url(") + "background-image:url(".Length;
                EndPos = MovieInfo.IndexOf(");filter:progid") - StartPos;
                MovieImage = MovieInfo.Substring(StartPos, EndPos);

                StartPos = MovieInfo.IndexOf("data-index=") + "data-index=".Length + 1;
                EndPos = MovieInfo.IndexOf("aria-label=") - StartPos - 2;
                MovieNum = int.Parse(MovieInfo.Substring(StartPos, EndPos));

                StartPos = MovieInfo.IndexOf("aria-label=") + "aria-label=".Length;
                EndPos = MovieInfo.IndexOf("><div style=") - StartPos;
                MovieTitle = MovieInfo.Substring(StartPos, EndPos).Trim('"');

                StartPos = MovieInfo.IndexOf("watch-page-link-maturity") + "watch-page-link-maturity".Length + 2;
                EndPos = MovieInfo.IndexOf("watch-page-link-duration") - StartPos - 20;
                MovieRating = MovieInfo.Substring(StartPos, EndPos);

                StartPos = MovieInfo.IndexOf("watch-page-link-duration") + "watch-page-link-duration".Length + 2;
                EndPos = MovieInfo.IndexOf("m</span></span>") - StartPos;
                MovieDuration = MovieInfo.Substring(StartPos, EndPos);
                MovieTitle = MovieTitle.Replace("#x27;", "'");
                MovieList.Add(new MovieInformation() { Title = MovieTitle, Duration = MovieDuration + "m", Rating = MovieRating, ImgUrl = MovieImage, Position = MovieNum, Year = MovieYear });
            }
            //refreshs flow panel
            resetItems();
            //displays movies into the flwchart
            movieDiplay();
            
        }

        private void resetItems()
        {
            //makes an array of items the size of the list
            MovieContainer = new MovieItem[MovieList.Count];
            for (int i = 0; i < MovieList.Count; i++)
            {
                MovieContainer[i] = new MovieItem();
                //sets picture
                MovieContainer[i].Picture = MovieList[i].ImgUrl;
                MovieContainer[i].OriginalPos = MovieList[i].Position;//holds position for later
            }
        }

        public void movieView(int Pos)
        {
            //loads the miniview of the movie
            picMovie.Load(MovieList[Pos - 1].ImgUrl);
            lblTitle.Text = MovieList[Pos - 1].Title.Trim();
            if (lblTitle.Text.Length > 25)
            {
                //just makes sure the title isn't too long
                lblTitle.Text = lblTitle.Text.Substring(0, 25) + "...";
            }
            lblMovieDuration.Text = MovieList[Pos - 1].Duration.Trim();
            lblMovieYear.Text = MovieList[Pos - 1].Year.Trim();
            lblMovieRating.Text = MovieList[Pos - 1].Rating.Trim();

            //Find Rating for the movie clicked from databse of WATCHED
            connection.Open();
            OleDbCommand comm = new OleDbCommand();//Oledb command object created
            comm.Connection = connection;//linking command to connection
            comm.CommandText = "SELECT * FROM Watched WHERE Title='" + lblTitle.Text + "'";//query to search for title of the movie in the Watched table
            OleDbDataReader reader = comm.ExecuteReader();//oledb reader object created
            int count = 0;//counts how many times the title is in the database but it will only be once
            string Rating = "";//var to store the user rating saved in database
            while (reader.Read())//while it can find the title in the database
            {
                count++;//increases
                Rating = reader["User Rating"].ToString();//the rating at that row is stored
            }
            if(count == 1)
            {
                txtBoxRating.Text = Rating;//rating is displayed
            }
            connection.Close();

            //Changes the watched/plan to watch button based on the lists they are added to 
            //Watched button
            for (int i = 0; i < Lists.ArrW1.Length; i++)
            {
                if (lblTitle.Text == Lists.ArrW1[i])//if the title is in watched list arr
                {
                    btnListAdd.Text = "Remove from Watched";//updates the text
                    return;
                }
                else
                {
                    btnListAdd.Text = "Watched";
                }
            }

            //Plan to Watch Button 
            for (int i = 0; i < Lists.ArrP1.Length; i++)
            {
                if (lblTitle.Text == Lists.ArrP1[i])//if the title is in plan to watch list arr
                {
                    btnListAdd1.Text = "Remove from Plan to Watch";//updates the text
                return;
                }
                else
                {
                    btnListAdd1.Text = "Plan On Watching";//if not remains the same or returns to original text when removed from the list
                }
            }
        }

        public void movieDiplay()
        {
            //refreshes the flowpanel
            flwMovies.Controls.Clear();
            for (int i = 0; i < MovieContainer.Length; i++)
            {
                //loops and adds all the right items with their info
                flwMovies.Controls.Add(MovieContainer[i]);
            }
            picMovie.Load(MovieList[0].ImgUrl);
            lblTitle.Text = MovieList[0].Title;
            lblMovieDuration.Text = MovieList[0].Duration;
            lblMovieYear.Text = MovieList[0].Year;
            lblMovieRating.Text = MovieList[0].Rating;

            //When no movie is clicked on so the previous movie or first movie on the page are shown 
            //Changes the watched/plan to watch button based on the lists they are added to 
            //Watched button 

            for (int i = 0; i < Lists.ArrW1.Length; i++)
            {
                if (lblTitle.Text == Lists.ArrW1[i])//if the title is in watched list arr
                {
                    btnListAdd.Text = "Remove from Watched";//updates the text
                    return;
                }
                else
                {
                    btnListAdd.Text = "Watched";//if not remains the same or returns to original text when removed from the list
                }
            }

            //Plan to Watch Button 
            for (int i = 0; i < Lists.ArrP1.Length; i++)
            {
                if (lblTitle.Text == Lists.ArrP1[i])
                {
                    btnListAdd1.Text = "Remove from Plan to Watch";
                    return;
                }
                else
                {
                    btnListAdd1.Text = "Plan On Watching";
                }
            }
        }

        private void btnResetSearch_Click(object sender, EventArgs e)
        {
            movieDiplay();

            //when reset it return to main page so it is false
            Clicked = false;
            Clicked1 = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //clears flow chart
            flwMovies.Controls.Clear();
            //bool that checks if there was a movie found
            bool resest = false;
            //makes sure there is a search inquery
            if (txtSearchBar.Text.Length > 0)
            {
                //loops through list and checks all movies to find the ones that contain the text in the search
                for (int i = 0; i < MovieList.Count; i++)
                {
                    if (MovieList[i].Title.Contains(txtSearchBar.Text.ToLower()) && !resest)
                    {
                        resest = true;
                        flwMovies.Controls.Clear();
                    }
                    if (MovieList[i].Title.ToLower().Contains(txtSearchBar.Text.ToLower()))
                    {
                        //adds item to flow panel
                        flwMovies.Controls.Add(MovieContainer[i]);
                    }
                }

                if (!resest)
                {
                    //if no movie is found this happens
                    MessageBox.Show("No movies with that name found.", "Search Results");
                }
            }
        }

        private void bubbleSort(int[] arrayToSort, int Sortingto)
        {
            //for upto the unsorted elements is what this loop means
            for (int i = 0; i < Sortingto; i++)
            {
                //checks if needs to be rearranged by checking if the one on the left if larger than the one on the right
                if (arrayToSort[i] > arrayToSort[i + 1])
                {
                    //temp that stores the whole array and carries it over to swap the 2

                    int temp = arrayToSort[i + 1];
                    arrayToSort[i + 1] = arrayToSort[i];
                    arrayToSort[i] = temp;


                    MovieInformation movietemp = MovieList[i + 1];
                    MovieList[i + 1] = MovieList[i];
                    MovieList[i] = movietemp;
                }
            }

            Sortingto--;
            if (Sortingto != 0)
            {
                bubbleSort(arrayToSort, Sortingto);
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (comBoxSortBy.Text == "Year" || comBoxSortBy.Text == "Duration" || comBoxSortBy.Text == "Title")
            {
                //checks the sorting type and then formats arraytosort with int data that contains the correct info
                int[] ArrayToSort = new int[MovieList.Count];
                if (comBoxSortBy.Text == "Year")
                {
                    for (int i = 0; i < ArrayToSort.Length; i++)
                    {
                        ArrayToSort[i] = int.Parse(MovieList[i].Year);
                    }
                }
                else if (comBoxSortBy.Text == "Duration")
                {
                    for (int i = 0; i < ArrayToSort.Length; i++)
                    {
                        ArrayToSort[i] = int.Parse(MovieList[i].Duration.TrimEnd('m'));
                    }
                }
                else if (comBoxSortBy.Text == "Title")
                {
                    for (int i = 0; i < ArrayToSort.Length; i++)
                    {
                        ArrayToSort[i] = MovieList[i].Title[0];
                    }
                }
                bubbleSort(ArrayToSort, ArrayToSort.Length - 1);
                //resests display to display the results in order
                resetItems();
                movieDiplay();
            }
            else
            {
                //tells the user that nothing is selected
                MessageBox.Show("Please select one of the given options of sorting.", "Error");
            }
        }
        

        private void btnListAdd_Click(object sender, EventArgs e)
        {
            for(int i=0;i<Lists.ArrP1.Length;i++)
            {
                if(lblTitle.Text == Lists.ArrP1[i])
                {
                    MessageBox.Show("Movie is Plan to Watch List.\n Please remove it from the plan to watch list to move it to watched list.");
                    return;
                }
            }
            if (btnListAdd.Text == "Watched")
            {
                connection.Close();
                //check if rating is acceptable
                int x;
                string input = txtBoxRating.Text;
                if (int.TryParse(input, out x))
                {
                    if (x < 0 || x > 10)
                    {
                        MessageBox.Show("Invalid Rating");
                        txtBoxRating.Text = "0";
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Rating");
                    txtBoxRating.Text = "0";
                }
                //inserting data into Database
                connection.Open();
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = connection;
                comm.CommandText = "insert into Watched([Title], [User Rating]) values('" + lblTitle.Text + "', '" + txtBoxRating.Text + "')";
                comm.ExecuteNonQuery();
                MessageBox.Show("Movie added to Watched List!");
                result.Add(lblTitle.Text);
                Lists.ArrW1 = result.ToArray();
                connection.Close();
                for (int i = 0; i < MovieList.Count; i++)
                {
                    if (MovieList[i].Title.ToLower().Contains(lblTitle.Text.ToLower()))
                    {
                        flwMovies.Controls.Remove(MovieContainer[i]);
                        Lists.ArrWatched[Watched1] = i;
                    }
                }
                Watched1++;
                connection.Close();
            }
            else//if they click remove from watched
            {
                for (int i = 0; i < MovieList.Count; i++)
                {
                    if (MovieList[i].Title.ToLower().Contains(lblTitle.Text.ToLower()))
                    {
                        if(Clicked == true)
                        {
                            flwMovies.Controls.Remove(MovieContainer[i]);
                        }
                        for(int n =0;n<Lists.ArrWatched.Length;n++)
                        {
                            if(Lists.ArrWatched[n] == i)
                            {
                                for(int k =n;k< Lists.ArrWatched.Length-1;k++)
                                {
                                    Lists.ArrWatched[k] = Lists.ArrWatched[k + 1];
                                }
                                break;
                            }
                        }
                    }
                }
                connection.Open();
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = connection;
                comm.CommandText = "DELETE * FROM Watched WHERE Title='" + lblTitle.Text + "'";
                comm.ExecuteNonQuery();
                connection.Close();
                btnListAdd.Text = "Watched";
                result.Remove(lblTitle.Text);
                Lists.ArrW1 = result.ToArray();
                //remove the container and from database, change the btn txt to watched, remove from list Arr1 and Watched array
            }
        }
        
        
        
        private void btnListAdd1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Lists.ArrW1.Length; i++)
            {
                if (lblTitle.Text == Lists.ArrW1[i])
                {
                    MessageBox.Show("Movie is Watched List.\n Please remove it from the watched list to move it to plan to watch list.");
                    return;
                    
                }
            }
            if(btnListAdd1.Text=="Plan On Watching")
            {
                connection.Close();
                //check for duplicates 
                for (int i = 0; i < result1.Count; i++)
                {
                    if (lblTitle.Text == result1[i])
                    {
                        MessageBox.Show("Already in Plan to Watch List");
                        return;
                    }
                }
                connection.Close();
                //store info to database
                connection.Open();
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = connection;
                comm.CommandText = "insert into [Plan to Watch]([Title]) values('" + lblTitle.Text + "')";
                comm.ExecuteNonQuery();
                MessageBox.Show("Movie added to Plan to Watch List!");
                result1.Add(lblTitle.Text);
                Lists.ArrP1 = result1.ToArray();
                connection.Close();
                for (int i = 0; i < MovieList.Count; i++)
                {
                    if (MovieList[i].Title.ToLower().Contains(lblTitle.Text.ToLower()))
                    {
                        Lists.ArrPlantoWatch[Watched2] = i;
                    }

                }
                Watched2++;
                connection.Close();
            }
            else
            {
                for (int i = 0; i < MovieList.Count; i++)
                {
                    if (MovieList[i].Title.ToLower().Contains(lblTitle.Text.ToLower()))
                    {
                        if (Clicked1 == true)
                        {
                            flwMovies.Controls.Remove(MovieContainer[i]);
                        }
                        for (int n = 0; n < Lists.ArrPlantoWatch.Length; n++)
                        {
                            if (Lists.ArrPlantoWatch[n] == i)
                            {
                                for (int k = n; k < Lists.ArrPlantoWatch.Length - 1; k++)
                                {
                                    Lists.ArrPlantoWatch[k] = Lists.ArrPlantoWatch[k + 1];
                                }
                                break;
                            }
                        }
                    }
                }
                connection.Open();
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = connection;
                comm.CommandText = "DELETE * FROM [Plan to Watch] WHERE Title='" + lblTitle.Text + "'";
                comm.ExecuteNonQuery();
                connection.Close();
                btnListAdd1.Text = "Plan On Watching";
                result1.Remove(lblTitle.Text);
                Lists.ArrP1 = result1.ToArray();
                //remove the container and from database, change the btn txt to watched, remove from list Arr1 and Watched array
            }
        }
        bool Clicked = false;
        bool Clicked1 = false;
        private void cmboBoxMyLists_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (cmboBoxMyLists.SelectedIndex == 0)//watched 
            {
                Clicked = true;
                flwMovies.Controls.Clear();
                for(int i =0;i<Lists.ArrWatched.Length;i++)
                {
                    if (Lists.ArrWatched[i] == -1)
                    {
                        //nun
                    }
                    else
                    {
                        flwMovies.Controls.Add(MovieContainer[Lists.ArrWatched[i]]);
                        
                    }
                }
                
            }
            else if (cmboBoxMyLists.SelectedIndex == 1)//plan to watch
            {
                Clicked1 = true;
                flwMovies.Controls.Clear();
                for (int i = 0; i < Lists.ArrPlantoWatch.Length; i++)
                {
                    if(Lists.ArrPlantoWatch[i]==-1)
                    {
                        //nun
                    }
                    else
                    {
                        flwMovies.Controls.Add(MovieContainer[Lists.ArrPlantoWatch[i]]);
                        
                    }
                    
                }
                
            }
        }
        
    }
}
