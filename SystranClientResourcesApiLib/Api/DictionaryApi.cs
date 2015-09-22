using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using Systran.ResourcesClientLib.Client;
using Systran.ResourcesClientLib.Model;

namespace Systran.ResourcesClientLib.Api {
  

  public interface IDictionaryApi {
    
    /// <summary>
    /// Add dictionary Add a new dictionary.
    /// </summary>
    /// <param name="Input">Input with dictionary information</param>
    /// <returns>DictionaryAddResponse</returns>
    DictionaryAddResponse ResourcesDictionaryAddPost (DictionaryAddBody Input);

    /// <summary>
    /// Add dictionary Add a new dictionary.
    /// </summary>
    /// <param name="Input">Input with dictionary information</param>
    /// <returns>DictionaryAddResponse</returns>
    Task<DictionaryAddResponse> ResourcesDictionaryAddPostAsync (DictionaryAddBody Input);
    
    /// <summary>
    /// Delete a dictionary Delete an existing dictionary.
    /// </summary>
    /// <param name="DictionaryId">Dictionary Id</param>
    /// <returns></returns>
    void ResourcesDictionaryDeletePost (string DictionaryId);

    /// <summary>
    /// Delete a dictionary Delete an existing dictionary.
    /// </summary>
    /// <param name="DictionaryId">Dictionary Id</param>
    /// <returns></returns>
    Task ResourcesDictionaryDeletePostAsync (string DictionaryId);
    
    /// <summary>
    /// Add an entry Add a new entry to an existing dictionary.
    /// </summary>
    /// <param name="DictionaryId">Dictionary Id</param>/// <param name="Input">Input with dictionary id and entries information</param>
    /// <returns>EntryAddResponse</returns>
    EntryAddResponse ResourcesDictionaryEntryAddPost (string DictionaryId, EntryAddBody Input);

    /// <summary>
    /// Add an entry Add a new entry to an existing dictionary.
    /// </summary>
    /// <param name="DictionaryId">Dictionary Id</param>/// <param name="Input">Input with dictionary id and entries information</param>
    /// <returns>EntryAddResponse</returns>
    Task<EntryAddResponse> ResourcesDictionaryEntryAddPostAsync (string DictionaryId, EntryAddBody Input);
    
    /// <summary>
    /// Delete an entry Delete an entry in an existing dictionary.
    /// </summary>
    /// <param name="DictionaryId">Dictionary Id</param>/// <param name="Input">Input with dictionary id + entry id (src or tgt) to delete</param>
    /// <returns>EntryDeleteResponse</returns>
    EntryDeleteResponse ResourcesDictionaryEntryDeletePost (string DictionaryId, EntryDeleteBody Input);

    /// <summary>
    /// Delete an entry Delete an entry in an existing dictionary.
    /// </summary>
    /// <param name="DictionaryId">Dictionary Id</param>/// <param name="Input">Input with dictionary id + entry id (src or tgt) to delete</param>
    /// <returns>EntryDeleteResponse</returns>
    Task<EntryDeleteResponse> ResourcesDictionaryEntryDeletePostAsync (string DictionaryId, EntryDeleteBody Input);
    
    /// <summary>
    /// Import entries Import entries to an existing dictionary.
    /// </summary>
    /// <param name="DictionaryId">Id of the dictionary where to import entries</param>/// <param name="SourceLang">Source lang of the entries to import</param>/// <param name="InputFile">File with entries to import</param>
    /// <returns>DictionariesImportResponse</returns>
    DictionariesImportResponse ResourcesDictionaryEntryImportPost (string DictionaryId, string SourceLang, string InputFile);

    /// <summary>
    /// Import entries Import entries to an existing dictionary.
    /// </summary>
    /// <param name="DictionaryId">Id of the dictionary where to import entries</param>/// <param name="SourceLang">Source lang of the entries to import</param>/// <param name="InputFile">File with entries to import</param>
    /// <returns>DictionariesImportResponse</returns>
    Task<DictionariesImportResponse> ResourcesDictionaryEntryImportPostAsync (string DictionaryId, string SourceLang, string InputFile);
    
    /// <summary>
    /// List entries List entries for a specific dictionary.
    /// </summary>
    /// <param name="DictionaryId">Dictionary Id</param>/// <param name="Filters">Different filters that can be applied to the list functionality (skip/limit/sort/match)</param>
    /// <returns>EntriesListResponse</returns>
    EntriesListResponse ResourcesDictionaryEntryListPost (string DictionaryId, EntriesListFilters Filters);

    /// <summary>
    /// List entries List entries for a specific dictionary.
    /// </summary>
    /// <param name="DictionaryId">Dictionary Id</param>/// <param name="Filters">Different filters that can be applied to the list functionality (skip/limit/sort/match)</param>
    /// <returns>EntriesListResponse</returns>
    Task<EntriesListResponse> ResourcesDictionaryEntryListPostAsync (string DictionaryId, EntriesListFilters Filters);
    
