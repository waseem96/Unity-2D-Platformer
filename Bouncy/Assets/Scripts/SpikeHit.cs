using UnityEngine;

public class SpikeHit : MonoBehaviour
{
	public Animator animator;

	public bool isDead = false;


	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Spike")
		{
			animator.SetBool("isDead", true);
			animator.SetBool("isJumping", false);
			animator.SetBool("isFalling", false);
			isDead = true;
		}

		if (other.tag == "InvisSpike")
		{
			animator.SetBool("isDead", true);
			animator.SetBool("isJumping", false);
			animator.SetBool("isFalling", false);
			isDead = true;
		}
	}
}
