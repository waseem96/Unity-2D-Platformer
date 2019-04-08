using UnityEngine;
using UnityEngine.SceneManagement;


public class DeathCanvas : MonoBehaviour
{

	public GameObject DeadMenuUI;
	public SpikeHit sh;

	void Update()
	{
		if (sh.isDead == true)
		{
			DeadMenuUI.SetActive(true);
			Time.timeScale = 0f;
		}
		else
		{
			DeadMenuUI.SetActive(false);
			Time.timeScale = 1f;
		}
	}
	public void Restart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		Time.timeScale = 1f;
	}
	public void Menu()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene(0);
	}
}
