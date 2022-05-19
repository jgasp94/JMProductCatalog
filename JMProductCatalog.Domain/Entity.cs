using JMProductCatalog.Domain.Validation;
using System;

namespace JMProductCatalog.Domain.Entities
{
    public abstract class Entity
    {
        public Guid Id { get; protected set; }
        protected void ValidationDomain(Guid id)
        {
            DomainExceptionValidation.When(!Guid.TryParse(id.ToString(), out var newGuid) 
                    || string.IsNullOrEmpty(id.ToString()) 
                    || id == Guid.Empty, 
                    "Invalid ID value.");
            Id = id;
        }
    }
}
