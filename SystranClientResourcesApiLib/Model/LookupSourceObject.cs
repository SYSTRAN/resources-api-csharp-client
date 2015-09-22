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
  public class LookupSourceObject {
    
    
    [DataMember(Name="inflection", EmitDefaultValue=false)]
    public string Inflection { get; set; }

    
    
    [DataMember(Name="info", EmitDefaultValue=false)]
    public string Info { get; set; }

    
    
    [DataMember(Name="lemma", EmitDefaultValue=false)]
    public string Lemma { get; set; }

    
    
    [DataMember(Name="phonetic", EmitDefaultValue=false)]
    public string Phonetic { get; set; }

    
    
    [DataMember(Name="pos", EmitDefaultValue=false)]
    public string Pos { get; set; }

    
    
    [DataMember(Name="term", EmitDefaultValue=false)]
    public string Term { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class LookupSourceObject {\n");
      
      sb.Append("  Inflection: ").Append(Inflection).Append("\n");
      
      sb.Append("  Info: ").Append(Info).Append("\n");
      
      sb.Append("  Lemma: ").Append(Lemma).Append("\n");
      
      sb.Append("  Phonetic: ").Append(Phonetic).Append("\n");
      
      sb.Append("  Pos: ").Append(Pos).Append("\n");
      
      sb.Append("  Term: ").Append(Term).Append("\n");
      
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