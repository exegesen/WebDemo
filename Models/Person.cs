using Microsoft.AspNetCore.Mvc;
using WebDemo.Models;
using WebDemo.ViewModels;
namespace WebDemo.Models
{
    public class Person
    {
        public static int counter = 0;
        public static int Counter() {
            counter++;
            return counter;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
    }
}