// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package me

import (
	"context"
	"reflect"

	"github.com/ovh/pulumi-ovh/sdk/go/ovh/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumix"
)

// Creates an identity group.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
//
//	"github.com/ovh/pulumi-ovh/sdk/go/ovh/Me"
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Me.NewIdentityGroup(ctx, "myGroup", &Me.IdentityGroupArgs{
//				Description: pulumi.String("Some custom description"),
//				Role:        pulumi.String("NONE"),
//			})
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
type IdentityGroup struct {
	pulumi.CustomResourceState

	// URN of the user group, used when writing IAM policies
	GroupURN pulumi.StringOutput `pulumi:"GroupURN"`
	// Creation date of this group.
	Creation pulumi.StringOutput `pulumi:"creation"`
	// Is the group a default and immutable one.
	DefaultGroup pulumi.BoolOutput `pulumi:"defaultGroup"`
	// Group description.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// Date of the last update of this group.
	LastUpdate pulumi.StringOutput `pulumi:"lastUpdate"`
	// Group name.
	Name pulumi.StringOutput `pulumi:"name"`
	// Role associated with the group. Valid roles are ADMIN, REGULAR, UNPRIVILEGED, and NONE.
	Role pulumi.StringPtrOutput `pulumi:"role"`
}

// NewIdentityGroup registers a new resource with the given unique name, arguments, and options.
func NewIdentityGroup(ctx *pulumi.Context,
	name string, args *IdentityGroupArgs, opts ...pulumi.ResourceOption) (*IdentityGroup, error) {
	if args == nil {
		args = &IdentityGroupArgs{}
	}

	opts = internal.PkgResourceDefaultOpts(opts)
	var resource IdentityGroup
	err := ctx.RegisterResource("ovh:Me/identityGroup:IdentityGroup", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetIdentityGroup gets an existing IdentityGroup resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetIdentityGroup(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *IdentityGroupState, opts ...pulumi.ResourceOption) (*IdentityGroup, error) {
	var resource IdentityGroup
	err := ctx.ReadResource("ovh:Me/identityGroup:IdentityGroup", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering IdentityGroup resources.
type identityGroupState struct {
	// URN of the user group, used when writing IAM policies
	GroupURN *string `pulumi:"GroupURN"`
	// Creation date of this group.
	Creation *string `pulumi:"creation"`
	// Is the group a default and immutable one.
	DefaultGroup *bool `pulumi:"defaultGroup"`
	// Group description.
	Description *string `pulumi:"description"`
	// Date of the last update of this group.
	LastUpdate *string `pulumi:"lastUpdate"`
	// Group name.
	Name *string `pulumi:"name"`
	// Role associated with the group. Valid roles are ADMIN, REGULAR, UNPRIVILEGED, and NONE.
	Role *string `pulumi:"role"`
}

type IdentityGroupState struct {
	// URN of the user group, used when writing IAM policies
	GroupURN pulumi.StringPtrInput
	// Creation date of this group.
	Creation pulumi.StringPtrInput
	// Is the group a default and immutable one.
	DefaultGroup pulumi.BoolPtrInput
	// Group description.
	Description pulumi.StringPtrInput
	// Date of the last update of this group.
	LastUpdate pulumi.StringPtrInput
	// Group name.
	Name pulumi.StringPtrInput
	// Role associated with the group. Valid roles are ADMIN, REGULAR, UNPRIVILEGED, and NONE.
	Role pulumi.StringPtrInput
}

func (IdentityGroupState) ElementType() reflect.Type {
	return reflect.TypeOf((*identityGroupState)(nil)).Elem()
}

type identityGroupArgs struct {
	// Group description.
	Description *string `pulumi:"description"`
	// Group name.
	Name *string `pulumi:"name"`
	// Role associated with the group. Valid roles are ADMIN, REGULAR, UNPRIVILEGED, and NONE.
	Role *string `pulumi:"role"`
}

// The set of arguments for constructing a IdentityGroup resource.
type IdentityGroupArgs struct {
	// Group description.
	Description pulumi.StringPtrInput
	// Group name.
	Name pulumi.StringPtrInput
	// Role associated with the group. Valid roles are ADMIN, REGULAR, UNPRIVILEGED, and NONE.
	Role pulumi.StringPtrInput
}

func (IdentityGroupArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*identityGroupArgs)(nil)).Elem()
}

type IdentityGroupInput interface {
	pulumi.Input

	ToIdentityGroupOutput() IdentityGroupOutput
	ToIdentityGroupOutputWithContext(ctx context.Context) IdentityGroupOutput
}

func (*IdentityGroup) ElementType() reflect.Type {
	return reflect.TypeOf((**IdentityGroup)(nil)).Elem()
}

func (i *IdentityGroup) ToIdentityGroupOutput() IdentityGroupOutput {
	return i.ToIdentityGroupOutputWithContext(context.Background())
}

func (i *IdentityGroup) ToIdentityGroupOutputWithContext(ctx context.Context) IdentityGroupOutput {
	return pulumi.ToOutputWithContext(ctx, i).(IdentityGroupOutput)
}

func (i *IdentityGroup) ToOutput(ctx context.Context) pulumix.Output[*IdentityGroup] {
	return pulumix.Output[*IdentityGroup]{
		OutputState: i.ToIdentityGroupOutputWithContext(ctx).OutputState,
	}
}

// IdentityGroupArrayInput is an input type that accepts IdentityGroupArray and IdentityGroupArrayOutput values.
// You can construct a concrete instance of `IdentityGroupArrayInput` via:
//
//	IdentityGroupArray{ IdentityGroupArgs{...} }
type IdentityGroupArrayInput interface {
	pulumi.Input

	ToIdentityGroupArrayOutput() IdentityGroupArrayOutput
	ToIdentityGroupArrayOutputWithContext(context.Context) IdentityGroupArrayOutput
}

type IdentityGroupArray []IdentityGroupInput

func (IdentityGroupArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*IdentityGroup)(nil)).Elem()
}

func (i IdentityGroupArray) ToIdentityGroupArrayOutput() IdentityGroupArrayOutput {
	return i.ToIdentityGroupArrayOutputWithContext(context.Background())
}

func (i IdentityGroupArray) ToIdentityGroupArrayOutputWithContext(ctx context.Context) IdentityGroupArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(IdentityGroupArrayOutput)
}

func (i IdentityGroupArray) ToOutput(ctx context.Context) pulumix.Output[[]*IdentityGroup] {
	return pulumix.Output[[]*IdentityGroup]{
		OutputState: i.ToIdentityGroupArrayOutputWithContext(ctx).OutputState,
	}
}

// IdentityGroupMapInput is an input type that accepts IdentityGroupMap and IdentityGroupMapOutput values.
// You can construct a concrete instance of `IdentityGroupMapInput` via:
//
//	IdentityGroupMap{ "key": IdentityGroupArgs{...} }
type IdentityGroupMapInput interface {
	pulumi.Input

	ToIdentityGroupMapOutput() IdentityGroupMapOutput
	ToIdentityGroupMapOutputWithContext(context.Context) IdentityGroupMapOutput
}

type IdentityGroupMap map[string]IdentityGroupInput

func (IdentityGroupMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*IdentityGroup)(nil)).Elem()
}

