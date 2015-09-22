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
  public class EntryOutput {
    
    
    [DataMember(Name="source", EmitDefaultValue=false)]
    public string Source { get; set; }

    
    
    [DataMember(Name="target", EmitDefaultValue=false)]
    public string Target { get; set; }

    
    
    [DataMember(Name="partOfSpeech", EmitDefaultValue=false)]
    public string PartOfSpeech { get; set; }

    
    
    [DataMember(Name="priority", EmitDefaultValue=false)]
    public int? Priority { get; set; }

    
    
    [DataMember(Name="comments", EmitDefaultValue=false)]
    public string Comments { get; set; }

    
    
    [DataMember(Name="sourceConfidence", EmitDefaultValue=false)]
    public int? SourceConfidence { get; set; }

    
    
    [DataMember(Name="targetConfidence", EmitDefaultValue=false)]
    public int? TargetConfidence { get; set; }

    
    
    [DataMember(Name="sourceLang", EmitDefaultValue=false)]
    public string SourceLang { get; set; }

    
    
    [DataMember(Name="targetLang", EmitDefaultValue=false)]
    public string TargetLang { get; set; }

    
    
    [DataMember(Name="sourceId", EmitDefaultValue=false)]
    public string SourceId { get; set; }

    
    
    [DataMember(Name="targetId", EmitDefaultValue=false)]
    public string TargetId { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EntryOutput {\n");
      
      sb.Append("  Source: ").Append(Source).Append("\n");
      
      sb.Append("  Target: ").Append(Target).Append("\n");
      
      sb.Append("  PartOfSpeech: ").Append(PartOfSpeech).Append("\n");
      
      sb.Append("  Priority: ").Append(Priority).Append("\n");
      
      sb.Append("  Comments: ").Append(Comments).Append("\n");
      
      sb.Append("  SourceConfidence: ").Append(SourceConfidence).Append("\n");
      
      sb.Append("  TargetConfidence: ").Append(TargetConfidence).Append("\n");
      
      sb.Append("  SourceLang: ").Append(SourceLang).Append("\n");
      
      sb.Append("  TargetLang: ").Append(TargetLang).Append("\n");
      
      sb.Append("  SourceId: ").Append(SourceId).Append("\n");
      
      sb.Append("  TargetId: ").Append(TargetId).Append("\n");
      
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