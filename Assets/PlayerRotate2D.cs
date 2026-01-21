using UnityEngine;
using UnityEngine.UI;

public class PlayerRotate2D : MonoBehaviour
{
    public Text angleText;

    void Update()
    {
        // Lấy vị trí chuột trong world
        Vector3 mouseWorld =
            Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseWorld.z = 0f;

        // Vector hướng từ player tới chuột
        Vector2 direction =
            (mouseWorld - transform.position).normalized;

        // Tính góc SignedAngle
        float angle =
            Vector2.SignedAngle(Vector2.up, direction);

        // Xoay player
        transform.rotation =
            Quaternion.Euler(0, 0, angle);

        // Hiển thị góc
        if (angleText != null)
            angleText.text = "Angle: " + angle.ToString("F1");
    }
}
