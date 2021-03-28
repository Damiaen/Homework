using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace week3b
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        Client c = new Client();

        public MainPage()
        {
            InitializeComponent();
        }

        private void Recieve_Clicked(object sender, EventArgs e)
        {
            if (c.OpenConnection())
            {
                c.Send("<TEMP>");
                Temperature.Text = c.Receive();
                c.CloseConnection();
            }
        }
    }
}
