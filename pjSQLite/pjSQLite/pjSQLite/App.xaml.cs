using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace pjSQLite
{
    public partial class App : Application
    {
        private const string EMAILKEY = "Email";
        private const string ENVIAEMAILKEY = "EnviaEmail";

        public string Email
        {
            get
            {
                try
                {
                    if (Properties.ContainsKey(EMAILKEY))
                        return Properties[EMAILKEY].ToString();
                    return "";
                }
                catch (Exception erro)
                {
                    return "Properties[EMAILKEY] vazia. \nErro: " + erro.ToString();
                }
            }
            set
            {
                Properties[EMAILKEY] = value;
            }
        }

        public bool EnviaEmail
        {
            get
            {
                try
                {
                    if (Properties.ContainsKey(ENVIAEMAILKEY))
                        return (bool)Properties[ENVIAEMAILKEY];
                    return false;
                }
                catch
                {
                    return false;
                }

            }
            set
            {
                Properties[ENVIAEMAILKEY] = value;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
