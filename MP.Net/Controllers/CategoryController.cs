using Microsoft.AspNetCore.Mvc;
using MP.Net.Data;
using MP.Net.Models;
using System.Drawing.Text;

namespace MP.Net.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDBContext _db;
        public CategoryController(ApplicationDBContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Category> objCategoryList=_db.Categories.ToList();
            return View();
        }
    }
}
