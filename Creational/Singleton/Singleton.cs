// ============================================================
//  Singleton  ·  Creational · 1 of 3
//
//  PROBLEM : Multiple copies of a shared resource
//  BENEFIT : One controlled, shared instance
//
//    Client A ─┐
//    Client B ─┼──▶ ( One shared instance )
//    Client C ─┘
// ============================================================
namespace DesignPatterns.Creational;

public sealed class AppConfig
{
    // Lazy<T> makes creation thread-safe and on first use.
    private static readonly Lazy<AppConfig> _instance = new(() => new AppConfig());

    public static AppConfig Instance => _instance.Value;

    public string Environment { get; set; } = "Production";

    private AppConfig() { } // no "new AppConfig()" from outside
}

public static class SingletonDemo
{
    public static void Run()
    {
        var a = AppConfig.Instance;
        var b = AppConfig.Instance;
        Console.WriteLine(ReferenceEquals(a, b)); // True: same instance
    }
}

// Note: in modern .NET apps, prefer services.AddSingleton<T>() with dependency injection.
