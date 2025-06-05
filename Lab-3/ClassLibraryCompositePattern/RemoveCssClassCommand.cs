using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryOwnHTML
{
    public class RemoveCssClassCommand : ICommand
    {
        private readonly LightElementNode _element;
        private readonly string _className;

        public RemoveCssClassCommand(LightElementNode element, string className)
        {
            _element = element;
            _className = className;
        }

        public void Execute()
        {
            _element.CssClasses.Remove(_className);
        }
    }
}
