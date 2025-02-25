public class AckPacket : Packet
{
    public AckPacket(int sequenceNumber)
    {
        SequenceNumber = sequenceNumber;
    }
}
