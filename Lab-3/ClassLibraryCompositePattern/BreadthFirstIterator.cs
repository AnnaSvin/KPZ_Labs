using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryOwnHTML
{
    public class BreadthFirstIterator : IIterator<LightNode>
    {
        private readonly Queue<LightNode> _queue = new();

        public BreadthFirstIterator(LightNode root)
        {
            _queue.Enqueue(root);
        }

        public bool HasNext() => _queue.Count > 0;

        public LightNode Next()
        {
            var current = _queue.Dequeue();

            if (current is LightElementNode element)
            {
                foreach (var child in element.Children)
                {
                    _queue.Enqueue(child);
                }
            }

            return current;
        }
    }
}
