###### System.Data.SqlClient
## SqlCommand

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

```
