
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
Create an in-memory object for MetricSettings.
.Description
Create an in-memory object for MetricSettings.

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20210501Preview.MetricSettings
.Link
https://docs.microsoft.com/powershell/module/az.DiagnosticSetting/new-AzDiagnosticSettingMetricSettingsObject
#>
function New-AzDiagnosticSettingMetricSettingsObject {
    [OutputType('Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20210501Preview.MetricSettings')]
    [CmdletBinding(PositionalBinding=$false)]
    Param(

        [Parameter(HelpMessage="Name of a Diagnostic Metric category for a resource type this setting is applied to. To obtain the list of Diagnostic metric categories for a resource, first perform a GET diagnostic settings operation.")]
        [string]
        $Category,
        [Parameter(Mandatory, HelpMessage="a value indicating whether this category is enabled.")]
        [bool]
        $Enabled,
        [Parameter(HelpMessage="the number of days for the retention in days. A value of 0 will retain the events indefinitely.")]
        [int]
        $RetentionPolicyDay,
        [Parameter(HelpMessage="a value indicating whether the retention policy is enabled.")]
        [bool]
        $RetentionPolicyEnabled,
        [Parameter(HelpMessage="the timegrain of the metric in ISO8601 format.")]
        [System.TimeSpan]
        $TimeGrain
    )

    process {
        $Object = [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20210501Preview.MetricSettings]::New()

        if ($PSBoundParameters.ContainsKey('Category')) {
            $Object.Category = $Category
        }
        if ($PSBoundParameters.ContainsKey('Enabled')) {
            $Object.Enabled = $Enabled
        }
        if ($PSBoundParameters.ContainsKey('RetentionPolicyDay')) {
            $Object.RetentionPolicyDay = $RetentionPolicyDay
        }
        if ($PSBoundParameters.ContainsKey('RetentionPolicyEnabled')) {
            $Object.RetentionPolicyEnabled = $RetentionPolicyEnabled
        }
        if ($PSBoundParameters.ContainsKey('TimeGrain')) {
            $Object.TimeGrain = $TimeGrain
        }
        return $Object
    }
}

