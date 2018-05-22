using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
	public class LevelManager : MonoBehaviour
	{
		public int AutoLoadNextLevelAfter;

		public void Start()
		{
			if (AutoLoadNextLevelAfter == 0)
			{
				Debug.Log("AutoLoadNextLevelAfter was 0.");
			}
			else
			{
				Invoke("LoadNextLevel", AutoLoadNextLevelAfter);
			}
		}

		public void LoadLevel(string levelName)
		{
			Debug.Log("New Level load: " + levelName);
			SceneManager.LoadScene(levelName);
		}

		public void QuitRequest()
		{
			Debug.Log("Quit requested");
			Application.Quit();
		}

		public void LoadNextLevel()
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}

		public void OnStartButtonSubmit()
		{
			Debug.Log("Level 01 loaded!");
			LoadLevel("02 Level_01");
		}
	}
}