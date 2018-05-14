###### System.Data.Entity.DbContext
## DbContext

Execute SQL Statement
``` csharp
using (var context = new DbContext("Data Source="))
{
      var parameter1 = new SqlParameter("@Parameter1", p1);
      IEnumerable<Data> data = context.Database.SqlQuery<Data>("spGetData @Parameter1", parameter1);
}
```
