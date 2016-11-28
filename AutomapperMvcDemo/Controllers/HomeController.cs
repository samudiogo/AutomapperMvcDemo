using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutomapperMvcDemo.Domain.Entities;

using static AutomapperMvcDemo.AutoMapper.AutoMapperConfig;
using AutomapperMvcDemo.Models;

namespace AutomapperMvcDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var studentListModel = Mapper.Map<IEnumerable<Student>, IEnumerable<StudentViewModel>>
                (StudentMockList());

            return View(studentListModel);
        }
        private List<Student> StudentMockList()
        {
            return new List<Student>
            {
                new Student { Id = 1, Name= "Samuel", BirthDate = new DateTime(1990,2,12) },
                new Student { Id = 1, Name= "Gary", BirthDate = new DateTime(1978,6,21) },
                new Student { Id = 1, Name= "Andrew", BirthDate = new DateTime(1982,9,6) },
                new Student { Id = 1, Name= "John", BirthDate = new DateTime(1964,12,18) }
            };
        }
    }
}