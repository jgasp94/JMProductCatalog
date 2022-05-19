using JMProductCatalog.Domain.Validation;
using System;
using System.Collections.Generic;

namespace JMProductCatalog.Domain.Entities
{
    public sealed class Category : Entity
    {
        public Category(string name)
        {
            ValidationDomain(name);
        }

        public Category(Guid id, string name)
        {
            ValidationDomain(id);
            ValidationDomain(name);
        }

        public string Name { get; private set; }
        public ICollection<Product> Products { get; set; }

        public void Update(string name)
        {
            ValidationDomain(name);
        }

        private void ValidationDomain(string name)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Invalid name. Name is Required");
            DomainExceptionValidation.When(name.Length < 3, "Invalid name, to short, minimum 3 charecters");

            Name = name;
        }

    }
}
