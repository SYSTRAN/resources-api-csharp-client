using Microsoft.VisualStudio.TestTools.UnitTesting;
using Systran.ResourcesClientLib.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Systran.ResourcesClientLib.Client;
using Systran.ResourcesClientLib.Model;
using System.IO;

namespace Systran.ResourcesClientLib.Api.Tests
{
    [TestClass()]
    public class CorpusApiTests
    {
        private static ApiClient client;
        private static CorpusApi corpusApi;
        private static string segmentId;
        private static string corpusId;


        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {
            client = new ApiClient("https://platformapi-stag.systran.net:8904");
            Configuration.apiClient = client;
            Dictionary<String, String> keys = new Dictionary<String, String>();
            string key;
            using (StreamReader streamReader = new StreamReader("../../key.txt", Encoding.UTF8))
            {
                key = streamReader.ReadToEnd();
            }
            keys.Add("key", key); Configuration.apiKey = keys; Configuration.apiKey = keys;
            Configuration.apiKey = keys;
            corpusApi = new CorpusApi(Configuration.apiClient);
        }

        [TestMethod()]
        public void GetBasePathTest()
        {
            Assert.IsInstanceOfType(corpusApi.apiClient.basePath, typeof(string));
        }

        [TestMethod()]
        public void ResourcesCorpusAddPostTest()
        {
            CorpusAddResponse corpusAddResponse = new CorpusAddResponse();
            corpusAddResponse = corpusApi.ResourcesCorpusAddPost(@"dotNetTest", @"en", null, null);
            if(corpusAddResponse.Corpus != null)
            {
                corpusId = corpusAddResponse.Corpus.Id;
            }
            Assert.IsNotNull(corpusAddResponse.Corpus);

        }


        [TestMethod()]
        public void ResourcesCorpusDetailsGetTest()
        {
            CorpusDetailResponse corpusDetailResponse = new CorpusDetailResponse();
            corpusDetailResponse = corpusApi.ResourcesCorpusDetailsGet(corpusId, null);
            Assert.IsNotNull(corpusDetailResponse.Corpus);
        }

        [TestMethod()]
        public void ResourcesCorpusDetailsGetAsyncTest()
        {
            CorpusDetailResponse corpusDetailResponse = new CorpusDetailResponse();
            Task.Run(async () =>
            {
                corpusDetailResponse = await corpusApi.ResourcesCorpusDetailsGetAsync(corpusId, null);
            }).Wait();
            Assert.IsNotNull(corpusDetailResponse.Corpus);
        }

        [TestMethod()]
        public void ResourcesCorpusExistsGetTest()
        {
            CorpusExistsResponse corpusExistsResponse = new CorpusExistsResponse();
            corpusExistsResponse = corpusApi.ResourcesCorpusExistsGet("dotNetTest", null);
            Assert.IsNotNull(corpusExistsResponse.Exists);
        }

        [TestMethod()]
        public void ResourcesCorpusExistsGetAsyncTest()
        {
            CorpusExistsResponse corpusExistsResponse = new CorpusExistsResponse();
            Task.Run(async () =>
            {
                corpusExistsResponse = await corpusApi.ResourcesCorpusExistsGetAsync("dotNetTest", null);
            }).Wait();
            Assert.IsNotNull(corpusExistsResponse.Exists);
        }

        [TestMethod()]
        public void ResourcesCorpusExportGetTest()
        {
            string corpusExport;
            corpusExport = corpusApi.ResourcesCorpusExportGet(corpusId, null, null);
            Assert.IsNotNull(corpusExport);
        }


        [TestMethod()]
        public void ResourcesCorpusImportPostTest()
        {
            CorpusImportResponse corpusImportResponse = new CorpusImportResponse();
            corpusImportResponse = corpusApi.ResourcesCorpusImportPost("dotNetTest2", "", null, "application/x-tmx+xml", null, null);

            List<string> corpusList = new List<string>();
            corpusList.Add(corpusImportResponse.Corpus.Id);

            CorpusDeleteResponse corpusDeleteResponse = new CorpusDeleteResponse();
            corpusDeleteResponse = corpusApi.ResourcesCorpusDeletePost(corpusList, null);

            Assert.IsNotNull(corpusImportResponse.Corpus.Id);
        }


        [TestMethod()]
        public void ResourcesCorpusListGetTest()
        {
            CorpusListResponse corpusListResponse = new CorpusListResponse();
            corpusListResponse = corpusApi.ResourcesCorpusListGet(null, null, null, null, null, null, null);
            Assert.IsNotNull(corpusListResponse.Files);

        }

