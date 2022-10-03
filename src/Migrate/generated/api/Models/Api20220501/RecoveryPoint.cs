// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Recovery point.</summary>
    public partial class RecoveryPoint :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IRecoveryPoint,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IRecoveryPointInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.Resource();

        /// <summary>Resource Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IResourceInternal)__resource).Id; }

        /// <summary>Resource Location</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IResourceInternal)__resource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IResourceInternal)__resource).Location = value ?? null; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IRecoveryPointProperties Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IRecoveryPointInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.RecoveryPointProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProviderSpecificDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IProviderSpecificRecoveryPointDetails Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IRecoveryPointInternal.ProviderSpecificDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IRecoveryPointPropertiesInternal)Property).ProviderSpecificDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IRecoveryPointPropertiesInternal)Property).ProviderSpecificDetail = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IResourceInternal)__resource).Type = value; }

        /// <summary>Resource Name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IResourceInternal)__resource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IRecoveryPointProperties _property;

        /// <summary>The recovery point properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IRecoveryPointProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.RecoveryPointProperties()); set => this._property = value; }

        /// <summary>Gets the provider type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string ProviderSpecificDetailInstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IRecoveryPointPropertiesInternal)Property).ProviderSpecificDetailInstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IRecoveryPointPropertiesInternal)Property).ProviderSpecificDetailInstanceType = value ?? null; }

        /// <summary>The recovery point type: ApplicationConsistent, CrashConsistent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string RecoveryPointType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IRecoveryPointPropertiesInternal)Property).RecoveryPointType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IRecoveryPointPropertiesInternal)Property).RecoveryPointType = value ?? null; }

        /// <summary>The recovery point time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public global::System.DateTime? Time { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IRecoveryPointPropertiesInternal)Property).RecoveryPointTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IRecoveryPointPropertiesInternal)Property).RecoveryPointTime = value ?? default(global::System.DateTime); }

        /// <summary>Resource Type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="RecoveryPoint" /> instance.</summary>
        public RecoveryPoint()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// Recovery point.
    public partial interface IRecoveryPoint :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IResource
    {
        /// <summary>Gets the provider type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets the provider type.",
        SerializedName = @"instanceType",
        PossibleTypes = new [] { typeof(string) })]
        string ProviderSpecificDetailInstanceType { get; set; }
        /// <summary>The recovery point type: ApplicationConsistent, CrashConsistent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The recovery point type: ApplicationConsistent, CrashConsistent.",
        SerializedName = @"recoveryPointType",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryPointType { get; set; }
        /// <summary>The recovery point time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The recovery point time.",
        SerializedName = @"recoveryPointTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? Time { get; set; }

    }
    /// Recovery point.
    internal partial interface IRecoveryPointInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IResourceInternal
    {
        /// <summary>The recovery point properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IRecoveryPointProperties Property { get; set; }
        /// <summary>The provider specific details for the recovery point.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IProviderSpecificRecoveryPointDetails ProviderSpecificDetail { get; set; }
        /// <summary>Gets the provider type.</summary>
        string ProviderSpecificDetailInstanceType { get; set; }
        /// <summary>The recovery point type: ApplicationConsistent, CrashConsistent.</summary>
        string RecoveryPointType { get; set; }
        /// <summary>The recovery point time.</summary>
        global::System.DateTime? Time { get; set; }

    }
}