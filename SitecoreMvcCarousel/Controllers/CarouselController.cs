using System.Linq;
using System.Web.Mvc;
using SitecoreMvcCarousel.Models;

namespace SitecoreMvcCarousel.Controllers
{
public class CarouselController : Controller
{
    [HttpGet]
    public ViewResult Index()
    {
        var item = Sitecore.Mvc.Presentation.RenderingContext.Current.Rendering.Item;
        var slideIds = Sitecore.Data.ID.ParseArray(item["SelectedItems"]);
        var viewModel = new CarouselViewModel
        {
            CarouselSlides =
                slideIds.Select(i =>
                    new CarouselSlideViewModel
                    {
                        Item = item.Database.GetItem(i)
                    }).ToList()
        };
        return View("~/Views/Renderings/Carousel/Carousel_(ControllerRendering).cshtml", viewModel);
    }
}
}
