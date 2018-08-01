.class private auto ansi '<Module>'
{
} // end of class <Module>

.class private auto ansi beforefieldinit Foo
    extends [mscorlib]System.Object
{
    // Fields
    .field private int32 '<Bar>k__BackingField'
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (
        01 00 00 00
    )

    // Methods
    .method public hidebysig specialname
        instance void set_Bar (
            int32 'value'
        ) cil managed
    {
        .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (
            01 00 00 00
        )
        // Method begins at RVA 0x2050
        // Code size 8 (0x8)
        .maxstack 8

        IL_0000: ldarg.0
        IL_0001: ldarg.1
        IL_0002: stfld int32 Foo::'<Bar>k__BackingField'
        IL_0007: ret
    } // end of method Foo::set_Bar

    .method public hidebysig specialname
        instance int32 get_Bar () cil managed
    {
        .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (
            01 00 00 00
        )
        // Method begins at RVA 0x2059
        // Code size 7 (0x7)
        .maxstack 8

        IL_0000: ldarg.0
        IL_0001: ldfld int32 Foo::'<Bar>k__BackingField'
        IL_0006: ret
    } // end of method Foo::get_Bar

    .method public hidebysig specialname rtspecialname
        instance void .ctor () cil managed
    {
        // Method begins at RVA 0x2061
        // Code size 7 (0x7)
        .maxstack 8

        IL_0000: ldarg.0
        IL_0001: call instance void [mscorlib]System.Object::.ctor()
        IL_0006: ret
    } // end of method Foo::.ctor

    // Properties
    .property instance int32 Bar()
    {
        .get instance int32 Foo::get_Bar()
        .set instance void Foo::set_Bar(int32)
    }

} // end of class Foo

.class public auto ansi beforefieldinit Program
    extends [mscorlib]System.Object
{
    // Methods
    .method public hidebysig static
        void Main (
            string[] args
        ) cil managed
    {
        // Method begins at RVA 0x2069
        // Code size 7 (0x7)
        .maxstack 8

        IL_0000: newobj instance void Foo::.ctor()
        IL_0005: pop
        IL_0006: ret
    } // end of method Program::Main

    .method public hidebysig specialname rtspecialname
        instance void .ctor () cil managed
    {
        // Method begins at RVA 0x2061
        // Code size 7 (0x7)
        .maxstack 8

        IL_0000: ldarg.0
        IL_0001: call instance void [mscorlib]System.Object::.ctor()
        IL_0006: ret
    } // end of method Program::.ctor

} // end of class Program

