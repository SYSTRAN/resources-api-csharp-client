using Microsoft.VisualStudio.TestTools.UnitTesting;
using Systran.ResourcesClientLib.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Systran.ResourcesClientLib.Client;
using Systran.ResourcesClientLib.Model;

namespace Systran.ResourcesClientLib.Api.Tests
{
    [TestClass()]
    public class DictionaryApiTests
    {
        private static ApiClient client;
        private static DictionaryApi dictionaryApi;
        private static String dictionaryId;


        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {
            client = new ApiClient("https://platformapi-stag.systran.net:8904");
            Configuration.apiClient = client;
            Dictionary<String, String> keys = new Dictionary<String, String>();
            keys.Add("key", "a72c2f99-5841-4259-88a6-f75f9860f992");
            Configuration.apiKey = keys;
            dictionaryApi = new DictionaryApi(Configuration.apiClient);


        }

        [TestMethod()]
        public void GetBasePathTest()
        {
            Assert.IsInstanceOfType(dictionaryApi.apiClient.basePath, typeof(string));
        }

        [TestMethod()]
        public void ResourcesDictionaryAddPostTest()
        {
            DictionaryAddResponse dictionaryAddResponse = new DictionaryAddResponse();
            DictionaryAddBody dictionaryAddBody = new DictionaryAddBody();
            DictionaryAddInput dictionaryAddInput = new DictionaryAddInput();
            dictionaryAddInput.SourceLang = "en";
            dictionaryAddInput.TargetLangs = "fr";
            dictionaryAddInput.Name = "testCsharpClient";
            dictionaryAddInput.Type = "";
            dictionaryAddInput.Comments = "This dictionary has been created for csharp client testing purposes";

            dictionaryAddBody.Dictionary = dictionaryAddInput;
            dictionaryAddResponse = dictionaryApi.ResourcesDictionaryAddPost(dictionaryAddBody);
            Assert.IsNotNull(dictionaryAddResponse.Added);
            if (dictionaryAddResponse != null)
            {
                dictionaryId = dictionaryAddResponse.Added.Id;
            }

        }


        [TestMethod()]
        public void ResourcesDictionaryEntryAddPostTest()
        {
            EntryAddBody entryAddBody = new EntryAddBody();
            EntryAddInput entryAddInput = new EntryAddInput();
            entryAddInput.SourceLang = "en";
            entryAddInput.Source = "test";
            entryAddInput.TargetLang = "fr";
            entryAddInput.Target = "test";
            entryAddInput.Type = "";
            entryAddInput.SourcePos = "";
            entryAddInput.TargetPos = "";
            entryAddInput.Priority = "";
            entryAddBody.Entry = entryAddInput;
            EntryAddResponse entryAddResponse = new EntryAddResponse();
            entryAddResponse = dictionaryApi.ResourcesDictionaryEntryAddPost(dictionaryId, entryAddBody);
            Assert.IsNotNull(entryAddResponse);
        }

        [TestMethod()]
        public void ResourcesDictionaryEntryImportPostTest()
        {
            DictionariesImportResponse dictionariesImportResponse = new DictionariesImportResponse();
            dictionariesImportResponse = dictionaryApi.ResourcesDictionaryEntryImportPost(dictionaryId, "en", "../../entries.txt");
            Assert.IsNotNull(dictionariesImportResponse.Total);
        }

        [TestMethod()]
        public void ResourcesDictionaryEntryListPostTest()
        {
            EntriesListFilters entriesListFilters = new EntriesListFilters();
            EntriesListResponse entriesListResponse = new EntriesListResponse();
            entriesListResponse = dictionaryApi.ResourcesDictionaryEntryListPost(dictionaryId, entriesListFilters);
            Assert.IsNotNull(entriesListResponse.TotalNoLimit);
        }

