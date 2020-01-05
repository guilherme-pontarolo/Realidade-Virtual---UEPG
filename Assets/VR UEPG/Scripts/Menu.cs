using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {

    public GameObject MenuObjeto;
    private bool Visibilidade;
	public float x, y, z;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void DesabilitaMenu()
    {
        MenuObjeto.transform.position = new Vector3(0,0,-2000);
    }

    public void AbilitaMenu()
    {
        MenuObjeto.transform.position = new Vector3(0 , 1, 5);
    }

    public void ApareceBotoes()
    {
        MenuObjeto.transform.position = new Vector3(5, 0, 5);
    }

    public void ApareceVoltar()
    {
        MenuObjeto.transform.position = new Vector3(0, 4, 8);
    }

	public void ApareceMontarDesmontar()
	{
		MenuObjeto.transform.position = new Vector3(x, y, z);
	}

    public void ExitGame()
    {
        Application.Quit();
    }
}
