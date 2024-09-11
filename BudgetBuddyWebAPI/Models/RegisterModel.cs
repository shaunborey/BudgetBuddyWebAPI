namespace BudgetBuddyWebAPI.Models
{
    public class RegisterModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public string TimeZoneId { get; set; }
        public bool OptInAccountNotices { get; set; }
        public bool OptInProductNotices { get; set; }
        public int SubscriptionPlanId { get; set; }
        public string StripeCustomerId { get; set; }
    }
}
