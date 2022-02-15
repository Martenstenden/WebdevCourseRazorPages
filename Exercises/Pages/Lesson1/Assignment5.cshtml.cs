using System;
using System.Diagnostics.Metrics;
using Exercises.Pages.Lesson1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercises.Pages.Lesson1
{
    public class Assignment5 : PageModel
    {
        public class MoodCounter {
            public int Happy { get; set; }
            public int Disappointed { get; set; }
            public int Angry { get; set; }
        }

        public int Happy { get; set; } = 0;
        public int Disappointed { get; set; } = 0;
        public int Angry { get; set; } = 0;

        public void OnGet(string action = "")
        {
            action = action.ToLower();

            string counterStr = Request.Cookies["happy"];
            if (counterStr == null)
            {
                Response.Cookies.Append("happy", Happy.ToString(), new CookieOptions()
                {
                    Expires = DateTimeOffset.Now.AddDays(30)
                });
            }
            else
            {
                Happy = int.Parse(counterStr);
                Disappointed = int.Parse(counterStr);
                Angry = int.Parse(counterStr);
                
                if (action == "happy")
                {
                    Happy++;
                    Response.Cookies.Append("happy", Happy.ToString());
                }
                else if (action == "disappointed")
                {
                    Disappointed++;
                    Response.Cookies.Append("counter", Disappointed.ToString());
                }
                else if (action == "angry")
                {
                    Angry++;
                    Response.Cookies.Append("counter", Angry.ToString());
                }
                else if (action == "reset")
                {
                    Response.Cookies.Delete("counter");
                }
            }
        }
    }
}
