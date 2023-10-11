using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Page : MonoBehaviour
{
    public Button[] pageButtons; // 페이지 버튼 배열

    // Start is called before the first frame update
    void Start()
    {
        // 페이지 버튼에 이벤트 등록
        for (int i = 0; i < pageButtons.Length; i++)
        {
            int pageIndex = i + 1; // 페이지 인덱스는 1부터 시작
            pageButtons[i].onClick.AddListener(() => GoToPage(pageIndex));
        }

    }

    private void GoToPage(int pageIndex)
    {
        SceneManager.LoadScene(pageIndex == 0 ? "Home" : "Page" + pageIndex);
    }
}
