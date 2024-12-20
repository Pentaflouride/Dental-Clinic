﻿namespace Dental_Clinic.Responses.User
{
    public class LoginResponse
    {
        public required string Jwt { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public required string Phone { get; set; }
        public int Role { get; set; }
    }
}
