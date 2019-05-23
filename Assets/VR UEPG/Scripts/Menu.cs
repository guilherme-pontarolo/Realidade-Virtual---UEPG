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
        MenuObjeto.transform.position = new Vector3(0,0,-1000);
    }

    public void ApareceBotoes()
    {
        MenuObjeto.transform.position = new Vector3(5, 0, 5);
    }

    public void ApareceVoltar()
    {
        MenuObjeto.transform.position = new Vector3(-1, 5, 8);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
