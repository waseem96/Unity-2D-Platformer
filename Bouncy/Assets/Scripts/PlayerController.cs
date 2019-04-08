using UnityEngine;

public class PlayerController : MonoBehaviour
{

	public float speed;
	public float jumpForce;
	private float moveInput;

	private Rigidbody2D rb;

	private bool facingRight = true;

	private bool isGrounded;
	public Transform groundCheck;
	public float checkRadius;
	public LayerMask whatIsGround;

	private int extraJumps;
	public int extraJumpValue;

	public Animator animator;


	void Start()
	{
		extraJumps = extraJumpValue;
		rb = GetComponent<Rigidbody2D>();
	}

	void Update()
	{
		if (isGrounded == true)
		{
			extraJumps = extraJumpValue;
		}

		if (((Input.GetKeyDown(KeyCode.W)) || (Input.GetKeyDown(KeyCode.UpArrow))) && extraJumps > 0)
		{
			rb.velocity = Vector2.up * jumpForce;
			animator.SetBool("isJumping", true);
			extraJumps--;
		}
		else if (((Input.GetKeyDown(KeyCode.W)) || (Input.GetKeyDown(KeyCode.UpArrow))) && extraJumps == 0 && isGrounded == true)
		{
			rb.velocity = Vector2.up * jumpForce;
			animator.SetBool("isJumping", true);
		}

		if (rb.velocity.y == 0)
		{
			animator.SetBool("isJumping", false);
			animator.SetBool("isFalling", false);
		}
		if (rb.velocity.y > 0)
		{
			animator.SetBool("isJumping", true);
			animator.SetBool("isFalling", false); //added
		}
		if (rb.velocity.y < 0)
		{
			animator.SetBool("isJumping", false);
			animator.SetBool("isFalling", true);

		}
	}


	void FixedUpdate()
	{
		isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);

		moveInput = Input.GetAxis("Horizontal") * speed;
		rb.velocity = new Vector2(moveInput, rb.velocity.y);
		animator.SetFloat("Speed", Mathf.Abs(moveInput));

		if (facingRight == false && moveInput > 0)
		{
			Flip();
		}
		else if (facingRight == true && moveInput < 0)
		{
			Flip();
		}
	}

	void Flip()
	{
		facingRight = !facingRight;
		Vector3 Scaler = transform.localScale;
		Scaler.x *= -1;
		transform.localScale = Scaler;
	}
}
