/*******************************************************************************
 * Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2009-11-25
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// Adds new instances to the LoadBalancer. Once the instance is registered, it starts receiving traffic and
    /// requests from the LoadBalancer. Any instance that is not in any of the Availability Zones registered for the LoadBalancer
    /// will be moved to the OutOfService state. It will move to the InService state when the Availability Zone is added to the
    /// LoadBalancer.
    ///
    /// You must have been the one who created the LoadBalancer. In other words, in order to successfully call this API, you must
    /// provide the same account credentials as those that were used to create the LoadBalancer.
    ///
    /// Completion of this API does not guarantee that operation has completed. Rather, it means that the request has been
    /// registered and the changes will happen shortly.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://elasticloadbalancing.amazonaws.com/doc/2009-11-25/", IsNullable = false)]
    public class RegisterInstancesWithLoadBalancerRequest
    {
        private string loadBalancerNameField;
        private List<Instance> instancesField;

        /// <summary>
        /// Gets and sets the LoadBalancerName property.
        /// The mnemonic name associated with the LoadBalancer. The name must be unique within your AWS account.
        /// </summary>
        [XmlElementAttribute(ElementName = "LoadBalancerName")]
        public string LoadBalancerName
        {
            get { return this.loadBalancerNameField; }
            set { this.loadBalancerNameField = value; }
        }

        /// <summary>
        /// Sets the LoadBalancerName property
        /// </summary>
        /// <param name="loadBalancerName">The mnemonic name associated with the LoadBalancer. The name must be unique within your AWS account.</param>
        /// <returns>this instance</returns>
        public RegisterInstancesWithLoadBalancerRequest WithLoadBalancerName(string loadBalancerName)
        {
            this.loadBalancerNameField = loadBalancerName;
            return this;
        }

        /// <summary>
        /// Checks if LoadBalancerName property is set
        /// </summary>
        /// <returns>true if LoadBalancerName property is set</returns>
        public bool IsSetLoadBalancerName()
        {
            return this.loadBalancerNameField != null;
        }

        /// <summary>
        /// Gets and sets the Instances property.
        /// List of instances IDs that should be registered with the LoadBalancer.
        /// </summary>
        [XmlElementAttribute(ElementName = "Instances")]
        public List<Instance> Instances
        {
            get
            {
                if (this.instancesField == null)
                {
                    this.instancesField = new List<Instance>();
                }
                return this.instancesField;
            }
            set { this.instancesField = value; }
        }

        /// <summary>
        /// Sets the Instances property
        /// </summary>
        /// <param name="list">List of instances IDs that should be registered with the LoadBalancer.</param>
        /// <returns>this instance</returns>
        public RegisterInstancesWithLoadBalancerRequest WithInstances(params Instance[] list)
        {
            foreach (Instance item in list)
            {
                Instances.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Instances property is set
        /// </summary>
        /// <returns>true if Instances property is set</returns>
        public bool IsSetInstances()
        {
            return (Instances.Count > 0);
        }

    }
}
