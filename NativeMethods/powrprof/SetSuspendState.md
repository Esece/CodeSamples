## SetSuspendState

``` csharp

void Sleep()
{
    SetSuspendState(true, true, true);
}

void Hibernate()
{
    SetSuspendState(false, true, true);
}

[DllImport("Powrprof.dll", CharSet=CharSet.Auto, ExactSpelling=true)]
public static extern bool SetSuspendState(bool hiberate, bool forceCritical, bool disableWakeEvent);
```