    /// <summary>
    /// Update an entry Update an entry in an existing dictionary.
    /// </summary>
    /// <param name="DictionaryId">Dictionary Id</param>/// <param name="Input">Input with dictionary id + entry id (src or tgt) to delete</param>
    /// <returns>EntryUpdateResponse</returns>
    EntryUpdateResponse ResourcesDictionaryEntryUpdatePost (string DictionaryId, EntryUpdateBody Input);

    /// <summary>
    /// Update an entry Update an entry in an existing dictionary.
    /// </summary>
    /// <param name="DictionaryId">Dictionary Id</param>/// <param name="Input">Input with dictionary id + entry id (src or tgt) to delete</param>
    /// <returns>EntryUpdateResponse</returns>
    Task<EntryUpdateResponse> ResourcesDictionaryEntryUpdatePostAsync (string DictionaryId, EntryUpdateBody Input);
    
    /// <summary>
    /// Export a dictionary Export an existing dictionary.
    /// </summary>
    /// <param name="DictionaryId">Dictionary Id</param>
    /// <returns></returns>
    void ResourcesDictionaryExportPost (string DictionaryId);

    /// <summary>
    /// Export a dictionary Export an existing dictionary.
    /// </summary>
    /// <param name="DictionaryId">Dictionary Id</param>
    /// <returns></returns>
    Task ResourcesDictionaryExportPostAsync (string DictionaryId);
    
    /// <summary>
    /// List dictionaries List the dictionaries.
    /// </summary>
    /// <param name="Filters">Different filters that can be applied to the list functionality (skip/limit/sort/match)</param>
    /// <returns>DictionariesListResponse</returns>
    DictionariesListResponse ResourcesDictionaryListPost (DictionariesListFilters Filters);

    /// <summary>
    /// List dictionaries List the dictionaries.
    /// </summary>
    /// <param name="Filters">Different filters that can be applied to the list functionality (skip/limit/sort/match)</param>
    /// <returns>DictionariesListResponse</returns>
    Task<DictionariesListResponse> ResourcesDictionaryListPostAsync (DictionariesListFilters Filters);
    
    /// <summary>
    /// Lookup Lookup words from a source language to a target language.
    /// </summary>
    /// <param name="Source">Language code of the source text\n</param>/// <param name="Target">Language code in which to lookup the source text\n</param>/// <param name="Input">Input word (the &#39;input&#39; parameter can be repeated)\n</param>/// <param name="Autocomplete">With this option, if the input word is not found in the source language, it will be filled in with autocompletion to perform the lookup\n\nDefault: false\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>LookupResponse</returns>
    LookupResponse ResourcesDictionaryLookupGet (string Source, string Target, List<string> Input, bool? Autocomplete, string Callback);

    /// <summary>
    /// Lookup Lookup words from a source language to a target language.
    /// </summary>
    /// <param name="Source">Language code of the source text\n</param>/// <param name="Target">Language code in which to lookup the source text\n</param>/// <param name="Input">Input word (the &#39;input&#39; parameter can be repeated)\n</param>/// <param name="Autocomplete">With this option, if the input word is not found in the source language, it will be filled in with autocompletion to perform the lookup\n\nDefault: false\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>LookupResponse</returns>
    Task<LookupResponse> ResourcesDictionaryLookupGetAsync (string Source, string Target, List<string> Input, bool? Autocomplete, string Callback);
    
    /// <summary>
    /// Lookup Supported Languages List of language pairs in which lookup is supported. This list can be limited to a specific source language or target language.\n
    /// </summary>
    /// <param name="Source">Language code of the source text\n</param>/// <param name="Target">Language code into which to translate the source text\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>LookupSupportedLanguageResponse</returns>
    LookupSupportedLanguageResponse ResourcesDictionaryLookupSupportedLanguagesGet (string Source, string Target, string Callback);

    /// <summary>
    /// Lookup Supported Languages List of language pairs in which lookup is supported. This list can be limited to a specific source language or target language.\n
    /// </summary>
    /// <param name="Source">Language code of the source text\n</param>/// <param name="Target">Language code into which to translate the source text\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>LookupSupportedLanguageResponse</returns>
    Task<LookupSupportedLanguageResponse> ResourcesDictionaryLookupSupportedLanguagesGetAsync (string Source, string Target, string Callback);
    
    /// <summary>
    /// Supported Languages Get supported languages by dictionaries
    /// </summary>
    
    /// <returns>SupportedLanguagesResponse</returns>
    SupportedLanguagesResponse ResourcesDictionarySupportedLanguagesGet ();

    /// <summary>
    /// Supported Languages Get supported languages by dictionaries
    /// </summary>
    
    /// <returns>SupportedLanguagesResponse</returns>
    Task<SupportedLanguagesResponse> ResourcesDictionarySupportedLanguagesGetAsync ();
    
    /// <summary>
    /// Update a dictionary Update an existing dictionary.
    /// </summary>
    /// <param name="DictionaryId">Dictionary Id</param>/// <param name="Input">Input with dictionary id</param>
    /// <returns>DictionaryUpdateResponse</returns>
    DictionaryUpdateResponse ResourcesDictionaryUpdatePost (string DictionaryId, DictionaryUpdateBody Input);

