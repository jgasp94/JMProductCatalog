using FluentAssertions;
using System;
using Xunit;

namespace JMProductCatalog.Domain.Test
{
    public class CategoryUnitTest1
    {
        [Fact(DisplayName ="Create Category with valid State")]
        public void CreateCategory_WithValidParameters_ResultValidState()
        {
            Action action = () => new Entities.Category(Guid.NewGuid(), "Material Escolar");
            action.Should()
                    .NotThrow<Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName ="Not create category because id invalid")]
        public void CreateCategory_MissingNameInvalid_DomainExceptionInvalidID()
        {
            Action action = () => new Entities.Category(Guid.Empty, "Material Escolar");
            action.Should()
                    .Throw<Validation.DomainExceptionValidation>().WithMessage("Invalid ID value.");
        }
    }
}
