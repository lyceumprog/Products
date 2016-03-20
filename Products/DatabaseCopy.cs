using System;
using System.IO;
using Android.Content;

namespace Products
{
	public class DatabaseCopy
	{
		public DatabaseCopy (Context context)
		{

			string dbPath = 
				Path.Combine (Environment.GetFolderPath (Environment.SpecialFolder.Personal), 
					"product.sqlite");

			if (!File.Exists (dbPath)) {
				var dbAssetStream = context.Assets.Open ("database.sqlite");
				var dbFileStream = new FileStream (dbPath, FileMode.OpenOrCreate);
				var buffer = new byte[1024];

				int b = buffer.Length;
				int length;

				while ((length = dbAssetStream.Read (buffer, 0, b)) > 0) {
					dbFileStream.Write (buffer, 0, length);
				}

				dbFileStream.Flush ();
				dbFileStream.Close ();
				dbAssetStream.Close ();
			}
		}
	}
}