func (i IdentityGroupMap) ToIdentityGroupMapOutput() IdentityGroupMapOutput {
	return i.ToIdentityGroupMapOutputWithContext(context.Background())
}

func (i IdentityGroupMap) ToIdentityGroupMapOutputWithContext(ctx context.Context) IdentityGroupMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(IdentityGroupMapOutput)
}

func (i IdentityGroupMap) ToOutput(ctx context.Context) pulumix.Output[map[string]*IdentityGroup] {
	return pulumix.Output[map[string]*IdentityGroup]{
		OutputState: i.ToIdentityGroupMapOutputWithContext(ctx).OutputState,
	}
}

type IdentityGroupOutput struct{ *pulumi.OutputState }

func (IdentityGroupOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**IdentityGroup)(nil)).Elem()
}

func (o IdentityGroupOutput) ToIdentityGroupOutput() IdentityGroupOutput {
	return o
}

func (o IdentityGroupOutput) ToIdentityGroupOutputWithContext(ctx context.Context) IdentityGroupOutput {
	return o
}

func (o IdentityGroupOutput) ToOutput(ctx context.Context) pulumix.Output[*IdentityGroup] {
	return pulumix.Output[*IdentityGroup]{
		OutputState: o.OutputState,
	}
}

// URN of the user group, used when writing IAM policies
func (o IdentityGroupOutput) GroupURN() pulumi.StringOutput {
	return o.ApplyT(func(v *IdentityGroup) pulumi.StringOutput { return v.GroupURN }).(pulumi.StringOutput)
}

