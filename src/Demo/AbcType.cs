using HotChocolate.Types;

namespace Demo
{
    public class AbcType : ObjectType<Abc>
    {
        protected override void Configure(IObjectTypeDescriptor<Abc> descriptor)
        {
            descriptor.Interface<AlphabeticalInterfaceType>();
        }
    }

    public class Abc
    {
        public string Foo => "abc";
    }
}
