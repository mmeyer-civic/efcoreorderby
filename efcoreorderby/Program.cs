using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace efcoreorderby
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var options = new DbContextOptionsBuilder<EfCoreOrderByContext>()
          .UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=simple_object;Trusted_Connection=True;MultipleActiveResultSets=true")
          .Options;
            using (EfCoreOrderByContext db = new EfCoreOrderByContext(options))
            {
                //works
                var query = db.SimpleObjects.OrderBy(t =>t.Name).ThenBy(t=>t.Color).ThenBy(t=>t.Family).ToList();

                foreach (var o in query)
                    Console.WriteLine(o.Name);

                //doesn't work
                var query2 = db.SimpleObjects.OrderBy(t => new { t.Name, t.Color, t.Family }).ToList();

                foreach (var o in query2)
                    Console.WriteLine(o.Name);
            }
        }
    }
}
