using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Week3Client
{
    public partial class MainPage : ContentPage
    {
        Client _client;
        string temp = "Onbekend";


        public MainPage()
        {
            InitializeComponent();
            _client = new Client();
            temperature.BindingContext = temp;
        }

        private void Recieve_Clicked(object sender, EventArgs e)
        {
             _client.OpenConnection();
            var socketTemp = _client.Recieve();
            Console.WriteLine("Temp from socket : {0}", socketTemp);
            temperature.BindingContext = socketTemp;
        }

    }
}
