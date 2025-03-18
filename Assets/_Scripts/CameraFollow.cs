using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    public Transform playerTransform;

    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - playerTransform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 newPosition = playerTransform.position + offset;
        transform.position = newPosition;
    }
}
