using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using burgershack_c.Models;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace burgershack_c
{
    public class Program
    {

        //VERY VERY VERY BAD NEVER DO THIS
        public static List<Burger> Burgers = new List<Burger>() {
                new Burger() {
                    Id = 1,
                    Name = "Straight Up",
                    Description = "A plain old burger seasoned to perfection",
                    Price = 9.99 },
                new Burger() {
                    Id = 2,
                    Name = "Cheese Burger",
                    Description = "Straight up with cheese, (Choose One: Provolone, Gouda, Munster, Swiss, Cheddar, Merican)",
                    Price = 10.99 } };

        public static List<Drink> Drinks = new List<Drink>() {
            new Drink() {
                    Id = 1,
                    Name = "Soda",
                    Description = "Your choice between Pepsi and Coke products",
                    Price = 2.00 },
                new Drink() {
                    Id = 2,
                    Name = "Water",
                    Description = "Water gathered from a local mountain stream",
                    Price = 3.00 } 
        };
        public static List<Side> Sides = new List<Side>() {
            new Side() {
                    Id = 1,
                    Name = "French Fries",
                    Description = "Thinly sliced and fried to perfection",
                    Price = 2.50 },
                new Side() {
                    Id = 2,
                    Name = "Steak Fries",
                    Description = "Thick cut potatoes and slightly fried",
                    Price = 2.50 } 
        };
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
