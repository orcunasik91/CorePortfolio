namespace CorePortfolio.Entities.Concrete;
public class Message
{
    public int MessageId { get; set; }
    public string SenderName { get; set; }
    public string Email { get; set; }
    public string Content { get; set; }
    public DateTime DateSent { get; set; }
    public bool IsRead { get; set; }
}