###### System.Data.Entity.DbContext
## DbContext

Execute SQL Statement
``` csharp
using (var context = new DbContext("Data Source=;Initial Catalog=;Integrated Security=True;MultipleActiveResultSets=True"))
{
      var parameter1 = new SqlParameter("@Parameter1", p1);
      IEnumerable<Data> data = context.Database.SqlQuery<Data>("spGetData @Parameter1", parameter1);
}
```

Execute SQL Statement (Simple)
``` csharp
using (var context = new DbContext("Data Source=;Initial Catalog=;Integrated Security=True;MultipleActiveResultSets=True"))
{
      context.Database.SqlQuery<int>("select * from tbl where id = @id", new SqlParameter("id", 600));
}
```
