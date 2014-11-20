using Demo.Model.Templates.UserDefined;
using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Content.Models
{
	public interface ICallToActionListModel
	{
		ITextPhrase Header { get; }
		IEnumerable<ICallToAction> CallToActions { get; }
	}
}
