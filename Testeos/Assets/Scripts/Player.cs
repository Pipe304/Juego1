using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float movementSpeed = 5.0f;
    public float rotationSpeed = 200.0f;
    private Animator anim;
    public float x, y;
    public Rigidbody rb;
    public float JumpForce = 8f;
    public bool puedoSaltar;

    // Start is called before the first frame update
    void Start()
    {
        puedoSaltar = false;
        anim = GetComponent<Animator>();
    }

    void FixedUpdate() 
    {
        transform.Rotate(0, x * Time.deltaTime * rotationSpeed, 0);
        transform.Translate(0, 0, y * Time.deltaTime * movementSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y);

        if(puedoSaltar)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                anim.SetBool("Salto", true);
                rb.AddForce(new Vector3(0, JumpForce, 0), ForceMode.Impulse);
            }
            anim.SetBool("TocarPiso", true);
        }
        else 
        {
            Falling();
        }
    }

    public void Falling()
    {
        anim.SetBool("TocarPiso", false);
        anim.SetBool("Salto", false);
    }
}
