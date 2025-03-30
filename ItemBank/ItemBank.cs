using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using LearnositySDK.Request;
using LearnositySDK.Utils;
using Microsoft.Extensions.Options;
using LearnositySDK.Examples;



namespace LearnosityDotNetHelper;
public class ItemBank
{
   
    private readonly LearnositySettings _settings;

    public ItemBank(IOptions<LearnositySettings> settings)
    {
        _settings = settings?.Value ?? throw new ArgumentNullException(nameof(settings));
    }


    private Remote SendDataApiRequest(string url, string action, object dataObject)
    {
        
        string json = JsonConvert.SerializeObject(dataObject, Formatting.Indented,
        new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        JsonObject security = new JsonObject();
        security.set("consumer_key", _settings.ConsumerKey);
        security.set("domain", "localhost");
        DataApi da = new DataApi();
        JsonObject request = JsonObjectFactory.fromString(json);
        Remote r = da.request(url, security, _settings.ConsumerSecret, request, action);
        return r;
           
    }


    /// https://reference.learnosity.com/data-api/endpoints/itembank_endpoints#setFeatures
    /// </summary>
    /// <param name="questions"></param>
    /// <returns></returns>
    public Remote SetFeatures(Features features)
    {
        string url = $"{_settings.URLData}/itembank/features";
        return SendDataApiRequest(url, "set", features);
    }
        
    /// <summary>
    /// Pass a collection of questions to the API. 
    /// https://reference.learnosity.com/data-api/endpoints/itembank_endpoints#setQuestions
    /// </summary>
    /// <param name="questions"></param>
    /// <returns></returns>
    public Remote SetQuestions(Questions questions)
    {
        string url = $"{_settings.URLData}/itembank/questions";
        return SendDataApiRequest(url, "set", questions);
    }

    /// <summary>
    /// Pass a collection of items to the API. Items contain question references, so questions need to be created first with SetQuestions.
    /// https://reference.learnosity.com/data-api/endpoints/itembank_endpoints#setItems
    /// </summary>
    /// <param name="items"></param>
    /// <returns></returns>
        
    public Remote SetItems(Items items)
    {
        string url = $"{_settings.URLData}/itembank/items";
        return SendDataApiRequest(url, "set", items);
    }

    /// <summary>
    /// Pass a collection of activities to the API. Activities contain item references, so items need to be created first with SetItems.
    /// https://help.learnosity.com/hc/en-us/articles/26076378893725-Activities-Endpoints-Data-API#set-activities
    /// </summary>
    /// <param name="activities"></param>
    /// <returns></returns>

    public Remote SetActivities(Activities activities)
    {
        string url = $"{_settings.URLData}/itembank/activities";
        return SendDataApiRequest(url, "set", activities);
    }


    //https://reference.learnosity.com/data-api/endpoints/itembank_endpoints#getQuestions
    /*  public static string GetQuestions(ItemReferences references)
     {
         string json = JsonConvert.SerializeObject(references, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
         Console.WriteLine(json);

         string url = "https://data.learnosity.com/v2022.2.LTS/itembank/questions";
         string action = "get";


         JsonObject security = new JsonObject();
         security.set("consumer_key", consumerKey);
         security.set("domain", "localhost");


         DataApi da = new DataApi();
         JsonObject request = JsonObjectFactory.fromString(json);
         Remote r = da.request(url, security, consumerSecret, request, action);


         Console.WriteLine(r.getBody().ToString());
         Console.WriteLine(r.getStatusCode().ToString());

         return r.getStatusCode().ToString();

     } */




    //ideally would be async method
    //this method is based on documentation here https://reference.learnosity.com/data-api/endpoints/itembank_endpoints#uploadAssets
    //first you post JSON to create a public URL, then you do an HTTP Put to send the local file content to the URL for storage

    public string UploadAsset(Asset asset)
        {
            string json = JsonConvert.SerializeObject(asset, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
           
            string url = $"{_settings.URLData}/itembank/upload/assets";
            string action = "get";

            JsonObject security = new JsonObject();
            security.set("consumer_key", _settings.ConsumerKey);
            security.set("domain", "localhost");


            DataApi da = new DataApi();
            JsonObject request = JsonObjectFactory.fromString(json);
            Console.WriteLine(json);
            Remote r = da.request(url, security, _settings.ConsumerSecret, request, action);

            string responseBody = r.getBody().ToString();
            Console.WriteLine(r.getBody().ToString());
            
            
            //parse the response and then prep the HTTP PUT with contents inside response
            var response = JsonConvert.DeserializeObject<dynamic>(responseBody);
            string upload = response.data[0].upload;
            string publicURL = response.data[0]["public"];
            string contentType = response.data[0].content_type;

            using (HttpClient httpClient = new HttpClient())
            {
                // Read the binary data from the file
                byte[] fileData = File.ReadAllBytes(asset.Subkeys[0]);

                // Create a ByteArrayContent to hold the image data
                ByteArrayContent content = new ByteArrayContent(fileData);

                // Set the Content-Type header
                content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(contentType);

                // Send the PUT request with the image data
                HttpResponseMessage httpResponse = httpClient.PutAsync(upload, content).Result;

                // Check the response status
                if (httpResponse.IsSuccessStatusCode)
                {
                    Console.WriteLine("PUT request succeeded.");
                }
                else
                {
                    Console.WriteLine($"PUT request failed with status code {httpResponse.StatusCode}");
                }
            }


            return publicURL; //this public url will be used to create the feature based on the uploaded asset
        } 


    
}
