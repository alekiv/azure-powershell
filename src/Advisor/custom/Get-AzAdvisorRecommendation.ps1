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
Obtains details of a cached recommendation.
.Description
Obtains details of a cached recommendation.
.Link
https://docs.microsoft.com/powershell/module/az.advisor/Get-AzAdvisorRecommendation
#>
function Get-AzAdvisorRecommendation {
    [OutputType([Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IResourceRecommendationBase])]
    [CmdletBinding(DefaultParameterSetName='ListByFilter', PositionalBinding=$false)]
    param(
        [Parameter(ParameterSetName='ListByName', Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.Category('Path')]
        [System.String]
        # The resource group name.
        ${ResourceGroupName},

        [Parameter(ParameterSetName='ListById', Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.Category('Path')]
        [System.String]
        # The resource Id.
        ${ResourceId},

        [Parameter(ParameterSetName='ListById')]
        [Parameter(ParameterSetName='ListByName')]
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.Category('Path')]
        [System.String]
        # The category of recommendation.
        ${Category},

        [Parameter(ParameterSetName='GetById', Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.Category('Path')]
        [System.String]
        # The recommendation ID.
        ${Id},

        [Parameter(ParameterSetName='GetById', Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.Category('Path')]
        [System.String]
        # The fully qualified Azure Resource Manager identifier of the resource to which the recommendation applies.
        ${ResourceUri},

        [Parameter(ParameterSetName='GetViaIdentity1', Mandatory, ValueFromPipeline)]
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.Category('Path')]
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.IAdvisorIdentity]
        # Identity Parameter
        # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
        ${InputObject},

        [Parameter(ParameterSetName='ListByFilter')]
        [Parameter(ParameterSetName='ListById')]
        [Parameter(ParameterSetName='ListByName')]
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.Category('Path')]
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
        [System.String[]]
        # The Azure subscription ID.
        ${SubscriptionId},

        [Parameter(ParameterSetName='ListByFilter')]
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.Category('Query')]
        [System.String]
        # The filter to apply to the recommendations.
        # Filter can be applied to properties ['ResourceId', 'ResourceGroup', 'RecommendationTypeGuid', '[Category](#category)'] with operators ['eq', 'and', 'or'].
        # Example:
        # - $filter=Category eq 'Cost' and ResourceGroup eq 'MyResourceGroup'
        ${Filter},

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
        if ($PSBoundParameters.ContainsKey("ResourceId"))
            {
                $filter = "ResourceId eq '$ResourceId'"
                $null = $PSBoundParameters.Remove("ResourceId")
            }
        if ($PSBoundParameters.ContainsKey("ResourceGroupName"))
            {
                $filter = "ResourceGroup eq '$ResourceGroupName'"
                $null = $PSBoundParameters.Remove("ResourceGroupName")
            }
        if ($PSBoundParameters.ContainsKey("Category"))
            {
                if ($filter) {$filter = $filter + " and Category eq '$Category'"} else {$filter = "Category eq '$Category'"}
                $null = $PSBoundParameters.Remove("Category")
            }
        if ($filter) {$PSBoundParameters['Filter'] = $filter}
        . Az.Advisor.internal\Get-AzAdvisorRecommendation @PSBoundParameters
    }
}
