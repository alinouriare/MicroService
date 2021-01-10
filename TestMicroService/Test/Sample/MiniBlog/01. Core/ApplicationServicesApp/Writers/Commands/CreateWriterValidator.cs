using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServicesApp.Writers.Commands
{
    public class CreateWriterValidator : AbstractValidator<CreateWiterCommand>
    {
        public CreateWriterValidator()
        {
            RuleFor(c => c.FirstName)
                .NotEmpty().WithMessage("اسمش خالیه")
                .MinimumLength(5).WithMessage("کمه")
                .MaximumLength(100).WithMessage("زیاده");
        }
    }
}
