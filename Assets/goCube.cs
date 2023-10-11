using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class goCube : MonoBehaviour
{
    public Button CubeButton;


    void Start()
    {

        CubeButton.onClick.AddListener(GoToCube);
    }
    private void GoToCube()
    {
        SceneManager.LoadScene("Menu");
    }
}
