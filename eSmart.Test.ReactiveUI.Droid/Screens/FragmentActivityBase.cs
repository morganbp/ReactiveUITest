
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

namespace eSmart.Test.ReactiveUI.Droid
{
	[Activity (Label = "FragmentActivityBase")]			
	public class FragmentActivityBase : Activity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Create your application here
		}
	}
}

