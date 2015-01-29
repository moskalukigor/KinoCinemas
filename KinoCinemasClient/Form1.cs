using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;

namespace KinoCinemasClient
{
    [ServiceContract]
    public interface IMyCinemas
    {
        [OperationContract]
        MovieViewModel Return(MovieViewModel MvM);
    }
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            ChannelFactory<IMyCinemas> factory = new ChannelFactory<IMyCinemas>(
                new WSHttpBinding(),
                new EndpointAddress("http://localhost/MathService"));
            IMyCinemas channel = factory.CreateChannel();
            int result = channel.Return(MvM);
        }
    }
}
