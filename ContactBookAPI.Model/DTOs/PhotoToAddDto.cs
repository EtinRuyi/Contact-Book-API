using Microsoft.AspNetCore.Http;

namespace ContactBookAPI.Model.DTOs
{
    public class PhotoToAddDto
    {
        public IFormFile PhotoFile { get; set; }
    }
}
