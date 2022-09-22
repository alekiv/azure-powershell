// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Extensions;

    /// <summary>
    /// Properties required to the Create Or Update Alias(Disaster Recovery configurations)
    /// </summary>
    public partial class ArmDisasterRecoveryProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonObject into a new instance of <see cref="ArmDisasterRecoveryProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ArmDisasterRecoveryProperties(Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_provisioningState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonString>("provisioningState"), out var __jsonProvisioningState) ? (string)__jsonProvisioningState : (string)ProvisioningState;}
            {_partnerNamespace = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonString>("partnerNamespace"), out var __jsonPartnerNamespace) ? (string)__jsonPartnerNamespace : (string)PartnerNamespace;}
            {_alternateName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonString>("alternateName"), out var __jsonAlternateName) ? (string)__jsonAlternateName : (string)AlternateName;}
            {_role = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonString>("role"), out var __jsonRole) ? (string)__jsonRole : (string)Role;}
            {_pendingReplicationOperationsCount = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonNumber>("pendingReplicationOperationsCount"), out var __jsonPendingReplicationOperationsCount) ? (long?)__jsonPendingReplicationOperationsCount : PendingReplicationOperationsCount;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IArmDisasterRecoveryProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IArmDisasterRecoveryProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IArmDisasterRecoveryProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonObject json ? new ArmDisasterRecoveryProperties(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="ArmDisasterRecoveryProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ArmDisasterRecoveryProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._provisioningState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonString(this._provisioningState.ToString()) : null, "provisioningState" ,container.Add );
            }
            AddIf( null != (((object)this._partnerNamespace)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonString(this._partnerNamespace.ToString()) : null, "partnerNamespace" ,container.Add );
            AddIf( null != (((object)this._alternateName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonString(this._alternateName.ToString()) : null, "alternateName" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._role)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonString(this._role.ToString()) : null, "role" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._pendingReplicationOperationsCount ? (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonNumber((long)this._pendingReplicationOperationsCount) : null, "pendingReplicationOperationsCount" ,container.Add );
            }
            AfterToJson(ref container);
            return container;
        }
    }
}