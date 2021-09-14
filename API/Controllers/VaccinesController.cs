using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VaccinesController : ControllerBase
    {

        [HttpGet]
        [Route(nameof(GetVaccines))]
        public dynamic GetVaccines(int vType, string searchText = "")
        {
            List<Vaccine> vaccines = new List<Vaccine>
            {
                new Vaccine { Id= 1, CenterName =  "Prince Rashid Military Hospital", Location =  "Irbid", Vaccines =  "Sinopharm", Dosage = 1},
                new Vaccine { Id =  2, CenterName =  "Prince Hashem bin Al Hussein Military Hospital", Location =  "Zarqa", Vaccines =  "Sinopharm", Dosage =  2},
                new Vaccine { Id =  3, CenterName =  "New Zarqa Governmental Hospital", Location =  "Zarqa", Vaccines =  "Sinopharm", Dosage =  2},
                new Vaccine { Id =  4, CenterName =  "Al Hussein Gardens Gate No. 2 from inside the car Drive Through", Location =  "Amman", Vaccines =  "Sinopharm", Dosage =  2},
                new Vaccine { Id =  5, CenterName =  "Al Bashir Hospital", Location =  "Amman", Vaccines =  "Sinopharm", Dosage =  1},
                new Vaccine {Id =  6, CenterName =  "Prince Hamzah Hospital", Location =  "Amman", Vaccines =  "Sinopharm", Dosage = 2},
                new Vaccine {Id =  7, CenterName =  "Prince Hashem bin Abdullah Military Hospital", Location =  "Aqaba", Vaccines =  "Sinopharm", Dosage =  2},
                new Vaccine { Id =  8, CenterName =  "North Madaba Comprehensive Health Center", Location =  "Madaba", Vaccines =  "Pfizer / Bionic", Dosage =  1},
                new Vaccine {Id =  9, CenterName =  "Irbid Camp Improvement Committee (Yarmouk Hall)", Location =  "Irbid", Vaccines =  "Pfizer / Bionic", Dosage =  1},
                new Vaccine { Id =  11, CenterName =  "Hobras Comprehensive Health Center", Location =  "Irbid", Vaccines =  "Pfizer / Bionic", Dosage =  2},
                new Vaccine { Id =  12, CenterName =  "Irbid Cultural Center", Location =  "Irbid", Vaccines =  "Pfizer / Bionic", Dosage =  2},
                new Vaccine { Id =  13, CenterName =  "Dirar Health Center - Deir Alla", Location =  "Balqa", Vaccines =  "Pfizer / Bionic", Dosage =  2},
                new Vaccine { Id =  14, CenterName =  "South Shouna Health Center", Location =  "Balqa", Vaccines =  "Pfizer / Bionic", Dosage =  2},
                new Vaccine { Id =  15, CenterName =  "Fuheis Health Center", Location =  "Balqa", Vaccines =  "Pfizer / Bionic", Dosage =  2},
                new Vaccine { Id =  16, CenterName =  "Zarqa camp improvement committee hall", Location =  "Zarqa", Vaccines =  "Pfizer / Bionic", Dosage =  2},
                new Vaccine { Id =  17, CenterName =  "Prince Muhammad City for Youth", Location =  "Zarqa", Vaccines =  "Pfizer / Bionic", Dosage =  2},
                new Vaccine { Id =  18, CenterName =  "Alhasa comprehensive health center", Location =  "Tafila", Vaccines =  "Pfizer / Bionic", Dosage =  2},
                new Vaccine { Id =  19, CenterName =  "Southern Mazar Health Center", Location =  "Karak", Vaccines =  "Pfizer / Bionic", Dosage =  2},
                new Vaccine { Id =  20, CenterName =  "King Talal Military Hospital", Location =  "Mafraq", Vaccines =  "Pfizer / Bionic", Dosage =  2}
            };


            if (vType != -1)
            {
                if (vType == 1)
                    vaccines = vaccines.Where(w => w.Vaccines == "Sinopharm").ToList();
                else if (vType == 2)
                    vaccines = vaccines.Where(w => w.Vaccines == "Pfizer / Bionic").ToList();
            }
            if (searchText == null) searchText = "";

            if (!string.IsNullOrEmpty(searchText.Trim()))
            {
                searchText = searchText.Trim().ToLower();
                vaccines = vaccines.Where(w => w.Location.ToLower().Contains(searchText)).ToList();
            }
            return Ok(vaccines) ;
        }
    }


    public class Vaccine
    {
        public int Id { get; set; }
        public string CenterName { get; set; }
        public string Location { get; set; }
        public string Vaccines { get; set; }
        public int Dosage { get; set; }
    }
}
