using UnityEngine;

public class FireSpawner : MonoBehaviour
{

    [SerializeField] private GameObject _object;
    [SerializeField] private Transform _spawnPoint;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.L)) Instantiate(_object, _spawnPoint.position, _spawnPoint.rotation);
    }
}
