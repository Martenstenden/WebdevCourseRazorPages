using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercises.Pages.Lesson1
{
    public class Assignment1 : PageModel
    {
        //public int HomeScore { get; set; }
        //public int AwayScore { get; set; }

        //public void OnGet([FromQuery] string action)
        //{
        //    if (action == "incHome")
        //    {
        //        HomeScore = Convert.ToInt32(Request.Query["HomeCount"].First());
        //        AwayScore = Convert.ToInt32(Request.Query["AwayCount"].First());

        //        HomeScore++;
        //    }
        //    else if (action == "decHome")
        //    {
        //        HomeScore = Convert.ToInt32(Request.Query["HomeCount"].First());
        //        AwayScore = Convert.ToInt32(Request.Query["AwayCount"].First());

        //        HomeScore--;
        //    }
        //    else if (action == "incAway")
        //    {
        //        HomeScore = Convert.ToInt32(Request.Query["HomeCount"].First());
        //        AwayScore = Convert.ToInt32(Request.Query["AwayCount"].First());

        //        AwayScore++;
        //    }
        //    else if (action == "decAway")
        //    {
        //        HomeScore = Convert.ToInt32(Request.Query["HomeCount"].First());
        //        AwayScore = Convert.ToInt32(Request.Query["AwayCount"].First());

        //        AwayScore--;
        //    }
        //}

        //public void OnGet([FromQuery] string action, [FromQuery] int HomeCount, [FromQuery] int AwayCount)
        //{
        //    if(action == "incHome")
        //    {
        //        HomeScore = HomeCount;
        //        AwayScore = AwayCount;
        //        HomeScore++;
        //    }
        //    else if(action == "decHome")
        //    {
        //        HomeScore = HomeCount;
        //        AwayScore = AwayCount;
        //        HomeScore--;
        //    }
        //    else if (action == "incAway")
        //    {
        //        HomeScore = HomeCount;
        //        AwayScore = AwayCount;
        //        AwayScore++;
        //    }
        //    else if (action == "decAway")
        //    {
        //        HomeScore = HomeCount;
        //        AwayScore = AwayCount;
        //        AwayScore--;
        //    }
        //}

        [BindProperty]
        public string action { get; set; }
        [BindProperty]
        public int HomeScore { get; set; }
        [BindProperty]
        public int AwayScore { get; set; }

        public void OnGet()
        {
            if (action == "incHome")
            {
                HomeScore++;
            }
            else if (action == "decHome")
            {
                HomeScore--;
            }
            else if (action == "incAway")
            {
                AwayScore++;
            }
            else if (action == "decAway")
            {
                AwayScore--;
            }
        }
    }
}