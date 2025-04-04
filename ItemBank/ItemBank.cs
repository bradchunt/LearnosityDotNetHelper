﻿using Newtonsoft.Json;
using LearnositySDK.Request;
using LearnositySDK.Utils;
using Microsoft.Extensions.Options;




namespace LearnosityDotNetHelper;
public class ItemBank
{

    private readonly LearnositySettings _settings;

    public ItemBank(IOptions<LearnositySettings> settings)
    {
        _settings = settings?.Value ?? throw new ArgumentNullException(nameof(settings));
    }


    private ApiResponse SendDataApiRequest(string url, string action, object dataObject)
    {
        try
        {
            string json = JsonConvert.SerializeObject(dataObject, Formatting.Indented,
            new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

            JsonObject security = new JsonObject();
            security.set("consumer_key", _settings.ConsumerKey);
            security.set("domain", "localhost");

            DataApi da = new DataApi();
            JsonObject request = JsonObjectFactory.fromString(json);
            Remote r = da.request(url, security, _settings.ConsumerSecret, request, action);

            ApiResponse response = new ApiResponse
            {
                HttpStatusCode = Convert.ToInt32(r.getStatusCode()),
                RawResponseBody = r.getBody()
            };

            // Parse the response body
            try
            {
                response.ParsedResponse = JsonConvert.DeserializeObject<dynamic>(r.getBody());

                // Check the API's internal success status
                if (response.ParsedResponse?.meta?.status != null)
                {
                    response.IsSuccess = (bool)response.ParsedResponse.meta.status;

                    // For error responses, extract additional information
                    if (!response.IsSuccess && response.ParsedResponse.meta.message != null)
                    {
                        response.ErrorMessage = response.ParsedResponse.meta.message.ToString();
                    }

                    if (response.ParsedResponse.meta.request_uuid != null)
                    {
                        response.RequestUuid = response.ParsedResponse.meta.request_uuid.ToString();
                    }
                }
                else
                {
                    response.IsSuccess = Convert.ToInt32(r.getStatusCode()) == 200;
                }
            }
            catch
            {
                // If we can't parse the response, base success on HTTP status code
                response.IsSuccess = Convert.ToInt32(r.getStatusCode()) == 200;
            }

            return response;
        }
        catch (Exception ex)
        {
            return new ApiResponse
            {
                IsSuccess = false,
                ErrorMessage = ex.Message
            };
        }
    }


    /// https://reference.learnosity.com/data-api/endpoints/itembank_endpoints#setFeatures
    /// </summary>
    /// <param name="questions"></param>
    /// <returns></returns>
    public ApiResponse SetFeatures(Features features)
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
    public ApiResponse SetQuestions(Questions questions)
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

    public ApiResponse SetItems(Items items)
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

    public ApiResponse SetActivities(Activities activities)
    {
        string url = $"{_settings.URLData}/itembank/activities";
        return SendDataApiRequest(url, "set", activities);
    }

    /// <summary>
    /// Pass a collection of activity references to the API. 
    /// https://help.learnosity.com/hc/en-us/articles/26076378893725-Activities-Endpoints-Data-API#get-activities
    /// </summary>
    /// <param name="activityReferences"></param>
    /// <returns></returns>

    public ApiResponse GetActivities(ActivityReferences activityReferences)
    {
        string url = $"{_settings.URLData}/itembank/activities";
        return SendDataApiRequest(url, "get", activityReferences);
    }

    /// <summary>
    /// Pass a collection of item references to the API. 
    /// https://help.learnosity.com/hc/en-us/articles/26076386828189-Items-Endpoints-Data-API#get-items
    /// </summary>
    /// <param name="itemReferences"></param>
    /// <returns></returns>

    public ApiResponse GetItems(ItemReferences itemReferences)
    {
        string url = $"{_settings.URLData}/itembank/items";
        return SendDataApiRequest(url, "get", itemReferences);
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

    public bool ActivityExists(string reference)
    {
        ActivityReferences activityReferences = new ActivityReferences();
        activityReferences.References.Add(reference);

        ApiResponse activityExists = GetActivities(activityReferences);
        if (activityExists != null)
        {
            string jsonResponse = activityExists.RawResponseBody;
            JsonObject jsonObject = JsonObjectFactory.fromString(jsonResponse);
            int recordsCount = jsonObject.getJsonObject("meta").getInt("records");
            return recordsCount > 0;
        }
        return false;
    }

    public bool ItemsExist(Activity activity)
    {
       
        ItemReferences itemReferences = new ItemReferences();
        itemReferences.References = activity.ActivityData.Items.ToList(); // Directly use the item strings.

        ApiResponse itemsExists = GetItems(itemReferences);

        if (itemsExists != null)
        {
            string jsonResponse = itemsExists.RawResponseBody;
            try
            {
                JsonObject jsonObject = JsonObjectFactory.fromString(jsonResponse);
                int recordsCount = jsonObject.getJsonObject("meta").getInt("records");

                return recordsCount > 0;
            }
            catch (Newtonsoft.Json.JsonReaderException)
            {
                // Handle invalid JSON response
                return false;
            }
        }

        return false;
    }
}

