using UnityEngine;

namespace Infrastructure
{
	public class Bootstrapper : MonoBehaviour
	{
		private void Awake()
		{
			SceneLoader.LoadScene(GameScene.Lobby);
		}
	}
}