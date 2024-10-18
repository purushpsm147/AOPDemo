using System.Reflection;

namespace AOPDemo;

public class StudentServiceDispatch<T> : DispatchProxy
    where T : class
{
    public T Target { get; set; }

    public static T Create<T>(T target) where T : class
    {
        var proxy = Create<T, StudentServiceDispatch<T>>() as StudentServiceDispatch<T>;
        proxy!.Target = target;

        return proxy as T;
    }
    protected override object? Invoke(
        MethodInfo? targetMethod, 
        object?[]? args)
    {
        // This method is called whenever any method on the generated proxy type is called
        Console.WriteLine("This Invoke method is called before the AddStudent method is called.");
        
        return targetMethod.Invoke(Target, args); // Now we call the actual method
    }
}
