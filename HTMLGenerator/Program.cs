using System.Reflection.Emit;

namespace HTMLGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IHtml website1 = new HtmlStyled(".Net");
            website1.AddCourses(" C#", "daTAbaser", "WebbuTVeCkling ", "clean Code ");
            website1.AddMessages(" Möte på måndag", "diskA Koppar", "Sal byte på tisdag ", "Clean Code lektion");
            website1.AddStyling("darkslateblue");

            GenerateHtml generateHtml = new GenerateHtml(website1);
            generateHtml.RenderHtml();

            //Utilities.DisplayHtmlInBrowser("HTML Generator", website1.PutTogetherHtmlElements());
        }
    }
}