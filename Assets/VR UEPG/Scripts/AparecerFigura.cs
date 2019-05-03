using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AparecerFigura : MonoBehaviour{

    public GameObject FiguraObject;
    private bool Visibilidade;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // Mostra ou esconde o objeto
    public void ApareceOuDesapareceFigura()
    {
        if (!Visibilidade)
        {
            FiguraObject.SetActive(true);
            Visibilidade = true;
        }
        else
        {
            FiguraObject.SetActive(false);
            Visibilidade = false;
        }
    }

    public void DesabilitarOutros()
    {
    FiguraObject.SetActive(false);
    }
}
