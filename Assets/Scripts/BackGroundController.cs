using UnityEngine;

public class BackGroundController : MonoBehaviour
{
    private float ScrollSpeed = -1f;
    private float deadLine = -16f;
    private float start = 15.8f;

    void Start()
    {

    }

    void Update()
    {
        transform.Translate(ScrollSpeed * Time.deltaTime, 0, 0);

        if (transform.position.x < deadLine)
        {
            transform.position = new Vector2(start, 0);
        }
    }
}
