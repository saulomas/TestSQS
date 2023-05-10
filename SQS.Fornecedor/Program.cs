using Amazon;
using Amazon.SQS;
using Amazon.SQS.Model;

const string urlQueue = "https://sqs.sa-east-1.amazonaws.com/480910489369/teste";

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var client = new AmazonSQSClient(RegionEndpoint.SAEast1);
var request = new SendMessageRequest(urlQueue, "Teste 123.");

await client.SendMessageAsync(request);