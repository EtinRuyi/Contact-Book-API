using ContactBookAPI.Core.Services.Interface;
using ContactBookAPI.Model.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace ContactBookAPI.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRoleController : BaseController
    {
        private readonly IUserRoleService _roleService;
        public UserRoleController(IUserRoleService roleService) => _roleService = roleService;

        [HttpPost]
        public async Task<IActionResult> AddRole([FromBody] AddUserRoleDto dto)
            => BuildHTTPRequest(await _roleService.AddUserRoleAsync(dto));


    }
}