// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Firecracker.Management.Models
{
    /// <summary>Type of snapshot to create. It is optional and by default, a full snapshot is created.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public enum SnapshotCreateParams_snapshot_type
    {
        [EnumMember(Value = "Full")]
        #pragma warning disable CS1591
        Full,
        #pragma warning restore CS1591
        [EnumMember(Value = "Diff")]
        #pragma warning disable CS1591
        Diff,
        #pragma warning restore CS1591
    }
}
