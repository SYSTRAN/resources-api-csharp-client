using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using Systran.ResourcesClientLib.Client;
using Systran.ResourcesClientLib.Model;

namespace Systran.ResourcesClientLib.Api {
  

  public interface ICorpusApi {
    
    /// <summary>
    /// Add a new corpus Add a new empty corpus.\n
    /// </summary>
    /// <param name="Name">Corpus name. The name also contains the directories (ex: \&quot;/myproject/firstPass/PersonalCorpus\&quot;)</param>/// <param name="Lang">Language code ([details](#description_langage_code_values))</param>/// <param name="Tag">Tag for the the corpus (this parameter can be repeated)</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>CorpusAddResponse</returns>
    CorpusAddResponse ResourcesCorpusAddPost (string Name, string Lang, List<string> Tag, string Callback);

    /// <summary>
    /// Add a new corpus Add a new empty corpus.\n
    /// </summary>
    /// <param name="Name">Corpus name. The name also contains the directories (ex: \&quot;/myproject/firstPass/PersonalCorpus\&quot;)</param>/// <param name="Lang">Language code ([details](#description_langage_code_values))</param>/// <param name="Tag">Tag for the the corpus (this parameter can be repeated)</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>CorpusAddResponse</returns>
    Task<CorpusAddResponse> ResourcesCorpusAddPostAsync (string Name, string Lang, List<string> Tag, string Callback);
    
    /// <summary>
    /// Delete corpus Delete a corpus.\n
    /// </summary>
    /// <param name="CorpusId">Corpus identifier (this parameter can be repeated)</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>CorpusDeleteResponse</returns>
    CorpusDeleteResponse ResourcesCorpusDeletePost (List<string> CorpusId, string Callback);

    /// <summary>
    /// Delete corpus Delete a corpus.\n
    /// </summary>
    /// <param name="CorpusId">Corpus identifier (this parameter can be repeated)</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>CorpusDeleteResponse</returns>
    Task<CorpusDeleteResponse> ResourcesCorpusDeletePostAsync (List<string> CorpusId, string Callback);
    
    /// <summary>
    /// Detail corpus Get detailed information about a corpus.\n
    /// </summary>
    /// <param name="CorpusId">Corpus identifier</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>CorpusDetailResponse</returns>
    CorpusDetailResponse ResourcesCorpusDetailsGet (string CorpusId, string Callback);

    /// <summary>
    /// Detail corpus Get detailed information about a corpus.\n
    /// </summary>
    /// <param name="CorpusId">Corpus identifier</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>CorpusDetailResponse</returns>
    Task<CorpusDetailResponse> ResourcesCorpusDetailsGetAsync (string CorpusId, string Callback);
    
    /// <summary>
    /// Corpus Exists Check if a corpus exists\n
    /// </summary>
    /// <param name="Name">Corpus name. The name also contains the directories (ex: \&quot;/myproject/firstPass/PersonalCorpus\&quot;)</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>CorpusExistsResponse</returns>
    CorpusExistsResponse ResourcesCorpusExistsGet (string Name, string Callback);

    /// <summary>
    /// Corpus Exists Check if a corpus exists\n
    /// </summary>
    /// <param name="Name">Corpus name. The name also contains the directories (ex: \&quot;/myproject/firstPass/PersonalCorpus\&quot;)</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>CorpusExistsResponse</returns>
    Task<CorpusExistsResponse> ResourcesCorpusExistsGetAsync (string Name, string Callback);
    
    /// <summary>
    /// Export corpus Download a corpus in an expected format.\n
    /// </summary>
    /// <param name="CorpusId">Corpus identifier</param>/// <param name="Format">The expected corpus format\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>string</returns>
    string ResourcesCorpusExportGet (string CorpusId, string Format, string Callback);

    /// <summary>
    /// Export corpus Download a corpus in an expected format.\n
    /// </summary>
    /// <param name="CorpusId">Corpus identifier</param>/// <param name="Format">The expected corpus format\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>string</returns>
    Task<string> ResourcesCorpusExportGetAsync (string CorpusId, string Format, string Callback);
    
    /// <summary>
    /// Import corpus Add a new corpus from an existing corpus.\n
    /// </summary>
    /// <param name="Name">Corpus name. The name also contains the directories (ex: \&quot;/myproject/firstPass/PersonalCorpus\&quot;)</param>/// <param name="Input">Content of the existing corpus\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="InputFile">Content of the existing corpus\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Format">Format of the input corpus.\n</param>/// <param name="Tag">Tag for the the corpus (this parameter can be repeated)</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>CorpusImportResponse</returns>
    CorpusImportResponse ResourcesCorpusImportPost (string Name, string Input, string InputFile, string Format, List<string> Tag, string Callback);

    /// <summary>
    /// Import corpus Add a new corpus from an existing corpus.\n
    /// </summary>
    /// <param name="Name">Corpus name. The name also contains the directories (ex: \&quot;/myproject/firstPass/PersonalCorpus\&quot;)</param>/// <param name="Input">Content of the existing corpus\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="InputFile">Content of the existing corpus\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Format">Format of the input corpus.\n</param>/// <param name="Tag">Tag for the the corpus (this parameter can be repeated)</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>CorpusImportResponse</returns>
    Task<CorpusImportResponse> ResourcesCorpusImportPostAsync (string Name, string Input, string InputFile, string Format, List<string> Tag, string Callback);
    
    /// <summary>
    /// List corpora List available corpora. Parameters can be used to restrict the list of returned corpora.\n
    /// </summary>
    /// <param name="SourceLang">Source language code ([details](#description_langage_code_values))</param>/// <param name="TargetLang">Target language code ([details](#description_langage_code_values))</param>/// <param name="WithoutPending">Filter out corpora in \&quot;pending\&quot; status\n</param>/// <param name="WithoutError">Filter out corpora in \&quot;error\&quot; status\n</param>/// <param name="Prefix">Prefix of the corpus name\n</param>/// <param name="Directory">If specified, response will return the content of this directory, including corpora and directories. This list can can also be filtered by the prefix parameter.\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>CorpusListResponse</returns>
    CorpusListResponse ResourcesCorpusListGet (string SourceLang, string TargetLang, bool? WithoutPending, bool? WithoutError, string Prefix, string Directory, string Callback);

    /// <summary>
    /// List corpora List available corpora. Parameters can be used to restrict the list of returned corpora.\n
    /// </summary>
    /// <param name="SourceLang">Source language code ([details](#description_langage_code_values))</param>/// <param name="TargetLang">Target language code ([details](#description_langage_code_values))</param>/// <param name="WithoutPending">Filter out corpora in \&quot;pending\&quot; status\n</param>/// <param name="WithoutError">Filter out corpora in \&quot;error\&quot; status\n</param>/// <param name="Prefix">Prefix of the corpus name\n</param>/// <param name="Directory">If specified, response will return the content of this directory, including corpora and directories. This list can can also be filtered by the prefix parameter.\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>CorpusListResponse</returns>
    Task<CorpusListResponse> ResourcesCorpusListGetAsync (string SourceLang, string TargetLang, bool? WithoutPending, bool? WithoutError, string Prefix, string Directory, string Callback);
    
