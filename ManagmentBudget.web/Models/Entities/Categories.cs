namespace ManagmentBudget.web.Models.Entities
{
    public class Categories
    {
        public int CategoryId { get; set; }

        public string Name { get; set; }

        public Types_Operations TypeOperationId { get; set; }

        public Users UserId { get; set; }
    }
}
