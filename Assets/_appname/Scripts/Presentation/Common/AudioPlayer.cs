using System.Collections.Generic;
using DG.Tweening;
using Polycube.Infrastructure;
using UnityEngine;
using UnityEngine.Audio;

namespace Appname.Presentation
{
    public class AudioPlayer : MonoBehaviour
    {
        [SerializeField] private AudioMixer _masterMixer;
        [SerializeField] private AudioSource _sfxChannel1;
        [SerializeField] private AudioSource _sfxChannel2;
        [SerializeField] private AudioSource _sfxChannel3;
        [SerializeField] private AudioSource _bgmChannel1;
        [SerializeField] private AudioSource _bgmChannel2;

        private List<AudioSource> _pausedSfx = new List<AudioSource>();
        private List<AudioSource> _pausedBgm = new List<AudioSource>();
        private bool _isBgmChannel1Active;
        private Sequence _bgmSequence;

        private const string MASTER_VOLUME_PARAM = "MasterVolume";
        private const string SFX_VOLUME_PARAM = "SfxVolume";
        private const string BGM_VOLUME_PARAM = "BgmVolume";

        public bool IsAnyBgmPlaying { get { return _bgmChannel1.isPlaying || _bgmChannel2.isPlaying; } }
        public bool IsAnySfxPlaying { get { return _sfxChannel1.isPlaying || _sfxChannel2.isPlaying || _sfxChannel3.isPlaying; } }

        public void PlaySfx(AudioClip audioClip, float volume = 1f, float pitch = 1f)
        {
            var source = GetNextAvailableSfxAudioSource();
            source.clip = audioClip;
            source.volume = volume;
            source.pitch = pitch;
            source.Play();
        }

        /// <summary>
        /// Plays the BGM from the same spot in time as the previous BGM source
        /// </summary>
        public void PlayBgm(AudioClip audioClip, float clipVolume = 1f)
        {
            AudioSource newSource;
            AudioSource oldSource;

            if (_isBgmChannel1Active)
            {
                newSource = _bgmChannel2;
                oldSource = _bgmChannel1;
            }
            else
            {
                newSource = _bgmChannel1;
                oldSource = _bgmChannel2;
            }

            if (oldSource.clip == audioClip) return;

            if (_bgmSequence != null)
            {
                _bgmSequence.Kill();
            }

            _bgmSequence = DOTween.Sequence();

            newSource.clip = audioClip;
            newSource.loop = true;
            newSource.volume = 0f;
            newSource.time = oldSource.time;
            newSource.Play();

            _isBgmChannel1Active = !_isBgmChannel1Active;

            _bgmSequence.Append(newSource.DOFade(1f, 1f));
            _bgmSequence.Insert(0f, oldSource.DOFade(0f, 1f));
            _bgmSequence.OnComplete(oldSource.Stop);
        }

        /// <param name="value">0 to 1</param>
        public void SetMasterVolume(float value)
        {
            _masterMixer.SetFloat(MASTER_VOLUME_PARAM, Mathf.Lerp(-80f, 0f, EasedLerp(value)));
        }

        /// <param name="value">0 to 1</param>
        public void SetSfxVolume(float value)
        {
            _masterMixer.SetFloat(SFX_VOLUME_PARAM, Mathf.Lerp(-80f, 0f, EasedLerp(value)));
        }
            
        /// <param name="value">0 to 1</param>
        public void SetBgmVolume(float value)
        {
            _masterMixer.SetFloat(BGM_VOLUME_PARAM, Mathf.Lerp(-80f, 0f, EasedLerp(value)));
        }

        public void PauseAll()
        {
            PauseSfx();
            PauseBgm();
        }

        public void ResumeAll()
        {
            ResumeSfx();
            ResumeBgm();
        }

        private void ResumeSfx()
        {
            foreach (var source in _pausedSfx)
            {
                source.Play();
            }
            _pausedSfx.Clear();
        }

        private float EasedLerp(float value)
        {
            return Easing.GetEaseProgress(EasingEquation.CubicEaseOut, value);
        }

        private void ResumeBgm()
        {
            foreach (var source in _pausedBgm)
            {
                source.Play();
            }
            _pausedBgm.Clear();
        }

        private void PauseSfx()
        {
            if (_sfxChannel1.isPlaying)
            {
                _sfxChannel1.Pause();
                _pausedSfx.Add(_sfxChannel1);

            }

            if (_sfxChannel2.isPlaying)
            {
                _sfxChannel2.Pause();
                _pausedSfx.Add(_sfxChannel2);

            }

            if (_sfxChannel3.isPlaying)
            {
                _sfxChannel3.Pause();
                _pausedSfx.Add(_sfxChannel3);

            }
        }

        private void PauseBgm()
        {
            if (_bgmChannel1.isPlaying)
            {
                _bgmChannel1.Pause();
                _pausedBgm.Add(_bgmChannel1);

            }

            if (_bgmChannel2.isPlaying)
            {
                _bgmChannel2.Pause();
                _pausedBgm.Add(_bgmChannel2);

            }
        }

        private AudioSource GetNextAvailableSfxAudioSource()
        {
            if (!_sfxChannel1.isPlaying)
            {
                return _sfxChannel1;
            }
            else if (!_sfxChannel2.isPlaying)
            {
                return _sfxChannel2;
            }
            else if (!_sfxChannel3.isPlaying)
            {
                return _sfxChannel3;
            }
            else
            {
                _sfxChannel3.Stop();
                return _sfxChannel3;
            }
        }
    }
}
