using LandscapeGeneratorMenu.Model.Menu.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandscapeGeneratorMenu.Model.Menu
{
    class MenuTemplateModel : IMenuTemplate
    {
        public string Title { get; set; }
        public string Label { get; set; }
    }
}
