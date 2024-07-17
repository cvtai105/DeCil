// using App.Models.DTOs;
// using App.Models.Entities;
// using App.Services;
// using Microsoft.AspNetCore.Mvc;

// namespace App.Controllers
// {
//     [Route("auth")]
//     public class AuthController : Controller
//     {
//         private readonly AdminService _adminService;
//         private readonly TokenService _tokenService;

//         public AuthController(AdminService adminService, TokenService tokenService)
//         {
//             _adminService = adminService;
//             _tokenService = tokenService;
//         }

//         [HttpPost("login")]
//         public async Task<IActionResult> Login([FromBody] LoginRequest request)
//         {
//             Admin? admin = await _adminService.FindByEmailAsync(request.Email);        

//             if (admin == null || admin.Password != request.Password)
//             {
//                 return Unauthorized("Sai tài khoản hoặc mật khẩu");
//             }

//             // Generate token
//             var token = _tokenService.CreateToken(admin.Email, "admin");

//             // Return the token
//             return Ok(new AuthResponse { Token = token });
//         }
//     }

// }