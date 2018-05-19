using UnityEngine;

namespace Assets.Scripts
{
	public class MusicManager : MonoBehaviour
	{
		public AudioClip[] LevelMusicChangeArray;

		private void Awake()
		{
			DontDestroyOnLoad(gameObject);
		}

		private void OnLevelWasLoaded(int level)
		{
			var thisLevelMusic = LevelMusicChangeArray[level];
			if (!thisLevelMusic) return;

			var audioSource = GetComponent<AudioSource>();
			audioSource.clip = thisLevelMusic;
			audioSource.loop = true;
			audioSource.Play();
		}
	}
}
