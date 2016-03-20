using System;
using Mono.Data.Sqlite;
using System.Collections.Generic;

namespace Products
{
	public class DBO
	{
		SqliteConnection dbConnection;

		public DBO ()
		{
			string dbPath = 
				System.IO.Path.Combine 
				(System.Environment.GetFolderPath (System.Environment.SpecialFolder.Personal), 
					"product.sqlite");
			var dbConnection = new SqliteConnection ("Data source=" + dbPath);
		}

		public List<Product> GetProducts(){
			List<Product> productList = new List<Product> ();

			dbConnection.Open ();

			using (SqliteCommand dbCommand = dbConnection.CreateCommand ()) {

				dbCommand.CommandText = "select * from products";

				SqliteDataReader dbReader = dbCommand.ExecuteReader ();
				while (dbReader.Read ()) { // TODO add links
					/*
					_title_ = (dbReader [_index_].ToString ());
					_price_ = (dbReader [_index_].ToString ());
					...
					*/
				}
				dbReader.Close ();
			}

			dbConnection.Close ();

			return productList;
		}
	}
}
