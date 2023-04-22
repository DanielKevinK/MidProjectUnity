using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject About;
    public GameObject Enter;

    // Start is called before the first frame update
    void Start()
    {
        MainMenu.SetActive(true);
        About.SetActive(false);
        Enter.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AboutBtnClicked()
    {
        MainMenu.SetActive(false);
        About.SetActive(true);
    }

    public void EnterBtnClicked()
    {
        Application.LoadLevel("Flower");
    }

    public void ExitBtnClicked()
    {
        Application.Quit();
    }

    public void ReturnButton()
    {
        MainMenu.SetActive(true);
        About.SetActive(false);
    }
}
