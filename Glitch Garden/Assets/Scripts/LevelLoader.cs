using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
	[SerializeField] Object SceneToLoad;
	[SerializeField] int TimeToWait = 3;
    
    IEnumerator Start()
    {
		yield return new WaitForSeconds(TimeToWait);
		SceneManager.LoadScene(SceneToLoad.name);
    }
}
