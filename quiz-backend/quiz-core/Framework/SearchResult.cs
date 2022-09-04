using System.Collections.Generic;

namespace quiz_core.Framework
{
    /// <summary>
    /// Base class for search results.
    /// </summary>
    /// <typeparam name="TModel">Type of the individual items.</typeparam>
    public class SearchResult<TModel>
    {
        /// <summary>
        /// Gets or sets the total count of items corresponding to the search criteria.
        /// </summary>
        public int TotalCount { get; set; }

        /// <summary>
        /// Gets or sets the actual items in this page.
        /// </summary>
        public IEnumerable<TModel> Items { get; set; }
    }
}
