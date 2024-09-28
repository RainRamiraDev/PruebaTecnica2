namespace PruebaTecnica.Dto
{
    

    public class UserDbAlterDto //Dto de modificacion de BD (Post,Put)
    {
        public string Nombre { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Contraseña { get; set; } = null!;
    }
}