// Creation date of this group.
func (o IdentityGroupOutput) Creation() pulumi.StringOutput {
	return o.ApplyT(func(v *IdentityGroup) pulumi.StringOutput { return v.Creation }).(pulumi.StringOutput)
}

// Is the group a default and immutable one.
func (o IdentityGroupOutput) DefaultGroup() pulumi.BoolOutput {
	return o.ApplyT(func(v *IdentityGroup) pulumi.BoolOutput { return v.DefaultGroup }).(pulumi.BoolOutput)
}

// Group description.
func (o IdentityGroupOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *IdentityGroup) pulumi.StringPtrOutput { return v.Description }).(pulumi.StringPtrOutput)
}

// Date of the last update of this group.
func (o IdentityGroupOutput) LastUpdate() pulumi.StringOutput {
	return o.ApplyT(func(v *IdentityGroup) pulumi.StringOutput { return v.LastUpdate }).(pulumi.StringOutput)
}

// Group name.
func (o IdentityGroupOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *IdentityGroup) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// Role associated with the group. Valid roles are ADMIN, REGULAR, UNPRIVILEGED, and NONE.
func (o IdentityGroupOutput) Role() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *IdentityGroup) pulumi.StringPtrOutput { return v.Role }).(pulumi.StringPtrOutput)
}

type IdentityGroupArrayOutput struct{ *pulumi.OutputState }

func (IdentityGroupArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*IdentityGroup)(nil)).Elem()
}

func (o IdentityGroupArrayOutput) ToIdentityGroupArrayOutput() IdentityGroupArrayOutput {
	return o
}

func (o IdentityGroupArrayOutput) ToIdentityGroupArrayOutputWithContext(ctx context.Context) IdentityGroupArrayOutput {
	return o
}

func (o IdentityGroupArrayOutput) ToOutput(ctx context.Context) pulumix.Output[[]*IdentityGroup] {
	return pulumix.Output[[]*IdentityGroup]{
		OutputState: o.OutputState,
	}
}

func (o IdentityGroupArrayOutput) Index(i pulumi.IntInput) IdentityGroupOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *IdentityGroup {
		return vs[0].([]*IdentityGroup)[vs[1].(int)]
	}).(IdentityGroupOutput)
}

type IdentityGroupMapOutput struct{ *pulumi.OutputState }

func (IdentityGroupMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*IdentityGroup)(nil)).Elem()
}

func (o IdentityGroupMapOutput) ToIdentityGroupMapOutput() IdentityGroupMapOutput {
	return o
}

func (o IdentityGroupMapOutput) ToIdentityGroupMapOutputWithContext(ctx context.Context) IdentityGroupMapOutput {
	return o
}

func (o IdentityGroupMapOutput) ToOutput(ctx context.Context) pulumix.Output[map[string]*IdentityGroup] {
	return pulumix.Output[map[string]*IdentityGroup]{
		OutputState: o.OutputState,
	}
}

func (o IdentityGroupMapOutput) MapIndex(k pulumi.StringInput) IdentityGroupOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *IdentityGroup {
		return vs[0].(map[string]*IdentityGroup)[vs[1].(string)]
	}).(IdentityGroupOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*IdentityGroupInput)(nil)).Elem(), &IdentityGroup{})
	pulumi.RegisterInputType(reflect.TypeOf((*IdentityGroupArrayInput)(nil)).Elem(), IdentityGroupArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*IdentityGroupMapInput)(nil)).Elem(), IdentityGroupMap{})
	pulumi.RegisterOutputType(IdentityGroupOutput{})
	pulumi.RegisterOutputType(IdentityGroupArrayOutput{})
	pulumi.RegisterOutputType(IdentityGroupMapOutput{})
}
