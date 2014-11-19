using Demo.Content.Models;
using Demo.Content.Extensions;
using Rocketcore.Search;
using Sitecore.ContentSearch;
using Sitecore.ContentSearch.Linq;
using Sitecore.ContentSearch.Linq.Utilities;
using Sitecore.ContentSearch.SearchTypes;
using Sitecore.ContentSearch.Utilities;
using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Demo.Content.Controllers
{
	public class CallToActionController : Controller
	{
		protected readonly ISearchManager SearchManager;

		public CallToActionController(ISearchManager searchManager)
		{
			SearchManager = searchManager;
		}

		public ViewResult CallToActionHeroSlider()
		{
			var model = CreateModel();

			return View(model);
		}

		public ViewResult CallToActionList()
		{
			var model = CreateModel();

			return View(model);
		}

		public IEnumerable<ID> GetTags(RenderingParameters renderingParameters)
		{
			return renderingParameters["tags"].Split('|').Select(id => new ID(id));
		}

		public CallToActionListModel CreateModel()
		{
			var tags = GetTags(RenderingContext.Current.Rendering.Parameters);
			var searchResults = Enumerable.Empty<SearchResultItem>();

			using (var searchContext = SearchManager.SearchContext)
			{
				var searchQueryable = searchContext.GetQueryable<SearchResultItem>();

				searchResults = searchQueryable.Where(item => item.TemplateId == new ID("{30683BF7-4B2E-443F-9C4C-1DAABB2962C2}"))
											   .FilterByTags(tags)
											   .ToList();
			}

			var model = new CallToActionListModel
			{
				CallToActions = searchResults.Select(item => item.GetItem())
			};

			return model;
		}
	}
}
