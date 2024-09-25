namespace HTMLGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] courses = { " C#", "daTAbaser", "WebbuTVeCkling ", "clean Code " };

            Console.WriteLine(
                $"<!DOCTYPE html> \n" +
                $"<html> \n" +
                $"<body\\> \n" +
                $"<h1>Välkomna!</h1> \n" +
                $"<p>Kurs om { char.ToUpper(courses[0].Trim().ToLower()[0]) + courses[0].Trim().ToLower().Substring(1) }</p> \n" +
                $"<p>Kurs om { char.ToUpper(courses[1].Trim().ToLower()[0]) + courses[1].Trim().ToLower().Substring(1) }</p> \n" +
                $"<p>Kurs om { char.ToUpper(courses[2].Trim().ToLower()[0]) + courses[2].Trim().ToLower().Substring(1) }</p> \n" +
                $"<p>Kurs om { char.ToUpper(courses[3].Trim().ToLower()[0]) + courses[3].Trim().ToLower().Substring(1) }</p> \n" +
                $"</body> \n" +
                $"</html>"
            );
        }
    }
}
