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
  public class LookupTargetObject {
    
    
    [DataMember(Name="context", EmitDefaultValue=false)]
    public string Context { get; set; }

    
    
    [DataMember(Name="domain", EmitDefaultValue=false)]
    public string Domain { get; set; }

    
    
    [DataMember(Name="entry_id", EmitDefaultValue=false)]
    public string EntryId { get; set; }

    
    
    [DataMember(Name="expressions", EmitDefaultValue=false)]
    public List<LookupExpressionObject> Expressions { get; set; }

    
    
    [DataMember(Name="invmeanings", EmitDefaultValue=false)]
    public List<string> Invmeanings { get; set; }

    
    
    [DataMember(Name="lemma", EmitDefaultValue=false)]
    public string Lemma { get; set; }

    
    
    [DataMember(Name="rank", EmitDefaultValue=false)]
    public string Rank { get; set; }

    
    
    [DataMember(Name="synonym", EmitDefaultValue=false)]
    public string Synonym { get; set; }

    
    
    [DataMember(Name="variant", EmitDefaultValue=false)]
    public string Variant { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class LookupTargetObject {\n");
      
      sb.Append("  Context: ").Append(Context).Append("\n");
      
      sb.Append("  Domain: ").Append(Domain).Append("\n");
      
      sb.Append("  EntryId: ").Append(EntryId).Append("\n");
      
      sb.Append("  Expressions: ").Append(Expressions).Append("\n");
      
      sb.Append("  Invmeanings: ").Append(Invmeanings).Append("\n");
      
      sb.Append("  Lemma: ").Append(Lemma).Append("\n");
      
      sb.Append("  Rank: ").Append(Rank).Append("\n");
      
      sb.Append("  Synonym: ").Append(Synonym).Append("\n");
      
      sb.Append("  Variant: ").Append(Variant).Append("\n");
      
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