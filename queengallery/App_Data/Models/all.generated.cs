using  System;
using  System.Collections.Generic;
using  System.Linq.Expressions;
using  System.Web;
using  Umbraco.Core.Models;
using  Umbraco.Core.Models.PublishedContent;
using  Umbraco.Web;
using  Umbraco.ModelsBuilder;
using  Umbraco.ModelsBuilder.Umbraco;
[assembly: PureLiveAssembly]
[assembly:ModelsBuilderAssembly(PureLive = true, SourceHash = "4f51bb1ec02531c8")]
[assembly:System.Reflection.AssemblyVersion("0.0.0.1")]


// FILE: models.generated.cs

//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.4.0
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------















namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>EXHIBITION</summary>
	[PublishedContentModel("BlogPost")]
	public partial class BlogPost : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "BlogPost";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public BlogPost(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<BlogPost, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Artist
		///</summary>
		[ImplementPropertyType("artist")]
		public string Artist
		{
			get { return this.GetPropertyValue<string>("artist"); }
		}

		///<summary>
		/// Content
		///</summary>
		[ImplementPropertyType("content")]
		public Newtonsoft.Json.Linq.JToken Content
		{
			get { return this.GetPropertyValue<Newtonsoft.Json.Linq.JToken>("content"); }
		}

		///<summary>
		/// ContentEn
		///</summary>
		[ImplementPropertyType("contentEn")]
		public IHtmlString ContentEn
		{
			get { return this.GetPropertyValue<IHtmlString>("contentEn"); }
		}

		///<summary>
		/// ContentGridEn
		///</summary>
		[ImplementPropertyType("contentGridEn")]
		public Newtonsoft.Json.Linq.JToken ContentGridEn
		{
			get { return this.GetPropertyValue<Newtonsoft.Json.Linq.JToken>("contentGridEn"); }
		}

		///<summary>
		/// ContentTh
		///</summary>
		[ImplementPropertyType("contentTh")]
		public IHtmlString ContentTh
		{
			get { return this.GetPropertyValue<IHtmlString>("contentTh"); }
		}

		///<summary>
		/// From
		///</summary>
		[ImplementPropertyType("from")]
		public DateTime From
		{
			get { return this.GetPropertyValue<DateTime>("from"); }
		}

		///<summary>
		/// Introduction
		///</summary>
		[ImplementPropertyType("introduction")]
		public string Introduction
		{
			get { return this.GetPropertyValue<string>("introduction"); }
		}

		///<summary>
		/// IntroductionEn
		///</summary>
		[ImplementPropertyType("introductionEn")]
		public string IntroductionEn
		{
			get { return this.GetPropertyValue<string>("introductionEn"); }
		}

		///<summary>
		/// IntroductionTh
		///</summary>
		[ImplementPropertyType("introductionTh")]
		public string IntroductionTh
		{
			get { return this.GetPropertyValue<string>("introductionTh"); }
		}

		///<summary>
		/// Logo
		///</summary>
		[ImplementPropertyType("logo")]
		public Umbraco.Web.Models.ImageCropDataSet Logo
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("logo"); }
		}

		///<summary>
		/// NameEn
		///</summary>
		[ImplementPropertyType("nameEn")]
		public string NameEn
		{
			get { return this.GetPropertyValue<string>("nameEn"); }
		}

		///<summary>
		/// NameTh
		///</summary>
		[ImplementPropertyType("nameTh")]
		public string NameTh
		{
			get { return this.GetPropertyValue<string>("nameTh"); }
		}

		///<summary>
		/// To
		///</summary>
		[ImplementPropertyType("to")]
		public DateTime To
		{
			get { return this.GetPropertyValue<DateTime>("to"); }
		}
	}

	// Mixin content Type 1059 with alias "BlogPostRepository"
	/// <summary>Blog Post Repository</summary>
	public partial interface IBlogPostRepository : IPublishedContent
	{
		/// <summary>Hide in bottom navigation?</summary>
		bool UmbracoNaviHide { get; }
	}

	/// <summary>Blog Post Repository</summary>
	[PublishedContentModel("BlogPostRepository")]
	public partial class BlogPostRepository : PublishedContentModel, IBlogPostRepository
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "BlogPostRepository";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public BlogPostRepository(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<BlogPostRepository, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Hide in bottom navigation?
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return GetUmbracoNaviHide(this); }
		}

		/// <summary>Static getter for Hide in bottom navigation?</summary>
		public static bool GetUmbracoNaviHide(IBlogPostRepository that) { return that.GetPropertyValue<bool>("umbracoNaviHide"); }
	}

	/// <summary>Home</summary>
	[PublishedContentModel("Home")]
	public partial class Home : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Home";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Home(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Home, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Content
		///</summary>
		[ImplementPropertyType("content")]
		public Newtonsoft.Json.Linq.JToken Content
		{
			get { return this.GetPropertyValue<Newtonsoft.Json.Linq.JToken>("content"); }
		}

		///<summary>
		/// Hide in navigation?
		///</summary>
		[ImplementPropertyType("hideInNavigation")]
		public bool HideInNavigation
		{
			get { return this.GetPropertyValue<bool>("hideInNavigation"); }
		}

		///<summary>
		/// Site Description
		///</summary>
		[ImplementPropertyType("siteDescription")]
		public string SiteDescription
		{
			get { return this.GetPropertyValue<string>("siteDescription"); }
		}

		///<summary>
		/// Site Logo
		///</summary>
		[ImplementPropertyType("siteLogo")]
		public object SiteLogo
		{
			get { return this.GetPropertyValue("siteLogo"); }
		}

		///<summary>
		/// Site Title
		///</summary>
		[ImplementPropertyType("siteTitle")]
		public string SiteTitle
		{
			get { return this.GetPropertyValue<string>("siteTitle"); }
		}
	}

	/// <summary>Landing Page</summary>
	[PublishedContentModel("LandingPage")]
	public partial class LandingPage : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "LandingPage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public LandingPage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<LandingPage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Content
		///</summary>
		[ImplementPropertyType("content")]
		public Newtonsoft.Json.Linq.JToken Content
		{
			get { return this.GetPropertyValue<Newtonsoft.Json.Linq.JToken>("content"); }
		}

		///<summary>
		/// Hide in bottom navigation?
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return this.GetPropertyValue<bool>("umbracoNaviHide"); }
		}
	}

	/// <summary>Text Page</summary>
	[PublishedContentModel("TextPage")]
	public partial class TextPage : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "TextPage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public TextPage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<TextPage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Content
		///</summary>
		[ImplementPropertyType("content")]
		public Newtonsoft.Json.Linq.JToken Content
		{
			get { return this.GetPropertyValue<Newtonsoft.Json.Linq.JToken>("content"); }
		}
	}

	/// <summary>Site</summary>
	[PublishedContentModel("site")]
	public partial class Site : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "site";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Site(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Site, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Site Logo
		///</summary>
		[ImplementPropertyType("siteLogo")]
		public object SiteLogo
		{
			get { return this.GetPropertyValue("siteLogo"); }
		}

		///<summary>
		/// Site Name
		///</summary>
		[ImplementPropertyType("siteName")]
		public string SiteName
		{
			get { return this.GetPropertyValue<string>("siteName"); }
		}
	}

	/// <summary>News</summary>
	[PublishedContentModel("news")]
	public partial class News : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "news";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public News(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<News, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// ImageEn
		///</summary>
		[ImplementPropertyType("imageEn")]
		public Umbraco.Web.Models.ImageCropDataSet ImageEn
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("imageEn"); }
		}

		///<summary>
		/// ImageTh
		///</summary>
		[ImplementPropertyType("imageTh")]
		public Umbraco.Web.Models.ImageCropDataSet ImageTh
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("imageTh"); }
		}

		///<summary>
		/// NewsDate
		///</summary>
		[ImplementPropertyType("newsDate")]
		public DateTime NewsDate
		{
			get { return this.GetPropertyValue<DateTime>("newsDate"); }
		}

		///<summary>
		/// NewsType
		///</summary>
		[ImplementPropertyType("newsType")]
		public object NewsType
		{
			get { return this.GetPropertyValue("newsType"); }
		}

		///<summary>
		/// PdfEn
		///</summary>
		[ImplementPropertyType("pdfEn")]
		public object PdfEn
		{
			get { return this.GetPropertyValue("pdfEn"); }
		}

		///<summary>
		/// PdfTh
		///</summary>
		[ImplementPropertyType("pdfTh")]
		public object PdfTh
		{
			get { return this.GetPropertyValue("pdfTh"); }
		}

		///<summary>
		/// TextEn
		///</summary>
		[ImplementPropertyType("textEn")]
		public IHtmlString TextEn
		{
			get { return this.GetPropertyValue<IHtmlString>("textEn"); }
		}

		///<summary>
		/// TextTh
		///</summary>
		[ImplementPropertyType("textTh")]
		public IHtmlString TextTh
		{
			get { return this.GetPropertyValue<IHtmlString>("textTh"); }
		}
	}

	/// <summary>EXHIBITIONS Post Repository</summary>
	[PublishedContentModel("eXHIBITIONSPostRepository")]
	public partial class EXhibitionspostRepository : PublishedContentModel, IBlogPostRepository
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "eXHIBITIONSPostRepository";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public EXhibitionspostRepository(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<EXhibitionspostRepository, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Hide in bottom navigation?
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return BlogPostRepository.GetUmbracoNaviHide(this); }
		}
	}

	/// <summary>EXHIBITIONS Post</summary>
	[PublishedContentModel("eXHIBITIONSPost")]
	public partial class EXhibitionspost : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "eXHIBITIONSPost";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public EXhibitionspost(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<EXhibitionspost, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// content
		///</summary>
		[ImplementPropertyType("content")]
		public Newtonsoft.Json.Linq.JToken Content
		{
			get { return this.GetPropertyValue<Newtonsoft.Json.Linq.JToken>("content"); }
		}

		///<summary>
		/// Introduction
		///</summary>
		[ImplementPropertyType("introduction")]
		public string Introduction
		{
			get { return this.GetPropertyValue<string>("introduction"); }
		}
	}

	// Mixin content Type 1031 with alias "Folder"
	/// <summary>Folder</summary>
	public partial interface IFolder : IPublishedContent
	{
		/// <summary>Contents:</summary>
		object Contents { get; }
	}

	/// <summary>Folder</summary>
	[PublishedContentModel("Folder")]
	public partial class Folder : PublishedContentModel, IFolder
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Folder";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Folder(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Folder, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Contents:
		///</summary>
		[ImplementPropertyType("contents")]
		public object Contents
		{
			get { return GetContents(this); }
		}

		/// <summary>Static getter for Contents:</summary>
		public static object GetContents(IFolder that) { return that.GetPropertyValue("contents"); }
	}

	/// <summary>Image</summary>
	[PublishedContentModel("Image")]
	public partial class Image : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Image";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Image(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Image, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload image
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public Umbraco.Web.Models.ImageCropDataSet UmbracoFile
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("umbracoFile"); }
		}

		///<summary>
		/// Height
		///</summary>
		[ImplementPropertyType("umbracoHeight")]
		public string UmbracoHeight
		{
			get { return this.GetPropertyValue<string>("umbracoHeight"); }
		}

		///<summary>
		/// Width
		///</summary>
		[ImplementPropertyType("umbracoWidth")]
		public string UmbracoWidth
		{
			get { return this.GetPropertyValue<string>("umbracoWidth"); }
		}
	}

	/// <summary>File</summary>
	[PublishedContentModel("File")]
	public partial class File : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "File";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public File(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<File, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload file
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public object UmbracoFile
		{
			get { return this.GetPropertyValue("umbracoFile"); }
		}
	}

	/// <summary>Art Piece</summary>
	[PublishedContentModel("artPiece")]
	public partial class ArtPiece : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "artPiece";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public ArtPiece(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ArtPiece, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// DescriptionEn
		///</summary>
		[ImplementPropertyType("descriptionEn")]
		public IHtmlString DescriptionEn
		{
			get { return this.GetPropertyValue<IHtmlString>("descriptionEn"); }
		}

		///<summary>
		/// DescriptionTh
		///</summary>
		[ImplementPropertyType("descriptionTh")]
		public IHtmlString DescriptionTh
		{
			get { return this.GetPropertyValue<IHtmlString>("descriptionTh"); }
		}

		///<summary>
		/// Image
		///</summary>
		[ImplementPropertyType("image")]
		public Umbraco.Web.Models.ImageCropDataSet Image
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("image"); }
		}

		///<summary>
		/// NameEn
		///</summary>
		[ImplementPropertyType("nameEn")]
		public string NameEn
		{
			get { return this.GetPropertyValue<string>("nameEn"); }
		}

		///<summary>
		/// NameTh
		///</summary>
		[ImplementPropertyType("nameTh")]
		public string NameTh
		{
			get { return this.GetPropertyValue<string>("nameTh"); }
		}

		///<summary>
		/// TitleEn
		///</summary>
		[ImplementPropertyType("titleEn")]
		public string TitleEn
		{
			get { return this.GetPropertyValue<string>("titleEn"); }
		}

		///<summary>
		/// TitleTh
		///</summary>
		[ImplementPropertyType("titleTh")]
		public string TitleTh
		{
			get { return this.GetPropertyValue<string>("titleTh"); }
		}
	}

	/// <summary>Artist</summary>
	[PublishedContentModel("artist")]
	public partial class Artist : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "artist";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Artist(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Artist, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// BiographyEn
		///</summary>
		[ImplementPropertyType("biographyEn")]
		public IHtmlString BiographyEn
		{
			get { return this.GetPropertyValue<IHtmlString>("biographyEn"); }
		}

		///<summary>
		/// BiographyTh
		///</summary>
		[ImplementPropertyType("biographyTh")]
		public IHtmlString BiographyTh
		{
			get { return this.GetPropertyValue<IHtmlString>("biographyTh"); }
		}

		///<summary>
		/// DescriptionEn
		///</summary>
		[ImplementPropertyType("descriptionEn")]
		public string DescriptionEn
		{
			get { return this.GetPropertyValue<string>("descriptionEn"); }
		}

		///<summary>
		/// DescriptionTh
		///</summary>
		[ImplementPropertyType("descriptionTh")]
		public string DescriptionTh
		{
			get { return this.GetPropertyValue<string>("descriptionTh"); }
		}

		///<summary>
		/// Image
		///</summary>
		[ImplementPropertyType("image")]
		public Umbraco.Web.Models.ImageCropDataSet Image
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("image"); }
		}

		///<summary>
		/// NameEn
		///</summary>
		[ImplementPropertyType("nameEn")]
		public string NameEn
		{
			get { return this.GetPropertyValue<string>("nameEn"); }
		}

		///<summary>
		/// NameTh
		///</summary>
		[ImplementPropertyType("nameTh")]
		public string NameTh
		{
			get { return this.GetPropertyValue<string>("nameTh"); }
		}
	}

	/// <summary>Artist Folder</summary>
	[PublishedContentModel("artistFolder")]
	public partial class ArtistFolder : PublishedContentModel, IFolder
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "artistFolder";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public ArtistFolder(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ArtistFolder, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Contents:
		///</summary>
		[ImplementPropertyType("contents")]
		public object Contents
		{
			get { return Folder.GetContents(this); }
		}
	}

	/// <summary>Member</summary>
	[PublishedContentModel("Member")]
	public partial class Member : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Member";
		public new const PublishedItemType ModelItemType = PublishedItemType.Member;
