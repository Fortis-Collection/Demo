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
		public Item Header { get; set; }
		public IEnumerable<Item> CallToActions { get; set; }
	}
}
