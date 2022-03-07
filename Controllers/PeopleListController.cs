using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebDemo.Models;
using WebDemo.ViewModels;
namespace WebDemo.Controllers
{
    public class PeopleList : Controller
    {
        CreatePersonViewModel createPersonViewModel;
        PersonList personList;
        /*
        public PeopleList(CreatePersonViewModel createPersonViewModel)
        {
            this.createPersonViewModel = createPersonViewModel;
        }
        */


        [HttpGet]
        public ViewResult People()
        {
            createPersonViewModel = new CreatePersonViewModel();
            
            //Create People
            Person p0 = new Person()
            {
                Name = "Dillip",
                Id = 0,
                City = "Georgestown",
            };
            Person p1 = new Person()
            {
                Name = "Anton",
                Id = 1,
                City = "Malmö",
            };
            Person p2 = new Person()
            {
                Name = "Peter",
                Id = 2,
                City = "Foggy Bottom",
            };
            Person p3 = new Person()
            {
                Name = "Lisa",
                Id = 3,
                City = "Mexico City",
            };


            //Creating the View model
            personList = new PersonList();
            personList.PList = new List<Person>();
            personList.PList.Add(p0);
            personList.PList.Add(p1);
            personList.PList.Add(p2);
            personList.PList.Add(p3);

            createPersonViewModel.People = personList;

            createPersonViewModel.Col0 = "Name";
            createPersonViewModel.Col2 = "Remove";
            createPersonViewModel.Col1 = "City";
            createPersonViewModel.Title = "Title";

            

            //Pass the viewModel to the view
            return View(createPersonViewModel);
        }

        
        [HttpPost]
        public ViewResult People(CreatePersonViewModel createPersonViewModel, int personId)
        {
            createPersonViewModel.People.PList.RemoveAt(personId);
            return View(createPersonViewModel);
        }

    }
}
