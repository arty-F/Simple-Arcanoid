using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField]
    Ball ball;
    bool isLaunched = false;

    const float yPos = -11.5f;
    const float yBallPos = -10.35f;
    const float xMin = -13;
    const float xMax = 13;

    void Update()
    {
        MovePaddleToMouseX();

        if (!isLaunched)
        {
            MoveBallToMouseX();
        }
    }

    private void MovePaddleToMouseX()
    {
        var xPos = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
        xPos = Mathf.Clamp(xPos, xMin, xMax);
        transform.position = new Vector3(xPos, yPos);
    }

    private void MoveBallToMouseX()
    {
        ball.transform.position = new Vector3(transform.position.x, yBallPos);

        if (Input.GetMouseButtonDown(0))
        {
            isLaunched = true;
            ball.BallRigidbody.velocity = new Vector2(5, 25);
        }
    }
}
