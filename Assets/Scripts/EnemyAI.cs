using UnityEngine;
using UnityEngine.AI;

public class EnemeAI : MonoBehaviour
{
    private NavMeshAgent _agent;
    public Transform player;

    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        _agent.updateUpAxis = false;
        _agent.updateRotation = false;
    }

    private void Update()
    {
        _agent.SetDestination(player.position);
        
    }
}
