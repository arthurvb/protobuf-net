// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: protogen.proto

#pragma warning disable CS1591, CS0612, CS3021

namespace ProtoBuf.CustomOptions
{

    [global::ProtoBuf.ProtoContract()]
    internal partial class ProtogenFileOptions
    {
        [global::ProtoBuf.ProtoMember(1, Name = @"namespace")]
        [global::System.ComponentModel.DefaultValue("")]
        internal string Namespace { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"access")]
        internal Access Access { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    internal partial class ProtogenMessageOptions
    {
        [global::ProtoBuf.ProtoMember(1, Name = @"name")]
        [global::System.ComponentModel.DefaultValue("")]
        internal string Name { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"access")]
        internal Access Access { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    internal partial class ProtogenFieldOptions
    {
        [global::ProtoBuf.ProtoMember(1, Name = @"name")]
        [global::System.ComponentModel.DefaultValue("")]
        internal string Name { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"access")]
        internal Access Access { get; set; }

        [global::ProtoBuf.ProtoMember(3)]
        internal bool asRef { get; set; }

        [global::ProtoBuf.ProtoMember(4)]
        internal bool dynamicType { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    internal partial class ProtogenEnumOptions
    {
        [global::ProtoBuf.ProtoMember(1, Name = @"name")]
        [global::System.ComponentModel.DefaultValue("")]
        internal string Name { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"access")]
        internal Access Access { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    internal partial class ProtogenEnumValueOptions
    {
        [global::ProtoBuf.ProtoMember(1, Name = @"name")]
        [global::System.ComponentModel.DefaultValue("")]
        internal string Name { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    internal partial class ProtogenServiceOptions
    {
        [global::ProtoBuf.ProtoMember(1, Name = @"name")]
        [global::System.ComponentModel.DefaultValue("")]
        internal string Name { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"access")]
        internal Access Access { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    internal partial class ProtogenMethodOptions
    {
        [global::ProtoBuf.ProtoMember(1, Name = @"name")]
        [global::System.ComponentModel.DefaultValue("")]
        internal string Name { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public enum Access
    {
        [global::ProtoBuf.ProtoEnum(Name = @"INHERIT")]
        Inherit = 0,
        [global::ProtoBuf.ProtoEnum(Name = @"PUBLIC")]
        Public = 1,
        [global::ProtoBuf.ProtoEnum(Name = @"PRIVATE")]
        Private = 2,
        [global::ProtoBuf.ProtoEnum(Name = @"INTERNAL")]
        Internal = 3,
    }

    internal static class Extensions
    {
        internal static ProtogenFileOptions GetOptions(global::Google.Protobuf.Reflection.FileOptions obj)
        => obj == null ? default(ProtogenFileOptions) : global::ProtoBuf.Extensible.GetValue<ProtogenFileOptions>(obj, 1037);

        internal static ProtogenMessageOptions GetOptions(global::Google.Protobuf.Reflection.MessageOptions obj)
        => obj == null ? default(ProtogenMessageOptions) : global::ProtoBuf.Extensible.GetValue<ProtogenMessageOptions>(obj, 1037);

        internal static ProtogenFieldOptions GetOptions(global::Google.Protobuf.Reflection.FieldOptions obj)
        => obj == null ? default(ProtogenFieldOptions) : global::ProtoBuf.Extensible.GetValue<ProtogenFieldOptions>(obj, 1037);

        internal static ProtogenEnumOptions GetOptions(global::Google.Protobuf.Reflection.EnumOptions obj)
        => obj == null ? default(ProtogenEnumOptions) : global::ProtoBuf.Extensible.GetValue<ProtogenEnumOptions>(obj, 1037);

        internal static ProtogenEnumValueOptions GetOptions(global::Google.Protobuf.Reflection.EnumValueOptions obj)
        => obj == null ? default(ProtogenEnumValueOptions) : global::ProtoBuf.Extensible.GetValue<ProtogenEnumValueOptions>(obj, 1037);

        internal static ProtogenServiceOptions GetOptions(global::Google.Protobuf.Reflection.ServiceOptions obj)
        => obj == null ? default(ProtogenServiceOptions) : global::ProtoBuf.Extensible.GetValue<ProtogenServiceOptions>(obj, 1037);

        internal static ProtogenMethodOptions GetOptions(global::Google.Protobuf.Reflection.MethodOptions obj)
        => obj == null ? default(ProtogenMethodOptions) : global::ProtoBuf.Extensible.GetValue<ProtogenMethodOptions>(obj, 1037);

    }
}

#pragma warning restore CS1591, CS0612, CS3021