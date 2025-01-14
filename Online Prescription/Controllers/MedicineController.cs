﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Online_Prescription.Models;
using Online_Prescription.Repository;

namespace Online_Prescription.Controllers
{
    public class MedicineController : Controller
    {
        private readonly MedicineRepository _medicineRepository = new MedicineRepository();

        [HttpPost("api/medicine/add")]
        [Authorize]
        public IActionResult AddMedicine([FromBody] Medicine medicine)
        {
            var addedMedicine = _medicineRepository.Add(medicine);
            return Ok(addedMedicine);
        }

        [HttpGet("api/medicine/getById")]
        [Authorize]
        public IActionResult GetMedicineById(int mId)
        {
            var medicine = _medicineRepository.GetById(mId);

            return Ok(medicine);
        }

        [HttpGet("api/medicine/getAll")]
        [Authorize]
        public IActionResult GetAllMedicines()
        {
            return Ok(_medicineRepository.GetAll());
        }

        [HttpPut("api/medicine/update")]
        [Authorize]
        public IActionResult UpdateMedicine([FromBody] Medicine medicine)
        {
            return Ok(_medicineRepository.Update(medicine));
        }

        [HttpDelete("api/medicine/delete")]
        [Authorize]
        public IActionResult DeleteMedicine(int mId)
        {
            var medicine = _medicineRepository.GetById(mId);
            if (medicine != null)
            {
                _medicineRepository.Delete(medicine);
                return Ok(true);
            }
            else
            {
                return BadRequest("Invalid Medicine ID, medicine object not available");
            }
           
        }
    }
}
