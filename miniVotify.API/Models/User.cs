namespace miniVotify.API.Models
{
    public class User
    {
        public required int id {  get; set; }
        public string UserName { get; set; } = string.Empty;

        public required string PasswordHash { get; set; }
        public required string email { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public Boolean IsActive { get; set; }

        public required string Role { get; set; }
    }
}
//Esta clase representa a un usuario con sus atributos que en la base de datos se va a corresponde con una tabla. 
//Estamos definiendo los atributos que va a tener el usuario que se va a registrar en nuestra aplicación. 