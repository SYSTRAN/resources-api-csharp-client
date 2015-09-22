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
  public class DictionariesListSortFilter {
    
    /* 1/-1 for ascending/descending order on nbEntries field */
    [DataMember(Name="nbEntries", EmitDefaultValue=false)]
    public int? NbEntries { get; set; }

    
    /* 1/-1 for ascending/descending order on comments field */
    [DataMember(Name="comments", EmitDefaultValue=false)]
    public int? Comments { get; set; }

    
    /* 1/-1 for ascending/descending order on name field */
    [DataMember(Name="name", EmitDefaultValue=false)]
    public int? Name { get; set; }

    
    /* 1/-1 for ascending/descending order on sourceLang field */
    [DataMember(Name="sourceLang", EmitDefaultValue=false)]
    public int? SourceLang { get; set; }

    
    /* 1/-1 for ascending/descending order on targetLangs field */
    [DataMember(Name="targetLangs", EmitDefaultValue=false)]
    public int? TargetLangs { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DictionariesListSortFilter {\n");
      
      sb.Append("  NbEntries: ").Append(NbEntries).Append("\n");
      
      sb.Append("  Comments: ").Append(Comments).Append("\n");
      
      sb.Append("  Name: ").Append(Name).Append("\n");
      
      sb.Append("  SourceLang: ").Append(SourceLang).Append("\n");
      
      sb.Append("  TargetLangs: ").Append(TargetLangs).Append("\n");
      
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