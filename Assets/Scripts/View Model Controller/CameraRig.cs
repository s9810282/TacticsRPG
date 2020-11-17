using UnityEngine;
using System.Collections;
public class CameraRig : MonoBehaviour
{
    public float speed = 3f;
    public Transform follow;
    Transform _transform;

    void Awake()
    {
        _transform = transform;
    }

    void Update()
    {
        transform.localPosition = Vector3.Lerp(transform.position, follow.localPosition, speed * Time.deltaTime);
    }
}
