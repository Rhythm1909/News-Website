namespace websiteApi.model{



public class User{
    
    public int Id {get; set;}
    public string Email{get; set;} = string.Empty;

    
    public string? Password{get; set;}

    

    public string? VerificationToken {get; set;} 

    public DateTime? VerifiedAt {get; set;}
    

}

}