        [TestMethod()]
        public void ResourcesCorpusListGetAsyncTest()
        {
            CorpusListResponse corpusListResponse = new CorpusListResponse();
            Task.Run(async () =>
            {
                corpusListResponse = await corpusApi.ResourcesCorpusListGetAsync(null, null, null, null, null, null, null);
            }).Wait();
            Assert.IsNotNull(corpusListResponse.Files);
        }

        [TestMethod()]
        public void ResourcesCorpusMatchGetTest()
        {       
            List<string> corpusList = new List<string>();
            corpusList.Add(corpusId);
            List<string> input = new List<string>();
            input.Add("dotNetTest");
            CorpusMatchResponse corpusMatchResponse = new CorpusMatchResponse();
            corpusMatchResponse = corpusApi.ResourcesCorpusMatchGet(corpusList, input, "en", "fr", null, null, null);
            Assert.IsNotNull(corpusMatchResponse.Matches);
        }

        [TestMethod()]
        public void ResourcesCorpusSegmentAddPostTest()
        {
            CorpusSegmentAddRequest corpusSegmentAddRequest = new CorpusSegmentAddRequest();
            corpusSegmentAddRequest.CorpusId = corpusId;
            CorpusAddSegment corpusAddSegment = new CorpusAddSegment();
            List<CorpusAddSegment> segList = new List<CorpusAddSegment>();
            corpusAddSegment.Source = "Illustation";
            corpusAddSegment.Lang = "en";
            CorpusAddSegmentTarget corpusAddSegmentTarget = new CorpusAddSegmentTarget();
            corpusAddSegmentTarget.Lang = "fr";
            corpusAddSegmentTarget.Target = "nouveau segment cible";
            List<CorpusAddSegmentTarget> targList = new List<CorpusAddSegmentTarget>();
            targList.Add(corpusAddSegmentTarget);
            corpusAddSegment.Targets = targList;
            segList.Add(corpusAddSegment);
            corpusSegmentAddRequest.Segments = segList;
            CorpusSegmentAddResponse corpusSegmentAddResponse = new CorpusSegmentAddResponse();
            corpusSegmentAddResponse = corpusApi.ResourcesCorpusSegmentAddPost(corpusSegmentAddRequest, null);
            Assert.IsNotNull(corpusSegmentAddResponse.Segments);

        }



        [TestMethod()]
        public void ResourcesCorpusSegmentListGetTest()
        {
            CorpusSegmentListResponse corpusSegmentListResponse = new CorpusSegmentListResponse();
            corpusSegmentListResponse = corpusApi.ResourcesCorpusSegmentListGet(corpusId, null, null, null);
            Assert.IsNotNull(corpusSegmentListResponse.Segments);
        }

        [TestMethod()]
        public void ResourcesCorpusSegmentListGetAsyncTest()
        {
            CorpusSegmentListResponse corpusSegmentListResponse = new CorpusSegmentListResponse();
            Task.Run(async () =>
            {
                corpusSegmentListResponse = await corpusApi.ResourcesCorpusSegmentListGetAsync(corpusId, null, null, null);
            }).Wait();
            Assert.IsNotNull(corpusSegmentListResponse.Segments);
        }

