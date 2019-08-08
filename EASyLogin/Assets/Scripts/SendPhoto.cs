using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.IO;
using System.Linq;
using System.Threading;
// using Microsoft.Cognitive.CustomVision;


public class SendPhoto : MonoBehaviour
{
//     private static List<MemoryStream> WriteOffImages;

//     private static List<MemoryStream> DentImages;

//     private static MemoryStream testImage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("z")){

        }
    }
       

    // void AzureSend()//Main before
    // {
    //     // You can either add your training key here, pass it on the command line, or type it in when the program runs
    //     string trainingKey = GetTrainingKey("23cece57dbe143f5a8ad37f2f7b4f54d", args);

    //     // Create the Api, passing in a credentials object that contains the training key
    //     TrainingApiCredentials trainingCredentials = new TrainingApiCredentials(trainingKey);
    //     TrainingApi trainingApi = new TrainingApi(trainingCredentials);

    //     // Create a new project  
    //     Console.WriteLine("Creating new project:");
    //     var project = trainingApi.CreateProject("Car Assessment");

    //     // Make two tags in the new project  
    //     var WriteOffTag = trainingApi.CreateTag(project.Id, "WriteOff");
    //     var DentTag = trainingApi.CreateTag(project.Id, "Dent");

    //     // Add some images to the tags  
    //     //Console.WriteLine("\tUploading images");
    //     LoadImagesFromDisk();

    //     // Images can be uploaded one at a time  
    //     foreach (var image in WriteOffImages)
    //     {
    //         trainingApi.CreateImagesFromData(project.Id, image, new List< string> () { WriteOffTag.Id.ToString() });
    //     }

    //     // Or uploaded in a single batch   
    //     trainingApi.CreateImagesFromData(project.Id, DentImages, new List< Guid> () { DentTag.Id });

    //     // Now there are images with tags start training the project
    //     Console.WriteLine("\tTraining");
    //     var iteration = trainingApi.TrainProject(project.Id);

    //     // The returned iteration will be in progress, and can be queried periodically to see when it has completed  
    //     while (iteration.Status == "Training")
    //     {
    //         Thread.Sleep(1000);

    //         // Re-query the iteration to get it's updated status  
    //         iteration = trainingApi.GetIteration(project.Id, iteration.Id);
    //     }

    //     // The iteration is now trained. Make it the default project endpoint  
    //     iteration.IsDefault = true;
    //     trainingApi.UpdateIteration(project.Id, iteration.Id, iteration);
    //     Console.WriteLine("Done!\\n");

    //     // Now there is a trained endpoint, it can be used to make a prediction  

    //     // Add your prediction key from the settings page of the portal 
    //     // The prediction key is used in place of the training key when making predictions 
    //     string predictionKey = GetPredictionKey("d499e90087434906a0a80fd5398cc499", args);

    //     // Create a prediction endpoint, passing in a prediction credentials object that contains the obtained prediction key  
    //     PredictionEndpointCredentials predictionEndpointCredentials = new PredictionEndpointCredentials(predictionKey);
    //     PredictionEndpoint endpoint = new PredictionEndpoint(predictionEndpointCredentials);

    //     // Make a prediction against the new project  
    //     Console.WriteLine("Making a prediction:");
    //     var result = endpoint.PredictImage(project.Id, testImage);

    //     // Loop over each prediction and write out the results  
    //     foreach (var c in result.Predictions)
    //     {
    //         Console.WriteLine($"\t{c.Tag}: {c.Probability:P1}");
    //     }
    //     Console.ReadKey();
    // }

    // private static string GetTrainingKey(string trainingKey, string[] args)
    // {
    //     if (string.IsNullOrWhiteSpace(trainingKey) || trainingKey.Equals("23cece57dbe143f5a8ad37f2f7b4f54d"))
    //     {
    //         if (args.Length >= 1)
    //         {
    //             trainingKey = args[0];
    //         }

    //         while (string.IsNullOrWhiteSpace(trainingKey) || trainingKey.Length != 32)
    //         {
    //             Console.Write("Enter your training key: ");
    //             trainingKey = Console.ReadLine();
    //         }
    //         Console.WriteLine();
    //     }

    //     return trainingKey;
    // }

    // private static string GetPredictionKey(string predictionKey, string[] args)
    // {
    //     if (string.IsNullOrWhiteSpace(predictionKey) || predictionKey.Equals("d499e90087434906a0a80fd5398cc499"))
    //     {
    //         if (args.Length >= 1)
    //         {
    //             predictionKey = args[0];
    //         }

    //         while (string.IsNullOrWhiteSpace(predictionKey) || predictionKey.Length != 32)
    //         {
    //             Console.Write("Enter your prediction Key: ");
    //             predictionKey = Console.ReadLine();
    //         }
    //         Console.WriteLine();
    //     }

    //     return predictionKey;
    // }

    // private static void LoadImagesFromDisk()
    // {
    //     // this loads the images to be uploaded from disk into memory
    //     // WriteOffImages = Directory.GetFiles(@"..\..\..\..\Images\writeoff").Select(f => new MemoryStream(File.ReadAllBytes(f))).ToList();
    //     // DentImages = Directory.GetFiles(@"..\..\..\..\Images\Dent").Select(f => new MemoryStream(File.ReadAllBytes(f))).ToList();
    //     testImage = new MemoryStream(File.ReadAllBytes(@"/Users/benjamingillott/Desktop/Conf/SES_EASy/EASyLogin/Screenshots/TestImageSign.jpg"));
    // }
}