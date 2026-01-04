using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float moveSpeed = 7f;
    [SerializeField] float rotationSpeed = 5f;

    private bool isWalking;

    void Update()
    {
        Vector3 inputVector = new Vector3(0, 0, 0);

        if (Input.GetKey(KeyCode.W))
        {
            inputVector.z = +1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            inputVector.z = -1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            inputVector.x = -1;
        }
        if ( Input.GetKey(KeyCode.D))
        {
            inputVector.x = +1;
        }

        isWalking = inputVector != Vector3.zero;
        inputVector = inputVector.normalized;
        transform.position += inputVector * Time.deltaTime * moveSpeed;

        transform.forward = Vector3.Slerp(transform.forward, inputVector, Time.deltaTime * rotationSpeed);
    }

    public bool IsWalking()
    {
        return isWalking;
    }
}
