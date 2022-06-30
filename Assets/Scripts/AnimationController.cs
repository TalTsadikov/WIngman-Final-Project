using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class AnimationController : MonoBehaviour
{
    [SerializeField]
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
            anim.SetBool("W Pressed", true);

        if(Input.GetKeyUp(KeyCode.W))
            anim.SetBool("W Pressed", false);

        if (Input.GetKeyDown(KeyCode.S))
            anim.SetBool("S Pressed", true);

        if (Input.GetKeyUp(KeyCode.S))
            anim.SetBool("S Pressed", false);


    }
}
