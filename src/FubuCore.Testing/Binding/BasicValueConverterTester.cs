using FubuCore.Binding;
using FubuCore.Conversion;
using FubuTestingSupport;
using NUnit.Framework;
using Rhino.Mocks;

namespace FubuCore.Testing.Binding
{
    [TestFixture]
    public class BasicValueConverterTester
    {
        [Test]
        public void create_default_of_values()
        {
            var context = MockRepository.GenerateMock<IPropertyContext>();
            context.Stub(x => x.PropertyValue).Return(null);

            new BasicValueConverter(null, typeof (string)).Convert(context)
                .ShouldBeNull();

            new BasicValueConverter(null, typeof (int)).Convert(context)
                .ShouldEqual(default(int));

            new BasicValueConverter(null, typeof (bool)).Convert(context)
                .ShouldEqual(default(bool));
        }
    }
}