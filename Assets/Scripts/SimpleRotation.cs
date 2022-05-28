using UnityEngine;

public class SimpleRotation : MonoBehaviour
{
    public Vector3 RotateVector;

    private void Update()
    {
        transform.Rotate(RotateVector * Time.deltaTime);
    }
}