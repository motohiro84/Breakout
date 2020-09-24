using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class GameSystem : MonoBehaviour
{
	public void EasyGame() {
		SceneManager.LoadScene ("Easy");
	}
	public void NormalGame() {
		SceneManager.LoadScene ("Normal");
	}
	public void HardGame() {
		SceneManager.LoadScene ("Hard");
	}
}