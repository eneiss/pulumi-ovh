// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package me

import (
	"fmt"

	"github.com/blang/semver"
	"github.com/ovh/pulumi-ovh/sdk/go/ovh/internal"
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
	case "ovh:Me/aPIOAuth2Client:APIOAuth2Client":
		r = &APIOAuth2Client{}
	case "ovh:Me/identityGroup:IdentityGroup":
		r = &IdentityGroup{}
	case "ovh:Me/identityUser:IdentityUser":
		r = &IdentityUser{}
	case "ovh:Me/installationTemplate:InstallationTemplate":
		r = &InstallationTemplate{}
	case "ovh:Me/installationTemplatePartitionScheme:InstallationTemplatePartitionScheme":
		r = &InstallationTemplatePartitionScheme{}
	case "ovh:Me/installationTemplatePartitionSchemeHardwareRaid:InstallationTemplatePartitionSchemeHardwareRaid":
		r = &InstallationTemplatePartitionSchemeHardwareRaid{}
	case "ovh:Me/installationTemplatePartitionSchemePartition:InstallationTemplatePartitionSchemePartition":
		r = &InstallationTemplatePartitionSchemePartition{}
	case "ovh:Me/ipxeScript:IpxeScript":
		r = &IpxeScript{}
	case "ovh:Me/sshKey:SshKey":
		r = &SshKey{}
	default:
		return nil, fmt.Errorf("unknown resource type: %s", typ)
	}

	err = ctx.RegisterResource(typ, name, nil, r, pulumi.URN_(urn))
	return
}

func init() {
	version, err := internal.PkgVersion()
	if err != nil {
		version = semver.Version{Major: 1}
	}
	pulumi.RegisterResourceModule(
		"ovh",
		"Me/aPIOAuth2Client",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"ovh",
		"Me/identityGroup",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"ovh",
		"Me/identityUser",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"ovh",
		"Me/installationTemplate",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"ovh",
		"Me/installationTemplatePartitionScheme",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"ovh",
		"Me/installationTemplatePartitionSchemeHardwareRaid",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"ovh",
		"Me/installationTemplatePartitionSchemePartition",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"ovh",
		"Me/ipxeScript",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"ovh",
		"Me/sshKey",
		&module{version},
	)
}
