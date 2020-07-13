using HotChocolate.Types;

namespace Demo
{
    public class XyzType: ObjectType<Xyz>
    {
        protected override void Configure(IObjectTypeDescriptor<Xyz> descriptor)
        {
            descriptor.Interface<AlphabeticalInterfaceType>();
        }
    }

    public class Xyz
    {
        public string Foo => "abc";
    }
}
