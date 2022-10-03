// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Extensions;

    /// <summary>Parameter supplied to check Namespace name availability operation</summary>
    [Microsoft.Azure.PowerShell.Cmdlets.EventHub.DoNotFormat]
    public partial class CheckNameAvailabilityParameter :
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ICheckNameAvailabilityParameter,
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ICheckNameAvailabilityParameterInternal
    {

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Name to check the namespace name availability</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Creates an new <see cref="CheckNameAvailabilityParameter" /> instance.</summary>
        public CheckNameAvailabilityParameter()
        {

        }
    }
    /// Parameter supplied to check Namespace name availability operation
    public partial interface ICheckNameAvailabilityParameter :
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.IJsonSerializable
    {
        /// <summary>Name to check the namespace name availability</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Name to check the namespace name availability",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

    }
    /// Parameter supplied to check Namespace name availability operation
    internal partial interface ICheckNameAvailabilityParameterInternal

    {
        /// <summary>Name to check the namespace name availability</summary>
        string Name { get; set; }

    }
}