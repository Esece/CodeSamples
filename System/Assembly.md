###### System.Assembly
## Assembly

All Assemblies
``` csharp
AppDomain.CurrentDomain.GetAssemblies()
```

Get Assembly Location
``` csharp
Assembly.GetExecutingAssembly().Location
```

Get All Primitive Types
``` csharp
typeof(int).Assembly.GetTypes().Where(t => t.IsPrimitive).ToArray()
```
