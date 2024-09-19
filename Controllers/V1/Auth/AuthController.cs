using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JWT_Implementation.Data;
using Microsoft.AspNetCore.Mvc;

namespace JWT_Implementation.Controllers.V1.Auth
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly Utilities
    }
}