// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.HDInsight.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes a role on the cluster.
    /// </summary>
    public partial class Role
    {
        /// <summary>
        /// Initializes a new instance of the Role class.
        /// </summary>
        public Role()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Role class.
        /// </summary>
        /// <param name="name">The name of the role.</param>
        /// <param name="minInstanceCount">The minimum instance count of the
        /// cluster.</param>
        /// <param name="targetInstanceCount">The instance count of the
        /// cluster.</param>
        /// <param name="autoscaleConfiguration">The autoscale
        /// configurations.</param>
        /// <param name="hardwareProfile">The hardware profile.</param>
        /// <param name="osProfile">The operating system profile.</param>
        /// <param name="virtualNetworkProfile">The virtual network
        /// profile.</param>
        /// <param name="dataDisksGroups">The data disks groups for the
        /// role.</param>
        /// <param name="scriptActions">The list of script actions on the
        /// role.</param>
        public Role(string name = default(string), int? minInstanceCount = default(int?), int? targetInstanceCount = default(int?), Autoscale autoscaleConfiguration = default(Autoscale), HardwareProfile hardwareProfile = default(HardwareProfile), OsProfile osProfile = default(OsProfile), VirtualNetworkProfile virtualNetworkProfile = default(VirtualNetworkProfile), IList<DataDisksGroups> dataDisksGroups = default(IList<DataDisksGroups>), IList<ScriptAction> scriptActions = default(IList<ScriptAction>))
        {
            Name = name;
            MinInstanceCount = minInstanceCount;
            TargetInstanceCount = targetInstanceCount;
            AutoscaleConfiguration = autoscaleConfiguration;
            HardwareProfile = hardwareProfile;
            OsProfile = osProfile;
            VirtualNetworkProfile = virtualNetworkProfile;
            DataDisksGroups = dataDisksGroups;
            ScriptActions = scriptActions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the role.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the minimum instance count of the cluster.
        /// </summary>
        [JsonProperty(PropertyName = "minInstanceCount")]
        public int? MinInstanceCount { get; set; }

        /// <summary>
        /// Gets or sets the instance count of the cluster.
        /// </summary>
        [JsonProperty(PropertyName = "targetInstanceCount")]
        public int? TargetInstanceCount { get; set; }

        /// <summary>
        /// Gets or sets the autoscale configurations.
        /// </summary>
        [JsonProperty(PropertyName = "autoscale")]
        public Autoscale AutoscaleConfiguration { get; set; }

        /// <summary>
        /// Gets or sets the hardware profile.
        /// </summary>
        [JsonProperty(PropertyName = "hardwareProfile")]
        public HardwareProfile HardwareProfile { get; set; }

        /// <summary>
        /// Gets or sets the operating system profile.
        /// </summary>
        [JsonProperty(PropertyName = "osProfile")]
        public OsProfile OsProfile { get; set; }

        /// <summary>
        /// Gets or sets the virtual network profile.
        /// </summary>
        [JsonProperty(PropertyName = "virtualNetworkProfile")]
        public VirtualNetworkProfile VirtualNetworkProfile { get; set; }

        /// <summary>
        /// Gets or sets the data disks groups for the role.
        /// </summary>
        [JsonProperty(PropertyName = "dataDisksGroups")]
        public IList<DataDisksGroups> DataDisksGroups { get; set; }

        /// <summary>
        /// Gets or sets the list of script actions on the role.
        /// </summary>
        [JsonProperty(PropertyName = "scriptActions")]
        public IList<ScriptAction> ScriptActions { get; set; }

    }
}
