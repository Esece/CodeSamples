###### System.Data.SqlClient.SqlDataReader
## SqlDataReader

Read from Database
``` csharp
using (var connection = new SqlConnection(""))
{
    using (var command = connection.CreateCommand())
    {
        command.CommandText = "SELECT * FROM tbl WHERE Id = @Id";
        command.Parameters.AddWithValue("@Id", id);
		
        connection.Open();

        using (var reader = command.ExecuteReader())
        {
            while (reader.Read())
            {
                var str = (string)reader[0];
            }
        }
    }
}
```
