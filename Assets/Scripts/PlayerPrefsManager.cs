using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPrefsManager : MonoBehaviour
{
	private const string MASTER_VOLUME_KEY = "master_volume";
	private const string DIFFICULTY_KEY = "difficulty;";
	private const string LEVEL_UNLOCKED_KEY = "level_unlocked_";

	public static void SetMasterVolume(float volume)
	{
		if (volume >= 0f && volume <= 1f)
		{
			PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
		}
		else
		{
			Debug.LogError("Master volume value not in range (0-1)! Value passed: " + volume);
		}
	}

	public static float GetMasterVolume()
	{
		return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
	}

	public static void SetDifficulty(float difficulty)
	{
		if (difficulty >= 1f && difficulty <= 3f)
		{
			PlayerPrefs.SetFloat(DIFFICULTY_KEY, difficulty);
		}
		else
		{
			Debug.LogError("Difficulty value not in range (0-1)! Value passed: " + difficulty);
		}
	}

	public static float GetDifficulty()
	{
		return PlayerPrefs.GetFloat(DIFFICULTY_KEY);
	}

	public static void UnlockLevel(int level)
	{
		Debug.LogWarning(SceneManager.sceneCountInBuildSettings);
		var buildSettingsRange = SceneManager.sceneCountInBuildSettings - 1;
		if (level > buildSettingsRange)
		{
			Debug.LogError("Level out of build settings range(0-" + buildSettingsRange + "). Value passed: " + level);
		}
		else
		{
			PlayerPrefs.SetInt(LEVEL_UNLOCKED_KEY + level, 1);
		}
	}

	public static bool IsLevelUnlocked(int level)
	{
		var buildSettingsRange = SceneManager.sceneCountInBuildSettings - 1;
		if (level > buildSettingsRange)
		{
			Debug.LogError("Level out of build settings range(0-" + buildSettingsRange + "). Value passed: " + level);
			return false;
		}
		var levelUnlocked = PlayerPrefs.GetInt(LEVEL_UNLOCKED_KEY + level);
		var isLevelUnlocked = levelUnlocked == 1;
		return isLevelUnlocked;
	}
}
