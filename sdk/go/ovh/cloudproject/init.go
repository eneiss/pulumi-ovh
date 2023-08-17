// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package cloudproject

import (
	"fmt"

	"github.com/blang/semver"
	"github.com/scraly/pulumi-ovh/sdk/go/ovh"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type module struct {
	version semver.Version
}

func (m *module) Version() semver.Version {
	return m.version
}

func (m *module) Construct(ctx *pulumi.Context, name, typ, urn string) (r pulumi.Resource, err error) {
	switch typ {
	case "ovh:CloudProject/containerRegistry:ContainerRegistry":
		r = &ContainerRegistry{}
	case "ovh:CloudProject/containerRegistryUser:ContainerRegistryUser":
		r = &ContainerRegistryUser{}
	case "ovh:CloudProject/database:Database":
		r = &Database{}
	case "ovh:CloudProject/failoverIpAttach:FailoverIpAttach":
		r = &FailoverIpAttach{}
	case "ovh:CloudProject/kube:Kube":
		r = &Kube{}
	case "ovh:CloudProject/kubeIpRestrictions:KubeIpRestrictions":
		r = &KubeIpRestrictions{}
	case "ovh:CloudProject/kubeNodePool:KubeNodePool":
		r = &KubeNodePool{}
	case "ovh:CloudProject/kubeOidc:KubeOidc":
		r = &KubeOidc{}
	case "ovh:CloudProject/networkPrivate:NetworkPrivate":
		r = &NetworkPrivate{}
	case "ovh:CloudProject/networkPrivateSubnet:NetworkPrivateSubnet":
		r = &NetworkPrivateSubnet{}
	case "ovh:CloudProject/project:Project":
		r = &Project{}
	case "ovh:CloudProject/regionStoragePresign:RegionStoragePresign":
		r = &RegionStoragePresign{}
	case "ovh:CloudProject/s3Credential:S3Credential":
		r = &S3Credential{}
	case "ovh:CloudProject/s3Policy:S3Policy":
		r = &S3Policy{}
	case "ovh:CloudProject/user:User":
		r = &User{}
	case "ovh:CloudProject/workflowBackup:WorkflowBackup":
		r = &WorkflowBackup{}
	default:
		return nil, fmt.Errorf("unknown resource type: %s", typ)
	}

	err = ctx.RegisterResource(typ, name, nil, r, pulumi.URN_(urn))
	return
}

func init() {
	version, err := ovh.PkgVersion()
	if err != nil {
		version = semver.Version{Major: 1}
	}
	pulumi.RegisterResourceModule(
		"ovh",
		"CloudProject/containerRegistry",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"ovh",
		"CloudProject/containerRegistryUser",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"ovh",
		"CloudProject/database",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"ovh",
		"CloudProject/failoverIpAttach",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"ovh",
		"CloudProject/kube",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"ovh",
		"CloudProject/kubeIpRestrictions",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"ovh",
		"CloudProject/kubeNodePool",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"ovh",
		"CloudProject/kubeOidc",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"ovh",
		"CloudProject/networkPrivate",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"ovh",
		"CloudProject/networkPrivateSubnet",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"ovh",
		"CloudProject/project",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"ovh",
		"CloudProject/regionStoragePresign",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"ovh",
		"CloudProject/s3Credential",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"ovh",
		"CloudProject/s3Policy",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"ovh",
		"CloudProject/user",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"ovh",
		"CloudProject/workflowBackup",
		&module{version},
	)
}
