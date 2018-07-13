###### System.Web.Mvc.IModelBinder
### IModelBinder

Custom Model Binder Template
``` csharp
public class CustomModelBinder : IModelBinder
{
    public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
    {
        var type = bindingContext.ModelType;
        object instance = null;
        :
        return instance;
    }
}
```
``` csharp
ModelBinders.Binders.Add(type, new CustomModelBinder());
```
