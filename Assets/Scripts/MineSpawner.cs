using UnityEngine;

public class MineSpawner : MonoBehaviour
{

    [SerializeField] private GameObject _mine;
    [SerializeField] private Transform _mineSpawnPoint;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Instantiate(_mine, _mineSpawnPoint.position, _mineSpawnPoint.rotation);
        }
    }
}
