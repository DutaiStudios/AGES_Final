using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamBob : MonoBehaviour
{

    [SerializeField] CharacterController pcontrol;
    [SerializeField] Animation bob_animate;

    private bool isMove;

    private bool left;
    private bool right;

    void CamAnimation()
    {
        if (isMove == true)
        {
            if (left == true)
            {
                if (!bob_animate.isPlaying)
                {
                    bob_animate.Play("walkLeft");
                    left = false;
                    right = true;
                }
            }

            if (right == true)
            {
                if (!bob_animate.isPlaying)
                {
                    bob_animate.Play("walkRight");
                    right = false;
                    left = true;
                }
            }
        }
    }
    void Start()
    {
        left = true;
        right = false;
    }


    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        if (inputX != 0 || inputY != 0)
        {
            isMove = true;
        }

        else if (inputX == 0 && inputY == 0)
        {
            isMove = false;
        }

        CamAnimation();
    }
}
