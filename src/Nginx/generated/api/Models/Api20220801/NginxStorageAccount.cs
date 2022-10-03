// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20220801
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.Extensions;

    public partial class NginxStorageAccount :
        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20220801.INginxStorageAccount,
        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20220801.INginxStorageAccountInternal
    {

        /// <summary>Backing field for <see cref="AccountName" /> property.</summary>
        private string _accountName;

        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Origin(Microsoft.Azure.PowerShell.Cmdlets.Nginx.PropertyOrigin.Owned)]
        public string AccountName { get => this._accountName; set => this._accountName = value; }

        /// <summary>Backing field for <see cref="ContainerName" /> property.</summary>
        private string _containerName;

        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Origin(Microsoft.Azure.PowerShell.Cmdlets.Nginx.PropertyOrigin.Owned)]
        public string ContainerName { get => this._containerName; set => this._containerName = value; }

        /// <summary>Creates an new <see cref="NginxStorageAccount" /> instance.</summary>
        public NginxStorageAccount()
        {

        }
    }
    public partial interface INginxStorageAccount :
        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.IJsonSerializable
    {
        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"accountName",
        PossibleTypes = new [] { typeof(string) })]
        string AccountName { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"containerName",
        PossibleTypes = new [] { typeof(string) })]
        string ContainerName { get; set; }

    }
    internal partial interface INginxStorageAccountInternal

    {
        string AccountName { get; set; }

        string ContainerName { get; set; }

    }
}