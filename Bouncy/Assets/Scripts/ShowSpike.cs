using UnityEngine;

public class ShowSpike : MonoBehaviour
{

	private SpriteRenderer sp;

	private void Awake()
	{
		sp = GetComponent<SpriteRenderer>();
		sp.enabled = false;
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{
			sp.enabled = true;
		}
	}
}
