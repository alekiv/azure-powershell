// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>InMageRcm discovered protected VM details.</summary>
    public partial class InMageRcmDiscoveredProtectedVMDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IInMageRcmDiscoveredProtectedVMDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IInMageRcmDiscoveredProtectedVMDetailsInternal
    {

        /// <summary>Backing field for <see cref="CreatedTimestamp" /> property.</summary>
        private global::System.DateTime? _createdTimestamp;

        /// <summary>The SDS created timestamp.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public global::System.DateTime? CreatedTimestamp { get => this._createdTimestamp; }

        /// <summary>Backing field for <see cref="Datastore" /> property.</summary>
        private string[] _datastore;

        /// <summary>The list of datastores.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string[] Datastore { get => this._datastore; }

        /// <summary>Backing field for <see cref="IPAddress" /> property.</summary>
        private string[] _iPAddress;

        /// <summary>The list of IP addresses.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string[] IPAddress { get => this._iPAddress; }

        /// <summary>Backing field for <see cref="IsDeleted" /> property.</summary>
        private bool? _isDeleted;

        /// <summary>A value indicating whether the VM is deleted.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public bool? IsDeleted { get => this._isDeleted; }

        /// <summary>Backing field for <see cref="LastDiscoveryTimeInUtc" /> property.</summary>
        private global::System.DateTime? _lastDiscoveryTimeInUtc;

        /// <summary>The last time when SDS information discovered in SRS.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public global::System.DateTime? LastDiscoveryTimeInUtc { get => this._lastDiscoveryTimeInUtc; }

        /// <summary>Internal Acessors for CreatedTimestamp</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IInMageRcmDiscoveredProtectedVMDetailsInternal.CreatedTimestamp { get => this._createdTimestamp; set { {_createdTimestamp = value;} } }

        /// <summary>Internal Acessors for Datastore</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IInMageRcmDiscoveredProtectedVMDetailsInternal.Datastore { get => this._datastore; set { {_datastore = value;} } }

        /// <summary>Internal Acessors for IPAddress</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IInMageRcmDiscoveredProtectedVMDetailsInternal.IPAddress { get => this._iPAddress; set { {_iPAddress = value;} } }

        /// <summary>Internal Acessors for IsDeleted</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IInMageRcmDiscoveredProtectedVMDetailsInternal.IsDeleted { get => this._isDeleted; set { {_isDeleted = value;} } }

        /// <summary>Internal Acessors for LastDiscoveryTimeInUtc</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IInMageRcmDiscoveredProtectedVMDetailsInternal.LastDiscoveryTimeInUtc { get => this._lastDiscoveryTimeInUtc; set { {_lastDiscoveryTimeInUtc = value;} } }

        /// <summary>Internal Acessors for OSName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IInMageRcmDiscoveredProtectedVMDetailsInternal.OSName { get => this._oSName; set { {_oSName = value;} } }

        /// <summary>Internal Acessors for PowerStatus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IInMageRcmDiscoveredProtectedVMDetailsInternal.PowerStatus { get => this._powerStatus; set { {_powerStatus = value;} } }

        /// <summary>Internal Acessors for UpdatedTimestamp</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IInMageRcmDiscoveredProtectedVMDetailsInternal.UpdatedTimestamp { get => this._updatedTimestamp; set { {_updatedTimestamp = value;} } }

        /// <summary>Internal Acessors for VCenterFqdn</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IInMageRcmDiscoveredProtectedVMDetailsInternal.VCenterFqdn { get => this._vCenterFqdn; set { {_vCenterFqdn = value;} } }

        /// <summary>Internal Acessors for VCenterId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IInMageRcmDiscoveredProtectedVMDetailsInternal.VCenterId { get => this._vCenterId; set { {_vCenterId = value;} } }

        /// <summary>Internal Acessors for VMFqdn</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IInMageRcmDiscoveredProtectedVMDetailsInternal.VMFqdn { get => this._vMFqdn; set { {_vMFqdn = value;} } }

        /// <summary>Internal Acessors for VmwareToolsStatus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IInMageRcmDiscoveredProtectedVMDetailsInternal.VmwareToolsStatus { get => this._vmwareToolsStatus; set { {_vmwareToolsStatus = value;} } }

        /// <summary>Backing field for <see cref="OSName" /> property.</summary>
        private string _oSName;

        /// <summary>The VM's OS name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string OSName { get => this._oSName; }

        /// <summary>Backing field for <see cref="PowerStatus" /> property.</summary>
        private string _powerStatus;

        /// <summary>The VM power status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string PowerStatus { get => this._powerStatus; }

        /// <summary>Backing field for <see cref="UpdatedTimestamp" /> property.</summary>
        private global::System.DateTime? _updatedTimestamp;

        /// <summary>The SDS updated timestamp.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public global::System.DateTime? UpdatedTimestamp { get => this._updatedTimestamp; }

        /// <summary>Backing field for <see cref="VCenterFqdn" /> property.</summary>
        private string _vCenterFqdn;

        /// <summary>The VCenter fqdn.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string VCenterFqdn { get => this._vCenterFqdn; }

        /// <summary>Backing field for <see cref="VCenterId" /> property.</summary>
        private string _vCenterId;

        /// <summary>The VCenter Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string VCenterId { get => this._vCenterId; }

        /// <summary>Backing field for <see cref="VMFqdn" /> property.</summary>
        private string _vMFqdn;

        /// <summary>The VM fqdn.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string VMFqdn { get => this._vMFqdn; }

        /// <summary>Backing field for <see cref="VmwareToolsStatus" /> property.</summary>
        private string _vmwareToolsStatus;

        /// <summary>The VMware tools status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string VmwareToolsStatus { get => this._vmwareToolsStatus; }

        /// <summary>Creates an new <see cref="InMageRcmDiscoveredProtectedVMDetails" /> instance.</summary>
        public InMageRcmDiscoveredProtectedVMDetails()
        {

        }
    }
    /// InMageRcm discovered protected VM details.
    public partial interface IInMageRcmDiscoveredProtectedVMDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>The SDS created timestamp.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The SDS created timestamp.",
        SerializedName = @"createdTimestamp",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? CreatedTimestamp { get;  }
        /// <summary>The list of datastores.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The list of datastores.",
        SerializedName = @"datastores",
        PossibleTypes = new [] { typeof(string) })]
        string[] Datastore { get;  }
        /// <summary>The list of IP addresses.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The list of IP addresses.",
        SerializedName = @"ipAddresses",
        PossibleTypes = new [] { typeof(string) })]
        string[] IPAddress { get;  }
        /// <summary>A value indicating whether the VM is deleted.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A value indicating whether the VM is deleted.",
        SerializedName = @"isDeleted",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsDeleted { get;  }
        /// <summary>The last time when SDS information discovered in SRS.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The last time when SDS information discovered in SRS.",
        SerializedName = @"lastDiscoveryTimeInUtc",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastDiscoveryTimeInUtc { get;  }
        /// <summary>The VM's OS name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The VM's OS name.",
        SerializedName = @"osName",
        PossibleTypes = new [] { typeof(string) })]
        string OSName { get;  }
        /// <summary>The VM power status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The VM power status.",
        SerializedName = @"powerStatus",
        PossibleTypes = new [] { typeof(string) })]
        string PowerStatus { get;  }
        /// <summary>The SDS updated timestamp.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The SDS updated timestamp.",
        SerializedName = @"updatedTimestamp",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? UpdatedTimestamp { get;  }
        /// <summary>The VCenter fqdn.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The VCenter fqdn.",
        SerializedName = @"vCenterFqdn",
        PossibleTypes = new [] { typeof(string) })]
        string VCenterFqdn { get;  }
        /// <summary>The VCenter Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The VCenter Id.",
        SerializedName = @"vCenterId",
        PossibleTypes = new [] { typeof(string) })]
        string VCenterId { get;  }
        /// <summary>The VM fqdn.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The VM fqdn.",
        SerializedName = @"vmFqdn",
        PossibleTypes = new [] { typeof(string) })]
        string VMFqdn { get;  }
        /// <summary>The VMware tools status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The VMware tools status.",
        SerializedName = @"vmwareToolsStatus",
        PossibleTypes = new [] { typeof(string) })]
        string VmwareToolsStatus { get;  }

    }
    /// InMageRcm discovered protected VM details.
    internal partial interface IInMageRcmDiscoveredProtectedVMDetailsInternal

    {
        /// <summary>The SDS created timestamp.</summary>
        global::System.DateTime? CreatedTimestamp { get; set; }
        /// <summary>The list of datastores.</summary>
        string[] Datastore { get; set; }
        /// <summary>The list of IP addresses.</summary>
        string[] IPAddress { get; set; }
        /// <summary>A value indicating whether the VM is deleted.</summary>
        bool? IsDeleted { get; set; }
        /// <summary>The last time when SDS information discovered in SRS.</summary>
        global::System.DateTime? LastDiscoveryTimeInUtc { get; set; }
        /// <summary>The VM's OS name.</summary>
        string OSName { get; set; }
        /// <summary>The VM power status.</summary>
        string PowerStatus { get; set; }
        /// <summary>The SDS updated timestamp.</summary>
        global::System.DateTime? UpdatedTimestamp { get; set; }
        /// <summary>The VCenter fqdn.</summary>
        string VCenterFqdn { get; set; }
        /// <summary>The VCenter Id.</summary>
        string VCenterId { get; set; }
        /// <summary>The VM fqdn.</summary>
        string VMFqdn { get; set; }
        /// <summary>The VMware tools status.</summary>
        string VmwareToolsStatus { get; set; }

    }
}