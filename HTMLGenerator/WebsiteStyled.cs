using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLGenerator
{
    internal class WebsiteStyled : Website
    {
        public WebsiteStyled(string className)
            : base(className)
        {

        }

        public override string AddStyle(string color)
        {
            var inputColor = Utilities.HandleNullAndEmpty(color);
            return base.AddStyle(color.ToLower());
        }
    }
}
