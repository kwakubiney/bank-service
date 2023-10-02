namespace Models.Account;
public class Account{
    public string ID {get; set;}
    public string Name {get; set;}
    public long Balance {get; set;}
    public DateTime CreatedAt { get; set; }
    public DateTime LastModified {get; set;}
}