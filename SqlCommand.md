###### System.Data.SqlClient
## SqlCommand

Stored Procedure with In and Out Parameters
``` csharp
using (var connection = new SqlConnection(""))
{
    using (var command = connection.CreateCommand())
    {
        command.CommandType = CommandType.StoredProcedure;
        command.CommandText = "spGetData";

        command.Parameters.AddWithValue("@ID", id);

        var returnCodeParam = new SqlParameter("@ReturnCode", SqlDbType.Int) { Direction = ParameterDirection.Output };
        command.Parameters.Add(returnCodeParam);

        connection.Open();
        command.ExecuteNonQuery();

        var returnCode = (int)returnCodeParam.Value;
    }
}	
```

Get DataTable
``` csharp
using (var connection = new SqlConnection(""))
{
    using (var command = connection.CreateCommand())
    {
        command.CommandText = "SELECT TOP 10 * FROM tbl";

        using (var adapter = new SqlDataAdapter(command))
        {
            var table = new DataTable();
            adapter.Fill(table);
        }
    }
}
```

Write Binary
``` csharp
var bytes = File.ReadAllBytes(@"C:\Users\logo.png");

using (var connection = new SqlConnection(""))
{
    using (var command = connection.CreateCommand())
    {
        command.CommandText = "UPDATE tblImage SET Data = @Data WHERE ID = 3";
        command.Parameters.AddWithValue("@Data", bytes);
        connection.Open();
        command.ExecuteNonQuery();
    }
}
```
