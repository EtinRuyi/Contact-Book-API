namespace ContactBookAPI.Model.DTOs
{
    public class LoginResponseDto
    {
        public string Token { get; set; }
        public string Message { get; set; }
        public bool Success { get; set; }
    }
}
