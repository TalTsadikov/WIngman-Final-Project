using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class AnimationController : MonoBehaviour
{
    public Animator anim;

    [SerializeField] WingsuitController wingsuitController;

    public const string PERCENTAGE = "Percentage";
    public const string LEFT_ROLL = "Left Roll";
    public const string RIGHT_ROLL = "Right Roll";


    // Update is called once per frame
    void Update()
    {
        anim.SetFloat(PERCENTAGE, wingsuitController.percentage);

        if (Input.GetKeyDown(KeyCode.A))
            anim.SetTrigger(LEFT_ROLL);

        if (Input.GetKeyDown(KeyCode.D))
            anim.SetTrigger(RIGHT_ROLL);
    }



}
