using Microsoft.AspNetCore.Mvc;
using Nancy.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WebDemo.Models;
using WebDemo.ViewModels;
namespace WebDemo.Models
{
    public class PersonList
    {
        [Required]
        public static List<Person> PList { get; set; }

        public List<Person> PListDynamic { get; set; }

        public static List<Person> GetPList(){
            return PList;
        }
        public static List<Person> defaultList()
        {
            Person.ResetCounter();
            Person p0 = new Person()
            {
                Name = "Dillip",
                Id = Person.Counter(),
                City = "Georgestown",
            };
            Person p1 = new Person()
            {
                Name = "Anton",
                Id = Person.Counter(),
                City = "Malmö",
            };
            Person p2 = new Person()
            {
                Name = "Peter",
                Id = Person.Counter(),
                City = "Foggy Bottom",
            };
            Person p3 = new Person()
            {
                Name = "Lisa",
                Id = Person.Counter(),
                City = "Mexico City",
            };


            //Creating the View model
            PersonList personList = new PersonList();
            
            PersonList.PList = new List<Person>();
            PersonList.PList.Add(p0);
            PersonList.PList.Add(p1);
            PersonList.PList.Add(p2);
            PersonList.PList.Add(p3);

            return PersonList.PList;
        }
    }
    public static class JsonExtensions
    {
        public static string ToJson(this Object obj)
        {
            return new JavaScriptSerializer().Serialize(obj);
        }
    }
}