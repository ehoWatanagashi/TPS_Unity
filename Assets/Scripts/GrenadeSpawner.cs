using UnityEngine;

public class GrenadeSpawner : MonoBehaviour
{

    [SerializeField] private GameObject _grenade;
    [SerializeField] private Transform _grenadeSpawnPoint;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            Instantiate(_grenade, _grenadeSpawnPoint.position, _grenadeSpawnPoint.rotation);
        }
    }
}