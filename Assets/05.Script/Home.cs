using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Home : MonoBehaviour
{
    public Button homeButton; // 홈 버튼

    // Start is called before the first frame update
    void Start()
    {
        // 홈 버튼에 이벤트 등록
        homeButton.onClick.AddListener(GoToHome);
    }
    private void GoToHome()
    {
        SceneManager.LoadScene("Home");
    }
}
