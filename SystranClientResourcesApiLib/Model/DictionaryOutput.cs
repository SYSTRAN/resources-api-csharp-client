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
  public class DictionaryOutput {
    
    
    [DataMember(Name="nbEntries", EmitDefaultValue=false)]
    public int? NbEntries { get; set; }

    
    
    [DataMember(Name="targetLangs", EmitDefaultValue=false)]
    public string TargetLangs { get; set; }

    
    
    [DataMember(Name="sourceLang", EmitDefaultValue=false)]
    public string SourceLang { get; set; }

    
    
    [DataMember(Name="name", EmitDefaultValue=false)]
    public string Name { get; set; }

    
    
    [DataMember(Name="comments", EmitDefaultValue=false)]
    public string Comments { get; set; }

    
    
    [DataMember(Name="type", EmitDefaultValue=false)]
    public string Type { get; set; }

    
    
    [DataMember(Name="id", EmitDefaultValue=false)]
    public string Id { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DictionaryOutput {\n");
      
      sb.Append("  NbEntries: ").Append(NbEntries).Append("\n");
      
      sb.Append("  TargetLangs: ").Append(TargetLangs).Append("\n");
      
      sb.Append("  SourceLang: ").Append(SourceLang).Append("\n");
      
      sb.Append("  Name: ").Append(Name).Append("\n");
      
      sb.Append("  Comments: ").Append(Comments).Append("\n");
      
      sb.Append("  Type: ").Append(Type).Append("\n");
      
      sb.Append("  Id: ").Append(Id).Append("\n");
      
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