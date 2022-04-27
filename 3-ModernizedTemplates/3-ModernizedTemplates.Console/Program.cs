Console.WriteLine("Hello, World!");

var client = new RestClient("https://httpbin.org/get");
var request = new RestRequest();
var response = await client.GetAsync(request);
Console.WriteLine(response.Content);

Console.WriteLine("Press any key to shut down...");
Console.ReadKey();