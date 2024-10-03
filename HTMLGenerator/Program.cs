using System.Diagnostics;

namespace HTMLGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GeneratorWebsite website1 = new GeneratorWebsite(".Net");
            website1.AddCourses(" C#", "daTAbaser", "WebbuTVeCkling ", "clean Code ");
            website1.AddMessages(" Möte på måndag", "diskA Koppar", "Sal byte på tisdag ", "Clean Code lektion");
            website1.ShowHTML();

            GeneratorWebsiteStyled website2 = new GeneratorWebsiteStyled(".Net", "Red");
            website2.AddCourses(" C#", "daTAbaser", "WebbuTVeCkling ", "clean Code ");
            website2.AddMessages(" Möte på måndag", "diskA Koppar", "Sal byte på tisdag ", "Clean Code lektion");
            website2.ShowHTML();            
        }
    }
}
