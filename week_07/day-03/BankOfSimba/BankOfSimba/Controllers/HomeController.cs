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
        public static int counter = 0;

        // GET: /<controller>/
        [Route("Simba")]
        public IActionResult Index()
        {
            BankAccount bankAccount = new BankAccount("Simba", 2000, Animal.Lion, true, true);
            return View(bankAccount);
        }

        [Route("List")]
        public IActionResult List()
        {
            var bankAccount = new BankAccount();

            bankAccount.ListOfNamesThaIDontKnow.Add(new BankAccount("Simba", 2000, Animal.Lion, true, true));
            bankAccount.ListOfNamesThaIDontKnow.Add(new BankAccount("Mufasa", 20000, Animal.Hound, false, true));
            bankAccount.ListOfNamesThaIDontKnow.Add(new BankAccount("Timon", 12000, Animal.Monkey, true, false));
            bankAccount.ListOfNamesThaIDontKnow.Add(new BankAccount("Pumba", 5000, Animal.Lion, false, false));
            bankAccount.ListOfNamesThaIDontKnow.Add(new BankAccount("Nala", 8000, Animal.Giraffe, false, true));

            return View(bankAccount);
        }
    }
}