        [TestMethod()]
        public void ResourcesDictionaryEntryListPostAsyncTest()
        {
            EntriesListFilters entriesListFilters = new EntriesListFilters();
            EntriesListResponse entriesListResponse = new EntriesListResponse();
            Task.Run(async () =>
            {
                entriesListResponse = await dictionaryApi.ResourcesDictionaryEntryListPostAsync(dictionaryId, entriesListFilters);
            }).Wait();
            Assert.IsNotNull(entriesListResponse.TotalNoLimit);
        }

        [TestMethod()]
        public void ResourcesDictionaryEntryUpdatePostTest()
        {

            EntriesListFilters entriesListFilters = new EntriesListFilters();
            EntriesListResponse entriesListResponse = new EntriesListResponse();
            entriesListResponse = dictionaryApi.ResourcesDictionaryEntryListPost(dictionaryId, entriesListFilters);

            EntryUpdateBody entryUpdateBody = new EntryUpdateBody();
            EntryUpdateInput entryUpdateInput = new EntryUpdateInput();
            EntryUpdateResponse entryUpdateResponse = new EntryUpdateResponse();
            entryUpdateBody.SourceId = entriesListResponse.Entries[0].SourceId;
            entryUpdateBody.TargetId = entriesListResponse.Entries[0].TargetId;

            entryUpdateInput.Priority = "";
            entryUpdateInput.Type = "";
            entryUpdateInput.SourcePos = "";
            entryUpdateInput.TargetPos = "";
            entryUpdateInput.Source = "example";
            entryUpdateInput.Target = "exemple";
            entryUpdateInput.TargetLang = "fr";
            entryUpdateInput.SourceLang = "en";
            entryUpdateBody.Update = entryUpdateInput;


            entryUpdateResponse = dictionaryApi.ResourcesDictionaryEntryUpdatePost(dictionaryId, entryUpdateBody);
            Assert.IsNotNull(entryUpdateResponse.TargetId);
        }

        /*    [TestMethod()]
          public void ResourcesDictionaryEntryUpdatePostAsyncTest()
           {
               EntryUpdateBody entryUpdateBody = new EntryUpdateBody();
               EntryUpdateResponse entryUpdateResponse = new EntryUpdateResponse();
               Task.Run(async () =>
               {
                   entryUpdateResponse = await dictionaryApi.ResourcesDictionaryEntryUpdatePostAsync(dictionaryId, entryUpdateBody);
               }).Wait();
               Assert.IsNotNull(entryUpdateResponse.TargetId);
           }*/

 

        [TestMethod()]
        public void ResourcesDictionaryListPostTest()
        {
            DictionariesListFilters dictionariesListFilters = new DictionariesListFilters();
            DictionariesListResponse dictionariesListResponse = new DictionariesListResponse();
            dictionariesListResponse = dictionaryApi.ResourcesDictionaryListPost(dictionariesListFilters);
            Assert.IsNotNull(dictionariesListResponse.Dictionaries);
        }

        [TestMethod()]
        public void ResourcesDictionaryLookupGetTest()
        {
            LookupResponse lookupResponse = new LookupResponse();
            List<string> inputs = new List<string>();
            inputs.Add("example");
            lookupResponse = dictionaryApi.ResourcesDictionaryLookupGet("en", "fr", inputs, null, null);
            Assert.IsNotNull(lookupResponse.Outputs);
        }

        [TestMethod()]
        public void ResourcesDictionaryLookupGetAsyncTest()
        {
            LookupResponse lookupResponse = new LookupResponse();
            List<string> inputs = new List<string>();
            inputs.Add("example");
            Task.Run(async () =>
            {
                lookupResponse = await dictionaryApi.ResourcesDictionaryLookupGetAsync("en", "fr", inputs, null, null);
            }).Wait();
            Assert.IsNotNull(lookupResponse.Outputs);
        }

