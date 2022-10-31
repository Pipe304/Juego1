using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorCollider : MonoBehaviour
{
    public Player feetCollider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        feetCollider.puedoSaltar = true;
    }

    private void OnTriggerExit(Collider other) 
    {
        feetCollider.puedoSaltar = false;
    }
}
