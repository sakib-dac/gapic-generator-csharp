// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/showcase/v1beta1/sequence.proto
// </auto-generated>
// Original file comments:
// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//   https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Showcase.V1Beta1 {
  public static partial class SequenceService
  {
    static readonly string __ServiceName = "google.showcase.v1beta1.SequenceService";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Showcase.V1Beta1.CreateSequenceRequest> __Marshaller_google_showcase_v1beta1_CreateSequenceRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Showcase.V1Beta1.CreateSequenceRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Showcase.V1Beta1.Sequence> __Marshaller_google_showcase_v1beta1_Sequence = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Showcase.V1Beta1.Sequence.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Showcase.V1Beta1.GetSequenceReportRequest> __Marshaller_google_showcase_v1beta1_GetSequenceReportRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Showcase.V1Beta1.GetSequenceReportRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Showcase.V1Beta1.SequenceReport> __Marshaller_google_showcase_v1beta1_SequenceReport = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Showcase.V1Beta1.SequenceReport.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Showcase.V1Beta1.AttemptSequenceRequest> __Marshaller_google_showcase_v1beta1_AttemptSequenceRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Showcase.V1Beta1.AttemptSequenceRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Protobuf.WellKnownTypes.Empty.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Showcase.V1Beta1.CreateSequenceRequest, global::Google.Showcase.V1Beta1.Sequence> __Method_CreateSequence = new grpc::Method<global::Google.Showcase.V1Beta1.CreateSequenceRequest, global::Google.Showcase.V1Beta1.Sequence>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateSequence",
        __Marshaller_google_showcase_v1beta1_CreateSequenceRequest,
        __Marshaller_google_showcase_v1beta1_Sequence);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Showcase.V1Beta1.GetSequenceReportRequest, global::Google.Showcase.V1Beta1.SequenceReport> __Method_GetSequenceReport = new grpc::Method<global::Google.Showcase.V1Beta1.GetSequenceReportRequest, global::Google.Showcase.V1Beta1.SequenceReport>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetSequenceReport",
        __Marshaller_google_showcase_v1beta1_GetSequenceReportRequest,
        __Marshaller_google_showcase_v1beta1_SequenceReport);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Showcase.V1Beta1.AttemptSequenceRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_AttemptSequence = new grpc::Method<global::Google.Showcase.V1Beta1.AttemptSequenceRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AttemptSequence",
        __Marshaller_google_showcase_v1beta1_AttemptSequenceRequest,
        __Marshaller_google_protobuf_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Showcase.V1Beta1.SequenceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of SequenceService</summary>
    [grpc::BindServiceMethod(typeof(SequenceService), "BindService")]
    public abstract partial class SequenceServiceBase
    {
      /// <summary>
      /// Creates a sequence.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Showcase.V1Beta1.Sequence> CreateSequence(global::Google.Showcase.V1Beta1.CreateSequenceRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Retrieves a sequence.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Showcase.V1Beta1.SequenceReport> GetSequenceReport(global::Google.Showcase.V1Beta1.GetSequenceReportRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Attempts a sequence.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> AttemptSequence(global::Google.Showcase.V1Beta1.AttemptSequenceRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for SequenceService</summary>
    public partial class SequenceServiceClient : grpc::ClientBase<SequenceServiceClient>
    {
      /// <summary>Creates a new client for SequenceService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public SequenceServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for SequenceService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public SequenceServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected SequenceServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected SequenceServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Creates a sequence.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Showcase.V1Beta1.Sequence CreateSequence(global::Google.Showcase.V1Beta1.CreateSequenceRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateSequence(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a sequence.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Showcase.V1Beta1.Sequence CreateSequence(global::Google.Showcase.V1Beta1.CreateSequenceRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateSequence, null, options, request);
      }
      /// <summary>
      /// Creates a sequence.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Showcase.V1Beta1.Sequence> CreateSequenceAsync(global::Google.Showcase.V1Beta1.CreateSequenceRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateSequenceAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a sequence.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Showcase.V1Beta1.Sequence> CreateSequenceAsync(global::Google.Showcase.V1Beta1.CreateSequenceRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateSequence, null, options, request);
      }
      /// <summary>
      /// Retrieves a sequence.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Showcase.V1Beta1.SequenceReport GetSequenceReport(global::Google.Showcase.V1Beta1.GetSequenceReportRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetSequenceReport(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves a sequence.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Showcase.V1Beta1.SequenceReport GetSequenceReport(global::Google.Showcase.V1Beta1.GetSequenceReportRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetSequenceReport, null, options, request);
      }
      /// <summary>
      /// Retrieves a sequence.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Showcase.V1Beta1.SequenceReport> GetSequenceReportAsync(global::Google.Showcase.V1Beta1.GetSequenceReportRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetSequenceReportAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves a sequence.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Showcase.V1Beta1.SequenceReport> GetSequenceReportAsync(global::Google.Showcase.V1Beta1.GetSequenceReportRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetSequenceReport, null, options, request);
      }
      /// <summary>
      /// Attempts a sequence.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Protobuf.WellKnownTypes.Empty AttemptSequence(global::Google.Showcase.V1Beta1.AttemptSequenceRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AttemptSequence(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Attempts a sequence.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Protobuf.WellKnownTypes.Empty AttemptSequence(global::Google.Showcase.V1Beta1.AttemptSequenceRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AttemptSequence, null, options, request);
      }
      /// <summary>
      /// Attempts a sequence.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> AttemptSequenceAsync(global::Google.Showcase.V1Beta1.AttemptSequenceRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AttemptSequenceAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Attempts a sequence.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> AttemptSequenceAsync(global::Google.Showcase.V1Beta1.AttemptSequenceRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AttemptSequence, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override SequenceServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new SequenceServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(SequenceServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_CreateSequence, serviceImpl.CreateSequence)
          .AddMethod(__Method_GetSequenceReport, serviceImpl.GetSequenceReport)
          .AddMethod(__Method_AttemptSequence, serviceImpl.AttemptSequence).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, SequenceServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_CreateSequence, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Showcase.V1Beta1.CreateSequenceRequest, global::Google.Showcase.V1Beta1.Sequence>(serviceImpl.CreateSequence));
      serviceBinder.AddMethod(__Method_GetSequenceReport, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Showcase.V1Beta1.GetSequenceReportRequest, global::Google.Showcase.V1Beta1.SequenceReport>(serviceImpl.GetSequenceReport));
      serviceBinder.AddMethod(__Method_AttemptSequence, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Showcase.V1Beta1.AttemptSequenceRequest, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.AttemptSequence));
    }

  }
}
#endregion
