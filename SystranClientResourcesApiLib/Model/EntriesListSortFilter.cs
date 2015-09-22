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
  public class EntriesListSortFilter {
    
    /* 1/-1 for ascending/descending order on source field */
    [DataMember(Name="source", EmitDefaultValue=false)]
    public int? Source { get; set; }

    
    /* 1/-1 for ascending/descending order on target field */
    [DataMember(Name="target", EmitDefaultValue=false)]
    public int? Target { get; set; }

    
    /* 1/-1 for ascending/descending order on partOfSpeech field */
    [DataMember(Name="partOfSpeech", EmitDefaultValue=false)]
    public int? PartOfSpeech { get; set; }

    
    /* 1/-1 for ascending/descending order on priority field */
    [DataMember(Name="priority", EmitDefaultValue=false)]
    public int? Priority { get; set; }

    
    /* 1/-1 for ascending/descending order on comments field */
    [DataMember(Name="comments", EmitDefaultValue=false)]
    public int? Comments { get; set; }

    
    /* 1/-1 for ascending/descending order on sourceConfidence field */
    [DataMember(Name="sourceConfidence", EmitDefaultValue=false)]
    public int? SourceConfidence { get; set; }

    
    /* 1/-1 for ascending/descending order on targetConfidence field */
    [DataMember(Name="targetConfidence", EmitDefaultValue=false)]
    public int? TargetConfidence { get; set; }

    
    /* 1/-1 for ascending/descending order on targetLang field */
    [DataMember(Name="targetLang", EmitDefaultValue=false)]
    public int? TargetLang { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EntriesListSortFilter {\n");
      
      sb.Append("  Source: ").Append(Source).Append("\n");
      
      sb.Append("  Target: ").Append(Target).Append("\n");
      
      sb.Append("  PartOfSpeech: ").Append(PartOfSpeech).Append("\n");
      
      sb.Append("  Priority: ").Append(Priority).Append("\n");
      
      sb.Append("  Comments: ").Append(Comments).Append("\n");
      
      sb.Append("  SourceConfidence: ").Append(SourceConfidence).Append("\n");
      
      sb.Append("  TargetConfidence: ").Append(TargetConfidence).Append("\n");
      
      sb.Append("  TargetLang: ").Append(TargetLang).Append("\n");
      
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