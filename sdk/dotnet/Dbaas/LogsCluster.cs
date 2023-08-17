// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace ediri.Ovh.Dbaas
{
    /// <summary>
    /// ## Example Usage
    /// 
    /// ## Import
    /// 
    /// OVHcloud DBaaS Log Data Platform clusters can be imported using the `service_name` and `id` of the cluster, separated by "/" E.g., bash &lt;break&gt;&lt;break&gt;```sh&lt;break&gt; $ pulumi import ovh:Dbaas/logsCluster:LogsCluster ldp service_name/id &lt;break&gt;```&lt;break&gt;&lt;break&gt;
    /// </summary>
    [OvhResourceType("ovh:Dbaas/logsCluster:LogsCluster")]
    public partial class LogsCluster : global::Pulumi.CustomResource
    {
        /// <summary>
        /// List of IP blocks
        /// </summary>
        [Output("archiveAllowedNetworks")]
        public Output<ImmutableArray<string>> ArchiveAllowedNetworks { get; private set; } = null!;

        /// <summary>
        /// type of cluster (DEDICATED, PRO or TRIAL)
        /// </summary>
        [Output("clusterType")]
        public Output<string> ClusterType { get; private set; } = null!;

        /// <summary>
        /// PEM for dedicated inputs
        /// </summary>
        [Output("dedicatedInputPem")]
        public Output<string> DedicatedInputPem { get; private set; } = null!;

        /// <summary>
        /// List of IP blocks
        /// </summary>
        [Output("directInputAllowedNetworks")]
        public Output<ImmutableArray<string>> DirectInputAllowedNetworks { get; private set; } = null!;

        /// <summary>
        /// PEM for direct inputs
        /// </summary>
        [Output("directInputPem")]
        public Output<string> DirectInputPem { get; private set; } = null!;

        /// <summary>
        /// cluster hostname hosting tenant
        /// </summary>
        [Output("hostname")]
        public Output<string> Hostname { get; private set; } = null!;

        /// <summary>
        /// Initial allowed networks for ARCHIVE flow type
        /// </summary>
        [Output("initialArchiveAllowedNetworks")]
        public Output<ImmutableArray<string>> InitialArchiveAllowedNetworks { get; private set; } = null!;

        /// <summary>
        /// Initial allowed networks for DIRECT_INPUT flow type
        /// </summary>
        [Output("initialDirectInputAllowedNetworks")]
        public Output<ImmutableArray<string>> InitialDirectInputAllowedNetworks { get; private set; } = null!;

        /// <summary>
        /// Initial allowed networks for QUERY flow type
        /// </summary>
        [Output("initialQueryAllowedNetworks")]
        public Output<ImmutableArray<string>> InitialQueryAllowedNetworks { get; private set; } = null!;

        /// <summary>
        /// true if all content generated by given service will be placed on this cluster
        /// </summary>
        [Output("isDefault")]
        public Output<bool> IsDefault { get; private set; } = null!;

        /// <summary>
        /// true if given service can perform advanced operations on cluster
        /// </summary>
        [Output("isUnlocked")]
        public Output<bool> IsUnlocked { get; private set; } = null!;

        /// <summary>
        /// List of IP blocks
        /// </summary>
        [Output("queryAllowedNetworks")]
        public Output<ImmutableArray<string>> QueryAllowedNetworks { get; private set; } = null!;

        /// <summary>
        /// datacenter localization
        /// </summary>
        [Output("region")]
        public Output<string> Region { get; private set; } = null!;

        [Output("serviceName")]
        public Output<string> ServiceName { get; private set; } = null!;


        /// <summary>
        /// Create a LogsCluster resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public LogsCluster(string name, LogsClusterArgs args, CustomResourceOptions? options = null)
            : base("ovh:Dbaas/logsCluster:LogsCluster", name, args ?? new LogsClusterArgs(), MakeResourceOptions(options, ""))
        {
        }

        private LogsCluster(string name, Input<string> id, LogsClusterState? state = null, CustomResourceOptions? options = null)
            : base("ovh:Dbaas/logsCluster:LogsCluster", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "github://api.github.com/scraly/pulumi-ovh",
                AdditionalSecretOutputs =
                {
                    "dedicatedInputPem",
                    "directInputPem",
                    "initialArchiveAllowedNetworks",
                    "initialDirectInputAllowedNetworks",
                    "initialQueryAllowedNetworks",
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing LogsCluster resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static LogsCluster Get(string name, Input<string> id, LogsClusterState? state = null, CustomResourceOptions? options = null)
        {
            return new LogsCluster(name, id, state, options);
        }
    }

    public sealed class LogsClusterArgs : global::Pulumi.ResourceArgs
    {
        [Input("archiveAllowedNetworks")]
        private InputList<string>? _archiveAllowedNetworks;

        /// <summary>
        /// List of IP blocks
        /// </summary>
        public InputList<string> ArchiveAllowedNetworks
        {
            get => _archiveAllowedNetworks ?? (_archiveAllowedNetworks = new InputList<string>());
            set => _archiveAllowedNetworks = value;
        }

        [Input("directInputAllowedNetworks")]
        private InputList<string>? _directInputAllowedNetworks;

        /// <summary>
        /// List of IP blocks
        /// </summary>
        public InputList<string> DirectInputAllowedNetworks
        {
            get => _directInputAllowedNetworks ?? (_directInputAllowedNetworks = new InputList<string>());
            set => _directInputAllowedNetworks = value;
        }

        [Input("queryAllowedNetworks")]
        private InputList<string>? _queryAllowedNetworks;

        /// <summary>
        /// List of IP blocks
        /// </summary>
        public InputList<string> QueryAllowedNetworks
        {
            get => _queryAllowedNetworks ?? (_queryAllowedNetworks = new InputList<string>());
            set => _queryAllowedNetworks = value;
        }

        [Input("serviceName", required: true)]
        public Input<string> ServiceName { get; set; } = null!;

        public LogsClusterArgs()
        {
        }
        public static new LogsClusterArgs Empty => new LogsClusterArgs();
    }

    public sealed class LogsClusterState : global::Pulumi.ResourceArgs
    {
        [Input("archiveAllowedNetworks")]
        private InputList<string>? _archiveAllowedNetworks;

        /// <summary>
        /// List of IP blocks
        /// </summary>
        public InputList<string> ArchiveAllowedNetworks
        {
            get => _archiveAllowedNetworks ?? (_archiveAllowedNetworks = new InputList<string>());
            set => _archiveAllowedNetworks = value;
        }

        /// <summary>
        /// type of cluster (DEDICATED, PRO or TRIAL)
        /// </summary>
        [Input("clusterType")]
        public Input<string>? ClusterType { get; set; }

        [Input("dedicatedInputPem")]
        private Input<string>? _dedicatedInputPem;

        /// <summary>
        /// PEM for dedicated inputs
        /// </summary>
        public Input<string>? DedicatedInputPem
        {
            get => _dedicatedInputPem;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _dedicatedInputPem = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        [Input("directInputAllowedNetworks")]
        private InputList<string>? _directInputAllowedNetworks;

        /// <summary>
        /// List of IP blocks
        /// </summary>
        public InputList<string> DirectInputAllowedNetworks
        {
            get => _directInputAllowedNetworks ?? (_directInputAllowedNetworks = new InputList<string>());
            set => _directInputAllowedNetworks = value;
        }

        [Input("directInputPem")]
        private Input<string>? _directInputPem;

        /// <summary>
        /// PEM for direct inputs
        /// </summary>
        public Input<string>? DirectInputPem
        {
            get => _directInputPem;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _directInputPem = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        /// <summary>
        /// cluster hostname hosting tenant
        /// </summary>
        [Input("hostname")]
        public Input<string>? Hostname { get; set; }

        [Input("initialArchiveAllowedNetworks")]
        private InputList<string>? _initialArchiveAllowedNetworks;

        /// <summary>
        /// Initial allowed networks for ARCHIVE flow type
        /// </summary>
        public InputList<string> InitialArchiveAllowedNetworks
        {
            get => _initialArchiveAllowedNetworks ?? (_initialArchiveAllowedNetworks = new InputList<string>());
            set
            {
                var emptySecret = Output.CreateSecret(ImmutableArray.Create<string>());
                _initialArchiveAllowedNetworks = Output.All(value, emptySecret).Apply(v => v[0]);
            }
        }

        [Input("initialDirectInputAllowedNetworks")]
        private InputList<string>? _initialDirectInputAllowedNetworks;

        /// <summary>
        /// Initial allowed networks for DIRECT_INPUT flow type
        /// </summary>
        public InputList<string> InitialDirectInputAllowedNetworks
        {
            get => _initialDirectInputAllowedNetworks ?? (_initialDirectInputAllowedNetworks = new InputList<string>());
            set
            {
                var emptySecret = Output.CreateSecret(ImmutableArray.Create<string>());
                _initialDirectInputAllowedNetworks = Output.All(value, emptySecret).Apply(v => v[0]);
            }
        }

        [Input("initialQueryAllowedNetworks")]
        private InputList<string>? _initialQueryAllowedNetworks;

        /// <summary>
        /// Initial allowed networks for QUERY flow type
        /// </summary>
        public InputList<string> InitialQueryAllowedNetworks
        {
            get => _initialQueryAllowedNetworks ?? (_initialQueryAllowedNetworks = new InputList<string>());
            set
            {
                var emptySecret = Output.CreateSecret(ImmutableArray.Create<string>());
                _initialQueryAllowedNetworks = Output.All(value, emptySecret).Apply(v => v[0]);
            }
        }

        /// <summary>
        /// true if all content generated by given service will be placed on this cluster
        /// </summary>
        [Input("isDefault")]
        public Input<bool>? IsDefault { get; set; }

        /// <summary>
        /// true if given service can perform advanced operations on cluster
        /// </summary>
        [Input("isUnlocked")]
        public Input<bool>? IsUnlocked { get; set; }

        [Input("queryAllowedNetworks")]
        private InputList<string>? _queryAllowedNetworks;

        /// <summary>
        /// List of IP blocks
        /// </summary>
        public InputList<string> QueryAllowedNetworks
        {
            get => _queryAllowedNetworks ?? (_queryAllowedNetworks = new InputList<string>());
            set => _queryAllowedNetworks = value;
        }

        /// <summary>
        /// datacenter localization
        /// </summary>
        [Input("region")]
        public Input<string>? Region { get; set; }

        [Input("serviceName")]
        public Input<string>? ServiceName { get; set; }

        public LogsClusterState()
        {
        }
        public static new LogsClusterState Empty => new LogsClusterState();
    }
}
