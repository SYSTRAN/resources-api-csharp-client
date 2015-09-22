using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Systran.ResourcesClientLib.Model {

  /// <summary>
  /// Corpus match
  /// </summary>
  [DataContract]
  public class CorpusMatch {
    
    
    [DataMember(Name="source", EmitDefaultValue=false)]
    public string Source { get; set; }

    
    
    [DataMember(Name="target", EmitDefaultValue=false)]
    public string Target { get; set; }

    
    
    [DataMember(Name="score", EmitDefaultValue=false)]
    public double? Score { get; set; }

    
    
    [DataMember(Name="penalty", EmitDefaultValue=false)]
    public double? Penalty { get; set; }

    
    
    [DataMember(Name="align", EmitDefaultValue=false)]
    public string Align { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CorpusMatch {\n");
      
      sb.Append("  Source: ").Append(Source).Append("\n");
      
      sb.Append("  Target: ").Append(Target).Append("\n");
      
      sb.Append("  Score: ").Append(Score).Append("\n");
      
      sb.Append("  Penalty: ").Append(Penalty).Append("\n");
      
      sb.Append("  Align: ").Append(Align).Append("\n");
      
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