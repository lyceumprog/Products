﻿using System;
using Android.Graphics;
using Android.Content;
using Android.Content.Res;

namespace Products
{
	public class Product
	{
		public string title;
		public int price;
		public string image_name;
		public int count;

		public Product (string title, string price, string image_name)
		{
			this.title = title;
			this.price = int.Parse (price);
			this.image_name = image_name;
		}

		public Android.Graphics.Drawables.Drawable GetImage(Context context){ // Возвращает картинку по названию изображения
			return context.Resources.GetDrawable(context.Resources.GetIdentifier(this.image_name,"drawable",context.PackageName));
		}
	}
}