        [TestMethod()]
        public void ResourcesCorpusSegmentTargetAddPostTest()
        {

            CorpusSegmentListResponse corpusSegmentListResponse = new CorpusSegmentListResponse();
            corpusSegmentListResponse = corpusApi.ResourcesCorpusSegmentListGet(corpusId, null, null, null);

            CorpusSegmentAddTargetRequest corpusSegmentAddTargetRequest = new CorpusSegmentAddTargetRequest();
            CorpusSegmentAddTargetResponse corpusSegmentAddTargetResponse = new CorpusSegmentAddTargetResponse();
            corpusSegmentAddTargetRequest.CorpusId = corpusId;
            corpusSegmentAddTargetRequest.SegId = segmentId;
            CorpusAddSegmentTarget corpusAddSegmentTarget = new CorpusAddSegmentTarget();
            corpusAddSegmentTarget.Lang = "fr";
            corpusAddSegmentTarget.Target = "nouveau segment cible";
            List<CorpusAddSegmentTarget> segList = new List<CorpusAddSegmentTarget>();
            segList.Add(corpusAddSegmentTarget);
            corpusSegmentAddTargetRequest.Targets = segList;
            corpusSegmentAddTargetRequest.SegId = corpusSegmentListResponse.Segments[0].Id;
            corpusSegmentAddTargetResponse = corpusApi.ResourcesCorpusSegmentTargetAddPost(corpusSegmentAddTargetRequest, null);
            Assert.IsNotNull(corpusSegmentAddTargetResponse.Added);
        }
        /*
                [TestMethod()]
                public void ResourcesCorpusSegmentTargetDeletePostTest()
                {
                    CorpusSegmentDeleteTargetResponse corpusSegmentDeleteTargetResponse = new CorpusSegmentDeleteTargetResponse();
                    corpusSegmentDeleteTargetResponse = corpusApi.ResourcesCorpusSegmentTargetDeletePost(corpusId, segmentId, "targid", null);
                    Assert.IsNotNull(corpusSegmentDeleteTargetResponse.Deleted);

                }

                [TestMethod()]
                public void ResourcesCorpusSegmentTargetDeletePostAsyncTest()
                {
                    CorpusSegmentDeleteTargetResponse corpusSegmentDeleteTargetResponse = new CorpusSegmentDeleteTargetResponse();
                    Task.Run(async () =>
                    {
                        corpusSegmentDeleteTargetResponse = await corpusApi.ResourcesCorpusSegmentTargetDeletePostAsync(corpusId, segmentId, "targid", null);
                    }).Wait();
                    Assert.IsNotNull(corpusSegmentDeleteTargetResponse.Deleted);
                }*/


        [TestMethod()]
        public void ResourcesCorpusSegmentUpdatePostTest()
        {
            CorpusSegmentListResponse corpusSegmentListResponse = new CorpusSegmentListResponse();
            corpusSegmentListResponse = corpusApi.ResourcesCorpusSegmentListGet(corpusId, null, null, null);

            CorpusSegmentUpdateResponse corpusSegmentUpdateResponse = new CorpusSegmentUpdateResponse();
            corpusSegmentUpdateResponse = corpusApi.ResourcesCorpusSegmentUpdatePost(corpusId, corpusSegmentListResponse.Segments[0].Id, "source", "nouveau segment cible", "target", "targetLand", null);
            Assert.IsNotNull(corpusSegmentUpdateResponse.Updated);
        }

        [TestMethod()]
        public void ResourcesCorpusUpdatePostTest()
        {
            CorpusUpdateResponse corpusUpdateResponse = new CorpusUpdateResponse();
            corpusUpdateResponse = corpusApi.ResourcesCorpusUpdatePost(corpusId, "dotNetTest", null, null);
            Assert.IsNotNull(corpusUpdateResponse.Updated);
        }

        [TestMethod()]
        public void ResourcesCorpusSegmentDeletePostAsyncTest()
        {
            CorpusSegmentDeleteResponse corpusSegmentDeleteResponse = new CorpusSegmentDeleteResponse();
            CorpusSegmentListResponse corpusSegmentListResponse = new CorpusSegmentListResponse();
            corpusSegmentListResponse = corpusApi.ResourcesCorpusSegmentListGet(corpusId, null, null, null);
            List<string> segments = new List<string>();
            segmentId = corpusSegmentListResponse.Segments[0].Id;
            segments.Add(corpusSegmentListResponse.Segments[0].Id); Task.Run(async () =>
            {
                corpusSegmentDeleteResponse = await corpusApi.ResourcesCorpusSegmentDeletePostAsync(corpusId, segments, null);
            }).Wait();
            Assert.IsNotNull(corpusSegmentDeleteResponse.NbDeleted);
        }


        [TestMethod()]
        public void ResourcesCorpusUpdatePostAsyncTest()
        {
            CorpusUpdateResponse corpusUpdateResponse = new CorpusUpdateResponse();
            Task.Run(async () =>
            {
                corpusUpdateResponse = await corpusApi.ResourcesCorpusUpdatePostAsync(corpusId, "dotNetTest", null, null);
            }).Wait();
            Assert.IsNotNull(corpusUpdateResponse.Updated);
        }

        [TestMethod()]
        public void ResourcesCorpusDeletePostTest()
        {
            List<string> corpusList = new List<string>();
            corpusList.Add(corpusId);

            CorpusDeleteResponse corpusDeleteResponse = new CorpusDeleteResponse();
            corpusDeleteResponse = corpusApi.ResourcesCorpusDeletePost(corpusList, null);
            Assert.IsNotNull(corpusDeleteResponse.Files);
        }
    }
}