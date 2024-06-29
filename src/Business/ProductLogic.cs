using DarthSeldon.API.FluentValidation.Demo.Records;

namespace DarthSeldon.API.FluentValidation.Demo.Business
{
    /// <summary>
    /// Product Logic
    /// </summary>
    public class ProductLogic
    {
        #region Methods

        /// <summary>
        /// Obtains the products.
        /// </summary>
        /// <returns>Queryable list of Products</returns>
        public IQueryable<Product> ObtainProducts()
        {
            var products = new List<Product>()
            {
                new Product {
                    Id = 1,
                    Description = "Description Product 01",
                    Name = "Product 01",
                    Price = 10
                },
                new Product {
                    Id = 2,
                    Description = "Description Product 02",
                    Name = "Product 02",
                    Price = 15
                },
                new Product {
                    Id = 3,
                    Description = "Description Product 03",
                    Name = "Product 03",
                    Price = 20
                },
                new Product {
                    Id = 4,
                    Description = "Description Product 04",
                    Name = "Product 04",
                    Price = 25
                },
                new Product {
                    Id = 5,
                    Description = "Description Product 05",
                    Name = "Product 05",
                    Price = 30
                }
            };

            return products.AsQueryable();
        }

        /// <summary>
        /// Creates the product.
        /// </summary>
        /// <param name="product">Product.</param>
        /// <returns>Inserted product</returns>
        public Product CreateProduct(Product product)
        {
            return product;
        }

        #endregion Methods
    }
}