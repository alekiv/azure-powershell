// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501
{
    using Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.PowerShell;

    /// <summary>VMM fabric provider specific VM settings.</summary>
    [System.ComponentModel.TypeConverter(typeof(VmmVirtualMachineDetailsTypeConverter))]
    public partial class VmmVirtualMachineDetails
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.VmmVirtualMachineDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IVmmVirtualMachineDetails" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IVmmVirtualMachineDetails DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new VmmVirtualMachineDetails(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.VmmVirtualMachineDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IVmmVirtualMachineDetails" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IVmmVirtualMachineDetails DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new VmmVirtualMachineDetails(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="VmmVirtualMachineDetails" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="VmmVirtualMachineDetails" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IVmmVirtualMachineDetails FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeAll)?.ToString();

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.VmmVirtualMachineDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal VmmVirtualMachineDetails(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("InstanceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IConfigurationSettingsInternal)this).InstanceType = (string) content.GetValueForProperty("InstanceType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IConfigurationSettingsInternal)this).InstanceType, global::System.Convert.ToString);
            }
            if (content.Contains("OSDetailOstype"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVVirtualMachineDetailsInternal)this).OSDetailOstype = (string) content.GetValueForProperty("OSDetailOstype",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVVirtualMachineDetailsInternal)this).OSDetailOstype, global::System.Convert.ToString);
            }
            if (content.Contains("OSDetailProductType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVVirtualMachineDetailsInternal)this).OSDetailProductType = (string) content.GetValueForProperty("OSDetailProductType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVVirtualMachineDetailsInternal)this).OSDetailProductType, global::System.Convert.ToString);
            }
            if (content.Contains("OSDetailOsedition"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVVirtualMachineDetailsInternal)this).OSDetailOsedition = (string) content.GetValueForProperty("OSDetailOsedition",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVVirtualMachineDetailsInternal)this).OSDetailOsedition, global::System.Convert.ToString);
            }
            if (content.Contains("OSDetailOsversion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVVirtualMachineDetailsInternal)this).OSDetailOsversion = (string) content.GetValueForProperty("OSDetailOsversion",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVVirtualMachineDetailsInternal)this).OSDetailOsversion, global::System.Convert.ToString);
            }
            if (content.Contains("OSDetailOsmajorVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVVirtualMachineDetailsInternal)this).OSDetailOsmajorVersion = (string) content.GetValueForProperty("OSDetailOsmajorVersion",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVVirtualMachineDetailsInternal)this).OSDetailOsmajorVersion, global::System.Convert.ToString);
            }
            if (content.Contains("OSDetailOsminorVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVVirtualMachineDetailsInternal)this).OSDetailOsminorVersion = (string) content.GetValueForProperty("OSDetailOsminorVersion",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVVirtualMachineDetailsInternal)this).OSDetailOsminorVersion, global::System.Convert.ToString);
            }
            if (content.Contains("OSDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVVirtualMachineDetailsInternal)this).OSDetail = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IOSDetails) content.GetValueForProperty("OSDetail",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVVirtualMachineDetailsInternal)this).OSDetail, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.OSDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("SourceItemId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVVirtualMachineDetailsInternal)this).SourceItemId = (string) content.GetValueForProperty("SourceItemId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVVirtualMachineDetailsInternal)this).SourceItemId, global::System.Convert.ToString);
            }
            if (content.Contains("Generation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVVirtualMachineDetailsInternal)this).Generation = (string) content.GetValueForProperty("Generation",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVVirtualMachineDetailsInternal)this).Generation, global::System.Convert.ToString);
            }
            if (content.Contains("DiskDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVVirtualMachineDetailsInternal)this).DiskDetail = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IDiskDetails[]) content.GetValueForProperty("DiskDetail",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVVirtualMachineDetailsInternal)this).DiskDetail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IDiskDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.DiskDetailsTypeConverter.ConvertFrom));
            }
            if (content.Contains("HasPhysicalDisk"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVVirtualMachineDetailsInternal)this).HasPhysicalDisk = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.PresenceStatus?) content.GetValueForProperty("HasPhysicalDisk",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVVirtualMachineDetailsInternal)this).HasPhysicalDisk, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.PresenceStatus.CreateFrom);
            }
            if (content.Contains("HasFibreChannelAdapter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVVirtualMachineDetailsInternal)this).HasFibreChannelAdapter = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.PresenceStatus?) content.GetValueForProperty("HasFibreChannelAdapter",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVVirtualMachineDetailsInternal)this).HasFibreChannelAdapter, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.PresenceStatus.CreateFrom);
            }
            if (content.Contains("HasSharedVhd"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVVirtualMachineDetailsInternal)this).HasSharedVhd = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.PresenceStatus?) content.GetValueForProperty("HasSharedVhd",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVVirtualMachineDetailsInternal)this).HasSharedVhd, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.PresenceStatus.CreateFrom);
            }
            if (content.Contains("HyperVHostId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVVirtualMachineDetailsInternal)this).HyperVHostId = (string) content.GetValueForProperty("HyperVHostId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVVirtualMachineDetailsInternal)this).HyperVHostId, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.VmmVirtualMachineDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal VmmVirtualMachineDetails(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("InstanceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IConfigurationSettingsInternal)this).InstanceType = (string) content.GetValueForProperty("InstanceType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IConfigurationSettingsInternal)this).InstanceType, global::System.Convert.ToString);
            }
            if (content.Contains("OSDetailOstype"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVVirtualMachineDetailsInternal)this).OSDetailOstype = (string) content.GetValueForProperty("OSDetailOstype",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVVirtualMachineDetailsInternal)this).OSDetailOstype, global::System.Convert.ToString);
            }
            if (content.Contains("OSDetailProductType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVVirtualMachineDetailsInternal)this).OSDetailProductType = (string) content.GetValueForProperty("OSDetailProductType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVVirtualMachineDetailsInternal)this).OSDetailProductType, global::System.Convert.ToString);
            }
            if (content.Contains("OSDetailOsedition"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVVirtualMachineDetailsInternal)this).OSDetailOsedition = (string) content.GetValueForProperty("OSDetailOsedition",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVVirtualMachineDetailsInternal)this).OSDetailOsedition, global::System.Convert.ToString);
            }
            if (content.Contains("OSDetailOsversion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVVirtualMachineDetailsInternal)this).OSDetailOsversion = (string) content.GetValueForProperty("OSDetailOsversion",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVVirtualMachineDetailsInternal)this).OSDetailOsversion, global::System.Convert.ToString);
            }
            if (content.Contains("OSDetailOsmajorVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVVirtualMachineDetailsInternal)this).OSDetailOsmajorVersion = (string) content.GetValueForProperty("OSDetailOsmajorVersion",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVVirtualMachineDetailsInternal)this).OSDetailOsmajorVersion, global::System.Convert.ToString);
            }
            if (content.Contains("OSDetailOsminorVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVVirtualMachineDetailsInternal)this).OSDetailOsminorVersion = (string) content.GetValueForProperty("OSDetailOsminorVersion",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVVirtualMachineDetailsInternal)this).OSDetailOsminorVersion, global::System.Convert.ToString);
            }
            if (content.Contains("OSDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVVirtualMachineDetailsInternal)this).OSDetail = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IOSDetails) content.GetValueForProperty("OSDetail",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVVirtualMachineDetailsInternal)this).OSDetail, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.OSDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("SourceItemId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVVirtualMachineDetailsInternal)this).SourceItemId = (string) content.GetValueForProperty("SourceItemId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVVirtualMachineDetailsInternal)this).SourceItemId, global::System.Convert.ToString);
            }
            if (content.Contains("Generation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVVirtualMachineDetailsInternal)this).Generation = (string) content.GetValueForProperty("Generation",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVVirtualMachineDetailsInternal)this).Generation, global::System.Convert.ToString);
            }
            if (content.Contains("DiskDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVVirtualMachineDetailsInternal)this).DiskDetail = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IDiskDetails[]) content.GetValueForProperty("DiskDetail",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVVirtualMachineDetailsInternal)this).DiskDetail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IDiskDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.DiskDetailsTypeConverter.ConvertFrom));
            }
            if (content.Contains("HasPhysicalDisk"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVVirtualMachineDetailsInternal)this).HasPhysicalDisk = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.PresenceStatus?) content.GetValueForProperty("HasPhysicalDisk",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVVirtualMachineDetailsInternal)this).HasPhysicalDisk, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.PresenceStatus.CreateFrom);
            }
            if (content.Contains("HasFibreChannelAdapter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVVirtualMachineDetailsInternal)this).HasFibreChannelAdapter = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.PresenceStatus?) content.GetValueForProperty("HasFibreChannelAdapter",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVVirtualMachineDetailsInternal)this).HasFibreChannelAdapter, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.PresenceStatus.CreateFrom);
            }
            if (content.Contains("HasSharedVhd"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVVirtualMachineDetailsInternal)this).HasSharedVhd = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.PresenceStatus?) content.GetValueForProperty("HasSharedVhd",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVVirtualMachineDetailsInternal)this).HasSharedVhd, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.PresenceStatus.CreateFrom);
            }
            if (content.Contains("HyperVHostId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVVirtualMachineDetailsInternal)this).HyperVHostId = (string) content.GetValueForProperty("HyperVHostId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVVirtualMachineDetailsInternal)this).HyperVHostId, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }
    }
    /// VMM fabric provider specific VM settings.
    [System.ComponentModel.TypeConverter(typeof(VmmVirtualMachineDetailsTypeConverter))]
    public partial interface IVmmVirtualMachineDetails

    {

    }
}