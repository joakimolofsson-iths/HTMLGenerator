using System.Diagnostics;

namespace HTMLGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WebsiteGenerator website1 = new WebsiteGenerator(".Net");
            website1.AddCourses(" C#", "daTAbaser", "WebbuTVeCkling ", "clean Code ");
            website1.AddMessages(" Möte på måndag", "diskA Koppar", "Sal byte på tisdag ", "Clean Code lektion");
            website1.ShowHTML();

            StyledWebsiteGenerator website2 = new StyledWebsiteGenerator(".Net", "Red");
            website2.AddCourses(" C#", "daTAbaser", "WebbuTVeCkling ", "clean Code ");
            website2.AddMessages(" Möte på måndag", "diskA Koppar", "Sal byte på tisdag ", "Clean Code lektion");
            website2.ShowHTML();            
        }
    }
}
