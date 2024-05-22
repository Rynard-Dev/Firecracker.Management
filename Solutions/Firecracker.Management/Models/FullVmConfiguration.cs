// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Firecracker.Management.Models {
    #pragma warning disable CS1591
    public class FullVmConfiguration : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Balloon device descriptor.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Firecracker.Management.Models.Balloon? Balloon { get; set; }
#nullable restore
#else
        public Firecracker.Management.Models.Balloon Balloon { get; set; }
#endif
        /// <summary>Boot source descriptor.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Firecracker.Management.Models.BootSource? BootSource { get; set; }
#nullable restore
#else
        public Firecracker.Management.Models.BootSource BootSource { get; set; }
#endif
        /// <summary>Configurations for all block devices.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Drive>? Drives { get; set; }
#nullable restore
#else
        public List<Drive> Drives { get; set; }
#endif
        /// <summary>Describes the configuration option for the logging capability.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Firecracker.Management.Models.Logger? Logger { get; set; }
#nullable restore
#else
        public Firecracker.Management.Models.Logger Logger { get; set; }
#endif
        /// <summary>Describes the number of vCPUs, memory size, SMT capabilities, huge page configuration and the CPU template.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public MachineConfiguration? MachineConfig { get; set; }
#nullable restore
#else
        public MachineConfiguration MachineConfig { get; set; }
#endif
        /// <summary>Describes the configuration option for the metrics capability.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Firecracker.Management.Models.Metrics? Metrics { get; set; }
#nullable restore
#else
        public Firecracker.Management.Models.Metrics Metrics { get; set; }
#endif
        /// <summary>Defines the MMDS configuration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Firecracker.Management.Models.MmdsConfig? MmdsConfig { get; set; }
#nullable restore
#else
        public Firecracker.Management.Models.MmdsConfig MmdsConfig { get; set; }
#endif
        /// <summary>Configurations for all net devices.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<NetworkInterface>? NetworkInterfaces { get; set; }
#nullable restore
#else
        public List<NetworkInterface> NetworkInterfaces { get; set; }
#endif
        /// <summary>Defines a vsock device, backed by a set of Unix Domain Sockets, on the host side. For host-initiated connections, Firecracker will be listening on the Unix socket identified by the path `uds_path`. Firecracker will create this socket, bind and listen on it. Host-initiated connections will be performed by connection to this socket and issuing a connection forwarding request to the desired guest-side vsock port (i.e. `CONNECT 52\n`, to connect to port 52). For guest-initiated connections, Firecracker will expect host software to be bound and listening on Unix sockets at `uds_path_&lt;PORT&gt;`. E.g. &quot;/path/to/host_vsock.sock_52&quot; for port number 52.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Firecracker.Management.Models.Vsock? Vsock { get; set; }
#nullable restore
#else
        public Firecracker.Management.Models.Vsock Vsock { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="FullVmConfiguration"/> and sets the default values.
        /// </summary>
        public FullVmConfiguration()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="FullVmConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static FullVmConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new FullVmConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"balloon", n => { Balloon = n.GetObjectValue<Firecracker.Management.Models.Balloon>(Firecracker.Management.Models.Balloon.CreateFromDiscriminatorValue); } },
                {"boot-source", n => { BootSource = n.GetObjectValue<Firecracker.Management.Models.BootSource>(Firecracker.Management.Models.BootSource.CreateFromDiscriminatorValue); } },
                {"drives", n => { Drives = n.GetCollectionOfObjectValues<Drive>(Drive.CreateFromDiscriminatorValue)?.ToList(); } },
                {"logger", n => { Logger = n.GetObjectValue<Firecracker.Management.Models.Logger>(Firecracker.Management.Models.Logger.CreateFromDiscriminatorValue); } },
                {"machine-config", n => { MachineConfig = n.GetObjectValue<MachineConfiguration>(MachineConfiguration.CreateFromDiscriminatorValue); } },
                {"metrics", n => { Metrics = n.GetObjectValue<Firecracker.Management.Models.Metrics>(Firecracker.Management.Models.Metrics.CreateFromDiscriminatorValue); } },
                {"mmds-config", n => { MmdsConfig = n.GetObjectValue<Firecracker.Management.Models.MmdsConfig>(Firecracker.Management.Models.MmdsConfig.CreateFromDiscriminatorValue); } },
                {"network-interfaces", n => { NetworkInterfaces = n.GetCollectionOfObjectValues<NetworkInterface>(NetworkInterface.CreateFromDiscriminatorValue)?.ToList(); } },
                {"vsock", n => { Vsock = n.GetObjectValue<Firecracker.Management.Models.Vsock>(Firecracker.Management.Models.Vsock.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Firecracker.Management.Models.Balloon>("balloon", Balloon);
            writer.WriteObjectValue<Firecracker.Management.Models.BootSource>("boot-source", BootSource);
            writer.WriteCollectionOfObjectValues<Drive>("drives", Drives);
            writer.WriteObjectValue<Firecracker.Management.Models.Logger>("logger", Logger);
            writer.WriteObjectValue<MachineConfiguration>("machine-config", MachineConfig);
            writer.WriteObjectValue<Firecracker.Management.Models.Metrics>("metrics", Metrics);
            writer.WriteObjectValue<Firecracker.Management.Models.MmdsConfig>("mmds-config", MmdsConfig);
            writer.WriteCollectionOfObjectValues<NetworkInterface>("network-interfaces", NetworkInterfaces);
            writer.WriteObjectValue<Firecracker.Management.Models.Vsock>("vsock", Vsock);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
