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
  public class CorpusSegmentAddTargetRequest {
    
    /* Corpus identifier */
    [DataMember(Name="corpusId", EmitDefaultValue=false)]
    public string CorpusId { get; set; }

    
    /* Segment identifier */
    [DataMember(Name="segId", EmitDefaultValue=false)]
    public string SegId { get; set; }

    
    /* List of targets */
    [DataMember(Name="targets", EmitDefaultValue=false)]
    public List<CorpusAddSegmentTarget> Targets { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CorpusSegmentAddTargetRequest {\n");
      
      sb.Append("  CorpusId: ").Append(CorpusId).Append("\n");
      
      sb.Append("  SegId: ").Append(SegId).Append("\n");
      
      sb.Append("  Targets: ").Append(Targets).Append("\n");
      
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