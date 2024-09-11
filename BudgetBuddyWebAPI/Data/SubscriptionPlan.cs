namespace BudgetBuddyWebAPI.Data
{
    // Defines one of the available subscription plan options
    public class SubscriptionPlan
    {
        // The unique identifier of the subscription plan
        public int Id { get; set; }

        // The name of the subscription plan
        public string Name { get; set; }

        // A text description of the subscription plan
        public string Description { get; set; }

        // A text description of the amount the subscription plan costs per month
        public string MonthlyPrice { get; set; }

        // The price of the plan for the entire subscription period
        public decimal Price { get; set; }
    }
}
