using CorePortfolio.Entities.Concrete;
using FluentValidation;

namespace CorePortfolio.Business.ValidationRules;
public class PortfolioAddValidator : AbstractValidator<Portfolio>
{
    public PortfolioAddValidator()
    {
        RuleFor(p => p.ProjectName).NotEmpty().WithMessage("Proje Adı Boş Geçilmemelidir!");
    }
}