    /// <summary>
    /// Corpus Match Find sentences in the corpus that match the input text from a given threshold.\n
    /// </summary>
    /// <param name="CorpusId">Corpus identifier (this parameter can be repeated)</param>/// <param name="Input">Text is used to perform the match operation (this parameter can be repeated)\n</param>/// <param name="SourceLang">Source language code ([details](#description_langage_code_values))</param>/// <param name="TargetLang">Target language code ([details](#description_langage_code_values))</param>/// <param name="Threshold">The fuzzy match threshold from which a sentence will be considered as a match result\n</param>/// <param name="Limit">Limit the number of returned matches. Only first matches within the \&quot;limit\&quot; will be returned\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>CorpusMatchResponse</returns>
    CorpusMatchResponse ResourcesCorpusMatchGet (List<string> CorpusId, List<string> Input, string SourceLang, string TargetLang, double? Threshold, int? Limit, string Callback);

    /// <summary>
    /// Corpus Match Find sentences in the corpus that match the input text from a given threshold.\n
    /// </summary>
    /// <param name="CorpusId">Corpus identifier (this parameter can be repeated)</param>/// <param name="Input">Text is used to perform the match operation (this parameter can be repeated)\n</param>/// <param name="SourceLang">Source language code ([details](#description_langage_code_values))</param>/// <param name="TargetLang">Target language code ([details](#description_langage_code_values))</param>/// <param name="Threshold">The fuzzy match threshold from which a sentence will be considered as a match result\n</param>/// <param name="Limit">Limit the number of returned matches. Only first matches within the \&quot;limit\&quot; will be returned\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>CorpusMatchResponse</returns>
    Task<CorpusMatchResponse> ResourcesCorpusMatchGetAsync (List<string> CorpusId, List<string> Input, string SourceLang, string TargetLang, double? Threshold, int? Limit, string Callback);
    
    /// <summary>
    /// Add corpus segments Add segments in a corpus.\n
    /// </summary>
    /// <param name="Body">List of segments to add</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>CorpusSegmentAddResponse</returns>
    CorpusSegmentAddResponse ResourcesCorpusSegmentAddPost (CorpusSegmentAddRequest Body, string Callback);

    /// <summary>
    /// Add corpus segments Add segments in a corpus.\n
    /// </summary>
    /// <param name="Body">List of segments to add</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>CorpusSegmentAddResponse</returns>
    Task<CorpusSegmentAddResponse> ResourcesCorpusSegmentAddPostAsync (CorpusSegmentAddRequest Body, string Callback);
    
    /// <summary>
    /// Delete corpus segments Delete segments in a corpus.\n
    /// </summary>
    /// <param name="CorpusId">Corpus identifier</param>/// <param name="SegId">Segment Id (this parameter can be repeated)</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>CorpusSegmentDeleteResponse</returns>
    CorpusSegmentDeleteResponse ResourcesCorpusSegmentDeletePost (string CorpusId, List<string> SegId, string Callback);

    /// <summary>
    /// Delete corpus segments Delete segments in a corpus.\n
    /// </summary>
    /// <param name="CorpusId">Corpus identifier</param>/// <param name="SegId">Segment Id (this parameter can be repeated)</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>CorpusSegmentDeleteResponse</returns>
    Task<CorpusSegmentDeleteResponse> ResourcesCorpusSegmentDeletePostAsync (string CorpusId, List<string> SegId, string Callback);
    
    /// <summary>
    /// List corpus segments List segments in a corpus.\n
    /// </summary>
    /// <param name="CorpusId">Corpus identifier</param>/// <param name="Skip">Skip first found segments in the response\n</param>/// <param name="Limit">Limit the number of returned segments\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>CorpusSegmentListResponse</returns>
    CorpusSegmentListResponse ResourcesCorpusSegmentListGet (string CorpusId, int? Skip, int? Limit, string Callback);

    /// <summary>
    /// List corpus segments List segments in a corpus.\n
    /// </summary>
    /// <param name="CorpusId">Corpus identifier</param>/// <param name="Skip">Skip first found segments in the response\n</param>/// <param name="Limit">Limit the number of returned segments\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>CorpusSegmentListResponse</returns>
    Task<CorpusSegmentListResponse> ResourcesCorpusSegmentListGetAsync (string CorpusId, int? Skip, int? Limit, string Callback);
    
    /// <summary>
    /// Add corpus segment targets Add targets to a segment in a corpus.\n
    /// </summary>
    /// <param name="Body">List of targets to add</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>CorpusSegmentAddTargetResponse</returns>
    CorpusSegmentAddTargetResponse ResourcesCorpusSegmentTargetAddPost (CorpusSegmentAddTargetRequest Body, string Callback);

    /// <summary>
    /// Add corpus segment targets Add targets to a segment in a corpus.\n
    /// </summary>
    /// <param name="Body">List of targets to add</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>CorpusSegmentAddTargetResponse</returns>
    Task<CorpusSegmentAddTargetResponse> ResourcesCorpusSegmentTargetAddPostAsync (CorpusSegmentAddTargetRequest Body, string Callback);
    
    /// <summary>
    /// Delete corpus segment targets Delete segment targets in a corpus.\n
    /// </summary>
    /// <param name="CorpusId">Corpus identifier</param>/// <param name="SegId">Segment Id</param>/// <param name="TargetId">Target id (this parameter can be repeated)</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>CorpusSegmentDeleteTargetResponse</returns>
    CorpusSegmentDeleteTargetResponse ResourcesCorpusSegmentTargetDeletePost (string CorpusId, string SegId, List<string> TargetId, string Callback);

    /// <summary>
    /// Delete corpus segment targets Delete segment targets in a corpus.\n
    /// </summary>
    /// <param name="CorpusId">Corpus identifier</param>/// <param name="SegId">Segment Id</param>/// <param name="TargetId">Target id (this parameter can be repeated)</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>CorpusSegmentDeleteTargetResponse</returns>
    Task<CorpusSegmentDeleteTargetResponse> ResourcesCorpusSegmentTargetDeletePostAsync (string CorpusId, string SegId, List<string> TargetId, string Callback);
    
    /// <summary>
    /// Update corpus segment Update a segment in a corpus.\n
    /// </summary>
    /// <param name="CorpusId">Corpus identifier</param>/// <param name="SegId">Segment Id</param>/// <param name="Source">Source text</param>/// <param name="TargetId">Target id</param>/// <param name="Target">Target text. `targetId` is required if `target` is specified.</param>/// <param name="TargetLang">Target language. `targetId` is required if `targetLang` is specified.</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>CorpusSegmentUpdateResponse</returns>
    CorpusSegmentUpdateResponse ResourcesCorpusSegmentUpdatePost (string CorpusId, string SegId, string Source, string TargetId, string Target, string TargetLang, string Callback);

    /// <summary>
    /// Update corpus segment Update a segment in a corpus.\n
    /// </summary>
    /// <param name="CorpusId">Corpus identifier</param>/// <param name="SegId">Segment Id</param>/// <param name="Source">Source text</param>/// <param name="TargetId">Target id</param>/// <param name="Target">Target text. `targetId` is required if `target` is specified.</param>/// <param name="TargetLang">Target language. `targetId` is required if `targetLang` is specified.</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>CorpusSegmentUpdateResponse</returns>
    Task<CorpusSegmentUpdateResponse> ResourcesCorpusSegmentUpdatePostAsync (string CorpusId, string SegId, string Source, string TargetId, string Target, string TargetLang, string Callback);
    
