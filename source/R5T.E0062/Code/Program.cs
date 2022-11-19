using System;
using System.Threading.Tasks;


namespace R5T.E0062
{
    class Program
    {
        static async Task Main()
        {
            await Try.Instance.GenerateProgramFile();
        }
    }
}