﻿using JWTImplementation.Models;

namespace JWTImplementation.RequestModels
{
    public class LoginRequest
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
