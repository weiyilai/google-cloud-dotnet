// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/discoveryengine/v1beta/project.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.DiscoveryEngine.V1Beta {

  /// <summary>Holder for reflection information generated from google/cloud/discoveryengine/v1beta/project.proto</summary>
  public static partial class ProjectReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/discoveryengine/v1beta/project.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProjectReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjFnb29nbGUvY2xvdWQvZGlzY292ZXJ5ZW5naW5lL3YxYmV0YS9wcm9qZWN0",
            "LnByb3RvEiNnb29nbGUuY2xvdWQuZGlzY292ZXJ5ZW5naW5lLnYxYmV0YRof",
            "Z29vZ2xlL2FwaS9maWVsZF9iZWhhdmlvci5wcm90bxoZZ29vZ2xlL2FwaS9y",
            "ZXNvdXJjZS5wcm90bxofZ29vZ2xlL3Byb3RvYnVmL3RpbWVzdGFtcC5wcm90",
            "byLpBQoHUHJvamVjdBIRCgRuYW1lGAEgASgJQgPgQQMSNAoLY3JlYXRlX3Rp",
            "bWUYAiABKAsyGi5nb29nbGUucHJvdG9idWYuVGltZXN0YW1wQgPgQQMSQgoZ",
            "cHJvdmlzaW9uX2NvbXBsZXRpb25fdGltZRgDIAEoCzIaLmdvb2dsZS5wcm90",
            "b2J1Zi5UaW1lc3RhbXBCA+BBAxJhChFzZXJ2aWNlX3Rlcm1zX21hcBgEIAMo",
            "CzJBLmdvb2dsZS5jbG91ZC5kaXNjb3ZlcnllbmdpbmUudjFiZXRhLlByb2pl",
            "Y3QuU2VydmljZVRlcm1zTWFwRW50cnlCA+BBAxq5AgoMU2VydmljZVRlcm1z",
            "EgoKAmlkGAEgASgJEg8KB3ZlcnNpb24YAiABKAkSTgoFc3RhdGUYBCABKA4y",
            "Py5nb29nbGUuY2xvdWQuZGlzY292ZXJ5ZW5naW5lLnYxYmV0YS5Qcm9qZWN0",
            "LlNlcnZpY2VUZXJtcy5TdGF0ZRIvCgthY2NlcHRfdGltZRgFIAEoCzIaLmdv",
            "b2dsZS5wcm90b2J1Zi5UaW1lc3RhbXASMAoMZGVjbGluZV90aW1lGAYgASgL",
            "MhouZ29vZ2xlLnByb3RvYnVmLlRpbWVzdGFtcCJZCgVTdGF0ZRIVChFTVEFU",
            "RV9VTlNQRUNJRklFRBAAEhIKDlRFUk1TX0FDQ0VQVEVEEAESEQoNVEVSTVNf",
            "UEVORElORxACEhIKDlRFUk1TX0RFQ0xJTkVEEAMacQoUU2VydmljZVRlcm1z",
            "TWFwRW50cnkSCwoDa2V5GAEgASgJEkgKBXZhbHVlGAIgASgLMjkuZ29vZ2xl",
            "LmNsb3VkLmRpc2NvdmVyeWVuZ2luZS52MWJldGEuUHJvamVjdC5TZXJ2aWNl",
            "VGVybXM6AjgBOj/qQTwKJmRpc2NvdmVyeWVuZ2luZS5nb29nbGVhcGlzLmNv",
            "bS9Qcm9qZWN0EhJwcm9qZWN0cy97cHJvamVjdH1CkwIKJ2NvbS5nb29nbGUu",
            "Y2xvdWQuZGlzY292ZXJ5ZW5naW5lLnYxYmV0YUIMUHJvamVjdFByb3RvUAFa",
            "UWNsb3VkLmdvb2dsZS5jb20vZ28vZGlzY292ZXJ5ZW5naW5lL2FwaXYxYmV0",
            "YS9kaXNjb3ZlcnllbmdpbmVwYjtkaXNjb3ZlcnllbmdpbmVwYqICD0RJU0NP",
            "VkVSWUVOR0lORaoCI0dvb2dsZS5DbG91ZC5EaXNjb3ZlcnlFbmdpbmUuVjFC",
            "ZXRhygIjR29vZ2xlXENsb3VkXERpc2NvdmVyeUVuZ2luZVxWMWJldGHqAiZH",
            "b29nbGU6OkNsb3VkOjpEaXNjb3ZlcnlFbmdpbmU6OlYxYmV0YWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.DiscoveryEngine.V1Beta.Project), global::Google.Cloud.DiscoveryEngine.V1Beta.Project.Parser, new[]{ "Name", "CreateTime", "ProvisionCompletionTime", "ServiceTermsMap" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.DiscoveryEngine.V1Beta.Project.Types.ServiceTerms), global::Google.Cloud.DiscoveryEngine.V1Beta.Project.Types.ServiceTerms.Parser, new[]{ "Id", "Version", "State", "AcceptTime", "DeclineTime" }, null, new[]{ typeof(global::Google.Cloud.DiscoveryEngine.V1Beta.Project.Types.ServiceTerms.Types.State) }, null, null),
            null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Metadata and configurations for a Google Cloud project in the service.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class Project : pb::IMessage<Project>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Project> _parser = new pb::MessageParser<Project>(() => new Project());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Project> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.DiscoveryEngine.V1Beta.ProjectReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Project() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Project(Project other) : this() {
      name_ = other.name_;
      createTime_ = other.createTime_ != null ? other.createTime_.Clone() : null;
      provisionCompletionTime_ = other.provisionCompletionTime_ != null ? other.provisionCompletionTime_.Clone() : null;
      serviceTermsMap_ = other.serviceTermsMap_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Project Clone() {
      return new Project(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Output only. Full resource name of the project, for example
    /// `projects/{project}`.
    /// Note that when making requests, project number and project id are both
    /// acceptable, but the server will always respond in project number.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "create_time" field.</summary>
    public const int CreateTimeFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createTime_;
    /// <summary>
    /// Output only. The timestamp when this project is created.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp CreateTime {
      get { return createTime_; }
      set {
        createTime_ = value;
      }
    }

    /// <summary>Field number for the "provision_completion_time" field.</summary>
    public const int ProvisionCompletionTimeFieldNumber = 3;
    private global::Google.Protobuf.WellKnownTypes.Timestamp provisionCompletionTime_;
    /// <summary>
    /// Output only. The timestamp when this project is successfully provisioned.
    /// Empty value means this project is still provisioning and is not ready for
    /// use.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp ProvisionCompletionTime {
      get { return provisionCompletionTime_; }
      set {
        provisionCompletionTime_ = value;
      }
    }

    /// <summary>Field number for the "service_terms_map" field.</summary>
    public const int ServiceTermsMapFieldNumber = 4;
    private static readonly pbc::MapField<string, global::Google.Cloud.DiscoveryEngine.V1Beta.Project.Types.ServiceTerms>.Codec _map_serviceTermsMap_codec
        = new pbc::MapField<string, global::Google.Cloud.DiscoveryEngine.V1Beta.Project.Types.ServiceTerms>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForMessage(18, global::Google.Cloud.DiscoveryEngine.V1Beta.Project.Types.ServiceTerms.Parser), 34);
    private readonly pbc::MapField<string, global::Google.Cloud.DiscoveryEngine.V1Beta.Project.Types.ServiceTerms> serviceTermsMap_ = new pbc::MapField<string, global::Google.Cloud.DiscoveryEngine.V1Beta.Project.Types.ServiceTerms>();
    /// <summary>
    /// Output only. A map of terms of services. The key is the `id` of
    /// [ServiceTerms][google.cloud.discoveryengine.v1beta.Project.ServiceTerms].
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<string, global::Google.Cloud.DiscoveryEngine.V1Beta.Project.Types.ServiceTerms> ServiceTermsMap {
      get { return serviceTermsMap_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Project);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Project other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (!object.Equals(CreateTime, other.CreateTime)) return false;
      if (!object.Equals(ProvisionCompletionTime, other.ProvisionCompletionTime)) return false;
      if (!ServiceTermsMap.Equals(other.ServiceTermsMap)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (createTime_ != null) hash ^= CreateTime.GetHashCode();
      if (provisionCompletionTime_ != null) hash ^= ProvisionCompletionTime.GetHashCode();
      hash ^= ServiceTermsMap.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (createTime_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(CreateTime);
      }
      if (provisionCompletionTime_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(ProvisionCompletionTime);
      }
      serviceTermsMap_.WriteTo(output, _map_serviceTermsMap_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (createTime_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(CreateTime);
      }
      if (provisionCompletionTime_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(ProvisionCompletionTime);
      }
      serviceTermsMap_.WriteTo(ref output, _map_serviceTermsMap_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (createTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreateTime);
      }
      if (provisionCompletionTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ProvisionCompletionTime);
      }
      size += serviceTermsMap_.CalculateSize(_map_serviceTermsMap_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Project other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.createTime_ != null) {
        if (createTime_ == null) {
          CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        CreateTime.MergeFrom(other.CreateTime);
      }
      if (other.provisionCompletionTime_ != null) {
        if (provisionCompletionTime_ == null) {
          ProvisionCompletionTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        ProvisionCompletionTime.MergeFrom(other.ProvisionCompletionTime);
      }
      serviceTermsMap_.MergeFrom(other.serviceTermsMap_);
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
            Name = input.ReadString();
            break;
          }
          case 18: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 26: {
            if (provisionCompletionTime_ == null) {
              ProvisionCompletionTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(ProvisionCompletionTime);
            break;
          }
          case 34: {
            serviceTermsMap_.AddEntriesFrom(input, _map_serviceTermsMap_codec);
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
            Name = input.ReadString();
            break;
          }
          case 18: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 26: {
            if (provisionCompletionTime_ == null) {
              ProvisionCompletionTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(ProvisionCompletionTime);
            break;
          }
          case 34: {
            serviceTermsMap_.AddEntriesFrom(ref input, _map_serviceTermsMap_codec);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the Project message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Metadata about the terms of service.
      /// </summary>
      [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
      public sealed partial class ServiceTerms : pb::IMessage<ServiceTerms>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<ServiceTerms> _parser = new pb::MessageParser<ServiceTerms>(() => new ServiceTerms());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<ServiceTerms> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Google.Cloud.DiscoveryEngine.V1Beta.Project.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public ServiceTerms() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public ServiceTerms(ServiceTerms other) : this() {
          id_ = other.id_;
          version_ = other.version_;
          state_ = other.state_;
          acceptTime_ = other.acceptTime_ != null ? other.acceptTime_.Clone() : null;
          declineTime_ = other.declineTime_ != null ? other.declineTime_.Clone() : null;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public ServiceTerms Clone() {
          return new ServiceTerms(this);
        }

        /// <summary>Field number for the "id" field.</summary>
        public const int IdFieldNumber = 1;
        private string id_ = "";
        /// <summary>
        /// The unique identifier of this terms of service.
        /// Available terms:
        ///
        /// * `GA_DATA_USE_TERMS`: [Terms for data
        /// use](https://cloud.google.com/retail/data-use-terms). When using this as
        /// `id`, the acceptable
        /// [version][google.cloud.discoveryengine.v1beta.Project.ServiceTerms.version]
        /// to provide is `2022-11-23`.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public string Id {
          get { return id_; }
          set {
            id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "version" field.</summary>
        public const int VersionFieldNumber = 2;
        private string version_ = "";
        /// <summary>
        /// The version string of the terms of service.
        /// For acceptable values, see the comments for
        /// [id][google.cloud.discoveryengine.v1beta.Project.ServiceTerms.id] above.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public string Version {
          get { return version_; }
          set {
            version_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "state" field.</summary>
        public const int StateFieldNumber = 4;
        private global::Google.Cloud.DiscoveryEngine.V1Beta.Project.Types.ServiceTerms.Types.State state_ = global::Google.Cloud.DiscoveryEngine.V1Beta.Project.Types.ServiceTerms.Types.State.Unspecified;
        /// <summary>
        /// Whether the project has accepted/rejected the service terms or it is
        /// still pending.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public global::Google.Cloud.DiscoveryEngine.V1Beta.Project.Types.ServiceTerms.Types.State State {
          get { return state_; }
          set {
            state_ = value;
          }
        }

        /// <summary>Field number for the "accept_time" field.</summary>
        public const int AcceptTimeFieldNumber = 5;
        private global::Google.Protobuf.WellKnownTypes.Timestamp acceptTime_;
        /// <summary>
        /// The last time when the project agreed to the terms of service.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public global::Google.Protobuf.WellKnownTypes.Timestamp AcceptTime {
          get { return acceptTime_; }
          set {
            acceptTime_ = value;
          }
        }

        /// <summary>Field number for the "decline_time" field.</summary>
        public const int DeclineTimeFieldNumber = 6;
        private global::Google.Protobuf.WellKnownTypes.Timestamp declineTime_;
        /// <summary>
        /// The last time when the project declined or revoked the agreement to terms
        /// of service.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public global::Google.Protobuf.WellKnownTypes.Timestamp DeclineTime {
          get { return declineTime_; }
          set {
            declineTime_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other) {
          return Equals(other as ServiceTerms);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(ServiceTerms other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Id != other.Id) return false;
          if (Version != other.Version) return false;
          if (State != other.State) return false;
          if (!object.Equals(AcceptTime, other.AcceptTime)) return false;
          if (!object.Equals(DeclineTime, other.DeclineTime)) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          if (Id.Length != 0) hash ^= Id.GetHashCode();
          if (Version.Length != 0) hash ^= Version.GetHashCode();
          if (State != global::Google.Cloud.DiscoveryEngine.V1Beta.Project.Types.ServiceTerms.Types.State.Unspecified) hash ^= State.GetHashCode();
          if (acceptTime_ != null) hash ^= AcceptTime.GetHashCode();
          if (declineTime_ != null) hash ^= DeclineTime.GetHashCode();
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
          if (Id.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(Id);
          }
          if (Version.Length != 0) {
            output.WriteRawTag(18);
            output.WriteString(Version);
          }
          if (State != global::Google.Cloud.DiscoveryEngine.V1Beta.Project.Types.ServiceTerms.Types.State.Unspecified) {
            output.WriteRawTag(32);
            output.WriteEnum((int) State);
          }
          if (acceptTime_ != null) {
            output.WriteRawTag(42);
            output.WriteMessage(AcceptTime);
          }
          if (declineTime_ != null) {
            output.WriteRawTag(50);
            output.WriteMessage(DeclineTime);
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
          if (Id.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(Id);
          }
          if (Version.Length != 0) {
            output.WriteRawTag(18);
            output.WriteString(Version);
          }
          if (State != global::Google.Cloud.DiscoveryEngine.V1Beta.Project.Types.ServiceTerms.Types.State.Unspecified) {
            output.WriteRawTag(32);
            output.WriteEnum((int) State);
          }
          if (acceptTime_ != null) {
            output.WriteRawTag(42);
            output.WriteMessage(AcceptTime);
          }
          if (declineTime_ != null) {
            output.WriteRawTag(50);
            output.WriteMessage(DeclineTime);
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
          if (Id.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
          }
          if (Version.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Version);
          }
          if (State != global::Google.Cloud.DiscoveryEngine.V1Beta.Project.Types.ServiceTerms.Types.State.Unspecified) {
            size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) State);
          }
          if (acceptTime_ != null) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(AcceptTime);
          }
          if (declineTime_ != null) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(DeclineTime);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(ServiceTerms other) {
          if (other == null) {
            return;
          }
          if (other.Id.Length != 0) {
            Id = other.Id;
          }
          if (other.Version.Length != 0) {
            Version = other.Version;
          }
          if (other.State != global::Google.Cloud.DiscoveryEngine.V1Beta.Project.Types.ServiceTerms.Types.State.Unspecified) {
            State = other.State;
          }
          if (other.acceptTime_ != null) {
            if (acceptTime_ == null) {
              AcceptTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            AcceptTime.MergeFrom(other.AcceptTime);
          }
          if (other.declineTime_ != null) {
            if (declineTime_ == null) {
              DeclineTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            DeclineTime.MergeFrom(other.DeclineTime);
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
                Id = input.ReadString();
                break;
              }
              case 18: {
                Version = input.ReadString();
                break;
              }
              case 32: {
                State = (global::Google.Cloud.DiscoveryEngine.V1Beta.Project.Types.ServiceTerms.Types.State) input.ReadEnum();
                break;
              }
              case 42: {
                if (acceptTime_ == null) {
                  AcceptTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
                }
                input.ReadMessage(AcceptTime);
                break;
              }
              case 50: {
                if (declineTime_ == null) {
                  DeclineTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
                }
                input.ReadMessage(DeclineTime);
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
                Id = input.ReadString();
                break;
              }
              case 18: {
                Version = input.ReadString();
                break;
              }
              case 32: {
                State = (global::Google.Cloud.DiscoveryEngine.V1Beta.Project.Types.ServiceTerms.Types.State) input.ReadEnum();
                break;
              }
              case 42: {
                if (acceptTime_ == null) {
                  AcceptTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
                }
                input.ReadMessage(AcceptTime);
                break;
              }
              case 50: {
                if (declineTime_ == null) {
                  DeclineTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
                }
                input.ReadMessage(DeclineTime);
                break;
              }
            }
          }
        }
        #endif

        #region Nested types
        /// <summary>Container for nested types declared in the ServiceTerms message type.</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static partial class Types {
          /// <summary>
          /// The agreement states this terms of service.
          /// </summary>
          public enum State {
            /// <summary>
            /// The default value of the enum. This value is not actually used.
            /// </summary>
            [pbr::OriginalName("STATE_UNSPECIFIED")] Unspecified = 0,
            /// <summary>
            /// The project has given consent to the terms of service.
            /// </summary>
            [pbr::OriginalName("TERMS_ACCEPTED")] TermsAccepted = 1,
            /// <summary>
            /// The project is pending to review and accept the terms of service.
            /// </summary>
            [pbr::OriginalName("TERMS_PENDING")] TermsPending = 2,
            /// <summary>
            /// The project has declined or revoked the agreement to terms of service.
            /// </summary>
            [pbr::OriginalName("TERMS_DECLINED")] TermsDeclined = 3,
          }

        }
        #endregion

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
