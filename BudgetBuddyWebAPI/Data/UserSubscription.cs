namespace BudgetBuddyWebAPI.Data
{
    // Defines a subscription reccord associated with a user
    public class UserSubscription
    {
        // The unique identifier of the user subscription
        public int Id { get; set; }

        // The user's chosen subscription plan
        public SubscriptionPlan SubscriptionPlan { get; set; } = null!;

        // The current status of the user subscription
        public SubscriptionStatus Status { get; set; }

        // The date the user initially subscribed
        public DateTime CreatedDate { get; set; }

        // The date the subscription record was last updated
        public DateTime UpdatedDate { get; set; }

        // The date the subscription was last billed
        public DateTime LastBillingDate { get; set; }

        // The next scheduled billing date of the subscription
        public DateTime NextBillingDate { get; set; }
    }

    public enum SubscriptionStatus
    {
        Active,
        PendingSuspension,
        Suspended
    }
}
