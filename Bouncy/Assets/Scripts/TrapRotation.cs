using UnityEngine;

public class TrapRotation : MonoBehaviour
{
	public float RotationSpeed = 0f;
	public bool RotationEnabled = false;
	public bool RandomRotationEnabled;
	public float RotationSpeedMax;



	// Start is called before the first frame update
	void Start()
	{
		if (RandomRotationEnabled)
		{
			RotationSpeed = Random.Range(RotationSpeed, RotationSpeedMax);
		}
	}

	// Update is called once per frame
	void Update()
	{
		if (RotationEnabled)
		{
			transform.Rotate(0, 0, RotationSpeed + Time.deltaTime, Space.Self);
		}
	}
}
