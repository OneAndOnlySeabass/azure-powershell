
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
Create an in-memory object for ProfileUpgradeParameters.
.Description
Create an in-memory object for ProfileUpgradeParameters.

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.ProfileUpgradeParameters
.Link
https://learn.microsoft.com/powershell/module/Az.Cdn/new-AzFrontDoorCdnProfileUpgradeParametersObject
#>
function New-AzFrontDoorCdnProfileUpgradeParametersObject {
    [OutputType('Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.ProfileUpgradeParameters')]
    [CmdletBinding(PositionalBinding=$false)]
    Param(

        [Parameter(Mandatory, HelpMessage="Web Application Firewall (WAF) and security policy mapping for the profile upgrade.")]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IProfileChangeSkuWafMapping[]]
        $WafMappingList
    )

    process {
        $Object = [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.ProfileUpgradeParameters]::New()

        if ($PSBoundParameters.ContainsKey('WafMappingList')) {
            $Object.WafMappingList = $WafMappingList
        }
        return $Object
    }
}

