using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerGallery : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReturnClicked()
    {
        Application.LoadLevel("MainMenuScene");
    }

    public void SunflowerClicked()
    {
        Application.LoadLevel("SunflowerScene");
    }

    public void SakuraClicked()
    {
        Application.LoadLevel("SakuraScene");
    }

    public void WhiteRoseClicked()
    {
        Application.LoadLevel("WhiteRoseScene");
    }

    public void JasmineClicked()
    {
        Application.LoadLevel("JasmineScene");
    }
}
