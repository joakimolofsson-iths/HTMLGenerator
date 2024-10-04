namespace HTMLGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*IWebsite basicWebsite = new Website(".Net");
            basicWebsite.AddCourses(" C#", "daTAbaser", "WebbuTVeCkling ", "clean Code ");
            basicWebsite.AddMessages(" Möte på måndag", "diskA Koppar", "Sal byte på tisdag ", "Clean Code lektion");
            Generator generator1 = new Generator(basicWebsite);
            generator1.RenderHtml();*/

            IWebsite styledWebsite = new WebsiteStyled(".Net");
            styledWebsite.AddCourses(" C#", "daTAbaser", "WebbuTVeCkling ", "clean Code ");
            styledWebsite.AddMessages(" Möte på måndag", "diskA Koppar", "Sal byte på tisdag ", "Clean Code lektion");
            styledWebsite.AddStyle("Orange");
            Generator generator2 = new Generator(styledWebsite);
            generator2.RenderHtml();

            /*GeneratorWebsite website1 = new GeneratorWebsite(".Net");
            website1.AddCourses(" C#", "daTAbaser", "WebbuTVeCkling ", "clean Code ");
            website1.AddMessages(" Möte på måndag", "diskA Koppar", "Sal byte på tisdag ", "Clean Code lektion");
            website1.ShowHTML();

            GeneratorWebsiteStyled website2 = new GeneratorWebsiteStyled(".Net", "Indigo");
            website2.AddCourses(" C#", "daTAbaser", "WebbuTVeCkling ", "clean Code ");
            website2.AddMessages(" Möte på måndag", "diskA Koppar", "Sal byte på tisdag ", "Clean Code lektion");
            website2.ShowHTML();

            Utilities.DisplayHtmlInBrowser("HTML Generator", website2.ShowHTML());*/


        }
    }
}