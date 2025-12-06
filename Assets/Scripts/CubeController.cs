using UnityEngine;

public class CubeController : MonoBehaviour
{
    private float speed = -12f;
    private float deadLine = -10f;

    void Start()
    {

    }

    void Update()
    {
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        if(transform.position.x < deadLine)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag != "Player")
        {
            GetComponent<AudioSource>().Play();
        }
    }
}
