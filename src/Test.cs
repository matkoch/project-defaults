using System.Linq;

namespace ProjectDefaults;

internal class MyClass
{
    private static void Main(string[] args)
    {
        var x = args.Select(x => new { A = x, B = x.ToLower() });
    }
}