#pragma warning restore 0109

		public Member(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Member, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Is Approved
		///</summary>
		[ImplementPropertyType("umbracoMemberApproved")]
		public bool UmbracoMemberApproved
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberApproved"); }
		}

		///<summary>
		/// Comments
		///</summary>
		[ImplementPropertyType("umbracoMemberComments")]
		public string UmbracoMemberComments
		{
			get { return this.GetPropertyValue<string>("umbracoMemberComments"); }
		}

		///<summary>
		/// Failed Password Attempts
		///</summary>
		[ImplementPropertyType("umbracoMemberFailedPasswordAttempts")]
		public string UmbracoMemberFailedPasswordAttempts
		{
			get { return this.GetPropertyValue<string>("umbracoMemberFailedPasswordAttempts"); }
		}

		///<summary>
		/// Last Lockout Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLockoutDate")]
		public string UmbracoMemberLastLockoutDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLockoutDate"); }
		}

		///<summary>
		/// Last Login Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLogin")]
		public string UmbracoMemberLastLogin
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLogin"); }
		}

		///<summary>
		/// Last Password Change Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastPasswordChangeDate")]
		public string UmbracoMemberLastPasswordChangeDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastPasswordChangeDate"); }
		}

		///<summary>
		/// Is Locked Out
		///</summary>
		[ImplementPropertyType("umbracoMemberLockedOut")]
		public bool UmbracoMemberLockedOut
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberLockedOut"); }
		}

		///<summary>
		/// Password Answer
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalAnswer")]
		public string UmbracoMemberPasswordRetrievalAnswer
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalAnswer"); }
		}

		///<summary>
		/// Password Question
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalQuestion")]
		public string UmbracoMemberPasswordRetrievalQuestion
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalQuestion"); }
		}
	}

}



// EOF
