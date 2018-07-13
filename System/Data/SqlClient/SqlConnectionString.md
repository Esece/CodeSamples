###### System.Data.SqlClient
## SqlConnectionString

Test Connection
``` csharp
using (var connection = new SqlConnection(@"Data Source=[server]\[instance];Initial Catalog=[dbname];Integrated Security=True;MultipleActiveResultSets=True"))
{
    connection.Open();
}
```
