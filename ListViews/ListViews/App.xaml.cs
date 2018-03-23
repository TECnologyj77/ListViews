using ListViews.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ListViews
{
	public partial class App : Application
	{

        static PersonDataBase database;
		public App ()
		{
			InitializeComponent();

            MainPage = new NavigationPage(new EntryPage());
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}

        public static PersonDataBase DataBase {
            get
            {
               if(database is null)
                {
                    database = new PersonDataBase(DependencyService.Get<IFileHelper>().GetLocalFilePath("PersonSQLite.db3"));
                }
                return database;
            }
            set
            {

            }
        }
	}
}
