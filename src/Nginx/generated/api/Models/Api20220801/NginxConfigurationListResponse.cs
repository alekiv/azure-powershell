// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20220801
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.Extensions;

    /// <summary>Response of a list operation.</summary>
    public partial class NginxConfigurationListResponse :
        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20220801.INginxConfigurationListResponse,
        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20220801.INginxConfigurationListResponseInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>Link to the next set of results, if any.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Origin(Microsoft.Azure.PowerShell.Cmdlets.Nginx.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20220801.INginxConfiguration[] _value;

        /// <summary>Results of a list operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Origin(Microsoft.Azure.PowerShell.Cmdlets.Nginx.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20220801.INginxConfiguration[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="NginxConfigurationListResponse" /> instance.</summary>
        public NginxConfigurationListResponse()
        {

        }
    }
    /// Response of a list operation.
    public partial interface INginxConfigurationListResponse :
        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.IJsonSerializable
    {
        /// <summary>Link to the next set of results, if any.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Link to the next set of results, if any.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>Results of a list operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Results of a list operation.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20220801.INginxConfiguration) })]
        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20220801.INginxConfiguration[] Value { get; set; }

    }
    /// Response of a list operation.
    internal partial interface INginxConfigurationListResponseInternal

    {
        /// <summary>Link to the next set of results, if any.</summary>
        string NextLink { get; set; }
        /// <summary>Results of a list operation.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20220801.INginxConfiguration[] Value { get; set; }

    }
}