using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] private Transform _target;

    private NavMeshAgent _navMeshAgent;
    private Vector3 _npcTargetPosition;
    private Vector3 _currentTargetPosition;
    private Vector3 _lastTargetPosition;
    private float _visible = 5.0f;
    private float _maxError = 1.0f;
    private void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        _npcTargetPosition = transform.position;
        _currentTargetPosition = _target.position;
        _lastTargetPosition = _currentTargetPosition;
    }

    private void Update()
    {
        _currentTargetPosition = _target.position;


        if (Vector3.Distance(_currentTargetPosition, _lastTargetPosition) > _maxError) {
            _lastTargetPosition = _currentTargetPosition;
            if (Vector3.Distance(_npcTargetPosition, _lastTargetPosition) < _visible)
            {
                _navMeshAgent.SetDestination(_lastTargetPosition);
            }
        }
    }
}