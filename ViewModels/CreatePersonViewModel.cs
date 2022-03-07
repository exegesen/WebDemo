using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebDemo.Models;
using WebDemo.ViewModels;

namespace WebDemo.ViewModels
{
    public class CreatePersonViewModel
    {
        public string Col0 { get; set; }
        public string Col1 { get; set; }
        public string Col2 { get; set; }
        public string Title { get; set; }
        public List<Person> personList { get; set; }
        public void AddPerson(Person p) {

            if (personList == null) { 
                personList = new List<Person>();
            }
            personList.Add(p);

        }
        public void RemovePerson(Person p) {

            personList.Remove(p);

        }
        public void RemovePerson(int id)
        {

            personList.RemoveAt(id);

        }
        public Person GetPerson(int id) { 
        
            return personList[id];
        }
        

    }
}