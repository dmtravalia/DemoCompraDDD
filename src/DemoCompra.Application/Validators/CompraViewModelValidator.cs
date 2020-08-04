using DemoCompra.Application.ViewModels;
using FluentValidation;

namespace DemoCompra.Application.Validators
{
    public class CompraViewModelValidator : AbstractValidator<CompraViewModel>
    {
        public CompraViewModelValidator()
        {
            RuleFor(x => x.Quantidade)
                .GreaterThanOrEqualTo(100);

            RuleFor(x => x.Descricao)
                .NotNull();
        }
    }
}
