using System;
using System.Collections.Generic;
using Android.Widget;
using Android.Content;
using Android.Views;

namespace Products
{
	public class NotListView
	{
		public NotListView (List<Product> list,LinearLayout mainLayout, Context context)
		{
			for (int i = 0; i < list.Count; i++) {
				RelativeLayout productView = new RelativeLayout (context);

				ImageView productImage = new ImageView (context);
				productImage.SetImageDrawable (list [i].GetImage (context));
				productImage.Id = i * 10 + 1;

				RelativeLayout.LayoutParams lp = new RelativeLayout.LayoutParams(ViewGroup.LayoutParams.WrapContent,ViewGroup.LayoutParams.WrapContent);
				lp.AddRule (LayoutRules.AlignParentLeft);
				lp.AddRule (LayoutRules.CenterVertical);

				TextView productTitle = new TextView (context);
				productTitle.Id = i * 10 + 2;

				lp.AddRule (LayoutRules.AlignRight, productImage.Id);

				productView.AddView (productImage);
				productView.AddView (productTitle);
				//....

				mainLayout.AddView (productView);
			}
		}
	}
}

