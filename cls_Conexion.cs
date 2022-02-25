using System;
using System.Data;
using MySql.Data.MySqlClient;

public class Class1
{
	public Class1()
	{

        private DBHelper Conexion = new DBHelper();
        MySqlConnection Connection = new MySqlConnection("server=10.6.60.190;port=3306;user=administrador;password=ssp.2020;database=penas2");
        //MySqlConnection Connection = new MySqlConnection("server=localhost;port=3306;user=root;password=;database=penas2");
        MySqlDataReader dr;

        DataTable table = new DataTable();
        MySqlCommand cmd = new MySqlCommand();
}
}
