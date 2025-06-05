using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCompositePatternAndFlyweight
{
    public abstract class LifecycleElementNode : LightElementNode
    {
        protected LifecycleElementNode(string tagName, DisplayType display, ClosingType closing)
            : base(tagName, display, closing)
        {
        }

        public virtual void OnCreated() { }
        public virtual void OnClassListApplied() { }
        public virtual void OnStylesApplied() { }
        public virtual void OnInserted() { }
        public virtual void OnTextRendered() { }

        public void RenderWithLifecycle()
        {
            OnCreated();
            OnClassListApplied();
            OnStylesApplied();

            foreach (var child in Children)
            {
                if (child is LifecycleElementNode lifecycleChild)
                {
                    lifecycleChild.RenderWithLifecycle();
                }
            }

            OnTextRendered();
            OnInserted();
        }
    }
}
