using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {

    public GameObject MenuObjeto;
    private bool Visibilidade;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void DesabilitaMenu()
    {
        MenuObjeto.SetActive(false);
    }

    public void ApareceBotoes()
    {
        MenuObjeto.SetActive(true);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
