using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AparecerFigura : MonoBehaviour{

    public GameObject FiguraObjeto;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // Mostra ou esconde o objeto
    public void ApareceFigura()
    {
        FiguraObjeto.transform.position = new Vector3(-2, 1, 7);
    }

    public void DesapareceFigura()
    {
        FiguraObjeto.transform.position = new Vector3(0, 0, -1000);
    }
}
