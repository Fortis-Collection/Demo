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
using Fortis.Search;
using Fortis.Model;
using Demo.Model.Templates.UserDefined;

namespace Demo.Content.Controllers
{
	public class CallToActionController : Controller
	{
		protected readonly ISearchManager SearchManager;
		protected readonly IItemSearchFactory ItemSearchFactory;
		protected readonly IItemFactory ItemFactory;

		public CallToActionController(ISearchManager searchManager, IItemSearchFactory itemSearchFactory, IItemFactory itemFactory)
		{
			SearchManager = searchManager;
			ItemSearchFactory = itemSearchFactory;
			ItemFactory = itemFactory;
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

		public CallToActionListModel CreateModel()
		{
			var renderingContext = ItemFactory.GetRenderingContextItems<IItemWrapper, IItemWrapper, ICallToActionListOptions>();
			var tags = renderingContext.RenderingParametersItem.Tags.Value;
			var phrase = renderingContext.RenderingParametersItem.Heading.GetTarget<ITextPhrase>();
			var searchResults = Enumerable.Empty<ICallToAction>();

			using (var searchContext = SearchManager.SearchContext)
			{
				var searchQueryable = ItemSearchFactory.FilteredSearch<ICallToAction>(searchContext.GetQueryable<ICallToAction>());

				searchResults = searchQueryable.ContainsOr(item => item.TagsValue, tags).ToList();
			}

			var model = new CallToActionListModel
			{
				CallToActions = searchResults,
				Header = phrase
			};

			return model;
		}
	}
}
