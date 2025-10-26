using clase251025.Models;
using clase251025.Models.DTOs;
using clase251025.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace clase251025.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class HospitalController:ControllerBase
    {
        private readonly IHospitalService _service;
        public HospitalController(IHospitalService service )
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllHospitals()
        {
            IEnumerable<Hospital> items = await _service.GetAll();
            return Ok(items);
        }
        [HttpGet("{id:guid}")]
        [Authorize]
        public async Task<IActionResult> GetOne(Guid id)
        {
            var hospital = await _service.GetOne(id);
            return Ok(hospital);
        }

        [HttpPost]
        [Authorize(Policy = "AdminOnly")]
        public async Task<IActionResult> CreateHospital([FromBody] CreateHospitalDto dto)
        {
            if (!ModelState.IsValid) return ValidationProblem(ModelState);
            var hospital = await _service.CreateHospital(dto);
            return CreatedAtAction(nameof(GetOne), new { id = hospital.Id }, hospital);
        }
        [HttpPut("{id:guid}")]
        [Authorize] 
        public async Task<IActionResult> UpdateHospital(Guid id, [FromBody] UpdateHospitalDto dto)
        {
            if (!ModelState.IsValid) return ValidationProblem(ModelState);

            var updated = await _service.UpdateHospital(id, dto);
            if (updated is null) return NotFound();

            return Ok(updated); 
        }

        [HttpDelete("{id:guid}")]
        [Authorize(Policy = "AdminOnly")]
        public async Task<IActionResult> DeleteHospital(Guid id)
        {
            await _service.DeleteHospital(id);
            return NoContent();
        }

        [HttpGet("public/type1and3")]
        [AllowAnonymous]
        public async Task<IActionResult> GetHospitalsType1And3()
        {
            var hospitals = await _service.GetAllType1And3();
            return Ok(hospitals);
        }

    }
}
