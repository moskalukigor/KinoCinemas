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


namespace Cinemas
{
    public partial class Form1 : Form
    {

        static string connectionString =
            ConfigurationManager.ConnectionStrings["Igor_Moskaluk_DBEntities1"].ConnectionString;

        static public ICinemasManager cinemasManager = new CinemasManager(connectionString);


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {

                CinemasViewModels = new CinemasViewModels();
                inExViewModel = new InExViewModel(
                    customerManager, orderItemManager, orderManager);

                this.Title = "Каталог Товаров";

                List<string> _cmbList = catalogViewModel.Categories.Where(c => c.ParentId == (int?)null)// == c.ParentID)
                    .OrderBy(c => c.Name)
                    .Select(c => c.Name).ToList();

                _cmbList.Insert(0, "Все Товары");
                vwCatalog.cmbCategory.DataContext = _cmbList;
                vwCatalog.cmbCategory.SelectedIndex = 0;


                vwCatalog.dgUCCatalog.DataContext = catalogViewModel.Catalog;
                vwImport.dgUCModule2_Import.DataContext = inExViewModel.InEx;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MainWindow Loaded error");
            }
        }


    }
}
