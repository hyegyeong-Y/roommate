using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Page : MonoBehaviour
{
    public Button[] pageButtons; // ������ ��ư �迭

    // Start is called before the first frame update
    void Start()
    {
        // ������ ��ư�� �̺�Ʈ ���
        for (int i = 0; i < pageButtons.Length; i++)
        {
            int pageIndex = i + 1; // ������ �ε����� 1���� ����
            pageButtons[i].onClick.AddListener(() => GoToPage(pageIndex));
        }

    }

    private void GoToPage(int pageIndex)
    {
        SceneManager.LoadScene(pageIndex == 0 ? "Home" : "Page" + pageIndex);
    }
}
