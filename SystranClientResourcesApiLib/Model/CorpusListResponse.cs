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
  public class CorpusListResponse {
    
    /* List of corpus files */
    [DataMember(Name="files", EmitDefaultValue=false)]
    public List<Corpus> Files { get; set; }

    
    /* List of directories. Returned only if directory parameter was specified in the request. */
    [DataMember(Name="directories", EmitDefaultValue=false)]
    public List<string> Directories { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CorpusListResponse {\n");
      
      sb.Append("  Files: ").Append(Files).Append("\n");
      
      sb.Append("  Directories: ").Append(Directories).Append("\n");
      
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