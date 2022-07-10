using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class AnimationController : MonoBehaviour
{
    public Animator anim;

    [SerializeField] WingsuitController wingsuitController;

    public const string PERCENTAGE = "Percentage";

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat(PERCENTAGE, wingsuitController.percentage);
    }



}
