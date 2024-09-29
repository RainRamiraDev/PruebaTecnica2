﻿namespace PruebaTecnica.Dto
{
    public class UserDbReadDto //Dto de modificacion de BD (GetAll,GetById)
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Contraseña { get; set; } = null!;
    }
}
