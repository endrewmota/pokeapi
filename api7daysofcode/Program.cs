// See https://aka.ms/new-console-template for more information



using RestSharp;

var client = new RestClient($"https://pokeapi.co/api/v2/ability/65/");
var request = new RestRequest("", Method.Get);

var response = client.Execute(request);

Console.WriteLine(response.Content);
