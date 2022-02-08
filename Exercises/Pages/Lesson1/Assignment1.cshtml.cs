using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercises.Pages.Lesson1
{
    public class Assignment1 : PageModel
    {
        public int homeScore { get; set; }
        public int awayScore { get; set; }
        public string action { get; set; }

        public void OnGet()
        {
            homeScore = Request.Query["ScoreHome"];
            awayScore = Request.Query["ScoreAway"];
            action = Request.Query["action"];
        }
    }
}