using UnityEngine;

namespace Polycube.Infrastructure
{
    public class StoreController : MonoBehaviour
    {
        private StoreStats _storeStats;
        private StoreConfig _storeConfig;
        private float _elapsedTime;

        private static StoreController _instance;

        public static void OpenStore()
        {
            StoreService.OpenStore(_instance._storeConfig, _instance._storeStats);
        }

        public static void Defer()
        {
            StoreService.Defer(_instance._storeStats);
        }

        public static bool IsRated()
        {
            return StoreService.IsRated(_instance._storeStats);
        }

        public static bool IsRateAvailable()
        {
            return StoreService.IsRateAvailable(_instance._storeStats);
        }

        private void Awake()
        {
            _instance = this;
            _storeStats = StoreRepository.GetStoreStats();
            _storeConfig = StoreRepository.GetStoreConfig();
        }

        private void Update()
        {
            _elapsedTime += Time.deltaTime;
            if (_elapsedTime > 15f)
            {
                _storeStats.ElapsedTimeSinceSuggestion += Timer.ConvertToMilliseconds(_elapsedTime);
                _elapsedTime = 0f;
                StoreRepository.Save(_storeStats);
            }
        }
    }
}
