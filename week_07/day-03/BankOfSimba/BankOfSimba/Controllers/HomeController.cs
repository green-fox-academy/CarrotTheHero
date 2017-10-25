using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankOfSimba.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BankOfSimba.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        [Route("Simba")]
        public IActionResult Index()
        {
            BankAccount bankAccount = new BankAccount("Simba", 2000, Animal.Lion);
            return View(bankAccount);
        }

        [Route("List")]
        public IActionResult List()
        {
            var ListOfNamesThaIDontKnow = new List<BankAccount>();

            ListOfNamesThaIDontKnow.Add(new BankAccount("Simba", 2000, Animal.Lion));
            ListOfNamesThaIDontKnow.Add(new BankAccount("Mufasa", 20000, Animal.Hound));
            ListOfNamesThaIDontKnow.Add(new BankAccount("Timon", 12000, Animal.Monkey));
            ListOfNamesThaIDontKnow.Add(new BankAccount("Pumba", 5000, Animal.MonkeyBreadTree));
            ListOfNamesThaIDontKnow.Add(new BankAccount("Nala", 8000, Animal.Giraffe));

            return View(ListOfNamesThaIDontKnow);
        }
    }
}
