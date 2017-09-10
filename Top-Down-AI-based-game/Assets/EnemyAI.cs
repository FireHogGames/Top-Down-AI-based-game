using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class EnemyAI : MonoBehaviour {

    public Transform target;
    private NavMeshAgent aiAgent;

    private void Start()
    {
        aiAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        aiAgent.SetDestination(target.position);
    }
}
