// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TagsResponse.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using MailChimp.Net.Models;

using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
	public class MemberEventsResponse
	{
		public MemberEventsResponse()
		{
			Events = new List<MemberEvent>();
		}

		/// <summary>
		/// Gets or sets the tags.
		/// </summary>
		[JsonProperty("events")]
		public IEnumerable<MemberEvent> Events { get; set; }

		/// <summary>
		/// Gets or sets the number of tags.
		/// </summary>
		[JsonProperty("total_items")]
		public int NumberOfEvents { get; set; }

        [JsonProperty("_links")]
        public ICollection<Link> Links { get; set; }
    }
}
