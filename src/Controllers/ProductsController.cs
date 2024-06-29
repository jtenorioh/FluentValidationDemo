using DarthSeldon.API.FluentValidation.Demo.Business;
using DarthSeldon.API.FluentValidation.Demo.Records;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace DarthSeldon.API.FluentValidation.Demo.Controllers
{
    /// <summary>
    /// Products Controller
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        #region Members

        /// <summary>
        /// The logger
        /// </summary>
        private readonly ILogger<ProductsController> _logger;

        /// <summary>
        /// The product logic
        /// </summary>
        private readonly ProductLogic _productLogic;

        /// <summary>
        /// The validator
        /// </summary>
        private readonly IValidator<Product> _validator;

        #endregion Members

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductsController"/> class.
        /// </summary>
        /// <param name="logger">The logger.</param>
        /// <param name="productLogic">The product logic.</param>
        /// <param name="validator">The validator.</param>
        public ProductsController(ILogger<ProductsController> logger, ProductLogic productLogic, IValidator<Product> validator)
        {
            _logger = logger;
            _productLogic = productLogic;
            _validator = validator;
        }

        #endregion Constructors

        #region API

        /// <summary>
        /// Gets Products
        /// </summary>
        /// <returns>List of products</returns>
        [HttpGet(Name = "GetProducts")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(IEnumerable<Product>), 200)]
        public IActionResult Get()
        {
            return new JsonResult(_productLogic.ObtainProducts());
        }

        /// <summary>
        /// Creates a product
        /// </summary>
        /// <param name="product">Product.</param>
        /// <returns>Product</returns>
        [HttpPost(Name = "PostProduct")]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(Product), 200)]
        [ProducesResponseType(typeof(APIError), 400)]
        public IActionResult Post([FromBody] Product product)
        {
            var validationResult = _validator.Validate(product);

            if (validationResult is not null && !validationResult.IsValid)
                return new JsonResult(new APIError
                {
                    Entity = JsonSerializer.Serialize(product),
                    Errors = (from err in validationResult.Errors
                              select err.ErrorMessage).ToList()
                })
                {
                    StatusCode = StatusCodes.Status400BadRequest
                };

            return new JsonResult(_productLogic.CreateProduct(product));
        }

        #endregion API
    }
}