    /// <summary>
    /// Update a dictionary Update an existing dictionary.
    /// </summary>
    /// <param name="DictionaryId">Dictionary Id</param>/// <param name="Input">Input with dictionary id</param>
    /// <returns>DictionaryUpdateResponse</returns>
    Task<DictionaryUpdateResponse> ResourcesDictionaryUpdatePostAsync (string DictionaryId, DictionaryUpdateBody Input);
    
  }

  /// <summary>
  /// Represents a collection of functions to interact with the API endpoints
  /// </summary>
  public class DictionaryApi : IDictionaryApi {

    /// <summary>
    /// Initializes a new instance of the <see cref="DictionaryApi"/> class.
    /// </summary>
    /// <param name="apiClient"> an instance of ApiClient (optional)
    /// <returns></returns>
    public DictionaryApi(ApiClient apiClient = null) {
      if (apiClient == null) { // use the default one in Configuration
        this.apiClient = Configuration.apiClient; 
      } else {
        this.apiClient = apiClient;
      }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DictionaryApi"/> class.
    /// </summary>
    /// <returns></returns>
    public DictionaryApi(String basePath)
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
    /// Add dictionary Add a new dictionary.
    /// </summary>
    /// <param name="Input">Input with dictionary information</param>
    /// <returns>DictionaryAddResponse</returns>
    public DictionaryAddResponse ResourcesDictionaryAddPost (DictionaryAddBody Input) {

      
      // verify the required parameter 'Input' is set
      if (Input == null) throw new ApiException(400, "Missing required parameter 'Input' when calling ResourcesDictionaryAddPost");
      

      var path = "/resources/dictionary/add";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
      
      
      postBody = apiClient.Serialize(Input); // http body (model) parameter
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ResourcesDictionaryAddPost: " + response.Content, response.Content);
      }
      return (DictionaryAddResponse) apiClient.Deserialize(response.Content, typeof(DictionaryAddResponse));
    }
	
	 /// <summary>
    /// Add dictionary Add a new dictionary.
    /// </summary>
    /// <param name="Input">Input with dictionary information</param>
    /// <returns>DictionaryAddResponse</returns>
    public async Task<DictionaryAddResponse> ResourcesDictionaryAddPostAsync (DictionaryAddBody Input) {

      
          // verify the required parameter 'Input' is set
          if (Input == null) throw new ApiException(400, "Missing required parameter 'Input' when calling ResourcesDictionaryAddPost");
      

      var path = "/resources/dictionary/add";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
      
      
      postBody = apiClient.Serialize(Input); // http body (model) parameter
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ResourcesDictionaryAddPost: " + response.Content, response.Content);
      }
      return (DictionaryAddResponse) apiClient.Deserialize(response.Content, typeof(DictionaryAddResponse));
    }
    
    /// <summary>
    /// Delete a dictionary Delete an existing dictionary.
    /// </summary>
    /// <param name="DictionaryId">Dictionary Id</param>
    /// <returns></returns>
    public void ResourcesDictionaryDeletePost (string DictionaryId) {

      
      // verify the required parameter 'DictionaryId' is set
      if (DictionaryId == null) throw new ApiException(400, "Missing required parameter 'DictionaryId' when calling ResourcesDictionaryDeletePost");
      

      var path = "/resources/dictionary/delete";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (DictionaryId != null) queryParams.Add("dictionaryId", apiClient.ParameterToString(DictionaryId)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ResourcesDictionaryDeletePost: " + response.Content, response.Content);
      }
      
      return;
    }
	
	 /// <summary>
    /// Delete a dictionary Delete an existing dictionary.
    /// </summary>
    /// <param name="DictionaryId">Dictionary Id</param>
    /// <returns></returns>
    public async Task ResourcesDictionaryDeletePostAsync (string DictionaryId) {

      
          // verify the required parameter 'DictionaryId' is set
          if (DictionaryId == null) throw new ApiException(400, "Missing required parameter 'DictionaryId' when calling ResourcesDictionaryDeletePost");
      

      var path = "/resources/dictionary/delete";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (DictionaryId != null) queryParams.Add("dictionaryId", apiClient.ParameterToString(DictionaryId)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ResourcesDictionaryDeletePost: " + response.Content, response.Content);
      }
      
      return;
    }
    
