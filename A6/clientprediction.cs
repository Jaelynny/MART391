using UnityEngine;

public class ClientPrediction : MonoBehaviour
{
    public float speed = 5f;
    private Vector3 movementInput;

    void Update()
    {
        if (isLocalPlayer)
        {
            // Get player input
            movementInput = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

            // Predict player movement
            Vector3 predictedPosition = transform.position + (movementInput * speed * Time.deltaTime);
            transform.position = predictedPosition;

            // Send predicted position to server
            SendPositionToServer(predictedPosition);
        }
    }

    void SendPositionToServer(Vector3 position)
    {
        // Implement your networking code to send the position to the server
    }
}
