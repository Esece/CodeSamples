### Expression
###### System.Linq.Expressions.Expression



Property Name
``` csharp
Expression<Func<Product, string>> exp = p => p.Name;
var name = ((MemberExpression)exp.Body).Member.Name;

Console.WriteLine(name);  // prints "Name"
```

PropertyInfo
``` csharp
Expression<Func<Product, string>> exp = p => p.Name;
var propertyInfo = (PropertyInfo)((MemberExpression)productIdExp.Body).Member;
```

MethodInfo
``` csharp
Expression<Func<string, string>> trimStartExp = s => s.TrimStart(' ');
var info = (MethodInfo)((MethodCallExpression)trimStartExp.Body).Method;
```

Method Call
``` csharp
Expression.Call(Expression.Constant(" test "), info, Expression.Constant(new[] { ' ' })));  // equivalent of " test".TrimStart(' ');
```

Parameter
``` csharp
ParameterExpression p = Expression.Parameter(typeof(Product));
```

Assignment Operation
``` csharp
var parameter = Expression.Parameter(typeof(Product));
Expression.Assign(Expression.Property(parameter, "Id"), Expression.Constant(5));  // equivalent of "p.Id = 5;"
```

Compile to Delegate
``` csharp
var lines = new List<Expression>();

:

var parameter = Expression.Parameter(typeof(Product));
var block = Expression.Block(lines);
block.Update(new[] { parameter }, block.Expressions);

var func = Expression.Lambda<Action<Product>>(block, parameter).Compile();

var prod = new Product();
func(prod);  // method call
```
