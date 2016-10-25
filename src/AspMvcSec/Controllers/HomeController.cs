using System.Web.Mvc;
using AspMvcSec.DataAccess;
using AspMvcSec.Models;

namespace AspMvcSec.Controllers
{
  [Authorize]
  public class HomeController : Controller
  {
    private ICommentsRepository _commentsRepository;

    public HomeController() : this(new CommentsRepository())
    {      
    }

    public HomeController(ICommentsRepository commentsRepository)
    {
      _commentsRepository = commentsRepository;
    }

    public ActionResult Index()
    {
      return View(_commentsRepository.GetAll());
    }

    [ChildActionOnly]
    [HttpGet]
    public ActionResult CreateComment()
    {
      return PartialView();
    }

    [HttpPost]
    public ActionResult CreateComment(Comment comment)
    {
      _commentsRepository.Add(comment);
      return RedirectToAction("Index");
    }
  }
}