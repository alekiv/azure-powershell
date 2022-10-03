// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501
{
    using Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.PowerShell;

    /// <summary>Backup Vault Resource</summary>
    [System.ComponentModel.TypeConverter(typeof(BackupVaultResourceTypeConverter))]
    public partial class BackupVaultResource
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.BackupVaultResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal BackupVaultResource(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IBackupVaultResourceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IBackupVault) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IBackupVaultResourceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.BackupVaultTypeConverter.ConvertFrom);
            }
            if (content.Contains("IdentityPrincipalId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IDppTrackedResourceInternal)this).IdentityPrincipalId = (string) content.GetValueForProperty("IdentityPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IDppTrackedResourceInternal)this).IdentityPrincipalId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityTenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IDppTrackedResourceInternal)this).IdentityTenantId = (string) content.GetValueForProperty("IdentityTenantId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IDppTrackedResourceInternal)this).IdentityTenantId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IDppTrackedResourceInternal)this).IdentityType = (string) content.GetValueForProperty("IdentityType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IDppTrackedResourceInternal)this).IdentityType, global::System.Convert.ToString);
            }
            if (content.Contains("Identity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IDppTrackedResourceInternal)this).Identity = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IDppIdentityDetails) content.GetValueForProperty("Identity",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IDppTrackedResourceInternal)this).Identity, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.DppIdentityDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ETag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IDppTrackedResourceInternal)this).ETag = (string) content.GetValueForProperty("ETag",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IDppTrackedResourceInternal)this).ETag, global::System.Convert.ToString);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IDppTrackedResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IDppTrackedResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IDppTrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IDppTrackedResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IDppTrackedResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IDppTrackedResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IDppTrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IDppTrackedResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IDppTrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.DppTrackedResourceTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IDppTrackedResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IDppTrackedResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IDppTrackedResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IDppTrackedResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("MonitoringSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IBackupVaultResourceInternal)this).MonitoringSetting = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IMonitoringSettings) content.GetValueForProperty("MonitoringSetting",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IBackupVaultResourceInternal)this).MonitoringSetting, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.MonitoringSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IBackupVaultResourceInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IBackupVaultResourceInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("ResourceMoveDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IBackupVaultResourceInternal)this).ResourceMoveDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IResourceMoveDetails) content.GetValueForProperty("ResourceMoveDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IBackupVaultResourceInternal)this).ResourceMoveDetail, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.ResourceMoveDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ResourceMoveState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IBackupVaultResourceInternal)this).ResourceMoveState = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.ResourceMoveState?) content.GetValueForProperty("ResourceMoveState",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IBackupVaultResourceInternal)this).ResourceMoveState, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.ResourceMoveState.CreateFrom);
            }
            if (content.Contains("StorageSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IBackupVaultResourceInternal)this).StorageSetting = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IStorageSetting[]) content.GetValueForProperty("StorageSetting",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IBackupVaultResourceInternal)this).StorageSetting, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IStorageSetting>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.StorageSettingTypeConverter.ConvertFrom));
            }
            if (content.Contains("ResourceMoveDetailOperationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IBackupVaultResourceInternal)this).ResourceMoveDetailOperationId = (string) content.GetValueForProperty("ResourceMoveDetailOperationId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IBackupVaultResourceInternal)this).ResourceMoveDetailOperationId, global::System.Convert.ToString);
            }
            if (content.Contains("MonitoringSettingAzureMonitorAlertSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IBackupVaultResourceInternal)this).MonitoringSettingAzureMonitorAlertSetting = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IAzureMonitorAlertSettings) content.GetValueForProperty("MonitoringSettingAzureMonitorAlertSetting",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IBackupVaultResourceInternal)this).MonitoringSettingAzureMonitorAlertSetting, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.AzureMonitorAlertSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ResourceMoveDetailStartTimeUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IBackupVaultResourceInternal)this).ResourceMoveDetailStartTimeUtc = (string) content.GetValueForProperty("ResourceMoveDetailStartTimeUtc",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IBackupVaultResourceInternal)this).ResourceMoveDetailStartTimeUtc, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceMoveDetailCompletionTimeUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IBackupVaultResourceInternal)this).ResourceMoveDetailCompletionTimeUtc = (string) content.GetValueForProperty("ResourceMoveDetailCompletionTimeUtc",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IBackupVaultResourceInternal)this).ResourceMoveDetailCompletionTimeUtc, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceMoveDetailSourceResourcePath"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IBackupVaultResourceInternal)this).ResourceMoveDetailSourceResourcePath = (string) content.GetValueForProperty("ResourceMoveDetailSourceResourcePath",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IBackupVaultResourceInternal)this).ResourceMoveDetailSourceResourcePath, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceMoveDetailTargetResourcePath"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IBackupVaultResourceInternal)this).ResourceMoveDetailTargetResourcePath = (string) content.GetValueForProperty("ResourceMoveDetailTargetResourcePath",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IBackupVaultResourceInternal)this).ResourceMoveDetailTargetResourcePath, global::System.Convert.ToString);
            }
            if (content.Contains("AzureMonitorAlertsForAllJobFailure"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IBackupVaultResourceInternal)this).AzureMonitorAlertsForAllJobFailure = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.AlertsState?) content.GetValueForProperty("AzureMonitorAlertsForAllJobFailure",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IBackupVaultResourceInternal)this).AzureMonitorAlertsForAllJobFailure, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.AlertsState.CreateFrom);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.BackupVaultResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal BackupVaultResource(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IBackupVaultResourceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IBackupVault) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IBackupVaultResourceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.BackupVaultTypeConverter.ConvertFrom);
            }
            if (content.Contains("IdentityPrincipalId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IDppTrackedResourceInternal)this).IdentityPrincipalId = (string) content.GetValueForProperty("IdentityPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IDppTrackedResourceInternal)this).IdentityPrincipalId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityTenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IDppTrackedResourceInternal)this).IdentityTenantId = (string) content.GetValueForProperty("IdentityTenantId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IDppTrackedResourceInternal)this).IdentityTenantId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IDppTrackedResourceInternal)this).IdentityType = (string) content.GetValueForProperty("IdentityType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IDppTrackedResourceInternal)this).IdentityType, global::System.Convert.ToString);
            }
            if (content.Contains("Identity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IDppTrackedResourceInternal)this).Identity = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IDppIdentityDetails) content.GetValueForProperty("Identity",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IDppTrackedResourceInternal)this).Identity, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.DppIdentityDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ETag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IDppTrackedResourceInternal)this).ETag = (string) content.GetValueForProperty("ETag",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IDppTrackedResourceInternal)this).ETag, global::System.Convert.ToString);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IDppTrackedResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IDppTrackedResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IDppTrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IDppTrackedResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IDppTrackedResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IDppTrackedResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IDppTrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IDppTrackedResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IDppTrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.DppTrackedResourceTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IDppTrackedResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IDppTrackedResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IDppTrackedResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IDppTrackedResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("MonitoringSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IBackupVaultResourceInternal)this).MonitoringSetting = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IMonitoringSettings) content.GetValueForProperty("MonitoringSetting",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IBackupVaultResourceInternal)this).MonitoringSetting, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.MonitoringSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IBackupVaultResourceInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IBackupVaultResourceInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("ResourceMoveDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IBackupVaultResourceInternal)this).ResourceMoveDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IResourceMoveDetails) content.GetValueForProperty("ResourceMoveDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IBackupVaultResourceInternal)this).ResourceMoveDetail, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.ResourceMoveDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ResourceMoveState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IBackupVaultResourceInternal)this).ResourceMoveState = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.ResourceMoveState?) content.GetValueForProperty("ResourceMoveState",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IBackupVaultResourceInternal)this).ResourceMoveState, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.ResourceMoveState.CreateFrom);
            }
            if (content.Contains("StorageSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IBackupVaultResourceInternal)this).StorageSetting = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IStorageSetting[]) content.GetValueForProperty("StorageSetting",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IBackupVaultResourceInternal)this).StorageSetting, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IStorageSetting>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.StorageSettingTypeConverter.ConvertFrom));
            }
            if (content.Contains("ResourceMoveDetailOperationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IBackupVaultResourceInternal)this).ResourceMoveDetailOperationId = (string) content.GetValueForProperty("ResourceMoveDetailOperationId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IBackupVaultResourceInternal)this).ResourceMoveDetailOperationId, global::System.Convert.ToString);
            }
            if (content.Contains("MonitoringSettingAzureMonitorAlertSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IBackupVaultResourceInternal)this).MonitoringSettingAzureMonitorAlertSetting = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IAzureMonitorAlertSettings) content.GetValueForProperty("MonitoringSettingAzureMonitorAlertSetting",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IBackupVaultResourceInternal)this).MonitoringSettingAzureMonitorAlertSetting, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.AzureMonitorAlertSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ResourceMoveDetailStartTimeUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IBackupVaultResourceInternal)this).ResourceMoveDetailStartTimeUtc = (string) content.GetValueForProperty("ResourceMoveDetailStartTimeUtc",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IBackupVaultResourceInternal)this).ResourceMoveDetailStartTimeUtc, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceMoveDetailCompletionTimeUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IBackupVaultResourceInternal)this).ResourceMoveDetailCompletionTimeUtc = (string) content.GetValueForProperty("ResourceMoveDetailCompletionTimeUtc",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IBackupVaultResourceInternal)this).ResourceMoveDetailCompletionTimeUtc, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceMoveDetailSourceResourcePath"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IBackupVaultResourceInternal)this).ResourceMoveDetailSourceResourcePath = (string) content.GetValueForProperty("ResourceMoveDetailSourceResourcePath",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IBackupVaultResourceInternal)this).ResourceMoveDetailSourceResourcePath, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceMoveDetailTargetResourcePath"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IBackupVaultResourceInternal)this).ResourceMoveDetailTargetResourcePath = (string) content.GetValueForProperty("ResourceMoveDetailTargetResourcePath",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IBackupVaultResourceInternal)this).ResourceMoveDetailTargetResourcePath, global::System.Convert.ToString);
            }
            if (content.Contains("AzureMonitorAlertsForAllJobFailure"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IBackupVaultResourceInternal)this).AzureMonitorAlertsForAllJobFailure = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.AlertsState?) content.GetValueForProperty("AzureMonitorAlertsForAllJobFailure",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IBackupVaultResourceInternal)this).AzureMonitorAlertsForAllJobFailure, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.AlertsState.CreateFrom);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.BackupVaultResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IBackupVaultResource" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IBackupVaultResource DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new BackupVaultResource(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.BackupVaultResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IBackupVaultResource" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IBackupVaultResource DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new BackupVaultResource(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="BackupVaultResource" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="BackupVaultResource" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IBackupVaultResource FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Backup Vault Resource
    [System.ComponentModel.TypeConverter(typeof(BackupVaultResourceTypeConverter))]
    public partial interface IBackupVaultResource

    {

    }
}