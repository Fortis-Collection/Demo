#region Call To Action Slider Options (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

    using Fortis.Model.RenderingParameters;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Call To Action Slider Options</para>
	/// <para>ID: {02E4436F-437E-4297-B819-6334F1F560AF}</para>
	/// <para>/sitecore/templates/User Defined/Call To Action/Rendering Options/Call To Action Slider Options</para>
	/// </summary>
	//[Rocketcore.Search.PredefinedQuery("TemplateId", ComparisonType.Equal, "{02E4436F-437E-4297-B819-6334F1F560AF}", typeof(Guid))]
	[TemplateMapping("{02E4436F-437E-4297-B819-6334F1F560AF}", "InterfaceRenderingParameter")]
	public partial interface ICallToActionSliderOptions : IRenderingParameterWrapper , Demo.Model.Templates.UserDefined.ICallToActionLinksOptions
	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Call To Action/Rendering Options/Call To Action Slider Options</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{02E4436F-437E-4297-B819-6334F1F560AF}", typeof(Guid))]
	[TemplateMapping("{02E4436F-437E-4297-B819-6334F1F560AF}", "RenderingParameter")]
	public partial class CallToActionSliderOptions : RenderingParameterWrapper, ICallToActionSliderOptions
	{
		public CallToActionSliderOptions(Dictionary<string, string> parameters, ISpawnProvider spawnProvider) : base(parameters, spawnProvider)
		{
		}

		/// <summary><para>Template: Call To Action Slider Options</para><para>Field: CallToActionGroup</para><para>Data type: Droptree</para></summary>
		public virtual ILinkFieldWrapper CallToActionGroup
		{
			get { return (Fortis.Model.RenderingParameters.Fields.LinkFieldWrapper)GetField("Call To Action Group", "droptree"); }
		}

		/// <summary><para>Template: Call To Action Slider Options</para><para>Field: CallToActionGroup</para><para>Data type: Droptree</para></summary>
 		public string CallToActionGroupValue
		{
			get { return CallToActionGroup.Value; }
		}
		/// <summary><para>Template: Call To Action Slider Options</para><para>Field: SelectionMethod</para><para>Data type: Droplink</para></summary>
		public virtual ILinkFieldWrapper SelectionMethod
		{
			get { return (Fortis.Model.RenderingParameters.Fields.LinkFieldWrapper)GetField("Selection Method", "droplink"); }
		}

		/// <summary><para>Template: Call To Action Slider Options</para><para>Field: SelectionMethod</para><para>Data type: Droplink</para></summary>
 		public string SelectionMethodValue
		{
			get { return SelectionMethod.Value; }
		}
		/// <summary><para>Template: Call To Action Slider Options</para><para>Field: AggregateBy</para><para>Data type: Droplink</para></summary>
		public virtual ILinkFieldWrapper AggregateBy
		{
			get { return (Fortis.Model.RenderingParameters.Fields.LinkFieldWrapper)GetField("Aggregate By", "droplink"); }
		}

		/// <summary><para>Template: Call To Action Slider Options</para><para>Field: AggregateBy</para><para>Data type: Droplink</para></summary>
 		public string AggregateByValue
		{
			get { return AggregateBy.Value; }
		}
		/// <summary><para>Template: Call To Action Slider Options</para><para>Field: GroupTagsBy</para><para>Data type: Droplink</para></summary>
		public virtual ILinkFieldWrapper GroupTagsBy
		{
			get { return (Fortis.Model.RenderingParameters.Fields.LinkFieldWrapper)GetField("Group Tags By", "droplink"); }
		}

		/// <summary><para>Template: Call To Action Slider Options</para><para>Field: GroupTagsBy</para><para>Data type: Droplink</para></summary>
 		public string GroupTagsByValue
		{
			get { return GroupTagsBy.Value; }
		}
		/// <summary><para>Template: Call To Action Slider Options</para><para>Field: Tags</para><para>Data type: Tags</para></summary>
		public virtual IListFieldWrapper Tags
		{
			get { return (Fortis.Model.RenderingParameters.Fields.ListFieldWrapper)GetField("Tags", "tags"); }
		}

		/// <summary><para>Template: Call To Action Slider Options</para><para>Field: Tags</para><para>Data type: Tags</para></summary>
 		public IEnumerable<Guid> TagsValue
		{
			get { return Tags.Value; }
		}
		/// <summary><para>Template: Call To Action Slider Options</para><para>Field: OrderBy</para><para>Data type: Droplink</para></summary>
		public virtual ILinkFieldWrapper OrderBy
		{
			get { return (Fortis.Model.RenderingParameters.Fields.LinkFieldWrapper)GetField("Order By", "droplink"); }
		}

		/// <summary><para>Template: Call To Action Slider Options</para><para>Field: OrderBy</para><para>Data type: Droplink</para></summary>
 		public string OrderByValue
		{
			get { return OrderBy.Value; }
		}
		/// <summary><para>Template: Call To Action Slider Options</para><para>Field: OrderDirection</para><para>Data type: Droplink</para></summary>
		public virtual ILinkFieldWrapper OrderDirection
		{
			get { return (Fortis.Model.RenderingParameters.Fields.LinkFieldWrapper)GetField("Order Direction", "droplink"); }
		}

		/// <summary><para>Template: Call To Action Slider Options</para><para>Field: OrderDirection</para><para>Data type: Droplink</para></summary>
 		public string OrderDirectionValue
		{
			get { return OrderDirection.Value; }
		}
		/// <summary><para>Template: Call To Action Slider Options</para><para>Field: ItemsPerPage</para><para>Data type: Integer</para></summary>
		public virtual IIntegerFieldWrapper ItemsPerPage
		{
			get { return (Fortis.Model.RenderingParameters.Fields.IntegerFieldWrapper)GetField("Items Per Page", "integer"); }
		}

		/// <summary><para>Template: Call To Action Slider Options</para><para>Field: ItemsPerPage</para><para>Data type: Integer</para></summary>
 		public long ItemsPerPageValue
		{
			get { return ItemsPerPage.Value; }
		}
		/// <summary><para>Template: Call To Action Slider Options</para><para>Field: Heading</para><para>Data type: Droptree</para></summary>
		public virtual ILinkFieldWrapper Heading
		{
			get { return (Fortis.Model.RenderingParameters.Fields.LinkFieldWrapper)GetField("Heading", "droptree"); }
		}

		/// <summary><para>Template: Call To Action Slider Options</para><para>Field: Heading</para><para>Data type: Droptree</para></summary>
 		public string HeadingValue
		{
			get { return Heading.Value; }
		}
	
	}
}
#endregion
#region Call To Action Override (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;


	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Call To Action Override</para>
	/// <para>ID: {12BBD87B-1EE2-4E02-86F5-5AB1DA50307C}</para>
	/// <para>/sitecore/templates/User Defined/Call To Action/Call To Action Override</para>
	/// </summary>
	//[Rocketcore.Search.PredefinedQuery("TemplateId", ComparisonType.Equal, "{12BBD87B-1EE2-4E02-86F5-5AB1DA50307C}", typeof(Guid))]
	[TemplateMapping("{12BBD87B-1EE2-4E02-86F5-5AB1DA50307C}", "InterfaceMap")]
	public partial interface ICallToActionOverride : IItemWrapper , Demo.Model.Templates.UserDefined.IRocketcoreStandardTemplate, Demo.Model.Templates.UserDefined.ICallToAction
	{		
    	/// <summary>
		/// <para>Template: Call To Action Override</para><para>Field: CallToActionCustom</para><para>Data type: Droptree</para>
        /// </summary>
		[IndexField("call_to_action_custom")]
		ILinkFieldWrapper CallToActionCustom { get; }

    	/// <summary>
		/// <para>Template: Call To Action Override</para><para>Field: CallToActionCustom</para><para>Data type: Droptree</para>
        /// </summary>
		[IndexField("call_to_action_custom")]
 		string CallToActionCustomValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Call To Action/Call To Action Override</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{12BBD87B-1EE2-4E02-86F5-5AB1DA50307C}", typeof(Guid))]
	[TemplateMapping("{12BBD87B-1EE2-4E02-86F5-5AB1DA50307C}", "")]
	public partial class CallToActionOverride : ItemWrapper, ICallToActionOverride
	{
		private Item _item = null;

		public CallToActionOverride(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public CallToActionOverride(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public CallToActionOverride(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public CallToActionOverride(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Call To Action Override</para><para>Field: Tags</para><para>Data type: Tags</para></summary>
		[IndexField("tags_sm")]
		public virtual IListFieldWrapper Tags
		{
			get { return GetField<ListFieldWrapper>("Tags", "tags"); }
		}

		/// <summary><para>Template: Call To Action Override</para><para>Field: Tags</para><para>Data type: Tags</para></summary>
		[IndexField("tags")]
 		public IEnumerable<Guid> TagsValue
		{
			get { return Tags.Value; }
		}
		/// <summary><para>Template: Call To Action Override</para><para>Field: SubTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("sub_title_t")]
		public virtual ITextFieldWrapper SubTitle
		{
			get { return GetField<TextFieldWrapper>("Sub Title", "sub_title"); }
		}

		/// <summary><para>Template: Call To Action Override</para><para>Field: SubTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("sub_title")]
 		public string SubTitleValue
		{
			get { return SubTitle.Value; }
		}
		/// <summary><para>Template: Call To Action Override</para><para>Field: Title</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("title_t")]
		public virtual ITextFieldWrapper Title
		{
			get { return GetField<TextFieldWrapper>("Title", "title"); }
		}

		/// <summary><para>Template: Call To Action Override</para><para>Field: Title</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("title")]
 		public string TitleValue
		{
			get { return Title.Value; }
		}
		/// <summary><para>Template: Call To Action Override</para><para>Field: Body</para><para>Data type: Rich Text</para></summary>
		[IndexField("body_t")]
		public virtual IRichTextFieldWrapper Body
		{
			get { return GetField<RichTextFieldWrapper>("Body", "body"); }
		}

		/// <summary><para>Template: Call To Action Override</para><para>Field: Body</para><para>Data type: Rich Text</para></summary>
		[IndexField("body")]
 		public string BodyValue
		{
			get { return Body.Value; }
		}
		/// <summary><para>Template: Call To Action Override</para><para>Field: Image</para><para>Data type: Image</para></summary>
		public virtual IImageFieldWrapper Image
		{
			get { return GetField<ImageFieldWrapper>("Image"); }
		}

		/// <summary><para>Template: Call To Action Override</para><para>Field: Image</para><para>Data type: Image</para></summary>
 		public string ImageValue
		{
			get { return Image.Value; }
		}
		/// <summary><para>Template: Call To Action Override</para><para>Field: DateAndTime</para><para>Data type: Datetime</para></summary>
		[IndexField("date_and_time_tdt")]
		public virtual IDateTimeFieldWrapper DateAndTime
		{
			get { return GetField<DateTimeFieldWrapper>("Date And Time", "date_and_time"); }
		}

		/// <summary><para>Template: Call To Action Override</para><para>Field: DateAndTime</para><para>Data type: Datetime</para></summary>
		[IndexField("date_and_time")]
 		public DateTime DateAndTimeValue
		{
			get { return DateAndTime.Value; }
		}
		/// <summary><para>Template: Call To Action Override</para><para>Field: CallToActionCustom</para><para>Data type: Droptree</para></summary>
		[IndexField("call_to_action_custom_s")]
		public virtual ILinkFieldWrapper CallToActionCustom
		{
			get { return GetField<LinkFieldWrapper>("Call To Action Custom", "call_to_action_custom"); }
		}

		/// <summary><para>Template: Call To Action Override</para><para>Field: CallToActionCustom</para><para>Data type: Droptree</para></summary>
		[IndexField("call_to_action_custom")]
 		public string CallToActionCustomValue
		{
			get { return CallToActionCustom.Value; }
		}
	
	}
}
#endregion
#region Size Options (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

    using Fortis.Model.RenderingParameters;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Size Options</para>
	/// <para>ID: {165CD2BE-7EE4-4D06-ABBA-4BBAC6EFEE7D}</para>
	/// <para>/sitecore/templates/User Defined/Global/Presentation/Rendering Options/Size Options</para>
	/// </summary>
	//[Rocketcore.Search.PredefinedQuery("TemplateId", ComparisonType.Equal, "{165CD2BE-7EE4-4D06-ABBA-4BBAC6EFEE7D}", typeof(Guid))]
	[TemplateMapping("{165CD2BE-7EE4-4D06-ABBA-4BBAC6EFEE7D}", "InterfaceRenderingParameter")]
	public partial interface ISizeOptions : IRenderingParameterWrapper , Demo.Model.Templates.UserDefined.IRocketcoreRenderingParameters
	{		
    	/// <summary>
		/// <para>Template: Size Options</para><para>Field: Height</para><para>Data type: Integer</para>
        /// </summary>
		IIntegerFieldWrapper Height { get; }
 		long HeightValue { get; }
    	/// <summary>
		/// <para>Template: Size Options</para><para>Field: Width</para><para>Data type: Integer</para>
        /// </summary>
		IIntegerFieldWrapper Width { get; }
 		long WidthValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Global/Presentation/Rendering Options/Size Options</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{165CD2BE-7EE4-4D06-ABBA-4BBAC6EFEE7D}", typeof(Guid))]
	[TemplateMapping("{165CD2BE-7EE4-4D06-ABBA-4BBAC6EFEE7D}", "RenderingParameter")]
	public partial class SizeOptions : RenderingParameterWrapper, ISizeOptions
	{
		public SizeOptions(Dictionary<string, string> parameters, ISpawnProvider spawnProvider) : base(parameters, spawnProvider)
		{
		}

		/// <summary><para>Template: Size Options</para><para>Field: Height</para><para>Data type: Integer</para></summary>
		public virtual IIntegerFieldWrapper Height
		{
			get { return (Fortis.Model.RenderingParameters.Fields.IntegerFieldWrapper)GetField("Height", "integer"); }
		}

		/// <summary><para>Template: Size Options</para><para>Field: Height</para><para>Data type: Integer</para></summary>
 		public long HeightValue
		{
			get { return Height.Value; }
		}
		/// <summary><para>Template: Size Options</para><para>Field: Width</para><para>Data type: Integer</para></summary>
		public virtual IIntegerFieldWrapper Width
		{
			get { return (Fortis.Model.RenderingParameters.Fields.IntegerFieldWrapper)GetField("Width", "integer"); }
		}

		/// <summary><para>Template: Size Options</para><para>Field: Width</para><para>Data type: Integer</para></summary>
 		public long WidthValue
		{
			get { return Width.Value; }
		}
	
	}
}
#endregion
#region Call To Action Folder (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;


	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Call To Action Folder</para>
	/// <para>ID: {1ADCF820-3A3E-45BA-A66B-9470B1FD9E6F}</para>
	/// <para>/sitecore/templates/User Defined/Call To Action/Call To Action Folder</para>
	/// </summary>
	//[Rocketcore.Search.PredefinedQuery("TemplateId", ComparisonType.Equal, "{1ADCF820-3A3E-45BA-A66B-9470B1FD9E6F}", typeof(Guid))]
	[TemplateMapping("{1ADCF820-3A3E-45BA-A66B-9470B1FD9E6F}", "InterfaceMap")]
	public partial interface ICallToActionFolder : IItemWrapper , Demo.Model.Templates.UserDefined.IRocketcoreFolder
	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Call To Action/Call To Action Folder</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{1ADCF820-3A3E-45BA-A66B-9470B1FD9E6F}", typeof(Guid))]
	[TemplateMapping("{1ADCF820-3A3E-45BA-A66B-9470B1FD9E6F}", "")]
	public partial class CallToActionFolder : ItemWrapper, ICallToActionFolder
	{
		private Item _item = null;

		public CallToActionFolder(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public CallToActionFolder(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public CallToActionFolder(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public CallToActionFolder(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

	
	}
}
#endregion
#region Content Page (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;


	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Content Page</para>
	/// <para>ID: {23D17BB0-08BC-43D7-8589-7724407E1422}</para>
	/// <para>/sitecore/templates/User Defined/Generic/Content Page</para>
	/// </summary>
	//[Rocketcore.Search.PredefinedQuery("TemplateId", ComparisonType.Equal, "{23D17BB0-08BC-43D7-8589-7724407E1422}", typeof(Guid))]
	[TemplateMapping("{23D17BB0-08BC-43D7-8589-7724407E1422}", "InterfaceMap")]
	public partial interface IContentPage : IItemWrapper , Demo.Model.Templates.UserDefined.IPage, Demo.Model.Templates.UserDefined.IContentHeadings, Demo.Model.Templates.UserDefined.IContentDateTime, Demo.Model.Templates.UserDefined.IContentBody, Demo.Model.Templates.UserDefined.IContentImage, Demo.Model.Templates.UserDefined.ICallToActionOverride
	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Generic/Content Page</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{23D17BB0-08BC-43D7-8589-7724407E1422}", typeof(Guid))]
	[TemplateMapping("{23D17BB0-08BC-43D7-8589-7724407E1422}", "")]
	public partial class ContentPage : ItemWrapper, IContentPage
	{
		private Item _item = null;

		public ContentPage(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public ContentPage(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public ContentPage(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public ContentPage(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Content Page</para><para>Field: Description</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("description_t")]
		public virtual ITextFieldWrapper Description
		{
			get { return GetField<TextFieldWrapper>("Description", "description"); }
		}

		/// <summary><para>Template: Content Page</para><para>Field: Description</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("description")]
 		public string DescriptionValue
		{
			get { return Description.Value; }
		}
		/// <summary><para>Template: Content Page</para><para>Field: Keywords</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("keywords_t")]
		public virtual ITextFieldWrapper Keywords
		{
			get { return GetField<TextFieldWrapper>("Keywords", "keywords"); }
		}

		/// <summary><para>Template: Content Page</para><para>Field: Keywords</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("keywords")]
 		public string KeywordsValue
		{
			get { return Keywords.Value; }
		}
		/// <summary><para>Template: Content Page</para><para>Field: PageTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("page_title_t")]
		public virtual ITextFieldWrapper PageTitle
		{
			get { return GetField<TextFieldWrapper>("Page Title", "page_title"); }
		}

		/// <summary><para>Template: Content Page</para><para>Field: PageTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("page_title")]
 		public string PageTitleValue
		{
			get { return PageTitle.Value; }
		}
		/// <summary><para>Template: Content Page</para><para>Field: BreadcrumbTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("breadcrumb_title_t")]
		public virtual ITextFieldWrapper BreadcrumbTitle
		{
			get { return GetField<TextFieldWrapper>("Breadcrumb Title", "breadcrumb_title"); }
		}

		/// <summary><para>Template: Content Page</para><para>Field: BreadcrumbTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("breadcrumb_title")]
 		public string BreadcrumbTitleValue
		{
			get { return BreadcrumbTitle.Value; }
		}
		/// <summary><para>Template: Content Page</para><para>Field: HideFromBreadcrumb</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_breadcrumb_b")]
		public virtual IBooleanFieldWrapper HideFromBreadcrumb
		{
			get { return GetField<BooleanFieldWrapper>("Hide From Breadcrumb", "hide_from_breadcrumb"); }
		}

		/// <summary><para>Template: Content Page</para><para>Field: HideFromBreadcrumb</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_breadcrumb")]
 		public bool HideFromBreadcrumbValue
		{
			get { return HideFromBreadcrumb.Value; }
		}
		/// <summary><para>Template: Content Page</para><para>Field: HideFromNavigation</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_navigation_b")]
		public virtual IBooleanFieldWrapper HideFromNavigation
		{
			get { return GetField<BooleanFieldWrapper>("Hide From Navigation", "hide_from_navigation"); }
		}

		/// <summary><para>Template: Content Page</para><para>Field: HideFromNavigation</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_navigation")]
 		public bool HideFromNavigationValue
		{
			get { return HideFromNavigation.Value; }
		}
		/// <summary><para>Template: Content Page</para><para>Field: NavigationTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("navigation_title_t")]
		public virtual ITextFieldWrapper NavigationTitle
		{
			get { return GetField<TextFieldWrapper>("Navigation Title", "navigation_title"); }
		}

		/// <summary><para>Template: Content Page</para><para>Field: NavigationTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("navigation_title")]
 		public string NavigationTitleValue
		{
			get { return NavigationTitle.Value; }
		}
		/// <summary><para>Template: Content Page</para><para>Field: Tags</para><para>Data type: Tags</para></summary>
		[IndexField("tags_sm")]
		public virtual IListFieldWrapper Tags
		{
			get { return GetField<ListFieldWrapper>("Tags", "tags"); }
		}

		/// <summary><para>Template: Content Page</para><para>Field: Tags</para><para>Data type: Tags</para></summary>
		[IndexField("tags")]
 		public IEnumerable<Guid> TagsValue
		{
			get { return Tags.Value; }
		}
		/// <summary><para>Template: Content Page</para><para>Field: SubTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("sub_title_t")]
		public virtual ITextFieldWrapper SubTitle
		{
			get { return GetField<TextFieldWrapper>("Sub Title", "sub_title"); }
		}

		/// <summary><para>Template: Content Page</para><para>Field: SubTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("sub_title")]
 		public string SubTitleValue
		{
			get { return SubTitle.Value; }
		}
		/// <summary><para>Template: Content Page</para><para>Field: Title</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("title_t")]
		public virtual ITextFieldWrapper Title
		{
			get { return GetField<TextFieldWrapper>("Title", "title"); }
		}

		/// <summary><para>Template: Content Page</para><para>Field: Title</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("title")]
 		public string TitleValue
		{
			get { return Title.Value; }
		}
		/// <summary><para>Template: Content Page</para><para>Field: DateAndTime</para><para>Data type: Datetime</para></summary>
		[IndexField("date_and_time_tdt")]
		public virtual IDateTimeFieldWrapper DateAndTime
		{
			get { return GetField<DateTimeFieldWrapper>("Date And Time", "date_and_time"); }
		}

		/// <summary><para>Template: Content Page</para><para>Field: DateAndTime</para><para>Data type: Datetime</para></summary>
		[IndexField("date_and_time")]
 		public DateTime DateAndTimeValue
		{
			get { return DateAndTime.Value; }
		}
		/// <summary><para>Template: Content Page</para><para>Field: Body</para><para>Data type: Rich Text</para></summary>
		[IndexField("body_t")]
		public virtual IRichTextFieldWrapper Body
		{
			get { return GetField<RichTextFieldWrapper>("Body", "body"); }
		}

		/// <summary><para>Template: Content Page</para><para>Field: Body</para><para>Data type: Rich Text</para></summary>
		[IndexField("body")]
 		public string BodyValue
		{
			get { return Body.Value; }
		}
		/// <summary><para>Template: Content Page</para><para>Field: Image</para><para>Data type: Image</para></summary>
		public virtual IImageFieldWrapper Image
		{
			get { return GetField<ImageFieldWrapper>("Image"); }
		}

		/// <summary><para>Template: Content Page</para><para>Field: Image</para><para>Data type: Image</para></summary>
 		public string ImageValue
		{
			get { return Image.Value; }
		}
		/// <summary><para>Template: Content Page</para><para>Field: CallToActionCustom</para><para>Data type: Droptree</para></summary>
		[IndexField("call_to_action_custom_s")]
		public virtual ILinkFieldWrapper CallToActionCustom
		{
			get { return GetField<LinkFieldWrapper>("Call To Action Custom", "call_to_action_custom"); }
		}

		/// <summary><para>Template: Content Page</para><para>Field: CallToActionCustom</para><para>Data type: Droptree</para></summary>
		[IndexField("call_to_action_custom")]
 		public string CallToActionCustomValue
		{
			get { return CallToActionCustom.Value; }
		}
	
	}
}
#endregion
#region Ordering Options (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

    using Fortis.Model.RenderingParameters;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Ordering Options</para>
	/// <para>ID: {265AA3E1-31EF-4CAC-AC52-FF7061EBD714}</para>
	/// <para>/sitecore/templates/User Defined/Global/Presentation/Rendering Options/Ordering Options</para>
	/// </summary>
	//[Rocketcore.Search.PredefinedQuery("TemplateId", ComparisonType.Equal, "{265AA3E1-31EF-4CAC-AC52-FF7061EBD714}", typeof(Guid))]
	[TemplateMapping("{265AA3E1-31EF-4CAC-AC52-FF7061EBD714}", "InterfaceRenderingParameter")]
	public partial interface IOrderingOptions : IRenderingParameterWrapper , Demo.Model.Templates.UserDefined.IRocketcoreRenderingParameters
	{		
    	/// <summary>
		/// <para>Template: Ordering Options</para><para>Field: OrderBy</para><para>Data type: Droplink</para>
        /// </summary>
		ILinkFieldWrapper OrderBy { get; }
 		string OrderByValue { get; }
    	/// <summary>
		/// <para>Template: Ordering Options</para><para>Field: OrderDirection</para><para>Data type: Droplink</para>
        /// </summary>
		ILinkFieldWrapper OrderDirection { get; }
 		string OrderDirectionValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Global/Presentation/Rendering Options/Ordering Options</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{265AA3E1-31EF-4CAC-AC52-FF7061EBD714}", typeof(Guid))]
	[TemplateMapping("{265AA3E1-31EF-4CAC-AC52-FF7061EBD714}", "RenderingParameter")]
	public partial class OrderingOptions : RenderingParameterWrapper, IOrderingOptions
	{
		public OrderingOptions(Dictionary<string, string> parameters, ISpawnProvider spawnProvider) : base(parameters, spawnProvider)
		{
		}

		/// <summary><para>Template: Ordering Options</para><para>Field: OrderBy</para><para>Data type: Droplink</para></summary>
		public virtual ILinkFieldWrapper OrderBy
		{
			get { return (Fortis.Model.RenderingParameters.Fields.LinkFieldWrapper)GetField("Order By", "droplink"); }
		}

		/// <summary><para>Template: Ordering Options</para><para>Field: OrderBy</para><para>Data type: Droplink</para></summary>
 		public string OrderByValue
		{
			get { return OrderBy.Value; }
		}
		/// <summary><para>Template: Ordering Options</para><para>Field: OrderDirection</para><para>Data type: Droplink</para></summary>
		public virtual ILinkFieldWrapper OrderDirection
		{
			get { return (Fortis.Model.RenderingParameters.Fields.LinkFieldWrapper)GetField("Order Direction", "droplink"); }
		}

		/// <summary><para>Template: Ordering Options</para><para>Field: OrderDirection</para><para>Data type: Droplink</para></summary>
 		public string OrderDirectionValue
		{
			get { return OrderDirection.Value; }
		}
	
	}
}
#endregion
#region Navigation Link (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;


	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Navigation Link</para>
	/// <para>ID: {2FCB8A5D-40D4-4E11-B904-8D4A1A08612D}</para>
	/// <para>/sitecore/templates/User Defined/Navigation/Navigation Link</para>
	/// </summary>
	//[Rocketcore.Search.PredefinedQuery("TemplateId", ComparisonType.Equal, "{2FCB8A5D-40D4-4E11-B904-8D4A1A08612D}", typeof(Guid))]
	[TemplateMapping("{2FCB8A5D-40D4-4E11-B904-8D4A1A08612D}", "InterfaceMap")]
	public partial interface INavigationLink : IItemWrapper , Demo.Model.Templates.UserDefined.INavigation
	{		
    	/// <summary>
		/// <para>Template: Navigation Link</para><para>Field: Link</para><para>Data type: General Link</para>
        /// </summary>
		[IndexField("link")]
		IGeneralLinkFieldWrapper Link { get; }

    	/// <summary>
		/// <para>Template: Navigation Link</para><para>Field: Link</para><para>Data type: General Link</para>
        /// </summary>
		[IndexField("link")]
 		string LinkValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Navigation/Navigation Link</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{2FCB8A5D-40D4-4E11-B904-8D4A1A08612D}", typeof(Guid))]
	[TemplateMapping("{2FCB8A5D-40D4-4E11-B904-8D4A1A08612D}", "")]
	public partial class NavigationLink : ItemWrapper, INavigationLink
	{
		private Item _item = null;

		public NavigationLink(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public NavigationLink(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public NavigationLink(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public NavigationLink(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Navigation Link</para><para>Field: HideFromNavigation</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_navigation_b")]
		public virtual IBooleanFieldWrapper HideFromNavigation
		{
			get { return GetField<BooleanFieldWrapper>("Hide From Navigation", "hide_from_navigation"); }
		}

		/// <summary><para>Template: Navigation Link</para><para>Field: HideFromNavigation</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_navigation")]
 		public bool HideFromNavigationValue
		{
			get { return HideFromNavigation.Value; }
		}
		/// <summary><para>Template: Navigation Link</para><para>Field: NavigationTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("navigation_title_t")]
		public virtual ITextFieldWrapper NavigationTitle
		{
			get { return GetField<TextFieldWrapper>("Navigation Title", "navigation_title"); }
		}

		/// <summary><para>Template: Navigation Link</para><para>Field: NavigationTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("navigation_title")]
 		public string NavigationTitleValue
		{
			get { return NavigationTitle.Value; }
		}
		/// <summary><para>Template: Navigation Link</para><para>Field: Link</para><para>Data type: General Link</para></summary>
		[IndexField("link_t")]
		public virtual IGeneralLinkFieldWrapper Link
		{
			get { return GetField<GeneralLinkFieldWrapper>("Link", "link"); }
		}

		/// <summary><para>Template: Navigation Link</para><para>Field: Link</para><para>Data type: General Link</para></summary>
		[IndexField("link")]
 		public string LinkValue
		{
			get { return Link.Value; }
		}
	
	}
}
#endregion
#region Rocketcore Folder (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;


	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Rocketcore Folder</para>
	/// <para>ID: {306135B9-51D1-476B-8429-A717EC6DA037}</para>
	/// <para>/sitecore/templates/User Defined/Rocketcore/Rocketcore Folder</para>
	/// </summary>
	//[Rocketcore.Search.PredefinedQuery("TemplateId", ComparisonType.Equal, "{306135B9-51D1-476B-8429-A717EC6DA037}", typeof(Guid))]
	[TemplateMapping("{306135B9-51D1-476B-8429-A717EC6DA037}", "InterfaceMap")]
	public partial interface IRocketcoreFolder : IItemWrapper , Demo.Model.Templates.UserDefined.IRocketcorePermissions
	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Rocketcore/Rocketcore Folder</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{306135B9-51D1-476B-8429-A717EC6DA037}", typeof(Guid))]
	[TemplateMapping("{306135B9-51D1-476B-8429-A717EC6DA037}", "")]
	public partial class RocketcoreFolder : ItemWrapper, IRocketcoreFolder
	{
		private Item _item = null;

		public RocketcoreFolder(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public RocketcoreFolder(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public RocketcoreFolder(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public RocketcoreFolder(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

	
	}
}
#endregion
#region Call To Action Target (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;


	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Call To Action Target</para>
	/// <para>ID: {30683BF7-4B2E-443F-9C4C-1DAABB2962C2}</para>
	/// <para>/sitecore/templates/User Defined/Call To Action/Call To Action Target</para>
	/// </summary>
	//[Rocketcore.Search.PredefinedQuery("TemplateId", ComparisonType.Equal, "{30683BF7-4B2E-443F-9C4C-1DAABB2962C2}", typeof(Guid))]
	[TemplateMapping("{30683BF7-4B2E-443F-9C4C-1DAABB2962C2}", "InterfaceMap")]
	public partial interface ICallToActionTarget : IItemWrapper , Demo.Model.Templates.UserDefined.IRocketcoreStandardTemplate, Demo.Model.Templates.UserDefined.ICallToAction, Demo.Model.Templates.UserDefined.INavigationLink
	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Call To Action/Call To Action Target</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{30683BF7-4B2E-443F-9C4C-1DAABB2962C2}", typeof(Guid))]
	[TemplateMapping("{30683BF7-4B2E-443F-9C4C-1DAABB2962C2}", "")]
	public partial class CallToActionTarget : ItemWrapper, ICallToActionTarget
	{
		private Item _item = null;

		public CallToActionTarget(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public CallToActionTarget(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public CallToActionTarget(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public CallToActionTarget(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Call To Action Target</para><para>Field: Tags</para><para>Data type: Tags</para></summary>
		[IndexField("tags_sm")]
		public virtual IListFieldWrapper Tags
		{
			get { return GetField<ListFieldWrapper>("Tags", "tags"); }
		}

		/// <summary><para>Template: Call To Action Target</para><para>Field: Tags</para><para>Data type: Tags</para></summary>
		[IndexField("tags")]
 		public IEnumerable<Guid> TagsValue
		{
			get { return Tags.Value; }
		}
		/// <summary><para>Template: Call To Action Target</para><para>Field: SubTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("sub_title_t")]
		public virtual ITextFieldWrapper SubTitle
		{
			get { return GetField<TextFieldWrapper>("Sub Title", "sub_title"); }
		}

		/// <summary><para>Template: Call To Action Target</para><para>Field: SubTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("sub_title")]
 		public string SubTitleValue
		{
			get { return SubTitle.Value; }
		}
		/// <summary><para>Template: Call To Action Target</para><para>Field: Title</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("title_t")]
		public virtual ITextFieldWrapper Title
		{
			get { return GetField<TextFieldWrapper>("Title", "title"); }
		}

		/// <summary><para>Template: Call To Action Target</para><para>Field: Title</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("title")]
 		public string TitleValue
		{
			get { return Title.Value; }
		}
		/// <summary><para>Template: Call To Action Target</para><para>Field: Body</para><para>Data type: Rich Text</para></summary>
		[IndexField("body_t")]
		public virtual IRichTextFieldWrapper Body
		{
			get { return GetField<RichTextFieldWrapper>("Body", "body"); }
		}

		/// <summary><para>Template: Call To Action Target</para><para>Field: Body</para><para>Data type: Rich Text</para></summary>
		[IndexField("body")]
 		public string BodyValue
		{
			get { return Body.Value; }
		}
		/// <summary><para>Template: Call To Action Target</para><para>Field: Image</para><para>Data type: Image</para></summary>
		public virtual IImageFieldWrapper Image
		{
			get { return GetField<ImageFieldWrapper>("Image"); }
		}

		/// <summary><para>Template: Call To Action Target</para><para>Field: Image</para><para>Data type: Image</para></summary>
 		public string ImageValue
		{
			get { return Image.Value; }
		}
		/// <summary><para>Template: Call To Action Target</para><para>Field: DateAndTime</para><para>Data type: Datetime</para></summary>
		[IndexField("date_and_time_tdt")]
		public virtual IDateTimeFieldWrapper DateAndTime
		{
			get { return GetField<DateTimeFieldWrapper>("Date And Time", "date_and_time"); }
		}

		/// <summary><para>Template: Call To Action Target</para><para>Field: DateAndTime</para><para>Data type: Datetime</para></summary>
		[IndexField("date_and_time")]
 		public DateTime DateAndTimeValue
		{
			get { return DateAndTime.Value; }
		}
		/// <summary><para>Template: Call To Action Target</para><para>Field: Link</para><para>Data type: General Link</para></summary>
		[IndexField("link_t")]
		public virtual IGeneralLinkFieldWrapper Link
		{
			get { return GetField<GeneralLinkFieldWrapper>("Link", "link"); }
		}

		/// <summary><para>Template: Call To Action Target</para><para>Field: Link</para><para>Data type: General Link</para></summary>
		[IndexField("link")]
 		public string LinkValue
		{
			get { return Link.Value; }
		}
		/// <summary><para>Template: Call To Action Target</para><para>Field: HideFromNavigation</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_navigation_b")]
		public virtual IBooleanFieldWrapper HideFromNavigation
		{
			get { return GetField<BooleanFieldWrapper>("Hide From Navigation", "hide_from_navigation"); }
		}

		/// <summary><para>Template: Call To Action Target</para><para>Field: HideFromNavigation</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_navigation")]
 		public bool HideFromNavigationValue
		{
			get { return HideFromNavigation.Value; }
		}
		/// <summary><para>Template: Call To Action Target</para><para>Field: NavigationTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("navigation_title_t")]
		public virtual ITextFieldWrapper NavigationTitle
		{
			get { return GetField<TextFieldWrapper>("Navigation Title", "navigation_title"); }
		}

		/// <summary><para>Template: Call To Action Target</para><para>Field: NavigationTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("navigation_title")]
 		public string NavigationTitleValue
		{
			get { return NavigationTitle.Value; }
		}
	
	}
}
#endregion
#region Call To Action Options (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

    using Fortis.Model.RenderingParameters;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Call To Action Options</para>
	/// <para>ID: {3ACEEB4D-7AF0-4907-B33D-ED7762C53A8E}</para>
	/// <para>/sitecore/templates/User Defined/Call To Action/Rendering Options/Call To Action Options</para>
	/// </summary>
	//[Rocketcore.Search.PredefinedQuery("TemplateId", ComparisonType.Equal, "{3ACEEB4D-7AF0-4907-B33D-ED7762C53A8E}", typeof(Guid))]
	[TemplateMapping("{3ACEEB4D-7AF0-4907-B33D-ED7762C53A8E}", "InterfaceRenderingParameter")]
	public partial interface ICallToActionOptions : IRenderingParameterWrapper , Demo.Model.Templates.UserDefined.IRocketcoreRenderingParameters, Demo.Model.Templates.UserDefined.ISizeOptions, Demo.Model.Templates.UserDefined.ICallToActionLinksOptions
	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Call To Action/Rendering Options/Call To Action Options</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{3ACEEB4D-7AF0-4907-B33D-ED7762C53A8E}", typeof(Guid))]
	[TemplateMapping("{3ACEEB4D-7AF0-4907-B33D-ED7762C53A8E}", "RenderingParameter")]
	public partial class CallToActionOptions : RenderingParameterWrapper, ICallToActionOptions
	{
		public CallToActionOptions(Dictionary<string, string> parameters, ISpawnProvider spawnProvider) : base(parameters, spawnProvider)
		{
		}

		/// <summary><para>Template: Call To Action Options</para><para>Field: Height</para><para>Data type: Integer</para></summary>
		public virtual IIntegerFieldWrapper Height
		{
			get { return (Fortis.Model.RenderingParameters.Fields.IntegerFieldWrapper)GetField("Height", "integer"); }
		}

		/// <summary><para>Template: Call To Action Options</para><para>Field: Height</para><para>Data type: Integer</para></summary>
 		public long HeightValue
		{
			get { return Height.Value; }
		}
		/// <summary><para>Template: Call To Action Options</para><para>Field: Width</para><para>Data type: Integer</para></summary>
		public virtual IIntegerFieldWrapper Width
		{
			get { return (Fortis.Model.RenderingParameters.Fields.IntegerFieldWrapper)GetField("Width", "integer"); }
		}

		/// <summary><para>Template: Call To Action Options</para><para>Field: Width</para><para>Data type: Integer</para></summary>
 		public long WidthValue
		{
			get { return Width.Value; }
		}
		/// <summary><para>Template: Call To Action Options</para><para>Field: CallToActionGroup</para><para>Data type: Droptree</para></summary>
		public virtual ILinkFieldWrapper CallToActionGroup
		{
			get { return (Fortis.Model.RenderingParameters.Fields.LinkFieldWrapper)GetField("Call To Action Group", "droptree"); }
		}

		/// <summary><para>Template: Call To Action Options</para><para>Field: CallToActionGroup</para><para>Data type: Droptree</para></summary>
 		public string CallToActionGroupValue
		{
			get { return CallToActionGroup.Value; }
		}
		/// <summary><para>Template: Call To Action Options</para><para>Field: SelectionMethod</para><para>Data type: Droplink</para></summary>
		public virtual ILinkFieldWrapper SelectionMethod
		{
			get { return (Fortis.Model.RenderingParameters.Fields.LinkFieldWrapper)GetField("Selection Method", "droplink"); }
		}

		/// <summary><para>Template: Call To Action Options</para><para>Field: SelectionMethod</para><para>Data type: Droplink</para></summary>
 		public string SelectionMethodValue
		{
			get { return SelectionMethod.Value; }
		}
		/// <summary><para>Template: Call To Action Options</para><para>Field: AggregateBy</para><para>Data type: Droplink</para></summary>
		public virtual ILinkFieldWrapper AggregateBy
		{
			get { return (Fortis.Model.RenderingParameters.Fields.LinkFieldWrapper)GetField("Aggregate By", "droplink"); }
		}

		/// <summary><para>Template: Call To Action Options</para><para>Field: AggregateBy</para><para>Data type: Droplink</para></summary>
 		public string AggregateByValue
		{
			get { return AggregateBy.Value; }
		}
		/// <summary><para>Template: Call To Action Options</para><para>Field: GroupTagsBy</para><para>Data type: Droplink</para></summary>
		public virtual ILinkFieldWrapper GroupTagsBy
		{
			get { return (Fortis.Model.RenderingParameters.Fields.LinkFieldWrapper)GetField("Group Tags By", "droplink"); }
		}

		/// <summary><para>Template: Call To Action Options</para><para>Field: GroupTagsBy</para><para>Data type: Droplink</para></summary>
 		public string GroupTagsByValue
		{
			get { return GroupTagsBy.Value; }
		}
		/// <summary><para>Template: Call To Action Options</para><para>Field: Tags</para><para>Data type: Tags</para></summary>
		public virtual IListFieldWrapper Tags
		{
			get { return (Fortis.Model.RenderingParameters.Fields.ListFieldWrapper)GetField("Tags", "tags"); }
		}

		/// <summary><para>Template: Call To Action Options</para><para>Field: Tags</para><para>Data type: Tags</para></summary>
 		public IEnumerable<Guid> TagsValue
		{
			get { return Tags.Value; }
		}
		/// <summary><para>Template: Call To Action Options</para><para>Field: OrderBy</para><para>Data type: Droplink</para></summary>
		public virtual ILinkFieldWrapper OrderBy
		{
			get { return (Fortis.Model.RenderingParameters.Fields.LinkFieldWrapper)GetField("Order By", "droplink"); }
		}

		/// <summary><para>Template: Call To Action Options</para><para>Field: OrderBy</para><para>Data type: Droplink</para></summary>
 		public string OrderByValue
		{
			get { return OrderBy.Value; }
		}
		/// <summary><para>Template: Call To Action Options</para><para>Field: OrderDirection</para><para>Data type: Droplink</para></summary>
		public virtual ILinkFieldWrapper OrderDirection
		{
			get { return (Fortis.Model.RenderingParameters.Fields.LinkFieldWrapper)GetField("Order Direction", "droplink"); }
		}

		/// <summary><para>Template: Call To Action Options</para><para>Field: OrderDirection</para><para>Data type: Droplink</para></summary>
 		public string OrderDirectionValue
		{
			get { return OrderDirection.Value; }
		}
		/// <summary><para>Template: Call To Action Options</para><para>Field: ItemsPerPage</para><para>Data type: Integer</para></summary>
		public virtual IIntegerFieldWrapper ItemsPerPage
		{
			get { return (Fortis.Model.RenderingParameters.Fields.IntegerFieldWrapper)GetField("Items Per Page", "integer"); }
		}

		/// <summary><para>Template: Call To Action Options</para><para>Field: ItemsPerPage</para><para>Data type: Integer</para></summary>
 		public long ItemsPerPageValue
		{
			get { return ItemsPerPage.Value; }
		}
		/// <summary><para>Template: Call To Action Options</para><para>Field: Heading</para><para>Data type: Droptree</para></summary>
		public virtual ILinkFieldWrapper Heading
		{
			get { return (Fortis.Model.RenderingParameters.Fields.LinkFieldWrapper)GetField("Heading", "droptree"); }
		}

		/// <summary><para>Template: Call To Action Options</para><para>Field: Heading</para><para>Data type: Droptree</para></summary>
 		public string HeadingValue
		{
			get { return Heading.Value; }
		}
	
	}
}
#endregion
#region HomePage (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;


	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: HomePage</para>
	/// <para>ID: {44D657D3-6758-4C9C-B4C5-9200B424F186}</para>
	/// <para>/sitecore/templates/User Defined/Home/HomePage</para>
	/// </summary>
	//[Rocketcore.Search.PredefinedQuery("TemplateId", ComparisonType.Equal, "{44D657D3-6758-4C9C-B4C5-9200B424F186}", typeof(Guid))]
	[TemplateMapping("{44D657D3-6758-4C9C-B4C5-9200B424F186}", "InterfaceMap")]
	public partial interface IHomePage : IItemWrapper , Demo.Model.Templates.UserDefined.IRocketcoreStandardTemplate, Demo.Model.Templates.UserDefined.IContentPage
	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Home/HomePage</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{44D657D3-6758-4C9C-B4C5-9200B424F186}", typeof(Guid))]
	[TemplateMapping("{44D657D3-6758-4C9C-B4C5-9200B424F186}", "")]
	public partial class HomePage : ItemWrapper, IHomePage
	{
		private Item _item = null;

		public HomePage(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public HomePage(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public HomePage(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public HomePage(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: HomePage</para><para>Field: Description</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("description_t")]
		public virtual ITextFieldWrapper Description
		{
			get { return GetField<TextFieldWrapper>("Description", "description"); }
		}

		/// <summary><para>Template: HomePage</para><para>Field: Description</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("description")]
 		public string DescriptionValue
		{
			get { return Description.Value; }
		}
		/// <summary><para>Template: HomePage</para><para>Field: Keywords</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("keywords_t")]
		public virtual ITextFieldWrapper Keywords
		{
			get { return GetField<TextFieldWrapper>("Keywords", "keywords"); }
		}

		/// <summary><para>Template: HomePage</para><para>Field: Keywords</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("keywords")]
 		public string KeywordsValue
		{
			get { return Keywords.Value; }
		}
		/// <summary><para>Template: HomePage</para><para>Field: PageTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("page_title_t")]
		public virtual ITextFieldWrapper PageTitle
		{
			get { return GetField<TextFieldWrapper>("Page Title", "page_title"); }
		}

		/// <summary><para>Template: HomePage</para><para>Field: PageTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("page_title")]
 		public string PageTitleValue
		{
			get { return PageTitle.Value; }
		}
		/// <summary><para>Template: HomePage</para><para>Field: BreadcrumbTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("breadcrumb_title_t")]
		public virtual ITextFieldWrapper BreadcrumbTitle
		{
			get { return GetField<TextFieldWrapper>("Breadcrumb Title", "breadcrumb_title"); }
		}

		/// <summary><para>Template: HomePage</para><para>Field: BreadcrumbTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("breadcrumb_title")]
 		public string BreadcrumbTitleValue
		{
			get { return BreadcrumbTitle.Value; }
		}
		/// <summary><para>Template: HomePage</para><para>Field: HideFromBreadcrumb</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_breadcrumb_b")]
		public virtual IBooleanFieldWrapper HideFromBreadcrumb
		{
			get { return GetField<BooleanFieldWrapper>("Hide From Breadcrumb", "hide_from_breadcrumb"); }
		}

		/// <summary><para>Template: HomePage</para><para>Field: HideFromBreadcrumb</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_breadcrumb")]
 		public bool HideFromBreadcrumbValue
		{
			get { return HideFromBreadcrumb.Value; }
		}
		/// <summary><para>Template: HomePage</para><para>Field: HideFromNavigation</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_navigation_b")]
		public virtual IBooleanFieldWrapper HideFromNavigation
		{
			get { return GetField<BooleanFieldWrapper>("Hide From Navigation", "hide_from_navigation"); }
		}

		/// <summary><para>Template: HomePage</para><para>Field: HideFromNavigation</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_navigation")]
 		public bool HideFromNavigationValue
		{
			get { return HideFromNavigation.Value; }
		}
		/// <summary><para>Template: HomePage</para><para>Field: NavigationTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("navigation_title_t")]
		public virtual ITextFieldWrapper NavigationTitle
		{
			get { return GetField<TextFieldWrapper>("Navigation Title", "navigation_title"); }
		}

		/// <summary><para>Template: HomePage</para><para>Field: NavigationTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("navigation_title")]
 		public string NavigationTitleValue
		{
			get { return NavigationTitle.Value; }
		}
		/// <summary><para>Template: HomePage</para><para>Field: Tags</para><para>Data type: Tags</para></summary>
		[IndexField("tags_sm")]
		public virtual IListFieldWrapper Tags
		{
			get { return GetField<ListFieldWrapper>("Tags", "tags"); }
		}

		/// <summary><para>Template: HomePage</para><para>Field: Tags</para><para>Data type: Tags</para></summary>
		[IndexField("tags")]
 		public IEnumerable<Guid> TagsValue
		{
			get { return Tags.Value; }
		}
		/// <summary><para>Template: HomePage</para><para>Field: SubTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("sub_title_t")]
		public virtual ITextFieldWrapper SubTitle
		{
			get { return GetField<TextFieldWrapper>("Sub Title", "sub_title"); }
		}

		/// <summary><para>Template: HomePage</para><para>Field: SubTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("sub_title")]
 		public string SubTitleValue
		{
			get { return SubTitle.Value; }
		}
		/// <summary><para>Template: HomePage</para><para>Field: Title</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("title_t")]
		public virtual ITextFieldWrapper Title
		{
			get { return GetField<TextFieldWrapper>("Title", "title"); }
		}

		/// <summary><para>Template: HomePage</para><para>Field: Title</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("title")]
 		public string TitleValue
		{
			get { return Title.Value; }
		}
		/// <summary><para>Template: HomePage</para><para>Field: DateAndTime</para><para>Data type: Datetime</para></summary>
		[IndexField("date_and_time_tdt")]
		public virtual IDateTimeFieldWrapper DateAndTime
		{
			get { return GetField<DateTimeFieldWrapper>("Date And Time", "date_and_time"); }
		}

		/// <summary><para>Template: HomePage</para><para>Field: DateAndTime</para><para>Data type: Datetime</para></summary>
		[IndexField("date_and_time")]
 		public DateTime DateAndTimeValue
		{
			get { return DateAndTime.Value; }
		}
		/// <summary><para>Template: HomePage</para><para>Field: Body</para><para>Data type: Rich Text</para></summary>
		[IndexField("body_t")]
		public virtual IRichTextFieldWrapper Body
		{
			get { return GetField<RichTextFieldWrapper>("Body", "body"); }
		}

		/// <summary><para>Template: HomePage</para><para>Field: Body</para><para>Data type: Rich Text</para></summary>
		[IndexField("body")]
 		public string BodyValue
		{
			get { return Body.Value; }
		}
		/// <summary><para>Template: HomePage</para><para>Field: Image</para><para>Data type: Image</para></summary>
		public virtual IImageFieldWrapper Image
		{
			get { return GetField<ImageFieldWrapper>("Image"); }
		}

		/// <summary><para>Template: HomePage</para><para>Field: Image</para><para>Data type: Image</para></summary>
 		public string ImageValue
		{
			get { return Image.Value; }
		}
		/// <summary><para>Template: HomePage</para><para>Field: CallToActionCustom</para><para>Data type: Droptree</para></summary>
		[IndexField("call_to_action_custom_s")]
		public virtual ILinkFieldWrapper CallToActionCustom
		{
			get { return GetField<LinkFieldWrapper>("Call To Action Custom", "call_to_action_custom"); }
		}

		/// <summary><para>Template: HomePage</para><para>Field: CallToActionCustom</para><para>Data type: Droptree</para></summary>
		[IndexField("call_to_action_custom")]
 		public string CallToActionCustomValue
		{
			get { return CallToActionCustom.Value; }
		}
	
	}
}
#endregion
#region Phrase Folder (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;


	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Phrase Folder</para>
	/// <para>ID: {567B998F-F8DF-4DB6-88E1-1797035C4B6C}</para>
	/// <para>/sitecore/templates/User Defined/Phrases/Phrase Folder</para>
	/// </summary>
	//[Rocketcore.Search.PredefinedQuery("TemplateId", ComparisonType.Equal, "{567B998F-F8DF-4DB6-88E1-1797035C4B6C}", typeof(Guid))]
	[TemplateMapping("{567B998F-F8DF-4DB6-88E1-1797035C4B6C}", "InterfaceMap")]
	public partial interface IPhraseFolder : IItemWrapper , Demo.Model.Templates.UserDefined.IRocketcoreFolder
	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Phrases/Phrase Folder</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{567B998F-F8DF-4DB6-88E1-1797035C4B6C}", typeof(Guid))]
	[TemplateMapping("{567B998F-F8DF-4DB6-88E1-1797035C4B6C}", "")]
	public partial class PhraseFolder : ItemWrapper, IPhraseFolder
	{
		private Item _item = null;

		public PhraseFolder(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public PhraseFolder(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public PhraseFolder(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public PhraseFolder(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

	
	}
}
#endregion
#region Tagging (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;


	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Tagging</para>
	/// <para>ID: {5A593C05-0C1A-43DC-91F8-5909EB086BEF}</para>
	/// <para>/sitecore/templates/User Defined/Tagging/Tagging</para>
	/// </summary>
	//[Rocketcore.Search.PredefinedQuery("TemplateId", ComparisonType.Equal, "{5A593C05-0C1A-43DC-91F8-5909EB086BEF}", typeof(Guid))]
	[TemplateMapping("{5A593C05-0C1A-43DC-91F8-5909EB086BEF}", "InterfaceMap")]
	public partial interface ITagging : IItemWrapper , Demo.Model.Templates.UserDefined.IRocketcoreStandardTemplate
	{		
    	/// <summary>
		/// <para>Template: Tagging</para><para>Field: Tags</para><para>Data type: Tags</para>
        /// </summary>
		[IndexField("tags")]
		IListFieldWrapper Tags { get; }

    	/// <summary>
		/// <para>Template: Tagging</para><para>Field: Tags</para><para>Data type: Tags</para>
        /// </summary>
		[IndexField("tags")]
 		IEnumerable<Guid> TagsValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Tagging/Tagging</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{5A593C05-0C1A-43DC-91F8-5909EB086BEF}", typeof(Guid))]
	[TemplateMapping("{5A593C05-0C1A-43DC-91F8-5909EB086BEF}", "")]
	public partial class Tagging : ItemWrapper, ITagging
	{
		private Item _item = null;

		public Tagging(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public Tagging(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public Tagging(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public Tagging(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Tagging</para><para>Field: Tags</para><para>Data type: Tags</para></summary>
		[IndexField("tags_sm")]
		public virtual IListFieldWrapper Tags
		{
			get { return GetField<ListFieldWrapper>("Tags", "tags"); }
		}

		/// <summary><para>Template: Tagging</para><para>Field: Tags</para><para>Data type: Tags</para></summary>
		[IndexField("tags")]
 		public IEnumerable<Guid> TagsValue
		{
			get { return Tags.Value; }
		}
	
	}
}
#endregion
#region Pagination Options (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

    using Fortis.Model.RenderingParameters;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Pagination Options</para>
	/// <para>ID: {6237330F-ECFC-4391-A2AA-E7C1757C89EF}</para>
	/// <para>/sitecore/templates/User Defined/Global/Presentation/Rendering Options/Pagination Options</para>
	/// </summary>
	//[Rocketcore.Search.PredefinedQuery("TemplateId", ComparisonType.Equal, "{6237330F-ECFC-4391-A2AA-E7C1757C89EF}", typeof(Guid))]
	[TemplateMapping("{6237330F-ECFC-4391-A2AA-E7C1757C89EF}", "InterfaceRenderingParameter")]
	public partial interface IPaginationOptions : IRenderingParameterWrapper , Demo.Model.Templates.UserDefined.IRocketcoreRenderingParameters
	{		
    	/// <summary>
		/// <para>Template: Pagination Options</para><para>Field: ItemsPerPage</para><para>Data type: Integer</para>
        /// </summary>
		IIntegerFieldWrapper ItemsPerPage { get; }
 		long ItemsPerPageValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Global/Presentation/Rendering Options/Pagination Options</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{6237330F-ECFC-4391-A2AA-E7C1757C89EF}", typeof(Guid))]
	[TemplateMapping("{6237330F-ECFC-4391-A2AA-E7C1757C89EF}", "RenderingParameter")]
	public partial class PaginationOptions : RenderingParameterWrapper, IPaginationOptions
	{
		public PaginationOptions(Dictionary<string, string> parameters, ISpawnProvider spawnProvider) : base(parameters, spawnProvider)
		{
		}

		/// <summary><para>Template: Pagination Options</para><para>Field: ItemsPerPage</para><para>Data type: Integer</para></summary>
		public virtual IIntegerFieldWrapper ItemsPerPage
		{
			get { return (Fortis.Model.RenderingParameters.Fields.IntegerFieldWrapper)GetField("Items Per Page", "integer"); }
		}

		/// <summary><para>Template: Pagination Options</para><para>Field: ItemsPerPage</para><para>Data type: Integer</para></summary>
 		public long ItemsPerPageValue
		{
			get { return ItemsPerPage.Value; }
		}
	
	}
}
#endregion
#region Tag Folder (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;


	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Tag Folder</para>
	/// <para>ID: {67AB829E-C65E-4421-83A3-E6A6995695B8}</para>
	/// <para>/sitecore/templates/User Defined/Tagging/Tag Folder</para>
	/// </summary>
	//[Rocketcore.Search.PredefinedQuery("TemplateId", ComparisonType.Equal, "{67AB829E-C65E-4421-83A3-E6A6995695B8}", typeof(Guid))]
	[TemplateMapping("{67AB829E-C65E-4421-83A3-E6A6995695B8}", "InterfaceMap")]
	public partial interface ITagFolder : IItemWrapper , Demo.Model.Templates.UserDefined.IRocketcoreFolder
	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Tagging/Tag Folder</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{67AB829E-C65E-4421-83A3-E6A6995695B8}", typeof(Guid))]
	[TemplateMapping("{67AB829E-C65E-4421-83A3-E6A6995695B8}", "")]
	public partial class TagFolder : ItemWrapper, ITagFolder
	{
		private Item _item = null;

		public TagFolder(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public TagFolder(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public TagFolder(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public TagFolder(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

	
	}
}
#endregion
#region Call To Action Links Options (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

    using Fortis.Model.RenderingParameters;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Call To Action Links Options</para>
	/// <para>ID: {6D70D019-3250-4D7F-9E56-96A5B8934467}</para>
	/// <para>/sitecore/templates/User Defined/Call To Action/Rendering Options/Call To Action Links Options</para>
	/// </summary>
	//[Rocketcore.Search.PredefinedQuery("TemplateId", ComparisonType.Equal, "{6D70D019-3250-4D7F-9E56-96A5B8934467}", typeof(Guid))]
	[TemplateMapping("{6D70D019-3250-4D7F-9E56-96A5B8934467}", "InterfaceRenderingParameter")]
	public partial interface ICallToActionLinksOptions : IRenderingParameterWrapper , Demo.Model.Templates.UserDefined.ICallToActionListOptions
	{		
    	/// <summary>
		/// <para>Template: Call To Action Links Options</para><para>Field: CallToActionGroup</para><para>Data type: Droptree</para>
        /// </summary>
		ILinkFieldWrapper CallToActionGroup { get; }
 		string CallToActionGroupValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Call To Action/Rendering Options/Call To Action Links Options</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{6D70D019-3250-4D7F-9E56-96A5B8934467}", typeof(Guid))]
	[TemplateMapping("{6D70D019-3250-4D7F-9E56-96A5B8934467}", "RenderingParameter")]
	public partial class CallToActionLinksOptions : RenderingParameterWrapper, ICallToActionLinksOptions
	{
		public CallToActionLinksOptions(Dictionary<string, string> parameters, ISpawnProvider spawnProvider) : base(parameters, spawnProvider)
		{
		}

		/// <summary><para>Template: Call To Action Links Options</para><para>Field: SelectionMethod</para><para>Data type: Droplink</para></summary>
		public virtual ILinkFieldWrapper SelectionMethod
		{
			get { return (Fortis.Model.RenderingParameters.Fields.LinkFieldWrapper)GetField("Selection Method", "droplink"); }
		}

		/// <summary><para>Template: Call To Action Links Options</para><para>Field: SelectionMethod</para><para>Data type: Droplink</para></summary>
 		public string SelectionMethodValue
		{
			get { return SelectionMethod.Value; }
		}
		/// <summary><para>Template: Call To Action Links Options</para><para>Field: AggregateBy</para><para>Data type: Droplink</para></summary>
		public virtual ILinkFieldWrapper AggregateBy
		{
			get { return (Fortis.Model.RenderingParameters.Fields.LinkFieldWrapper)GetField("Aggregate By", "droplink"); }
		}

		/// <summary><para>Template: Call To Action Links Options</para><para>Field: AggregateBy</para><para>Data type: Droplink</para></summary>
 		public string AggregateByValue
		{
			get { return AggregateBy.Value; }
		}
		/// <summary><para>Template: Call To Action Links Options</para><para>Field: GroupTagsBy</para><para>Data type: Droplink</para></summary>
		public virtual ILinkFieldWrapper GroupTagsBy
		{
			get { return (Fortis.Model.RenderingParameters.Fields.LinkFieldWrapper)GetField("Group Tags By", "droplink"); }
		}

		/// <summary><para>Template: Call To Action Links Options</para><para>Field: GroupTagsBy</para><para>Data type: Droplink</para></summary>
 		public string GroupTagsByValue
		{
			get { return GroupTagsBy.Value; }
		}
		/// <summary><para>Template: Call To Action Links Options</para><para>Field: Tags</para><para>Data type: Tags</para></summary>
		public virtual IListFieldWrapper Tags
		{
			get { return (Fortis.Model.RenderingParameters.Fields.ListFieldWrapper)GetField("Tags", "tags"); }
		}

		/// <summary><para>Template: Call To Action Links Options</para><para>Field: Tags</para><para>Data type: Tags</para></summary>
 		public IEnumerable<Guid> TagsValue
		{
			get { return Tags.Value; }
		}
		/// <summary><para>Template: Call To Action Links Options</para><para>Field: OrderBy</para><para>Data type: Droplink</para></summary>
		public virtual ILinkFieldWrapper OrderBy
		{
			get { return (Fortis.Model.RenderingParameters.Fields.LinkFieldWrapper)GetField("Order By", "droplink"); }
		}

		/// <summary><para>Template: Call To Action Links Options</para><para>Field: OrderBy</para><para>Data type: Droplink</para></summary>
 		public string OrderByValue
		{
			get { return OrderBy.Value; }
		}
		/// <summary><para>Template: Call To Action Links Options</para><para>Field: OrderDirection</para><para>Data type: Droplink</para></summary>
		public virtual ILinkFieldWrapper OrderDirection
		{
			get { return (Fortis.Model.RenderingParameters.Fields.LinkFieldWrapper)GetField("Order Direction", "droplink"); }
		}

		/// <summary><para>Template: Call To Action Links Options</para><para>Field: OrderDirection</para><para>Data type: Droplink</para></summary>
 		public string OrderDirectionValue
		{
			get { return OrderDirection.Value; }
		}
		/// <summary><para>Template: Call To Action Links Options</para><para>Field: ItemsPerPage</para><para>Data type: Integer</para></summary>
		public virtual IIntegerFieldWrapper ItemsPerPage
		{
			get { return (Fortis.Model.RenderingParameters.Fields.IntegerFieldWrapper)GetField("Items Per Page", "integer"); }
		}

		/// <summary><para>Template: Call To Action Links Options</para><para>Field: ItemsPerPage</para><para>Data type: Integer</para></summary>
 		public long ItemsPerPageValue
		{
			get { return ItemsPerPage.Value; }
		}
		/// <summary><para>Template: Call To Action Links Options</para><para>Field: Heading</para><para>Data type: Droptree</para></summary>
		public virtual ILinkFieldWrapper Heading
		{
			get { return (Fortis.Model.RenderingParameters.Fields.LinkFieldWrapper)GetField("Heading", "droptree"); }
		}

		/// <summary><para>Template: Call To Action Links Options</para><para>Field: Heading</para><para>Data type: Droptree</para></summary>
 		public string HeadingValue
		{
			get { return Heading.Value; }
		}
		/// <summary><para>Template: Call To Action Links Options</para><para>Field: CallToActionGroup</para><para>Data type: Droptree</para></summary>
		public virtual ILinkFieldWrapper CallToActionGroup
		{
			get { return (Fortis.Model.RenderingParameters.Fields.LinkFieldWrapper)GetField("Call To Action Group", "droptree"); }
		}

		/// <summary><para>Template: Call To Action Links Options</para><para>Field: CallToActionGroup</para><para>Data type: Droptree</para></summary>
 		public string CallToActionGroupValue
		{
			get { return CallToActionGroup.Value; }
		}
	
	}
}
#endregion
#region Phrase Heading (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

    using Fortis.Model.RenderingParameters;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Phrase Heading</para>
	/// <para>ID: {72096AC2-E80D-46E9-B77E-9B8A858FA414}</para>
	/// <para>/sitecore/templates/User Defined/Phrases/Rendering Options/Phrase Heading</para>
	/// </summary>
	//[Rocketcore.Search.PredefinedQuery("TemplateId", ComparisonType.Equal, "{72096AC2-E80D-46E9-B77E-9B8A858FA414}", typeof(Guid))]
	[TemplateMapping("{72096AC2-E80D-46E9-B77E-9B8A858FA414}", "InterfaceRenderingParameter")]
	public partial interface IPhraseHeading : IRenderingParameterWrapper , Demo.Model.Templates.UserDefined.IRocketcoreRenderingParameters
	{		
    	/// <summary>
		/// <para>Template: Phrase Heading</para><para>Field: Heading</para><para>Data type: Droptree</para>
        /// </summary>
		ILinkFieldWrapper Heading { get; }
 		string HeadingValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Phrases/Rendering Options/Phrase Heading</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{72096AC2-E80D-46E9-B77E-9B8A858FA414}", typeof(Guid))]
	[TemplateMapping("{72096AC2-E80D-46E9-B77E-9B8A858FA414}", "RenderingParameter")]
	public partial class PhraseHeading : RenderingParameterWrapper, IPhraseHeading
	{
		public PhraseHeading(Dictionary<string, string> parameters, ISpawnProvider spawnProvider) : base(parameters, spawnProvider)
		{
		}

		/// <summary><para>Template: Phrase Heading</para><para>Field: Heading</para><para>Data type: Droptree</para></summary>
		public virtual ILinkFieldWrapper Heading
		{
			get { return (Fortis.Model.RenderingParameters.Fields.LinkFieldWrapper)GetField("Heading", "droptree"); }
		}

		/// <summary><para>Template: Phrase Heading</para><para>Field: Heading</para><para>Data type: Droptree</para></summary>
 		public string HeadingValue
		{
			get { return Heading.Value; }
		}
	
	}
}
#endregion
#region Content Category (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;


	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Content Category</para>
	/// <para>ID: {740F688C-5BC7-4705-8047-C017A06E4F87}</para>
	/// <para>/sitecore/templates/User Defined/Generic/Content Category</para>
	/// </summary>
	//[Rocketcore.Search.PredefinedQuery("TemplateId", ComparisonType.Equal, "{740F688C-5BC7-4705-8047-C017A06E4F87}", typeof(Guid))]
	[TemplateMapping("{740F688C-5BC7-4705-8047-C017A06E4F87}", "InterfaceMap")]
	public partial interface IContentCategory : IItemWrapper , Demo.Model.Templates.UserDefined.IRocketcoreStandardTemplate
	{		
    	/// <summary>
		/// <para>Template: Content Category</para><para>Field: Category</para><para>Data type: Droptree</para>
        /// </summary>
		[IndexField("category")]
		ILinkFieldWrapper Category { get; }

    	/// <summary>
		/// <para>Template: Content Category</para><para>Field: Category</para><para>Data type: Droptree</para>
        /// </summary>
		[IndexField("category")]
 		string CategoryValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Generic/Content Category</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{740F688C-5BC7-4705-8047-C017A06E4F87}", typeof(Guid))]
	[TemplateMapping("{740F688C-5BC7-4705-8047-C017A06E4F87}", "")]
	public partial class ContentCategory : ItemWrapper, IContentCategory
	{
		private Item _item = null;

		public ContentCategory(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public ContentCategory(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public ContentCategory(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public ContentCategory(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Content Category</para><para>Field: Category</para><para>Data type: Droptree</para></summary>
		[IndexField("category_s")]
		public virtual ILinkFieldWrapper Category
		{
			get { return GetField<LinkFieldWrapper>("Category", "category"); }
		}

		/// <summary><para>Template: Content Category</para><para>Field: Category</para><para>Data type: Droptree</para></summary>
		[IndexField("category")]
 		public string CategoryValue
		{
			get { return Category.Value; }
		}
	
	}
}
#endregion
#region Page (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;


	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Page</para>
	/// <para>ID: {7418FF44-684F-43D6-8DF7-A0741E84C028}</para>
	/// <para>/sitecore/templates/User Defined/Global/Page</para>
	/// </summary>
	//[Rocketcore.Search.PredefinedQuery("TemplateId", ComparisonType.Equal, "{7418FF44-684F-43D6-8DF7-A0741E84C028}", typeof(Guid))]
	[TemplateMapping("{7418FF44-684F-43D6-8DF7-A0741E84C028}", "InterfaceMap")]
	public partial interface IPage : IItemWrapper , Demo.Model.Templates.UserDefined.IRocketcoreStandardTemplate, Demo.Model.Templates.UserDefined.IMetaData, Demo.Model.Templates.UserDefined.IBreadcrumb, Demo.Model.Templates.UserDefined.INavigation, Demo.Model.Templates.UserDefined.ITagging
	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Global/Page</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{7418FF44-684F-43D6-8DF7-A0741E84C028}", typeof(Guid))]
	[TemplateMapping("{7418FF44-684F-43D6-8DF7-A0741E84C028}", "")]
	public partial class Page : ItemWrapper, IPage
	{
		private Item _item = null;

		public Page(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public Page(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public Page(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public Page(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Page</para><para>Field: Description</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("description_t")]
		public virtual ITextFieldWrapper Description
		{
			get { return GetField<TextFieldWrapper>("Description", "description"); }
		}

		/// <summary><para>Template: Page</para><para>Field: Description</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("description")]
 		public string DescriptionValue
		{
			get { return Description.Value; }
		}
		/// <summary><para>Template: Page</para><para>Field: Keywords</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("keywords_t")]
		public virtual ITextFieldWrapper Keywords
		{
			get { return GetField<TextFieldWrapper>("Keywords", "keywords"); }
		}

		/// <summary><para>Template: Page</para><para>Field: Keywords</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("keywords")]
 		public string KeywordsValue
		{
			get { return Keywords.Value; }
		}
		/// <summary><para>Template: Page</para><para>Field: PageTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("page_title_t")]
		public virtual ITextFieldWrapper PageTitle
		{
			get { return GetField<TextFieldWrapper>("Page Title", "page_title"); }
		}

		/// <summary><para>Template: Page</para><para>Field: PageTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("page_title")]
 		public string PageTitleValue
		{
			get { return PageTitle.Value; }
		}
		/// <summary><para>Template: Page</para><para>Field: BreadcrumbTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("breadcrumb_title_t")]
		public virtual ITextFieldWrapper BreadcrumbTitle
		{
			get { return GetField<TextFieldWrapper>("Breadcrumb Title", "breadcrumb_title"); }
		}

		/// <summary><para>Template: Page</para><para>Field: BreadcrumbTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("breadcrumb_title")]
 		public string BreadcrumbTitleValue
		{
			get { return BreadcrumbTitle.Value; }
		}
		/// <summary><para>Template: Page</para><para>Field: HideFromBreadcrumb</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_breadcrumb_b")]
		public virtual IBooleanFieldWrapper HideFromBreadcrumb
		{
			get { return GetField<BooleanFieldWrapper>("Hide From Breadcrumb", "hide_from_breadcrumb"); }
		}

		/// <summary><para>Template: Page</para><para>Field: HideFromBreadcrumb</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_breadcrumb")]
 		public bool HideFromBreadcrumbValue
		{
			get { return HideFromBreadcrumb.Value; }
		}
		/// <summary><para>Template: Page</para><para>Field: HideFromNavigation</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_navigation_b")]
		public virtual IBooleanFieldWrapper HideFromNavigation
		{
			get { return GetField<BooleanFieldWrapper>("Hide From Navigation", "hide_from_navigation"); }
		}

		/// <summary><para>Template: Page</para><para>Field: HideFromNavigation</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_navigation")]
 		public bool HideFromNavigationValue
		{
			get { return HideFromNavigation.Value; }
		}
		/// <summary><para>Template: Page</para><para>Field: NavigationTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("navigation_title_t")]
		public virtual ITextFieldWrapper NavigationTitle
		{
			get { return GetField<TextFieldWrapper>("Navigation Title", "navigation_title"); }
		}

		/// <summary><para>Template: Page</para><para>Field: NavigationTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("navigation_title")]
 		public string NavigationTitleValue
		{
			get { return NavigationTitle.Value; }
		}
		/// <summary><para>Template: Page</para><para>Field: Tags</para><para>Data type: Tags</para></summary>
		[IndexField("tags_sm")]
		public virtual IListFieldWrapper Tags
		{
			get { return GetField<ListFieldWrapper>("Tags", "tags"); }
		}

		/// <summary><para>Template: Page</para><para>Field: Tags</para><para>Data type: Tags</para></summary>
		[IndexField("tags")]
 		public IEnumerable<Guid> TagsValue
		{
			get { return Tags.Value; }
		}
	
	}
}
#endregion
#region Rocketcore Rendering Parameters (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

    using Fortis.Model.RenderingParameters;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Rocketcore Rendering Parameters</para>
	/// <para>ID: {76D9D059-77E5-48F7-8BDA-65E78BC61A9B}</para>
	/// <para>/sitecore/templates/User Defined/Rocketcore/Rocketcore Rendering Parameters</para>
	/// </summary>
	//[Rocketcore.Search.PredefinedQuery("TemplateId", ComparisonType.Equal, "{76D9D059-77E5-48F7-8BDA-65E78BC61A9B}", typeof(Guid))]
	[TemplateMapping("{76D9D059-77E5-48F7-8BDA-65E78BC61A9B}", "InterfaceRenderingParameter")]
	public partial interface IRocketcoreRenderingParameters : IRenderingParameterWrapper 
	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Rocketcore/Rocketcore Rendering Parameters</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{76D9D059-77E5-48F7-8BDA-65E78BC61A9B}", typeof(Guid))]
	[TemplateMapping("{76D9D059-77E5-48F7-8BDA-65E78BC61A9B}", "RenderingParameter")]
	public partial class RocketcoreRenderingParameters : RenderingParameterWrapper, IRocketcoreRenderingParameters
	{
		public RocketcoreRenderingParameters(Dictionary<string, string> parameters, ISpawnProvider spawnProvider) : base(parameters, spawnProvider)
		{
		}

	
	}
}
#endregion
#region Meta Data (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;


	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Meta Data</para>
	/// <para>ID: {77586D39-6101-42C0-9C2C-3115AC7E5C8A}</para>
	/// <para>/sitecore/templates/User Defined/Generic/Meta Data</para>
	/// </summary>
	//[Rocketcore.Search.PredefinedQuery("TemplateId", ComparisonType.Equal, "{77586D39-6101-42C0-9C2C-3115AC7E5C8A}", typeof(Guid))]
	[TemplateMapping("{77586D39-6101-42C0-9C2C-3115AC7E5C8A}", "InterfaceMap")]
	public partial interface IMetaData : IItemWrapper , Demo.Model.Templates.UserDefined.IRocketcoreStandardTemplate
	{		
    	/// <summary>
		/// <para>Template: Meta Data</para><para>Field: Description</para><para>Data type: Multi-Line Text</para>
        /// </summary>
		[IndexField("description")]
		ITextFieldWrapper Description { get; }

    	/// <summary>
		/// <para>Template: Meta Data</para><para>Field: Description</para><para>Data type: Multi-Line Text</para>
        /// </summary>
		[IndexField("description")]
 		string DescriptionValue { get; }
    	/// <summary>
		/// <para>Template: Meta Data</para><para>Field: Keywords</para><para>Data type: Multi-Line Text</para>
        /// </summary>
		[IndexField("keywords")]
		ITextFieldWrapper Keywords { get; }

    	/// <summary>
		/// <para>Template: Meta Data</para><para>Field: Keywords</para><para>Data type: Multi-Line Text</para>
        /// </summary>
		[IndexField("keywords")]
 		string KeywordsValue { get; }
    	/// <summary>
		/// <para>Template: Meta Data</para><para>Field: PageTitle</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("page_title")]
		ITextFieldWrapper PageTitle { get; }

    	/// <summary>
		/// <para>Template: Meta Data</para><para>Field: PageTitle</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("page_title")]
 		string PageTitleValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Generic/Meta Data</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{77586D39-6101-42C0-9C2C-3115AC7E5C8A}", typeof(Guid))]
	[TemplateMapping("{77586D39-6101-42C0-9C2C-3115AC7E5C8A}", "")]
	public partial class MetaData : ItemWrapper, IMetaData
	{
		private Item _item = null;

		public MetaData(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public MetaData(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public MetaData(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public MetaData(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Meta Data</para><para>Field: Description</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("description_t")]
		public virtual ITextFieldWrapper Description
		{
			get { return GetField<TextFieldWrapper>("Description", "description"); }
		}

		/// <summary><para>Template: Meta Data</para><para>Field: Description</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("description")]
 		public string DescriptionValue
		{
			get { return Description.Value; }
		}
		/// <summary><para>Template: Meta Data</para><para>Field: Keywords</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("keywords_t")]
		public virtual ITextFieldWrapper Keywords
		{
			get { return GetField<TextFieldWrapper>("Keywords", "keywords"); }
		}

		/// <summary><para>Template: Meta Data</para><para>Field: Keywords</para><para>Data type: Multi-Line Text</para></summary>
		[IndexField("keywords")]
 		public string KeywordsValue
		{
			get { return Keywords.Value; }
		}
		/// <summary><para>Template: Meta Data</para><para>Field: PageTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("page_title_t")]
		public virtual ITextFieldWrapper PageTitle
		{
			get { return GetField<TextFieldWrapper>("Page Title", "page_title"); }
		}

		/// <summary><para>Template: Meta Data</para><para>Field: PageTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("page_title")]
 		public string PageTitleValue
		{
			get { return PageTitle.Value; }
		}
	
	}
}
#endregion
#region Phrase (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;


	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Phrase</para>
	/// <para>ID: {860BC23B-03E7-4F97-A478-0704C18FD389}</para>
	/// <para>/sitecore/templates/User Defined/Phrases/Phrase</para>
	/// </summary>
	//[Rocketcore.Search.PredefinedQuery("TemplateId", ComparisonType.Equal, "{860BC23B-03E7-4F97-A478-0704C18FD389}", typeof(Guid))]
	[TemplateMapping("{860BC23B-03E7-4F97-A478-0704C18FD389}", "InterfaceMap")]
	public partial interface IPhrase : IItemWrapper , Demo.Model.Templates.UserDefined.IRocketcoreStandardTemplate
	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Phrases/Phrase</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{860BC23B-03E7-4F97-A478-0704C18FD389}", typeof(Guid))]
	[TemplateMapping("{860BC23B-03E7-4F97-A478-0704C18FD389}", "")]
	public partial class Phrase : ItemWrapper, IPhrase
	{
		private Item _item = null;

		public Phrase(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public Phrase(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public Phrase(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public Phrase(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

	
	}
}
#endregion
#region Selection Options (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

    using Fortis.Model.RenderingParameters;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Selection Options</para>
	/// <para>ID: {872FB55A-8617-48D9-9F92-A9D0EAB51A23}</para>
	/// <para>/sitecore/templates/User Defined/Global/Presentation/Rendering Options/Selection Options</para>
	/// </summary>
	//[Rocketcore.Search.PredefinedQuery("TemplateId", ComparisonType.Equal, "{872FB55A-8617-48D9-9F92-A9D0EAB51A23}", typeof(Guid))]
	[TemplateMapping("{872FB55A-8617-48D9-9F92-A9D0EAB51A23}", "InterfaceRenderingParameter")]
	public partial interface ISelectionOptions : IRenderingParameterWrapper , Demo.Model.Templates.UserDefined.IRocketcoreRenderingParameters
	{		
    	/// <summary>
		/// <para>Template: Selection Options</para><para>Field: SelectionMethod</para><para>Data type: Droplink</para>
        /// </summary>
		ILinkFieldWrapper SelectionMethod { get; }
 		string SelectionMethodValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Global/Presentation/Rendering Options/Selection Options</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{872FB55A-8617-48D9-9F92-A9D0EAB51A23}", typeof(Guid))]
	[TemplateMapping("{872FB55A-8617-48D9-9F92-A9D0EAB51A23}", "RenderingParameter")]
	public partial class SelectionOptions : RenderingParameterWrapper, ISelectionOptions
	{
		public SelectionOptions(Dictionary<string, string> parameters, ISpawnProvider spawnProvider) : base(parameters, spawnProvider)
		{
		}

		/// <summary><para>Template: Selection Options</para><para>Field: SelectionMethod</para><para>Data type: Droplink</para></summary>
		public virtual ILinkFieldWrapper SelectionMethod
		{
			get { return (Fortis.Model.RenderingParameters.Fields.LinkFieldWrapper)GetField("Selection Method", "droplink"); }
		}

		/// <summary><para>Template: Selection Options</para><para>Field: SelectionMethod</para><para>Data type: Droplink</para></summary>
 		public string SelectionMethodValue
		{
			get { return SelectionMethod.Value; }
		}
	
	}
}
#endregion
#region Content Gallery (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;


	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Content Gallery</para>
	/// <para>ID: {883473D9-60A4-4BEB-BE11-27A48458FD13}</para>
	/// <para>/sitecore/templates/User Defined/Generic/Content Gallery</para>
	/// </summary>
	//[Rocketcore.Search.PredefinedQuery("TemplateId", ComparisonType.Equal, "{883473D9-60A4-4BEB-BE11-27A48458FD13}", typeof(Guid))]
	[TemplateMapping("{883473D9-60A4-4BEB-BE11-27A48458FD13}", "InterfaceMap")]
	public partial interface IContentGallery : IItemWrapper , Demo.Model.Templates.UserDefined.IRocketcoreStandardTemplate
	{		
    	/// <summary>
		/// <para>Template: Content Gallery</para><para>Field: GalleryImages</para><para>Data type: Droptree</para>
        /// </summary>
		[IndexField("gallery_images")]
		ILinkFieldWrapper GalleryImages { get; }

    	/// <summary>
		/// <para>Template: Content Gallery</para><para>Field: GalleryImages</para><para>Data type: Droptree</para>
        /// </summary>
		[IndexField("gallery_images")]
 		string GalleryImagesValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Generic/Content Gallery</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{883473D9-60A4-4BEB-BE11-27A48458FD13}", typeof(Guid))]
	[TemplateMapping("{883473D9-60A4-4BEB-BE11-27A48458FD13}", "")]
	public partial class ContentGallery : ItemWrapper, IContentGallery
	{
		private Item _item = null;

		public ContentGallery(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public ContentGallery(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public ContentGallery(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public ContentGallery(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Content Gallery</para><para>Field: GalleryImages</para><para>Data type: Droptree</para></summary>
		[IndexField("gallery_images_s")]
		public virtual ILinkFieldWrapper GalleryImages
		{
			get { return GetField<LinkFieldWrapper>("Gallery Images", "gallery_images"); }
		}

		/// <summary><para>Template: Content Gallery</para><para>Field: GalleryImages</para><para>Data type: Droptree</para></summary>
		[IndexField("gallery_images")]
 		public string GalleryImagesValue
		{
			get { return GalleryImages.Value; }
		}
	
	}
}
#endregion
#region Html Phrase (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;


	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Html Phrase</para>
	/// <para>ID: {93DE3003-93CC-40E8-86F3-43D80B216238}</para>
	/// <para>/sitecore/templates/User Defined/Phrases/Html Phrase</para>
	/// </summary>
	//[Rocketcore.Search.PredefinedQuery("TemplateId", ComparisonType.Equal, "{93DE3003-93CC-40E8-86F3-43D80B216238}", typeof(Guid))]
	[TemplateMapping("{93DE3003-93CC-40E8-86F3-43D80B216238}", "InterfaceMap")]
	public partial interface IHtmlPhrase : IItemWrapper , Demo.Model.Templates.UserDefined.IPhrase
	{		
    	/// <summary>
		/// <para>Template: Html Phrase</para><para>Field: Phrase</para><para>Data type: Rich Text</para>
        /// </summary>
		[IndexField("phrase")]
		IRichTextFieldWrapper Phrase { get; }

    	/// <summary>
		/// <para>Template: Html Phrase</para><para>Field: Phrase</para><para>Data type: Rich Text</para>
        /// </summary>
		[IndexField("phrase")]
 		string PhraseValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Phrases/Html Phrase</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{93DE3003-93CC-40E8-86F3-43D80B216238}", typeof(Guid))]
	[TemplateMapping("{93DE3003-93CC-40E8-86F3-43D80B216238}", "")]
	public partial class HtmlPhrase : ItemWrapper, IHtmlPhrase
	{
		private Item _item = null;

		public HtmlPhrase(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public HtmlPhrase(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public HtmlPhrase(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public HtmlPhrase(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Html Phrase</para><para>Field: Phrase</para><para>Data type: Rich Text</para></summary>
		[IndexField("phrase_t")]
		public virtual IRichTextFieldWrapper Phrase
		{
			get { return GetField<RichTextFieldWrapper>("Phrase", "phrase"); }
		}

		/// <summary><para>Template: Html Phrase</para><para>Field: Phrase</para><para>Data type: Rich Text</para></summary>
		[IndexField("phrase")]
 		public string PhraseValue
		{
			get { return Phrase.Value; }
		}
	
	}
}
#endregion
#region Category Folder (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;


	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Category Folder</para>
	/// <para>ID: {960E231F-E632-46EF-9367-F954AE965B99}</para>
	/// <para>/sitecore/templates/User Defined/Categorisation/Category Folder</para>
	/// </summary>
	//[Rocketcore.Search.PredefinedQuery("TemplateId", ComparisonType.Equal, "{960E231F-E632-46EF-9367-F954AE965B99}", typeof(Guid))]
	[TemplateMapping("{960E231F-E632-46EF-9367-F954AE965B99}", "InterfaceMap")]
	public partial interface ICategoryFolder : IItemWrapper , Demo.Model.Templates.UserDefined.IRocketcoreFolder
	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Categorisation/Category Folder</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{960E231F-E632-46EF-9367-F954AE965B99}", typeof(Guid))]
	[TemplateMapping("{960E231F-E632-46EF-9367-F954AE965B99}", "")]
	public partial class CategoryFolder : ItemWrapper, ICategoryFolder
	{
		private Item _item = null;

		public CategoryFolder(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public CategoryFolder(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public CategoryFolder(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public CategoryFolder(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

	
	}
}
#endregion
#region Text Phrase (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;


	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Text Phrase</para>
	/// <para>ID: {9ACC757B-89EC-4E29-BAB5-1EB0D5E1EBD6}</para>
	/// <para>/sitecore/templates/User Defined/Phrases/Text Phrase</para>
	/// </summary>
	//[Rocketcore.Search.PredefinedQuery("TemplateId", ComparisonType.Equal, "{9ACC757B-89EC-4E29-BAB5-1EB0D5E1EBD6}", typeof(Guid))]
	[TemplateMapping("{9ACC757B-89EC-4E29-BAB5-1EB0D5E1EBD6}", "InterfaceMap")]
	public partial interface ITextPhrase : IItemWrapper , Demo.Model.Templates.UserDefined.IPhrase
	{		
    	/// <summary>
		/// <para>Template: Text Phrase</para><para>Field: Phrase</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("phrase")]
		ITextFieldWrapper Phrase { get; }

    	/// <summary>
		/// <para>Template: Text Phrase</para><para>Field: Phrase</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("phrase")]
 		string PhraseValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Phrases/Text Phrase</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{9ACC757B-89EC-4E29-BAB5-1EB0D5E1EBD6}", typeof(Guid))]
	[TemplateMapping("{9ACC757B-89EC-4E29-BAB5-1EB0D5E1EBD6}", "")]
	public partial class TextPhrase : ItemWrapper, ITextPhrase
	{
		private Item _item = null;

		public TextPhrase(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public TextPhrase(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public TextPhrase(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public TextPhrase(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Text Phrase</para><para>Field: Phrase</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("phrase_t")]
		public virtual ITextFieldWrapper Phrase
		{
			get { return GetField<TextFieldWrapper>("Phrase", "phrase"); }
		}

		/// <summary><para>Template: Text Phrase</para><para>Field: Phrase</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("phrase")]
 		public string PhraseValue
		{
			get { return Phrase.Value; }
		}
	
	}
}
#endregion
#region Tagging Options (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

    using Fortis.Model.RenderingParameters;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Tagging Options</para>
	/// <para>ID: {9D978F80-78D4-489A-832B-CFD2358EC804}</para>
	/// <para>/sitecore/templates/User Defined/Tagging/Rendering Options/Tagging Options</para>
	/// </summary>
	//[Rocketcore.Search.PredefinedQuery("TemplateId", ComparisonType.Equal, "{9D978F80-78D4-489A-832B-CFD2358EC804}", typeof(Guid))]
	[TemplateMapping("{9D978F80-78D4-489A-832B-CFD2358EC804}", "InterfaceRenderingParameter")]
	public partial interface ITaggingOptions : IRenderingParameterWrapper , Demo.Model.Templates.UserDefined.IRocketcoreRenderingParameters
	{		
    	/// <summary>
		/// <para>Template: Tagging Options</para><para>Field: Tags</para><para>Data type: Tags</para>
        /// </summary>
		IListFieldWrapper Tags { get; }
 		IEnumerable<Guid> TagsValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Tagging/Rendering Options/Tagging Options</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{9D978F80-78D4-489A-832B-CFD2358EC804}", typeof(Guid))]
	[TemplateMapping("{9D978F80-78D4-489A-832B-CFD2358EC804}", "RenderingParameter")]
	public partial class TaggingOptions : RenderingParameterWrapper, ITaggingOptions
	{
		public TaggingOptions(Dictionary<string, string> parameters, ISpawnProvider spawnProvider) : base(parameters, spawnProvider)
		{
		}

		/// <summary><para>Template: Tagging Options</para><para>Field: Tags</para><para>Data type: Tags</para></summary>
		public virtual IListFieldWrapper Tags
		{
			get { return (Fortis.Model.RenderingParameters.Fields.ListFieldWrapper)GetField("Tags", "tags"); }
		}

		/// <summary><para>Template: Tagging Options</para><para>Field: Tags</para><para>Data type: Tags</para></summary>
 		public IEnumerable<Guid> TagsValue
		{
			get { return Tags.Value; }
		}
	
	}
}
#endregion
#region Lookup Folder (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;


	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Lookup Folder</para>
	/// <para>ID: {9F94F923-2D44-4EB3-AC1A-927366290303}</para>
	/// <para>/sitecore/templates/User Defined/Global/Lookup/Lookup Folder</para>
	/// </summary>
	//[Rocketcore.Search.PredefinedQuery("TemplateId", ComparisonType.Equal, "{9F94F923-2D44-4EB3-AC1A-927366290303}", typeof(Guid))]
	[TemplateMapping("{9F94F923-2D44-4EB3-AC1A-927366290303}", "InterfaceMap")]
	public partial interface ILookupFolder : IItemWrapper , Demo.Model.Templates.UserDefined.IRocketcoreFolder
	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Global/Lookup/Lookup Folder</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{9F94F923-2D44-4EB3-AC1A-927366290303}", typeof(Guid))]
	[TemplateMapping("{9F94F923-2D44-4EB3-AC1A-927366290303}", "")]
	public partial class LookupFolder : ItemWrapper, ILookupFolder
	{
		private Item _item = null;

		public LookupFolder(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public LookupFolder(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public LookupFolder(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public LookupFolder(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

	
	}
}
#endregion
#region Navigation (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;


	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Navigation</para>
	/// <para>ID: {A3296576-C797-4ABC-8FAD-2B3BC3DD6DA0}</para>
	/// <para>/sitecore/templates/User Defined/Navigation/Navigation</para>
	/// </summary>
	//[Rocketcore.Search.PredefinedQuery("TemplateId", ComparisonType.Equal, "{A3296576-C797-4ABC-8FAD-2B3BC3DD6DA0}", typeof(Guid))]
	[TemplateMapping("{A3296576-C797-4ABC-8FAD-2B3BC3DD6DA0}", "InterfaceMap")]
	public partial interface INavigation : IItemWrapper , Demo.Model.Templates.UserDefined.IRocketcoreStandardTemplate
	{		
    	/// <summary>
		/// <para>Template: Navigation</para><para>Field: HideFromNavigation</para><para>Data type: Checkbox</para>
        /// </summary>
		[IndexField("hide_from_navigation")]
		IBooleanFieldWrapper HideFromNavigation { get; }

    	/// <summary>
		/// <para>Template: Navigation</para><para>Field: HideFromNavigation</para><para>Data type: Checkbox</para>
        /// </summary>
		[IndexField("hide_from_navigation")]
 		bool HideFromNavigationValue { get; }
    	/// <summary>
		/// <para>Template: Navigation</para><para>Field: NavigationTitle</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("navigation_title")]
		ITextFieldWrapper NavigationTitle { get; }

    	/// <summary>
		/// <para>Template: Navigation</para><para>Field: NavigationTitle</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("navigation_title")]
 		string NavigationTitleValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Navigation/Navigation</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{A3296576-C797-4ABC-8FAD-2B3BC3DD6DA0}", typeof(Guid))]
	[TemplateMapping("{A3296576-C797-4ABC-8FAD-2B3BC3DD6DA0}", "")]
	public partial class Navigation : ItemWrapper, INavigation
	{
		private Item _item = null;

		public Navigation(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public Navigation(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public Navigation(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public Navigation(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Navigation</para><para>Field: HideFromNavigation</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_navigation_b")]
		public virtual IBooleanFieldWrapper HideFromNavigation
		{
			get { return GetField<BooleanFieldWrapper>("Hide From Navigation", "hide_from_navigation"); }
		}

		/// <summary><para>Template: Navigation</para><para>Field: HideFromNavigation</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_navigation")]
 		public bool HideFromNavigationValue
		{
			get { return HideFromNavigation.Value; }
		}
		/// <summary><para>Template: Navigation</para><para>Field: NavigationTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("navigation_title_t")]
		public virtual ITextFieldWrapper NavigationTitle
		{
			get { return GetField<TextFieldWrapper>("Navigation Title", "navigation_title"); }
		}

		/// <summary><para>Template: Navigation</para><para>Field: NavigationTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("navigation_title")]
 		public string NavigationTitleValue
		{
			get { return NavigationTitle.Value; }
		}
	
	}
}
#endregion
#region Tagging Prototype (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

    using Fortis.Model.RenderingParameters;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Tagging Prototype</para>
	/// <para>ID: {A86728CE-890F-45A1-B5B5-EDCAD18F4516}</para>
	/// <para>/sitecore/templates/User Defined/Tagging/Rendering Options/Tagging Prototype</para>
	/// </summary>
	//[Rocketcore.Search.PredefinedQuery("TemplateId", ComparisonType.Equal, "{A86728CE-890F-45A1-B5B5-EDCAD18F4516}", typeof(Guid))]
	[TemplateMapping("{A86728CE-890F-45A1-B5B5-EDCAD18F4516}", "InterfaceRenderingParameter")]
	public partial interface ITaggingPrototype : IRenderingParameterWrapper , Demo.Model.Templates.UserDefined.IRocketcoreRenderingParameters, Demo.Model.Templates.UserDefined.ITaggingOptions
	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Tagging/Rendering Options/Tagging Prototype</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{A86728CE-890F-45A1-B5B5-EDCAD18F4516}", typeof(Guid))]
	[TemplateMapping("{A86728CE-890F-45A1-B5B5-EDCAD18F4516}", "RenderingParameter")]
	public partial class TaggingPrototype : RenderingParameterWrapper, ITaggingPrototype
	{
		public TaggingPrototype(Dictionary<string, string> parameters, ISpawnProvider spawnProvider) : base(parameters, spawnProvider)
		{
		}

		/// <summary><para>Template: Tagging Prototype</para><para>Field: Tags</para><para>Data type: Tags</para></summary>
		public virtual IListFieldWrapper Tags
		{
			get { return (Fortis.Model.RenderingParameters.Fields.ListFieldWrapper)GetField("Tags", "tags"); }
		}

		/// <summary><para>Template: Tagging Prototype</para><para>Field: Tags</para><para>Data type: Tags</para></summary>
 		public IEnumerable<Guid> TagsValue
		{
			get { return Tags.Value; }
		}
	
	}
}
#endregion
#region Call To Action Slide (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;


	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Call To Action Slide</para>
	/// <para>ID: {A8D9CC6F-03F3-41C0-BD4B-3187A72FA148}</para>
	/// <para>/sitecore/templates/User Defined/Call To Action/Call To Action Slide</para>
	/// </summary>
	//[Rocketcore.Search.PredefinedQuery("TemplateId", ComparisonType.Equal, "{A8D9CC6F-03F3-41C0-BD4B-3187A72FA148}", typeof(Guid))]
	[TemplateMapping("{A8D9CC6F-03F3-41C0-BD4B-3187A72FA148}", "InterfaceMap")]
	public partial interface ICallToActionSlide : IItemWrapper , Demo.Model.Templates.UserDefined.IRocketcoreStandardTemplate, Demo.Model.Templates.UserDefined.ICallToActionTarget
	{		
    	/// <summary>
		/// <para>Template: Call To Action Slide</para><para>Field: RightAlignImageText</para><para>Data type: Checkbox</para>
        /// </summary>
		[IndexField("right_align_image_text")]
		IBooleanFieldWrapper RightAlignImageText { get; }

    	/// <summary>
		/// <para>Template: Call To Action Slide</para><para>Field: RightAlignImageText</para><para>Data type: Checkbox</para>
        /// </summary>
		[IndexField("right_align_image_text")]
 		bool RightAlignImageTextValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Call To Action/Call To Action Slide</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{A8D9CC6F-03F3-41C0-BD4B-3187A72FA148}", typeof(Guid))]
	[TemplateMapping("{A8D9CC6F-03F3-41C0-BD4B-3187A72FA148}", "")]
	public partial class CallToActionSlide : ItemWrapper, ICallToActionSlide
	{
		private Item _item = null;

		public CallToActionSlide(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public CallToActionSlide(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public CallToActionSlide(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public CallToActionSlide(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Call To Action Slide</para><para>Field: Tags</para><para>Data type: Tags</para></summary>
		[IndexField("tags_sm")]
		public virtual IListFieldWrapper Tags
		{
			get { return GetField<ListFieldWrapper>("Tags", "tags"); }
		}

		/// <summary><para>Template: Call To Action Slide</para><para>Field: Tags</para><para>Data type: Tags</para></summary>
		[IndexField("tags")]
 		public IEnumerable<Guid> TagsValue
		{
			get { return Tags.Value; }
		}
		/// <summary><para>Template: Call To Action Slide</para><para>Field: SubTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("sub_title_t")]
		public virtual ITextFieldWrapper SubTitle
		{
			get { return GetField<TextFieldWrapper>("Sub Title", "sub_title"); }
		}

		/// <summary><para>Template: Call To Action Slide</para><para>Field: SubTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("sub_title")]
 		public string SubTitleValue
		{
			get { return SubTitle.Value; }
		}
		/// <summary><para>Template: Call To Action Slide</para><para>Field: Title</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("title_t")]
		public virtual ITextFieldWrapper Title
		{
			get { return GetField<TextFieldWrapper>("Title", "title"); }
		}

		/// <summary><para>Template: Call To Action Slide</para><para>Field: Title</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("title")]
 		public string TitleValue
		{
			get { return Title.Value; }
		}
		/// <summary><para>Template: Call To Action Slide</para><para>Field: Body</para><para>Data type: Rich Text</para></summary>
		[IndexField("body_t")]
		public virtual IRichTextFieldWrapper Body
		{
			get { return GetField<RichTextFieldWrapper>("Body", "body"); }
		}

		/// <summary><para>Template: Call To Action Slide</para><para>Field: Body</para><para>Data type: Rich Text</para></summary>
		[IndexField("body")]
 		public string BodyValue
		{
			get { return Body.Value; }
		}
		/// <summary><para>Template: Call To Action Slide</para><para>Field: Image</para><para>Data type: Image</para></summary>
		public virtual IImageFieldWrapper Image
		{
			get { return GetField<ImageFieldWrapper>("Image"); }
		}

		/// <summary><para>Template: Call To Action Slide</para><para>Field: Image</para><para>Data type: Image</para></summary>
 		public string ImageValue
		{
			get { return Image.Value; }
		}
		/// <summary><para>Template: Call To Action Slide</para><para>Field: DateAndTime</para><para>Data type: Datetime</para></summary>
		[IndexField("date_and_time_tdt")]
		public virtual IDateTimeFieldWrapper DateAndTime
		{
			get { return GetField<DateTimeFieldWrapper>("Date And Time", "date_and_time"); }
		}

		/// <summary><para>Template: Call To Action Slide</para><para>Field: DateAndTime</para><para>Data type: Datetime</para></summary>
		[IndexField("date_and_time")]
 		public DateTime DateAndTimeValue
		{
			get { return DateAndTime.Value; }
		}
		/// <summary><para>Template: Call To Action Slide</para><para>Field: Link</para><para>Data type: General Link</para></summary>
		[IndexField("link_t")]
		public virtual IGeneralLinkFieldWrapper Link
		{
			get { return GetField<GeneralLinkFieldWrapper>("Link", "link"); }
		}

		/// <summary><para>Template: Call To Action Slide</para><para>Field: Link</para><para>Data type: General Link</para></summary>
		[IndexField("link")]
 		public string LinkValue
		{
			get { return Link.Value; }
		}
		/// <summary><para>Template: Call To Action Slide</para><para>Field: HideFromNavigation</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_navigation_b")]
		public virtual IBooleanFieldWrapper HideFromNavigation
		{
			get { return GetField<BooleanFieldWrapper>("Hide From Navigation", "hide_from_navigation"); }
		}

		/// <summary><para>Template: Call To Action Slide</para><para>Field: HideFromNavigation</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_navigation")]
 		public bool HideFromNavigationValue
		{
			get { return HideFromNavigation.Value; }
		}
		/// <summary><para>Template: Call To Action Slide</para><para>Field: NavigationTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("navigation_title_t")]
		public virtual ITextFieldWrapper NavigationTitle
		{
			get { return GetField<TextFieldWrapper>("Navigation Title", "navigation_title"); }
		}

		/// <summary><para>Template: Call To Action Slide</para><para>Field: NavigationTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("navigation_title")]
 		public string NavigationTitleValue
		{
			get { return NavigationTitle.Value; }
		}
		/// <summary><para>Template: Call To Action Slide</para><para>Field: RightAlignImageText</para><para>Data type: Checkbox</para></summary>
		[IndexField("right_align_image_text_b")]
		public virtual IBooleanFieldWrapper RightAlignImageText
		{
			get { return GetField<BooleanFieldWrapper>("Right Align Image Text", "right_align_image_text"); }
		}

		/// <summary><para>Template: Call To Action Slide</para><para>Field: RightAlignImageText</para><para>Data type: Checkbox</para></summary>
		[IndexField("right_align_image_text")]
 		public bool RightAlignImageTextValue
		{
			get { return RightAlignImageText.Value; }
		}
	
	}
}
#endregion
#region Aggregate Options (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

    using Fortis.Model.RenderingParameters;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Aggregate Options</para>
	/// <para>ID: {AAA421D9-53C1-443B-AB8C-0499110138D8}</para>
	/// <para>/sitecore/templates/User Defined/Global/Presentation/Rendering Options/Aggregate Options</para>
	/// </summary>
	//[Rocketcore.Search.PredefinedQuery("TemplateId", ComparisonType.Equal, "{AAA421D9-53C1-443B-AB8C-0499110138D8}", typeof(Guid))]
	[TemplateMapping("{AAA421D9-53C1-443B-AB8C-0499110138D8}", "InterfaceRenderingParameter")]
	public partial interface IAggregateOptions : IRenderingParameterWrapper , Demo.Model.Templates.UserDefined.IRocketcoreRenderingParameters
	{		
    	/// <summary>
		/// <para>Template: Aggregate Options</para><para>Field: AggregateBy</para><para>Data type: Droplink</para>
        /// </summary>
		ILinkFieldWrapper AggregateBy { get; }
 		string AggregateByValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Global/Presentation/Rendering Options/Aggregate Options</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{AAA421D9-53C1-443B-AB8C-0499110138D8}", typeof(Guid))]
	[TemplateMapping("{AAA421D9-53C1-443B-AB8C-0499110138D8}", "RenderingParameter")]
	public partial class AggregateOptions : RenderingParameterWrapper, IAggregateOptions
	{
		public AggregateOptions(Dictionary<string, string> parameters, ISpawnProvider spawnProvider) : base(parameters, spawnProvider)
		{
		}

		/// <summary><para>Template: Aggregate Options</para><para>Field: AggregateBy</para><para>Data type: Droplink</para></summary>
		public virtual ILinkFieldWrapper AggregateBy
		{
			get { return (Fortis.Model.RenderingParameters.Fields.LinkFieldWrapper)GetField("Aggregate By", "droplink"); }
		}

		/// <summary><para>Template: Aggregate Options</para><para>Field: AggregateBy</para><para>Data type: Droplink</para></summary>
 		public string AggregateByValue
		{
			get { return AggregateBy.Value; }
		}
	
	}
}
#endregion
#region Content Image (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;


	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Content Image</para>
	/// <para>ID: {AF27068F-E9F3-491E-84B8-91A55F86D110}</para>
	/// <para>/sitecore/templates/User Defined/Generic/Content Image</para>
	/// </summary>
	//[Rocketcore.Search.PredefinedQuery("TemplateId", ComparisonType.Equal, "{AF27068F-E9F3-491E-84B8-91A55F86D110}", typeof(Guid))]
	[TemplateMapping("{AF27068F-E9F3-491E-84B8-91A55F86D110}", "InterfaceMap")]
	public partial interface IContentImage : IItemWrapper , Demo.Model.Templates.UserDefined.IRocketcoreStandardTemplate
	{		
    	/// <summary>
		/// <para>Template: Content Image</para><para>Field: Image</para><para>Data type: Image</para>
        /// </summary>
		IImageFieldWrapper Image { get; }
 		string ImageValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Generic/Content Image</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{AF27068F-E9F3-491E-84B8-91A55F86D110}", typeof(Guid))]
	[TemplateMapping("{AF27068F-E9F3-491E-84B8-91A55F86D110}", "")]
	public partial class ContentImage : ItemWrapper, IContentImage
	{
		private Item _item = null;

		public ContentImage(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public ContentImage(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public ContentImage(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public ContentImage(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Content Image</para><para>Field: Image</para><para>Data type: Image</para></summary>
		public virtual IImageFieldWrapper Image
		{
			get { return GetField<ImageFieldWrapper>("Image"); }
		}

		/// <summary><para>Template: Content Image</para><para>Field: Image</para><para>Data type: Image</para></summary>
 		public string ImageValue
		{
			get { return Image.Value; }
		}
	
	}
}
#endregion
#region Call To Action Group (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;


	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Call To Action Group</para>
	/// <para>ID: {B40FA2F9-6328-4DC6-A7DA-6F447DFB2BE1}</para>
	/// <para>/sitecore/templates/User Defined/Call To Action/Call To Action Group</para>
	/// </summary>
	//[Rocketcore.Search.PredefinedQuery("TemplateId", ComparisonType.Equal, "{B40FA2F9-6328-4DC6-A7DA-6F447DFB2BE1}", typeof(Guid))]
	[TemplateMapping("{B40FA2F9-6328-4DC6-A7DA-6F447DFB2BE1}", "InterfaceMap")]
	public partial interface ICallToActionGroup : IItemWrapper , Demo.Model.Templates.UserDefined.IRocketcoreStandardTemplate
	{		
    	/// <summary>
		/// <para>Template: Call To Action Group</para><para>Field: CallToActions</para><para>Data type: TreelistEx</para>
        /// </summary>
		[IndexField("call_to_actions")]
		IListFieldWrapper CallToActions { get; }

    	/// <summary>
		/// <para>Template: Call To Action Group</para><para>Field: CallToActions</para><para>Data type: TreelistEx</para>
        /// </summary>
		[IndexField("call_to_actions")]
 		IEnumerable<Guid> CallToActionsValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Call To Action/Call To Action Group</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{B40FA2F9-6328-4DC6-A7DA-6F447DFB2BE1}", typeof(Guid))]
	[TemplateMapping("{B40FA2F9-6328-4DC6-A7DA-6F447DFB2BE1}", "")]
	public partial class CallToActionGroup : ItemWrapper, ICallToActionGroup
	{
		private Item _item = null;

		public CallToActionGroup(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public CallToActionGroup(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public CallToActionGroup(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public CallToActionGroup(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Call To Action Group</para><para>Field: CallToActions</para><para>Data type: TreelistEx</para></summary>
		[IndexField("call_to_actions_sm")]
		public virtual IListFieldWrapper CallToActions
		{
			get { return GetField<ListFieldWrapper>("Call To Actions", "call_to_actions"); }
		}

		/// <summary><para>Template: Call To Action Group</para><para>Field: CallToActions</para><para>Data type: TreelistEx</para></summary>
		[IndexField("call_to_actions")]
 		public IEnumerable<Guid> CallToActionsValue
		{
			get { return CallToActions.Value; }
		}
	
	}
}
#endregion
#region Breadcrumb (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;


	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Breadcrumb</para>
	/// <para>ID: {BB60121D-D8BD-4D1A-9B44-5ABCC2AAFE5D}</para>
	/// <para>/sitecore/templates/User Defined/Navigation/Breadcrumb</para>
	/// </summary>
	//[Rocketcore.Search.PredefinedQuery("TemplateId", ComparisonType.Equal, "{BB60121D-D8BD-4D1A-9B44-5ABCC2AAFE5D}", typeof(Guid))]
	[TemplateMapping("{BB60121D-D8BD-4D1A-9B44-5ABCC2AAFE5D}", "InterfaceMap")]
	public partial interface IBreadcrumb : IItemWrapper , Demo.Model.Templates.UserDefined.IRocketcoreStandardTemplate
	{		
    	/// <summary>
		/// <para>Template: Breadcrumb</para><para>Field: BreadcrumbTitle</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("breadcrumb_title")]
		ITextFieldWrapper BreadcrumbTitle { get; }

    	/// <summary>
		/// <para>Template: Breadcrumb</para><para>Field: BreadcrumbTitle</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("breadcrumb_title")]
 		string BreadcrumbTitleValue { get; }
    	/// <summary>
		/// <para>Template: Breadcrumb</para><para>Field: HideFromBreadcrumb</para><para>Data type: Checkbox</para>
        /// </summary>
		[IndexField("hide_from_breadcrumb")]
		IBooleanFieldWrapper HideFromBreadcrumb { get; }

    	/// <summary>
		/// <para>Template: Breadcrumb</para><para>Field: HideFromBreadcrumb</para><para>Data type: Checkbox</para>
        /// </summary>
		[IndexField("hide_from_breadcrumb")]
 		bool HideFromBreadcrumbValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Navigation/Breadcrumb</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{BB60121D-D8BD-4D1A-9B44-5ABCC2AAFE5D}", typeof(Guid))]
	[TemplateMapping("{BB60121D-D8BD-4D1A-9B44-5ABCC2AAFE5D}", "")]
	public partial class Breadcrumb : ItemWrapper, IBreadcrumb
	{
		private Item _item = null;

		public Breadcrumb(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public Breadcrumb(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public Breadcrumb(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public Breadcrumb(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Breadcrumb</para><para>Field: BreadcrumbTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("breadcrumb_title_t")]
		public virtual ITextFieldWrapper BreadcrumbTitle
		{
			get { return GetField<TextFieldWrapper>("Breadcrumb Title", "breadcrumb_title"); }
		}

		/// <summary><para>Template: Breadcrumb</para><para>Field: BreadcrumbTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("breadcrumb_title")]
 		public string BreadcrumbTitleValue
		{
			get { return BreadcrumbTitle.Value; }
		}
		/// <summary><para>Template: Breadcrumb</para><para>Field: HideFromBreadcrumb</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_breadcrumb_b")]
		public virtual IBooleanFieldWrapper HideFromBreadcrumb
		{
			get { return GetField<BooleanFieldWrapper>("Hide From Breadcrumb", "hide_from_breadcrumb"); }
		}

		/// <summary><para>Template: Breadcrumb</para><para>Field: HideFromBreadcrumb</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_breadcrumb")]
 		public bool HideFromBreadcrumbValue
		{
			get { return HideFromBreadcrumb.Value; }
		}
	
	}
}
#endregion
#region Tagging Filter Options (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

    using Fortis.Model.RenderingParameters;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Tagging Filter Options</para>
	/// <para>ID: {C489105D-4469-4B37-B247-72785F48165D}</para>
	/// <para>/sitecore/templates/User Defined/Global/Presentation/Rendering Options/Tagging Filter Options</para>
	/// </summary>
	//[Rocketcore.Search.PredefinedQuery("TemplateId", ComparisonType.Equal, "{C489105D-4469-4B37-B247-72785F48165D}", typeof(Guid))]
	[TemplateMapping("{C489105D-4469-4B37-B247-72785F48165D}", "InterfaceRenderingParameter")]
	public partial interface ITaggingFilterOptions : IRenderingParameterWrapper , Demo.Model.Templates.UserDefined.IRocketcoreRenderingParameters
	{		
    	/// <summary>
		/// <para>Template: Tagging Filter Options</para><para>Field: GroupTagsBy</para><para>Data type: Droplink</para>
        /// </summary>
		ILinkFieldWrapper GroupTagsBy { get; }
 		string GroupTagsByValue { get; }
    	/// <summary>
		/// <para>Template: Tagging Filter Options</para><para>Field: Tags</para><para>Data type: Tags</para>
        /// </summary>
		IListFieldWrapper Tags { get; }
 		IEnumerable<Guid> TagsValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Global/Presentation/Rendering Options/Tagging Filter Options</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{C489105D-4469-4B37-B247-72785F48165D}", typeof(Guid))]
	[TemplateMapping("{C489105D-4469-4B37-B247-72785F48165D}", "RenderingParameter")]
	public partial class TaggingFilterOptions : RenderingParameterWrapper, ITaggingFilterOptions
	{
		public TaggingFilterOptions(Dictionary<string, string> parameters, ISpawnProvider spawnProvider) : base(parameters, spawnProvider)
		{
		}

		/// <summary><para>Template: Tagging Filter Options</para><para>Field: GroupTagsBy</para><para>Data type: Droplink</para></summary>
		public virtual ILinkFieldWrapper GroupTagsBy
		{
			get { return (Fortis.Model.RenderingParameters.Fields.LinkFieldWrapper)GetField("Group Tags By", "droplink"); }
		}

		/// <summary><para>Template: Tagging Filter Options</para><para>Field: GroupTagsBy</para><para>Data type: Droplink</para></summary>
 		public string GroupTagsByValue
		{
			get { return GroupTagsBy.Value; }
		}
		/// <summary><para>Template: Tagging Filter Options</para><para>Field: Tags</para><para>Data type: Tags</para></summary>
		public virtual IListFieldWrapper Tags
		{
			get { return (Fortis.Model.RenderingParameters.Fields.ListFieldWrapper)GetField("Tags", "tags"); }
		}

		/// <summary><para>Template: Tagging Filter Options</para><para>Field: Tags</para><para>Data type: Tags</para></summary>
 		public IEnumerable<Guid> TagsValue
		{
			get { return Tags.Value; }
		}
	
	}
}
#endregion
#region Presentation Settings (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;


	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Presentation Settings</para>
	/// <para>ID: {D16227ED-173B-4E26-85A5-A71B6D20B866}</para>
	/// <para>/sitecore/templates/User Defined/Rocketcore/Presentation Settings</para>
	/// </summary>
	//[Rocketcore.Search.PredefinedQuery("TemplateId", ComparisonType.Equal, "{D16227ED-173B-4E26-85A5-A71B6D20B866}", typeof(Guid))]
	[TemplateMapping("{D16227ED-173B-4E26-85A5-A71B6D20B866}", "InterfaceMap")]
	public partial interface IPresentationSettings : IItemWrapper , Demo.Model.Templates.UserDefined.IRocketcoreStandardTemplate
	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Rocketcore/Presentation Settings</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{D16227ED-173B-4E26-85A5-A71B6D20B866}", typeof(Guid))]
	[TemplateMapping("{D16227ED-173B-4E26-85A5-A71B6D20B866}", "")]
	public partial class PresentationSettings : ItemWrapper, IPresentationSettings
	{
		private Item _item = null;

		public PresentationSettings(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public PresentationSettings(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public PresentationSettings(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public PresentationSettings(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

	
	}
}
#endregion
#region Content Date Time (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;


	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Content Date Time</para>
	/// <para>ID: {D354D790-34CF-4972-97B4-0E601E2F64FA}</para>
	/// <para>/sitecore/templates/User Defined/Generic/Content Date Time</para>
	/// </summary>
	//[Rocketcore.Search.PredefinedQuery("TemplateId", ComparisonType.Equal, "{D354D790-34CF-4972-97B4-0E601E2F64FA}", typeof(Guid))]
	[TemplateMapping("{D354D790-34CF-4972-97B4-0E601E2F64FA}", "InterfaceMap")]
	public partial interface IContentDateTime : IItemWrapper , Demo.Model.Templates.UserDefined.IRocketcoreStandardTemplate
	{		
    	/// <summary>
		/// <para>Template: Content Date Time</para><para>Field: DateAndTime</para><para>Data type: Datetime</para>
        /// </summary>
		[IndexField("date_and_time")]
		IDateTimeFieldWrapper DateAndTime { get; }

    	/// <summary>
		/// <para>Template: Content Date Time</para><para>Field: DateAndTime</para><para>Data type: Datetime</para>
        /// </summary>
		[IndexField("date_and_time")]
 		DateTime DateAndTimeValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Generic/Content Date Time</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{D354D790-34CF-4972-97B4-0E601E2F64FA}", typeof(Guid))]
	[TemplateMapping("{D354D790-34CF-4972-97B4-0E601E2F64FA}", "")]
	public partial class ContentDateTime : ItemWrapper, IContentDateTime
	{
		private Item _item = null;

		public ContentDateTime(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public ContentDateTime(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public ContentDateTime(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public ContentDateTime(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Content Date Time</para><para>Field: DateAndTime</para><para>Data type: Datetime</para></summary>
		[IndexField("date_and_time_tdt")]
		public virtual IDateTimeFieldWrapper DateAndTime
		{
			get { return GetField<DateTimeFieldWrapper>("Date And Time", "date_and_time"); }
		}

		/// <summary><para>Template: Content Date Time</para><para>Field: DateAndTime</para><para>Data type: Datetime</para></summary>
		[IndexField("date_and_time")]
 		public DateTime DateAndTimeValue
		{
			get { return DateAndTime.Value; }
		}
	
	}
}
#endregion
#region Tag (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;


	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Tag</para>
	/// <para>ID: {D3CA7D61-14F5-4467-A9CC-4AAF50885C29}</para>
	/// <para>/sitecore/templates/User Defined/Tagging/Tag</para>
	/// </summary>
	//[Rocketcore.Search.PredefinedQuery("TemplateId", ComparisonType.Equal, "{D3CA7D61-14F5-4467-A9CC-4AAF50885C29}", typeof(Guid))]
	[TemplateMapping("{D3CA7D61-14F5-4467-A9CC-4AAF50885C29}", "InterfaceMap")]
	public partial interface ITag : IItemWrapper , Demo.Model.Templates.UserDefined.IRocketcoreStandardTemplate
	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Tagging/Tag</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{D3CA7D61-14F5-4467-A9CC-4AAF50885C29}", typeof(Guid))]
	[TemplateMapping("{D3CA7D61-14F5-4467-A9CC-4AAF50885C29}", "")]
	public partial class Tag : ItemWrapper, ITag
	{
		private Item _item = null;

		public Tag(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public Tag(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public Tag(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public Tag(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

	
	}
}
#endregion
#region Rocketcore Standard Template (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;


	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Rocketcore Standard Template</para>
	/// <para>ID: {D902D3A4-630C-4E8D-9261-4EAF6E14B8EA}</para>
	/// <para>/sitecore/templates/User Defined/Rocketcore/Rocketcore Standard Template</para>
	/// </summary>
	//[Rocketcore.Search.PredefinedQuery("TemplateId", ComparisonType.Equal, "{D902D3A4-630C-4E8D-9261-4EAF6E14B8EA}", typeof(Guid))]
	[TemplateMapping("{D902D3A4-630C-4E8D-9261-4EAF6E14B8EA}", "InterfaceMap")]
	public partial interface IRocketcoreStandardTemplate : IItemWrapper , Demo.Model.Templates.UserDefined.IRocketcorePermissions
	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Rocketcore/Rocketcore Standard Template</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{D902D3A4-630C-4E8D-9261-4EAF6E14B8EA}", typeof(Guid))]
	[TemplateMapping("{D902D3A4-630C-4E8D-9261-4EAF6E14B8EA}", "")]
	public partial class RocketcoreStandardTemplate : ItemWrapper, IRocketcoreStandardTemplate
	{
		private Item _item = null;

		public RocketcoreStandardTemplate(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public RocketcoreStandardTemplate(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public RocketcoreStandardTemplate(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public RocketcoreStandardTemplate(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

	
	}
}
#endregion
#region Call To Action (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;


	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Call To Action</para>
	/// <para>ID: {E83B1FB1-1261-4D1E-BE25-ABAE7FDD8DFF}</para>
	/// <para>/sitecore/templates/User Defined/Call To Action/Call To Action</para>
	/// </summary>
	//[Rocketcore.Search.PredefinedQuery("TemplateId", ComparisonType.Equal, "{E83B1FB1-1261-4D1E-BE25-ABAE7FDD8DFF}", typeof(Guid))]
	[TemplateMapping("{E83B1FB1-1261-4D1E-BE25-ABAE7FDD8DFF}", "InterfaceMap")]
	public partial interface ICallToAction : IItemWrapper , Demo.Model.Templates.UserDefined.IRocketcoreStandardTemplate, Demo.Model.Templates.UserDefined.ITagging, Demo.Model.Templates.UserDefined.IContentHeadings, Demo.Model.Templates.UserDefined.IContentBody, Demo.Model.Templates.UserDefined.IContentImage, Demo.Model.Templates.UserDefined.IContentDateTime
	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Call To Action/Call To Action</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{E83B1FB1-1261-4D1E-BE25-ABAE7FDD8DFF}", typeof(Guid))]
	[TemplateMapping("{E83B1FB1-1261-4D1E-BE25-ABAE7FDD8DFF}", "")]
	public partial class CallToAction : ItemWrapper, ICallToAction
	{
		private Item _item = null;

		public CallToAction(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public CallToAction(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public CallToAction(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public CallToAction(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Call To Action</para><para>Field: Tags</para><para>Data type: Tags</para></summary>
		[IndexField("tags_sm")]
		public virtual IListFieldWrapper Tags
		{
			get { return GetField<ListFieldWrapper>("Tags", "tags"); }
		}

		/// <summary><para>Template: Call To Action</para><para>Field: Tags</para><para>Data type: Tags</para></summary>
		[IndexField("tags")]
 		public IEnumerable<Guid> TagsValue
		{
			get { return Tags.Value; }
		}
		/// <summary><para>Template: Call To Action</para><para>Field: SubTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("sub_title_t")]
		public virtual ITextFieldWrapper SubTitle
		{
			get { return GetField<TextFieldWrapper>("Sub Title", "sub_title"); }
		}

		/// <summary><para>Template: Call To Action</para><para>Field: SubTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("sub_title")]
 		public string SubTitleValue
		{
			get { return SubTitle.Value; }
		}
		/// <summary><para>Template: Call To Action</para><para>Field: Title</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("title_t")]
		public virtual ITextFieldWrapper Title
		{
			get { return GetField<TextFieldWrapper>("Title", "title"); }
		}

		/// <summary><para>Template: Call To Action</para><para>Field: Title</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("title")]
 		public string TitleValue
		{
			get { return Title.Value; }
		}
		/// <summary><para>Template: Call To Action</para><para>Field: Body</para><para>Data type: Rich Text</para></summary>
		[IndexField("body_t")]
		public virtual IRichTextFieldWrapper Body
		{
			get { return GetField<RichTextFieldWrapper>("Body", "body"); }
		}

		/// <summary><para>Template: Call To Action</para><para>Field: Body</para><para>Data type: Rich Text</para></summary>
		[IndexField("body")]
 		public string BodyValue
		{
			get { return Body.Value; }
		}
		/// <summary><para>Template: Call To Action</para><para>Field: Image</para><para>Data type: Image</para></summary>
		public virtual IImageFieldWrapper Image
		{
			get { return GetField<ImageFieldWrapper>("Image"); }
		}

		/// <summary><para>Template: Call To Action</para><para>Field: Image</para><para>Data type: Image</para></summary>
 		public string ImageValue
		{
			get { return Image.Value; }
		}
		/// <summary><para>Template: Call To Action</para><para>Field: DateAndTime</para><para>Data type: Datetime</para></summary>
		[IndexField("date_and_time_tdt")]
		public virtual IDateTimeFieldWrapper DateAndTime
		{
			get { return GetField<DateTimeFieldWrapper>("Date And Time", "date_and_time"); }
		}

		/// <summary><para>Template: Call To Action</para><para>Field: DateAndTime</para><para>Data type: Datetime</para></summary>
		[IndexField("date_and_time")]
 		public DateTime DateAndTimeValue
		{
			get { return DateAndTime.Value; }
		}
	
	}
}
#endregion
#region Content Headings (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;


	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Content Headings</para>
	/// <para>ID: {E9A38444-4157-4BF9-A525-C2DBCBBDFEBA}</para>
	/// <para>/sitecore/templates/User Defined/Generic/Content Headings</para>
	/// </summary>
	//[Rocketcore.Search.PredefinedQuery("TemplateId", ComparisonType.Equal, "{E9A38444-4157-4BF9-A525-C2DBCBBDFEBA}", typeof(Guid))]
	[TemplateMapping("{E9A38444-4157-4BF9-A525-C2DBCBBDFEBA}", "InterfaceMap")]
	public partial interface IContentHeadings : IItemWrapper 
	{		
    	/// <summary>
		/// <para>Template: Content Headings</para><para>Field: SubTitle</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("sub_title")]
		ITextFieldWrapper SubTitle { get; }

    	/// <summary>
		/// <para>Template: Content Headings</para><para>Field: SubTitle</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("sub_title")]
 		string SubTitleValue { get; }
    	/// <summary>
		/// <para>Template: Content Headings</para><para>Field: Title</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("title")]
		ITextFieldWrapper Title { get; }

    	/// <summary>
		/// <para>Template: Content Headings</para><para>Field: Title</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("title")]
 		string TitleValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Generic/Content Headings</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{E9A38444-4157-4BF9-A525-C2DBCBBDFEBA}", typeof(Guid))]
	[TemplateMapping("{E9A38444-4157-4BF9-A525-C2DBCBBDFEBA}", "")]
	public partial class ContentHeadings : ItemWrapper, IContentHeadings
	{
		private Item _item = null;

		public ContentHeadings(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public ContentHeadings(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public ContentHeadings(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public ContentHeadings(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Content Headings</para><para>Field: SubTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("sub_title_t")]
		public virtual ITextFieldWrapper SubTitle
		{
			get { return GetField<TextFieldWrapper>("Sub Title", "sub_title"); }
		}

		/// <summary><para>Template: Content Headings</para><para>Field: SubTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("sub_title")]
 		public string SubTitleValue
		{
			get { return SubTitle.Value; }
		}
		/// <summary><para>Template: Content Headings</para><para>Field: Title</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("title_t")]
		public virtual ITextFieldWrapper Title
		{
			get { return GetField<TextFieldWrapper>("Title", "title"); }
		}

		/// <summary><para>Template: Content Headings</para><para>Field: Title</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("title")]
 		public string TitleValue
		{
			get { return Title.Value; }
		}
	
	}
}
#endregion
#region Category Filter Options (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

    using Fortis.Model.RenderingParameters;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Category Filter Options</para>
	/// <para>ID: {F2CAC251-A899-4F34-ADCB-7D6BA305B419}</para>
	/// <para>/sitecore/templates/User Defined/Global/Presentation/Rendering Options/Category Filter Options</para>
	/// </summary>
	//[Rocketcore.Search.PredefinedQuery("TemplateId", ComparisonType.Equal, "{F2CAC251-A899-4F34-ADCB-7D6BA305B419}", typeof(Guid))]
	[TemplateMapping("{F2CAC251-A899-4F34-ADCB-7D6BA305B419}", "InterfaceRenderingParameter")]
	public partial interface ICategoryFilterOptions : IRenderingParameterWrapper , Demo.Model.Templates.UserDefined.IRocketcoreRenderingParameters
	{		
    	/// <summary>
		/// <para>Template: Category Filter Options</para><para>Field: Categories</para><para>Data type: Tags</para>
        /// </summary>
		IListFieldWrapper Categories { get; }
 		IEnumerable<Guid> CategoriesValue { get; }
    	/// <summary>
		/// <para>Template: Category Filter Options</para><para>Field: GroupCategoriesBy</para><para>Data type: Droplink</para>
        /// </summary>
		ILinkFieldWrapper GroupCategoriesBy { get; }
 		string GroupCategoriesByValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Global/Presentation/Rendering Options/Category Filter Options</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{F2CAC251-A899-4F34-ADCB-7D6BA305B419}", typeof(Guid))]
	[TemplateMapping("{F2CAC251-A899-4F34-ADCB-7D6BA305B419}", "RenderingParameter")]
	public partial class CategoryFilterOptions : RenderingParameterWrapper, ICategoryFilterOptions
	{
		public CategoryFilterOptions(Dictionary<string, string> parameters, ISpawnProvider spawnProvider) : base(parameters, spawnProvider)
		{
		}

		/// <summary><para>Template: Category Filter Options</para><para>Field: Categories</para><para>Data type: Tags</para></summary>
		public virtual IListFieldWrapper Categories
		{
			get { return (Fortis.Model.RenderingParameters.Fields.ListFieldWrapper)GetField("Categories", "tags"); }
		}

		/// <summary><para>Template: Category Filter Options</para><para>Field: Categories</para><para>Data type: Tags</para></summary>
 		public IEnumerable<Guid> CategoriesValue
		{
			get { return Categories.Value; }
		}
		/// <summary><para>Template: Category Filter Options</para><para>Field: GroupCategoriesBy</para><para>Data type: Droplink</para></summary>
		public virtual ILinkFieldWrapper GroupCategoriesBy
		{
			get { return (Fortis.Model.RenderingParameters.Fields.LinkFieldWrapper)GetField("Group Categories By", "droplink"); }
		}

		/// <summary><para>Template: Category Filter Options</para><para>Field: GroupCategoriesBy</para><para>Data type: Droplink</para></summary>
 		public string GroupCategoriesByValue
		{
			get { return GroupCategoriesBy.Value; }
		}
	
	}
}
#endregion
#region Categories (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;


	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Categories</para>
	/// <para>ID: {F30ACA03-1829-4944-BB74-E8124759045E}</para>
	/// <para>/sitecore/templates/User Defined/Categorisation/Categories</para>
	/// </summary>
	//[Rocketcore.Search.PredefinedQuery("TemplateId", ComparisonType.Equal, "{F30ACA03-1829-4944-BB74-E8124759045E}", typeof(Guid))]
	[TemplateMapping("{F30ACA03-1829-4944-BB74-E8124759045E}", "InterfaceMap")]
	public partial interface ICategories : IItemWrapper , Demo.Model.Templates.UserDefined.IRocketcoreStandardTemplate
	{		
    	/// <summary>
		/// <para>Template: Categories</para><para>Field: PrimaryCategory</para><para>Data type: Droptree</para>
        /// </summary>
		[IndexField("primary_category")]
		ILinkFieldWrapper PrimaryCategory { get; }

    	/// <summary>
		/// <para>Template: Categories</para><para>Field: PrimaryCategory</para><para>Data type: Droptree</para>
        /// </summary>
		[IndexField("primary_category")]
 		string PrimaryCategoryValue { get; }
    	/// <summary>
		/// <para>Template: Categories</para><para>Field: RelatedCategories</para><para>Data type: TreelistEx</para>
        /// </summary>
		[IndexField("related_categories")]
		IListFieldWrapper RelatedCategories { get; }

    	/// <summary>
		/// <para>Template: Categories</para><para>Field: RelatedCategories</para><para>Data type: TreelistEx</para>
        /// </summary>
		[IndexField("related_categories")]
 		IEnumerable<Guid> RelatedCategoriesValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Categorisation/Categories</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{F30ACA03-1829-4944-BB74-E8124759045E}", typeof(Guid))]
	[TemplateMapping("{F30ACA03-1829-4944-BB74-E8124759045E}", "")]
	public partial class Categories : ItemWrapper, ICategories
	{
		private Item _item = null;

		public Categories(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public Categories(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public Categories(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public Categories(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Categories</para><para>Field: PrimaryCategory</para><para>Data type: Droptree</para></summary>
		[IndexField("primary_category_s")]
		public virtual ILinkFieldWrapper PrimaryCategory
		{
			get { return GetField<LinkFieldWrapper>("Primary Category", "primary_category"); }
		}

		/// <summary><para>Template: Categories</para><para>Field: PrimaryCategory</para><para>Data type: Droptree</para></summary>
		[IndexField("primary_category")]
 		public string PrimaryCategoryValue
		{
			get { return PrimaryCategory.Value; }
		}
		/// <summary><para>Template: Categories</para><para>Field: RelatedCategories</para><para>Data type: TreelistEx</para></summary>
		[IndexField("related_categories_sm")]
		public virtual IListFieldWrapper RelatedCategories
		{
			get { return GetField<ListFieldWrapper>("Related Categories", "related_categories"); }
		}

		/// <summary><para>Template: Categories</para><para>Field: RelatedCategories</para><para>Data type: TreelistEx</para></summary>
		[IndexField("related_categories")]
 		public IEnumerable<Guid> RelatedCategoriesValue
		{
			get { return RelatedCategories.Value; }
		}
	
	}
}
#endregion
#region Rocketcore Permissions (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;


	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Rocketcore Permissions</para>
	/// <para>ID: {F40D98A0-19D9-407A-8541-0FC885BB452A}</para>
	/// <para>/sitecore/templates/User Defined/Rocketcore/Rocketcore Permissions</para>
	/// </summary>
	//[Rocketcore.Search.PredefinedQuery("TemplateId", ComparisonType.Equal, "{F40D98A0-19D9-407A-8541-0FC885BB452A}", typeof(Guid))]
	[TemplateMapping("{F40D98A0-19D9-407A-8541-0FC885BB452A}", "InterfaceMap")]
	public partial interface IRocketcorePermissions : IItemWrapper 
	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Rocketcore/Rocketcore Permissions</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{F40D98A0-19D9-407A-8541-0FC885BB452A}", typeof(Guid))]
	[TemplateMapping("{F40D98A0-19D9-407A-8541-0FC885BB452A}", "")]
	public partial class RocketcorePermissions : ItemWrapper, IRocketcorePermissions
	{
		private Item _item = null;

		public RocketcorePermissions(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public RocketcorePermissions(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public RocketcorePermissions(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public RocketcorePermissions(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

	
	}
}
#endregion
#region Content Body (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;


	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Content Body</para>
	/// <para>ID: {F884BA23-8688-4808-95C3-52E554F8A8FC}</para>
	/// <para>/sitecore/templates/User Defined/Generic/Content Body</para>
	/// </summary>
	//[Rocketcore.Search.PredefinedQuery("TemplateId", ComparisonType.Equal, "{F884BA23-8688-4808-95C3-52E554F8A8FC}", typeof(Guid))]
	[TemplateMapping("{F884BA23-8688-4808-95C3-52E554F8A8FC}", "InterfaceMap")]
	public partial interface IContentBody : IItemWrapper , Demo.Model.Templates.UserDefined.IRocketcoreStandardTemplate
	{		
    	/// <summary>
		/// <para>Template: Content Body</para><para>Field: Body</para><para>Data type: Rich Text</para>
        /// </summary>
		[IndexField("body")]
		IRichTextFieldWrapper Body { get; }

    	/// <summary>
		/// <para>Template: Content Body</para><para>Field: Body</para><para>Data type: Rich Text</para>
        /// </summary>
		[IndexField("body")]
 		string BodyValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Generic/Content Body</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{F884BA23-8688-4808-95C3-52E554F8A8FC}", typeof(Guid))]
	[TemplateMapping("{F884BA23-8688-4808-95C3-52E554F8A8FC}", "")]
	public partial class ContentBody : ItemWrapper, IContentBody
	{
		private Item _item = null;

		public ContentBody(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public ContentBody(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public ContentBody(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public ContentBody(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Content Body</para><para>Field: Body</para><para>Data type: Rich Text</para></summary>
		[IndexField("body_t")]
		public virtual IRichTextFieldWrapper Body
		{
			get { return GetField<RichTextFieldWrapper>("Body", "body"); }
		}

		/// <summary><para>Template: Content Body</para><para>Field: Body</para><para>Data type: Rich Text</para></summary>
		[IndexField("body")]
 		public string BodyValue
		{
			get { return Body.Value; }
		}
	
	}
}
#endregion
#region Category (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;


	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Category</para>
	/// <para>ID: {F93E0257-281B-4B9B-B6E1-8FDF5B6A8829}</para>
	/// <para>/sitecore/templates/User Defined/Categorisation/Category</para>
	/// </summary>
	//[Rocketcore.Search.PredefinedQuery("TemplateId", ComparisonType.Equal, "{F93E0257-281B-4B9B-B6E1-8FDF5B6A8829}", typeof(Guid))]
	[TemplateMapping("{F93E0257-281B-4B9B-B6E1-8FDF5B6A8829}", "InterfaceMap")]
	public partial interface ICategory : IItemWrapper , Demo.Model.Templates.UserDefined.IRocketcoreStandardTemplate, Demo.Model.Templates.UserDefined.IContentHeadings
	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Categorisation/Category</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{F93E0257-281B-4B9B-B6E1-8FDF5B6A8829}", typeof(Guid))]
	[TemplateMapping("{F93E0257-281B-4B9B-B6E1-8FDF5B6A8829}", "")]
	public partial class Category : ItemWrapper, ICategory
	{
		private Item _item = null;

		public Category(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public Category(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public Category(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public Category(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Category</para><para>Field: SubTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("sub_title_t")]
		public virtual ITextFieldWrapper SubTitle
		{
			get { return GetField<TextFieldWrapper>("Sub Title", "sub_title"); }
		}

		/// <summary><para>Template: Category</para><para>Field: SubTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("sub_title")]
 		public string SubTitleValue
		{
			get { return SubTitle.Value; }
		}
		/// <summary><para>Template: Category</para><para>Field: Title</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("title_t")]
		public virtual ITextFieldWrapper Title
		{
			get { return GetField<TextFieldWrapper>("Title", "title"); }
		}

		/// <summary><para>Template: Category</para><para>Field: Title</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("title")]
 		public string TitleValue
		{
			get { return Title.Value; }
		}
	
	}
}
#endregion
#region Lookup (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;


	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Lookup</para>
	/// <para>ID: {FAAF2F41-C07C-4146-8C4D-1C7DC29EE12D}</para>
	/// <para>/sitecore/templates/User Defined/Global/Lookup/Lookup</para>
	/// </summary>
	//[Rocketcore.Search.PredefinedQuery("TemplateId", ComparisonType.Equal, "{FAAF2F41-C07C-4146-8C4D-1C7DC29EE12D}", typeof(Guid))]
	[TemplateMapping("{FAAF2F41-C07C-4146-8C4D-1C7DC29EE12D}", "InterfaceMap")]
	public partial interface ILookup : IItemWrapper , Demo.Model.Templates.UserDefined.IRocketcoreStandardTemplate
	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Global/Lookup/Lookup</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{FAAF2F41-C07C-4146-8C4D-1C7DC29EE12D}", typeof(Guid))]
	[TemplateMapping("{FAAF2F41-C07C-4146-8C4D-1C7DC29EE12D}", "")]
	public partial class Lookup : ItemWrapper, ILookup
	{
		private Item _item = null;

		public Lookup(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public Lookup(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public Lookup(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public Lookup(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

	
	}
}
#endregion
#region Call To Action List Options (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

    using Fortis.Model.RenderingParameters;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Call To Action List Options</para>
	/// <para>ID: {FB56AAF5-CFA4-4D50-91D0-E1121E4AB0D1}</para>
	/// <para>/sitecore/templates/User Defined/Call To Action/Rendering Options/Call To Action List Options</para>
	/// </summary>
	//[Rocketcore.Search.PredefinedQuery("TemplateId", ComparisonType.Equal, "{FB56AAF5-CFA4-4D50-91D0-E1121E4AB0D1}", typeof(Guid))]
	[TemplateMapping("{FB56AAF5-CFA4-4D50-91D0-E1121E4AB0D1}", "InterfaceRenderingParameter")]
	public partial interface ICallToActionListOptions : IRenderingParameterWrapper , Demo.Model.Templates.UserDefined.IRocketcoreRenderingParameters, Demo.Model.Templates.UserDefined.ISelectionOptions, Demo.Model.Templates.UserDefined.IAggregateOptions, Demo.Model.Templates.UserDefined.ITaggingFilterOptions, Demo.Model.Templates.UserDefined.IOrderingOptions, Demo.Model.Templates.UserDefined.IPaginationOptions, Demo.Model.Templates.UserDefined.IPhraseHeading
	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Call To Action/Rendering Options/Call To Action List Options</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{FB56AAF5-CFA4-4D50-91D0-E1121E4AB0D1}", typeof(Guid))]
	[TemplateMapping("{FB56AAF5-CFA4-4D50-91D0-E1121E4AB0D1}", "RenderingParameter")]
	public partial class CallToActionListOptions : RenderingParameterWrapper, ICallToActionListOptions
	{
		public CallToActionListOptions(Dictionary<string, string> parameters, ISpawnProvider spawnProvider) : base(parameters, spawnProvider)
		{
		}

		/// <summary><para>Template: Call To Action List Options</para><para>Field: SelectionMethod</para><para>Data type: Droplink</para></summary>
		public virtual ILinkFieldWrapper SelectionMethod
		{
			get { return (Fortis.Model.RenderingParameters.Fields.LinkFieldWrapper)GetField("Selection Method", "droplink"); }
		}

		/// <summary><para>Template: Call To Action List Options</para><para>Field: SelectionMethod</para><para>Data type: Droplink</para></summary>
 		public string SelectionMethodValue
		{
			get { return SelectionMethod.Value; }
		}
		/// <summary><para>Template: Call To Action List Options</para><para>Field: AggregateBy</para><para>Data type: Droplink</para></summary>
		public virtual ILinkFieldWrapper AggregateBy
		{
			get { return (Fortis.Model.RenderingParameters.Fields.LinkFieldWrapper)GetField("Aggregate By", "droplink"); }
		}

		/// <summary><para>Template: Call To Action List Options</para><para>Field: AggregateBy</para><para>Data type: Droplink</para></summary>
 		public string AggregateByValue
		{
			get { return AggregateBy.Value; }
		}
		/// <summary><para>Template: Call To Action List Options</para><para>Field: GroupTagsBy</para><para>Data type: Droplink</para></summary>
		public virtual ILinkFieldWrapper GroupTagsBy
		{
			get { return (Fortis.Model.RenderingParameters.Fields.LinkFieldWrapper)GetField("Group Tags By", "droplink"); }
		}

		/// <summary><para>Template: Call To Action List Options</para><para>Field: GroupTagsBy</para><para>Data type: Droplink</para></summary>
 		public string GroupTagsByValue
		{
			get { return GroupTagsBy.Value; }
		}
		/// <summary><para>Template: Call To Action List Options</para><para>Field: Tags</para><para>Data type: Tags</para></summary>
		public virtual IListFieldWrapper Tags
		{
			get { return (Fortis.Model.RenderingParameters.Fields.ListFieldWrapper)GetField("Tags", "tags"); }
		}

		/// <summary><para>Template: Call To Action List Options</para><para>Field: Tags</para><para>Data type: Tags</para></summary>
 		public IEnumerable<Guid> TagsValue
		{
			get { return Tags.Value; }
		}
		/// <summary><para>Template: Call To Action List Options</para><para>Field: OrderBy</para><para>Data type: Droplink</para></summary>
		public virtual ILinkFieldWrapper OrderBy
		{
			get { return (Fortis.Model.RenderingParameters.Fields.LinkFieldWrapper)GetField("Order By", "droplink"); }
		}

		/// <summary><para>Template: Call To Action List Options</para><para>Field: OrderBy</para><para>Data type: Droplink</para></summary>
 		public string OrderByValue
		{
			get { return OrderBy.Value; }
		}
		/// <summary><para>Template: Call To Action List Options</para><para>Field: OrderDirection</para><para>Data type: Droplink</para></summary>
		public virtual ILinkFieldWrapper OrderDirection
		{
			get { return (Fortis.Model.RenderingParameters.Fields.LinkFieldWrapper)GetField("Order Direction", "droplink"); }
		}

		/// <summary><para>Template: Call To Action List Options</para><para>Field: OrderDirection</para><para>Data type: Droplink</para></summary>
 		public string OrderDirectionValue
		{
			get { return OrderDirection.Value; }
		}
		/// <summary><para>Template: Call To Action List Options</para><para>Field: ItemsPerPage</para><para>Data type: Integer</para></summary>
		public virtual IIntegerFieldWrapper ItemsPerPage
		{
			get { return (Fortis.Model.RenderingParameters.Fields.IntegerFieldWrapper)GetField("Items Per Page", "integer"); }
		}

		/// <summary><para>Template: Call To Action List Options</para><para>Field: ItemsPerPage</para><para>Data type: Integer</para></summary>
 		public long ItemsPerPageValue
		{
			get { return ItemsPerPage.Value; }
		}
		/// <summary><para>Template: Call To Action List Options</para><para>Field: Heading</para><para>Data type: Droptree</para></summary>
		public virtual ILinkFieldWrapper Heading
		{
			get { return (Fortis.Model.RenderingParameters.Fields.LinkFieldWrapper)GetField("Heading", "droptree"); }
		}

		/// <summary><para>Template: Call To Action List Options</para><para>Field: Heading</para><para>Data type: Droptree</para></summary>
 		public string HeadingValue
		{
			get { return Heading.Value; }
		}
	
	}
}
#endregion
#region Filter Options (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

    using Fortis.Model.RenderingParameters;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Filter Options</para>
	/// <para>ID: {FE222C7A-3E9C-4D05-808C-972968FC5E81}</para>
	/// <para>/sitecore/templates/User Defined/Global/Presentation/Rendering Options/Filter Options</para>
	/// </summary>
	//[Rocketcore.Search.PredefinedQuery("TemplateId", ComparisonType.Equal, "{FE222C7A-3E9C-4D05-808C-972968FC5E81}", typeof(Guid))]
	[TemplateMapping("{FE222C7A-3E9C-4D05-808C-972968FC5E81}", "InterfaceRenderingParameter")]
	public partial interface IFilterOptions : IRenderingParameterWrapper , Demo.Model.Templates.UserDefined.IRocketcoreRenderingParameters, Demo.Model.Templates.UserDefined.ITaggingFilterOptions, Demo.Model.Templates.UserDefined.ICategoryFilterOptions
	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Global/Presentation/Rendering Options/Filter Options</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{FE222C7A-3E9C-4D05-808C-972968FC5E81}", typeof(Guid))]
	[TemplateMapping("{FE222C7A-3E9C-4D05-808C-972968FC5E81}", "RenderingParameter")]
	public partial class FilterOptions : RenderingParameterWrapper, IFilterOptions
	{
		public FilterOptions(Dictionary<string, string> parameters, ISpawnProvider spawnProvider) : base(parameters, spawnProvider)
		{
		}

		/// <summary><para>Template: Filter Options</para><para>Field: GroupTagsBy</para><para>Data type: Droplink</para></summary>
		public virtual ILinkFieldWrapper GroupTagsBy
		{
			get { return (Fortis.Model.RenderingParameters.Fields.LinkFieldWrapper)GetField("Group Tags By", "droplink"); }
		}

		/// <summary><para>Template: Filter Options</para><para>Field: GroupTagsBy</para><para>Data type: Droplink</para></summary>
 		public string GroupTagsByValue
		{
			get { return GroupTagsBy.Value; }
		}
		/// <summary><para>Template: Filter Options</para><para>Field: Tags</para><para>Data type: Tags</para></summary>
		public virtual IListFieldWrapper Tags
		{
			get { return (Fortis.Model.RenderingParameters.Fields.ListFieldWrapper)GetField("Tags", "tags"); }
		}

		/// <summary><para>Template: Filter Options</para><para>Field: Tags</para><para>Data type: Tags</para></summary>
 		public IEnumerable<Guid> TagsValue
		{
			get { return Tags.Value; }
		}
		/// <summary><para>Template: Filter Options</para><para>Field: Categories</para><para>Data type: Tags</para></summary>
		public virtual IListFieldWrapper Categories
		{
			get { return (Fortis.Model.RenderingParameters.Fields.ListFieldWrapper)GetField("Categories", "tags"); }
		}

		/// <summary><para>Template: Filter Options</para><para>Field: Categories</para><para>Data type: Tags</para></summary>
 		public IEnumerable<Guid> CategoriesValue
		{
			get { return Categories.Value; }
		}
		/// <summary><para>Template: Filter Options</para><para>Field: GroupCategoriesBy</para><para>Data type: Droplink</para></summary>
		public virtual ILinkFieldWrapper GroupCategoriesBy
		{
			get { return (Fortis.Model.RenderingParameters.Fields.LinkFieldWrapper)GetField("Group Categories By", "droplink"); }
		}

		/// <summary><para>Template: Filter Options</para><para>Field: GroupCategoriesBy</para><para>Data type: Droplink</para></summary>
 		public string GroupCategoriesByValue
		{
			get { return GroupCategoriesBy.Value; }
		}
	
	}
}
#endregion
