
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Creates or updates a new Event Hub as a nested resource within a Namespace.
.Description
Creates or updates a new Event Hub as a nested resource within a Namespace.
.Example
New-AzEventHub -Name myEventHub -ResourceGroupName myResourceGroup -NamespaceName myNamespace -MessageRetentionInDays 6 -PartitionCount 5
.Example
New-AzEventHub -Name myEventHub -ResourceGroupName myResourceGroup -NamespaceName myNamespace -ArchiveNameFormat "{Namespace}/{EventHub}/{PartitionId}/{Year}/{Month}/{Day}/{Hour}/{Minute}/{Second}" -BlobContainer container -CaptureEnabled -DestinationName EventHubArchive.AzureBlockBlob -Encoding Avro -IntervalInSeconds 600 -SizeLimitInBytes 11000000 -SkipEmptyArchive -StorageAccountResourceId "/subscriptions/{subscriptionId}/resourceGroups/myResourceGroup/providers/Microsoft.Storage/storageAccounts/myStorageAccount"

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IEventhub
.Inputs
Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.IEventHubIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IEventhub
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IEventHubIdentity>: Identity Parameter
  [Alias <String>]: The Disaster Recovery configuration name
  [ApplicationGroupName <String>]: The Application Group name 
  [AuthorizationRuleName <String>]: The authorization rule name.
  [ClusterName <String>]: The name of the Event Hubs Cluster.
  [ConsumerGroupName <String>]: The consumer group name
  [EventHubName <String>]: The Event Hub name
  [Id <String>]: Resource identity path
  [NamespaceName <String>]: The Namespace name
  [PrivateEndpointConnectionName <String>]: The PrivateEndpointConnection name
  [ResourceAssociationName <String>]: The ResourceAssociation Name
  [ResourceGroupName <String>]: Name of the resource group within the azure subscription.
  [SchemaGroupName <String>]: The Schema Group name 
  [SubscriptionId <String>]: Subscription credentials that uniquely identify a Microsoft Azure subscription. The subscription ID forms part of the URI for every service call.

PARAMETER <IEventhub>: Single item in List or Get Event Hub operation
  [ArchiveNameFormat <String>]: Blob naming convention for archive, e.g. {Namespace}/{EventHub}/{PartitionId}/{Year}/{Month}/{Day}/{Hour}/{Minute}/{Second}. Here all the parameters (Namespace,EventHub .. etc) are mandatory irrespective of order
  [BlobContainer <String>]: Blob container Name
  [CaptureEnabled <Boolean?>]: A value that indicates whether capture description is enabled. 
  [DataLakeAccountName <String>]: The Azure Data Lake Store name for the captured events
  [DataLakeFolderPath <String>]: The destination folder path for the captured events
  [DataLakeSubscriptionId <String>]: Subscription Id of Azure Data Lake Store
  [DestinationName <String>]: Name for capture destination
  [Encoding <EncodingCaptureDescription?>]: Enumerates the possible values for the encoding format of capture description. Note: 'AvroDeflate' will be deprecated in New API Version
  [IntervalInSeconds <Int32?>]: The time window allows you to set the frequency with which the capture to Azure Blobs will happen, value should between 60 to 900 seconds
  [MessageRetentionInDays <Int64?>]: Number of days to retain the events for this Event Hub, value should be 1 to 7 days
  [PartitionCount <Int64?>]: Number of partitions created for the Event Hub, allowed values are from 1 to 32 partitions.
  [SizeLimitInBytes <Int32?>]: The size window defines the amount of data built up in your Event Hub before an capture operation, value should be between 10485760 to 524288000 bytes
  [SkipEmptyArchive <Boolean?>]: A value that indicates whether to Skip Empty Archives
  [Status <EntityStatus?>]: Enumerates the possible values for the status of the Event Hub.
  [StorageAccountResourceId <String>]: Resource id of the storage account to be used to create the blobs
  [SystemDataCreatedAt <DateTime?>]: The timestamp of resource creation (UTC).
  [SystemDataCreatedBy <String>]: The identity that created the resource.
  [SystemDataCreatedByType <CreatedByType?>]: The type of identity that created the resource.
  [SystemDataLastModifiedAt <DateTime?>]: The type of identity that last modified the resource.
  [SystemDataLastModifiedBy <String>]: The identity that last modified the resource.
  [SystemDataLastModifiedByType <CreatedByType?>]: The type of identity that last modified the resource.
.Link
https://docs.microsoft.com/powershell/module/az.eventhub/new-azeventhub
#>
function New-AzEventHub {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IEventhub])]
[CmdletBinding(DefaultParameterSetName='CreateViaIdentity', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.IEventHubIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IEventhub]
    # Single item in List or Get Event Hub operation
    # To construct, see NOTES section for PARAMETER properties and create a hash table.
    ${Parameter},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName

        $mapping = @{
            CreateViaIdentity = 'Az.EventHub.private\New-AzEventHub_CreateViaIdentity';
        }

        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {

        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {

        throw
    }

}
end {
    try {
        $steppablePipeline.End()

    } catch {

        throw
    }
} 
}
