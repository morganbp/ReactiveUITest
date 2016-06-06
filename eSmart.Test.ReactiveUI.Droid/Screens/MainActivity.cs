
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ReactiveUI;
using ReactiveUITest;

namespace eSmart.Test.ReactiveUI.Droid
{
	[Activity (Label = "MainActivity")]			
	public class MainActivity : Activity, IViewFor<MainViewModel>
	{
		object IViewFor.ViewModel {
			get {
				return ViewModel;
			}
			set {
				ViewModel = (MainViewModel)value;
			}
		}

		public MainViewModel ViewModel { get; set; }

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			SetContentView (Resource.Layout.Main);

			ViewModel = new MainViewModel ();

            AppResources.Name;
		}
	}
}

