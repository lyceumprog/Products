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


				TextView productPrice = new TextView (context);
				productPrice.Id = i * 10 + 3;

				lp.AddRule (LayoutRules.AlignBottom, productTitle.Id);

				Button productPlus = new Button (context);
				productPlus.Id = i * 10 + 4;

				lp.AddRule (LayoutRules.AlignRight, productTitle.Id);

				EditText productAmount = new EditText (context);
				productAmount.Id = i * 10 + 5;

				lp.AddRule (LayoutRules.AlignBottom, productPlus.Id);

				Button productMinus = new Button (context);
				productMinus.Id = i * 10 + 6;

				lp.AddRule (LayoutRules.AlignRight, productAmount.Id);


    			productView.AddView (productImage);
				productView.AddView (productTitle);
				productView.AddView (productPrice);
				productView.AddView (productPlus);
				productView.AddView (productAmount);
				productView.AddView (productMinus);

				mainLayout.AddView (productView);
			}
		}
	}
}

