using UnityEngine;
using UnityEngine.SceneManagement;  // ใช้สำหรับการเปลี่ยนฉาก

public class PlayerController : MonoBehaviour
{
    // ฟังก์ชันนี้จะถูกเรียกเมื่อมีการชนกับวัตถุที่มี Collider2D
    private void OnTriggerEnter2D(Collider2D other)
    {
        // ตรวจสอบว่าผู้เล่นชนกับวัตถุที่มีแท็ก "NextLevel"
        if (other.CompareTag("NextLevel"))
        {
            ChangeScene("Scene2");  // เปลี่ยนไปฉากชื่อ "Level2"
        }
    }

    // ฟังก์ชันสำหรับเปลี่ยนฉาก
    void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
