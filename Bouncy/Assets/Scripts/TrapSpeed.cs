using UnityEngine;

public class TrapSpeed : MonoBehaviour
{
	[SerializeField]
	private float speed = 5f;


	void Update()
	{
		transform.position += transform.up * Time.deltaTime * speed;
	}
}
