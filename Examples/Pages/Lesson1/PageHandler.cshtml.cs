using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Examples.Pages.Lesson1
{
    public class PageHandler : PageModel
    {
        public int Counter { get; set; } = 0;

        public void OnGet()
        {

        }

        public void OnPostIncrement()
        {
            Counter = Convert.ToInt32(Request.Form["count"].First());

            Counter++;
        }

        public void OnPostDecrement()
        {
            Counter = Convert.ToInt32(Request.Form["count"].First());

            Counter--;
        }

        public void OnGetIncrement([FromQuery] int count)
        {
            Counter = count + 1;
        }

        public void OnGetDecrement([FromQuery] int count)
        {
            Counter = count - 1;
        }
    }
}
