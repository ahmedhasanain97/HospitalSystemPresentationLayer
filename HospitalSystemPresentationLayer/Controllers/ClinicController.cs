using HospitalSystemBLL.Dtos.ClinicDtos;
using HospitalSystemBLL.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalSystemPresentationLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClinicController : ControllerBase
    {
        private readonly IClinicService _clinicService;
        public ClinicController(IClinicService clinicService)
        {
            _clinicService = clinicService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllClinics()
        {
            var clinics = await _clinicService.GetAllClinicsAsync();
            return Ok(clinics);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetClinicById(int id)
        {
            var clinic = await _clinicService.GetClinicByIdAsync(id);
            if (clinic == null)
            {
                return NotFound();
            }
            return Ok(clinic);
        }
        [HttpPost]
        public async Task<IActionResult> AddClinic([FromBody] AddClinicDto clinic)
        {
            await _clinicService.AddClinicAsync(clinic);
            return Ok(clinic);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateClinic(int id, [FromBody] UpdateClinicDto clinic)
        {
            var existingClinic = await _clinicService.GetClinicByIdAsync(id);
            if (existingClinic == null)
            {
                return NotFound();
            }
            await _clinicService.UpdateClinicAsync(id, clinic);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClinic(int id)
        {
            var existingClinic = await _clinicService.GetClinicByIdAsync(id);
            if (existingClinic == null)
            {
                return NotFound();
            }
            await _clinicService.DeleteClinicAsync(id);
            return NoContent();
        }
    }
}
