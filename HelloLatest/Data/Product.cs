namespace HelloLatest.Data;

public class Product
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string ImageSrc { get; set; }
    public string Url { get; set; }

    public static readonly IReadOnlyList<Product> All = new List<Product>()
    {
        new() {
            Name = "JetBrains Rider",
            Description = "JetBrains Rider is a cross-platform .NET IDE based on the IntelliJ platform and ReSharper.",
            ImageSrc = "rider.png",
            Url = "https://www.jetbrains.com/rider/"
        },
        new ()
        {
            Name = "JetBrains ReSharper",
            Description = "ReSharper helps instantly get to any code in a solution, no matter how large the solution is. It can also navigate you from any symbol to its related code such as implementations of a given interface, extension methods of a class, or usages of a field.",
            ImageSrc = "resharper.png",
            Url = "https://www.jetbrains.com/resharper/"
        },
        new ()
        {
            Name = "JetBrains dotCover",
            Description = "JetBrains dotCover is a .NET unit test runner and code coverage tool that integrates with Visual Studio and JetBrains Rider.",
            ImageSrc = "dotcover.png",
            Url = "https://www.jetbrains.com/dotcover/"
        },
        new ()
        {
            Name = "JetBrains dotTrace",
            Description = "dotTrace helps you detect performance bottlenecks in a variety of .NET and .NET Core applications: WPF and Universal Windows Platform, ASP.NET, Windows services, WCF services, and unit tests. Mono and Unity applications are supported as well.",
            ImageSrc = "dottrace.png",
            Url = "https://www.jetbrains.com/profiler/"
        },
        new ()
        {
            Name = "JetBrains dotMemory",
            Description = "dotMemory allows you to analyze memory usage in a variety of .NET and .NET Core applications: desktop applications, Windows services, ASP.NET web applications, IIS, IIS Express, arbitrary .NET processes, and more.",
            ImageSrc = "dotmemory.png",
            Url = "https://www.jetbrains.com/dotmemory/"
        },
        new ()
        {
            Name = "JetBrains dotPeek",
            Description = "dotPeek is a free-of-charge standalone tool based on ReSharper's bundled decompiler. It can reliably decompile any .NET assembly into equivalent C# or IL code.",
            ImageSrc = "dotpeek.png",
            Url = "https://www.jetbrains.com/decompiler/"
        }
    };
}

