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
  public class CorpusMatches {
    
    /* Searched form */
    [DataMember(Name="form", EmitDefaultValue=false)]
    public string Form { get; set; }

    
    /* List of matches */
    [DataMember(Name="matches", EmitDefaultValue=false)]
    public List<CorpusMatch> Matches { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CorpusMatches {\n");
      
      sb.Append("  Form: ").Append(Form).Append("\n");
      
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