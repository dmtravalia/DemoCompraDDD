using FluentValidation;
using FluentValidation.Results;
using System;

namespace DemoCompra.Domain.Core.Models
{
    public abstract class Entity
    {
        public Guid Id { get; protected set; }
        public DateTime DataAtualizacao { get; protected set; }
        public DateTime DataCadastro { get; protected set; }

        public bool IsValid() => ValidationResult.IsValid;
        public ValidationResult ValidationResult { get; set; }

        protected Entity()
        {
            Id = Guid.NewGuid();
            ValidationResult = new ValidationResult();
        }

        public bool Validate<TModel>(TModel model, AbstractValidator<TModel> validator)
        {
            ValidationResult = validator.Validate(model);
            return ValidationResult.IsValid;
        }

        public void AdicionarErro(string mensagem)
        {
            ValidationResult.Errors.Add(new ValidationFailure(string.Empty, mensagem));
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as Entity;

            if (ReferenceEquals(this, compareTo)) return true;
            if (ReferenceEquals(null, compareTo)) return false;

            return Id.Equals(compareTo.Id);
        }

        public static bool operator ==(Entity a, Entity b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;

            return a.Equals(b);
        }

        public static bool operator !=(Entity a, Entity b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return (GetType().GetHashCode() * 907) + Id.GetHashCode();
        }

        public override string ToString()
        {
            return $"{GetType().Name} [Id={Id}]";
        }
    }
}
