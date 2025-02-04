# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['InstallationTemplatePartitionSchemeHardwareRaidArgs', 'InstallationTemplatePartitionSchemeHardwareRaid']

@pulumi.input_type
class InstallationTemplatePartitionSchemeHardwareRaidArgs:
    def __init__(__self__, *,
                 disks: pulumi.Input[Sequence[pulumi.Input[str]]],
                 mode: pulumi.Input[str],
                 scheme_name: pulumi.Input[str],
                 step: pulumi.Input[int],
                 template_name: pulumi.Input[str],
                 name: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a InstallationTemplatePartitionSchemeHardwareRaid resource.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] disks: Disk List. Syntax is cX:dY for disks and [cX:dY,cX:dY] for groups. With X and Y resp. the controller id and the disk id.
        :param pulumi.Input[str] mode: RAID mode (raid0, raid1, raid10, raid5, raid50, raid6, raid60).
        :param pulumi.Input[str] scheme_name: The partition scheme name.
        :param pulumi.Input[int] step: Specifies the creation order of the hardware RAID.
        :param pulumi.Input[str] template_name: The template name of the partition scheme.
        :param pulumi.Input[str] name: Hardware RAID name.
        """
        pulumi.set(__self__, "disks", disks)
        pulumi.set(__self__, "mode", mode)
        pulumi.set(__self__, "scheme_name", scheme_name)
        pulumi.set(__self__, "step", step)
        pulumi.set(__self__, "template_name", template_name)
        if name is not None:
            pulumi.set(__self__, "name", name)

    @property
    @pulumi.getter
    def disks(self) -> pulumi.Input[Sequence[pulumi.Input[str]]]:
        """
        Disk List. Syntax is cX:dY for disks and [cX:dY,cX:dY] for groups. With X and Y resp. the controller id and the disk id.
        """
        return pulumi.get(self, "disks")

    @disks.setter
    def disks(self, value: pulumi.Input[Sequence[pulumi.Input[str]]]):
        pulumi.set(self, "disks", value)

    @property
    @pulumi.getter
    def mode(self) -> pulumi.Input[str]:
        """
        RAID mode (raid0, raid1, raid10, raid5, raid50, raid6, raid60).
        """
        return pulumi.get(self, "mode")

    @mode.setter
    def mode(self, value: pulumi.Input[str]):
        pulumi.set(self, "mode", value)

    @property
    @pulumi.getter(name="schemeName")
    def scheme_name(self) -> pulumi.Input[str]:
        """
        The partition scheme name.
        """
        return pulumi.get(self, "scheme_name")

    @scheme_name.setter
    def scheme_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "scheme_name", value)

    @property
    @pulumi.getter
    def step(self) -> pulumi.Input[int]:
        """
        Specifies the creation order of the hardware RAID.
        """
        return pulumi.get(self, "step")

    @step.setter
    def step(self, value: pulumi.Input[int]):
        pulumi.set(self, "step", value)

    @property
    @pulumi.getter(name="templateName")
    def template_name(self) -> pulumi.Input[str]:
        """
        The template name of the partition scheme.
        """
        return pulumi.get(self, "template_name")

    @template_name.setter
    def template_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "template_name", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Hardware RAID name.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)


@pulumi.input_type
class _InstallationTemplatePartitionSchemeHardwareRaidState:
    def __init__(__self__, *,
                 disks: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 mode: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 scheme_name: Optional[pulumi.Input[str]] = None,
                 step: Optional[pulumi.Input[int]] = None,
                 template_name: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering InstallationTemplatePartitionSchemeHardwareRaid resources.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] disks: Disk List. Syntax is cX:dY for disks and [cX:dY,cX:dY] for groups. With X and Y resp. the controller id and the disk id.
        :param pulumi.Input[str] mode: RAID mode (raid0, raid1, raid10, raid5, raid50, raid6, raid60).
        :param pulumi.Input[str] name: Hardware RAID name.
        :param pulumi.Input[str] scheme_name: The partition scheme name.
        :param pulumi.Input[int] step: Specifies the creation order of the hardware RAID.
        :param pulumi.Input[str] template_name: The template name of the partition scheme.
        """
        if disks is not None:
            pulumi.set(__self__, "disks", disks)
        if mode is not None:
            pulumi.set(__self__, "mode", mode)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if scheme_name is not None:
            pulumi.set(__self__, "scheme_name", scheme_name)
        if step is not None:
            pulumi.set(__self__, "step", step)
        if template_name is not None:
            pulumi.set(__self__, "template_name", template_name)

    @property
    @pulumi.getter
    def disks(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        Disk List. Syntax is cX:dY for disks and [cX:dY,cX:dY] for groups. With X and Y resp. the controller id and the disk id.
        """
        return pulumi.get(self, "disks")

    @disks.setter
    def disks(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "disks", value)

    @property
    @pulumi.getter
    def mode(self) -> Optional[pulumi.Input[str]]:
        """
        RAID mode (raid0, raid1, raid10, raid5, raid50, raid6, raid60).
        """
        return pulumi.get(self, "mode")

    @mode.setter
    def mode(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "mode", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Hardware RAID name.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="schemeName")
    def scheme_name(self) -> Optional[pulumi.Input[str]]:
        """
        The partition scheme name.
        """
        return pulumi.get(self, "scheme_name")

    @scheme_name.setter
    def scheme_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "scheme_name", value)

    @property
    @pulumi.getter
    def step(self) -> Optional[pulumi.Input[int]]:
        """
        Specifies the creation order of the hardware RAID.
        """
        return pulumi.get(self, "step")

    @step.setter
    def step(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "step", value)

    @property
    @pulumi.getter(name="templateName")
    def template_name(self) -> Optional[pulumi.Input[str]]:
        """
        The template name of the partition scheme.
        """
        return pulumi.get(self, "template_name")

    @template_name.setter
    def template_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "template_name", value)


class InstallationTemplatePartitionSchemeHardwareRaid(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 disks: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 mode: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 scheme_name: Optional[pulumi.Input[str]] = None,
                 step: Optional[pulumi.Input[int]] = None,
                 template_name: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Use this resource to create a hardware raid group in the partition scheme of a custom installation template available for dedicated servers.

        ## Example Usage

        ```python
        import pulumi
        import pulumi_ovh as ovh

        mytemplate = ovh.me.InstallationTemplate("mytemplate",
            base_template_name="centos7_64",
            template_name="mytemplate",
            default_language="fr")
        scheme = ovh.me.InstallationTemplatePartitionScheme("scheme",
            template_name=mytemplate.template_name,
            priority=1)
        group1 = ovh.me.InstallationTemplatePartitionSchemeHardwareRaid("group1",
            template_name=scheme.template_name,
            scheme_name=scheme.name,
            disks=[
                "[c1:d1,c1:d2,c1:d3]",
                "[c1:d10,c1:d20,c1:d30]",
            ],
            mode="raid50",
            step=1)
        ```

        ## Import

        The resource can be imported using the `template_name`, `scheme_name`, `name` of the cluster, separated by "/" E.g.,

         bash

        ```sh
        $ pulumi import ovh:Me/installationTemplatePartitionSchemeHardwareRaid:InstallationTemplatePartitionSchemeHardwareRaid group1 template_name/scheme_name/name
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] disks: Disk List. Syntax is cX:dY for disks and [cX:dY,cX:dY] for groups. With X and Y resp. the controller id and the disk id.
        :param pulumi.Input[str] mode: RAID mode (raid0, raid1, raid10, raid5, raid50, raid6, raid60).
        :param pulumi.Input[str] name: Hardware RAID name.
        :param pulumi.Input[str] scheme_name: The partition scheme name.
        :param pulumi.Input[int] step: Specifies the creation order of the hardware RAID.
        :param pulumi.Input[str] template_name: The template name of the partition scheme.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: InstallationTemplatePartitionSchemeHardwareRaidArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Use this resource to create a hardware raid group in the partition scheme of a custom installation template available for dedicated servers.

        ## Example Usage

        ```python
        import pulumi
        import pulumi_ovh as ovh

        mytemplate = ovh.me.InstallationTemplate("mytemplate",
            base_template_name="centos7_64",
            template_name="mytemplate",
            default_language="fr")
        scheme = ovh.me.InstallationTemplatePartitionScheme("scheme",
            template_name=mytemplate.template_name,
            priority=1)
        group1 = ovh.me.InstallationTemplatePartitionSchemeHardwareRaid("group1",
            template_name=scheme.template_name,
            scheme_name=scheme.name,
            disks=[
                "[c1:d1,c1:d2,c1:d3]",
                "[c1:d10,c1:d20,c1:d30]",
            ],
            mode="raid50",
            step=1)
        ```

        ## Import

        The resource can be imported using the `template_name`, `scheme_name`, `name` of the cluster, separated by "/" E.g.,

         bash

        ```sh
        $ pulumi import ovh:Me/installationTemplatePartitionSchemeHardwareRaid:InstallationTemplatePartitionSchemeHardwareRaid group1 template_name/scheme_name/name
        ```

        :param str resource_name: The name of the resource.
        :param InstallationTemplatePartitionSchemeHardwareRaidArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(InstallationTemplatePartitionSchemeHardwareRaidArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 disks: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 mode: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 scheme_name: Optional[pulumi.Input[str]] = None,
                 step: Optional[pulumi.Input[int]] = None,
                 template_name: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = InstallationTemplatePartitionSchemeHardwareRaidArgs.__new__(InstallationTemplatePartitionSchemeHardwareRaidArgs)

            if disks is None and not opts.urn:
                raise TypeError("Missing required property 'disks'")
            __props__.__dict__["disks"] = disks
            if mode is None and not opts.urn:
                raise TypeError("Missing required property 'mode'")
            __props__.__dict__["mode"] = mode
            __props__.__dict__["name"] = name
            if scheme_name is None and not opts.urn:
                raise TypeError("Missing required property 'scheme_name'")
            __props__.__dict__["scheme_name"] = scheme_name
            if step is None and not opts.urn:
                raise TypeError("Missing required property 'step'")
            __props__.__dict__["step"] = step
            if template_name is None and not opts.urn:
                raise TypeError("Missing required property 'template_name'")
            __props__.__dict__["template_name"] = template_name
        super(InstallationTemplatePartitionSchemeHardwareRaid, __self__).__init__(
            'ovh:Me/installationTemplatePartitionSchemeHardwareRaid:InstallationTemplatePartitionSchemeHardwareRaid',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            disks: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
            mode: Optional[pulumi.Input[str]] = None,
            name: Optional[pulumi.Input[str]] = None,
            scheme_name: Optional[pulumi.Input[str]] = None,
            step: Optional[pulumi.Input[int]] = None,
            template_name: Optional[pulumi.Input[str]] = None) -> 'InstallationTemplatePartitionSchemeHardwareRaid':
        """
        Get an existing InstallationTemplatePartitionSchemeHardwareRaid resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] disks: Disk List. Syntax is cX:dY for disks and [cX:dY,cX:dY] for groups. With X and Y resp. the controller id and the disk id.
        :param pulumi.Input[str] mode: RAID mode (raid0, raid1, raid10, raid5, raid50, raid6, raid60).
        :param pulumi.Input[str] name: Hardware RAID name.
        :param pulumi.Input[str] scheme_name: The partition scheme name.
        :param pulumi.Input[int] step: Specifies the creation order of the hardware RAID.
        :param pulumi.Input[str] template_name: The template name of the partition scheme.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _InstallationTemplatePartitionSchemeHardwareRaidState.__new__(_InstallationTemplatePartitionSchemeHardwareRaidState)

        __props__.__dict__["disks"] = disks
        __props__.__dict__["mode"] = mode
        __props__.__dict__["name"] = name
        __props__.__dict__["scheme_name"] = scheme_name
        __props__.__dict__["step"] = step
        __props__.__dict__["template_name"] = template_name
        return InstallationTemplatePartitionSchemeHardwareRaid(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def disks(self) -> pulumi.Output[Sequence[str]]:
        """
        Disk List. Syntax is cX:dY for disks and [cX:dY,cX:dY] for groups. With X and Y resp. the controller id and the disk id.
        """
        return pulumi.get(self, "disks")

    @property
    @pulumi.getter
    def mode(self) -> pulumi.Output[str]:
        """
        RAID mode (raid0, raid1, raid10, raid5, raid50, raid6, raid60).
        """
        return pulumi.get(self, "mode")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Hardware RAID name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="schemeName")
    def scheme_name(self) -> pulumi.Output[str]:
        """
        The partition scheme name.
        """
        return pulumi.get(self, "scheme_name")

    @property
    @pulumi.getter
    def step(self) -> pulumi.Output[int]:
        """
        Specifies the creation order of the hardware RAID.
        """
        return pulumi.get(self, "step")

    @property
    @pulumi.getter(name="templateName")
    def template_name(self) -> pulumi.Output[str]:
        """
        The template name of the partition scheme.
        """
        return pulumi.get(self, "template_name")

