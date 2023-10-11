using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class goEdite : MonoBehaviour
{
    public Button EditeButton;

 
    void Start()
    {

        EditeButton.onClick.AddListener(GoToEdite);
    }
    private void GoToEdite()
    {
        SceneManager.LoadScene("DBEdite");
    }
}