using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{

    [SerializeField] CharacterController cont;
    [SerializeField] float speed;
    float truespeed;
    float sprintspeed;
    public bool canmove = true;
    public bool cansprint = false;
    [SerializeField] AudioSource walkingsfx;
    public bool phonecall = false;
    public int countdown;
    [SerializeField] CamLook playercam;
    [SerializeField] Text phonetut;
    public bool onphone = false;

    private void Start()
    {
        truespeed = speed;
        sprintspeed = speed * 2;

    }
    void Update()
    {
        PhonePickup();
        countdown++;
        PhoneRing();
        if (canmove == true)
        {

            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

            Vector3 move = transform.right * x + transform.forward * z;
            cont.Move(move * speed * Time.deltaTime);
            sprint();
        }

        else if (canmove == false)
        {
            return;
        }

    }

    void sprint()
    {

        if (cansprint == true)
        {
        if (Input.GetButtonDown("Fire1"))
        {
            speed = sprintspeed;
        }

        if (Input.GetButtonUp("Fire1"))
        {
            speed = truespeed;
        }
        }

    }

    void PhoneRing()
    {
        if (countdown >= 288)
        {
            phonecall = true;
        }
    }

    void PhonePickup()
    {
        if (playercam.phonesight == true)
        {
            phonetut.text = "Press E to pick up phone";
            if (Input.GetKeyDown("e"))
            {
                onphone = true;
                phonetut.text = " ";
            }
        }
        else if (playercam.phonesight == false)
        {

        }
    }
    
}
