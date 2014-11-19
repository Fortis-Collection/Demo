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
		Item Header { get; }
		IEnumerable<Item> CallToActions { get; }
	}
}
