using Microsoft.AspNetCore.Mvc;

namespace LAB2.Controllers
{
    public class TodoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {
            return View();

        }
        [HttpPost]
        public IActionResult Add(string task)
        {
            ViewBag.Message = $"Đã thêm task: {task}";
            return View("Index");
        }
        public IActionResult Edit(int id)
        {
            // Giả lập dữ liệu để chỉnh sửa 
            ViewBag.Task = $"Task {id}";
            return View();
        }

        [HttpPost]
        public IActionResult Edit(int id, string task)
        {
            ViewBag.Message = $"Đã cập nhật Task {id} thành: {task}";
            return View();
        }
    }
}