using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Products
{
	public class DBO
	{
		SqlConnection connection;

		public DBO ()
		{
			string dbPath = "";
			connection = new SqlConnection ("Data source=" + dbPath);
		}

		public List<Product> GetProducts(){
			List<Product> list = new List<Product> ();

			connection.Open ();

			using (SqlCommand command = connection.CreateCommand ()) {
				command.CommandText = "SELECT * FROM products";
				//....
			}

			connection.Close ();

			return list;
		}
	}
}

