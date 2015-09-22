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
  public class DictionariesListFilters {
    
    
    [DataMember(Name="skip", EmitDefaultValue=false)]
    public int? Skip { get; set; }

    
    
    [DataMember(Name="limit", EmitDefaultValue=false)]
    public int? Limit { get; set; }

    
    
    [DataMember(Name="sort", EmitDefaultValue=false)]
    public DictionariesListSortFilter Sort { get; set; }

    
    
    [DataMember(Name="match", EmitDefaultValue=false)]
    public DictionariesListMatchFilter Match { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DictionariesListFilters {\n");
      
      sb.Append("  Skip: ").Append(Skip).Append("\n");
      
      sb.Append("  Limit: ").Append(Limit).Append("\n");
      
      sb.Append("  Sort: ").Append(Sort).Append("\n");
      
      sb.Append("  Match: ").Append(Match).Append("\n");
      
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