using System.Threading;
using System.Threading.Tasks;

namespace ApiCompatExample
{
public class MyClass
{
    public Task MyMethod(CancellationToken ct = default)
    {
        return Task.CompletedTask;
    }
}
}
