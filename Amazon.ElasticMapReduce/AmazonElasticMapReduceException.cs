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
 *  API Version: 2009-03-31
 */

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Net;
using System.Runtime.Serialization;
using System.Security.Permissions;

using Amazon.ElasticMapReduce.Model;

namespace Amazon.ElasticMapReduce
{
    /// <summary>
    /// Amazon Elastic Map Reduce  Exception provides details of errors
    /// returned by Amazon Elastic Map Reduce  service
    /// </summary>
    [Serializable]
    public class AmazonElasticMapReduceException : Exception, ISerializable
    {
        private string message = null;
        private HttpStatusCode statusCode = default(HttpStatusCode);
        private string errorCode = null;
        private string errorType = null;
        private string requestId = null;
        private string xml = null;

        /// <summary>
        /// Initializes a new AmazonElasticMapReduceException with default values.
        /// </summary>
        public AmazonElasticMapReduceException()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new AmazonElasticMapReduceException with a specified
        /// error message
        /// </summary>
        /// <param name="message">A message that describes the error</param>
        public AmazonElasticMapReduceException(string message) {
            this.message = message;
        }

        /// <summary>
        /// Initializes a new AmazonElasticMapReduceException with a specified error message
        /// and HTTP status code
        /// </summary>
        /// <param name="message">A message that describes the error</param>
        /// <param name="statusCode">HTTP status code for error response</param>
        public AmazonElasticMapReduceException(string message, HttpStatusCode statusCode) : this (message)
        {
            this.statusCode = statusCode;
        }

        /// <summary>
        /// Initializes a new AmazonElasticMapReduceException from the inner exception that is
        /// the cause of this exception.
        /// </summary>
        /// <param name="innerException">The nested exception that caused the AmazonElasticMapReduceException</param>
        public AmazonElasticMapReduceException(Exception innerException)
            : this(innerException.Message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new AmazonElasticMapReduceException with serialized data.
        /// </summary>
        /// <param name="info">The object that holds the serialized object data.
        /// </param>
        /// <param name="context">The contextual information about the source or destination.
        /// </param>
        protected AmazonElasticMapReduceException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            this.message = info.GetString("message");
            this.statusCode = (HttpStatusCode)info.GetValue("statusCode", typeof(HttpStatusCode));
            this.errorCode = info.GetString("errorCode");
            this.errorType = info.GetString("errorType");;
            this.requestId = info.GetString("requestId");
            this.xml = info.GetString("xml");
        }

        /// <summary>
        /// Serializes this instance of AmazonElasticMapReduceException.
        /// </summary>
        /// <param name="info">The object that holds the serialized object data.</param>
        /// <param name="context">The contextual information about the source or destination.
        /// </param>
        [SecurityPermissionAttribute(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("message", message, typeof(string));
            info.AddValue("statusCode", statusCode, typeof(HttpStatusCode));
            info.AddValue("errorCode", errorCode, typeof(string));
            info.AddValue("errorType", errorType, typeof(string));
            info.AddValue("requestId", requestId, typeof(string));
            info.AddValue("xml", xml, typeof(string));
            base.GetObjectData(info, context);
        }

        /// <summary>
        /// Constructs AmazonElasticMapReduceException with message and wrapped exception
        /// </summary>
        /// <param name="message">A message that describes the error</param>
        /// <param name="innerException">The nested exception that caused the AmazonS3Exception</param>
        public AmazonElasticMapReduceException(string message, Exception innerException)
            : base (message, innerException)
        {
            this.message = message;
            AmazonElasticMapReduceException ex = innerException as AmazonElasticMapReduceException;
            if (ex != null)
            {
                this.statusCode = ex.StatusCode;
                this.errorCode = ex.ErrorCode;
                this.errorType = ex.ErrorType;
                this.requestId = ex.RequestId;
                this.xml = ex.XML;
            }
        }

        /// <summary>
        /// Initializes an AmazonElasticMapReduceException with error information provided in an
        /// AmazonElasticMapReduce response.
        /// </summary>
        /// <param name="message">A message that describes the error</param>
        /// <param name="statusCode">HTTP status code for error response</param>
        /// <param name="errorCode">Error Code returned by the service</param>
        /// <param name="errorType">Error type. Possible types:  Sender, Receiver or Unknown</param>
        /// <param name="requestId">Request ID returned by the service</param>
        /// <param name="xml">Compete xml found in response</param>
        public AmazonElasticMapReduceException(string message, HttpStatusCode statusCode, string errorCode, string errorType, string requestId, string xml)
            : this (message, statusCode)
        {
            this.errorCode = errorCode;
            this.errorType = errorType;
            this.requestId = requestId;
            this.xml = xml;
        }

        /// <summary>
        /// Gets and sets of the ErrorCode property.
        /// </summary>
        public string ErrorCode
        {
            get { return this.errorCode; }
        }

        /// <summary>
        /// Gets and sets of the ErrorType property.
        /// </summary>
        public string ErrorType
        {
            get { return this.errorType; }
        }

        /// <summary>
        /// Gets error message
        /// </summary>
        public override string Message
        {
            get { return this.message; }
        }

        /// <summary>
        /// Gets status code returned by the service if available. If status
        /// code is set to -1, it means that status code was unavailable at the
        /// time exception was thrown
        /// </summary>
        public HttpStatusCode StatusCode
        {
            get { return this.statusCode; }
        }

        /// <summary>
        /// Gets XML returned by the service if available.
        /// </summary>
        public string XML
        {
            get { return this.xml; }
        }

        /// <summary>
        /// Gets Request ID returned by the service if available.
        /// </summary>
        public string RequestId
        {
            get { return this.requestId; }
        }
    }
}
