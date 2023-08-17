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
    /// Manage dedicated server networking interface on SCALE and HIGH-GRADE range.
    /// 
    /// ## Example Usage
    /// 
    /// The following example aims to bind all interfaces in a vRack
    /// 
    /// The following example aims to attach the server to two different vRack.
    /// 
    /// ## Import
    /// 
    /// A dedicated server networking configuration can be imported using the `service_name`. bash &lt;break&gt;&lt;break&gt;```sh&lt;break&gt; $ pulumi import ovh:Dedicated/serverNetworking:ServerNetworking server service_name &lt;break&gt;```&lt;break&gt;&lt;break&gt;
    /// </summary>
    [OvhResourceType("ovh:Dedicated/serverNetworking:ServerNetworking")]
    public partial class ServerNetworking : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Operation description.
        /// </summary>
        [Output("description")]
        public Output<string> Description { get; private set; } = null!;

        /// <summary>
        /// Interface or interfaces aggregation.
        /// </summary>
        [Output("interfaces")]
        public Output<ImmutableArray<Outputs.ServerNetworkingInterface>> Interfaces { get; private set; } = null!;

        /// <summary>
        /// The service_name of your dedicated server. The full list of available dedicated servers can be found using the `ovh.getServers` datasource.
        /// </summary>
        [Output("serviceName")]
        public Output<string> ServiceName { get; private set; } = null!;

        /// <summary>
        /// status of the networking configuration (should be `active`).
        /// </summary>
        [Output("status")]
        public Output<string> Status { get; private set; } = null!;


        /// <summary>
        /// Create a ServerNetworking resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ServerNetworking(string name, ServerNetworkingArgs args, CustomResourceOptions? options = null)
            : base("ovh:Dedicated/serverNetworking:ServerNetworking", name, args ?? new ServerNetworkingArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ServerNetworking(string name, Input<string> id, ServerNetworkingState? state = null, CustomResourceOptions? options = null)
            : base("ovh:Dedicated/serverNetworking:ServerNetworking", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing ServerNetworking resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ServerNetworking Get(string name, Input<string> id, ServerNetworkingState? state = null, CustomResourceOptions? options = null)
        {
            return new ServerNetworking(name, id, state, options);
        }
    }

    public sealed class ServerNetworkingArgs : global::Pulumi.ResourceArgs
    {
        [Input("interfaces", required: true)]
        private InputList<Inputs.ServerNetworkingInterfaceArgs>? _interfaces;

        /// <summary>
        /// Interface or interfaces aggregation.
        /// </summary>
        public InputList<Inputs.ServerNetworkingInterfaceArgs> Interfaces
        {
            get => _interfaces ?? (_interfaces = new InputList<Inputs.ServerNetworkingInterfaceArgs>());
            set => _interfaces = value;
        }

        /// <summary>
        /// The service_name of your dedicated server. The full list of available dedicated servers can be found using the `ovh.getServers` datasource.
        /// </summary>
        [Input("serviceName", required: true)]
        public Input<string> ServiceName { get; set; } = null!;

        public ServerNetworkingArgs()
        {
        }
        public static new ServerNetworkingArgs Empty => new ServerNetworkingArgs();
    }

    public sealed class ServerNetworkingState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Operation description.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("interfaces")]
        private InputList<Inputs.ServerNetworkingInterfaceGetArgs>? _interfaces;

        /// <summary>
        /// Interface or interfaces aggregation.
        /// </summary>
        public InputList<Inputs.ServerNetworkingInterfaceGetArgs> Interfaces
        {
            get => _interfaces ?? (_interfaces = new InputList<Inputs.ServerNetworkingInterfaceGetArgs>());
            set => _interfaces = value;
        }

        /// <summary>
        /// The service_name of your dedicated server. The full list of available dedicated servers can be found using the `ovh.getServers` datasource.
        /// </summary>
        [Input("serviceName")]
        public Input<string>? ServiceName { get; set; }

        /// <summary>
        /// status of the networking configuration (should be `active`).
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        public ServerNetworkingState()
        {
        }
        public static new ServerNetworkingState Empty => new ServerNetworkingState();
    }
}
