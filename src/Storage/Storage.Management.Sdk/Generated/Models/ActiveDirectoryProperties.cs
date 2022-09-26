// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Settings properties for Active Directory (AD).
    /// </summary>
    public partial class ActiveDirectoryProperties
    {
        /// <summary>
        /// Initializes a new instance of the ActiveDirectoryProperties class.
        /// </summary>
        public ActiveDirectoryProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ActiveDirectoryProperties class.
        /// </summary>
        /// <param name="domainName">Specifies the primary domain that the AD
        /// DNS server is authoritative for.</param>
        /// <param name="domainGuid">Specifies the domain GUID.</param>
        /// <param name="netBiosDomainName">Specifies the NetBIOS domain
        /// name.</param>
        /// <param name="forestName">Specifies the Active Directory forest to
        /// get.</param>
        /// <param name="domainSid">Specifies the security identifier
        /// (SID).</param>
        /// <param name="azureStorageSid">Specifies the security identifier
        /// (SID) for Azure Storage.</param>
        /// <param name="samAccountName">Specifies the Active Directory
        /// SAMAccountName for Azure Storage.</param>
        /// <param name="accountType">Specifies the Active Directory account
        /// type for Azure Storage. Possible values include: 'User',
        /// 'Computer'</param>
        public ActiveDirectoryProperties(string domainName, string domainGuid, string netBiosDomainName = default(string), string forestName = default(string), string domainSid = default(string), string azureStorageSid = default(string), string samAccountName = default(string), string accountType = default(string))
        {
            DomainName = domainName;
            NetBiosDomainName = netBiosDomainName;
            ForestName = forestName;
            DomainGuid = domainGuid;
            DomainSid = domainSid;
            AzureStorageSid = azureStorageSid;
            SamAccountName = samAccountName;
            AccountType = accountType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies the primary domain that the AD DNS server is
        /// authoritative for.
        /// </summary>
        [JsonProperty(PropertyName = "domainName")]
        public string DomainName { get; set; }

        /// <summary>
        /// Gets or sets specifies the NetBIOS domain name.
        /// </summary>
        [JsonProperty(PropertyName = "netBiosDomainName")]
        public string NetBiosDomainName { get; set; }

        /// <summary>
        /// Gets or sets specifies the Active Directory forest to get.
        /// </summary>
        [JsonProperty(PropertyName = "forestName")]
        public string ForestName { get; set; }

        /// <summary>
        /// Gets or sets specifies the domain GUID.
        /// </summary>
        [JsonProperty(PropertyName = "domainGuid")]
        public string DomainGuid { get; set; }

        /// <summary>
        /// Gets or sets specifies the security identifier (SID).
        /// </summary>
        [JsonProperty(PropertyName = "domainSid")]
        public string DomainSid { get; set; }

        /// <summary>
        /// Gets or sets specifies the security identifier (SID) for Azure
        /// Storage.
        /// </summary>
        [JsonProperty(PropertyName = "azureStorageSid")]
        public string AzureStorageSid { get; set; }

        /// <summary>
        /// Gets or sets specifies the Active Directory SAMAccountName for
        /// Azure Storage.
        /// </summary>
        [JsonProperty(PropertyName = "samAccountName")]
        public string SamAccountName { get; set; }

        /// <summary>
        /// Gets or sets specifies the Active Directory account type for Azure
        /// Storage. Possible values include: 'User', 'Computer'
        /// </summary>
        [JsonProperty(PropertyName = "accountType")]
        public string AccountType { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DomainName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DomainName");
            }
            if (DomainGuid == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DomainGuid");
            }
        }
    }
}
