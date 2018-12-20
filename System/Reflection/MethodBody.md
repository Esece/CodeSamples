## MethodBody

Get Local variables
``` csharp
 var current = new System.Diagnostics.StackTrace().GetFrame(0);
 current.GetMethod().GetMethodBody().LocalVariables
```
