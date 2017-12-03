using System;
using UnityEngine;

namespace Polycube.Infrastructure
{
    public static class StoreService
    {
        public static void OpenStore(StoreConfig config, StoreStats stats)
        {
            stats.ElapsedTimeSinceSuggestion = 0;
            stats.LastRateVersion = Application.version;

            var url = GetStoreUrl(config.AppStoreId, config.PlayStoreId);
            Application.OpenURL(url);

            StoreRepository.Save(stats);
        }

        public static void Defer(StoreStats stats)
        {
            stats.ElapsedTimeSinceSuggestion = 0;
            StoreRepository.Save(stats);
        }

        public static bool IsRated(StoreStats stats)
        {
            return Application.version == stats.LastRateVersion;
        }

        public static bool IsRateAvailable(StoreStats stats)
        {
            const long THRESHOLD = 600000L; // 10 minutes in milliseconds
            return !IsRated(stats) && stats.ElapsedTimeSinceSuggestion > THRESHOLD;
        }

        public static string GetStoreUrl(string iTunesAppId, string googlePlayMarketAppBundleId) 
        {
            string url = "";
            #if (UNITY_IPHONE || UNITY_EDITOR)
            url = String.Format("https://itunes.apple.com/app/id{0}",  WWW.EscapeURL(iTunesAppId));
            #endif
            #if UNITY_ANDROID
            url = String.Format("https://play.google.com/store/apps/details?id={0}",  WWW.EscapeURL(googlePlayMarketAppBundleId));
            #endif
            return url;
        }
    }
}
