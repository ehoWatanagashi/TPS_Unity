using UnityEngine;

public class BulletPhysics : MonoBehaviour
{

    [SerializeField] private float _bulletSpeed = 10.0f;
    [SerializeField] private Vector3 _my3DVector;

    void Update()
    {
        transform.Translate(Vector3.forward * _bulletSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {       
            Destroy(gameObject);
            Debug.Log("Bullet Destroyed");
    }
          

}
