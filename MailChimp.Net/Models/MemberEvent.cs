// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Member.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using MailChimp.Net.Core;

using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
	/// <summary>
	/// The tag for a member
	/// </summary>
	public class MemberEvent
	{
		/// <summary>
		/// Gets or sets the time the event occurred
		/// </summary>
		[JsonProperty("occurred_at")]
		public string OccurredAt { get; set; }

		/// <summary>
		/// Gets or sets the tag's name.
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

        /// <summary>
        /// Gets or sets the event's optional list of properties
        /// </summary>
        [JsonProperty("properties")]
        public Dictionary<string, string> Properties { get; set; }

    }

    /// <summary>
    /// Adds the IsSyncing property to the MemberEvent class for use when creating new events.
    /// </summary>
    public class MemberEventDTO : MemberEvent
    {
        /// <summary>
        /// Gets or sets the IsSyncing property. Events created with the is_syncing value set to True will not trigger automations.
        /// </summary>
        [JsonProperty("is_syncing")]
        public bool IsSyncing { get; set; }
    }

}
