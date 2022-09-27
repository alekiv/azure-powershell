// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Extensions;

    public partial class EventHubIdentity
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
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonObject into a new instance of <see cref="EventHubIdentity" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal EventHubIdentity(Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_subscriptionId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonString>("subscriptionId"), out var __jsonSubscriptionId) ? (string)__jsonSubscriptionId : (string)SubscriptionId;}
            {_resourceGroupName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonString>("resourceGroupName"), out var __jsonResourceGroupName) ? (string)__jsonResourceGroupName : (string)ResourceGroupName;}
            {_clusterName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonString>("clusterName"), out var __jsonClusterName) ? (string)__jsonClusterName : (string)ClusterName;}
            {_namespaceName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonString>("namespaceName"), out var __jsonNamespaceName) ? (string)__jsonNamespaceName : (string)NamespaceName;}
            {_authorizationRuleName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonString>("authorizationRuleName"), out var __jsonAuthorizationRuleName) ? (string)__jsonAuthorizationRuleName : (string)AuthorizationRuleName;}
            {_privateEndpointConnectionName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonString>("privateEndpointConnectionName"), out var __jsonPrivateEndpointConnectionName) ? (string)__jsonPrivateEndpointConnectionName : (string)PrivateEndpointConnectionName;}
            {_resourceAssociationName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonString>("resourceAssociationName"), out var __jsonResourceAssociationName) ? (string)__jsonResourceAssociationName : (string)ResourceAssociationName;}
            {_alias = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonString>("alias"), out var __jsonAlias) ? (string)__jsonAlias : (string)Alias;}
            {_eventHubName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonString>("eventHubName"), out var __jsonEventHubName) ? (string)__jsonEventHubName : (string)EventHubName;}
            {_consumerGroupName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonString>("consumerGroupName"), out var __jsonConsumerGroupName) ? (string)__jsonConsumerGroupName : (string)ConsumerGroupName;}
            {_schemaGroupName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonString>("schemaGroupName"), out var __jsonSchemaGroupName) ? (string)__jsonSchemaGroupName : (string)SchemaGroupName;}
            {_applicationGroupName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonString>("applicationGroupName"), out var __jsonApplicationGroupName) ? (string)__jsonApplicationGroupName : (string)ApplicationGroupName;}
            {_id = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonString>("id"), out var __jsonId) ? (string)__jsonId : (string)Id;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.IEventHubIdentity.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.IEventHubIdentity.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.IEventHubIdentity FromJson(Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonObject json ? new EventHubIdentity(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="EventHubIdentity" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="EventHubIdentity" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonNode" />.
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
            AddIf( null != (((object)this._subscriptionId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonString(this._subscriptionId.ToString()) : null, "subscriptionId" ,container.Add );
            AddIf( null != (((object)this._resourceGroupName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonString(this._resourceGroupName.ToString()) : null, "resourceGroupName" ,container.Add );
            AddIf( null != (((object)this._clusterName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonString(this._clusterName.ToString()) : null, "clusterName" ,container.Add );
            AddIf( null != (((object)this._namespaceName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonString(this._namespaceName.ToString()) : null, "namespaceName" ,container.Add );
            AddIf( null != (((object)this._authorizationRuleName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonString(this._authorizationRuleName.ToString()) : null, "authorizationRuleName" ,container.Add );
            AddIf( null != (((object)this._privateEndpointConnectionName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonString(this._privateEndpointConnectionName.ToString()) : null, "privateEndpointConnectionName" ,container.Add );
            AddIf( null != (((object)this._resourceAssociationName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonString(this._resourceAssociationName.ToString()) : null, "resourceAssociationName" ,container.Add );
            AddIf( null != (((object)this._alias)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonString(this._alias.ToString()) : null, "alias" ,container.Add );
            AddIf( null != (((object)this._eventHubName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonString(this._eventHubName.ToString()) : null, "eventHubName" ,container.Add );
            AddIf( null != (((object)this._consumerGroupName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonString(this._consumerGroupName.ToString()) : null, "consumerGroupName" ,container.Add );
            AddIf( null != (((object)this._schemaGroupName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonString(this._schemaGroupName.ToString()) : null, "schemaGroupName" ,container.Add );
            AddIf( null != (((object)this._applicationGroupName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonString(this._applicationGroupName.ToString()) : null, "applicationGroupName" ,container.Add );
            AddIf( null != (((object)this._id)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonString(this._id.ToString()) : null, "id" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}