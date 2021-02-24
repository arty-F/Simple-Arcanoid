using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField]
    Ball ball;
    bool isLaunched = false;

    const float yPos = -11.5f;
    const float yBallPos = -10.35f;
    float xMin = -13;
    float xMax = 13;

    void Start()
    {
    }

    void Update()
    {
        var xPos = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
        xPos = Mathf.Clamp(xPos, xMin, xMax);
        transform.position = new Vector3(xPos, yPos);

        if (!isLaunched)
        {
            ball.transform.position = new Vector3(xPos, yBallPos);

            if (Input.GetMouseButtonDown(0))
            {
                isLaunched = true;
                ball.GetComponent<Rigidbody2D>().velocity = new Vector2(5, 25);
            }
        }
    }
}
