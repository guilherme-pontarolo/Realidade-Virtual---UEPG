using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manipulae : MonoBehaviour
{
    private const int TAM = 1;
    private const int TEMPO = 300;
    private const float ROT = 0.8F, COR = 0.03F;
    private float x, y, z;
    public Color color = Color.black;
    private int cont = 0;
    bool liberaY = false, liberaZ = false, librot=false;
    private int n = 0;
    Vector3 newSize;
    // Start is called before the first frame update
    void iniciaCor()
    {
        color.r = 255f;
        color.g = 0f;
        color.b = 0f;
        color.a = 0f;
    }
    void Start()
    {
        iniciaCor();
        gameObject.GetComponent<Renderer>().material.color = new Color(color.r, color.g, color.b, color.a);
        transform.Rotate(Vector3.forward, 45);
    }

    // Update is called once per frame
    void Update()
    {

        if (cont > TEMPO)
        {
            /*          transform.Rotate(Vector3.up, ROT*7);
                        transform.Rotate(Vector3.left, ROT*4);
                        transform.Rotate(Vector3.forward, ROT*4);*/
            if (librot==true){
                transform.Rotate(ROT, ROT, ROT, Space.Self);
            }
            if (transform.localScale.x < TAM)
            {
                x += 0.05f * Time.deltaTime;
                //                color.r += COR;
                transform.localScale += new Vector3(x, 0, 0);
                if (transform.localScale.x > TAM)
                    liberaY = true;
                    n++;
            }
        }
        if (cont > TEMPO * 3)
            if (liberaY && transform.localScale.y < TAM)
            {
                //                color.g += COR;
                y += 0.05f * Time.deltaTime;
                transform.localScale += new Vector3(0, y, 0);
                if (transform.localScale.y > TAM)
                    liberaZ = true;
                    n++;
            }
        if (cont > TEMPO * 5)
            if (liberaZ && transform.localScale.z < TAM)
            {
                //                color.b += COR;
                //                color.r -= COR;
                //                color.g -= COR / 2;
                z += 0.05f * Time.deltaTime;
                transform.localScale += new Vector3(0, 0, z);
                librot = true;
                n++;
            }
        gameObject.GetComponent<Renderer>().material.color = new Color(color.r, color.g, color.b, color.a);
        cont++;

    }

    public void scaleinicial()
    {
        if (transform.localScale.x >= TAM)
        {
            transform.localScale += new Vector3(-0.9182f, 0, 0);
            liberaY = false;
            liberaZ = false;
            librot = false;
            cont = 0;
            transform.rotation = new Quaternion(0, 0, 315, 0);
        }
        if (transform.localScale.y >= TAM)
        {
            transform.localScale += new Vector3(0, -0.909476f, 0);
            liberaY = false;
            liberaZ = false;
            librot = false;
            cont = 0;
            transform.rotation = new Quaternion(0, 0, 315, 0);
        }
        if (transform.localScale.z >= TAM)
        {
            transform.localScale += new Vector3(0, 0, -0.904626f);
            liberaY = false;
            liberaZ = false;
            librot = false;
            cont = 0;
            transform.rotation = new Quaternion(0, 0, 315, 0);
        }
    }
}
