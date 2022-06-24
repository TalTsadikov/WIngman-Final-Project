using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshPatrol : MonoBehaviour
{
    [SerializeField] private NavMeshAgent navMeshAgent;
    public Transform[] wayPointTransform;
    int wayPointIndex;
    Vector3 nextTarget;

    // Start is called before the first frame update
    void Start()
    {
        UpdateDestination();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, nextTarget) < 3)
        {
            UpdateWayPoint();
            UpdateDestination();
        }
    }

    void UpdateDestination()
    {
        nextTarget = wayPointTransform[wayPointIndex].position;
        navMeshAgent.SetDestination(nextTarget);
    }

    void UpdateWayPoint()
    {
        wayPointIndex++;

        if (wayPointIndex == wayPointTransform.Length)
        {
            wayPointIndex = 0;
        }
    }
}
