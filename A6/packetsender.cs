using UnityEngine;
using System.Collections;

public class PacketSender : MonoBehaviour
{
    private int nextSequenceNumber = 0;
    private float ackTimeout = 1.0f;

    void SendPacket(Packet packet)
    {
        packet.SequenceNumber = nextSequenceNumber++;
        SendToNetwork(packet);
        StartCoroutine(WaitForAck(packet));
    }

    IEnumerator WaitForAck(Packet packet)
    {
        yield return new WaitForSeconds(ackTimeout);
        if (!packet.Acknowledged)
        {
            SendToNetwork(packet); // Retransmit packet
        }
    }

    void SendToNetwork(Packet packet)
    {
        // Implement your networking code to send the packet
    }
}