    /// <summary>
    /// Add an entry Add a new entry to an existing dictionary.
    /// </summary>
    /// <param name="DictionaryId">Dictionary Id</param>/// <param name="Input">Input with dictionary id and entries information</param>
    /// <returns>EntryAddResponse</returns>
    public EntryAddResponse ResourcesDictionaryEntryAddPost (string DictionaryId, EntryAddBody Input) {

      
      // verify the required parameter 'DictionaryId' is set
      if (DictionaryId == null) throw new ApiException(400, "Missing required parameter 'DictionaryId' when calling ResourcesDictionaryEntryAddPost");
      
      // verify the required parameter 'Input' is set
      if (Input == null) throw new ApiException(400, "Missing required parameter 'Input' when calling ResourcesDictionaryEntryAddPost");
      

      var path = "/resources/dictionary/entry/add";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (DictionaryId != null) queryParams.Add("dictionaryId", apiClient.ParameterToString(DictionaryId)); // query parameter
      
      
      
      postBody = apiClient.Serialize(Input); // http body (model) parameter
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ResourcesDictionaryEntryAddPost: " + response.Content, response.Content);
      }
      return (EntryAddResponse) apiClient.Deserialize(response.Content, typeof(EntryAddResponse));
    }
	
	 /// <summary>
    /// Add an entry Add a new entry to an existing dictionary.
    /// </summary>
    /// <param name="DictionaryId">Dictionary Id</param>/// <param name="Input">Input with dictionary id and entries information</param>
    /// <returns>EntryAddResponse</returns>
    public async Task<EntryAddResponse> ResourcesDictionaryEntryAddPostAsync (string DictionaryId, EntryAddBody Input) {

      
          // verify the required parameter 'DictionaryId' is set
          if (DictionaryId == null) throw new ApiException(400, "Missing required parameter 'DictionaryId' when calling ResourcesDictionaryEntryAddPost");
      
          // verify the required parameter 'Input' is set
          if (Input == null) throw new ApiException(400, "Missing required parameter 'Input' when calling ResourcesDictionaryEntryAddPost");
      

      var path = "/resources/dictionary/entry/add";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (DictionaryId != null) queryParams.Add("dictionaryId", apiClient.ParameterToString(DictionaryId)); // query parameter
      
      
      
      postBody = apiClient.Serialize(Input); // http body (model) parameter
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ResourcesDictionaryEntryAddPost: " + response.Content, response.Content);
      }
      return (EntryAddResponse) apiClient.Deserialize(response.Content, typeof(EntryAddResponse));
    }
    
    /// <summary>
    /// Delete an entry Delete an entry in an existing dictionary.
    /// </summary>
    /// <param name="DictionaryId">Dictionary Id</param>/// <param name="Input">Input with dictionary id + entry id (src or tgt) to delete</param>
    /// <returns>EntryDeleteResponse</returns>
    public EntryDeleteResponse ResourcesDictionaryEntryDeletePost (string DictionaryId, EntryDeleteBody Input) {

      
      // verify the required parameter 'DictionaryId' is set
      if (DictionaryId == null) throw new ApiException(400, "Missing required parameter 'DictionaryId' when calling ResourcesDictionaryEntryDeletePost");
      
      // verify the required parameter 'Input' is set
      if (Input == null) throw new ApiException(400, "Missing required parameter 'Input' when calling ResourcesDictionaryEntryDeletePost");
      

      var path = "/resources/dictionary/entry/delete";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (DictionaryId != null) queryParams.Add("dictionaryId", apiClient.ParameterToString(DictionaryId)); // query parameter
      
      
      
      postBody = apiClient.Serialize(Input); // http body (model) parameter
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ResourcesDictionaryEntryDeletePost: " + response.Content, response.Content);
      }
      return (EntryDeleteResponse) apiClient.Deserialize(response.Content, typeof(EntryDeleteResponse));
    }
	
	 /// <summary>
    /// Delete an entry Delete an entry in an existing dictionary.
    /// </summary>
    /// <param name="DictionaryId">Dictionary Id</param>/// <param name="Input">Input with dictionary id + entry id (src or tgt) to delete</param>
    /// <returns>EntryDeleteResponse</returns>
    public async Task<EntryDeleteResponse> ResourcesDictionaryEntryDeletePostAsync (string DictionaryId, EntryDeleteBody Input) {

      
          // verify the required parameter 'DictionaryId' is set
          if (DictionaryId == null) throw new ApiException(400, "Missing required parameter 'DictionaryId' when calling ResourcesDictionaryEntryDeletePost");
      
          // verify the required parameter 'Input' is set
          if (Input == null) throw new ApiException(400, "Missing required parameter 'Input' when calling ResourcesDictionaryEntryDeletePost");
      

      var path = "/resources/dictionary/entry/delete";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (DictionaryId != null) queryParams.Add("dictionaryId", apiClient.ParameterToString(DictionaryId)); // query parameter
      
      
      
      postBody = apiClient.Serialize(Input); // http body (model) parameter
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ResourcesDictionaryEntryDeletePost: " + response.Content, response.Content);
      }
      return (EntryDeleteResponse) apiClient.Deserialize(response.Content, typeof(EntryDeleteResponse));
    }
    
    /// <summary>
    /// Import entries Import entries to an existing dictionary.
    /// </summary>
    /// <param name="DictionaryId">Id of the dictionary where to import entries</param>/// <param name="SourceLang">Source lang of the entries to import</param>/// <param name="InputFile">File with entries to import</param>
    /// <returns>DictionariesImportResponse</returns>
    public DictionariesImportResponse ResourcesDictionaryEntryImportPost (string DictionaryId, string SourceLang, string InputFile) {

      
      // verify the required parameter 'DictionaryId' is set
      if (DictionaryId == null) throw new ApiException(400, "Missing required parameter 'DictionaryId' when calling ResourcesDictionaryEntryImportPost");
      
      // verify the required parameter 'SourceLang' is set
      if (SourceLang == null) throw new ApiException(400, "Missing required parameter 'SourceLang' when calling ResourcesDictionaryEntryImportPost");
      
      // verify the required parameter 'InputFile' is set
      if (InputFile == null) throw new ApiException(400, "Missing required parameter 'InputFile' when calling ResourcesDictionaryEntryImportPost");
      

      var path = "/resources/dictionary/entry/import";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (DictionaryId != null) queryParams.Add("dictionaryId", apiClient.ParameterToString(DictionaryId)); // query parameter
       if (SourceLang != null) queryParams.Add("sourceLang", apiClient.ParameterToString(SourceLang)); // query parameter
      
      
      if (InputFile != null) fileParams.Add("inputFile", InputFile);
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ResourcesDictionaryEntryImportPost: " + response.Content, response.Content);
      }
      return (DictionariesImportResponse) apiClient.Deserialize(response.Content, typeof(DictionariesImportResponse));
    }
	
	 /// <summary>
    /// Import entries Import entries to an existing dictionary.
    /// </summary>
    /// <param name="DictionaryId">Id of the dictionary where to import entries</param>/// <param name="SourceLang">Source lang of the entries to import</param>/// <param name="InputFile">File with entries to import</param>
    /// <returns>DictionariesImportResponse</returns>
    public async Task<DictionariesImportResponse> ResourcesDictionaryEntryImportPostAsync (string DictionaryId, string SourceLang, string InputFile) {

      
          // verify the required parameter 'DictionaryId' is set
          if (DictionaryId == null) throw new ApiException(400, "Missing required parameter 'DictionaryId' when calling ResourcesDictionaryEntryImportPost");
      
          // verify the required parameter 'SourceLang' is set
          if (SourceLang == null) throw new ApiException(400, "Missing required parameter 'SourceLang' when calling ResourcesDictionaryEntryImportPost");
      
          // verify the required parameter 'InputFile' is set
          if (InputFile == null) throw new ApiException(400, "Missing required parameter 'InputFile' when calling ResourcesDictionaryEntryImportPost");
      

      var path = "/resources/dictionary/entry/import";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (DictionaryId != null) queryParams.Add("dictionaryId", apiClient.ParameterToString(DictionaryId)); // query parameter
       if (SourceLang != null) queryParams.Add("sourceLang", apiClient.ParameterToString(SourceLang)); // query parameter
      
      
      if (InputFile != null) fileParams.Add("inputFile", InputFile);
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ResourcesDictionaryEntryImportPost: " + response.Content, response.Content);
      }
      return (DictionariesImportResponse) apiClient.Deserialize(response.Content, typeof(DictionariesImportResponse));
    }
    
    /// <summary>
    /// List entries List entries for a specific dictionary.
    /// </summary>
    /// <param name="DictionaryId">Dictionary Id</param>/// <param name="Filters">Different filters that can be applied to the list functionality (skip/limit/sort/match)</param>
    /// <returns>EntriesListResponse</returns>
    public EntriesListResponse ResourcesDictionaryEntryListPost (string DictionaryId, EntriesListFilters Filters) {

      
      // verify the required parameter 'DictionaryId' is set
      if (DictionaryId == null) throw new ApiException(400, "Missing required parameter 'DictionaryId' when calling ResourcesDictionaryEntryListPost");
      

      var path = "/resources/dictionary/entry/list";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (DictionaryId != null) queryParams.Add("dictionaryId", apiClient.ParameterToString(DictionaryId)); // query parameter
      
      
      
      postBody = apiClient.Serialize(Filters); // http body (model) parameter
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ResourcesDictionaryEntryListPost: " + response.Content, response.Content);
      }
      return (EntriesListResponse) apiClient.Deserialize(response.Content, typeof(EntriesListResponse));
    }
	
	 /// <summary>
    /// List entries List entries for a specific dictionary.
    /// </summary>
    /// <param name="DictionaryId">Dictionary Id</param>/// <param name="Filters">Different filters that can be applied to the list functionality (skip/limit/sort/match)</param>
    /// <returns>EntriesListResponse</returns>
    public async Task<EntriesListResponse> ResourcesDictionaryEntryListPostAsync (string DictionaryId, EntriesListFilters Filters) {

      
          // verify the required parameter 'DictionaryId' is set
          if (DictionaryId == null) throw new ApiException(400, "Missing required parameter 'DictionaryId' when calling ResourcesDictionaryEntryListPost");
      

      var path = "/resources/dictionary/entry/list";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (DictionaryId != null) queryParams.Add("dictionaryId", apiClient.ParameterToString(DictionaryId)); // query parameter
      
      
      
      postBody = apiClient.Serialize(Filters); // http body (model) parameter
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ResourcesDictionaryEntryListPost: " + response.Content, response.Content);
      }
      return (EntriesListResponse) apiClient.Deserialize(response.Content, typeof(EntriesListResponse));
    }
    
    /// <summary>
    /// Update an entry Update an entry in an existing dictionary.
    /// </summary>
    /// <param name="DictionaryId">Dictionary Id</param>/// <param name="Input">Input with dictionary id + entry id (src or tgt) to delete</param>
    /// <returns>EntryUpdateResponse</returns>
    public EntryUpdateResponse ResourcesDictionaryEntryUpdatePost (string DictionaryId, EntryUpdateBody Input) {

      
      // verify the required parameter 'DictionaryId' is set
      if (DictionaryId == null) throw new ApiException(400, "Missing required parameter 'DictionaryId' when calling ResourcesDictionaryEntryUpdatePost");
      
      // verify the required parameter 'Input' is set
      if (Input == null) throw new ApiException(400, "Missing required parameter 'Input' when calling ResourcesDictionaryEntryUpdatePost");
      

      var path = "/resources/dictionary/entry/update";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (DictionaryId != null) queryParams.Add("dictionaryId", apiClient.ParameterToString(DictionaryId)); // query parameter
      
      
      
      postBody = apiClient.Serialize(Input); // http body (model) parameter
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ResourcesDictionaryEntryUpdatePost: " + response.Content, response.Content);
      }
      return (EntryUpdateResponse) apiClient.Deserialize(response.Content, typeof(EntryUpdateResponse));
    }
	
	 /// <summary>
    /// Update an entry Update an entry in an existing dictionary.
    /// </summary>
    /// <param name="DictionaryId">Dictionary Id</param>/// <param name="Input">Input with dictionary id + entry id (src or tgt) to delete</param>
    /// <returns>EntryUpdateResponse</returns>
    public async Task<EntryUpdateResponse> ResourcesDictionaryEntryUpdatePostAsync (string DictionaryId, EntryUpdateBody Input) {

      
          // verify the required parameter 'DictionaryId' is set
          if (DictionaryId == null) throw new ApiException(400, "Missing required parameter 'DictionaryId' when calling ResourcesDictionaryEntryUpdatePost");
      
          // verify the required parameter 'Input' is set
          if (Input == null) throw new ApiException(400, "Missing required parameter 'Input' when calling ResourcesDictionaryEntryUpdatePost");
      

      var path = "/resources/dictionary/entry/update";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (DictionaryId != null) queryParams.Add("dictionaryId", apiClient.ParameterToString(DictionaryId)); // query parameter
      
      
      
      postBody = apiClient.Serialize(Input); // http body (model) parameter
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ResourcesDictionaryEntryUpdatePost: " + response.Content, response.Content);
      }
      return (EntryUpdateResponse) apiClient.Deserialize(response.Content, typeof(EntryUpdateResponse));
    }
    
    /// <summary>
    /// Export a dictionary Export an existing dictionary.
    /// </summary>
    /// <param name="DictionaryId">Dictionary Id</param>
    /// <returns></returns>
    public void ResourcesDictionaryExportPost (string DictionaryId) {

      
      // verify the required parameter 'DictionaryId' is set
      if (DictionaryId == null) throw new ApiException(400, "Missing required parameter 'DictionaryId' when calling ResourcesDictionaryExportPost");
      

      var path = "/resources/dictionary/export";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (DictionaryId != null) queryParams.Add("dictionaryId", apiClient.ParameterToString(DictionaryId)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ResourcesDictionaryExportPost: " + response.Content, response.Content);
      }
      
      return;
    }
	
	 /// <summary>
    /// Export a dictionary Export an existing dictionary.
    /// </summary>
    /// <param name="DictionaryId">Dictionary Id</param>
    /// <returns></returns>
    public async Task ResourcesDictionaryExportPostAsync (string DictionaryId) {

      
          // verify the required parameter 'DictionaryId' is set
          if (DictionaryId == null) throw new ApiException(400, "Missing required parameter 'DictionaryId' when calling ResourcesDictionaryExportPost");
      

      var path = "/resources/dictionary/export";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (DictionaryId != null) queryParams.Add("dictionaryId", apiClient.ParameterToString(DictionaryId)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ResourcesDictionaryExportPost: " + response.Content, response.Content);
      }
      
      return;
    }
    
    /// <summary>
    /// List dictionaries List the dictionaries.
    /// </summary>
    /// <param name="Filters">Different filters that can be applied to the list functionality (skip/limit/sort/match)</param>
    /// <returns>DictionariesListResponse</returns>
    public DictionariesListResponse ResourcesDictionaryListPost (DictionariesListFilters Filters) {

      

      var path = "/resources/dictionary/list";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
      
      
      postBody = apiClient.Serialize(Filters); // http body (model) parameter
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ResourcesDictionaryListPost: " + response.Content, response.Content);
      }
      return (DictionariesListResponse) apiClient.Deserialize(response.Content, typeof(DictionariesListResponse));
    }
	
	 /// <summary>
    /// List dictionaries List the dictionaries.
    /// </summary>
    /// <param name="Filters">Different filters that can be applied to the list functionality (skip/limit/sort/match)</param>
    /// <returns>DictionariesListResponse</returns>
    public async Task<DictionariesListResponse> ResourcesDictionaryListPostAsync (DictionariesListFilters Filters) {

      

      var path = "/resources/dictionary/list";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
      
      
      postBody = apiClient.Serialize(Filters); // http body (model) parameter
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ResourcesDictionaryListPost: " + response.Content, response.Content);
      }
      return (DictionariesListResponse) apiClient.Deserialize(response.Content, typeof(DictionariesListResponse));
    }
    
    /// <summary>
    /// Lookup Lookup words from a source language to a target language.
    /// </summary>
    /// <param name="Source">Language code of the source text\n</param>/// <param name="Target">Language code in which to lookup the source text\n</param>/// <param name="Input">Input word (the &#39;input&#39; parameter can be repeated)\n</param>/// <param name="Autocomplete">With this option, if the input word is not found in the source language, it will be filled in with autocompletion to perform the lookup\n\nDefault: false\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>LookupResponse</returns>
    public LookupResponse ResourcesDictionaryLookupGet (string Source, string Target, List<string> Input, bool? Autocomplete, string Callback) {

      
      // verify the required parameter 'Source' is set
      if (Source == null) throw new ApiException(400, "Missing required parameter 'Source' when calling ResourcesDictionaryLookupGet");
      
      // verify the required parameter 'Target' is set
      if (Target == null) throw new ApiException(400, "Missing required parameter 'Target' when calling ResourcesDictionaryLookupGet");
      
      // verify the required parameter 'Input' is set
      if (Input == null) throw new ApiException(400, "Missing required parameter 'Input' when calling ResourcesDictionaryLookupGet");
      

      var path = "/resources/dictionary/lookup";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Source != null) queryParams.Add("source", apiClient.ParameterToString(Source)); // query parameter
       if (Target != null) queryParams.Add("target", apiClient.ParameterToString(Target)); // query parameter
       if (Input != null) queryParams.Add("input", apiClient.ParameterToString(Input)); // query parameter
       if (Autocomplete != null) queryParams.Add("autocomplete", apiClient.ParameterToString(Autocomplete)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ResourcesDictionaryLookupGet: " + response.Content, response.Content);
      }
      return (LookupResponse) apiClient.Deserialize(response.Content, typeof(LookupResponse));
    }
	
	 /// <summary>
    /// Lookup Lookup words from a source language to a target language.
    /// </summary>
    /// <param name="Source">Language code of the source text\n</param>/// <param name="Target">Language code in which to lookup the source text\n</param>/// <param name="Input">Input word (the &#39;input&#39; parameter can be repeated)\n</param>/// <param name="Autocomplete">With this option, if the input word is not found in the source language, it will be filled in with autocompletion to perform the lookup\n\nDefault: false\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>LookupResponse</returns>
    public async Task<LookupResponse> ResourcesDictionaryLookupGetAsync (string Source, string Target, List<string> Input, bool? Autocomplete, string Callback) {

      
          // verify the required parameter 'Source' is set
          if (Source == null) throw new ApiException(400, "Missing required parameter 'Source' when calling ResourcesDictionaryLookupGet");
      
          // verify the required parameter 'Target' is set
          if (Target == null) throw new ApiException(400, "Missing required parameter 'Target' when calling ResourcesDictionaryLookupGet");
      
          // verify the required parameter 'Input' is set
          if (Input == null) throw new ApiException(400, "Missing required parameter 'Input' when calling ResourcesDictionaryLookupGet");
      

      var path = "/resources/dictionary/lookup";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Source != null) queryParams.Add("source", apiClient.ParameterToString(Source)); // query parameter
       if (Target != null) queryParams.Add("target", apiClient.ParameterToString(Target)); // query parameter
       if (Input != null) queryParams.Add("input", apiClient.ParameterToString(Input)); // query parameter
       if (Autocomplete != null) queryParams.Add("autocomplete", apiClient.ParameterToString(Autocomplete)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ResourcesDictionaryLookupGet: " + response.Content, response.Content);
      }
      return (LookupResponse) apiClient.Deserialize(response.Content, typeof(LookupResponse));
    }
    
    /// <summary>
    /// Lookup Supported Languages List of language pairs in which lookup is supported. This list can be limited to a specific source language or target language.\n
    /// </summary>
    /// <param name="Source">Language code of the source text\n</param>/// <param name="Target">Language code into which to translate the source text\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>LookupSupportedLanguageResponse</returns>
    public LookupSupportedLanguageResponse ResourcesDictionaryLookupSupportedLanguagesGet (string Source, string Target, string Callback) {

      

      var path = "/resources/dictionary/lookup/supportedLanguages";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Source != null) queryParams.Add("source", apiClient.ParameterToString(Source)); // query parameter
       if (Target != null) queryParams.Add("target", apiClient.ParameterToString(Target)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ResourcesDictionaryLookupSupportedLanguagesGet: " + response.Content, response.Content);
      }
      return (LookupSupportedLanguageResponse) apiClient.Deserialize(response.Content, typeof(LookupSupportedLanguageResponse));
    }
	
	 /// <summary>
    /// Lookup Supported Languages List of language pairs in which lookup is supported. This list can be limited to a specific source language or target language.\n
    /// </summary>
    /// <param name="Source">Language code of the source text\n</param>/// <param name="Target">Language code into which to translate the source text\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>LookupSupportedLanguageResponse</returns>
    public async Task<LookupSupportedLanguageResponse> ResourcesDictionaryLookupSupportedLanguagesGetAsync (string Source, string Target, string Callback) {

      

      var path = "/resources/dictionary/lookup/supportedLanguages";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Source != null) queryParams.Add("source", apiClient.ParameterToString(Source)); // query parameter
       if (Target != null) queryParams.Add("target", apiClient.ParameterToString(Target)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ResourcesDictionaryLookupSupportedLanguagesGet: " + response.Content, response.Content);
      }
      return (LookupSupportedLanguageResponse) apiClient.Deserialize(response.Content, typeof(LookupSupportedLanguageResponse));
    }
    
    /// <summary>
    /// Supported Languages Get supported languages by dictionaries
    /// </summary>
    
    /// <returns>SupportedLanguagesResponse</returns>
    public SupportedLanguagesResponse ResourcesDictionarySupportedLanguagesGet () {

      

      var path = "/resources/dictionary/supportedLanguages";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ResourcesDictionarySupportedLanguagesGet: " + response.Content, response.Content);
      }
      return (SupportedLanguagesResponse) apiClient.Deserialize(response.Content, typeof(SupportedLanguagesResponse));
    }
	
	 /// <summary>
    /// Supported Languages Get supported languages by dictionaries
    /// </summary>
    
    /// <returns>SupportedLanguagesResponse</returns>
    public async Task<SupportedLanguagesResponse> ResourcesDictionarySupportedLanguagesGetAsync () {

      

      var path = "/resources/dictionary/supportedLanguages";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ResourcesDictionarySupportedLanguagesGet: " + response.Content, response.Content);
      }
      return (SupportedLanguagesResponse) apiClient.Deserialize(response.Content, typeof(SupportedLanguagesResponse));
    }
    
    /// <summary>
    /// Update a dictionary Update an existing dictionary.
    /// </summary>
    /// <param name="DictionaryId">Dictionary Id</param>/// <param name="Input">Input with dictionary id</param>
    /// <returns>DictionaryUpdateResponse</returns>
    public DictionaryUpdateResponse ResourcesDictionaryUpdatePost (string DictionaryId, DictionaryUpdateBody Input) {

      
      // verify the required parameter 'DictionaryId' is set
      if (DictionaryId == null) throw new ApiException(400, "Missing required parameter 'DictionaryId' when calling ResourcesDictionaryUpdatePost");
      
      // verify the required parameter 'Input' is set
      if (Input == null) throw new ApiException(400, "Missing required parameter 'Input' when calling ResourcesDictionaryUpdatePost");
      

      var path = "/resources/dictionary/update";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (DictionaryId != null) queryParams.Add("dictionaryId", apiClient.ParameterToString(DictionaryId)); // query parameter
      
      
      
      postBody = apiClient.Serialize(Input); // http body (model) parameter
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ResourcesDictionaryUpdatePost: " + response.Content, response.Content);
      }
      return (DictionaryUpdateResponse) apiClient.Deserialize(response.Content, typeof(DictionaryUpdateResponse));
    }
	
	 /// <summary>
    /// Update a dictionary Update an existing dictionary.
    /// </summary>
    /// <param name="DictionaryId">Dictionary Id</param>/// <param name="Input">Input with dictionary id</param>
    /// <returns>DictionaryUpdateResponse</returns>
    public async Task<DictionaryUpdateResponse> ResourcesDictionaryUpdatePostAsync (string DictionaryId, DictionaryUpdateBody Input) {

      
          // verify the required parameter 'DictionaryId' is set
          if (DictionaryId == null) throw new ApiException(400, "Missing required parameter 'DictionaryId' when calling ResourcesDictionaryUpdatePost");
      
          // verify the required parameter 'Input' is set
          if (Input == null) throw new ApiException(400, "Missing required parameter 'Input' when calling ResourcesDictionaryUpdatePost");
      

      var path = "/resources/dictionary/update";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (DictionaryId != null) queryParams.Add("dictionaryId", apiClient.ParameterToString(DictionaryId)); // query parameter
      
      
      
      postBody = apiClient.Serialize(Input); // http body (model) parameter
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ResourcesDictionaryUpdatePost: " + response.Content, response.Content);
      }
      return (DictionaryUpdateResponse) apiClient.Deserialize(response.Content, typeof(DictionaryUpdateResponse));
    }
    
  }  
  
}
