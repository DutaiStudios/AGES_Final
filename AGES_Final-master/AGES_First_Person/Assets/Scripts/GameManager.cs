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
    [SerializeField] GameObject playercamera;
    [SerializeField] TextManager textman;
    [SerializeField] GameObject phonetext;
    [SerializeField] GameObject ChoiceCanvas;
    [SerializeField] GameObject CreditsCanvas;
    [SerializeField] GameObject TitleScreen;

    [SerializeField] Animation ScreenLook;
    [SerializeField] TitleAnimation titleanim;
    [SerializeField] GameObject ScreenGlow;

    [SerializeField] PlayerMov phonecheck;

    [SerializeField] AudioSource ringingphone;
    [SerializeField] AudioClip phoneringclip;
    [SerializeField] GameObject PhoneCamera;
    [SerializeField] bool phoneactive = false;

    public bool ts = false;
    public bool doorauth = false;

    public bool choicealarm = false;

    void Start()
    {
        ScreenGlow.SetActive(false);
        ringingphone.Stop();
    }


    void Update()
    {

        if (ts == true)
        {
            Sceneman();
        }
        if (choicealarm == true)
        {
            Cursor.lockState = CursorLockMode.Confined;
        }
        else
        {

        }

        RingingPhone();
        Call1();
    }

    void PlayerChoice()
    {
        pmov.canmove = false;
        maincam.canlook = false;
        Cursor.lockState = CursorLockMode.Confined;
        
    }
    
    void Sceneman()
  {
        if (titleanim.collcheck == true)
     {
         SceneManager.LoadScene("Apartment1");
     }
  }
    public void GameEnter()
    {
        CreditsCanvas.SetActive(false);
        TitleScreen.SetActive(false);
        ScreenGlow.SetActive(true);
        ScreenLook.Play();
    }

    public void GameExit()
    {
        Application.Quit();
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

    void RingingPhone()
    {
        if (phonecheck.phonecall == true)
        {
            if (phoneactive == false)
            {
                ringingphone.Play();
                phoneactive = true;
                ScreenGlow.SetActive(true);
            }

        }
    }

    void Call1()
    {
        if (pmov.onphone == true)
        {
            choicealarm = true;
        }

        if (choicealarm == true)
        {
            ringingphone.Stop();
            pmov.canmove = false;
            phonetext.SetActive(false);
            maincam.canlook = false;
            ScreenGlow.SetActive(false);
            playercamera.SetActive(false);
            PhoneCamera.SetActive(true);
            choicefreeze.SetActive(true);
            Cursor.lockState = CursorLockMode.Confined;
        }
    }
}
