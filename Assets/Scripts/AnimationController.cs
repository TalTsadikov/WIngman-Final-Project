using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class AnimationController : MonoBehaviour
{
    public Animator anim;

    [SerializeField] WingsuitController wingsuitController;

    public const string PERCENTAGE = "Percentage";
    public const string PLAYER_CRASHED = "Player Crashed";

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat(PERCENTAGE, wingsuitController.percentage);
    }

    public void OnCollisionEnter(Collision coll)
    {
        //anim.SetBool("Player Crashed", true);
       // Debug.Log("hit wall");
    }
}
