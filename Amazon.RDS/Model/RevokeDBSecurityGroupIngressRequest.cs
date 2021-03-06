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
 *  API Version: 2010-01-01
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Revokes ingress to a DBSecurityGroup for previously authorized IP ranges or EC2 Security Groups.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://rds.amazonaws.com/doc/2010-01-01/", IsNullable = false)]
    public class RevokeDBSecurityGroupIngressRequest
    {
        private string DBSecurityGroupNameField;
        private string CIDRIPField;
        private string EC2SecurityGroupNameField;
        private string EC2SecurityGroupOwnerIdField;

        /// <summary>
        /// Gets and sets the DBSecurityGroupName property.
        /// Name of the DB Security Group to revoke ingress from.
        /// </summary>
        [XmlElementAttribute(ElementName = "DBSecurityGroupName")]
        public string DBSecurityGroupName
        {
            get { return this.DBSecurityGroupNameField; }
            set { this.DBSecurityGroupNameField = value; }
        }

        /// <summary>
        /// Sets the DBSecurityGroupName property
        /// </summary>
        /// <param name="DBSecurityGroupName">Name of the DB Security Group to revoke ingress from.</param>
        /// <returns>this instance</returns>
        public RevokeDBSecurityGroupIngressRequest WithDBSecurityGroupName(string DBSecurityGroupName)
        {
            this.DBSecurityGroupNameField = DBSecurityGroupName;
            return this;
        }

        /// <summary>
        /// Checks if DBSecurityGroupName property is set
        /// </summary>
        /// <returns>true if DBSecurityGroupName property is set</returns>
        public bool IsSetDBSecurityGroupName()
        {
            return this.DBSecurityGroupNameField != null;
        }

        /// <summary>
        /// Gets and sets the CIDRIP property.
        /// IP range to revoke access from. Format: ddd.ddd.ddd.ddd/dd
        /// Condition: Must be a valid CIDR range. If CIDRIP is specified EC2SecurityGroupName and EC2SecurityGroupOwnerId
        /// cannot be provided.
        /// </summary>
        [XmlElementAttribute(ElementName = "CIDRIP")]
        public string CIDRIP
        {
            get { return this.CIDRIPField; }
            set { this.CIDRIPField = value; }
        }

        /// <summary>
        /// Sets the CIDRIP property
        /// </summary>
        /// <param name="CIDRIP">IP range to revoke access from. Format: ddd.ddd.ddd.ddd/dd
        /// Condition: Must be a valid CIDR range. If CIDRIP is specified EC2SecurityGroupName and EC2SecurityGroupOwnerId
        /// cannot be provided.</param>
        /// <returns>this instance</returns>
        public RevokeDBSecurityGroupIngressRequest WithCIDRIP(string CIDRIP)
        {
            this.CIDRIPField = CIDRIP;
            return this;
        }

        /// <summary>
        /// Checks if CIDRIP property is set
        /// </summary>
        /// <returns>true if CIDRIP property is set</returns>
        public bool IsSetCIDRIP()
        {
            return this.CIDRIPField != null;
        }

        /// <summary>
        /// Gets and sets the EC2SecurityGroupName property.
        /// Name of the EC2 Security Group to revoke access from. Conditions: If EC2SecurityGroupName is specified
        /// EC2SecurityGroupOwnerId must also be provided and CIDRIP cannot be provided.
        /// </summary>
        [XmlElementAttribute(ElementName = "EC2SecurityGroupName")]
        public string EC2SecurityGroupName
        {
            get { return this.EC2SecurityGroupNameField; }
            set { this.EC2SecurityGroupNameField = value; }
        }

        /// <summary>
        /// Sets the EC2SecurityGroupName property
        /// </summary>
        /// <param name="EC2SecurityGroupName">Name of the EC2 Security Group to revoke access from. Conditions: If EC2SecurityGroupName is specified
        /// EC2SecurityGroupOwnerId must also be provided and CIDRIP cannot be provided.</param>
        /// <returns>this instance</returns>
        public RevokeDBSecurityGroupIngressRequest WithEC2SecurityGroupName(string EC2SecurityGroupName)
        {
            this.EC2SecurityGroupNameField = EC2SecurityGroupName;
            return this;
        }

        /// <summary>
        /// Checks if EC2SecurityGroupName property is set
        /// </summary>
        /// <returns>true if EC2SecurityGroupName property is set</returns>
        public bool IsSetEC2SecurityGroupName()
        {
            return this.EC2SecurityGroupNameField != null;
        }

        /// <summary>
        /// Gets and sets the EC2SecurityGroupOwnerId property.
        /// AWS Account Number of the owner of the security group specified in the EC2SecurityGroupName parameter. The AWS Access Key
        /// ID is not an acceptable value.
        /// </summary>
        [XmlElementAttribute(ElementName = "EC2SecurityGroupOwnerId")]
        public string EC2SecurityGroupOwnerId
        {
            get { return this.EC2SecurityGroupOwnerIdField; }
            set { this.EC2SecurityGroupOwnerIdField = value; }
        }

        /// <summary>
        /// Sets the EC2SecurityGroupOwnerId property
        /// </summary>
        /// <param name="EC2SecurityGroupOwnerId">AWS Account Number of the owner of the security group specified in the EC2SecurityGroupName parameter. The AWS Access Key
        /// ID is not an acceptable value.</param>
        /// <returns>this instance</returns>
        public RevokeDBSecurityGroupIngressRequest WithEC2SecurityGroupOwnerId(string EC2SecurityGroupOwnerId)
        {
            this.EC2SecurityGroupOwnerIdField = EC2SecurityGroupOwnerId;
            return this;
        }

        /// <summary>
        /// Checks if EC2SecurityGroupOwnerId property is set
        /// </summary>
        /// <returns>true if EC2SecurityGroupOwnerId property is set</returns>
        public bool IsSetEC2SecurityGroupOwnerId()
        {
            return this.EC2SecurityGroupOwnerIdField != null;
        }

    }
}
