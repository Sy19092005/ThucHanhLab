using UnityEngine;

public class TurretRotation : MonoBehaviour
{
    public Transform target;
    public float rotateSpeed = 3f;
    public bool smooth = true;

    void Update()
    {
        Vector3 dir = target.position - transform.position;
        Quaternion rot = Quaternion.LookRotation(dir);

        if (smooth)
            transform.rotation = Quaternion.Slerp(
                transform.rotation, rot, rotateSpeed * Time.deltaTime);
        else
            transform.rotation = rot;
    }
}

