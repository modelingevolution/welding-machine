using FluentAssertions;
using ModelingEvolution.Drawing;
using ModelingEvolution.Signals;
using Xunit;

namespace ModelingEvolution.WeldingMachine.Tests;

public class IWeldingMachineTests
{
    [Fact]
    public void Current_property_type_is_ISignal_of_Amps_float()
    {
        var prop = typeof(IWeldingMachine).GetProperty("Current");
        prop.Should().NotBeNull();
        prop!.PropertyType.Should().Be(typeof(ISignal<Amps<float>>));
    }
}
