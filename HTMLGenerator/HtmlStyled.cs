using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLGenerator
{
    internal class HtmlStyled : Html
    {
        public HtmlStyled(string className)
            : base(className)
        {

        }

        public override string AddStyling(string color)
        {
            return base.AddStyling(Utilities.HandleNullAndEmpty(color.ToLower()));
        }
    }
}
