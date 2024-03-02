using UnityEngine;

public class ComputerPaddle : MonoBehaviour
{
    [SerializeField] private Rigidbody2D ball;
    private Rigidbody2D rig;
    [SerializeField] private int speed;

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (this.ball.velocity.x > 0.0f)
        {
            if (this.ball.position.y > this.transform.position.y)
            {
                this.rig.AddForce(Vector2.up * this.speed);
            } else if (this.ball.position.y < this.transform.position.y) {
                this.rig.AddForce(Vector2.down * this.speed);
            }


        } else {
            if (this.transform.position.y > 0.0f)
            {
                this.rig.AddForce(Vector2.down * this.speed);   
            } else if (this.transform.position.y < 0.0f)
            {
                this.rig.AddForce(Vector2.up * this.speed);
            }
        }
    }

}
