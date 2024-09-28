namespace PruebaTecnica.Dto
{
    public class UserDbReadDto //Dto de modificacion de BD (GetAll,GetById)
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