    /// <summary>
    /// Update corpus properties Update properties of a corpus.\n
    /// </summary>
    /// <param name="CorpusId">Corpus identifier</param>/// <param name="Name">Corpus name. The name also contains the directories (ex: \&quot;/myproject/firstPass/PersonalCorpus\&quot;)</param>/// <param name="Tag">Tag for the the corpus (this parameter can be repeated)</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>CorpusUpdateResponse</returns>
    CorpusUpdateResponse ResourcesCorpusUpdatePost (string CorpusId, string Name, List<string> Tag, string Callback);

    /// <summary>
    /// Update corpus properties Update properties of a corpus.\n
    /// </summary>
    /// <param name="CorpusId">Corpus identifier</param>/// <param name="Name">Corpus name. The name also contains the directories (ex: \&quot;/myproject/firstPass/PersonalCorpus\&quot;)</param>/// <param name="Tag">Tag for the the corpus (this parameter can be repeated)</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>CorpusUpdateResponse</returns>
    Task<CorpusUpdateResponse> ResourcesCorpusUpdatePostAsync (string CorpusId, string Name, List<string> Tag, string Callback);
    
  }

  /// <summary>
  /// Represents a collection of functions to interact with the API endpoints
  /// </summary>
  public class CorpusApi : ICorpusApi {

    /// <summary>
    /// Initializes a new instance of the <see cref="CorpusApi"/> class.
    /// </summary>
    /// <param name="apiClient"> an instance of ApiClient (optional)
    /// <returns></returns>
    public CorpusApi(ApiClient apiClient = null) {
      if (apiClient == null) { // use the default one in Configuration
        this.apiClient = Configuration.apiClient; 
      } else {
        this.apiClient = apiClient;
      }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="CorpusApi"/> class.
    /// </summary>
    /// <returns></returns>
    public CorpusApi(String basePath)
    {
      this.apiClient = new ApiClient(basePath);
    }

    /// <summary>
    /// Sets the base path of the API client.
    /// </summary>
    /// <value>The base path</value>
    public void SetBasePath(String basePath) {
      this.apiClient.basePath = basePath;
    }

    /// <summary>
    /// Gets the base path of the API client.
    /// </summary>
    /// <value>The base path</value>
    public String GetBasePath(String basePath) {
      return this.apiClient.basePath;
    }

    /// <summary>
    /// Gets or sets the API client.
    /// </summary>
    /// <value>The API client</value>
    public ApiClient apiClient {get; set;}


    
    /// <summary>
    /// Add a new corpus Add a new empty corpus.\n
    /// </summary>
    /// <param name="Name">Corpus name. The name also contains the directories (ex: \&quot;/myproject/firstPass/PersonalCorpus\&quot;)</param>/// <param name="Lang">Language code ([details](#description_langage_code_values))</param>/// <param name="Tag">Tag for the the corpus (this parameter can be repeated)</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>CorpusAddResponse</returns>
    public CorpusAddResponse ResourcesCorpusAddPost (string Name, string Lang, List<string> Tag, string Callback) {

      
      // verify the required parameter 'Name' is set
      if (Name == null) throw new ApiException(400, "Missing required parameter 'Name' when calling ResourcesCorpusAddPost");
      
      // verify the required parameter 'Lang' is set
      if (Lang == null) throw new ApiException(400, "Missing required parameter 'Lang' when calling ResourcesCorpusAddPost");
      

      var path = "/resources/corpus/add";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Name != null) queryParams.Add("name", apiClient.ParameterToString(Name)); // query parameter
       if (Lang != null) queryParams.Add("lang", apiClient.ParameterToString(Lang)); // query parameter
       if (Tag != null) queryParams.Add("tag", apiClient.ParameterToString(Tag)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ResourcesCorpusAddPost: " + response.Content, response.Content);
      }
      return (CorpusAddResponse) apiClient.Deserialize(response.Content, typeof(CorpusAddResponse));
    }
	
	 /// <summary>
    /// Add a new corpus Add a new empty corpus.\n
    /// </summary>
    /// <param name="Name">Corpus name. The name also contains the directories (ex: \&quot;/myproject/firstPass/PersonalCorpus\&quot;)</param>/// <param name="Lang">Language code ([details](#description_langage_code_values))</param>/// <param name="Tag">Tag for the the corpus (this parameter can be repeated)</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>CorpusAddResponse</returns>
    public async Task<CorpusAddResponse> ResourcesCorpusAddPostAsync (string Name, string Lang, List<string> Tag, string Callback) {

      
          // verify the required parameter 'Name' is set
          if (Name == null) throw new ApiException(400, "Missing required parameter 'Name' when calling ResourcesCorpusAddPost");
      
          // verify the required parameter 'Lang' is set
          if (Lang == null) throw new ApiException(400, "Missing required parameter 'Lang' when calling ResourcesCorpusAddPost");
      

      var path = "/resources/corpus/add";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Name != null) queryParams.Add("name", apiClient.ParameterToString(Name)); // query parameter
       if (Lang != null) queryParams.Add("lang", apiClient.ParameterToString(Lang)); // query parameter
       if (Tag != null) queryParams.Add("tag", apiClient.ParameterToString(Tag)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ResourcesCorpusAddPost: " + response.Content, response.Content);
      }
      return (CorpusAddResponse) apiClient.Deserialize(response.Content, typeof(CorpusAddResponse));
    }
    
    /// <summary>
    /// Delete corpus Delete a corpus.\n
    /// </summary>
    /// <param name="CorpusId">Corpus identifier (this parameter can be repeated)</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>CorpusDeleteResponse</returns>
    public CorpusDeleteResponse ResourcesCorpusDeletePost (List<string> CorpusId, string Callback) {

      
      // verify the required parameter 'CorpusId' is set
      if (CorpusId == null) throw new ApiException(400, "Missing required parameter 'CorpusId' when calling ResourcesCorpusDeletePost");
      

      var path = "/resources/corpus/delete";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (CorpusId != null) queryParams.Add("corpusId", apiClient.ParameterToString(CorpusId)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ResourcesCorpusDeletePost: " + response.Content, response.Content);
      }
      return (CorpusDeleteResponse) apiClient.Deserialize(response.Content, typeof(CorpusDeleteResponse));
    }
	
	 /// <summary>
    /// Delete corpus Delete a corpus.\n
    /// </summary>
    /// <param name="CorpusId">Corpus identifier (this parameter can be repeated)</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>CorpusDeleteResponse</returns>
    public async Task<CorpusDeleteResponse> ResourcesCorpusDeletePostAsync (List<string> CorpusId, string Callback) {

      
          // verify the required parameter 'CorpusId' is set
          if (CorpusId == null) throw new ApiException(400, "Missing required parameter 'CorpusId' when calling ResourcesCorpusDeletePost");
      

      var path = "/resources/corpus/delete";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (CorpusId != null) queryParams.Add("corpusId", apiClient.ParameterToString(CorpusId)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ResourcesCorpusDeletePost: " + response.Content, response.Content);
      }
      return (CorpusDeleteResponse) apiClient.Deserialize(response.Content, typeof(CorpusDeleteResponse));
    }
    
