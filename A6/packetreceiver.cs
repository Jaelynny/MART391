using UnityEngine;

public class PacketReceiver : MonoBehaviour
{
    private int expectedSequenceNumber = 0;

    void ReceivePacket(Packet packet)
    {
        if (packet.SequenceNumber == expectedSequenceNumber)
        {
            ProcessPacket(packet);
            expectedSequenceNumber++;
            SendAck(packet.SequenceNumber);
        }
    }

    void ProcessPacket(Packet packet)
    {
        // Implement your packet processing code
    }

    void SendAck(int sequenceNumber)
    {
        AckPacket ack = new AckPacket(sequenceNumber);
        SendToNetwork(ack);
    }

    void SendToNetwork(AckPacket ack)
    {
        // Implement your networking code to send the acknowledgment packet
    }
}
