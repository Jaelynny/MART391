using UnityEngine;
using System.Collections.Generic;

public class PacketBuffer : MonoBehaviour
{
    private List<Packet> packetBuffer = new List<Packet>();

    void ReceivePacket(Packet packet)
    {
        packetBuffer.Add(packet);
        packetBuffer.Sort((a, b) => a.SequenceNumber.CompareTo(b.SequenceNumber));
    }

    void Update()
    {
        if (packetBuffer.Count > 0)
        {
            Packet packet = packetBuffer[0];
            packetBuffer.RemoveAt(0);
            InterpolationHandler.Instance.InterpolateState(packet);
        }
    }
}
