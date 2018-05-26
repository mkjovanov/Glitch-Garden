using UnityEngine;

namespace Assets.Scripts
{
	public class MusicManager : MonoBehaviour
	{
		public AudioClip[] LevelMusicChangeArray;
		private AudioSource _audioSorce;

		private void Awake()
		{
			_audioSorce = GetComponent<AudioSource>();
			DontDestroyOnLoad(gameObject);
		}

		private void OnLevelWasLoaded(int level)
		{
			var thisLevelMusic = LevelMusicChangeArray[level];
			if (!thisLevelMusic) return;

			_audioSorce.clip = thisLevelMusic;
			_audioSorce.loop = true;
			_audioSorce.volume = PlayerPrefsManager.GetMasterVolume();
			_audioSorce.Play();
		}

		public void SetVolume(float volume)
		{
			_audioSorce.volume = volume;
		}
	}
}
