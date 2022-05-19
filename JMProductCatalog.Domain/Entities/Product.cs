using JMProductCatalog.Domain.Validation;
using System;

namespace JMProductCatalog.Domain.Entities
{
    public sealed class Product : Entity
    {

        public Product(string name, string description, decimal price, int stock, string image)
        {
            ValidateDomain(name, description, price, stock, image);
        }

        public Product(Guid id, string name, string description, decimal price, int stock, string image)
        {
            ValidationDomain(id);
            ValidateDomain(name, description, price, stock, image);
        }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public int Stock { get; private set; }
        public string Image { get; private set; }


        private void ValidateDomain(string name, string description, decimal price, int stock, string image)
        {

            DomainExceptionValidation.When(string.IsNullOrEmpty(name),
                "Invalid name. Name is required");

            DomainExceptionValidation.When(name.Length < 3, 
                "Invalid name, too short, minimum 3 caracteres");

            DomainExceptionValidation.When(description.Length < 5,
                "Invalid description, too short, minimum 5 characters");

            DomainExceptionValidation.When(price < 0, "Invalid price value");
            
            DomainExceptionValidation.When(stock < 0, "Invalid stock value");
            
            DomainExceptionValidation.When(image.Length > 250
                , "Invalid image name, to long, maximum 250 characters");


            Name = name;
            Description = description;
            Price = price;
            Stock = stock;
            Image = image;
        }

        
        public Guid CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
