namespace clase251025.Models.DTOs
{
    public record UpdateHospitalDto
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        public int? Type { get; set; } 
    }
}
