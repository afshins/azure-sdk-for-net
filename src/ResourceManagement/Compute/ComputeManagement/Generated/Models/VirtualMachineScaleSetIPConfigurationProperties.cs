// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Describes a virtual machine scale set network profile's IP
    /// configuration properties.
    /// </summary>
    public partial class VirtualMachineScaleSetIPConfigurationProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetIPConfigurationProperties class.
        /// </summary>
        public VirtualMachineScaleSetIPConfigurationProperties() { }

        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetIPConfigurationProperties class.
        /// </summary>
        public VirtualMachineScaleSetIPConfigurationProperties(ApiEntityReference subnet = default(ApiEntityReference), IList<SubResource> loadBalancerBackendAddressPools = default(IList<SubResource>))
        {
            Subnet = subnet;
            LoadBalancerBackendAddressPools = loadBalancerBackendAddressPools;
        }

        /// <summary>
        /// Gets or sets the subnet.
        /// </summary>
        [JsonProperty(PropertyName = "subnet")]
        public ApiEntityReference Subnet { get; set; }

        /// <summary>
        /// Gets or sets the load balancer backend address pools.
        /// </summary>
        [JsonProperty(PropertyName = "loadBalancerBackendAddressPools")]
        public IList<SubResource> LoadBalancerBackendAddressPools { get; set; }

    }
}