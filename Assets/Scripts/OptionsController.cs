using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
	public class OptionsController : MonoBehaviour
	{
		public Slider VolumeSlider;
		public Slider DifficultySlider;
		public LevelManager LevelManager;

		private MusicManager _musicManager;

		public void Start()
		{
			_musicManager = FindObjectOfType<MusicManager>();

			VolumeSlider.value = PlayerPrefsManager.GetMasterVolume();
			DifficultySlider.value = PlayerPrefsManager.GetDifficulty();
		}

		public void Update()
		{
			_musicManager.SetVolume(VolumeSlider.value);
		}

		public void SaveAndExit()
		{
			PlayerPrefsManager.SetMasterVolume(VolumeSlider.value);
			PlayerPrefsManager.SetDifficulty(DifficultySlider.value);

			_musicManager.SetVolume(VolumeSlider.value);
			LevelManager.LoadLevel("01A Start");
		}

		public void SetDefaults()
		{
			VolumeSlider.value = 0.8f;
			DifficultySlider.value = 2f;
		}
	}
}
