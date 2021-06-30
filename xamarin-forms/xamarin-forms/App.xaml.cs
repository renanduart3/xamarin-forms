using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using xamarin_forms.Services;
using xamarin_forms.Views;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace xamarin_forms
{
	public partial class App : Application
	{

		public App()
		{
			InitializeComponent();

			DependencyService.Register<MockDataStore>();
			MainPage = new AppShell();
		}

		protected override void OnStart()
		{
			AppCenter.Start("android=3d4e6e6f-fb0d-4dc7-a9fd-c76c5c736681;" +
				  "ios=4656872e-568f-423e-b40e-68a936c67240;",
				  typeof(Analytics), typeof(Crashes));

		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
