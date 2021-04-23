using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
    public CharacterController controller;
    public Animator animatorcontroller;
    public Transform cam;

    public float speed = 6.0f;

    public float turnSmoothTime = 0.1f;
    float turnsmoothvelocity;

    // Update is called once per frame
    private void Start()
    {
        animatorcontroller.SetInteger("AnimState", 0);
    }
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0.0f, vertical).normalized;

        if(direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z)* Mathf.Rad2Deg * cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnsmoothvelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 movedirection = Quaternion.Euler(0.0f, targetAngle, 0.0f) * Vector3.forward;
            controller.Move(movedirection.normalized * speed * Time.deltaTime);
            animatorcontroller.SetInteger("AnimState", 1);
        }
        else
        {
            animatorcontroller.SetInteger("AnimState", 0);
        }

    }
}
