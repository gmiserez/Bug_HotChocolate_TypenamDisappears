using HotChocolate.Types;

namespace Demo
{
    public class AlphabeticalInterfaceType: InterfaceType
    {
        protected override void Configure(IInterfaceTypeDescriptor descriptor)
        {
            descriptor.Name("Alphabetical");
            descriptor.Field("foo").Type<NonNullType<StringType>>();
        }
    }
}
