##### System.Reflection.Emit.DynamicMethod
# DynamicMethod

Starter code
``` csharp
var method = new DynamicMethod("", typeof(int), new[] { typeof(int), typeof(int) });

var x = method.DefineParameter(1, ParameterAttributes.In, null);
var y = method.DefineParameter(1, ParameterAttributes.In, null);

var generator = method.GetILGenerator();
generator.Emit(OpCodes.Ldarg_0);
generator.Emit(OpCodes.Ldarg_1);
generator.Emit(OpCodes.Add);
generator.Emit(OpCodes.Ret);

var add = (Func<int, int, int>)method.CreateDelegate(typeof(Func<int, int, int>));
```
