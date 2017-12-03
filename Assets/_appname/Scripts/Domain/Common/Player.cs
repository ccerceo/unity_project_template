using System;
using UnityEngine;

namespace Appname.Domain
{
    [Serializable]
    public class Player
    {
        [SerializeField] private bool _isFTUE;
        [SerializeField] private float _bgmVolume = 0.86f;
        [SerializeField] private float _sfxVolume = 1f;

        public string Name
        {
            get
            {
                if (Social.localUser.authenticated)
                {
                    return Social.localUser.userName;
                }

                const string defaultName = "You";
                return defaultName;
            }
        }

        public bool IsFTUE
        {
            get { return _isFTUE; }
            set { _isFTUE = value; }
        }

        public float BgmVolume
        {
            get { return _bgmVolume; }
            set { _bgmVolume = value; }
        }

        public float SfxVolume
        {
            get { return _sfxVolume; }
            set { _sfxVolume = value; }
        }

        public Player()
        {
            IsFTUE = true;
        }
    }
}
