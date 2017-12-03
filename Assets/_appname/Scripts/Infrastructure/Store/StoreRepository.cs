using UnityEngine;

namespace Polycube.Infrastructure
{
    public static class StoreRepository
    {
        private const string STORE_DATA_KEY = "StoreData";
        private const string CONFIG_RESOURCE_PATH = "Prefabs/Common/StoreConfig";

        public static StoreConfig GetStoreConfig()
        {
            return Object.Instantiate(Resources.Load<StoreConfig>(CONFIG_RESOURCE_PATH));
        }

        public static StoreStats GetStoreStats()
        {
            return LocalStorage.Get<StoreStats>(STORE_DATA_KEY) ?? new StoreStats();
        }

        public static void Save(StoreStats stats)
        {
            LocalStorage.Set(STORE_DATA_KEY, stats);
        }
    }
}
