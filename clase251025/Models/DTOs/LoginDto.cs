namespace clase251025.Models.DTOs
{
    public record LoginDto
    {
        public string Email { get; init; }
        public string Password { get; init; }
    }
}
