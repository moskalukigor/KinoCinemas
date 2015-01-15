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

        static public CinemasViewModels cinemasViewModels = null;

        public ListCinemas()
        {
            InitializeComponent();
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {

                cinemasViewModels = new CinemasViewModels();

                string _cmbList = cinemasViewModels.CINEMAS.Select(s => s.Id + " " + s.Name+ "\n").ToString();

                //MessageBox.Show(_cmbList);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MainWindow Loaded error");
            }
        }


    }
}
