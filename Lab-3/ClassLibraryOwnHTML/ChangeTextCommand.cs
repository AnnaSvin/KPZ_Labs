using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryOwnHTML
{
    public class ChangeTextCommand : ICommand
    {
        private readonly LightTextNode _textNode;
        private readonly string _newText;

        public ChangeTextCommand(LightTextNode textNode, string newText)
        {
            _textNode = textNode;
            _newText = newText;
        }

        public void Execute()
        {
            _textNode.Text = _newText;
        }
    }
}
