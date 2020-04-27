using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TextManager : MonoBehaviour
{
    //Determines which game player is playing
    [SerializeField] bool Game1;
    [SerializeField] bool Game2;
    [SerializeField] bool Game3;
    //Name and most recent dialogue of NPC character
    [SerializeField] Text CurTextTarg;
    [SerializeField] Text CurText;
    //Choice UI button text
    [SerializeField] Text But1text;
    [SerializeField] Text But2text;
    [SerializeField] Text But3text;

    public bool choiceavailable = false;

    void Start()
    {
        
    }

    void Update()
    {
        if (Game1 == true)
        {
            Game1Set();
        }

        if (Game2 == true)
        {
            Game2Set();
        }

        if (Game3 == true)
        {
            Game3Set();
        }

    }

    void Game1Set()
    {
        CurTextTarg.text = "??????";
        CurText.text = "...\n\n...\n\nERROR- \n\n01100010 01101111 01101111 01110100 00100000 01100101 01110010 01110010 01101111 01110010\n\nSystem loadout failed.";

    }

    void Game2Set()
    {

    }

    void Game3Set()
    {

    }

    void Game1Converse()
    {

    }
}
