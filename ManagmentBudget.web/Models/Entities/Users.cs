using System.ComponentModel.DataAnnotations.Schema;

namespace ManagmentBudget.web.Models.Entities
{
    [Table ("Userss")]
    public class Users
    {
        public int UserId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string StandardEmail { get; set; }

        public string PasswordHash { get; set; }

    }
}
