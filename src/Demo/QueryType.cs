using HotChocolate.Types;

namespace Demo
{
    public class QueryType: ObjectType
    {
        protected override void Configure(IObjectTypeDescriptor descriptor)
        {
            descriptor.Field("alpha")
                .Type<NonNullType<AlphabeticalInterfaceType>>()
                .Resolver(ctx => new Abc());
        }
    }
}
