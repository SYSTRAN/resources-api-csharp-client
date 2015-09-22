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
  public class LookupMatchObject {
    
    
    [DataMember(Name="auto_complete", EmitDefaultValue=false)]
    public bool? AutoComplete { get; set; }

    
    
    [DataMember(Name="model_name", EmitDefaultValue=false)]
    public string ModelName { get; set; }

    
    
    [DataMember(Name="source", EmitDefaultValue=false)]
    public LookupSourceObject Source { get; set; }

    
    
    [DataMember(Name="target", EmitDefaultValue=false)]
    public LookupTargetObject Target { get; set; }

    
    
    [DataMember(Name="other_expressions", EmitDefaultValue=false)]
    public List<LookupOtherExpression> OtherExpressions { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class LookupMatchObject {\n");
      
      sb.Append("  AutoComplete: ").Append(AutoComplete).Append("\n");
      
      sb.Append("  ModelName: ").Append(ModelName).Append("\n");
      
      sb.Append("  Source: ").Append(Source).Append("\n");
      
      sb.Append("  Target: ").Append(Target).Append("\n");
      
      sb.Append("  OtherExpressions: ").Append(OtherExpressions).Append("\n");
      
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