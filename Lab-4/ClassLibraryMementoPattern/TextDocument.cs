using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMementoPattern
{
    public class TextDocument : IOriginator
    {
        public string Content { get; private set; }

        public TextDocument(string content = "")
        {
            Content = content;
        }

        public void Write(string text)
        {
            Content += text;
        }

        public IMemento Save()
        {
            return new Memento(Content);
        }

        public void Restore(IMemento memento)
        {
            Content = memento.GetState();
        }

        public override string ToString()
        {
            return Content;
        }
    }
}
