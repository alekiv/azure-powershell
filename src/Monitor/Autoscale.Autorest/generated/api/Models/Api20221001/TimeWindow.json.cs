// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Models.Api20221001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Runtime.Extensions;

    /// <summary>A specific date-time for the profile.</summary>
    public partial class TimeWindow
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
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Models.Api20221001.ITimeWindow.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Models.Api20221001.ITimeWindow.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Models.Api20221001.ITimeWindow FromJson(Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Runtime.Json.JsonObject json ? new TimeWindow(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Runtime.Json.JsonObject into a new instance of <see cref="TimeWindow" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal TimeWindow(Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_timeZone = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Runtime.Json.JsonString>("timeZone"), out var __jsonTimeZone) ? (string)__jsonTimeZone : (string)TimeZone;}
            {_start = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Runtime.Json.JsonString>("start"), out var __jsonStart) ? global::System.DateTime.TryParse((string)__jsonStart, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonStartValue) ? __jsonStartValue : Start : Start;}
            {_end = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Runtime.Json.JsonString>("end"), out var __jsonEnd) ? global::System.DateTime.TryParse((string)__jsonEnd, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonEndValue) ? __jsonEndValue : End : End;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="TimeWindow" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="TimeWindow" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Runtime.Json.JsonNode" />.
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
            AddIf( null != (((object)this._timeZone)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Runtime.Json.JsonString(this._timeZone.ToString()) : null, "timeZone" ,container.Add );
            AddIf( (Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Runtime.Json.JsonString(this._start.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)), "start" ,container.Add );
            AddIf( (Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Runtime.Json.JsonString(this._end.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)), "end" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}