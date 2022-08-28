// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Automation.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The parameters supplied to the update variable operation.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class VariableUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the VariableUpdateParameters class.
        /// </summary>
        public VariableUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VariableUpdateParameters class.
        /// </summary>
        /// <param name="name">Gets or sets the name of the variable.</param>
        /// <param name="value">Gets or sets the value of the variable.</param>
        /// <param name="description">Gets or sets the description of the
        /// variable.</param>
        public VariableUpdateParameters(string name = default(string), string value = default(string), string description = default(string))
        {
            Name = name;
            Value = value;
            Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the variable.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the value of the variable.
        /// </summary>
        [JsonProperty(PropertyName = "properties.value")]
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets the description of the variable.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

    }
}
