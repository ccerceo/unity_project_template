using UnityEngine;

namespace Polycube.Infrastructure
{
    public class StoreConfig : ScriptableObject
    {
        [SerializeField] private string _appStoreId;
        [SerializeField] private string _playStoreId;

        public string AppStoreId { get { return _appStoreId; } }
        public string PlayStoreId { get { return _playStoreId; } }

        public StoreConfig()
        {
        }
    }
}
