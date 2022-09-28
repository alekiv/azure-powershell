// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001
{
    using Microsoft.Azure.PowerShell.Cmdlets.Advisor.Runtime.PowerShell;

    /// <summary>Advisor Digest configuration entity</summary>
    [System.ComponentModel.TypeConverter(typeof(DigestConfigTypeConverter))]
    public partial class DigestConfig
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.DigestConfig"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IDigestConfig" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IDigestConfig DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new DigestConfig(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.DigestConfig"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IDigestConfig" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IDigestConfig DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new DigestConfig(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.DigestConfig"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal DigestConfig(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IDigestConfigInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IDigestConfigInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("ActionGroupResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IDigestConfigInternal)this).ActionGroupResourceId = (string) content.GetValueForProperty("ActionGroupResourceId",((Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IDigestConfigInternal)this).ActionGroupResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("Frequency"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IDigestConfigInternal)this).Frequency = (int?) content.GetValueForProperty("Frequency",((Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IDigestConfigInternal)this).Frequency, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("Category"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IDigestConfigInternal)this).Category = (Microsoft.Azure.PowerShell.Cmdlets.Advisor.Support.Category[]) content.GetValueForProperty("Category",((Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IDigestConfigInternal)this).Category, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Advisor.Support.Category>(__y, Microsoft.Azure.PowerShell.Cmdlets.Advisor.Support.Category.CreateFrom));
            }
            if (content.Contains("Language"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IDigestConfigInternal)this).Language = (string) content.GetValueForProperty("Language",((Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IDigestConfigInternal)this).Language, global::System.Convert.ToString);
            }
            if (content.Contains("State"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IDigestConfigInternal)this).State = (Microsoft.Azure.PowerShell.Cmdlets.Advisor.Support.DigestConfigState?) content.GetValueForProperty("State",((Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IDigestConfigInternal)this).State, Microsoft.Azure.PowerShell.Cmdlets.Advisor.Support.DigestConfigState.CreateFrom);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.DigestConfig"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal DigestConfig(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IDigestConfigInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IDigestConfigInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("ActionGroupResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IDigestConfigInternal)this).ActionGroupResourceId = (string) content.GetValueForProperty("ActionGroupResourceId",((Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IDigestConfigInternal)this).ActionGroupResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("Frequency"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IDigestConfigInternal)this).Frequency = (int?) content.GetValueForProperty("Frequency",((Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IDigestConfigInternal)this).Frequency, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("Category"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IDigestConfigInternal)this).Category = (Microsoft.Azure.PowerShell.Cmdlets.Advisor.Support.Category[]) content.GetValueForProperty("Category",((Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IDigestConfigInternal)this).Category, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Advisor.Support.Category>(__y, Microsoft.Azure.PowerShell.Cmdlets.Advisor.Support.Category.CreateFrom));
            }
            if (content.Contains("Language"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IDigestConfigInternal)this).Language = (string) content.GetValueForProperty("Language",((Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IDigestConfigInternal)this).Language, global::System.Convert.ToString);
            }
            if (content.Contains("State"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IDigestConfigInternal)this).State = (Microsoft.Azure.PowerShell.Cmdlets.Advisor.Support.DigestConfigState?) content.GetValueForProperty("State",((Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IDigestConfigInternal)this).State, Microsoft.Azure.PowerShell.Cmdlets.Advisor.Support.DigestConfigState.CreateFrom);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="DigestConfig" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="DigestConfig" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IDigestConfig FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Advisor.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Advisor.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Advisor Digest configuration entity
    [System.ComponentModel.TypeConverter(typeof(DigestConfigTypeConverter))]
    public partial interface IDigestConfig

    {

    }
}