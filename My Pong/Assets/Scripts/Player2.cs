using UnityEngine;

public class Player2 : MonoBehaviour
{
    private Vector2 _direction;
    private Rigidbody2D rig;
    [SerializeField] private int speed;

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            _direction = Vector2.up;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            _direction = Vector2.down;
        }
        else
        {
            _direction = Vector2.zero;
        }
    }

    private void FixedUpdate()
    {
        rig.MovePosition(rig.position + _direction * speed * Time.fixedDeltaTime);
    }
}
