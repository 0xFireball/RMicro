namespace RMicro
{
    public interface ITwoWayChannel
    {
        void SendBytes(byte[] data);

        byte[] ReceiveBytes();

        byte[] ReceiveBytes(int length);
    }
}