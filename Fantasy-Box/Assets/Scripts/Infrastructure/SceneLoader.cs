using UnityEngine;
using UnityEngine.SceneManagement;

namespace Infrastructure
{
	public static class SceneLoader
	{
		public static void LoadScene(GameScene scene)
		{
			if (IsSceneExist(scene))
			{
				SceneManager.LoadSceneAsync((int) scene);
			}
			else
			{
				Debug.LogError($"{scene} scene with index {(int) scene} not found.");
			}
		}

		private static bool IsSceneExist(GameScene scene)
		{
			return SceneUtility.GetScenePathByBuildIndex((int) scene) != string.Empty;
		}
	}
}