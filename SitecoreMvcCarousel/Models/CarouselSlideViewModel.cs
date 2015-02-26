using System.Web.Mvc;
using Sitecore.Data.Items;

namespace SitecoreMvcCarousel.Models
{
    public class CarouselSlideViewModel
    {
        public Item Item { get; set; }

        public MvcHtmlString Header
        {
            get { return GetFieldValue("Header"); }
        }

        public MvcHtmlString SubHead
        {
            get { return GetFieldValue("SubHead"); }
        }

        public MvcHtmlString Background
        {
            get { return GetFieldValue("Background"); }
        }

        public MvcHtmlString CallToAction
        {
            get { return GetFieldValue("CallToAction"); }
        }

        private MvcHtmlString GetFieldValue(string fieldName)
        {
            return new MvcHtmlString(Sitecore.Web.UI.WebControls.FieldRenderer.Render(Item, fieldName));
        }
    }
}