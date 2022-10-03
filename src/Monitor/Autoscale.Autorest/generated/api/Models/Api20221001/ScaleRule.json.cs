// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Models.Api20221001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Runtime.Extensions;

    /// <summary>A rule that provide the triggers and parameters for the scaling action.</summary>
    public partial class ScaleRule
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Runtime.Json.JsonObject container);

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

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Runtime.Json.JsonObject json, ref bool returnNow);

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

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Models.Api20221001.IScaleRule.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Models.Api20221001.IScaleRule.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Models.Api20221001.IScaleRule FromJson(Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Runtime.Json.JsonObject json ? new ScaleRule(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Runtime.Json.JsonObject into a new instance of <see cref="ScaleRule" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ScaleRule(Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_metricTrigger = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Runtime.Json.JsonObject>("metricTrigger"), out var __jsonMetricTrigger) ? Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Models.Api20221001.MetricTrigger.FromJson(__jsonMetricTrigger) : MetricTrigger;}
            {_scaleAction = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Runtime.Json.JsonObject>("scaleAction"), out var __jsonScaleAction) ? Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Models.Api20221001.ScaleAction.FromJson(__jsonScaleAction) : ScaleAction;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="ScaleRule" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ScaleRule" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._metricTrigger ? (Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Runtime.Json.JsonNode) this._metricTrigger.ToJson(null,serializationMode) : null, "metricTrigger" ,container.Add );
            AddIf( null != this._scaleAction ? (Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Runtime.Json.JsonNode) this._scaleAction.ToJson(null,serializationMode) : null, "scaleAction" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}