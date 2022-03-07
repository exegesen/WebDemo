using Microsoft.AspNetCore.Mvc;
using WebDemo.Models;
using WebDemo.ViewModels;
namespace WebDemo.Models
{
    public class Person
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
    }
}