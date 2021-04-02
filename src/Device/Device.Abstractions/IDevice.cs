namespace Device.Abstractions
{
    public interface IDevice
    {
        string Name { get; set; }

        void WriteCode();

        void ReadCode();

    }
}