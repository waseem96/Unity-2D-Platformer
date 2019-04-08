using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CoinScore : MonoBehaviour
{

	private int coins;

	public Text ScoreUI;

	//public GameObject NextLevelButton;


	// Use this for initialization
	void Start()
	{
		coins = 0;
	}

	// Update is called once per frame
	void Update()
	{
		ScoreUI.text = coins.ToString();
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Coin")
		{
			coins += 1;
			Destroy(other.gameObject);
			if (coins == 5)
			{
				SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
			}

		}
	}
	/*public void Win()
	{
		NextLevelButton.SetActive(true);
	}
	public void Lose()
	{
		NextLevelButton.SetActive(false);
	}
	public void NextLevel()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}*/
}
