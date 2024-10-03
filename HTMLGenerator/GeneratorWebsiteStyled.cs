﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLGenerator
{
    internal class GeneratorWebsiteStyled : GeneratorWebsite
    {
        private string _color;

        public GeneratorWebsiteStyled(string className, string color)
            : base(className)
        {
            _color = color;
        }

        public string Color
        {
            get => _color;
            set => _color = UtilitiesInput.HandleNullAndEmpty(value);
        }

        protected override void PrintHead(string color)
        {
            base.PrintHead(_color.ToLower());
        }
    }
}