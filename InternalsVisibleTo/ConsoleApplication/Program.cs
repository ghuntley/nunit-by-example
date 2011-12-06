using System.Runtime.CompilerServices;

// The assembly name should is slightly different if you want to strong name
// everything. http://msdn.microsoft.com/en-us/library/wd40t7ad.aspx is
// worth reading.
[assembly: InternalsVisibleTo("ConsoleApplication.Tests")]
namespace ConsoleApplication
{
    class Program
    {

        internal static int Main(string[] args)
        {
            return 1;
        }
    }
}
