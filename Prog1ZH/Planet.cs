using System;
using System.Collections.Generic;
using System.Text;

namespace Prog1ZH
{
    class Planet
    {
        public Planet(string Planet)
        {
            var _planetArr = Planet.Split(";");
            this.Name = _planetArr[0];
            this.Url = _planetArr[1];
        }
        public string Name { get; set; }
        public string Url { get; set; }
    }
}