    /// <summary>
    /// Detail corpus Get detailed information about a corpus.\n
    /// </summary>
    /// <param name="CorpusId">Corpus identifier</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>CorpusDetailResponse</returns>
    public CorpusDetailResponse ResourcesCorpusDetailsGet (string CorpusId, string Callback) {

      
      // verify the required parameter 'CorpusId' is set
      if (CorpusId == null) throw new ApiException(400, "Missing required parameter 'CorpusId' when calling ResourcesCorpusDetailsGet");
      

      var path = "/resources/corpus/details";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (CorpusId != null) queryParams.Add("corpusId", apiClient.ParameterToString(CorpusId)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ResourcesCorpusDetailsGet: " + response.Content, response.Content);
      }
      return (CorpusDetailResponse) apiClient.Deserialize(response.Content, typeof(CorpusDetailResponse));
    }
	
	 /// <summary>
    /// Detail corpus Get detailed information about a corpus.\n
    /// </summary>
    /// <param name="CorpusId">Corpus identifier</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>CorpusDetailResponse</returns>
    public async Task<CorpusDetailResponse> ResourcesCorpusDetailsGetAsync (string CorpusId, string Callback) {

      
          // verify the required parameter 'CorpusId' is set
          if (CorpusId == null) throw new ApiException(400, "Missing required parameter 'CorpusId' when calling ResourcesCorpusDetailsGet");
      

      var path = "/resources/corpus/details";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (CorpusId != null) queryParams.Add("corpusId", apiClient.ParameterToString(CorpusId)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ResourcesCorpusDetailsGet: " + response.Content, response.Content);
      }
      return (CorpusDetailResponse) apiClient.Deserialize(response.Content, typeof(CorpusDetailResponse));
    }
    
