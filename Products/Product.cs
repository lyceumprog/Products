using System;
using Android.Graphics;

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

		public Bitmap GetImage(){ // Возвращает картинку по названию изображения
			
		}
	}
}

