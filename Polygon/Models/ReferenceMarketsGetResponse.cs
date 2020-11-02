﻿using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace Polygon.Models
{
	public class ReferenceMarketsGetResponse
	{
		/// <summary>
		/// Gets or Sets Status
		/// </summary>

		[JsonPropertyName("status")]
		public string Status { get; set; }

		/// <summary>
		/// Gets or Sets Results
		/// </summary>
		[JsonPropertyName("results")]
		public List<string> Results { get; set; }

	}
}
