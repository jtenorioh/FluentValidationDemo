namespace DarthSeldon.API.FluentValidation.Demo.Records
{
    /// <summary>
    /// API Error
    /// </summary>
    /// <seealso cref="System.IEquatable&lt;DarthSeldon.API.FluentValidation.Demo.Records.APIError&gt;" />
    public record APIError
    {
        #region Properties

        /// <summary>
        /// Gets or sets the entity.
        /// </summary>
        /// <value>
        /// The entity.
        /// </value>
        public string Entity { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the errors.
        /// </summary>
        /// <value>
        /// The errors.
        /// </value>
        public List<string>? Errors { get; set; }

        #endregion Properties
    }
}