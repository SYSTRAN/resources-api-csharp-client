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
  public class CorpusSegmentAddRequest {
    
    /* Corpus identifier */
    [DataMember(Name="corpusId", EmitDefaultValue=false)]
    public string CorpusId { get; set; }

    
    /* List of segments to add */
    [DataMember(Name="segments", EmitDefaultValue=false)]
    public List<CorpusAddSegment> Segments { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CorpusSegmentAddRequest {\n");
      
      sb.Append("  CorpusId: ").Append(CorpusId).Append("\n");
      
      sb.Append("  Segments: ").Append(Segments).Append("\n");
      
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