using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigidbody;
    [SerializeField] float torqueAmount = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
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
