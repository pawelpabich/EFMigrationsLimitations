using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;

namespace EFMigrationsLimitations
{
    class Program
    {
        static void Main()
        {
            using (var context = new AppContext())
            {
                context.Items.Add(new Item());
                context.SaveChanges();
                foreach (var item in context.Items.ToList())
                {
                    Console.WriteLine("Item {0}", item.Id);
                }
            }
        }
    }

    public sealed class Configuration : DbMigrationsConfiguration<AppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AppContext context)
        { }
    }


    public class AppContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
    }

    public class Item
    {
        public int Id { get; set; }
        public string Master { get; set; }
        public string AnotherDev { get; set; }
    }
}
