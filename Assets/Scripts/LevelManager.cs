using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
	public class LevelManager : MonoBehaviour
	{
		public float LoadNextLevelAfter;

		public void Start()
		{
			Invoke("LoadNextLevel", LoadNextLevelAfter);
		}

		public void LoadLevel(string name)
		{
			Debug.Log("New Level load: " + name);
			SceneManager.LoadScene(name);
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
	}
}
