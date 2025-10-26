using System.ComponentModel.DataAnnotations;

namespace clase251025.Models.DTOs
{
    public class CreateHospitalDto
    {
        [Required]
        public Guid Id { get; init; }
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
        public int Type { get; set; }
    }
}
