using System;
using Cinemas.Abstract;
using Cinemas.Models;
using Cinemas.ViewModels;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

using System.Data.Entity;


namespace Cinemas
{
    public partial class ListCinemas : Form
    {

        static string connectionString =
            ConfigurationManager.ConnectionStrings["Igor_Moskaluk_DBEntities1"].ConnectionString;

        static public ICinemasManager cinemasManager = new CinemasManager(connectionString);
        static public IMovieManager movieManager = new MovieManager(connectionString);

        static public CinemasViewModels cinemasViewModels = null;
        static public MovieViewModel movieViewModels = null;

        public ListCinemas()
        {
            InitializeComponent();
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {


                cinemasViewModels = new CinemasViewModels(cinemasManager);
                movieViewModels = new MovieViewModel(movieManager);


                //string _cmbList = cinemasViewModels.CINEMAS.Select(s => s.Id + " " + s.Name+ "\n").ToString();
                dgView.DataSource = movieViewModels.ListMovie;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MainWindow Loaded error");
            }
        }


    }
}
