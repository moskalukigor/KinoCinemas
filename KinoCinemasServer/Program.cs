using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Threading.Tasks;

using CinemasProj.Abstract;
using CinemasProj.Models;
using CinemasProj.ViewModels;
using System.Configuration;
using System.Data.Entity;
using System.Runtime.Serialization;

namespace CinemasProj
{
    [ServiceContract]
    public interface IMyCinemas
    {
        [OperationContract]
        MovieViewModel Return(MovieViewModel MvM);
    }
    public class MyCinemas : IMyCinemas
    {
        public MovieViewModel Return(MovieViewModel MvM)
        {
            return MvM;
        }
    }

    class Program
    {
        static string connectionString =
            ConfigurationManager.ConnectionStrings["Igor_Moskaluk_DBEntities"].ConnectionString;

        static public ICinemasManager cinemasManager = new CinemasManager(connectionString);
        static public IMovieManager movieManager = new MovieManager(connectionString);

        static public CinemasViewModels cinemasViewModels = null;
        static public MovieViewModel movieViewModels = new MovieViewModel(movieManager, cinemasManager);

        static void Main(string[] args)
        {

            ServiceHost sh = new ServiceHost(typeof(MyCinemas));
            //sh.CloseTimeout = TimeSpan.FromSeconds(20);
            sh.Open();

            Console.WriteLine("Press \"Enter\" to continue!\n");
            Console.ReadLine();
            sh.Close();
        }
    }
}
