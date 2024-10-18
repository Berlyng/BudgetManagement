namespace ManagmentBudget.web.Models.Entities
{
    public class Transactions
    {
        public int TransactionId { get; set; }

        public Users UserId { get; set; }

        public DateTime TransactionDate { get; set; }

        public decimal Mount { get; set; }

        public int TypeOperationId { get; set; }

        public string Note { get; set; }

        public int AccountId { get; set; }

        public int CategoryId { get; set; }

    }
}
