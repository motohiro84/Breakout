using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class GameSystem : MonoBehaviour
{
	public void GameScene(int mode) {
		Level.mode = mode;
		SceneManager.LoadScene ("Main");
	}
}