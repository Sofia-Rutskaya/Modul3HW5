using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
namespace Modul3HW5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ReadFiles();

            Console.Read();
        }

        public static async Task<string> Hello()
        {
            var path = @"C:\Users\admin\source\repos\Sofia-Rutskaya\Modul3HW5\Modul3HW5\Modul3HW5\Modul3HW5\Hello.txt";
            var result = string.Empty;
            using (var file = new StreamReader(path))
            {
                result = await file.ReadToEndAsync();
            }

            return result;
        }

        public static async Task<string> World()
        {
            var path = @"C:\Users\admin\source\repos\Sofia-Rutskaya\Modul3HW5\Modul3HW5\Modul3HW5\Modul3HW5\World.txt";
            var result = string.Empty;
            using (var file = new StreamReader(path))
            {
                result = await file.ReadToEndAsync();
            }

            return result;
        }

        public static async void ReadFiles()
        {
            var result = string.Empty;
            result = await Task.Run(() => Hello());
            result += await Task.Run(() => World());
            Console.WriteLine(result);
        }
    }
}
