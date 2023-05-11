// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/maps/places/v1/geometry.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Maps.Places.V1 {

  /// <summary>Holder for reflection information generated from google/maps/places/v1/geometry.proto</summary>
  public static partial class GeometryReflection {

    #region Descriptor
    /// <summary>File descriptor for google/maps/places/v1/geometry.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GeometryReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRnb29nbGUvbWFwcy9wbGFjZXMvdjEvZ2VvbWV0cnkucHJvdG8SFWdvb2ds",
            "ZS5tYXBzLnBsYWNlcy52MRofZ29vZ2xlL2FwaS9maWVsZF9iZWhhdmlvci5w",
            "cm90bxoYZ29vZ2xlL3R5cGUvbGF0bG5nLnByb3RvIkcKBkNpcmNsZRIoCgZj",
            "ZW50ZXIYASABKAsyEy5nb29nbGUudHlwZS5MYXRMbmdCA+BBAhITCgZyYWRp",
            "dXMYAiABKAFCA+BBAkKlAQoZY29tLmdvb2dsZS5tYXBzLnBsYWNlcy52MUIN",
            "R2VvbWV0cnlQcm90b1ABWjtnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9n",
            "b29nbGVhcGlzL21hcHMvcGxhY2VzL3YxO3BsYWNlc/gBAaICBkdNUFNWMaoC",
            "FUdvb2dsZS5NYXBzLlBsYWNlcy5WMcoCFUdvb2dsZVxNYXBzXFBsYWNlc1xW",
            "MWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Type.LatlngReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Maps.Places.V1.Circle), global::Google.Maps.Places.V1.Circle.Parser, new[]{ "Center", "Radius" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Circle with a LatLng as center and radius.
  /// </summary>
  public sealed partial class Circle : pb::IMessage<Circle>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Circle> _parser = new pb::MessageParser<Circle>(() => new Circle());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Circle> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Maps.Places.V1.GeometryReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Circle() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Circle(Circle other) : this() {
      center_ = other.center_ != null ? other.center_.Clone() : null;
      radius_ = other.radius_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Circle Clone() {
      return new Circle(this);
    }

    /// <summary>Field number for the "center" field.</summary>
    public const int CenterFieldNumber = 1;
    private global::Google.Type.LatLng center_;
    /// <summary>
    /// Required. Center latitude and longitude.
    ///
    /// The range of latitude must be within `[-90.0, 90.0]`. The range of the
    /// longitude must be within `[-180.0, 180.0]`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Type.LatLng Center {
      get { return center_; }
      set {
        center_ = value;
      }
    }

    /// <summary>Field number for the "radius" field.</summary>
    public const int RadiusFieldNumber = 2;
    private double radius_;
    /// <summary>
    /// Required. Radius measured in meters. The radius must be within `[0.0,
    /// 50000.0]`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Radius {
      get { return radius_; }
      set {
        radius_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Circle);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Circle other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Center, other.Center)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Radius, other.Radius)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (center_ != null) hash ^= Center.GetHashCode();
      if (Radius != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Radius);
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
      if (center_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Center);
      }
      if (Radius != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(Radius);
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
      if (center_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Center);
      }
      if (Radius != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(Radius);
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
      if (center_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Center);
      }
      if (Radius != 0D) {
        size += 1 + 8;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Circle other) {
      if (other == null) {
        return;
      }
      if (other.center_ != null) {
        if (center_ == null) {
          Center = new global::Google.Type.LatLng();
        }
        Center.MergeFrom(other.Center);
      }
      if (other.Radius != 0D) {
        Radius = other.Radius;
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
            if (center_ == null) {
              Center = new global::Google.Type.LatLng();
            }
            input.ReadMessage(Center);
            break;
          }
          case 17: {
            Radius = input.ReadDouble();
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
            if (center_ == null) {
              Center = new global::Google.Type.LatLng();
            }
            input.ReadMessage(Center);
            break;
          }
          case 17: {
            Radius = input.ReadDouble();
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