// See https://aka.ms/new-console-template for more information
using OpenAI_API;

Console.WriteLine("Hello, World!");
var api= new OpenAI_API(" ");
var request = new OpenAI_AP.Images.ImageGenerationRequest{
    Prompt = ""
};
var response = api.ImageGenerationRequest.CreateImageAsync(request);
Console.WriteLine("Image URL: {0}", response.Date[0].URL);