// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> The network access type for operating on the resources in the Batch account. </summary>
    public enum PublicNetworkAccessType
    {
        /// <summary> Enables connectivity to Azure Batch through public DNS. </summary>
        Enabled,
        /// <summary> Disables public connectivity and enables private connectivity to Azure Batch Service through private endpoint resource. </summary>
        Disabled
    }
}
