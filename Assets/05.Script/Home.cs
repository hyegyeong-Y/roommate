using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Home : MonoBehaviour
{
    public Button homeButton; // Ȩ ��ư

    // Start is called before the first frame update
    void Start()
    {
        // Ȩ ��ư�� �̺�Ʈ ���
        homeButton.onClick.AddListener(GoToHome);
    }
    private void GoToHome()
    {
        SceneManager.LoadScene("Home");
    }
}
