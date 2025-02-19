// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The CloudServiceRoleListResult. </summary>
    internal partial class CloudServiceRoleListResult
    {
        /// <summary> Initializes a new instance of CloudServiceRoleListResult. </summary>
        /// <param name="value"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal CloudServiceRoleListResult(IEnumerable<CloudServiceRole> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of CloudServiceRoleListResult. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"></param>
        internal CloudServiceRoleListResult(IReadOnlyList<CloudServiceRole> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<CloudServiceRole> Value { get; }
        /// <summary> Gets the next link. </summary>
        public string NextLink { get; }
    }
}
