using IMRWebAPIApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.Text.Json;

namespace IMRWebAPIApp.Controllers
{
    public class ProducController : Controller
    {
        private IOfferSerice _service;
        public ProducController(IOfferSerice service)
        {
            this._service = service;
        }

        [HttpGet]
        public async JsonResult GetTodaysOffers()
        {
            List<Product> offersList = _service.GetTodayOffers();

            await Task.Delay(1000);

            return JsonSerializer.Serialize<List<Product>>(offersList);
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}
