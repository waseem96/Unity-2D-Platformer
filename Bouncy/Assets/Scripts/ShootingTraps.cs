using System.Collections;
using UnityEngine;

public class ShootingTraps : MonoBehaviour
{
	[SerializeField]
	private GameObject ItemToShootPrefab;
	[SerializeField]
	private float ShootStartDelay = 0.1f;
	[SerializeField]
	private float ShootInterval = 2f;
	[SerializeField]
	private float DestroyItemDelay = 3f;

	void Start()
	{
		StartCoroutine(ShootObject(ShootInterval));
	}
	private IEnumerator ShootObject(float delay)
	{
		yield return new WaitForSeconds(delay + ShootStartDelay);
		ShootStartDelay = 0f;
		var item = (GameObject)Instantiate(ItemToShootPrefab, transform.position, transform.rotation);
		Destroy(item, DestroyItemDelay);
		StartCoroutine(ShootObject(ShootInterval));
	}

}
