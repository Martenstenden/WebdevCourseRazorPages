using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercises.Pages.Lesson1
{
    public class Assignment3 : PageModel
    {
        public double Resultaat { get; set; }

        public void OnPostAdd([FromForm] double tussenresultaat, double input)
        {
            Resultaat = tussenresultaat + input;
        }
        public void OnPostSub([FromForm] double tussenresultaat, double input)
        {
            Resultaat = tussenresultaat - input;
        }
        public void OnPostMul([FromForm] double tussenresultaat, double input)
        {
            Resultaat = tussenresultaat * input;
        }
        public void OnPostDiv([FromForm] double tussenresultaat, double input)
        {
            Resultaat = tussenresultaat / input;
        }
    }
}
