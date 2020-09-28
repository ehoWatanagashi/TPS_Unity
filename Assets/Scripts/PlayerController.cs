using UnityEngine;

public class PlayerController : MonoBehaviour
{
   
    [SerializeField] private float _speed = 4.0f;
    [SerializeField] private float _rotateSpeed = 5.0f;
    [SerializeField] private float _jumpHeight = 2.0f;
    [SerializeField] private float _gravityValue = -9.81f;

    private CharacterController controller;
    private Vector3 _playerVelocity;
    private Vector3 _direction;
    private bool groundedPlayer;

   /*  private void Start()
     {
         controller = gameObject.AddComponent<CharacterController>();
     }*/



 /*   private void Start()
    {
        Quaternion.Euler(0f, 90f, 0f) * transform.forward;
    }*/
    private void Update()
    {

    /*   groundedPlayer = controller.isGrounded;
        if (groundedPlayer && _playerVelocity.y < 0)
        {
            _playerVelocity.y = 0f;
        }*/

        // move


        _direction.x = -Input.GetAxis("Horizontal");
        _direction.z = -Input.GetAxis("Vertical");
        _direction.Normalize();

        /* Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
         move.Normalize();
         controller.Move(-move * Time.deltaTime * _playerSpeed);*/

        var speed = (_direction.sqrMagnitude > 0) ? _speed : 0;
        speed = speed * Time.deltaTime;

        transform.position += transform.forward * speed;

        Vector3 desiredForvard = Vector3.RotateTowards(transform.forward, _direction, _rotateSpeed * Time.deltaTime, 0f);
        transform.rotation = Quaternion.LookRotation(desiredForvard);

        /*   if (move != Vector3.zero)
           {
               gameObject.transform.forward = move;
           }
   */
        /* if (Input.GetKey(KeyCode.Space) && groundedPlayer)
         {
             _playerVelocity.y += Mathf.Sqrt(_jumpHeight * -3.0f * _gravityValue);
         }



         _playerVelocity.y += _gravityValue * Time.deltaTime;
         controller.Move(_playerVelocity * Time.deltaTime);*/

        if (Input.GetKey(KeyCode.Space) && groundedPlayer)
        {
            _playerVelocity.y += Mathf.Sqrt(_jumpHeight * -3.0f * _gravityValue);
        }

    }
}
