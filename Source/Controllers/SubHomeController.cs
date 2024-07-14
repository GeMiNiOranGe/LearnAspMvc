using Microsoft.AspNetCore.Mvc;
using Source.Services;

namespace Source.Controllers {
    public class SubHomeController : Controller {
        private readonly ILogger<SubHomeController> _logger;
        private readonly ProductService _productServices;

        public SubHomeController(ILogger<SubHomeController> logger, ProductService productServices) {
            _logger = logger;
            _productServices = productServices;
        }

        public string Message() {
            _logger.LogInformation("Print infor: SubHomeController.Message()");
            _logger.LogWarning("Print warn: SubHomeController.Message()");
            _logger.LogError("Print error: SubHomeController.Message()");
            _logger.LogCritical("Print critical: SubHomeController.Message()");

            return "This is 'Message' method of SubHomeController class";
        }

        public void Nothing() {
            _logger.LogInformation("Nothing action");
            Response.Headers.Append("NothingMessage", "You can't see me");
        }

        public object Anything() {
            return DateTime.Now;
        }

        public IActionResult Readme() {
            var content = @"
            Hello
            World,
            I'm
            Mike";
            return Content(content);
        }

        public IActionResult PhonePrice() {
            return Json(new {
                ProductName = "Iphone X",
                Price = 2000
            });
        }

        public IActionResult Privacy() {
            var url = Url.Action("Privacy", "Home");
            _logger.LogInformation($"Local redirect to {url}");
            return LocalRedirect(url);
        }

        public IActionResult Youtube() {
            var url = "https://www.youtube.com";
            _logger.LogInformation($"Redirect to {url}");
            return Redirect(url);
        }

        public IActionResult HelloView(string username) {
            if (string.IsNullOrEmpty(username)) {
                username = "Guest";
            }

            /*
             * Url Example: localhost/SubHome/HelloView?username=Mike
             */
            // return View("MyViews/SubHome/HelloMyView.cshtml", username);
            // return View("Hello", username);
            return View((object)username);
        }

        [TempData]
        public string StatusMessage { get; set; }

        public IActionResult Product(int? id) {
            var product = _productServices
                .Where(product => product.Id == id)
                .FirstOrDefault();

            if (product == null) {
                //TempData["StatusMessage"] = "Product not found";

                StatusMessage = "Product not found";
                return Redirect(Url.Action("Index", "Home"));
            }
            // Case 1:
            //return View(product);

            // Case 2:
            //ViewData["Product"] = product;
            //ViewData["Title"] = product.Name;
            //return View("ProductView");

            // Case 3:
            ViewBag.Product = product;
            return View("ProductView1");
        }
    }
}
