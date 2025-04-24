using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagato.Models
{
    public class BuildInformation
    {
        /// <summary>
        /// Commit Hash
        /// </summary>
        [JsonProperty("commit_sha")]
        public string? CommitHash { get; set; }

        /// <summary>
        /// Commit Timestamp
        /// </summary>
        [JsonProperty("commit_timestamp")]
        public string? CommitTimestamp { get; set; }

        /// <summary>
        /// Git Semver
        /// </summary>
        [JsonProperty("semver")]
        public string? SemanticVersion { get; set; }

        /// <summary>
        /// Git Origin Url
        /// </summary>
        [JsonProperty("origin_url")]
        public string? OriginUrl { get; set; }

        /// <summary>
        /// Build Timestamp
        /// </summary>
        [JsonProperty("timestamp")]
        public string? BuildTimestamp { get; set; }
    }
}
