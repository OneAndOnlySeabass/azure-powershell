// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Extensions;

    /// <summary>Continents Response</summary>
    public partial class ContinentsResponse :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IContinentsResponse,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IContinentsResponseInternal
    {

        /// <summary>Backing field for <see cref="Continent" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IContinentsResponseContinentsItem[] _continent;

        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IContinentsResponseContinentsItem[] Continent { get => this._continent; set => this._continent = value; }

        /// <summary>Backing field for <see cref="CountryOrRegion" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IContinentsResponseCountryOrRegionsItem[] _countryOrRegion;

        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IContinentsResponseCountryOrRegionsItem[] CountryOrRegion { get => this._countryOrRegion; set => this._countryOrRegion = value; }

        /// <summary>Creates an new <see cref="ContinentsResponse" /> instance.</summary>
        public ContinentsResponse()
        {

        }
    }
    /// Continents Response
    public partial interface IContinentsResponse :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IJsonSerializable
    {
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"continents",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IContinentsResponseContinentsItem) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IContinentsResponseContinentsItem[] Continent { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"countryOrRegions",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IContinentsResponseCountryOrRegionsItem) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IContinentsResponseCountryOrRegionsItem[] CountryOrRegion { get; set; }

    }
    /// Continents Response
    internal partial interface IContinentsResponseInternal

    {
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IContinentsResponseContinentsItem[] Continent { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IContinentsResponseCountryOrRegionsItem[] CountryOrRegion { get; set; }

    }
}