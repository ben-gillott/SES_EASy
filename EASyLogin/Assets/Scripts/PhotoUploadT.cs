using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;


public class PhotoUploadT //: MonoBehavior
{

    //public static void Main()
    public void CallThisInPhotoUpload()
    {
        string imageFilePath = "//Users//benjamingillott//Desktop//Conf//SES_EASy/EASyLogin//Screenshots//Signature.jpg";//"C:\\Users\\suhu\\Documents\\Trial_upload images\\SES_EASy\\EASyLogin\\Screenshots\\TestImageSign.png";

        MakePredictionRequest(imageFilePath).Wait();

        // Console.WriteLine("\n\nHit ENTER to exit...");
        // Console.ReadLine();
    }

    public /* static*/ async Task MakePredictionRequest(string imageFilePath)
    {
        var client = new HttpClient();

        // Request headers - replace this example key with your valid Prediction-Key.
        client.DefaultRequestHeaders.Add("Prediction-Key", "d499e90087434906a0a80fd5398cc499");

        // Prediction URL - replace this example URL with your valid Prediction URL.
        string url = "https://ml-for-everyone.herokuapp.com/index.html?mode=train&iterationName=Iteration2&projectId=24d9a0b5-2bfd-4948-8684-57f0d32b79ef&trainingApiKey=23cece57dbe143f5a8ad37f2f7b4f54d&predictionApiKey=d499e90087434906a0a80fd5398cc499";

        HttpResponseMessage response;

        // Request body. Try this sample with a locally stored image.
        byte[] byteData = GetImageAsByteArray(imageFilePath);

        using (var content = new ByteArrayContent(byteData))
        {
            content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
            
            Debug.Log("Made it past octet");

            response = await client.PostAsync(url, content);//todo

            Debug.Log("hi :)");
            Debug.Log(await response.Content.ReadAsStringAsync());
            
        }
    }

    private /*static*/ byte[] GetImageAsByteArray(string imageFilePath)
    {
        FileStream fileStream = new FileStream(imageFilePath, FileMode.Open, FileAccess.Read);
        BinaryReader binaryReader = new BinaryReader(fileStream);
        return binaryReader.ReadBytes((int)fileStream.Length);
    }
}

