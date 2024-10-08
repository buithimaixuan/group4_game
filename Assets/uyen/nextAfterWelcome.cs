using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // Namespace chính xác là SceneManager

public class nextAfterWelcome : MonoBehaviour
{
    public string sceneName; // Tên của màn muốn load
    public Button yourButton; // Tham chiếu tới nút UI

    void Start()
    {
        // Đăng ký sự kiện khi bấm nút
        yourButton.onClick.AddListener(OnButtonClick);
    }

    // Phương thức được gọi khi bấm nút
    void OnButtonClick()
    {
        loadNewScene(); // Load màn mới khi bấm nút
    }

    public void loadNewScene()
    {
        SceneManager.LoadScene(sceneName); // Sử dụng SceneManager để load scene
    }
}
