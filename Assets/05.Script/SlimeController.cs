using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeController : MonoBehaviour
{
    public GameObject Slime_Face;
    public Material[] Face_Mat;
    public GameObject[] Slime_Hat;
    public Material[] Color_Mat;
    public Material[] mat = new Material[2];

    public void Start()
    {
        mat = Slime_Face.GetComponent<Renderer>().materials;

    }
    public void ChangeSlimeFace(int num)
    {
        switch (num)
        {
            case 1:
                mat[1] = Face_Mat[0];
                Slime_Face.GetComponent<Renderer>().materials = mat;
                break;
            case 2:
                mat[1] = Face_Mat[1];
                Slime_Face.GetComponent<Renderer>().materials = mat;
                break;
            case 3:
                mat[1] = Face_Mat[2];
                Slime_Face.GetComponent<Renderer>().materials = mat;
                break;
        }
    }
    public void ChangeSlimeHat(int num)
    {
        switch (num)
        {
            case 4:
                Slime_Hat[0].SetActive(true);
                Slime_Hat[1].SetActive(false);
                Slime_Hat[2].SetActive(false);
                break;
            case 5:
                Slime_Hat[0].SetActive(false);
                Slime_Hat[1].SetActive(true);
                Slime_Hat[2].SetActive(false);
                break;
            case 6:
                Slime_Hat[0].SetActive(false);
                Slime_Hat[1].SetActive(false);
                Slime_Hat[2].SetActive(true);
                break;

        }
    }
    public void ChangeSlimeColor(int num)
    {
        switch (num)
        {
            case 7:
                mat[0] = Color_Mat[0];
                Slime_Face.GetComponent<Renderer>().materials = mat;
                break;
            case 8:
                mat[0] = Color_Mat[1];
                Slime_Face.GetComponent<Renderer>().materials = mat;
                break;
            case 9:
                mat[0] = Color_Mat[2];
                Slime_Face.GetComponent<Renderer>().materials = mat;
                break;
        }
    }









}
