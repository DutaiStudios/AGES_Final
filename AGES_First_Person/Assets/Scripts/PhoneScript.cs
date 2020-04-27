﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneScript : MonoBehaviour
{

    [SerializeField] GameObject glow;
    [SerializeField] GameManager gm;
    [SerializeField] Animation glowstrobe;
    // Start is called before the first frame update
    void Start()
    {
        glow.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Phonecall();
    }

    void Phonecall()
    {
        if (gm.gamenum == 1)
        {
        glow.SetActive(true);
        }

    }
}
