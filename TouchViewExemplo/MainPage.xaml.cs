using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TouchViewExemplo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public void Handle_AnimationStarted(object sender, EventArgs e)
        {
     
        }

        public void Handle_Completed(object sender, EventArgs e)
        {
            //DisplayAlert("Aeeeee", "Voce Clicou aqui", "OK"); 
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
