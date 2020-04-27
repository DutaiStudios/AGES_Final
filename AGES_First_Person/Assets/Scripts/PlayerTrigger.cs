using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrigger : MonoBehaviour
{

    [SerializeField] DoorProxy curdoor;
    [SerializeField] GameObject Doorat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "GateCheck")
        {
            Doorat = other.gameObject;
            
        }
    }
}
