using UnityEngine;

public class BulletSpawner : MonoBehaviour
{

    [SerializeField] private GameObject _bullet;
    [SerializeField] private Transform _bulletSpawnPoint;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) 
        { 
            Instantiate(_bullet, _bulletSpawnPoint.position, _bulletSpawnPoint.rotation);
        }
    }
}