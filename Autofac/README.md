## Autofac Code Samples
#### Simple Working Demo
``` csharp
static void Main()
{
    var builder = new Autofac.ContainerBuilder();
    builder.RegisterType<RepositoryType>().As<IRepositoryType>();
    builder.RegisterType<ServiceType>().As<IServiceType>();
    
    var container = builder.Build();
    
    using (var scope = container.BeginLifetimeScope())
    {
        var service = scope.Resolve<IServiceType>();
        service.Save(123);
    }
}

public class ServiceType : IServiceType
{
    IRepositoryType _repo;
    
    public ServiceType(IRepositoryType repo)
    {
        _repo = repo;
    }
    
    public void Save(int value)
    {
        Debug.WriteLine("Saving");
        _repo.Save();
    }
}

public interface IServiceType
{
    void Save(int value);
}

public class RepositoryType : IRepositoryType
{
    public void Save()
    {
        Debug.WriteLine("Saved");
    }
}

public interface IRepositoryType
{
    void Save();
}
```
