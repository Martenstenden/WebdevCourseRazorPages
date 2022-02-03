using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercises.Pages.Lesson1
{
    public class Assignment1 : PageModel
    {
        public int scoreHome { get; set; }
        public int scoreAway { get; set; }
        public void OnGet()
        {
            if (Request.Query.ContainsKey("incrementHome"))
            {
                scoreHome = Convert.ToInt32(Request.Query["incrementHome"].First());

                scoreHome++;
            }

            else if (Request.Query.ContainsKey("decrementHome"))
            {
                scoreHome = Convert.ToInt32(Request.Query["decrementHome"].First());

                scoreHome--;
            }

            else if (Request.Query.ContainsKey("incrementAway"))
            {
                scoreAway = Convert.ToInt32(Request.Query["incrementAway"].First());

                scoreAway++;
            }

            else if (Request.Query.ContainsKey("decrementAway"))
            {
                scoreAway = Convert.ToInt32(Request.Query["decrementAway"].First());

                scoreAway--;
            }

            else if (Request.Query.ContainsKey("reset"))
            {
                scoreHome = 0;
                scoreAway = 0;
            }
        }
    }
}
