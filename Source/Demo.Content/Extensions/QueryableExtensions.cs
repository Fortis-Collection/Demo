using Sitecore.ContentSearch.Linq;
using Sitecore.ContentSearch.Linq.Utilities;
using Sitecore.ContentSearch.SearchTypes;
using Sitecore.ContentSearch.Utilities;
using Sitecore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Content.Extensions
{
	public static class QueryableExtensions
	{
		public static IQueryable<SearchResultItem> FilterByTags(this IQueryable<SearchResultItem> searchQueryable, IEnumerable<ID> ids)
		{
			var predicate = PredicateBuilder.True<SearchResultItem>();

			predicate = ids.Aggregate(predicate, (current, id) => current.Or(p => p["tags"] == IdHelper.NormalizeGuid(id)));

			return searchQueryable.Filter(predicate);
		}
	}
}
