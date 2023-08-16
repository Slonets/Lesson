using DateAccess.Data;
using Microsoft.AspNetCore.Mvc;

namespace WebAcademy.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentDbContext _context;

        public StudentController(StudentDbContext context)
        {
            _context = context;
        }
        //отримуємо список студентів
        public IActionResult Index()
        {
            return View(_context.Students.ToList());
        }
    }
}
