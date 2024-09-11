using Microsoft.AspNetCore.Identity;

namespace BudgetBuddyWebAPI.Data
{
    // Defines a registered user of the BudgetBuddy application
    public class ApplicationUser : IdentityUser
    {
        // The user's first name
        public required string FirstName { get; set; }

        // The user's middle name
        public string MiddleName { get; set; } = string.Empty;

        // The user's last name
        public required string LastName { get; set; }

        // The user's name suffix
        public string Suffix { get; set; } = string.Empty;

        // The TimeZoneInfo.Id of the user's selected timezone
        public string TimeZoneId { get; set; } = TimeZoneInfo.Utc.Id;

        // The Stripe customer ID associated with the user, if applicable
        public string StripeCustomerId { get; set; } = string.Empty;

        // A flag indicating if the user has opted in to receiving account notifications
        public bool OptInAccountNotices { get; set; } = false;

        // A flag indicating if the user has opted in to receiving product notifications
        public bool OptInProductNotices { get; set; } = false;

        // The subscription associated with this user
        public UserSubscription Subscription { get; set; } = null!;
    }
}
