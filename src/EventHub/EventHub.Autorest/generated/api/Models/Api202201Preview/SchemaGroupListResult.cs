// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Extensions;

    /// <summary>The result of the List SchemaGroup operation.</summary>
    [Microsoft.Azure.PowerShell.Cmdlets.EventHub.DoNotFormat]
    public partial class SchemaGroupListResult :
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroupListResult,
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroupListResultInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>
        /// Link to the next set of results. Not empty if Value contains incomplete list of Schema Groups.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroup[] _value;

        /// <summary>Result of the List SchemaGroups operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroup[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="SchemaGroupListResult" /> instance.</summary>
        public SchemaGroupListResult()
        {

        }
    }
    /// The result of the List SchemaGroup operation.
    public partial interface ISchemaGroupListResult :
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Link to the next set of results. Not empty if Value contains incomplete list of Schema Groups.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Link to the next set of results. Not empty if Value contains incomplete list of Schema Groups.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>Result of the List SchemaGroups operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Result of the List SchemaGroups operation.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroup) })]
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroup[] Value { get; set; }

    }
    /// The result of the List SchemaGroup operation.
    internal partial interface ISchemaGroupListResultInternal

    {
        /// <summary>
        /// Link to the next set of results. Not empty if Value contains incomplete list of Schema Groups.
        /// </summary>
        string NextLink { get; set; }
        /// <summary>Result of the List SchemaGroups operation.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroup[] Value { get; set; }

    }
}