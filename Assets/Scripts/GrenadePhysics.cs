using UnityEngine;

public class GrenadePhysics : MonoBehaviour
{

    [SerializeField] private float _grenadeHeight = 7.0f;
    [SerializeField] private float _grenadeSpeed = 10.0f;
    [SerializeField] private GameObject _explosion;
    //[SerializeField] private float _grenadeExplosionPower = 10.0f;
    //[SerializeField] private float _grenadeExplosionRadius = 5.0f;

    [SerializeField] private Vector3 _my3DVector;

    private Rigidbody _grenadeRigidBody;

    private void Start()
    {
        _grenadeRigidBody = GetComponent<Rigidbody>();
        _grenadeRigidBody.AddForce(new Vector3(0, _grenadeHeight, 0), ForceMode.Impulse);
    }

    void Update()
    {
        transform.Translate(Vector3.forward * _grenadeSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        Instantiate(_explosion, transform.position, transform.rotation);
        Debug.Log("Grenade Destroyed");
    }
    /*Debug.Log("GrenadePhysics Destroyed");
    ContactPoint contact = collision.contacts[0];
    Quaternion rotation = Quaternion.FromToRotation(Vector3.up, contact.normal);
    Vector3 position = contact.point;
    Instantiate(_explosion, position, rotation);
    Destroy(gameObject);
}*/

    /*    private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Floor"))
            {
                // Vector3 explosionPos = transform.position;
                // _grenadeRigidBody.AddExplosionForce(_grenadeExplosionPower, explosionPos, _grenadeExplosionRadius, 3.0f);
                Destroy(gameObject);
                Debug.Log("GrenadePhysics Destroyed");
            }
        }*/

}
