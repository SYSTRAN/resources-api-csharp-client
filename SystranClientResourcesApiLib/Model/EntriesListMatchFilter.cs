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
  public class EntriesListMatchFilter {
    
    /* Match all entries with source present in a subset of values */
    [DataMember(Name="inSource", EmitDefaultValue=false)]
    public List<string> InSource { get; set; }

    
    /* Match all entries with source not present in a subset of values */
    [DataMember(Name="ninSource", EmitDefaultValue=false)]
    public List<string> NinSource { get; set; }

    
    /* Match all entries with source containing the specified value */
    [DataMember(Name="regexSource", EmitDefaultValue=false)]
    public string RegexSource { get; set; }

    
    /* Match all entries with target present in a subset of values */
    [DataMember(Name="inTarget", EmitDefaultValue=false)]
    public List<string> InTarget { get; set; }

    
    /* Match all entries with target not present in a subset of values */
    [DataMember(Name="ninTarget", EmitDefaultValue=false)]
    public List<string> NinTarget { get; set; }

    
    /* Match all entries with target containing the specified value */
    [DataMember(Name="regexTarget", EmitDefaultValue=false)]
    public string RegexTarget { get; set; }

    
    /* Match all entries with part of speech present in a subset of values */
    [DataMember(Name="inPartOfSpeech", EmitDefaultValue=false)]
    public List<string> InPartOfSpeech { get; set; }

    
    /* Match all entries with part of speech not present in a subset of values */
    [DataMember(Name="ninPartOfSpeech", EmitDefaultValue=false)]
    public List<string> NinPartOfSpeech { get; set; }

    
    /* Match all entries with comments containing the specified value */
    [DataMember(Name="regexComments", EmitDefaultValue=false)]
    public string RegexComments { get; set; }

    
    /* Match all entries with target lang present in a subset of values */
    [DataMember(Name="inTargetLang", EmitDefaultValue=false)]
    public List<string> InTargetLang { get; set; }

    
    /* Match all entries with target lang not present in a subset of values */
    [DataMember(Name="ninTargetLang", EmitDefaultValue=false)]
    public List<string> NinTargetLang { get; set; }

    
    /* Match all entries with priority equal and over specified value */
    [DataMember(Name="minPriority", EmitDefaultValue=false)]
    public int? MinPriority { get; set; }

    
    /* Match all entries with priority under and equal specified value */
    [DataMember(Name="maxPriority", EmitDefaultValue=false)]
    public int? MaxPriority { get; set; }

    
    /* Match all entries with priority present in a subset of values */
    [DataMember(Name="inPriority", EmitDefaultValue=false)]
    public List<int?> InPriority { get; set; }

    
    /* Match all entries with priority not present in a subset of values */
    [DataMember(Name="ninPriority", EmitDefaultValue=false)]
    public List<int?> NinPriority { get; set; }

    
    /* Match all entries with source confidence equal and over specified value */
    [DataMember(Name="minSourceConfidence", EmitDefaultValue=false)]
    public int? MinSourceConfidence { get; set; }

    
    /* Match all entries with source confidence under and equal specified value */
    [DataMember(Name="maxSourceConfidence", EmitDefaultValue=false)]
    public int? MaxSourceConfidence { get; set; }

    
    /* Match all entries with sourceConfidence present in a subset of values */
    [DataMember(Name="inSourceConfidence", EmitDefaultValue=false)]
    public List<int?> InSourceConfidence { get; set; }

    
    /* Match all entries with sourceConfidence not present in a subset of values */
    [DataMember(Name="ninSourceConfidence", EmitDefaultValue=false)]
    public List<int?> NinSourceConfidence { get; set; }

    
    /* Match all entries with target confidence equal and over specified value */
    [DataMember(Name="minTargetConfidence", EmitDefaultValue=false)]
    public int? MinTargetConfidence { get; set; }

    
    /* Match all entries with target confidence under and equal specified value */
    [DataMember(Name="maxTargetConfidence", EmitDefaultValue=false)]
    public int? MaxTargetConfidence { get; set; }

    
    /* Match all entries with targetConfidence present in a subset of values */
    [DataMember(Name="inTargetConfidence", EmitDefaultValue=false)]
    public List<int?> InTargetConfidence { get; set; }

    
    /* Match all entries with targetConfidence not present in a subset of values */
    [DataMember(Name="ninTargetConfidence", EmitDefaultValue=false)]
    public List<int?> NinTargetConfidence { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EntriesListMatchFilter {\n");
      
      sb.Append("  InSource: ").Append(InSource).Append("\n");
      
      sb.Append("  NinSource: ").Append(NinSource).Append("\n");
      
      sb.Append("  RegexSource: ").Append(RegexSource).Append("\n");
      
      sb.Append("  InTarget: ").Append(InTarget).Append("\n");
      
      sb.Append("  NinTarget: ").Append(NinTarget).Append("\n");
      
      sb.Append("  RegexTarget: ").Append(RegexTarget).Append("\n");
      
      sb.Append("  InPartOfSpeech: ").Append(InPartOfSpeech).Append("\n");
      
      sb.Append("  NinPartOfSpeech: ").Append(NinPartOfSpeech).Append("\n");
      
      sb.Append("  RegexComments: ").Append(RegexComments).Append("\n");
      
      sb.Append("  InTargetLang: ").Append(InTargetLang).Append("\n");
      
      sb.Append("  NinTargetLang: ").Append(NinTargetLang).Append("\n");
      
      sb.Append("  MinPriority: ").Append(MinPriority).Append("\n");
      
      sb.Append("  MaxPriority: ").Append(MaxPriority).Append("\n");
      
      sb.Append("  InPriority: ").Append(InPriority).Append("\n");
      
      sb.Append("  NinPriority: ").Append(NinPriority).Append("\n");
      
      sb.Append("  MinSourceConfidence: ").Append(MinSourceConfidence).Append("\n");
      
      sb.Append("  MaxSourceConfidence: ").Append(MaxSourceConfidence).Append("\n");
      
      sb.Append("  InSourceConfidence: ").Append(InSourceConfidence).Append("\n");
      
      sb.Append("  NinSourceConfidence: ").Append(NinSourceConfidence).Append("\n");
      
      sb.Append("  MinTargetConfidence: ").Append(MinTargetConfidence).Append("\n");
      
      sb.Append("  MaxTargetConfidence: ").Append(MaxTargetConfidence).Append("\n");
      
      sb.Append("  InTargetConfidence: ").Append(InTargetConfidence).Append("\n");
      
      sb.Append("  NinTargetConfidence: ").Append(NinTargetConfidence).Append("\n");
      
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