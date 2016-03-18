using System;
using Mono.Data.Sqlite;
using System.Collections.Generic;

namespace Products
{
	public class DBO
	{
		SqliteConnection connection;

		public DBO ()
		{
			string dbPath = "";
			connection = new SqliteConnection ("Data source=" + dbPath);
		}

		public List<Product> GetProducts(){
			List<Product> list = new List<Product> ();

			connection.Open ();

			using (SqliteCommand command = connection.CreateCommand ()) {
				command.CommandText = "SELECT * FROM products";
				//....
			}

			connection.Close ();

			return list;
		}
	}
}

