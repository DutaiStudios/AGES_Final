using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class DoorProxy : MonoBehaviour
{

    [SerializeField] Text fronttext;
    [SerializeField] Text backtext;
    [SerializeField] GameManager gm;

    [SerializeField] Animation DoorAnim;

    [SerializeField] AudioSource denied;
    [SerializeField] AudioSource accept;

    public bool isactivated = false;
    // Start is called before the first frame update
    void Start()
    {
        fronttext.text = "";
        backtext.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            isactivated = true;
            if (gm.doorauth == true)
            {
                accept.Play();
                //DoorAnim.Play("scifiDooropen");
            }

            if (gm.doorauth == false)
            {
                denied.Play();
                fronttext.text = "Access Denied";
                backtext.text = "Access Denied";
            }
        }
    }

    void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            isactivated = false;
            if (gm.doorauth == true)
            {
               //DoorAnim.Play("scifiDoorclose");
            }

            if (gm.doorauth == false)
            {
                fronttext.text = "";
                backtext.text = "";
            }
        }
    }
}
