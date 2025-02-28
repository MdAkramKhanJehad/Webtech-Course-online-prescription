﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Online_Prescription.Models;
using Online_Prescription.Repository;

namespace Online_Prescription.Controllers
{
    public class DoctorPrescriptionController : Controller
    {
        private readonly DoctorPrescriptionRepository _doctorPrescriptionRepository = new DoctorPrescriptionRepository();

        [HttpPost("api/doctorPrescription/add")]
        [Authorize]
        public IActionResult AddDoctorToPrescription([FromBody] DoctorPrescription doctorPrescription)
        {
            var addedDoctorPrescription = _doctorPrescriptionRepository.Add(doctorPrescription);
            return Ok(addedDoctorPrescription);
        }


        [HttpGet("api/doctorPrescription/getById")]
        [Authorize]
        public IActionResult GetDoctorPrescriptionById(int pId)
        {
            var doctorPrescription = _doctorPrescriptionRepository.GetByPrescriptionId(pId);

            return Ok(doctorPrescription);
        }


        [HttpGet("api/doctorPrescription/getAll")]
        [Authorize]
        public IActionResult GetAllDoctorPrescription()
        {
            return Ok(_doctorPrescriptionRepository.GetAll());
        }


        [HttpPut("api/doctorPrescription/update")]
        [Authorize]
        public IActionResult UpdateDoctorPrescription([FromBody] DoctorPrescription doctorPrescription)
        {
            return Ok(_doctorPrescriptionRepository.Update(doctorPrescription));
        }


        [HttpDelete("api/doctorPrescription/delete")]
        [Authorize]
        public IActionResult DeleteDoctorToPrescription(int pId)
        {
            var doctorPrescription = _doctorPrescriptionRepository.GetByPrescriptionId(pId);
            if (doctorPrescription != null)
            {
                _doctorPrescriptionRepository.Delete(doctorPrescription);
                return Ok(true);
            }
            else
            {
                return BadRequest("DoctorPrescription object is not available");
            }

           
        }

    }
}
