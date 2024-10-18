namespace ManagmentBudget.web.Models.Entities
{
    public class Account_Types
    {
        public int AccountTypeId { get; set; }

        public string Name { get; set; }

        public Users UserId { get; set; }

        public int Order { get; set; }
    }
}
