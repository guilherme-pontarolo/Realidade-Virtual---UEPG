using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class GazeInteracao : MonoBehaviour
{

    public Image imgCirculo;
    public float gazeTime = 2;
    private float timer;
    bool gazedAt;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (gazedAt)
        {
            timer += Time.deltaTime;
            imgCirculo.fillAmount = timer / gazeTime;

            if (timer > gazeTime)
            {
                // executa o manipulador de ponteiro
                ExecuteEvents.Execute(gameObject, new PointerEventData(EventSystem.current), ExecuteEvents.pointerDownHandler);
                timer = 0;
            }
        }

    }

    public void PointerEnter()
    {
        gazedAt = true;
        Debug.Log("PointerEnter");
    }

    public void PointerExit()
    {
        timer = 0;
        gazedAt = false;
        imgCirculo.fillAmount = 0;
        Debug.Log("PointerExit");
        
    }

    public void PointerDown()
    {
        Debug.Log("PointerDown");
    }
}