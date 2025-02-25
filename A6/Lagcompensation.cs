using UnityEngine;
using System.Collections.Generic;

public class LagCompensation : MonoBehaviour
{
    private List<Vector3> stateBuffer = new List<Vector3>();
    private int bufferSize = 10; // Adjust buffer size as needed

    void Update()
    {
        // Store the current game state in the buffer
        stateBuffer.Add(transform.position);

        // Remove old states if the buffer exceeds the size limit
        if (stateBuffer.Count > bufferSize)
        {
            stateBuffer.RemoveAt(0);
        }
    }

    public void ApplyLagCompensation(int stateIndex)
    {
        // Rewind to the correct game state based on the state index
        if (stateIndex >= 0 && stateIndex < stateBuffer.Count)
        {
            transform.position = stateBuffer[stateIndex];
        }
    }
}
