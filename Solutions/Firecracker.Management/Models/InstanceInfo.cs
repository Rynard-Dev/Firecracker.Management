// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Firecracker.Management.Models {
    /// <summary>
    /// Describes MicroVM instance information.
    /// </summary>
    public class InstanceInfo : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Application name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppName { get; set; }
#nullable restore
#else
        public string AppName { get; set; }
#endif
        /// <summary>MicroVM / instance ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The current detailed state (Not started, Running, Paused) of the Firecracker instance. This value is read-only for the control-plane.</summary>
        public InstanceInfo_state? State { get; set; }
        /// <summary>MicroVM hypervisor build version.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VmmVersion { get; set; }
#nullable restore
#else
        public string VmmVersion { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="InstanceInfo"/> and sets the default values.
        /// </summary>
        public InstanceInfo()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="InstanceInfo"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static InstanceInfo CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new InstanceInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"app_name", n => { AppName = n.GetStringValue(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"state", n => { State = n.GetEnumValue<InstanceInfo_state>(); } },
                {"vmm_version", n => { VmmVersion = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("app_name", AppName);
            writer.WriteStringValue("id", Id);
            writer.WriteEnumValue<InstanceInfo_state>("state", State);
            writer.WriteStringValue("vmm_version", VmmVersion);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
