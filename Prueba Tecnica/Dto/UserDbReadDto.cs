namespace PruebaTecnica.Dto
{
    //Dto de consulta de BD (GetById,GetAll)
    public class UserDbReadDto
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Contraseña { get; set; } = null!;

    }
}
