// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.GuestConfiguration.Models
{
    /// <summary> Information about the guest configuration assignment. </summary>
    public partial class AssignmentInfo
    {
        /// <summary> Initializes a new instance of AssignmentInfo. </summary>
        public AssignmentInfo()
        {
        }

        /// <summary> Initializes a new instance of AssignmentInfo. </summary>
        /// <param name="name"> Name of the guest configuration assignment. </param>
        /// <param name="configuration"> Information about the configuration. </param>
        internal AssignmentInfo(string name, ConfigurationInfo configuration)
        {
            Name = name;
            Configuration = configuration;
        }

        /// <summary> Name of the guest configuration assignment. </summary>
        public string Name { get; }
        /// <summary> Information about the configuration. </summary>
        public ConfigurationInfo Configuration { get; set; }
    }
}
