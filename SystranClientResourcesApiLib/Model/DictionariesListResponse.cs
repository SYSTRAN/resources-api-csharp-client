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
  public class DictionariesListResponse {
    
    /* Number of dictionaries without skip/limit filter */
    [DataMember(Name="totalNoLimit", EmitDefaultValue=false)]
    public int? TotalNoLimit { get; set; }

    
    /* List of dictionaries */
    [DataMember(Name="dictionaries", EmitDefaultValue=false)]
    public List<DictionaryOutput> Dictionaries { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DictionariesListResponse {\n");
      
      sb.Append("  TotalNoLimit: ").Append(TotalNoLimit).Append("\n");
      
      sb.Append("  Dictionaries: ").Append(Dictionaries).Append("\n");
      
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