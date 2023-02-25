using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    new Rigidbody2D rigidbody;
    [SerializeField] float torqueAmount = 1.0f;
    [SerializeField] float boostSpeed = 50f;
    [SerializeField] float baseSpeed = 20f;
    SurfaceEffector2D surfaceEffector2D;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        RotatePlayer();
        RespondToBoost();
    }

    private void RespondToBoost()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector2D.speed = boostSpeed;
        } else
        {
            surfaceEffector2D.speed = baseSpeed;
        }
    }

    private void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidbody.AddTorque(torqueAmount);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody.AddTorque(-torqueAmount);
        }
    }
}
