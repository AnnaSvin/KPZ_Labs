using ClassLibraryOwnHTML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCompositePattern
{
    public class ImageElement : LightElementNode
    {
        private string _href;
        private IImageLoaderStrategy _loaderStrategy;

        public string Href
        {
            get => _href;
            set
            {
                _href = value;
                SetStrategyByHref(_href);
            }
        }

        public ImageElement(string href)
            : base("img", DisplayType.Inline, ClosingType.SelfClosing)
        {
            Href = href;
        }

        private void SetStrategyByHref(string href)
        {
            if (IsLocalFile(href))
                _loaderStrategy = new FileSystemImageLoader();
            else
                _loaderStrategy = new NetworkImageLoader();
        }

        private bool IsLocalFile(string href)
        {
            return !(href.StartsWith("http://") || href.StartsWith("https://"));
        }

        public override string OuterHTML
        {
            get
            {
                return _loaderStrategy.LoadImage(Href);
            }
        }

        public override string InnerHTML => "";
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
