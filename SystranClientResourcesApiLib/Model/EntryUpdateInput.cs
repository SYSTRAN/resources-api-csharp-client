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
  public class EntryUpdateInput {
    
    
    [DataMember(Name="sourceLang", EmitDefaultValue=false)]
    public string SourceLang { get; set; }

    
    
    [DataMember(Name="targetLang", EmitDefaultValue=false)]
    public string TargetLang { get; set; }

    
    
    [DataMember(Name="source", EmitDefaultValue=false)]
    public string Source { get; set; }

    
    
    [DataMember(Name="target", EmitDefaultValue=false)]
    public string Target { get; set; }

    
    
    [DataMember(Name="type", EmitDefaultValue=false)]
    public string Type { get; set; }

    
    
    [DataMember(Name="sourcePos", EmitDefaultValue=false)]
    public string SourcePos { get; set; }

    
    
    [DataMember(Name="targetPos", EmitDefaultValue=false)]
    public string TargetPos { get; set; }

    
    
    [DataMember(Name="priority", EmitDefaultValue=false)]
    public string Priority { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EntryUpdateInput {\n");
      
      sb.Append("  SourceLang: ").Append(SourceLang).Append("\n");
      
      sb.Append("  TargetLang: ").Append(TargetLang).Append("\n");
      
      sb.Append("  Source: ").Append(Source).Append("\n");
      
      sb.Append("  Target: ").Append(Target).Append("\n");
      
      sb.Append("  Type: ").Append(Type).Append("\n");
      
      sb.Append("  SourcePos: ").Append(SourcePos).Append("\n");
      
      sb.Append("  TargetPos: ").Append(TargetPos).Append("\n");
      
      sb.Append("  Priority: ").Append(Priority).Append("\n");
      
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