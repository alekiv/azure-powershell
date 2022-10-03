// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Models.Api20221001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Runtime.Extensions;

    /// <summary>a property bag of settings. This value can be empty.</summary>
    public partial class WebhookNotificationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Models.Api20221001.IWebhookNotificationProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Models.Api20221001.IWebhookNotificationPropertiesInternal
    {

        /// <summary>Creates an new <see cref="WebhookNotificationProperties" /> instance.</summary>
        public WebhookNotificationProperties()
        {

        }
    }
    /// a property bag of settings. This value can be empty.
    public partial interface IWebhookNotificationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Runtime.IAssociativeArray<string>
    {

    }
    /// a property bag of settings. This value can be empty.
    internal partial interface IWebhookNotificationPropertiesInternal

    {

    }
}