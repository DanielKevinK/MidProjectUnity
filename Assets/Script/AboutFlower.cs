using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AboutFlower : MonoBehaviour
{
    public GameObject Information;

    // Start is called before the first frame update
    void Start()
    {
        Information.SetActive(false);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReturnButtonClicked(){
        Application.LoadLevel("Flower");
    }
    
    public void InformationButtonClicked(){
        if(Information.activeSelf == true){
            Information.SetActive(false);
        }
        else if(Information.activeSelf == false){
            Information.SetActive(true);
        }
    }
}
