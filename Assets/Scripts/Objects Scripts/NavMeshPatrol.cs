using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshPatrol : MonoBehaviour
{
    [SerializeField] private NavMeshAgent agent;
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
        if (Vector3.Distance(transform.position, nextTarget) < 20)
        {
            Debug.Log("Changed");
            UpdateWayPoint();
            UpdateDestination();
        }
    }

    void UpdateDestination()
    {
        nextTarget = wayPointTransform[wayPointIndex].position;
        agent.SetDestination(nextTarget);
    }

    void UpdateWayPoint()
    {
       wayPointIndex = Random.Range(0, wayPointTransform.Length);
    }
}
