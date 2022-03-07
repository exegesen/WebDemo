﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Text.Json;
using WebDemo.Models;
using WebDemo.ViewModels;

namespace WebDemo.Controllers
{
    
    public class PeopleList : Controller
    {
        
        CreatePersonViewModel createPersonViewModel;
        PersonList personList;
        public const string createPersonViewModelSession = "_createPersonViewModelSessionKey";
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
        public IActionResult People([FromForm] CreatePersonViewModel createPersonViewModel)
        {
            createPersonViewModel.People.PList.RemoveAt(createPersonViewModel.PersonId);
            return View(createPersonViewModel);
        }

        [HttpPost]
        public IActionResult Filter([FromForm] CreatePersonViewModel createPersonViewModel)
        {
            //createPersonViewModel.FilterAdd
            return View(createPersonViewModel);
        }


        [HttpPost]
        public IActionResult Add([FromForm] CreatePersonViewModel createPersonViewModel)
        {
            Person p = new Person()
            {
                Name = createPersonViewModel.Add,
                Id = Person.Counter(),
                City = createPersonViewModel.City,

            };

            createPersonViewModel.People.PList.Add((Person)p);


            return View(createPersonViewModel);
        }
        



    }

}
