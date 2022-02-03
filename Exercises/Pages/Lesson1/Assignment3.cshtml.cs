using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace Exercises.Pages.Lesson1
{
    public class Assignment3 : PageModel
    {
        public void OnGet()
        {
         
        }

        [BindProperty]
        public string Result { get; set; }

        public int intermediateresult = 0;

        public void OnPost([FromForm] string input)
        {
            intermediateresult = Convert.ToInt32(input);
            
            if (intermediateresult != 0)
            {
                Result = intermediateresult + input;
            }
        }
    }
}
