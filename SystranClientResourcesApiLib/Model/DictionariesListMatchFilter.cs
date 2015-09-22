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
  public class DictionariesListMatchFilter {
    
    /* Match all dictionaries with sourceLang present in a subset of values */
    [DataMember(Name="inSourceLang", EmitDefaultValue=false)]
    public List<string> InSourceLang { get; set; }

    
    /* Match all dictionaries with sourceLang not present in a subset of values */
    [DataMember(Name="ninSourceLang", EmitDefaultValue=false)]
    public List<string> NinSourceLang { get; set; }

    
    /* Match all dictionaries with targetLang from a subset of values present in targetLangs property */
    [DataMember(Name="inTargetLangs", EmitDefaultValue=false)]
    public List<string> InTargetLangs { get; set; }

    
    /* Match all entries with comments containing the specified value */
    [DataMember(Name="regexComments", EmitDefaultValue=false)]
    public string RegexComments { get; set; }

    
    /* Match all dictionaries with nbEntries present in a subset of values */
    [DataMember(Name="inNbEntries", EmitDefaultValue=false)]
    public List<int?> InNbEntries { get; set; }

    
    /* Match all dictionaries with nbEntries not present in a subset of values */
    [DataMember(Name="ninNbEntries", EmitDefaultValue=false)]
    public List<int?> NinNbEntries { get; set; }

    
    /* Match all entries with nbEntries equal and over specified value */
    [DataMember(Name="minNbEntries", EmitDefaultValue=false)]
    public int? MinNbEntries { get; set; }

    
    /* Match all entries with nbEntries under and equal specified value */
    [DataMember(Name="maxNbEntries", EmitDefaultValue=false)]
    public int? MaxNbEntries { get; set; }

    
    /* Match all entries with name present in a subset of values */
    [DataMember(Name="inName", EmitDefaultValue=false)]
    public List<string> InName { get; set; }

    
    /* Match all entries with name not present in a subset of values */
    [DataMember(Name="ninName", EmitDefaultValue=false)]
    public List<string> NinName { get; set; }

    
    /* Match all entries with name containing the specified value */
    [DataMember(Name="regexName", EmitDefaultValue=false)]
    public string RegexName { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DictionariesListMatchFilter {\n");
      
      sb.Append("  InSourceLang: ").Append(InSourceLang).Append("\n");
      
      sb.Append("  NinSourceLang: ").Append(NinSourceLang).Append("\n");
      
      sb.Append("  InTargetLangs: ").Append(InTargetLangs).Append("\n");
      
      sb.Append("  RegexComments: ").Append(RegexComments).Append("\n");
      
      sb.Append("  InNbEntries: ").Append(InNbEntries).Append("\n");
      
      sb.Append("  NinNbEntries: ").Append(NinNbEntries).Append("\n");
      
      sb.Append("  MinNbEntries: ").Append(MinNbEntries).Append("\n");
      
      sb.Append("  MaxNbEntries: ").Append(MaxNbEntries).Append("\n");
      
      sb.Append("  InName: ").Append(InName).Append("\n");
      
      sb.Append("  NinName: ").Append(NinName).Append("\n");
      
      sb.Append("  RegexName: ").Append(RegexName).Append("\n");
      
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