using DefaultNamespace;
using UnityEngine;
using UnityEngine.Serialization;

public class Player : MonoBehaviour,  IAlive
{
    [SerializeField] private float speed;
    [SerializeField] public int collectItems = 0;
    private Rigidbody2D _rb;
    public Joystick joystick;


    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (joystick._joystickVec.y != 0)
        {
            _rb.velocity = new Vector2(joystick._joystickVec.x * speed, joystick._joystickVec.y * speed);
        }
        else
        {
            _rb.velocity = Vector2.zero;
        }
    }

    public void Dead()
    {
        Destroy(gameObject);                  
    }

    public void CollectItem()
    {
        collectItems += 1;
    }
}
