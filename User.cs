﻿using System.ComponentModel.DataAnnotations;

namespace APIProyectoFinal
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }

    }
}
