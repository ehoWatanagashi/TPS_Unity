using UnityEngine;

public class BulletSpawner : MonoBehaviour
{

    [SerializeField] private GameObject _object;
    [SerializeField] private Transform _spawnPoint;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) { 
            Instantiate(_object, _spawnPoint.position, _spawnPoint.rotation);
        }
    }
}