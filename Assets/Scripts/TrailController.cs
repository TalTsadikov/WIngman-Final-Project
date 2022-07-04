using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailController : MonoBehaviour
{
    [SerializeField] WingsuitController wingsuitController;
    [SerializeField] ParticleSystem PS;
    

    void Update()
    {
        if (wingsuitController.percentage > 0.7f)
        {
            EnableTrail();
        }

        else
        {
            DisableTrail();
        }
    }

    

    void EnableTrail()
    {
        PS.enableEmission = true;
    }

    void DisableTrail()
    {
        PS.enableEmission = false;

    }
}
