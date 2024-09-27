namespace PruebaTecnica.Dto
{
    //Dto de modificacion de BD (Post,Put)

    public class UserDbAlterDto
    {
        public string Nombre { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Contraseña { get; set; } = null!;
    }
}
