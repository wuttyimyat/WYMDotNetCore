
using System.Data;
using System.Data.SqlClient;
using WYMDotNetCore.ConsoleApp;

Console.WriteLine("Hello, World!");

//SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();
//stringBuilder.DataSource = ".";
//stringBuilder.InitialCatalog = "WYMDotNetCore";
//stringBuilder.UserID = "sa";
//stringBuilder.Password = "sa@123";
//SqlConnection connection = new SqlConnection(stringBuilder.ConnectionString);
//connection.Open();
//Console.WriteLine("Connection Open.");
//string query = "SELECT * FROM Tbl_Blog";
//SqlCommand cmd = new SqlCommand(query, connection);
//SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
//DataTable dt = new DataTable();
//sqlDataAdapter.Fill(dt);
//connection.Close();
//Console.WriteLine("Connection Close.");
//foreach (DataRow dr in dt.Rows)
//{
//   Console.WriteLine("Blog Id ==> " + dr["BlogId"]);
//   Console.WriteLine("Blog Title ==> " + dr["BlogTitle"]);
//   Console.WriteLine("Blog Author ==> " + dr["BlogAuthor"]);
//   Console.WriteLine("Blog Content ==> " + dr["BlogContent"]);
//   Console.WriteLine("---------------------------------------------");

//}
//AdoDotNetExample adoDotNetExample = new AdoDotNetExample();
////adoDotNetExample.Read();
////adoDotNetExample.Create("title", "Author", "Content");
////adoDotNetExample.Update(11, "test title", "test author", "test content");
////adoDotNetExample.Delete(11);
//adoDotNetExample.Edit(11);
//adoDotNetExample.Edit(1);

DapperExample dapperExample = new DapperExample();
dapperExample.Run();

Console.ReadKey();
