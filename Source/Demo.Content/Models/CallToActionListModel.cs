using Demo.Model.Templates.UserDefined;
using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Content.Models
{
	public class CallToActionListModel : ICallToActionListModel
	{
		public ITextPhrase Header { get; set; }
		public IEnumerable<ICallToAction> CallToActions { get; set; }
	}
}
