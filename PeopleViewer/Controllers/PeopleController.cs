using Microsoft.AspNetCore.Mvc;
using PersonReader.Factory;
using PersonReader.Interface;
using System.Collections.Generic;

namespace PeopleViewer.Controllers
{
    public class PeopleController : Controller
    {
        private ReaderFactory factory = new ReaderFactory();
        public IActionResult UseService()
        {
            // File reader

            ViewData["Title"] = "Using a Web Service";
            return PopulatePeopleView("Service");
            //Inline temporary variable with Ctrl + .
        }

        public IActionResult UseCSV()
        {
            // File reader
            ViewData["Title"] = "Using a CSV File";
            return PopulatePeopleView("CSV");
        }

        public IActionResult UseSQL()
        {
            ViewData["Title"] = "Using SQL Database";
            return PopulatePeopleView("SQL");
        }

        private IActionResult PopulatePeopleView(string readerType)
        {
            // File reader
            IPersonReader reader = factory.GetReader(readerType);
            IEnumerable<Person> people = reader.GetPeople();
            ViewData["ReaderType"] = reader.GetType().ToString();
            return View("Index", people);
        }
    }
}