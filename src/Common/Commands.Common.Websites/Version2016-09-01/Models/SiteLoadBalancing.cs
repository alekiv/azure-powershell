// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Version2016_09_01.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for SiteLoadBalancing.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SiteLoadBalancing
    {
        [EnumMember(Value = "WeightedRoundRobin")]
        WeightedRoundRobin,
        [EnumMember(Value = "LeastRequests")]
        LeastRequests,
        [EnumMember(Value = "LeastResponseTime")]
        LeastResponseTime,
        [EnumMember(Value = "WeightedTotalTraffic")]
        WeightedTotalTraffic,
        [EnumMember(Value = "RequestHash")]
        RequestHash
    }
    internal static class SiteLoadBalancingEnumExtension
    {
        internal static string ToSerializedValue(this SiteLoadBalancing? value)
        {
            return value == null ? null : ((SiteLoadBalancing)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this SiteLoadBalancing value)
        {
            switch( value )
            {
                case SiteLoadBalancing.WeightedRoundRobin:
                    return "WeightedRoundRobin";
                case SiteLoadBalancing.LeastRequests:
                    return "LeastRequests";
                case SiteLoadBalancing.LeastResponseTime:
                    return "LeastResponseTime";
                case SiteLoadBalancing.WeightedTotalTraffic:
                    return "WeightedTotalTraffic";
                case SiteLoadBalancing.RequestHash:
                    return "RequestHash";
            }
            return null;
        }

        internal static SiteLoadBalancing? ParseSiteLoadBalancing(this string value)
        {
            switch( value )
            {
                case "WeightedRoundRobin":
                    return SiteLoadBalancing.WeightedRoundRobin;
                case "LeastRequests":
                    return SiteLoadBalancing.LeastRequests;
                case "LeastResponseTime":
                    return SiteLoadBalancing.LeastResponseTime;
                case "WeightedTotalTraffic":
                    return SiteLoadBalancing.WeightedTotalTraffic;
                case "RequestHash":
                    return SiteLoadBalancing.RequestHash;
            }
            return null;
        }
    }
}
