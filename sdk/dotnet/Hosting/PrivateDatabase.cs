// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace ediri.Ovh.Hosting
{
    /// <summary>
    /// ## Example Usage
    /// 
    /// ## Import
    /// 
    /// OVHcloud Webhosting database can be imported using the `service_name`, E.g., &lt;break&gt;&lt;break&gt;```sh&lt;break&gt; $ pulumi import ovh:Hosting/privateDatabase:PrivateDatabase database service_name &lt;break&gt;```&lt;break&gt;&lt;break&gt;
    /// </summary>
    [OvhResourceType("ovh:Hosting/privateDatabase:PrivateDatabase")]
    public partial class PrivateDatabase : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Number of CPU on your private database
        /// </summary>
        [Output("cpu")]
        public Output<int> Cpu { get; private set; } = null!;

        /// <summary>
        /// Datacenter where this private database is located
        /// </summary>
        [Output("datacenter")]
        public Output<string> Datacenter { get; private set; } = null!;

        /// <summary>
        /// Name displayed in customer panel for your private database
        /// </summary>
        [Output("displayName")]
        public Output<string> DisplayName { get; private set; } = null!;

        /// <summary>
        /// Private database hostname
        /// </summary>
        [Output("hostname")]
        public Output<string> Hostname { get; private set; } = null!;

        /// <summary>
        /// Private database FTP hostname
        /// </summary>
        [Output("hostnameFtp")]
        public Output<string> HostnameFtp { get; private set; } = null!;

        /// <summary>
        /// Infrastructure where service was stored
        /// </summary>
        [Output("infrastructure")]
        public Output<string> Infrastructure { get; private set; } = null!;

        /// <summary>
        /// Type of the private database offer
        /// </summary>
        [Output("offer")]
        public Output<string> Offer { get; private set; } = null!;

        /// <summary>
        /// Details about your Order
        /// </summary>
        [Output("orders")]
        public Output<ImmutableArray<Outputs.PrivateDatabaseOrder>> Orders { get; private set; } = null!;

        /// <summary>
        /// OVHcloud Subsidiary
        /// </summary>
        [Output("ovhSubsidiary")]
        public Output<string> OvhSubsidiary { get; private set; } = null!;

        /// <summary>
        /// Ovh payment mode
        /// </summary>
        [Output("paymentMean")]
        public Output<string?> PaymentMean { get; private set; } = null!;

        /// <summary>
        /// Product Plan to order
        /// </summary>
        [Output("plan")]
        public Output<Outputs.PrivateDatabasePlan> Plan { get; private set; } = null!;

        /// <summary>
        /// Product Plan to order
        /// </summary>
        [Output("planOptions")]
        public Output<ImmutableArray<Outputs.PrivateDatabasePlanOption>> PlanOptions { get; private set; } = null!;

        /// <summary>
        /// Private database service port
        /// </summary>
        [Output("port")]
        public Output<int> Port { get; private set; } = null!;

        /// <summary>
        /// Private database FTP port
        /// </summary>
        [Output("portFtp")]
        public Output<int> PortFtp { get; private set; } = null!;

        /// <summary>
        /// Space allowed (in MB) on your private database
        /// </summary>
        [Output("quotaSize")]
        public Output<int> QuotaSize { get; private set; } = null!;

        /// <summary>
        /// Sapce used (in MB) on your private database
        /// </summary>
        [Output("quotaUsed")]
        public Output<int> QuotaUsed { get; private set; } = null!;

        /// <summary>
        /// Amount of ram (in MB) on your private database
        /// </summary>
        [Output("ram")]
        public Output<int> Ram { get; private set; } = null!;

        /// <summary>
        /// Private database server name
        /// </summary>
        [Output("server")]
        public Output<string> Server { get; private set; } = null!;

        /// <summary>
        /// Service name
        /// </summary>
        [Output("serviceName")]
        public Output<string> ServiceName { get; private set; } = null!;

        /// <summary>
        /// Private database state
        /// </summary>
        [Output("state")]
        public Output<string> State { get; private set; } = null!;

        /// <summary>
        /// Private database type
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;

        /// <summary>
        /// URN of the private database, used when writing IAM policies
        /// </summary>
        [Output("urn")]
        public Output<string> Urn { get; private set; } = null!;

        /// <summary>
        /// Private database available versions
        /// </summary>
        [Output("version")]
        public Output<string> Version { get; private set; } = null!;

        /// <summary>
        /// Private database version label
        /// </summary>
        [Output("versionLabel")]
        public Output<string> VersionLabel { get; private set; } = null!;

        /// <summary>
        /// Private database version number
        /// </summary>
        [Output("versionNumber")]
        public Output<double> VersionNumber { get; private set; } = null!;


        /// <summary>
        /// Create a PrivateDatabase resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public PrivateDatabase(string name, PrivateDatabaseArgs args, CustomResourceOptions? options = null)
            : base("ovh:Hosting/privateDatabase:PrivateDatabase", name, args ?? new PrivateDatabaseArgs(), MakeResourceOptions(options, ""))
        {
        }

        private PrivateDatabase(string name, Input<string> id, PrivateDatabaseState? state = null, CustomResourceOptions? options = null)
            : base("ovh:Hosting/privateDatabase:PrivateDatabase", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing PrivateDatabase resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static PrivateDatabase Get(string name, Input<string> id, PrivateDatabaseState? state = null, CustomResourceOptions? options = null)
        {
            return new PrivateDatabase(name, id, state, options);
        }
    }

    public sealed class PrivateDatabaseArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name displayed in customer panel for your private database
        /// </summary>
        [Input("displayName")]
        public Input<string>? DisplayName { get; set; }

        /// <summary>
        /// OVHcloud Subsidiary
        /// </summary>
        [Input("ovhSubsidiary", required: true)]
        public Input<string> OvhSubsidiary { get; set; } = null!;

        /// <summary>
        /// Ovh payment mode
        /// </summary>
        [Input("paymentMean")]
        public Input<string>? PaymentMean { get; set; }

        /// <summary>
        /// Product Plan to order
        /// </summary>
        [Input("plan", required: true)]
        public Input<Inputs.PrivateDatabasePlanArgs> Plan { get; set; } = null!;

        [Input("planOptions")]
        private InputList<Inputs.PrivateDatabasePlanOptionArgs>? _planOptions;

        /// <summary>
        /// Product Plan to order
        /// </summary>
        public InputList<Inputs.PrivateDatabasePlanOptionArgs> PlanOptions
        {
            get => _planOptions ?? (_planOptions = new InputList<Inputs.PrivateDatabasePlanOptionArgs>());
            set => _planOptions = value;
        }

        /// <summary>
        /// Service name
        /// </summary>
        [Input("serviceName")]
        public Input<string>? ServiceName { get; set; }

        public PrivateDatabaseArgs()
        {
        }
        public static new PrivateDatabaseArgs Empty => new PrivateDatabaseArgs();
    }

    public sealed class PrivateDatabaseState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Number of CPU on your private database
        /// </summary>
        [Input("cpu")]
        public Input<int>? Cpu { get; set; }

        /// <summary>
        /// Datacenter where this private database is located
        /// </summary>
        [Input("datacenter")]
        public Input<string>? Datacenter { get; set; }

        /// <summary>
        /// Name displayed in customer panel for your private database
        /// </summary>
        [Input("displayName")]
        public Input<string>? DisplayName { get; set; }

        /// <summary>
        /// Private database hostname
        /// </summary>
        [Input("hostname")]
        public Input<string>? Hostname { get; set; }

        /// <summary>
        /// Private database FTP hostname
        /// </summary>
        [Input("hostnameFtp")]
        public Input<string>? HostnameFtp { get; set; }

        /// <summary>
        /// Infrastructure where service was stored
        /// </summary>
        [Input("infrastructure")]
        public Input<string>? Infrastructure { get; set; }

        /// <summary>
        /// Type of the private database offer
        /// </summary>
        [Input("offer")]
        public Input<string>? Offer { get; set; }

        [Input("orders")]
        private InputList<Inputs.PrivateDatabaseOrderGetArgs>? _orders;

        /// <summary>
        /// Details about your Order
        /// </summary>
        public InputList<Inputs.PrivateDatabaseOrderGetArgs> Orders
        {
            get => _orders ?? (_orders = new InputList<Inputs.PrivateDatabaseOrderGetArgs>());
            set => _orders = value;
        }

        /// <summary>
        /// OVHcloud Subsidiary
        /// </summary>
        [Input("ovhSubsidiary")]
        public Input<string>? OvhSubsidiary { get; set; }

        /// <summary>
        /// Ovh payment mode
        /// </summary>
        [Input("paymentMean")]
        public Input<string>? PaymentMean { get; set; }

        /// <summary>
        /// Product Plan to order
        /// </summary>
        [Input("plan")]
        public Input<Inputs.PrivateDatabasePlanGetArgs>? Plan { get; set; }

        [Input("planOptions")]
        private InputList<Inputs.PrivateDatabasePlanOptionGetArgs>? _planOptions;

        /// <summary>
        /// Product Plan to order
        /// </summary>
        public InputList<Inputs.PrivateDatabasePlanOptionGetArgs> PlanOptions
        {
            get => _planOptions ?? (_planOptions = new InputList<Inputs.PrivateDatabasePlanOptionGetArgs>());
            set => _planOptions = value;
        }

        /// <summary>
        /// Private database service port
        /// </summary>
        [Input("port")]
        public Input<int>? Port { get; set; }

        /// <summary>
        /// Private database FTP port
        /// </summary>
        [Input("portFtp")]
        public Input<int>? PortFtp { get; set; }

        /// <summary>
        /// Space allowed (in MB) on your private database
        /// </summary>
        [Input("quotaSize")]
        public Input<int>? QuotaSize { get; set; }

        /// <summary>
        /// Sapce used (in MB) on your private database
        /// </summary>
        [Input("quotaUsed")]
        public Input<int>? QuotaUsed { get; set; }

        /// <summary>
        /// Amount of ram (in MB) on your private database
        /// </summary>
        [Input("ram")]
        public Input<int>? Ram { get; set; }

        /// <summary>
        /// Private database server name
        /// </summary>
        [Input("server")]
        public Input<string>? Server { get; set; }

        /// <summary>
        /// Service name
        /// </summary>
        [Input("serviceName")]
        public Input<string>? ServiceName { get; set; }

        /// <summary>
        /// Private database state
        /// </summary>
        [Input("state")]
        public Input<string>? State { get; set; }

        /// <summary>
        /// Private database type
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        /// <summary>
        /// URN of the private database, used when writing IAM policies
        /// </summary>
        [Input("urn")]
        public Input<string>? Urn { get; set; }

        /// <summary>
        /// Private database available versions
        /// </summary>
        [Input("version")]
        public Input<string>? Version { get; set; }

        /// <summary>
        /// Private database version label
        /// </summary>
        [Input("versionLabel")]
        public Input<string>? VersionLabel { get; set; }

        /// <summary>
        /// Private database version number
        /// </summary>
        [Input("versionNumber")]
        public Input<double>? VersionNumber { get; set; }

        public PrivateDatabaseState()
        {
        }
        public static new PrivateDatabaseState Empty => new PrivateDatabaseState();
    }
}
