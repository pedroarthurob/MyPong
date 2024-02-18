using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rig;
    [SerializeField] private int speed;

    private void Awake()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        ResetPosition();
    }

    private void firstMove()
    {
        float x = Random.value;
        if (x < 0.5f)
        {
            x = -1.0f;
        } else
        {
            x = 1.0f;
        }

        float y = Random.value;

        if ( y < 0.5f) {
            y = Random.Range(-1.0f, -0.5f);
        } else
        {
            y = Random.Range(0.5f, 1.0f);
        }

        Vector2 direction = new Vector2(x, y);
        rig.AddForce(direction*speed);
    }

    public void ResetPosition()
    {
        rig.position = Vector3.zero;
        rig.velocity = Vector3.zero;
        firstMove();
    }

    public void AddForce(Vector2 force)
    {
        rig.AddForce(force);
    }
}
