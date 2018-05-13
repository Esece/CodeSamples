###### System.Data.SqlClient
## SqlConnection

Connect with Windows Auth or Service Account
``` csharp
using (var connection = new SqlConnection("Data Source=;Initial Catalog=;Integrated Security=True;MultipleActiveResultSets=True"))
{

}
```
