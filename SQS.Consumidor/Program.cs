using Amazon;
using Amazon.SQS;
using Amazon.SQS.Model;

const string urlQueue = "https://sqs.sa-east-1.amazonaws.com/480910489369/teste";

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var client = new AmazonSQSClient(RegionEndpoint.SAEast1);
var request = new ReceiveMessageRequest()
{
    QueueUrl = urlQueue
};

while (true)
{
    var response = await client.ReceiveMessageAsync(request);

    foreach (var message in response.Messages)
    {
        Console.WriteLine(message.Body);
        await client.DeleteMessageAsync(urlQueue, message.ReceiptHandle);
    }
}