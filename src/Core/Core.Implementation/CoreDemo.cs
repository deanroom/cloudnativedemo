using Core.Abstractions;
using Device.Abstractions;
using Framework.Abstractions;

namespace Core.Implementation
{
    public class CoreDemo:ICore
    {
        private readonly IFramework _framework;
        private readonly IDevice _device;

        public CoreDemo(IFramework framework, IDevice device)
        {
            _framework = framework;
            _device = device;
        }

        public string Name { get; set; }
        public void Start()
        {
            _device.WriteCode($"[{nameof(CoreDemo)}-Start()] said 'Get up, it is time to make money.'");
        }

        public void Stop()
        {
            _device.WriteCode($"[{nameof(CoreDemo)}-Stop()] said 'I love you baby, please take a rest.'");
        }

        public void Abort()
        {
            _device.WriteCode($"[{nameof(CoreDemo)}-Abort()] said 'Oh no, what your ar doing, please stop it!'");
        }

        public void Do(string message)
        {
            var result = _device.ReadCode();
            _framework.Info($"[{nameof(CoreDemo)}-Do()] get command [{message}] and replied [{result}]");
        }
    }
}