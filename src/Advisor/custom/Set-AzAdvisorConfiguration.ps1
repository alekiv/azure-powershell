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
Updates or creates the Azure Advisor Configuration.
.Description
Updates or creates the Azure Advisor Configuration.
.Link
https://docs.microsoft.com/powershell/module/az.advisor/Set-AzAdvisorConfiguration
#>
function Set-AzAdvisorConfiguration {
    [OutputType([Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IConfigData])]
    [CmdletBinding(DefaultParameterSetName='CreateByLCT', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    param(
        [Parameter(ParameterSetName='CreateByRG', Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.Category('Path')]
        [System.String]
        # The name of the Azure resource group.
        ${ResourceGroupName},
    
        [Parameter(ParameterSetName='CreateByLCT')]
        [Parameter(ParameterSetName='CreateByRG')]
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.Category('Path')]
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
        [System.String]
        # The Azure subscription ID.
        ${SubscriptionId},
    
        [Parameter(ParameterSetName='CreateByInputObject', Mandatory, ValueFromPipeline)]
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.Category('Path')]
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.IAdvisorIdentity]
        # Identity Parameter
        # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
        ${InputObject},
    
        [Parameter(ParameterSetName='CreateByLCT')]
        [Parameter(ParameterSetName='CreateByRG')]
        [Parameter(ParameterSetName='CreateByInputObject')]
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.Category('Body')]
        [System.Management.Automation.SwitchParameter]
        # Exclude the resource from Advisor evaluations.
        # Valid values: False (default) or True.
        ${Exclude},
    
        [Parameter(ParameterSetName='CreateByLCT')]
        [Parameter(ParameterSetName='CreateByInputObject')]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Advisor.Support.CpuThreshold])]
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.Support.CpuThreshold]
        # Minimum percentage threshold for Advisor low CPU utilization evaluation.
        # Valid only for subscriptions.
        # Valid values: 5 (default), 10, 15 or 20.
        ${LowCpuThreshold},
    
        [Parameter()]
        [Alias('AzureRMContext', 'AzureCredential')]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.Category('Azure')]
        [System.Management.Automation.PSObject]
        # The credentials, account, tenant, and subscription used for communication with Azure.
        ${DefaultProfile},
    
        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Wait for .NET debugger to attach
        ${Break},
    
        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.Category('Runtime')]
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.Runtime.SendAsyncStep[]]
        # SendAsync Pipeline Steps to be appended to the front of the pipeline
        ${HttpPipelineAppend},
    
        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.Category('Runtime')]
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.Runtime.SendAsyncStep[]]
        # SendAsync Pipeline Steps to be prepended to the front of the pipeline
        ${HttpPipelinePrepend},
    
        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.Category('Runtime')]
        [System.Uri]
        # The URI for the proxy server to use
        ${Proxy},
    
        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.Category('Runtime')]
        [System.Management.Automation.PSCredential]
        # Credentials for a proxy server to use for the remote call
        ${ProxyCredential},
    
        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Use the default credentials for the proxy
        ${ProxyUseDefaultCredentials}
    )
    
    process {
        if (!$Exclude) {$PSBoundParameters['Exclude'] = $False}
        . Az.advisor.internal\New-AzAdvisorConfiguration @PSBoundParameters
    }
}