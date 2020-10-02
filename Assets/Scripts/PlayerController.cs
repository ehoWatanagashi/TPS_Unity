using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private float _speed = 4.0f;
    [SerializeField] private float _rotateSpeed = 3.0f;
    [SerializeField] private float _jumpHeight = 5.0f;

    private Rigidbody _myRigidBody;
    private Vector3 _direction;
    private bool _groundedPlayer = false;

    #region UnityMethods


    private void Start()
    {
        _myRigidBody = GetComponent<Rigidbody>();
    }
    private void Update()
    {

        Walk();
        checkPlayerOnTheGround();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            _groundedPlayer = true;
        }
    }

    #endregion

    #region Methods
    private void checkPlayerOnTheGround()
    {
        if (_groundedPlayer)
        {      
            if (Input.GetKey(KeyCode.Space))
            {
                Jump();
            }
        }       
    }
  
    private void Walk()
    {
        _direction.x = -Input.GetAxis("Horizontal");
        _direction.z = -Input.GetAxis("Vertical");
        _direction.Normalize();


        var speed = (_direction.sqrMagnitude > 0) ? _speed : 0;
        speed = speed * Time.deltaTime;

        transform.position += transform.forward * speed;

        Vector3 desiredForvard = Vector3.RotateTowards(transform.forward, _direction, _rotateSpeed * Time.deltaTime, 0f);
        transform.rotation = Quaternion.LookRotation(desiredForvard);
    }

    private void Jump()
    {
        _myRigidBody.AddForce(new Vector3(0, _jumpHeight, 0), ForceMode.Impulse);
        _groundedPlayer = false;
    }
    #endregion
}
