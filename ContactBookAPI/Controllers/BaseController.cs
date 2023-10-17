using ContactBookAPI.Model.Entities.Shared;
using Microsoft.AspNetCore.Mvc;

namespace ContactBookAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        public IActionResult BuildHTTPRequest<T>(BaseResponse<T> requestResponse)
        {
            return requestResponse.ResponseCode switch
            {
                StatusCodes.Status200OK => Ok(requestResponse),
                StatusCodes.Status400BadRequest => BadRequest(requestResponse),
                StatusCodes.Status201Created => Created(requestResponse.Message, requestResponse),
                StatusCodes.Status401Unauthorized => Unauthorized(requestResponse),
                StatusCodes.Status404NotFound => NotFound(requestResponse),
            };
        }
    }
}
