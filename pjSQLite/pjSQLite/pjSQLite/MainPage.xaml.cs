using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace pjSQLite
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var app = Application.Current as App;
            app.Email = TxtEmail.Text;
            app.EnviaEmail = SwitchEnviaEmail.On;
            // se quiser salvar imediatamente
            Application.Current.SavePropertiesAsync();
            if (app.EnviaEmail == true)
            {
                if (app.Email != "")
                {
                    LabelEmail.Text = app.Email;
                }
                else
                {
                    LabelEmail.Text = "Properties Email vazia";
                }
            }
            else
            {
                LabelEmail.Text = "";
            }
        }
    }
}
