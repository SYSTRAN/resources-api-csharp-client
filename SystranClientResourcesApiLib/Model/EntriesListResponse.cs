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
  public class EntriesListResponse {
    
    /* Number of entries without skip/limit filter */
    [DataMember(Name="totalNoLimit", EmitDefaultValue=false)]
    public int? TotalNoLimit { get; set; }

    
    /* List of entries */
    [DataMember(Name="entries", EmitDefaultValue=false)]
    public List<EntryOutput> Entries { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EntriesListResponse {\n");
      
      sb.Append("  TotalNoLimit: ").Append(TotalNoLimit).Append("\n");
      
      sb.Append("  Entries: ").Append(Entries).Append("\n");
      
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