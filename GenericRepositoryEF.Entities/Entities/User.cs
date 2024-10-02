﻿namespace GenericRepositoryEF.Entities.Entities
{
    public class User : IBaseEntity
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string? Email { get; set; }
        public string Role { get; set; }
    }
}
