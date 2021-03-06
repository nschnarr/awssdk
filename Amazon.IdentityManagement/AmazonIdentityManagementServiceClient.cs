/*
 * Copyright 2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;

using Amazon.IdentityManagement.Model;
using Amazon.IdentityManagement.Model.Transform;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;


namespace Amazon.IdentityManagement
{
    /// <summary>
    /// Implemenation for accessing AmazonIdentityManagementService.
    ///  
    /// AWS Identity and Access Management <para>AWS Identity and Access
    /// Management (IAM) is a web service that enables Amazon Web Services
    /// (AWS) customers to manage users and user permissions under their AWS
    /// account.</para> <para>This is the AWS Identity and Access Management
    /// API Reference. This guide describes who should read this guide and
    /// other resources related to IAM. </para> <para>Use of this guide
    /// assumes you are familiar with the following:</para>
    /// <ul>
    /// <li>Basic understanding of web services (for information, go to W3
    /// Schools Web Services Tutorial at <a
    /// href="http://www.w3schools.com/webservices/default.asp">
    /// http://www.w3schools.com/webservices/default.asp </a> ).</li>
    /// <li>XML (for information, go to W3 Schools XML Tutorial at <a
    /// href="http://www.w3schools.com/xml/default.asp">
    /// http://www.w3schools.com/xml/default.asp </a> ).</li>
    /// <li>JSON (for information, go to <a href="http://json.org">
    /// http://json.org </a> )</li>
    /// <li>The specific AWS products you are using or plan to use (e.g.,
    /// Amazon Elastic Compute Cloud (Amazon EC2), Amazon Simple Storage
    /// Service (Amazon S3), etc.)</li>
    /// 
    /// </ul>
    /// <para>If you're new to AWS and need additional technical information
    /// about a specific AWS product, you can find the product's technical
    /// documentation at <a href="http://aws.amazon.com/documentation/">
    /// http://aws.amazon.com/documentation/ </a> .</para> <para>We will refer
    /// to Amazon AWS Identity and Access Management using the the abbreviated
    /// form IAM; all copyrights and legal protections still apply.</para>
    /// </summary>
    public class AmazonIdentityManagementServiceClient : AmazonWebServiceClient, AmazonIdentityManagementService
    {
    
    
        AbstractAWSSigner signer = new QueryStringSigner();

        /// <summary>
        /// Constructs AmazonIdentityManagementServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonIdentityManagementServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIdentityManagementServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIdentityManagementServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonS3 Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="config">The AmazonIdentityManagementServiceClient Configuration Object</param>
        public AmazonIdentityManagementServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonIdentityManagementServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }
        
   

         /// <summary>
         /// <para>Lists the groups that have the specified path prefix.</para>
         /// <para>You can paginate the results using the <c>MaxItems</c> and
         /// <c>Marker</c> parameters.</para>
         /// </summary>
         /// 
         /// <param name="listGroupsRequest">Container for the necessary parameters
         ///           to execute the ListGroups service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <returns>The response from the ListGroups service method, as returned
         ///         by AmazonIdentityManagementService.</returns>
         /// 
        public ListGroupsResponse ListGroups(ListGroupsRequest listGroupsRequest) 
        {           
            IRequest<ListGroupsRequest> request = new ListGroupsRequestMarshaller().Marshall(listGroupsRequest);
            ListGroupsResponse response = Invoke<ListGroupsRequest, ListGroupsResponse> (request, this.signer, ListGroupsResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para>Deletes the access key associated with the specified
         /// user.</para> <para>If the <c>UserName</c> field is not specified, the
         /// UserName is determined implicitly based on the AWS Access Key ID used
         /// to sign the request. Because this action works for access keys under
         /// the account, this API can be used to manage root credentials even if
         /// the account has no associated users.</para>
         /// </summary>
         /// 
         /// <param name="deleteAccessKeyRequest">Container for the necessary
         ///           parameters to execute the DeleteAccessKey service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <exception cref="NoSuchEntityException"/>
        public DeleteAccessKeyResponse DeleteAccessKey(DeleteAccessKeyRequest deleteAccessKeyRequest) 
        {           
            IRequest<DeleteAccessKeyRequest> request = new DeleteAccessKeyRequestMarshaller().Marshall(deleteAccessKeyRequest);
            DeleteAccessKeyResponse response = Invoke<DeleteAccessKeyRequest, DeleteAccessKeyResponse> (request, this.signer, DeleteAccessKeyResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para>Returns information about the signing certificates associated
         /// with the specified user. If there are none, the action returns an
         /// empty list.</para> <para>Although each user is limited to a small
         /// number of signing certificates, you can still paginate the results
         /// using the <c>MaxItems</c> and <c>Marker</c> parameters.</para>
         /// <para>If the <c>UserName</c> field is not specified, the UserName is
         /// determined implicitly based on the AWS Access Key ID used to sign the
         /// request. Because this action works for access keys under the account,
         /// this API can be used to manage root credentials even if the account
         /// has no associated users.</para>
         /// </summary>
         /// 
         /// <param name="listSigningCertificatesRequest">Container for the
         ///           necessary parameters to execute the ListSigningCertificates service
         ///           method on AmazonIdentityManagementService.</param>
         /// 
         /// <returns>The response from the ListSigningCertificates service method,
         ///         as returned by AmazonIdentityManagementService.</returns>
         /// 
         /// <exception cref="NoSuchEntityException"/>
        public ListSigningCertificatesResponse ListSigningCertificates(ListSigningCertificatesRequest listSigningCertificatesRequest) 
        {           
            IRequest<ListSigningCertificatesRequest> request = new ListSigningCertificatesRequestMarshaller().Marshall(listSigningCertificatesRequest);
            ListSigningCertificatesResponse response = Invoke<ListSigningCertificatesRequest, ListSigningCertificatesResponse> (request, this.signer, ListSigningCertificatesResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para>Uploads an X.509 signing certificate and associates it with the
         /// specified user. Some AWS services use X.509 signing certificates to
         /// validate requests that are signed with a corresponding private key.
         /// When you upload the certificate, its default status is Active.</para>
         /// <para>If the <c>UserName</c> field is not specified, the UserName is
         /// determined implicitly based on the AWS Access Key ID used to sign the
         /// request. Because this action works for access keys under the account,
         /// this API can be used to manage root credentials even if the account
         /// has no associated users.</para> <para><b>NOTE:</b>Because the body of
         /// a X.509 certificate can be large, you should use POST rather than GET
         /// when calling UploadSigningCertificate. For more information, see Using
         /// the Query API in the AWS Identity and Access Management User
         /// Guide.</para>
         /// </summary>
         /// 
         /// <param name="uploadSigningCertificateRequest">Container for the
         ///           necessary parameters to execute the UploadSigningCertificate service
         ///           method on AmazonIdentityManagementService.</param>
         /// 
         /// <returns>The response from the UploadSigningCertificate service
         ///         method, as returned by AmazonIdentityManagementService.</returns>
         /// 
         /// <exception cref="MalformedCertificateException"/>
         /// <exception cref="NoSuchEntityException"/>
         /// <exception cref="LimitExceededException"/>
         /// <exception cref="EntityAlreadyExistsException"/>
        public UploadSigningCertificateResponse UploadSigningCertificate(UploadSigningCertificateRequest uploadSigningCertificateRequest) 
        {           
            IRequest<UploadSigningCertificateRequest> request = new UploadSigningCertificateRequestMarshaller().Marshall(uploadSigningCertificateRequest);
            UploadSigningCertificateResponse response = Invoke<UploadSigningCertificateRequest, UploadSigningCertificateResponse> (request, this.signer, UploadSigningCertificateResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para>Deletes the specified policy associated with the specified
         /// user.</para>
         /// </summary>
         /// 
         /// <param name="deleteUserPolicyRequest">Container for the necessary
         ///           parameters to execute the DeleteUserPolicy service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <exception cref="NoSuchEntityException"/>
        public DeleteUserPolicyResponse DeleteUserPolicy(DeleteUserPolicyRequest deleteUserPolicyRequest) 
        {           
            IRequest<DeleteUserPolicyRequest> request = new DeleteUserPolicyRequestMarshaller().Marshall(deleteUserPolicyRequest);
            DeleteUserPolicyResponse response = Invoke<DeleteUserPolicyRequest, DeleteUserPolicyResponse> (request, this.signer, DeleteUserPolicyResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para>Adds (or updates) a policy document associated with the
         /// specified user. For information about how to write a policy, refer to
         /// the <a href="http://aws.amazon.com/documentation/"> AWS Identity and
         /// Access Management User Guide </a> .</para> <para>For information about
         /// limits on the number of policies you can associate with a user, see
         /// Limitations on AWS IAM Entities in the <a
         /// href="http://aws.amazon.com/documentation/"> AWS Identity and Access
         /// Management User Guide </a> .</para> <para><b>NOTE:</b>Because policy
         /// documents can be large, you should use POST rather than GET when
         /// calling PutUserPolicy. For more information, see Using the Query API
         /// in the AWS Identity and Access Management User Guide.</para>
         /// </summary>
         /// 
         /// <param name="putUserPolicyRequest">Container for the necessary
         ///           parameters to execute the PutUserPolicy service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <exception cref="MalformedPolicyDocumentException"/>
         /// <exception cref="NoSuchEntityException"/>
         /// <exception cref="LimitExceededException"/>
        public PutUserPolicyResponse PutUserPolicy(PutUserPolicyRequest putUserPolicyRequest) 
        {           
            IRequest<PutUserPolicyRequest> request = new PutUserPolicyRequestMarshaller().Marshall(putUserPolicyRequest);
            PutUserPolicyResponse response = Invoke<PutUserPolicyRequest, PutUserPolicyResponse> (request, this.signer, PutUserPolicyResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para>Retrieves the specified policy document for the specified user.
         /// The returned policy is URL-encoded according to RFC 3986. For more
         /// information about RFC 3986, go to
         /// http://www.faqs.org/rfcs/rfc3986.html.</para>
         /// </summary>
         /// 
         /// <param name="getUserPolicyRequest">Container for the necessary
         ///           parameters to execute the GetUserPolicy service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <returns>The response from the GetUserPolicy service method, as
         ///         returned by AmazonIdentityManagementService.</returns>
         /// 
         /// <exception cref="NoSuchEntityException"/>
        public GetUserPolicyResponse GetUserPolicy(GetUserPolicyRequest getUserPolicyRequest) 
        {           
            IRequest<GetUserPolicyRequest> request = new GetUserPolicyRequestMarshaller().Marshall(getUserPolicyRequest);
            GetUserPolicyResponse response = Invoke<GetUserPolicyRequest, GetUserPolicyResponse> (request, this.signer, GetUserPolicyResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para>Updates the login profile for the specified user. Use this API
         /// to change the user's password.</para>
         /// </summary>
         /// 
         /// <param name="updateLoginProfileRequest">Container for the necessary
         ///           parameters to execute the UpdateLoginProfile service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <exception cref="EntityTemporarilyUnmodifiableException"/>
         /// <exception cref="NoSuchEntityException"/>
        public UpdateLoginProfileResponse UpdateLoginProfile(UpdateLoginProfileRequest updateLoginProfileRequest) 
        {           
            IRequest<UpdateLoginProfileRequest> request = new UpdateLoginProfileRequestMarshaller().Marshall(updateLoginProfileRequest);
            UpdateLoginProfileResponse response = Invoke<UpdateLoginProfileRequest, UpdateLoginProfileResponse> (request, this.signer, UpdateLoginProfileResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para>Updates the name and/or the path of the specified user.</para>
         /// <para><b>IMPORTANT:</b> You should understand the implications of
         /// changing a user's path or name. For more information, see Renaming
         /// Users and Groups in the AWS Identity and Access Management User Guide.
         /// </para>
         /// </summary>
         /// 
         /// <param name="updateUserRequest">Container for the necessary parameters
         ///           to execute the UpdateUser service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <exception cref="EntityTemporarilyUnmodifiableException"/>
         /// <exception cref="NoSuchEntityException"/>
         /// <exception cref="EntityAlreadyExistsException"/>
        public UpdateUserResponse UpdateUser(UpdateUserRequest updateUserRequest) 
        {           
            IRequest<UpdateUserRequest> request = new UpdateUserRequestMarshaller().Marshall(updateUserRequest);
            UpdateUserResponse response = Invoke<UpdateUserRequest, UpdateUserResponse> (request, this.signer, UpdateUserResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para>Deletes the login profile for the specified user, which
         /// terminates the user's ability to access AWS services through the IAM
         /// login page.</para> <para><b>IMPORTANT:</b>Deleting a user's login
         /// profile does not prevent a user from accessing IAM through the command
         /// line interface or the API. To prevent a user from accessing IAM
         /// through the command line interface or the API you must either make the
         /// access key inactive or delete it. For more information about making
         /// keys inactive or deleting them, see UpdateAccessKey and
         /// DeleteAccessKey. </para>
         /// </summary>
         /// 
         /// <param name="deleteLoginProfileRequest">Container for the necessary
         ///           parameters to execute the DeleteLoginProfile service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <exception cref="EntityTemporarilyUnmodifiableException"/>
         /// <exception cref="NoSuchEntityException"/>
        public DeleteLoginProfileResponse DeleteLoginProfile(DeleteLoginProfileRequest deleteLoginProfileRequest) 
        {           
            IRequest<DeleteLoginProfileRequest> request = new DeleteLoginProfileRequestMarshaller().Marshall(deleteLoginProfileRequest);
            DeleteLoginProfileResponse response = Invoke<DeleteLoginProfileRequest, DeleteLoginProfileResponse> (request, this.signer, DeleteLoginProfileResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para>Changes the status of the specified signing certificate from
         /// active to disabled, or vice versa. This action can be used to disable
         /// a user's signing certificate as part of a certificate rotation
         /// workflow.</para> <para>If the <c>UserName</c> field is not specified,
         /// the UserName is determined implicitly based on the AWS Access Key ID
         /// used to sign the request. Because this action works for access keys
         /// under the account, this API can be used to manage root credentials
         /// even if the account has no associated users.</para> <para>For
         /// information about rotating certificates, see Managing Keys and
         /// Certificates in the <a href="http://aws.amazon.com/documentation/">
         /// AWS Identity and Access Management User Guide </a> .</para>
         /// </summary>
         /// 
         /// <param name="updateSigningCertificateRequest">Container for the
         ///           necessary parameters to execute the UpdateSigningCertificate service
         ///           method on AmazonIdentityManagementService.</param>
         /// 
         /// <exception cref="NoSuchEntityException"/>
        public UpdateSigningCertificateResponse UpdateSigningCertificate(UpdateSigningCertificateRequest updateSigningCertificateRequest) 
        {           
            IRequest<UpdateSigningCertificateRequest> request = new UpdateSigningCertificateRequestMarshaller().Marshall(updateSigningCertificateRequest);
            UpdateSigningCertificateResponse response = Invoke<UpdateSigningCertificateRequest, UpdateSigningCertificateResponse> (request, this.signer, UpdateSigningCertificateResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para>Lists the users that have the specified path prefix. If there
         /// are none, the action returns an empty list.</para> <para>You can
         /// paginate the results using the <c>MaxItems</c> and <c>Marker</c>
         /// parameters.</para>
         /// </summary>
         /// 
         /// <param name="listUsersRequest">Container for the necessary parameters
         ///           to execute the ListUsers service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <returns>The response from the ListUsers service method, as returned
         ///         by AmazonIdentityManagementService.</returns>
         /// 
        public ListUsersResponse ListUsers(ListUsersRequest listUsersRequest) 
        {           
            IRequest<ListUsersRequest> request = new ListUsersRequestMarshaller().Marshall(listUsersRequest);
            ListUsersResponse response = Invoke<ListUsersRequest, ListUsersResponse> (request, this.signer, ListUsersResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para>Deletes the specified policy that is associated with the
         /// specified group.</para>
         /// </summary>
         /// 
         /// <param name="deleteGroupPolicyRequest">Container for the necessary
         ///           parameters to execute the DeleteGroupPolicy service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <exception cref="NoSuchEntityException"/>
        public DeleteGroupPolicyResponse DeleteGroupPolicy(DeleteGroupPolicyRequest deleteGroupPolicyRequest) 
        {           
            IRequest<DeleteGroupPolicyRequest> request = new DeleteGroupPolicyRequestMarshaller().Marshall(deleteGroupPolicyRequest);
            DeleteGroupPolicyResponse response = Invoke<DeleteGroupPolicyRequest, DeleteGroupPolicyResponse> (request, this.signer, DeleteGroupPolicyResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para>Updates the name and/or the path of the specified group.</para>
         /// <para><b>IMPORTANT:</b> You should understand the implications of
         /// changing a group's path or name. For more information, see Renaming
         /// Users and Groups in the AWS Identity and Access Management User Guide.
         /// </para>
         /// </summary>
         /// 
         /// <param name="updateGroupRequest">Container for the necessary
         ///           parameters to execute the UpdateGroup service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <exception cref="NoSuchEntityException"/>
        public UpdateGroupResponse UpdateGroup(UpdateGroupRequest updateGroupRequest) 
        {           
            IRequest<UpdateGroupRequest> request = new UpdateGroupRequestMarshaller().Marshall(updateGroupRequest);
            UpdateGroupResponse response = Invoke<UpdateGroupRequest, UpdateGroupResponse> (request, this.signer, UpdateGroupResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para>Adds (or updates) a policy document associated with the
         /// specified group. For information about how to write a policy, refer to
         /// the <a href="http://aws.amazon.com/documentation/"> AWS Identity and
         /// Access Management User Guide </a> .</para> <para>For information about
         /// limits on the number of policies you can associate with a group, see
         /// Limitations on AWS IAM Entities in the <a
         /// href="http://aws.amazon.com/documentation/"> AWS Identity and Access
         /// Management User Guide </a> .</para> <para><b>NOTE:</b>Because policy
         /// documents can be large, you should use POST rather than GET when
         /// calling PutGroupPolicy. For more information, see Using the Query API
         /// in the AWS Identity and Access Management User Guide.</para>
         /// </summary>
         /// 
         /// <param name="putGroupPolicyRequest">Container for the necessary
         ///           parameters to execute the PutGroupPolicy service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <exception cref="MalformedPolicyDocumentException"/>
         /// <exception cref="NoSuchEntityException"/>
         /// <exception cref="LimitExceededException"/>
         /// <exception cref="EntityAlreadyExistsException"/>
        public PutGroupPolicyResponse PutGroupPolicy(PutGroupPolicyRequest putGroupPolicyRequest) 
        {           
            IRequest<PutGroupPolicyRequest> request = new PutGroupPolicyRequestMarshaller().Marshall(putGroupPolicyRequest);
            PutGroupPolicyResponse response = Invoke<PutGroupPolicyRequest, PutGroupPolicyResponse> (request, this.signer, PutGroupPolicyResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para>Creates a new user for your account.</para> <para>For
         /// information about limitations on the number of users you can create,
         /// see Limitations on AWS IAM Entities in the <a
         /// href="http://aws.amazon.com/documentation/"> AWS Identity and Access
         /// Management User Guide </a> .</para>
         /// </summary>
         /// 
         /// <param name="createUserRequest">Container for the necessary parameters
         ///           to execute the CreateUser service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <returns>The response from the CreateUser service method, as returned
         ///         by AmazonIdentityManagementService.</returns>
         /// 
         /// <exception cref="NoSuchEntityException"/>
         /// <exception cref="LimitExceededException"/>
         /// <exception cref="EntityAlreadyExistsException"/>
        public CreateUserResponse CreateUser(CreateUserRequest createUserRequest) 
        {           
            IRequest<CreateUserRequest> request = new CreateUserRequestMarshaller().Marshall(createUserRequest);
            CreateUserResponse response = Invoke<CreateUserRequest, CreateUserResponse> (request, this.signer, CreateUserResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para>Deletes the specified signing certificate associated with the
         /// specified user.</para> <para>If the <c>UserName</c> field is not
         /// specified, the UserName is determined implicitly based on the AWS
         /// Access Key ID used to sign the request. Because this action works for
         /// access keys under the account, this API can be used to manage root
         /// credentials even if the account has no associated users.</para>
         /// </summary>
         /// 
         /// <param name="deleteSigningCertificateRequest">Container for the
         ///           necessary parameters to execute the DeleteSigningCertificate service
         ///           method on AmazonIdentityManagementService.</param>
         /// 
         /// <exception cref="NoSuchEntityException"/>
        public DeleteSigningCertificateResponse DeleteSigningCertificate(DeleteSigningCertificateRequest deleteSigningCertificateRequest) 
        {           
            IRequest<DeleteSigningCertificateRequest> request = new DeleteSigningCertificateRequestMarshaller().Marshall(deleteSigningCertificateRequest);
            DeleteSigningCertificateResponse response = Invoke<DeleteSigningCertificateRequest, DeleteSigningCertificateResponse> (request, this.signer, DeleteSigningCertificateResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para>Enables the specified MFA device and associates it with the
         /// specified user. Once enabled, the MFA device is required for every
         /// subsequent login by the user associated with the device.</para>
         /// </summary>
         /// 
         /// <param name="enableMFADeviceRequest">Container for the necessary
         ///           parameters to execute the EnableMFADevice service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <exception cref="EntityTemporarilyUnmodifiableException"/>
         /// <exception cref="NoSuchEntityException"/>
         /// <exception cref="InvalidAuthenticationCodeException"/>
         /// <exception cref="LimitExceededException"/>
         /// <exception cref="EntityAlreadyExistsException"/>
        public EnableMFADeviceResponse EnableMFADevice(EnableMFADeviceRequest enableMFADeviceRequest) 
        {           
            IRequest<EnableMFADeviceRequest> request = new EnableMFADeviceRequestMarshaller().Marshall(enableMFADeviceRequest);
            EnableMFADeviceResponse response = Invoke<EnableMFADeviceRequest, EnableMFADeviceResponse> (request, this.signer, EnableMFADeviceResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para>Lists the names of the policies associated with the specified
         /// user. If there are none, the action returns an empty list.</para>
         /// <para>You can paginate the results using the <c>MaxItems</c> and
         /// <c>Marker</c> parameters.</para>
         /// </summary>
         /// 
         /// <param name="listUserPoliciesRequest">Container for the necessary
         ///           parameters to execute the ListUserPolicies service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <returns>The response from the ListUserPolicies service method, as
         ///         returned by AmazonIdentityManagementService.</returns>
         /// 
         /// <exception cref="NoSuchEntityException"/>
        public ListUserPoliciesResponse ListUserPolicies(ListUserPoliciesRequest listUserPoliciesRequest) 
        {           
            IRequest<ListUserPoliciesRequest> request = new ListUserPoliciesRequestMarshaller().Marshall(listUserPoliciesRequest);
            ListUserPoliciesResponse response = Invoke<ListUserPoliciesRequest, ListUserPoliciesResponse> (request, this.signer, ListUserPoliciesResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para>Returns information about the Access Key IDs associated with the
         /// specified user. If there are none, the action returns an empty
         /// list.</para> <para>Although each user is limited to a small number of
         /// keys, you can still paginate the results using the <c>MaxItems</c> and
         /// <c>Marker</c> parameters.</para> <para>If the <c>UserName</c> field is
         /// not specified, the UserName is determined implicitly based on the AWS
         /// Access Key ID used to sign the request. Because this action works for
         /// access keys under the account, this API can be used to manage root
         /// credentials even if the account has no associated users.</para>
         /// <para><b>NOTE:</b>To ensure the security of your account, the secret
         /// access key is accesible only during key and user creation.</para>
         /// </summary>
         /// 
         /// <param name="listAccessKeysRequest">Container for the necessary
         ///           parameters to execute the ListAccessKeys service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <returns>The response from the ListAccessKeys service method, as
         ///         returned by AmazonIdentityManagementService.</returns>
         /// 
         /// <exception cref="NoSuchEntityException"/>
        public ListAccessKeysResponse ListAccessKeys(ListAccessKeysRequest listAccessKeysRequest) 
        {           
            IRequest<ListAccessKeysRequest> request = new ListAccessKeysRequestMarshaller().Marshall(listAccessKeysRequest);
            ListAccessKeysResponse response = Invoke<ListAccessKeysRequest, ListAccessKeysResponse> (request, this.signer, ListAccessKeysResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para>Retrieves the login profile for the specified user.</para>
         /// </summary>
         /// 
         /// <param name="getLoginProfileRequest">Container for the necessary
         ///           parameters to execute the GetLoginProfile service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <returns>The response from the GetLoginProfile service method, as
         ///         returned by AmazonIdentityManagementService.</returns>
         /// 
         /// <exception cref="NoSuchEntityException"/>
        public GetLoginProfileResponse GetLoginProfile(GetLoginProfileRequest getLoginProfileRequest) 
        {           
            IRequest<GetLoginProfileRequest> request = new GetLoginProfileRequestMarshaller().Marshall(getLoginProfileRequest);
            GetLoginProfileResponse response = Invoke<GetLoginProfileRequest, GetLoginProfileResponse> (request, this.signer, GetLoginProfileResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para>Lists the groups the specified user belongs to.</para> <para>You
         /// can paginate the results using the <c>MaxItems</c> and <c>Marker</c>
         /// parameters.</para>
         /// </summary>
         /// 
         /// <param name="listGroupsForUserRequest">Container for the necessary
         ///           parameters to execute the ListGroupsForUser service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <returns>The response from the ListGroupsForUser service method, as
         ///         returned by AmazonIdentityManagementService.</returns>
         /// 
         /// <exception cref="NoSuchEntityException"/>
        public ListGroupsForUserResponse ListGroupsForUser(ListGroupsForUserRequest listGroupsForUserRequest) 
        {           
            IRequest<ListGroupsForUserRequest> request = new ListGroupsForUserRequestMarshaller().Marshall(listGroupsForUserRequest);
            ListGroupsForUserResponse response = Invoke<ListGroupsForUserRequest, ListGroupsForUserResponse> (request, this.signer, ListGroupsForUserResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para>Creates a new group.</para> <para>For information about the
         /// number of groups you can create, see Limitations on AWS IAM Entities
         /// in the <a href="http://aws.amazon.com/documentation/"> AWS Identity
         /// and Access Management User Guide </a> .</para>
         /// </summary>
         /// 
         /// <param name="createGroupRequest">Container for the necessary
         ///           parameters to execute the CreateGroup service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <returns>The response from the CreateGroup service method, as returned
         ///         by AmazonIdentityManagementService.</returns>
         /// 
         /// <exception cref="NoSuchEntityException"/>
         /// <exception cref="LimitExceededException"/>
         /// <exception cref="EntityAlreadyExistsException"/>
        public CreateGroupResponse CreateGroup(CreateGroupRequest createGroupRequest) 
        {           
            IRequest<CreateGroupRequest> request = new CreateGroupRequestMarshaller().Marshall(createGroupRequest);
            CreateGroupResponse response = Invoke<CreateGroupRequest, CreateGroupResponse> (request, this.signer, CreateGroupResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para>Deletes the specified user. The user must not belong to any
         /// groups, have any keys or signing certificates, or have any attached
         /// policies.</para>
         /// </summary>
         /// 
         /// <param name="deleteUserRequest">Container for the necessary parameters
         ///           to execute the DeleteUser service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <exception cref="NoSuchEntityException"/>
         /// <exception cref="DeleteConflictException"/>
        public DeleteUserResponse DeleteUser(DeleteUserRequest deleteUserRequest) 
        {           
            IRequest<DeleteUserRequest> request = new DeleteUserRequestMarshaller().Marshall(deleteUserRequest);
            DeleteUserResponse response = Invoke<DeleteUserRequest, DeleteUserResponse> (request, this.signer, DeleteUserResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para>Retrieves the specified policy document for the specified group.
         /// The returned policy is URL-encoded according to RFC 3986. For more
         /// information about RFC 3986, go to
         /// http://www.faqs.org/rfcs/rfc3986.html.</para>
         /// </summary>
         /// 
         /// <param name="getGroupPolicyRequest">Container for the necessary
         ///           parameters to execute the GetGroupPolicy service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <returns>The response from the GetGroupPolicy service method, as
         ///         returned by AmazonIdentityManagementService.</returns>
         /// 
         /// <exception cref="NoSuchEntityException"/>
        public GetGroupPolicyResponse GetGroupPolicy(GetGroupPolicyRequest getGroupPolicyRequest) 
        {           
            IRequest<GetGroupPolicyRequest> request = new GetGroupPolicyRequestMarshaller().Marshall(getGroupPolicyRequest);
            GetGroupPolicyResponse response = Invoke<GetGroupPolicyRequest, GetGroupPolicyResponse> (request, this.signer, GetGroupPolicyResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para>Deactivates the specified MFA device and removes it from
         /// association with the user for which it was originally enabled.</para>
         /// </summary>
         /// 
         /// <param name="deactivateMFADeviceRequest">Container for the necessary
         ///           parameters to execute the DeactivateMFADevice service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <exception cref="EntityTemporarilyUnmodifiableException"/>
         /// <exception cref="NoSuchEntityException"/>
        public DeactivateMFADeviceResponse DeactivateMFADevice(DeactivateMFADeviceRequest deactivateMFADeviceRequest) 
        {           
            IRequest<DeactivateMFADeviceRequest> request = new DeactivateMFADeviceRequestMarshaller().Marshall(deactivateMFADeviceRequest);
            DeactivateMFADeviceResponse response = Invoke<DeactivateMFADeviceRequest, DeactivateMFADeviceResponse> (request, this.signer, DeactivateMFADeviceResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para>Removes the specified user from the specified group.</para>
         /// </summary>
         /// 
         /// <param name="removeUserFromGroupRequest">Container for the necessary
         ///           parameters to execute the RemoveUserFromGroup service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <exception cref="NoSuchEntityException"/>
        public RemoveUserFromGroupResponse RemoveUserFromGroup(RemoveUserFromGroupRequest removeUserFromGroupRequest) 
        {           
            IRequest<RemoveUserFromGroupRequest> request = new RemoveUserFromGroupRequestMarshaller().Marshall(removeUserFromGroupRequest);
            RemoveUserFromGroupResponse response = Invoke<RemoveUserFromGroupRequest, RemoveUserFromGroupResponse> (request, this.signer, RemoveUserFromGroupResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para>Lists the names of the policies associated with the specified
         /// group. If there are none, the action returns an empty list.</para>
         /// <para>You can paginate the results using the <c>MaxItems</c> and
         /// <c>Marker</c> parameters.</para>
         /// </summary>
         /// 
         /// <param name="listGroupPoliciesRequest">Container for the necessary
         ///           parameters to execute the ListGroupPolicies service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <returns>The response from the ListGroupPolicies service method, as
         ///         returned by AmazonIdentityManagementService.</returns>
         /// 
         /// <exception cref="NoSuchEntityException"/>
        public ListGroupPoliciesResponse ListGroupPolicies(ListGroupPoliciesRequest listGroupPoliciesRequest) 
        {           
            IRequest<ListGroupPoliciesRequest> request = new ListGroupPoliciesRequestMarshaller().Marshall(listGroupPoliciesRequest);
            ListGroupPoliciesResponse response = Invoke<ListGroupPoliciesRequest, ListGroupPoliciesResponse> (request, this.signer, ListGroupPoliciesResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para>Creates a login profile for the specified user, giving the user
         /// the ability to access AWS services such as the AWS Management Console.
         /// For more information about login profiles, see Managing Login
         /// Profiles and MFA Devices in the <a
         /// href="http://aws.amazon.com/documentation/"> AWS Identity and Access
         /// Management User Guide </a> .</para>
         /// </summary>
         /// 
         /// <param name="createLoginProfileRequest">Container for the necessary
         ///           parameters to execute the CreateLoginProfile service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <returns>The response from the CreateLoginProfile service method, as
         ///         returned by AmazonIdentityManagementService.</returns>
         /// 
         /// <exception cref="NoSuchEntityException"/>
         /// <exception cref="EntityAlreadyExistsException"/>
        public CreateLoginProfileResponse CreateLoginProfile(CreateLoginProfileRequest createLoginProfileRequest) 
        {           
            IRequest<CreateLoginProfileRequest> request = new CreateLoginProfileRequestMarshaller().Marshall(createLoginProfileRequest);
            CreateLoginProfileResponse response = Invoke<CreateLoginProfileRequest, CreateLoginProfileResponse> (request, this.signer, CreateLoginProfileResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para>Creates a new AWS Secret Access Key and corresponding AWS Access
         /// Key ID for the specified user. The default status for new keys is
         /// Active.</para> <para>If the <c>UserName</c> field is not specified,
         /// the UserName is determined implicitly based on the AWS Access Key ID
         /// used to sign the request. Because this action works for access keys
         /// under the account, this API can be used to manage root credentials
         /// even if the account has no associated users.</para> <para>For
         /// information about limits on the number of keys you can create, see
         /// Limitations on AWS IAM Entities in the <a
         /// href="http://aws.amazon.com/documentation/"> AWS Identity and Access
         /// Management User Guide </a> .</para> <para><b>IMPORTANT:</b>To ensure
         /// the security of your account, the secret access key is accesible only
         /// during key and user creation. You must save the key (for example, in
         /// a text file) if you want to be able to access it again. If a secret
         /// key is lost, you can delete the access keys for the associated user
         /// and then create new keys.</para>
         /// </summary>
         /// 
         /// <param name="createAccessKeyRequest">Container for the necessary
         ///           parameters to execute the CreateAccessKey service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <returns>The response from the CreateAccessKey service method, as
         ///         returned by AmazonIdentityManagementService.</returns>
         /// 
         /// <exception cref="NoSuchEntityException"/>
         /// <exception cref="LimitExceededException"/>
        public CreateAccessKeyResponse CreateAccessKey(CreateAccessKeyRequest createAccessKeyRequest) 
        {           
            IRequest<CreateAccessKeyRequest> request = new CreateAccessKeyRequestMarshaller().Marshall(createAccessKeyRequest);
            CreateAccessKeyResponse response = Invoke<CreateAccessKeyRequest, CreateAccessKeyResponse> (request, this.signer, CreateAccessKeyResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para>Retrieves information about the specified user, including the
         /// user's path, GUID, and ARN.</para> <para>If the <c>UserName</c> field
         /// is not specified, UserName is determined implicitly based on the AWS
         /// Access Key ID used to sign the request.</para>
         /// </summary>
         /// 
         /// <param name="getUserRequest">Container for the necessary parameters to
         ///           execute the GetUser service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <returns>The response from the GetUser service method, as returned by
         ///         AmazonIdentityManagementService.</returns>
         /// 
         /// <exception cref="NoSuchEntityException"/>
        public GetUserResponse GetUser(GetUserRequest getUserRequest) 
        {           
            IRequest<GetUserRequest> request = new GetUserRequestMarshaller().Marshall(getUserRequest);
            GetUserResponse response = Invoke<GetUserRequest, GetUserResponse> (request, this.signer, GetUserResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para>Synchronizes the specified MFA device with AWS servers.</para>
         /// </summary>
         /// 
         /// <param name="resyncMFADeviceRequest">Container for the necessary
         ///           parameters to execute the ResyncMFADevice service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <exception cref="NoSuchEntityException"/>
         /// <exception cref="InvalidAuthenticationCodeException"/>
        public ResyncMFADeviceResponse ResyncMFADevice(ResyncMFADeviceRequest resyncMFADeviceRequest) 
        {           
            IRequest<ResyncMFADeviceRequest> request = new ResyncMFADeviceRequestMarshaller().Marshall(resyncMFADeviceRequest);
            ResyncMFADeviceResponse response = Invoke<ResyncMFADeviceRequest, ResyncMFADeviceResponse> (request, this.signer, ResyncMFADeviceResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para>Lists the MFA devices associated with the specified user.</para>
         /// <para>You can paginate the results using the <c>MaxItems</c> and
         /// <c>Marker</c> parameters.</para>
         /// </summary>
         /// 
         /// <param name="listMFADevicesRequest">Container for the necessary
         ///           parameters to execute the ListMFADevices service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <returns>The response from the ListMFADevices service method, as
         ///         returned by AmazonIdentityManagementService.</returns>
         /// 
         /// <exception cref="NoSuchEntityException"/>
        public ListMFADevicesResponse ListMFADevices(ListMFADevicesRequest listMFADevicesRequest) 
        {           
            IRequest<ListMFADevicesRequest> request = new ListMFADevicesRequestMarshaller().Marshall(listMFADevicesRequest);
            ListMFADevicesResponse response = Invoke<ListMFADevicesRequest, ListMFADevicesResponse> (request, this.signer, ListMFADevicesResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para>Changes the status of the specified access key from Active to
         /// Inactive, or vice versa. This action can be used to disable a user's
         /// key as part of a key rotation workflow.</para> <para>If the
         /// <c>UserName</c> field is not specified, the UserName is determined
         /// implicitly based on the AWS Access Key ID used to sign the request.
         /// Because this action works for access keys under the account, this API
         /// can be used to manage root credentials even if the account has no
         /// associated users.</para> <para>For information about rotating keys,
         /// see Managing Keys and Certificates in the <a
         /// href="http://aws.amazon.com/documentation/"> AWS Identity and Access
         /// Management User Guide </a> .</para>
         /// </summary>
         /// 
         /// <param name="updateAccessKeyRequest">Container for the necessary
         ///           parameters to execute the UpdateAccessKey service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <exception cref="NoSuchEntityException"/>
        public UpdateAccessKeyResponse UpdateAccessKey(UpdateAccessKeyRequest updateAccessKeyRequest) 
        {           
            IRequest<UpdateAccessKeyRequest> request = new UpdateAccessKeyRequestMarshaller().Marshall(updateAccessKeyRequest);
            UpdateAccessKeyResponse response = Invoke<UpdateAccessKeyRequest, UpdateAccessKeyResponse> (request, this.signer, UpdateAccessKeyResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para>Adds the specified user to the specified group.</para>
         /// </summary>
         /// 
         /// <param name="addUserToGroupRequest">Container for the necessary
         ///           parameters to execute the AddUserToGroup service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <exception cref="NoSuchEntityException"/>
         /// <exception cref="LimitExceededException"/>
        public AddUserToGroupResponse AddUserToGroup(AddUserToGroupRequest addUserToGroupRequest) 
        {           
            IRequest<AddUserToGroupRequest> request = new AddUserToGroupRequestMarshaller().Marshall(addUserToGroupRequest);
            AddUserToGroupResponse response = Invoke<AddUserToGroupRequest, AddUserToGroupResponse> (request, this.signer, AddUserToGroupResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para>Returns a list of users that are in the specified group. You can
         /// paginate the results using the <c>MaxItems</c> and <c>Marker</c>
         /// parameters.</para>
         /// </summary>
         /// 
         /// <param name="getGroupRequest">Container for the necessary parameters
         ///           to execute the GetGroup service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <returns>The response from the GetGroup service method, as returned by
         ///         AmazonIdentityManagementService.</returns>
         /// 
         /// <exception cref="NoSuchEntityException"/>
        public GetGroupResponse GetGroup(GetGroupRequest getGroupRequest) 
        {           
            IRequest<GetGroupRequest> request = new GetGroupRequestMarshaller().Marshall(getGroupRequest);
            GetGroupResponse response = Invoke<GetGroupRequest, GetGroupResponse> (request, this.signer, GetGroupResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para>Deletes the specified group. The group must not contain any
         /// users or have any attached policies.</para>
         /// </summary>
         /// 
         /// <param name="deleteGroupRequest">Container for the necessary
         ///           parameters to execute the DeleteGroup service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <exception cref="NoSuchEntityException"/>
         /// <exception cref="DeleteConflictException"/>
        public DeleteGroupResponse DeleteGroup(DeleteGroupRequest deleteGroupRequest) 
        {           
            IRequest<DeleteGroupRequest> request = new DeleteGroupRequestMarshaller().Marshall(deleteGroupRequest);
            DeleteGroupResponse response = Invoke<DeleteGroupRequest, DeleteGroupResponse> (request, this.signer, DeleteGroupResponseUnmarshaller.GetInstance());
            return response;
        }
    
    }
}   
    
