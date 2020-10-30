using UnityEngine;

public class EnemyRay : MonoBehaviour
{
    [SerializeField] private LayerMask _mask;
    private Transform _player;

    private float _startOffset = 0.5f;
    private void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void FixedUpdate()
    {
        var color = Color.red;
        RaycastHit hit;
        var startRaycastPosition = CalculateOffset(transform.position);
        var directionToPlayer = CalculateOffset(_player.position) - startRaycastPosition;

        var rayCast = Physics.Raycast(startRaycastPosition, directionToPlayer, out hit, directionToPlayer.magnitude, _mask);

            if (rayCast)
             {
                //print(hit.collider.gameObject.name);
                    if (hit.collider.gameObject.CompareTag("Player"))
                        {
                            color = Color.green;
                            //print(hit.collider.gameObject.tag);
                        }
             }
        Debug.DrawRay(startRaycastPosition, directionToPlayer, color);
    }

    private Vector3 CalculateOffset(Vector3 position)
    {
        position.y += _startOffset;
        return position;
    }

}