        [TestMethod()]
        public void ResourcesDictionaryLookupSupportedLanguagesGetTest()
        {
            LookupSupportedLanguageResponse lookupSupportedLanguageResponse = new LookupSupportedLanguageResponse();
            lookupSupportedLanguageResponse = dictionaryApi.ResourcesDictionaryLookupSupportedLanguagesGet(null, null, null);
            Assert.IsNotNull(lookupSupportedLanguageResponse.LanguagePairs);
        }

        [TestMethod()]
        public void ResourcesDictionaryLookupSupportedLanguagesGetAsyncTest()
        {
            LookupSupportedLanguageResponse lookupSupportedLanguageResponse = new LookupSupportedLanguageResponse();
            Task.Run(async () =>
            {
                lookupSupportedLanguageResponse = await dictionaryApi.ResourcesDictionaryLookupSupportedLanguagesGetAsync(null, null, null);
            }).Wait();
            Assert.IsNotNull(lookupSupportedLanguageResponse.LanguagePairs);
        }

        [TestMethod()]
        public void ResourcesDictionarySupportedLanguagesGetTest()
        {
            SupportedLanguagesResponse supportedLanguagesResponse = new SupportedLanguagesResponse();
            supportedLanguagesResponse = dictionaryApi.ResourcesDictionarySupportedLanguagesGet();
            Assert.IsNotNull(supportedLanguagesResponse.Languages);
        }

        [TestMethod()]
        public void ResourcesDictionarySupportedLanguagesGetAsyncTest()
        {
            SupportedLanguagesResponse supportedLanguagesResponse = new SupportedLanguagesResponse();
            Task.Run(async () =>
            {
                supportedLanguagesResponse = await dictionaryApi.ResourcesDictionarySupportedLanguagesGetAsync();
            }).Wait();
            Assert.IsNotNull(supportedLanguagesResponse.Languages);
        }

        [TestMethod()]
        public void ResourcesDictionaryUpdatePostTest()
        {
            EntriesListResponse entriesListResponse = new EntriesListResponse();


            DictionaryUpdateBody dictionaryUpdateBody = new DictionaryUpdateBody();
            DictionaryUpdateInput dictionaryUpdateInput = new DictionaryUpdateInput();
            dictionaryUpdateInput.Comments = "This dictionary has been created and updated for csharp client testing purposes";
            dictionaryUpdateBody.Dictionary = dictionaryUpdateInput;

            DictionaryUpdateResponse dictionaryUpdateResponse = new DictionaryUpdateResponse();
            dictionaryUpdateResponse = dictionaryApi.ResourcesDictionaryUpdatePost(dictionaryId, dictionaryUpdateBody);
            Assert.IsNotNull(dictionaryUpdateResponse.Updated);
        }

        [TestMethod()]
        public void ResourcesDictionaryEntryDeletePostTest()
        {

            EntriesListResponse entriesListResponse = new EntriesListResponse();
            EntriesListFilters entriesListFilters = new EntriesListFilters();
            entriesListResponse = dictionaryApi.ResourcesDictionaryEntryListPost(dictionaryId, entriesListFilters);


            EntryDeleteBody entryDeleteBody = new EntryDeleteBody();
            EntryDeleteInput entryDeleteInput = new EntryDeleteInput();
            entryDeleteInput.SourceId = entriesListResponse.Entries[0].SourceId;
            entryDeleteInput.TargetId = entriesListResponse.Entries[0].TargetId;
            entryDeleteBody.Entry = entryDeleteInput;
            EntryDeleteResponse entryDeleteResponse = new EntryDeleteResponse();
            entryDeleteResponse = dictionaryApi.ResourcesDictionaryEntryDeletePost(dictionaryId, entryDeleteBody);
            Assert.IsNotNull(entryDeleteResponse.Status);
        }


        [TestMethod()]
        public void ResourcesDictionaryDeletePostTest()
        {
            dictionaryApi.ResourcesDictionaryDeletePost(dictionaryId);
        }

    }
}