// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Grafana;

namespace Azure.ResourceManager.Grafana.Models
{
    /// <summary> List of private endpoint connection associated with the specified storage account. </summary>
    internal partial class GrafanaPrivateEndpointConnectionListResult
    {
        /// <summary> Initializes a new instance of GrafanaPrivateEndpointConnectionListResult. </summary>
        internal GrafanaPrivateEndpointConnectionListResult()
        {
            Value = new ChangeTrackingList<GrafanaPrivateEndpointConnectionData>();
        }

        /// <summary> Initializes a new instance of GrafanaPrivateEndpointConnectionListResult. </summary>
        /// <param name="value"> Array of private endpoint connections. </param>
        /// <param name="nextLink"> URL to get the next set of operation list results (if there are any). </param>
        internal GrafanaPrivateEndpointConnectionListResult(IReadOnlyList<GrafanaPrivateEndpointConnectionData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of private endpoint connections. </summary>
        public IReadOnlyList<GrafanaPrivateEndpointConnectionData> Value { get; }
        /// <summary> URL to get the next set of operation list results (if there are any). </summary>
        public string NextLink { get; }
    }
}
