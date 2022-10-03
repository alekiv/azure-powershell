// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api202201Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Extensions;

    /// <summary>The response of the List rule operation.</summary>
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.DoNotFormat]
    public partial class RuleListResult :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api202201Preview.IRuleListResult,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api202201Preview.IRuleListResultInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>
        /// Link to the next set of results. Not empty if Value contains incomplete list of rules
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api202201Preview.IRule[] _value;

        /// <summary>Result of the List Rules operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api202201Preview.IRule[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="RuleListResult" /> instance.</summary>
        public RuleListResult()
        {

        }
    }
    /// The response of the List rule operation.
    public partial interface IRuleListResult :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Link to the next set of results. Not empty if Value contains incomplete list of rules
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Link to the next set of results. Not empty if Value contains incomplete list of rules",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>Result of the List Rules operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Result of the List Rules operation.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api202201Preview.IRule) })]
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api202201Preview.IRule[] Value { get; set; }

    }
    /// The response of the List rule operation.
    internal partial interface IRuleListResultInternal

    {
        /// <summary>
        /// Link to the next set of results. Not empty if Value contains incomplete list of rules
        /// </summary>
        string NextLink { get; set; }
        /// <summary>Result of the List Rules operation.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api202201Preview.IRule[] Value { get; set; }

    }
}