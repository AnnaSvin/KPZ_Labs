using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryOwnHTML
{
    public class DepthFirstIterator : IIterator<LightNode>
    {
        private readonly Stack<LightNode> _stack = new();

        public DepthFirstIterator(LightNode root)
        {
            _stack.Push(root);
        }

        public bool HasNext() => _stack.Count > 0;

        public LightNode Next()
        {
            var current = _stack.Pop();

            if (current is LightElementNode element)
            {
                for (int i = element.Children.Count - 1; i >= 0; i--)
                {
                    _stack.Push(element.Children[i]);
                }
            }

            return current;
        }
    }
}
