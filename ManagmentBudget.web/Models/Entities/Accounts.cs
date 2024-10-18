namespace ManagmentBudget.web.Models.Entities
{
    public class Accounts
    {
        public int AccountId { get; set; }

        public string Name { get; set; }

        public Account_Types AccountTypeId { get; set; }

        public decimal Mount { get; set; }

        public string  Description { get; set; }
    }
}
