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
  public class DictionariesImportResponse {
    
    /* Number of entries that was already present in the dictionary */
    [DataMember(Name="duplicates", EmitDefaultValue=false)]
    public int? Duplicates { get; set; }

    
    /* Number of entries succesfully inserted */
    [DataMember(Name="inserted", EmitDefaultValue=false)]
    public int? Inserted { get; set; }

    
    /* Number of entries processed */
    [DataMember(Name="total", EmitDefaultValue=false)]
    public int? Total { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DictionariesImportResponse {\n");
      
      sb.Append("  Duplicates: ").Append(Duplicates).Append("\n");
      
      sb.Append("  Inserted: ").Append(Inserted).Append("\n");
      
      sb.Append("  Total: ").Append(Total).Append("\n");
      
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