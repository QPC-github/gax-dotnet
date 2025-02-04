/*
 * Copyright 2021 Google LLC All Rights Reserved.
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE file or at
 * https://developers.google.com/open-source/licenses/bsd
 */

// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/api/usage.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Api {

  /// <summary>Holder for reflection information generated from google/api/usage.proto</summary>
  public static partial class UsageReflection {

    #region Descriptor
    /// <summary>File descriptor for google/api/usage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UsageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZnb29nbGUvYXBpL3VzYWdlLnByb3RvEgpnb29nbGUuYXBpImoKBVVzYWdl",
            "EhQKDHJlcXVpcmVtZW50cxgBIAMoCRIkCgVydWxlcxgGIAMoCzIVLmdvb2ds",
            "ZS5hcGkuVXNhZ2VSdWxlEiUKHXByb2R1Y2VyX25vdGlmaWNhdGlvbl9jaGFu",
            "bmVsGAcgASgJIl0KCVVzYWdlUnVsZRIQCghzZWxlY3RvchgBIAEoCRIgChhh",
            "bGxvd191bnJlZ2lzdGVyZWRfY2FsbHMYAiABKAgSHAoUc2tpcF9zZXJ2aWNl",
            "X2NvbnRyb2wYAyABKAhCbAoOY29tLmdvb2dsZS5hcGlCClVzYWdlUHJvdG9Q",
            "AVpFZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hcGkv",
            "c2VydmljZWNvbmZpZztzZXJ2aWNlY29uZmlnogIER0FQSWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Api.Usage), global::Google.Api.Usage.Parser, new[]{ "Requirements", "Rules", "ProducerNotificationChannel" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Api.UsageRule), global::Google.Api.UsageRule.Parser, new[]{ "Selector", "AllowUnregisteredCalls", "SkipServiceControl" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Configuration controlling usage of a service.
  /// </summary>
  public sealed partial class Usage : pb::IMessage<Usage>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Usage> _parser = new pb::MessageParser<Usage>(() => new Usage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Usage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Api.UsageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Usage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Usage(Usage other) : this() {
      requirements_ = other.requirements_.Clone();
      rules_ = other.rules_.Clone();
      producerNotificationChannel_ = other.producerNotificationChannel_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Usage Clone() {
      return new Usage(this);
    }

    /// <summary>Field number for the "requirements" field.</summary>
    public const int RequirementsFieldNumber = 1;
    private static readonly pb::FieldCodec<string> _repeated_requirements_codec
        = pb::FieldCodec.ForString(10);
    private readonly pbc::RepeatedField<string> requirements_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// Requirements that must be satisfied before a consumer project can use the
    /// service. Each requirement is of the form &lt;service.name>/&lt;requirement-id>;
    /// for example 'serviceusage.googleapis.com/billing-enabled'.
    ///
    /// For Google APIs, a Terms of Service requirement must be included here.
    /// Google Cloud APIs must include "serviceusage.googleapis.com/tos/cloud".
    /// Other Google APIs should include
    /// "serviceusage.googleapis.com/tos/universal". Additional ToS can be
    /// included based on the business needs.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> Requirements {
      get { return requirements_; }
    }

    /// <summary>Field number for the "rules" field.</summary>
    public const int RulesFieldNumber = 6;
    private static readonly pb::FieldCodec<global::Google.Api.UsageRule> _repeated_rules_codec
        = pb::FieldCodec.ForMessage(50, global::Google.Api.UsageRule.Parser);
    private readonly pbc::RepeatedField<global::Google.Api.UsageRule> rules_ = new pbc::RepeatedField<global::Google.Api.UsageRule>();
    /// <summary>
    /// A list of usage rules that apply to individual API methods.
    ///
    /// **NOTE:** All service configuration rules follow "last one wins" order.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Api.UsageRule> Rules {
      get { return rules_; }
    }

    /// <summary>Field number for the "producer_notification_channel" field.</summary>
    public const int ProducerNotificationChannelFieldNumber = 7;
    private string producerNotificationChannel_ = "";
    /// <summary>
    /// The full resource name of a channel used for sending notifications to the
    /// service producer.
    ///
    /// Google Service Management currently only supports
    /// [Google Cloud Pub/Sub](https://cloud.google.com/pubsub) as a notification
    /// channel. To use Google Cloud Pub/Sub as the channel, this must be the name
    /// of a Cloud Pub/Sub topic that uses the Cloud Pub/Sub topic name format
    /// documented in https://cloud.google.com/pubsub/docs/overview.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ProducerNotificationChannel {
      get { return producerNotificationChannel_; }
      set {
        producerNotificationChannel_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Usage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Usage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!requirements_.Equals(other.requirements_)) return false;
      if(!rules_.Equals(other.rules_)) return false;
      if (ProducerNotificationChannel != other.ProducerNotificationChannel) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= requirements_.GetHashCode();
      hash ^= rules_.GetHashCode();
      if (ProducerNotificationChannel.Length != 0) hash ^= ProducerNotificationChannel.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      requirements_.WriteTo(output, _repeated_requirements_codec);
      rules_.WriteTo(output, _repeated_rules_codec);
      if (ProducerNotificationChannel.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(ProducerNotificationChannel);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      requirements_.WriteTo(ref output, _repeated_requirements_codec);
      rules_.WriteTo(ref output, _repeated_rules_codec);
      if (ProducerNotificationChannel.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(ProducerNotificationChannel);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += requirements_.CalculateSize(_repeated_requirements_codec);
      size += rules_.CalculateSize(_repeated_rules_codec);
      if (ProducerNotificationChannel.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ProducerNotificationChannel);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Usage other) {
      if (other == null) {
        return;
      }
      requirements_.Add(other.requirements_);
      rules_.Add(other.rules_);
      if (other.ProducerNotificationChannel.Length != 0) {
        ProducerNotificationChannel = other.ProducerNotificationChannel;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            requirements_.AddEntriesFrom(input, _repeated_requirements_codec);
            break;
          }
          case 50: {
            rules_.AddEntriesFrom(input, _repeated_rules_codec);
            break;
          }
          case 58: {
            ProducerNotificationChannel = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            requirements_.AddEntriesFrom(ref input, _repeated_requirements_codec);
            break;
          }
          case 50: {
            rules_.AddEntriesFrom(ref input, _repeated_rules_codec);
            break;
          }
          case 58: {
            ProducerNotificationChannel = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Usage configuration rules for the service.
  ///
  /// NOTE: Under development.
  ///
  /// Use this rule to configure unregistered calls for the service. Unregistered
  /// calls are calls that do not contain consumer project identity.
  /// (Example: calls that do not contain an API key).
  /// By default, API methods do not allow unregistered calls, and each method call
  /// must be identified by a consumer project identity. Use this rule to
  /// allow/disallow unregistered calls.
  ///
  /// Example of an API that wants to allow unregistered calls for entire service.
  ///
  ///     usage:
  ///       rules:
  ///       - selector: "*"
  ///         allow_unregistered_calls: true
  ///
  /// Example of a method that wants to allow unregistered calls.
  ///
  ///     usage:
  ///       rules:
  ///       - selector: "google.example.library.v1.LibraryService.CreateBook"
  ///         allow_unregistered_calls: true
  /// </summary>
  public sealed partial class UsageRule : pb::IMessage<UsageRule>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<UsageRule> _parser = new pb::MessageParser<UsageRule>(() => new UsageRule());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<UsageRule> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Api.UsageReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UsageRule() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UsageRule(UsageRule other) : this() {
      selector_ = other.selector_;
      allowUnregisteredCalls_ = other.allowUnregisteredCalls_;
      skipServiceControl_ = other.skipServiceControl_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UsageRule Clone() {
      return new UsageRule(this);
    }

    /// <summary>Field number for the "selector" field.</summary>
    public const int SelectorFieldNumber = 1;
    private string selector_ = "";
    /// <summary>
    /// Selects the methods to which this rule applies. Use '*' to indicate all
    /// methods in all APIs.
    ///
    /// Refer to [selector][google.api.DocumentationRule.selector] for syntax details.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Selector {
      get { return selector_; }
      set {
        selector_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "allow_unregistered_calls" field.</summary>
    public const int AllowUnregisteredCallsFieldNumber = 2;
    private bool allowUnregisteredCalls_;
    /// <summary>
    /// If true, the selected method allows unregistered calls, e.g. calls
    /// that don't identify any user or application.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool AllowUnregisteredCalls {
      get { return allowUnregisteredCalls_; }
      set {
        allowUnregisteredCalls_ = value;
      }
    }

    /// <summary>Field number for the "skip_service_control" field.</summary>
    public const int SkipServiceControlFieldNumber = 3;
    private bool skipServiceControl_;
    /// <summary>
    /// If true, the selected method should skip service control and the control
    /// plane features, such as quota and billing, will not be available.
    /// This flag is used by Google Cloud Endpoints to bypass checks for internal
    /// methods, such as service health check methods.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool SkipServiceControl {
      get { return skipServiceControl_; }
      set {
        skipServiceControl_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as UsageRule);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(UsageRule other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Selector != other.Selector) return false;
      if (AllowUnregisteredCalls != other.AllowUnregisteredCalls) return false;
      if (SkipServiceControl != other.SkipServiceControl) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Selector.Length != 0) hash ^= Selector.GetHashCode();
      if (AllowUnregisteredCalls != false) hash ^= AllowUnregisteredCalls.GetHashCode();
      if (SkipServiceControl != false) hash ^= SkipServiceControl.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Selector.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Selector);
      }
      if (AllowUnregisteredCalls != false) {
        output.WriteRawTag(16);
        output.WriteBool(AllowUnregisteredCalls);
      }
      if (SkipServiceControl != false) {
        output.WriteRawTag(24);
        output.WriteBool(SkipServiceControl);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Selector.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Selector);
      }
      if (AllowUnregisteredCalls != false) {
        output.WriteRawTag(16);
        output.WriteBool(AllowUnregisteredCalls);
      }
      if (SkipServiceControl != false) {
        output.WriteRawTag(24);
        output.WriteBool(SkipServiceControl);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Selector.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Selector);
      }
      if (AllowUnregisteredCalls != false) {
        size += 1 + 1;
      }
      if (SkipServiceControl != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(UsageRule other) {
      if (other == null) {
        return;
      }
      if (other.Selector.Length != 0) {
        Selector = other.Selector;
      }
      if (other.AllowUnregisteredCalls != false) {
        AllowUnregisteredCalls = other.AllowUnregisteredCalls;
      }
      if (other.SkipServiceControl != false) {
        SkipServiceControl = other.SkipServiceControl;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Selector = input.ReadString();
            break;
          }
          case 16: {
            AllowUnregisteredCalls = input.ReadBool();
            break;
          }
          case 24: {
            SkipServiceControl = input.ReadBool();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Selector = input.ReadString();
            break;
          }
          case 16: {
            AllowUnregisteredCalls = input.ReadBool();
            break;
          }
          case 24: {
            SkipServiceControl = input.ReadBool();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
