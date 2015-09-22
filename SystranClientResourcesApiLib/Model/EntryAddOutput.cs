using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Systran.ResourcesClientLib.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class EntryAddOutput {
    
    
    [DataMember(Name="confidence", EmitDefaultValue=false)]
    public string Confidence { get; set; }

    
    
    [DataMember(Name="sourceId", EmitDefaultValue=false)]
    public string SourceId { get; set; }

    
    
    [DataMember(Name="targetId", EmitDefaultValue=false)]
    public string TargetId { get; set; }

    
    
    [DataMember(Name="pos", EmitDefaultValue=false)]
    public string Pos { get; set; }

    
    
    [DataMember(Name="targetPos", EmitDefaultValue=false)]
    public string TargetPos { get; set; }

    
    
    [DataMember(Name="source", EmitDefaultValue=false)]
    public string Source { get; set; }

    
    
    [DataMember(Name="target", EmitDefaultValue=false)]
    public string Target { get; set; }

    
    
    [DataMember(Name="type", EmitDefaultValue=false)]
    public string Type { get; set; }

    
    
    [DataMember(Name="status", EmitDefaultValue=false)]
    public string Status { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EntryAddOutput {\n");
      
      sb.Append("  Confidence: ").Append(Confidence).Append("\n");
      
      sb.Append("  SourceId: ").Append(SourceId).Append("\n");
      
      sb.Append("  TargetId: ").Append(TargetId).Append("\n");
      
      sb.Append("  Pos: ").Append(Pos).Append("\n");
      
      sb.Append("  TargetPos: ").Append(TargetPos).Append("\n");
      
      sb.Append("  Source: ").Append(Source).Append("\n");
      
      sb.Append("  Target: ").Append(Target).Append("\n");
      
      sb.Append("  Type: ").Append(Type).Append("\n");
      
      sb.Append("  Status: ").Append(Status).Append("\n");
      
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
  
  
}