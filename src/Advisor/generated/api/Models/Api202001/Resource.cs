// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Advisor.Runtime.Extensions;

    /// <summary>An Azure resource.</summary>
    public partial class Resource :
        Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IResource,
        Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IResourceInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>The resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.Origin(Microsoft.Azure.PowerShell.Cmdlets.Advisor.PropertyOrigin.Owned)]
        public string Id { get => this._id; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IResourceInternal.Id { get => this._id; set { {_id = value;} } }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IResourceInternal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IResourceInternal.Type { get => this._type; set { {_type = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.Origin(Microsoft.Azure.PowerShell.Cmdlets.Advisor.PropertyOrigin.Owned)]
        public string Name { get => this._name; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>The type of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.Origin(Microsoft.Azure.PowerShell.Cmdlets.Advisor.PropertyOrigin.Owned)]
        public string Type { get => this._type; }

        /// <summary>Creates an new <see cref="Resource" /> instance.</summary>
        public Resource()
        {

        }
    }
    /// An Azure resource.
    public partial interface IResource :
        Microsoft.Azure.PowerShell.Cmdlets.Advisor.Runtime.IJsonSerializable
    {
        /// <summary>The resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The resource ID.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get;  }
        /// <summary>The name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The name of the resource.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }
        /// <summary>The type of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The type of the resource.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get;  }

    }
    /// An Azure resource.
    internal partial interface IResourceInternal

    {
        /// <summary>The resource ID.</summary>
        string Id { get; set; }
        /// <summary>The name of the resource.</summary>
        string Name { get; set; }
        /// <summary>The type of the resource.</summary>
        string Type { get; set; }

    }
}