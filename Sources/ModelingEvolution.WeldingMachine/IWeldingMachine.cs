using ModelingEvolution.Drawing;
using ModelingEvolution.Signals;

namespace ModelingEvolution.WeldingMachine;

public interface IWeldingMachine
{
    /// <summary>
    /// Live welding current as a signal. Consumers gate on <c>Current.HasValue</c> before reading
    /// <c>Current.Value</c> (<c>HasValue == false</c> when the tag is unmapped or no read has
    /// succeeded yet), or call <c>Current.Subscribe</c> to receive
    /// <c>Sample&lt;Amps&lt;float&gt;&gt;</c> events as each polled value arrives.
    /// </summary>
    ISignal<Amps<float>> Current { get; }
}
