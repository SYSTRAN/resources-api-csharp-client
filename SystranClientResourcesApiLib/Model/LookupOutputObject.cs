using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Systran.ResourcesClientLib.Model {

  /// <summary>
  /// Output for a word
  /// </summary>
  [DataContract]
  public class LookupOutputObject {
    
    
    [DataMember(Name="autoComplete", EmitDefaultValue=false)]
    public bool? AutoComplete { get; set; }

    
    
    [DataMember(Name="sDictSeach", EmitDefaultValue=false)]
    public bool? SDictSeach { get; set; }

    
    
    [DataMember(Name="matches", EmitDefaultValue=false)]
    public List<LookupMatchObject> Matches { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class LookupOutputObject {\n");
      
      sb.Append("  AutoComplete: ").Append(AutoComplete).Append("\n");
      
      sb.Append("  SDictSeach: ").Append(SDictSeach).Append("\n");
      
      sb.Append("  Matches: ").Append(Matches).Append("\n");
      
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