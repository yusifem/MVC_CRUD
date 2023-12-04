using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class PersonController : Controller
    {
        static List<Person> people = new List<Person> { new Person { Name = "Person1", Surname = "Perosnn1", Age = 111 } };
        public IActionResult Index()
        {
            return View(people);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Person person)
        {
            people.Add(person);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Details(int id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            Person person = people.FirstOrDefault(x => x.Id == id);
            if (person == null)
            {
                return NotFound();
            }
            return View(person);
        }
        public IActionResult Delete(int id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            Person person = people.FirstOrDefault(x => x.Id == id);
            if (person == null)
            {
                return NotFound();
            }
            people.Remove(person);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Update(int id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            Person person = people.FirstOrDefault(x => x.Id == id);
            if (person == null)
            {
                return NotFound();
            }
            return View(person);
        }
        [HttpPost]
        public IActionResult Update(int id, Person person)
        {
            if (id == null)
            {
                return BadRequest();
            }
            Person exist = people.FirstOrDefault(x => x.Id == id);
            if (exist == null)
            {
                return NotFound();
            }
            exist.Name = person.Name;
            exist.Age = person.Age;
            exist.Surname = person.Surname;
            return RedirectToAction(nameof(Index));

        }
    }
}
