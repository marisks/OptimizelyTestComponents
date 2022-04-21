using Microsoft.AspNetCore.Mvc;

namespace The.Great.Library.Pages.The.Great.Library.Components.Tester
{
    public class TesterViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string message)
        {
            return View(new TesterViewModel { Message = message });
        }
    }

    public class TesterViewModel
    {
        public string Message { get; internal set; }
    }
}
