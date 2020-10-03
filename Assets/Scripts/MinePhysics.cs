using UnityEngine;
using System.Collections;

public class MinePhysics : MonoBehaviour
{

    [SerializeField] private float _explosionRadius = 20.0F;
    [SerializeField] private float _explosionPower = 200.0F;
    [SerializeField] private GameObject _explosion;


    void Start()
    {
        StartCoroutine(ExplosionBomb());   
    }

    IEnumerator ExplosionBomb()
    {
        //delay 3 sec
        yield return new WaitForSeconds(3);
        StartCoroutine(ExplosionBomb());

        Vector3 _explosionPosition = transform.position;
        Collider[] colliders = Physics.OverlapSphere(_explosionPosition, _explosionRadius);
        foreach (Collider hit in colliders)
        {
            Rigidbody _RigidBody = hit.GetComponent<Rigidbody>();
            if (_RigidBody != null)
                _RigidBody.AddExplosionForce(_explosionPower, _explosionPosition, _explosionRadius, 3.0F);
        }
        //add visual effect (bigExplosion) and destroy mine
        Instantiate(_explosion, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}