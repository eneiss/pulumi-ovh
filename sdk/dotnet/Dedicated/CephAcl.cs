// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace ediri.Ovh.Dedicated
{
    /// <summary>
    /// Add a new access ACL for the given network/mask.
    /// 
    /// ## Example Usage
    /// </summary>
    [OvhResourceType("ovh:Dedicated/cephAcl:CephAcl")]
    public partial class CephAcl : global::Pulumi.CustomResource
    {
        /// <summary>
        /// IP family. `IPv4` or `IPv6`
        /// </summary>
        [Output("family")]
        public Output<string> Family { get; private set; } = null!;

        /// <summary>
        /// The network mask to apply
        /// </summary>
        [Output("netmask")]
        public Output<string> Netmask { get; private set; } = null!;

        /// <summary>
        /// The network IP to authorize
        /// </summary>
        [Output("network")]
        public Output<string> Network { get; private set; } = null!;

        /// <summary>
        /// The internal name of your dedicated CEPH
        /// </summary>
        [Output("serviceName")]
        public Output<string> ServiceName { get; private set; } = null!;


        /// <summary>
        /// Create a CephAcl resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public CephAcl(string name, CephAclArgs args, CustomResourceOptions? options = null)
            : base("ovh:Dedicated/cephAcl:CephAcl", name, args ?? new CephAclArgs(), MakeResourceOptions(options, ""))
        {
        }

        private CephAcl(string name, Input<string> id, CephAclState? state = null, CustomResourceOptions? options = null)
            : base("ovh:Dedicated/cephAcl:CephAcl", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "github://api.github.com/scraly/pulumi-ovh",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing CephAcl resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static CephAcl Get(string name, Input<string> id, CephAclState? state = null, CustomResourceOptions? options = null)
        {
            return new CephAcl(name, id, state, options);
        }
    }

    public sealed class CephAclArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The network mask to apply
        /// </summary>
        [Input("netmask", required: true)]
        public Input<string> Netmask { get; set; } = null!;

        /// <summary>
        /// The network IP to authorize
        /// </summary>
        [Input("network", required: true)]
        public Input<string> Network { get; set; } = null!;

        /// <summary>
        /// The internal name of your dedicated CEPH
        /// </summary>
        [Input("serviceName", required: true)]
        public Input<string> ServiceName { get; set; } = null!;

        public CephAclArgs()
        {
        }
        public static new CephAclArgs Empty => new CephAclArgs();
    }

    public sealed class CephAclState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// IP family. `IPv4` or `IPv6`
        /// </summary>
        [Input("family")]
        public Input<string>? Family { get; set; }

        /// <summary>
        /// The network mask to apply
        /// </summary>
        [Input("netmask")]
        public Input<string>? Netmask { get; set; }

        /// <summary>
        /// The network IP to authorize
        /// </summary>
        [Input("network")]
        public Input<string>? Network { get; set; }

        /// <summary>
        /// The internal name of your dedicated CEPH
        /// </summary>
        [Input("serviceName")]
        public Input<string>? ServiceName { get; set; }

        public CephAclState()
        {
        }
        public static new CephAclState Empty => new CephAclState();
    }
}
