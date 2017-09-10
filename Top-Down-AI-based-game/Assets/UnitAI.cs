using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class UnitAI : MonoBehaviour
{
    private NavMeshAgent aiAgent;

    private Camera cam;

    private void Start()
    {
        aiAgent = GetComponent<NavMeshAgent>();
        cam = Camera.main;
    }

    private void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);

            RaycastHit _hit;

            if (Physics.Raycast(ray, out _hit))
            {
                aiAgent.SetDestination(_hit.point);
            }
        }
    }
}
