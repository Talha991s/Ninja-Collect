using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovementComponent : MonoBehaviour
{
    public Rigidbody rb;
    [SerializeField] private float WalkSpeed;
    [SerializeField] private float Runspeed;
    [SerializeField] private float Jumpforce;
    public Animator animatorcontroller;

    public bool IsGrounded;

    private PlayerBehaviour playerBehaviour;
    Vector2 InputVector = Vector2.zero;
    private void Awake()
    {
        playerBehaviour = GetComponent<PlayerBehaviour>();
    }
    private void Start()
    {
        animatorcontroller = GetComponent<Animator>();
        animatorcontroller.SetInteger("AnimState", 0); //Idle
    }
    private void Update()
    {
        if (!(InputVector.magnitude > 0))
        {
            animatorcontroller.SetInteger("AnimState", 0);
        }
        if (playerBehaviour.IsJumping) return;

        Vector3 moveDirection = transform.forward * InputVector.y + transform.right * InputVector.x;

        //float currentSpeed = playerBehaviour.isRunning ? Runspeed : WalkSpeed;

        Vector3 movementDirection = moveDirection * Runspeed * Time.deltaTime;

        transform.position += moveDirection;
        
    }
    public void OnMovement(InputValue value)
    {
        Debug.Log(value.Get<Vector2>());
        animatorcontroller.SetInteger("AnimState", 1);
        InputVector = value.Get<Vector2>();
    }

    public void OnJump(InputValue value)
    {
        //if (IsGrounded && Time.timeScale != 0)
        //{
            Debug.Log("Jump");
            rb.AddForce(new Vector3(0, Jumpforce, 0));
            animatorcontroller.SetInteger("AnimState", 2);
        //}
        //IsGrounded = false;

    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Platform"))
        {
            IsGrounded = true;
        }
    }
}
