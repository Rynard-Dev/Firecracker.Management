// <auto-generated/>
#pragma warning disable CS0618
using Firecracker.Management.Drives.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Firecracker.Management.Drives
{
    /// <summary>
    /// Builds and executes requests for operations under \drives
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class DrivesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Firecracker.Management.drives.item collection</summary>
        /// <param name="position">The id of the guest drive</param>
        /// <returns>A <see cref="global::Firecracker.Management.Drives.Item.WithDrive_ItemRequestBuilder"/></returns>
        public global::Firecracker.Management.Drives.Item.WithDrive_ItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("drive_id", position);
                return new global::Firecracker.Management.Drives.Item.WithDrive_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Firecracker.Management.Drives.DrivesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DrivesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/drives", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Firecracker.Management.Drives.DrivesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DrivesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/drives", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