    /// <summary>
    /// Corpus Exists Check if a corpus exists\n
    /// </summary>
    /// <param name="Name">Corpus name. The name also contains the directories (ex: \&quot;/myproject/firstPass/PersonalCorpus\&quot;)</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>CorpusExistsResponse</returns>
    public CorpusExistsResponse ResourcesCorpusExistsGet (string Name, string Callback) {

      
      // verify the required parameter 'Name' is set
      if (Name == null) throw new ApiException(400, "Missing required parameter 'Name' when calling ResourcesCorpusExistsGet");
      

      var path = "/resources/corpus/exists";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Name != null) queryParams.Add("name", apiClient.ParameterToString(Name)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ResourcesCorpusExistsGet: " + response.Content, response.Content);
      }
      return (CorpusExistsResponse) apiClient.Deserialize(response.Content, typeof(CorpusExistsResponse));
    }
	
	 /// <summary>
    /// Corpus Exists Check if a corpus exists\n
    /// </summary>
    /// <param name="Name">Corpus name. The name also contains the directories (ex: \&quot;/myproject/firstPass/PersonalCorpus\&quot;)</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>CorpusExistsResponse</returns>
    public async Task<CorpusExistsResponse> ResourcesCorpusExistsGetAsync (string Name, string Callback) {

      
          // verify the required parameter 'Name' is set
          if (Name == null) throw new ApiException(400, "Missing required parameter 'Name' when calling ResourcesCorpusExistsGet");
      

      var path = "/resources/corpus/exists";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Name != null) queryParams.Add("name", apiClient.ParameterToString(Name)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ResourcesCorpusExistsGet: " + response.Content, response.Content);
      }
      return (CorpusExistsResponse) apiClient.Deserialize(response.Content, typeof(CorpusExistsResponse));
    }
    
    /// <summary>
    /// Export corpus Download a corpus in an expected format.\n
    /// </summary>
    /// <param name="CorpusId">Corpus identifier</param>/// <param name="Format">The expected corpus format\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>string</returns>
    public string ResourcesCorpusExportGet (string CorpusId, string Format, string Callback) {

      
      // verify the required parameter 'CorpusId' is set
      if (CorpusId == null) throw new ApiException(400, "Missing required parameter 'CorpusId' when calling ResourcesCorpusExportGet");
      

      var path = "/resources/corpus/export";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (CorpusId != null) queryParams.Add("corpusId", apiClient.ParameterToString(CorpusId)); // query parameter
       if (Format != null) queryParams.Add("format", apiClient.ParameterToString(Format)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ResourcesCorpusExportGet: " + response.Content, response.Content);
      }
            return (string)response.Content;
    }
	
	 /// <summary>
    /// Export corpus Download a corpus in an expected format.\n
    /// </summary>
    /// <param name="CorpusId">Corpus identifier</param>/// <param name="Format">The expected corpus format\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>string</returns>
    public async Task<string> ResourcesCorpusExportGetAsync (string CorpusId, string Format, string Callback) {

      
          // verify the required parameter 'CorpusId' is set
          if (CorpusId == null) throw new ApiException(400, "Missing required parameter 'CorpusId' when calling ResourcesCorpusExportGet");
      

      var path = "/resources/corpus/export";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (CorpusId != null) queryParams.Add("corpusId", apiClient.ParameterToString(CorpusId)); // query parameter
       if (Format != null) queryParams.Add("format", apiClient.ParameterToString(Format)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ResourcesCorpusExportGet: " + response.Content, response.Content);
      }
            return (string)response.Content;
    }
    
    /// <summary>
    /// Import corpus Add a new corpus from an existing corpus.\n
    /// </summary>
    /// <param name="Name">Corpus name. The name also contains the directories (ex: \&quot;/myproject/firstPass/PersonalCorpus\&quot;)</param>/// <param name="Input">Content of the existing corpus\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="InputFile">Content of the existing corpus\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Format">Format of the input corpus.\n</param>/// <param name="Tag">Tag for the the corpus (this parameter can be repeated)</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>CorpusImportResponse</returns>
    public CorpusImportResponse ResourcesCorpusImportPost (string Name, string Input, string InputFile, string Format, List<string> Tag, string Callback) {

      
      // verify the required parameter 'Name' is set
      if (Name == null) throw new ApiException(400, "Missing required parameter 'Name' when calling ResourcesCorpusImportPost");
      

      var path = "/resources/corpus/import";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Name != null) queryParams.Add("name", apiClient.ParameterToString(Name)); // query parameter
       if (Input != null) queryParams.Add("input", apiClient.ParameterToString(Input)); // query parameter
       if (Format != null) queryParams.Add("format", apiClient.ParameterToString(Format)); // query parameter
       if (Tag != null) queryParams.Add("tag", apiClient.ParameterToString(Tag)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      if (InputFile != null) fileParams.Add("inputFile", InputFile);
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ResourcesCorpusImportPost: " + response.Content, response.Content);
      }
      return (CorpusImportResponse) apiClient.Deserialize(response.Content, typeof(CorpusImportResponse));
    }
	
	 /// <summary>
    /// Import corpus Add a new corpus from an existing corpus.\n
    /// </summary>
    /// <param name="Name">Corpus name. The name also contains the directories (ex: \&quot;/myproject/firstPass/PersonalCorpus\&quot;)</param>/// <param name="Input">Content of the existing corpus\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="InputFile">Content of the existing corpus\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Format">Format of the input corpus.\n</param>/// <param name="Tag">Tag for the the corpus (this parameter can be repeated)</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>CorpusImportResponse</returns>
    public async Task<CorpusImportResponse> ResourcesCorpusImportPostAsync (string Name, string Input, string InputFile, string Format, List<string> Tag, string Callback) {

      
          // verify the required parameter 'Name' is set
          if (Name == null) throw new ApiException(400, "Missing required parameter 'Name' when calling ResourcesCorpusImportPost");
      

      var path = "/resources/corpus/import";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Name != null) queryParams.Add("name", apiClient.ParameterToString(Name)); // query parameter
       if (Input != null) queryParams.Add("input", apiClient.ParameterToString(Input)); // query parameter
       if (Format != null) queryParams.Add("format", apiClient.ParameterToString(Format)); // query parameter
       if (Tag != null) queryParams.Add("tag", apiClient.ParameterToString(Tag)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      if (InputFile != null) fileParams.Add("inputFile", InputFile);
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ResourcesCorpusImportPost: " + response.Content, response.Content);
      }
      return (CorpusImportResponse) apiClient.Deserialize(response.Content, typeof(CorpusImportResponse));
    }
    
    /// <summary>
    /// List corpora List available corpora. Parameters can be used to restrict the list of returned corpora.\n
    /// </summary>
    /// <param name="SourceLang">Source language code ([details](#description_langage_code_values))</param>/// <param name="TargetLang">Target language code ([details](#description_langage_code_values))</param>/// <param name="WithoutPending">Filter out corpora in \&quot;pending\&quot; status\n</param>/// <param name="WithoutError">Filter out corpora in \&quot;error\&quot; status\n</param>/// <param name="Prefix">Prefix of the corpus name\n</param>/// <param name="Directory">If specified, response will return the content of this directory, including corpora and directories. This list can can also be filtered by the prefix parameter.\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>CorpusListResponse</returns>
    public CorpusListResponse ResourcesCorpusListGet (string SourceLang, string TargetLang, bool? WithoutPending, bool? WithoutError, string Prefix, string Directory, string Callback) {

      

      var path = "/resources/corpus/list";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (SourceLang != null) queryParams.Add("sourceLang", apiClient.ParameterToString(SourceLang)); // query parameter
       if (TargetLang != null) queryParams.Add("targetLang", apiClient.ParameterToString(TargetLang)); // query parameter
       if (WithoutPending != null) queryParams.Add("withoutPending", apiClient.ParameterToString(WithoutPending)); // query parameter
       if (WithoutError != null) queryParams.Add("withoutError", apiClient.ParameterToString(WithoutError)); // query parameter
       if (Prefix != null) queryParams.Add("prefix", apiClient.ParameterToString(Prefix)); // query parameter
       if (Directory != null) queryParams.Add("directory", apiClient.ParameterToString(Directory)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ResourcesCorpusListGet: " + response.Content, response.Content);
      }
      return (CorpusListResponse) apiClient.Deserialize(response.Content, typeof(CorpusListResponse));
    }
	
	 /// <summary>
    /// List corpora List available corpora. Parameters can be used to restrict the list of returned corpora.\n
    /// </summary>
    /// <param name="SourceLang">Source language code ([details](#description_langage_code_values))</param>/// <param name="TargetLang">Target language code ([details](#description_langage_code_values))</param>/// <param name="WithoutPending">Filter out corpora in \&quot;pending\&quot; status\n</param>/// <param name="WithoutError">Filter out corpora in \&quot;error\&quot; status\n</param>/// <param name="Prefix">Prefix of the corpus name\n</param>/// <param name="Directory">If specified, response will return the content of this directory, including corpora and directories. This list can can also be filtered by the prefix parameter.\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>CorpusListResponse</returns>
    public async Task<CorpusListResponse> ResourcesCorpusListGetAsync (string SourceLang, string TargetLang, bool? WithoutPending, bool? WithoutError, string Prefix, string Directory, string Callback) {

      

      var path = "/resources/corpus/list";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (SourceLang != null) queryParams.Add("sourceLang", apiClient.ParameterToString(SourceLang)); // query parameter
       if (TargetLang != null) queryParams.Add("targetLang", apiClient.ParameterToString(TargetLang)); // query parameter
       if (WithoutPending != null) queryParams.Add("withoutPending", apiClient.ParameterToString(WithoutPending)); // query parameter
       if (WithoutError != null) queryParams.Add("withoutError", apiClient.ParameterToString(WithoutError)); // query parameter
       if (Prefix != null) queryParams.Add("prefix", apiClient.ParameterToString(Prefix)); // query parameter
       if (Directory != null) queryParams.Add("directory", apiClient.ParameterToString(Directory)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ResourcesCorpusListGet: " + response.Content, response.Content);
      }
      return (CorpusListResponse) apiClient.Deserialize(response.Content, typeof(CorpusListResponse));
    }
    
    /// <summary>
    /// Corpus Match Find sentences in the corpus that match the input text from a given threshold.\n
    /// </summary>
    /// <param name="CorpusId">Corpus identifier (this parameter can be repeated)</param>/// <param name="Input">Text is used to perform the match operation (this parameter can be repeated)\n</param>/// <param name="SourceLang">Source language code ([details](#description_langage_code_values))</param>/// <param name="TargetLang">Target language code ([details](#description_langage_code_values))</param>/// <param name="Threshold">The fuzzy match threshold from which a sentence will be considered as a match result\n</param>/// <param name="Limit">Limit the number of returned matches. Only first matches within the \&quot;limit\&quot; will be returned\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>CorpusMatchResponse</returns>
    public CorpusMatchResponse ResourcesCorpusMatchGet (List<string> CorpusId, List<string> Input, string SourceLang, string TargetLang, double? Threshold, int? Limit, string Callback) {

      
      // verify the required parameter 'CorpusId' is set
      if (CorpusId == null) throw new ApiException(400, "Missing required parameter 'CorpusId' when calling ResourcesCorpusMatchGet");
      
      // verify the required parameter 'Input' is set
      if (Input == null) throw new ApiException(400, "Missing required parameter 'Input' when calling ResourcesCorpusMatchGet");
      
      // verify the required parameter 'SourceLang' is set
      if (SourceLang == null) throw new ApiException(400, "Missing required parameter 'SourceLang' when calling ResourcesCorpusMatchGet");
      
      // verify the required parameter 'TargetLang' is set
      if (TargetLang == null) throw new ApiException(400, "Missing required parameter 'TargetLang' when calling ResourcesCorpusMatchGet");
      

      var path = "/resources/corpus/match";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (CorpusId != null) queryParams.Add("corpusId", apiClient.ParameterToString(CorpusId)); // query parameter
       if (Input != null) queryParams.Add("input", apiClient.ParameterToString(Input)); // query parameter
       if (SourceLang != null) queryParams.Add("sourceLang", apiClient.ParameterToString(SourceLang)); // query parameter
       if (TargetLang != null) queryParams.Add("targetLang", apiClient.ParameterToString(TargetLang)); // query parameter
       if (Threshold != null) queryParams.Add("threshold", apiClient.ParameterToString(Threshold)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ResourcesCorpusMatchGet: " + response.Content, response.Content);
      }
      return (CorpusMatchResponse) apiClient.Deserialize(response.Content, typeof(CorpusMatchResponse));
    }
	
	 /// <summary>
    /// Corpus Match Find sentences in the corpus that match the input text from a given threshold.\n
    /// </summary>
    /// <param name="CorpusId">Corpus identifier (this parameter can be repeated)</param>/// <param name="Input">Text is used to perform the match operation (this parameter can be repeated)\n</param>/// <param name="SourceLang">Source language code ([details](#description_langage_code_values))</param>/// <param name="TargetLang">Target language code ([details](#description_langage_code_values))</param>/// <param name="Threshold">The fuzzy match threshold from which a sentence will be considered as a match result\n</param>/// <param name="Limit">Limit the number of returned matches. Only first matches within the \&quot;limit\&quot; will be returned\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>CorpusMatchResponse</returns>
    public async Task<CorpusMatchResponse> ResourcesCorpusMatchGetAsync (List<string> CorpusId, List<string> Input, string SourceLang, string TargetLang, double? Threshold, int? Limit, string Callback) {

      
          // verify the required parameter 'CorpusId' is set
          if (CorpusId == null) throw new ApiException(400, "Missing required parameter 'CorpusId' when calling ResourcesCorpusMatchGet");
      
          // verify the required parameter 'Input' is set
          if (Input == null) throw new ApiException(400, "Missing required parameter 'Input' when calling ResourcesCorpusMatchGet");
      
          // verify the required parameter 'SourceLang' is set
          if (SourceLang == null) throw new ApiException(400, "Missing required parameter 'SourceLang' when calling ResourcesCorpusMatchGet");
      
          // verify the required parameter 'TargetLang' is set
          if (TargetLang == null) throw new ApiException(400, "Missing required parameter 'TargetLang' when calling ResourcesCorpusMatchGet");
      

      var path = "/resources/corpus/match";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (CorpusId != null) queryParams.Add("corpusId", apiClient.ParameterToString(CorpusId)); // query parameter
       if (Input != null) queryParams.Add("input", apiClient.ParameterToString(Input)); // query parameter
       if (SourceLang != null) queryParams.Add("sourceLang", apiClient.ParameterToString(SourceLang)); // query parameter
       if (TargetLang != null) queryParams.Add("targetLang", apiClient.ParameterToString(TargetLang)); // query parameter
       if (Threshold != null) queryParams.Add("threshold", apiClient.ParameterToString(Threshold)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ResourcesCorpusMatchGet: " + response.Content, response.Content);
      }
      return (CorpusMatchResponse) apiClient.Deserialize(response.Content, typeof(CorpusMatchResponse));
    }
    
    /// <summary>
    /// Add corpus segments Add segments in a corpus.\n
    /// </summary>
    /// <param name="Body">List of segments to add</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>CorpusSegmentAddResponse</returns>
    public CorpusSegmentAddResponse ResourcesCorpusSegmentAddPost (CorpusSegmentAddRequest Body, string Callback) {

      
      // verify the required parameter 'Body' is set
      if (Body == null) throw new ApiException(400, "Missing required parameter 'Body' when calling ResourcesCorpusSegmentAddPost");
      

      var path = "/resources/corpus/segment/add";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      
      postBody = apiClient.Serialize(Body); // http body (model) parameter
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ResourcesCorpusSegmentAddPost: " + response.Content, response.Content);
      }
      return (CorpusSegmentAddResponse) apiClient.Deserialize(response.Content, typeof(CorpusSegmentAddResponse));
    }
	
	 /// <summary>
    /// Add corpus segments Add segments in a corpus.\n
    /// </summary>
    /// <param name="Body">List of segments to add</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>CorpusSegmentAddResponse</returns>
    public async Task<CorpusSegmentAddResponse> ResourcesCorpusSegmentAddPostAsync (CorpusSegmentAddRequest Body, string Callback) {

      
          // verify the required parameter 'Body' is set
          if (Body == null) throw new ApiException(400, "Missing required parameter 'Body' when calling ResourcesCorpusSegmentAddPost");
      

      var path = "/resources/corpus/segment/add";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      
      postBody = apiClient.Serialize(Body); // http body (model) parameter
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ResourcesCorpusSegmentAddPost: " + response.Content, response.Content);
      }
      return (CorpusSegmentAddResponse) apiClient.Deserialize(response.Content, typeof(CorpusSegmentAddResponse));
    }
    
    /// <summary>
    /// Delete corpus segments Delete segments in a corpus.\n
    /// </summary>
    /// <param name="CorpusId">Corpus identifier</param>/// <param name="SegId">Segment Id (this parameter can be repeated)</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>CorpusSegmentDeleteResponse</returns>
    public CorpusSegmentDeleteResponse ResourcesCorpusSegmentDeletePost (string CorpusId, List<string> SegId, string Callback) {

      
      // verify the required parameter 'CorpusId' is set
      if (CorpusId == null) throw new ApiException(400, "Missing required parameter 'CorpusId' when calling ResourcesCorpusSegmentDeletePost");
      
      // verify the required parameter 'SegId' is set
      if (SegId == null) throw new ApiException(400, "Missing required parameter 'SegId' when calling ResourcesCorpusSegmentDeletePost");
      

      var path = "/resources/corpus/segment/delete";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (CorpusId != null) queryParams.Add("corpusId", apiClient.ParameterToString(CorpusId)); // query parameter
       if (SegId != null) queryParams.Add("segId", apiClient.ParameterToString(SegId)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ResourcesCorpusSegmentDeletePost: " + response.Content, response.Content);
      }
      return (CorpusSegmentDeleteResponse) apiClient.Deserialize(response.Content, typeof(CorpusSegmentDeleteResponse));
    }
	
	 /// <summary>
    /// Delete corpus segments Delete segments in a corpus.\n
    /// </summary>
    /// <param name="CorpusId">Corpus identifier</param>/// <param name="SegId">Segment Id (this parameter can be repeated)</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>CorpusSegmentDeleteResponse</returns>
    public async Task<CorpusSegmentDeleteResponse> ResourcesCorpusSegmentDeletePostAsync (string CorpusId, List<string> SegId, string Callback) {

      
          // verify the required parameter 'CorpusId' is set
          if (CorpusId == null) throw new ApiException(400, "Missing required parameter 'CorpusId' when calling ResourcesCorpusSegmentDeletePost");
      
          // verify the required parameter 'SegId' is set
          if (SegId == null) throw new ApiException(400, "Missing required parameter 'SegId' when calling ResourcesCorpusSegmentDeletePost");
      

      var path = "/resources/corpus/segment/delete";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (CorpusId != null) queryParams.Add("corpusId", apiClient.ParameterToString(CorpusId)); // query parameter
       if (SegId != null) queryParams.Add("segId", apiClient.ParameterToString(SegId)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ResourcesCorpusSegmentDeletePost: " + response.Content, response.Content);
      }
      return (CorpusSegmentDeleteResponse) apiClient.Deserialize(response.Content, typeof(CorpusSegmentDeleteResponse));
    }
    
    /// <summary>
    /// List corpus segments List segments in a corpus.\n
    /// </summary>
    /// <param name="CorpusId">Corpus identifier</param>/// <param name="Skip">Skip first found segments in the response\n</param>/// <param name="Limit">Limit the number of returned segments\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>CorpusSegmentListResponse</returns>
    public CorpusSegmentListResponse ResourcesCorpusSegmentListGet (string CorpusId, int? Skip, int? Limit, string Callback) {

      
      // verify the required parameter 'CorpusId' is set
      if (CorpusId == null) throw new ApiException(400, "Missing required parameter 'CorpusId' when calling ResourcesCorpusSegmentListGet");
      

      var path = "/resources/corpus/segment/list";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (CorpusId != null) queryParams.Add("corpusId", apiClient.ParameterToString(CorpusId)); // query parameter
       if (Skip != null) queryParams.Add("skip", apiClient.ParameterToString(Skip)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ResourcesCorpusSegmentListGet: " + response.Content, response.Content);
      }
      return (CorpusSegmentListResponse) apiClient.Deserialize(response.Content, typeof(CorpusSegmentListResponse));
    }
	
	 /// <summary>
    /// List corpus segments List segments in a corpus.\n
    /// </summary>
    /// <param name="CorpusId">Corpus identifier</param>/// <param name="Skip">Skip first found segments in the response\n</param>/// <param name="Limit">Limit the number of returned segments\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>CorpusSegmentListResponse</returns>
    public async Task<CorpusSegmentListResponse> ResourcesCorpusSegmentListGetAsync (string CorpusId, int? Skip, int? Limit, string Callback) {

      
          // verify the required parameter 'CorpusId' is set
          if (CorpusId == null) throw new ApiException(400, "Missing required parameter 'CorpusId' when calling ResourcesCorpusSegmentListGet");
      

      var path = "/resources/corpus/segment/list";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (CorpusId != null) queryParams.Add("corpusId", apiClient.ParameterToString(CorpusId)); // query parameter
       if (Skip != null) queryParams.Add("skip", apiClient.ParameterToString(Skip)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ResourcesCorpusSegmentListGet: " + response.Content, response.Content);
      }
      return (CorpusSegmentListResponse) apiClient.Deserialize(response.Content, typeof(CorpusSegmentListResponse));
    }
    
    /// <summary>
    /// Add corpus segment targets Add targets to a segment in a corpus.\n
    /// </summary>
    /// <param name="Body">List of targets to add</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>CorpusSegmentAddTargetResponse</returns>
    public CorpusSegmentAddTargetResponse ResourcesCorpusSegmentTargetAddPost (CorpusSegmentAddTargetRequest Body, string Callback) {

      
      // verify the required parameter 'Body' is set
      if (Body == null) throw new ApiException(400, "Missing required parameter 'Body' when calling ResourcesCorpusSegmentTargetAddPost");
      

      var path = "/resources/corpus/segment/target/add";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      
      postBody = apiClient.Serialize(Body); // http body (model) parameter
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ResourcesCorpusSegmentTargetAddPost: " + response.Content, response.Content);
      }
      return (CorpusSegmentAddTargetResponse) apiClient.Deserialize(response.Content, typeof(CorpusSegmentAddTargetResponse));
    }
	
	 /// <summary>
    /// Add corpus segment targets Add targets to a segment in a corpus.\n
    /// </summary>
    /// <param name="Body">List of targets to add</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>CorpusSegmentAddTargetResponse</returns>
    public async Task<CorpusSegmentAddTargetResponse> ResourcesCorpusSegmentTargetAddPostAsync (CorpusSegmentAddTargetRequest Body, string Callback) {

      
          // verify the required parameter 'Body' is set
          if (Body == null) throw new ApiException(400, "Missing required parameter 'Body' when calling ResourcesCorpusSegmentTargetAddPost");
      

      var path = "/resources/corpus/segment/target/add";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      
      postBody = apiClient.Serialize(Body); // http body (model) parameter
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ResourcesCorpusSegmentTargetAddPost: " + response.Content, response.Content);
      }
      return (CorpusSegmentAddTargetResponse) apiClient.Deserialize(response.Content, typeof(CorpusSegmentAddTargetResponse));
    }
    
    /// <summary>
    /// Delete corpus segment targets Delete segment targets in a corpus.\n
    /// </summary>
    /// <param name="CorpusId">Corpus identifier</param>/// <param name="SegId">Segment Id</param>/// <param name="TargetId">Target id (this parameter can be repeated)</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>CorpusSegmentDeleteTargetResponse</returns>
    public CorpusSegmentDeleteTargetResponse ResourcesCorpusSegmentTargetDeletePost (string CorpusId, string SegId, List<string> TargetId, string Callback) {

      
      // verify the required parameter 'CorpusId' is set
      if (CorpusId == null) throw new ApiException(400, "Missing required parameter 'CorpusId' when calling ResourcesCorpusSegmentTargetDeletePost");
      
      // verify the required parameter 'SegId' is set
      if (SegId == null) throw new ApiException(400, "Missing required parameter 'SegId' when calling ResourcesCorpusSegmentTargetDeletePost");
      
      // verify the required parameter 'TargetId' is set
      if (TargetId == null) throw new ApiException(400, "Missing required parameter 'TargetId' when calling ResourcesCorpusSegmentTargetDeletePost");
      

      var path = "/resources/corpus/segment/target/delete";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (CorpusId != null) queryParams.Add("corpusId", apiClient.ParameterToString(CorpusId)); // query parameter
       if (SegId != null) queryParams.Add("segId", apiClient.ParameterToString(SegId)); // query parameter
       if (TargetId != null) queryParams.Add("targetId", apiClient.ParameterToString(TargetId)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ResourcesCorpusSegmentTargetDeletePost: " + response.Content, response.Content);
      }
      return (CorpusSegmentDeleteTargetResponse) apiClient.Deserialize(response.Content, typeof(CorpusSegmentDeleteTargetResponse));
    }
	
	 /// <summary>
    /// Delete corpus segment targets Delete segment targets in a corpus.\n
    /// </summary>
    /// <param name="CorpusId">Corpus identifier</param>/// <param name="SegId">Segment Id</param>/// <param name="TargetId">Target id (this parameter can be repeated)</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>CorpusSegmentDeleteTargetResponse</returns>
    public async Task<CorpusSegmentDeleteTargetResponse> ResourcesCorpusSegmentTargetDeletePostAsync (string CorpusId, string SegId, List<string> TargetId, string Callback) {

      
          // verify the required parameter 'CorpusId' is set
          if (CorpusId == null) throw new ApiException(400, "Missing required parameter 'CorpusId' when calling ResourcesCorpusSegmentTargetDeletePost");
      
          // verify the required parameter 'SegId' is set
          if (SegId == null) throw new ApiException(400, "Missing required parameter 'SegId' when calling ResourcesCorpusSegmentTargetDeletePost");
      
          // verify the required parameter 'TargetId' is set
          if (TargetId == null) throw new ApiException(400, "Missing required parameter 'TargetId' when calling ResourcesCorpusSegmentTargetDeletePost");
      

      var path = "/resources/corpus/segment/target/delete";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (CorpusId != null) queryParams.Add("corpusId", apiClient.ParameterToString(CorpusId)); // query parameter
       if (SegId != null) queryParams.Add("segId", apiClient.ParameterToString(SegId)); // query parameter
       if (TargetId != null) queryParams.Add("targetId", apiClient.ParameterToString(TargetId)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ResourcesCorpusSegmentTargetDeletePost: " + response.Content, response.Content);
      }
      return (CorpusSegmentDeleteTargetResponse) apiClient.Deserialize(response.Content, typeof(CorpusSegmentDeleteTargetResponse));
    }
    
    /// <summary>
    /// Update corpus segment Update a segment in a corpus.\n
    /// </summary>
    /// <param name="CorpusId">Corpus identifier</param>/// <param name="SegId">Segment Id</param>/// <param name="Source">Source text</param>/// <param name="TargetId">Target id</param>/// <param name="Target">Target text. `targetId` is required if `target` is specified.</param>/// <param name="TargetLang">Target language. `targetId` is required if `targetLang` is specified.</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>CorpusSegmentUpdateResponse</returns>
    public CorpusSegmentUpdateResponse ResourcesCorpusSegmentUpdatePost (string CorpusId, string SegId, string Source, string TargetId, string Target, string TargetLang, string Callback) {

      
      // verify the required parameter 'CorpusId' is set
      if (CorpusId == null) throw new ApiException(400, "Missing required parameter 'CorpusId' when calling ResourcesCorpusSegmentUpdatePost");
      
      // verify the required parameter 'SegId' is set
      if (SegId == null) throw new ApiException(400, "Missing required parameter 'SegId' when calling ResourcesCorpusSegmentUpdatePost");
      

      var path = "/resources/corpus/segment/update";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (CorpusId != null) queryParams.Add("corpusId", apiClient.ParameterToString(CorpusId)); // query parameter
       if (SegId != null) queryParams.Add("segId", apiClient.ParameterToString(SegId)); // query parameter
       if (Source != null) queryParams.Add("source", apiClient.ParameterToString(Source)); // query parameter
       if (TargetId != null) queryParams.Add("targetId", apiClient.ParameterToString(TargetId)); // query parameter
       if (Target != null) queryParams.Add("target", apiClient.ParameterToString(Target)); // query parameter
       if (TargetLang != null) queryParams.Add("targetLang", apiClient.ParameterToString(TargetLang)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ResourcesCorpusSegmentUpdatePost: " + response.Content, response.Content);
      }
      return (CorpusSegmentUpdateResponse) apiClient.Deserialize(response.Content, typeof(CorpusSegmentUpdateResponse));
    }
	
	 /// <summary>
    /// Update corpus segment Update a segment in a corpus.\n
    /// </summary>
    /// <param name="CorpusId">Corpus identifier</param>/// <param name="SegId">Segment Id</param>/// <param name="Source">Source text</param>/// <param name="TargetId">Target id</param>/// <param name="Target">Target text. `targetId` is required if `target` is specified.</param>/// <param name="TargetLang">Target language. `targetId` is required if `targetLang` is specified.</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>CorpusSegmentUpdateResponse</returns>
    public async Task<CorpusSegmentUpdateResponse> ResourcesCorpusSegmentUpdatePostAsync (string CorpusId, string SegId, string Source, string TargetId, string Target, string TargetLang, string Callback) {

      
          // verify the required parameter 'CorpusId' is set
          if (CorpusId == null) throw new ApiException(400, "Missing required parameter 'CorpusId' when calling ResourcesCorpusSegmentUpdatePost");
      
          // verify the required parameter 'SegId' is set
          if (SegId == null) throw new ApiException(400, "Missing required parameter 'SegId' when calling ResourcesCorpusSegmentUpdatePost");
      

      var path = "/resources/corpus/segment/update";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (CorpusId != null) queryParams.Add("corpusId", apiClient.ParameterToString(CorpusId)); // query parameter
       if (SegId != null) queryParams.Add("segId", apiClient.ParameterToString(SegId)); // query parameter
       if (Source != null) queryParams.Add("source", apiClient.ParameterToString(Source)); // query parameter
       if (TargetId != null) queryParams.Add("targetId", apiClient.ParameterToString(TargetId)); // query parameter
       if (Target != null) queryParams.Add("target", apiClient.ParameterToString(Target)); // query parameter
       if (TargetLang != null) queryParams.Add("targetLang", apiClient.ParameterToString(TargetLang)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ResourcesCorpusSegmentUpdatePost: " + response.Content, response.Content);
      }
      return (CorpusSegmentUpdateResponse) apiClient.Deserialize(response.Content, typeof(CorpusSegmentUpdateResponse));
    }
    
    /// <summary>
    /// Update corpus properties Update properties of a corpus.\n
    /// </summary>
    /// <param name="CorpusId">Corpus identifier</param>/// <param name="Name">Corpus name. The name also contains the directories (ex: \&quot;/myproject/firstPass/PersonalCorpus\&quot;)</param>/// <param name="Tag">Tag for the the corpus (this parameter can be repeated)</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>CorpusUpdateResponse</returns>
    public CorpusUpdateResponse ResourcesCorpusUpdatePost (string CorpusId, string Name, List<string> Tag, string Callback) {

      
      // verify the required parameter 'CorpusId' is set
      if (CorpusId == null) throw new ApiException(400, "Missing required parameter 'CorpusId' when calling ResourcesCorpusUpdatePost");
      

      var path = "/resources/corpus/update";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (CorpusId != null) queryParams.Add("corpusId", apiClient.ParameterToString(CorpusId)); // query parameter
       if (Name != null) queryParams.Add("name", apiClient.ParameterToString(Name)); // query parameter
       if (Tag != null) queryParams.Add("tag", apiClient.ParameterToString(Tag)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ResourcesCorpusUpdatePost: " + response.Content, response.Content);
      }
      return (CorpusUpdateResponse) apiClient.Deserialize(response.Content, typeof(CorpusUpdateResponse));
    }
	
	 /// <summary>
    /// Update corpus properties Update properties of a corpus.\n
    /// </summary>
    /// <param name="CorpusId">Corpus identifier</param>/// <param name="Name">Corpus name. The name also contains the directories (ex: \&quot;/myproject/firstPass/PersonalCorpus\&quot;)</param>/// <param name="Tag">Tag for the the corpus (this parameter can be repeated)</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>CorpusUpdateResponse</returns>
    public async Task<CorpusUpdateResponse> ResourcesCorpusUpdatePostAsync (string CorpusId, string Name, List<string> Tag, string Callback) {

      
          // verify the required parameter 'CorpusId' is set
          if (CorpusId == null) throw new ApiException(400, "Missing required parameter 'CorpusId' when calling ResourcesCorpusUpdatePost");
      

      var path = "/resources/corpus/update";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (CorpusId != null) queryParams.Add("corpusId", apiClient.ParameterToString(CorpusId)); // query parameter
       if (Name != null) queryParams.Add("name", apiClient.ParameterToString(Name)); // query parameter
       if (Tag != null) queryParams.Add("tag", apiClient.ParameterToString(Tag)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ResourcesCorpusUpdatePost: " + response.Content, response.Content);
      }
      return (CorpusUpdateResponse) apiClient.Deserialize(response.Content, typeof(CorpusUpdateResponse));
    }
    
  }  
  
}
