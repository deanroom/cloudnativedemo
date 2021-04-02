namespace Core.Abstractions
{
    public interface ICore
    {
        public string Name { get; set; }

        bool Start();

        bool Stop();

        bool Abort();
    }
}