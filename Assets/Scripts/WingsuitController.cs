using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class WingsuitController : MonoBehaviour
{
    // Get the player Rigidbody component
    public Rigidbody rb;
    // Rotation
    public Vector3 rot;
    //Mouse Sensetivity
    public float mouseSensetivity = 100f;

    // Min speed, when the player is on 0 deg or whatever minAngle you have
    public float lowSpeed = 12.5f;
    // Max speed
    public float highSpeed = 13.8f;

    // Max drag, if the player is on 0 deg or minAngle
    public float maxDrag = 4;
    // Min drag
    public float minDrag = 2;

    // Here we will store the modified force and drag
    private float mod_force;
    private float mod_drag;

    // Min angle for the player to rotate on the x-axis
    public float minAngle = 0;
    // Max angle
    public float maxAngle = 45;

    // Converting the x rotation from min angle to max, into a 0-1 format.
    // 0 means minAngle
    // 1 means maxAngle
    public float percentage;

    // Audio mixer, to control the sound FX pitch
    public AudioMixer am;

    private void Start()
    {
        // Setting rotation variable to the current angles
        rot = transform.rotation.eulerAngles;
    }

    private void LateUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            highSpeed = 20f;
        }
        else
            highSpeed = 13.8f;

        // Rotation
        // Y
        rot.y += 20 * Input.GetAxis("Mouse X") * Time.deltaTime * mouseSensetivity;
        // Z
        rot.z = -5 * Input.GetAxis("Mouse X");
        // Limiting the z-axis
        rot.z = Mathf.Clamp(rot.z, -5, 5);
        // X
        rot.x += 20 * Input.GetAxis("Mouse Y") * Time.deltaTime * -mouseSensetivity;
        // Limiting x-axis
        rot.x = Mathf.Clamp(rot.x, minAngle, maxAngle);
        // Update rotation
        transform.rotation = Quaternion.Euler(rot);

        // Speed and drag based on angle
        // Get the percentage (minAngle = 0, maxAngle = 1)
        percentage = rot.x / maxAngle;
        // Update parameters
        // If 0, we'll have maxDrag and lowSpeed
        // If 1, we'll get minDrag and highSpeed
        mod_drag = (percentage * (minDrag - maxDrag)) + maxDrag;
        mod_force = (percentage * (highSpeed - lowSpeed)) + lowSpeed;
        // Getting the local space of the velocity
        Vector3 localV = transform.InverseTransformDirection(rb.velocity);
        // Change z velocity to mod_force
        localV.z = mod_force;
        // Convert the local velocity back to world space and set it to the Rigidbody's velocity
        rb.velocity = transform.TransformDirection(localV);
        // Update drag to the modified one
        rb.drag = mod_drag;
        // Change pitch value based on the player's angle and percentage
        am.SetFloat("Pitch", 1 + percentage);
    }
}
