using GenesisPalindrome.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GenesisPalindrome.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Palindrome()
        {
            Palindrome palindrome = new Palindrome();
            return View(palindrome);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Palindrome(Palindrome palindrome, string UserWord)
        {
            // reverse the word
            // string reversedWord = palindrome.ReverseWord(UserWord);

            palindrome.IsPalindrome(UserWord);
            return View(palindrome);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}