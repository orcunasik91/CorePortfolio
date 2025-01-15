namespace CorePortfolio.Entities.Concrete;
public class Portfolio
{
    public int PortfolioId { get; set; }
    public string ProjectName { get; set; }
    public string ImageUrl { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}