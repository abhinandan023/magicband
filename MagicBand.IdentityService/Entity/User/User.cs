
public class User {

    public ulong UserId  { get; set; } // Magic Band Id
    public string SocialUserId { get; set; } // Google or Microsoft Id
    public string SubscriptionId { get; set; } // Id Associated with subscription (fast-track, basic or free )
    public int  UserTypeId  { get; set; } // Type of the user, like student, teacher, Product support, Admin
    public string FirstName { get; set; } // First name of the user
    public string MiddleName { get; set; } // Middle name of the user 
    public string LastName { get; set; } // Last name of the user
    public string ProfilePic { get; set; } // User profile data structure, TO DO
    public string DisplayName { get; set; } // Display name of the user, which an user can choose and the same can be displayed in his profile section
    public List<long> TemplatIds   { get; set; } // List of template Ids, which is being owned by teacher type user
    

}