namespace DarthSeldon.API.FluentValidation.Demo.Records
{
    /// <summary>
    /// Product
    /// </summary>
    /// <seealso cref="System.IEquatable&lt;DarthSeldon.API.FluentValidation.Demo.Records.Product&gt;" />
    public record Product
    {
        #region Properties

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// Identifier.
        /// </value>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// Name.
        /// </value>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// Description.
        /// </value>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// Price.
        /// </value>
        public decimal Price { get; set; }

        #endregion Properties
    }
}