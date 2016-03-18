using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace Products
{
	[Activity (Label = "Products", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it

			List<Product> item_list = new DBO ().GetProducts ();

			new NotListView (item_list, new LinearLayout (this), this);
		}
	}
}


