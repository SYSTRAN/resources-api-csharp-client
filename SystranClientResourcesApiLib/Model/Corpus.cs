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
  public class Corpus {
    
    /* Identifier */
    [DataMember(Name="id", EmitDefaultValue=false)]
    public string Id { get; set; }

    
    /* Name */
    [DataMember(Name="name", EmitDefaultValue=false)]
    public string Name { get; set; }

    
    /* Creation date */
    [DataMember(Name="createdAt", EmitDefaultValue=false)]
    public string CreatedAt { get; set; }

    
    /* Format */
    [DataMember(Name="format", EmitDefaultValue=false)]
    public string Format { get; set; }

    
    /* Number of segments */
    [DataMember(Name="nbSegments", EmitDefaultValue=false)]
    public int? NbSegments { get; set; }

    
    /* Source language */
    [DataMember(Name="sourceLang", EmitDefaultValue=false)]
    public string SourceLang { get; set; }

    
    /* Target languages */
    [DataMember(Name="targetLangs", EmitDefaultValue=false)]
    public List<string> TargetLangs { get; set; }

    
    /* Corpus status */
    [DataMember(Name="status", EmitDefaultValue=false)]
    public string Status { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Corpus {\n");
      
      sb.Append("  Id: ").Append(Id).Append("\n");
      
      sb.Append("  Name: ").Append(Name).Append("\n");
      
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      
      sb.Append("  Format: ").Append(Format).Append("\n");
      
      sb.Append("  NbSegments: ").Append(NbSegments).Append("\n");
      
      sb.Append("  SourceLang: ").Append(SourceLang).Append("\n");
      
      sb.Append("  TargetLangs: ").Append(TargetLangs).Append("\n");
      
      sb.Append("  Status: ").Append(Status).Append("\n");
      
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