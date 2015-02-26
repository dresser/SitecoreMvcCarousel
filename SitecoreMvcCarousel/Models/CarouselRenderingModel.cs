using System.Collections.Generic;
using System.Linq;
using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;

namespace SitecoreMvcCarousel.Models
{
    public class CarouselRenderingModel : Sitecore.Mvc.Presentation.RenderingModel
    {
        public override void Initialize(Rendering rendering)
        {
            base.Initialize(rendering);
            CarouselSlides =
                Sitecore.Data.ID.ParseArray(Item["SelectedItems"])
                    .Select(id => Item.Database.GetItem(id)).ToList();
        }

        public IList<Item> CarouselSlides { get; private set; } 
    }
}