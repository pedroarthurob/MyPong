using UnityEngine;

public class Player1 : MonoBehaviour
{
    private Vector2 _direction;
    protected Rigidbody2D rig;
    [SerializeField] protected int speed;

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _direction = Vector2.up;
        } else if (Input.GetKey(KeyCode.S))
        {
            _direction = Vector2.down;
        } else 
        {
            _direction = Vector2.zero;
        }
    }

    private void FixedUpdate()
    {
        rig.MovePosition(rig.position + _direction * speed * Time.fixedDeltaTime);    
    }
}
