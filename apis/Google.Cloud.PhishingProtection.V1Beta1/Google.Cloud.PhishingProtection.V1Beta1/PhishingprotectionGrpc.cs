// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/phishingprotection/v1beta1/phishingprotection.proto
// </auto-generated>
// Original file comments:
// Copyright 2019 Google LLC.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
//
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Cloud.PhishingProtection.V1Beta1 {
  /// <summary>
  /// Service to report phishing URIs.
  /// </summary>
  public static partial class PhishingProtectionServiceV1Beta1
  {
    static readonly string __ServiceName = "google.cloud.phishingprotection.v1beta1.PhishingProtectionServiceV1Beta1";

    static readonly grpc::Marshaller<global::Google.Cloud.PhishingProtection.V1Beta1.ReportPhishingRequest> __Marshaller_google_cloud_phishingprotection_v1beta1_ReportPhishingRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.PhishingProtection.V1Beta1.ReportPhishingRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.PhishingProtection.V1Beta1.ReportPhishingResponse> __Marshaller_google_cloud_phishingprotection_v1beta1_ReportPhishingResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.PhishingProtection.V1Beta1.ReportPhishingResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Cloud.PhishingProtection.V1Beta1.ReportPhishingRequest, global::Google.Cloud.PhishingProtection.V1Beta1.ReportPhishingResponse> __Method_ReportPhishing = new grpc::Method<global::Google.Cloud.PhishingProtection.V1Beta1.ReportPhishingRequest, global::Google.Cloud.PhishingProtection.V1Beta1.ReportPhishingResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ReportPhishing",
        __Marshaller_google_cloud_phishingprotection_v1beta1_ReportPhishingRequest,
        __Marshaller_google_cloud_phishingprotection_v1beta1_ReportPhishingResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.PhishingProtection.V1Beta1.PhishingprotectionReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of PhishingProtectionServiceV1Beta1</summary>
    [grpc::BindServiceMethod(typeof(PhishingProtectionServiceV1Beta1), "BindService")]
    public abstract partial class PhishingProtectionServiceV1Beta1Base
    {
      /// <summary>
      /// Reports a URI suspected of containing phishing content to be reviewed. Once
      /// the report review is completed, if its result verifies the existince of
      /// malicious phishing content, the site will be added the to [Google's Social
      /// Engineering lists](https://support.google.com/webmasters/answer/6350487/)
      /// in order to protect users that could get exposed to this threat in
      /// the future.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.PhishingProtection.V1Beta1.ReportPhishingResponse> ReportPhishing(global::Google.Cloud.PhishingProtection.V1Beta1.ReportPhishingRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for PhishingProtectionServiceV1Beta1</summary>
    public partial class PhishingProtectionServiceV1Beta1Client : grpc::ClientBase<PhishingProtectionServiceV1Beta1Client>
    {
      /// <summary>Creates a new client for PhishingProtectionServiceV1Beta1</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public PhishingProtectionServiceV1Beta1Client(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for PhishingProtectionServiceV1Beta1 that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public PhishingProtectionServiceV1Beta1Client(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected PhishingProtectionServiceV1Beta1Client() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected PhishingProtectionServiceV1Beta1Client(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Reports a URI suspected of containing phishing content to be reviewed. Once
      /// the report review is completed, if its result verifies the existince of
      /// malicious phishing content, the site will be added the to [Google's Social
      /// Engineering lists](https://support.google.com/webmasters/answer/6350487/)
      /// in order to protect users that could get exposed to this threat in
      /// the future.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.PhishingProtection.V1Beta1.ReportPhishingResponse ReportPhishing(global::Google.Cloud.PhishingProtection.V1Beta1.ReportPhishingRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ReportPhishing(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Reports a URI suspected of containing phishing content to be reviewed. Once
      /// the report review is completed, if its result verifies the existince of
      /// malicious phishing content, the site will be added the to [Google's Social
      /// Engineering lists](https://support.google.com/webmasters/answer/6350487/)
      /// in order to protect users that could get exposed to this threat in
      /// the future.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.PhishingProtection.V1Beta1.ReportPhishingResponse ReportPhishing(global::Google.Cloud.PhishingProtection.V1Beta1.ReportPhishingRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ReportPhishing, null, options, request);
      }
      /// <summary>
      /// Reports a URI suspected of containing phishing content to be reviewed. Once
      /// the report review is completed, if its result verifies the existince of
      /// malicious phishing content, the site will be added the to [Google's Social
      /// Engineering lists](https://support.google.com/webmasters/answer/6350487/)
      /// in order to protect users that could get exposed to this threat in
      /// the future.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.PhishingProtection.V1Beta1.ReportPhishingResponse> ReportPhishingAsync(global::Google.Cloud.PhishingProtection.V1Beta1.ReportPhishingRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ReportPhishingAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Reports a URI suspected of containing phishing content to be reviewed. Once
      /// the report review is completed, if its result verifies the existince of
      /// malicious phishing content, the site will be added the to [Google's Social
      /// Engineering lists](https://support.google.com/webmasters/answer/6350487/)
      /// in order to protect users that could get exposed to this threat in
      /// the future.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.PhishingProtection.V1Beta1.ReportPhishingResponse> ReportPhishingAsync(global::Google.Cloud.PhishingProtection.V1Beta1.ReportPhishingRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ReportPhishing, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override PhishingProtectionServiceV1Beta1Client NewInstance(ClientBaseConfiguration configuration)
      {
        return new PhishingProtectionServiceV1Beta1Client(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(PhishingProtectionServiceV1Beta1Base serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ReportPhishing, serviceImpl.ReportPhishing).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, PhishingProtectionServiceV1Beta1Base serviceImpl)
    {
      serviceBinder.AddMethod(__Method_ReportPhishing, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.PhishingProtection.V1Beta1.ReportPhishingRequest, global::Google.Cloud.PhishingProtection.V1Beta1.ReportPhishingResponse>(serviceImpl.ReportPhishing));
    }

  }
}
#endregion
