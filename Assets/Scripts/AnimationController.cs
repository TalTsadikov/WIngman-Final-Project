using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class AnimationController : MonoBehaviour
{
    [SerializeField]
    Animator anim;
    [SerializeField]
    WingsuitController wingsuitController;
    [SerializeField]
    float currentAngle;

    public const string PERCENTAGE = "Percentage";

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat(PERCENTAGE, wingsuitController.percentage);
        currentAngle = wingsuitController.percentage;
    }
}
