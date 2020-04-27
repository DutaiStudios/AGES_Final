using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] Text choicealert;
    [SerializeField] GameObject choicefreeze;
    [SerializeField] PlayerMov pmov;
    [SerializeField] CamLook maincam;

    [SerializeField] TextManager textman;

    [SerializeField] GameObject ChoiceCanvas;
    [SerializeField] GameObject CreditsCanvas;
    [SerializeField] GameObject TitleScreen;

    public int gamenum = 0;

    public bool doorauth = false;

    public bool choicealarm = false;

    void Start()
    {
        
    }


    void Update()
    {
        if (textman.choiceavailable == true)
        {
            PlayerChoice();
        }


    }

    void PlayerChoice()
    {
        pmov.canmove = false;
        maincam.canlook = false;
        Cursor.lockState = CursorLockMode.None;
        
    }
    
    public void GameEnter()
    {
        SceneManager.LoadScene("Apartment1");
    }

    public void GameExit()
    {
        SceneManager.LoadScene(0);
    }

    public void Credits()
    {
        CreditsCanvas.SetActive(true);
        TitleScreen.SetActive(false);
    }

    public void ReturnToTitle()
    {
        CreditsCanvas.SetActive(false);
        TitleScreen.SetActive(true);
    }
}
