
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
Invokes GEO DR failover and reconfigure the alias to point to the secondary namespace
.Description
Invokes GEO DR failover and reconfigure the alias to point to the secondary namespace
.Example
{{ Add code here }}
.Example
{{ Add code here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.IEventHubIdentity
.Outputs
System.Boolean
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
.Link
https://docs.microsoft.com/powershell/module/az.eventhub/invoke-azeventhubfaildisasterrecoveryconfigover
#>
function Invoke-AzEventHubFailDisasterRecoveryConfigOver {
[OutputType([System.Boolean])]
[CmdletBinding(DefaultParameterSetName='Fail', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Fail', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Category('Path')]
    [System.String]
    # The Disaster Recovery configuration name
    ${Name},

    [Parameter(ParameterSetName='Fail', Mandatory)]
    [Alias('Namespace')]
    [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Category('Path')]
    [System.String]
    # The Namespace name
    ${NamespaceName},

    [Parameter(ParameterSetName='Fail', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Category('Path')]
    [System.String]
    # Name of the resource group within the azure subscription.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Fail')]
    [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Subscription credentials that uniquely identify a Microsoft Azure subscription.
    # The subscription ID forms part of the URI for every service call.
    ${SubscriptionId},

    [Parameter(ParameterSetName='FailViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.IEventHubIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

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

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru},

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
            Fail = 'Az.EventHub.private\Invoke-AzEventHubFailDisasterRecoveryConfigOver_Fail';
            FailViaIdentity = 'Az.EventHub.private\Invoke-AzEventHubFailDisasterRecoveryConfigOver_FailViaIdentity';
        }
        if (('Fail') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
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
