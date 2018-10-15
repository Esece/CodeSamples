## SqlDataAdapter

Get DataTable (Simple)
``` csharp

var table = new DataTable();
var sql = "SELECT * FROM tbl";
var connectionString = @"Data Source=server\instance;Initial Catalog=db;";

using (var adapter = new SqlDataAdapter(sql, connectionString))
{
  adapter.Fill(table);
}
```
