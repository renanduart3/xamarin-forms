using System;
using System.Collections.Generic;
using Xamarin.Forms;
using xamarin_forms.ViewModels;
using xamarin_forms.Views;

namespace xamarin_forms
{
	public partial class AppShell : Xamarin.Forms.Shell
	{
		public AppShell()
		{
			InitializeComponent();
			Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
			Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
		}

	}
}
