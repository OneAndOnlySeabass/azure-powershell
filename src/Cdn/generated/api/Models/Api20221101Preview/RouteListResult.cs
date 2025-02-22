// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Extensions;

    /// <summary>
    /// Result of the request to list routes. It contains a list of route objects and a URL link to get the next set of results.
    /// </summary>
    public partial class RouteListResult :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IRouteListResult,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IRouteListResultInternal
    {

        /// <summary>Internal Acessors for Value</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IRoute[] Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IRouteListResultInternal.Value { get => this._value; set { {_value = value;} } }

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>URL to get the next set of route objects if there are any.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IRoute[] _value;

        /// <summary>List of AzureFrontDoor routes within a profile.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IRoute[] Value { get => this._value; }

        /// <summary>Creates an new <see cref="RouteListResult" /> instance.</summary>
        public RouteListResult()
        {

        }
    }
    /// Result of the request to list routes. It contains a list of route objects and a URL link to get the next set of results.
    public partial interface IRouteListResult :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IJsonSerializable
    {
        /// <summary>URL to get the next set of route objects if there are any.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URL to get the next set of route objects if there are any.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>List of AzureFrontDoor routes within a profile.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"List of AzureFrontDoor routes within a profile.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IRoute) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IRoute[] Value { get;  }

    }
    /// Result of the request to list routes. It contains a list of route objects and a URL link to get the next set of results.
    internal partial interface IRouteListResultInternal

    {
        /// <summary>URL to get the next set of route objects if there are any.</summary>
        string NextLink { get; set; }
        /// <summary>List of AzureFrontDoor routes within a profile.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IRoute[] Value { get; set; }

    }
}