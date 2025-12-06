using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator animator;

    Rigidbody2D rigidbody;

    private float groundLevel = -3.0f;
    private float dump = 0.8f;
    public float jumpVel = 20f;

    private float deadLine = -9f;

    void Start()
    {
        this.animator = GetComponent<Animator>();
        this.rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        animator.SetFloat("Horizontal", 1);
        bool isGround = (transform.position.y > groundLevel) ? false : true;
        animator.SetBool("isGround", isGround);

        GetComponent<AudioSource>().volume = (isGround) ? 1 : 0;

        if (Input.GetMouseButtonDown(0) && isGround)
        {
            rigidbody.velocity = new Vector2(0, jumpVel);
        }

        if (Input.GetMouseButton(0) == false)
        {
            if (rigidbody.velocity.y > 0)
            {
                rigidbody.velocity *= dump;
            }
        }

        if (transform.position.x < this.deadLine)
        {
            GameObject.Find("Canvas").GetComponent<UIController>().GameOver();
            Destroy(gameObject);
        }
    }
}
