// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Authorization.Models
{
    /// <summary> The approval settings. </summary>
    public partial class ApprovalSettings
    {
        /// <summary> Initializes a new instance of ApprovalSettings. </summary>
        public ApprovalSettings()
        {
            ApprovalStages = new ChangeTrackingList<ApprovalStage>();
        }

        /// <summary> Initializes a new instance of ApprovalSettings. </summary>
        /// <param name="isApprovalRequired"> Determines whether approval is required or not. </param>
        /// <param name="isApprovalRequiredForExtension"> Determines whether approval is required for assignment extension. </param>
        /// <param name="isRequestorJustificationRequired"> Determine whether requestor justification is required. </param>
        /// <param name="approvalMode"> The type of rule. </param>
        /// <param name="approvalStages"> The approval stages of the request. </param>
        internal ApprovalSettings(bool? isApprovalRequired, bool? isApprovalRequiredForExtension, bool? isRequestorJustificationRequired, ApprovalMode? approvalMode, IList<ApprovalStage> approvalStages)
        {
            IsApprovalRequired = isApprovalRequired;
            IsApprovalRequiredForExtension = isApprovalRequiredForExtension;
            IsRequestorJustificationRequired = isRequestorJustificationRequired;
            ApprovalMode = approvalMode;
            ApprovalStages = approvalStages;
        }

        /// <summary> Determines whether approval is required or not. </summary>
        public bool? IsApprovalRequired { get; set; }
        /// <summary> Determines whether approval is required for assignment extension. </summary>
        public bool? IsApprovalRequiredForExtension { get; set; }
        /// <summary> Determine whether requestor justification is required. </summary>
        public bool? IsRequestorJustificationRequired { get; set; }
        /// <summary> The type of rule. </summary>
        public ApprovalMode? ApprovalMode { get; set; }
        /// <summary> The approval stages of the request. </summary>
        public IList<ApprovalStage> ApprovalStages { get; }
    }
}
