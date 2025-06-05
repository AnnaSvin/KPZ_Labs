using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryOwnHTML
{
    public class AddCssClassCommand : ICommand
    {
        private readonly LightElementNode _element;
        private readonly string _className;

        public AddCssClassCommand(LightElementNode element, string className)
        {
            _element = element;
            _className = className;
        }

        public void Execute()
        {
            if (!_element.CssClasses.Contains(_className))
            {
                _element.CssClasses.Add(_className);
            }
        }
    }
}
