// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Use this data source to retrieve information about a dedicated CEPH.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as ovh from "@pulumi/ovh";
 *
 * const my-ceph = ovh.Dedicated.getCeph({
 *     serviceName: "XXXXXX",
 * });
 * ```
 */
export function getCeph(args: GetCephArgs, opts?: pulumi.InvokeOptions): Promise<GetCephResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("ovh:Dedicated/getCeph:getCeph", {
        "cephVersion": args.cephVersion,
        "serviceName": args.serviceName,
        "status": args.status,
    }, opts);
}

/**
 * A collection of arguments for invoking getCeph.
 */
export interface GetCephArgs {
    /**
     * CEPH cluster version
     */
    cephVersion?: string;
    /**
     * The service name of the dedicated CEPH cluster.
     */
    serviceName: string;
    /**
     * the status of the service
     */
    status?: string;
}

/**
 * A collection of values returned by getCeph.
 */
export interface GetCephResult {
    /**
     * URN of the CEPH instance
     */
    readonly CephURN: string;
    /**
     * list of CEPH monitors IPs
     */
    readonly cephMons: string[];
    /**
     * CEPH cluster version
     */
    readonly cephVersion: string;
    /**
     * CRUSH algorithm settings. Possible values
     * * OPTIMAL
     * * DEFAULT
     * * LEGACY
     * * BOBTAIL
     * * ARGONAUT
     * * FIREFLY
     * * HAMMER
     * * JEWEL
     */
    readonly crushTunables: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * CEPH cluster label
     */
    readonly label: string;
    /**
     * cluster region
     */
    readonly region: string;
    readonly serviceName: string;
    /**
     * Cluster size in TB
     */
    readonly size: number;
    /**
     * the state of the cluster
     */
    readonly state: string;
    /**
     * the status of the service
     */
    readonly status: string;
}
/**
 * Use this data source to retrieve information about a dedicated CEPH.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as ovh from "@pulumi/ovh";
 *
 * const my-ceph = ovh.Dedicated.getCeph({
 *     serviceName: "XXXXXX",
 * });
 * ```
 */
export function getCephOutput(args: GetCephOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetCephResult> {
    return pulumi.output(args).apply((a: any) => getCeph(a, opts))
}

/**
 * A collection of arguments for invoking getCeph.
 */
export interface GetCephOutputArgs {
    /**
     * CEPH cluster version
     */
    cephVersion?: pulumi.Input<string>;
    /**
     * The service name of the dedicated CEPH cluster.
     */
    serviceName: pulumi.Input<string>;
    /**
     * the status of the service
     */
    status?: pulumi.Input<string>;
}
