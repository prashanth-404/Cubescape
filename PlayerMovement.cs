using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    public float speed = 5f;
    [SerializeField]
    public float movementSpeed = 3f;
    [SerializeField]
    public float jumpForce = 3f;

    public Rigidbody rb;
    private bool OnGround = true;
    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
        float x = Input.GetAxis("Horizontal");
        transform.Translate(x * Time.deltaTime * movementSpeed, 0, 0);
        if (Input.GetKeyDown(KeyCode.Space) && OnGround)
        {
            rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
            OnGround = false;
        }
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Ground")
        {
            OnGround = true;
        }
    }

}