using System;

namespace Polycube.Infrastructure
{
    [Serializable]
    public class StoreStats
    {
        /// <summary>
        /// Time in milliseconds since last rate suggestion confirmation
        /// </summary>
        public long ElapsedTimeSinceSuggestion;

        public string LastRateVersion;
    }
}
