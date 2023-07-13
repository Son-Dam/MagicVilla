using System.ComponentModel.DataAnnotations;

namespace MagicVilla_UserAuthAPI.Models
{
    public class LocalUser
    {
        public int Id { get; set; }
        [MaxLength(30)]
        public string UserName { get; set; }
        [MaxLength(30)]
        public string Name { get; set; }
        [MaxLength(16)]
        public string Password { get; set; }
        [MaxLength(30)]
        public string Role { get; set; }

    }
}
