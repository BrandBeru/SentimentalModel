using SentimentModel_ConsoleApp1;

Console.WriteLine("Eneter a comment: ");

String comment = Console.ReadLine();

// Create single instance of sample data from first line of dataset for model input
SentimentModel.ModelInput sampleData = new SentimentModel.ModelInput()
{
    Col0 = comment
};

// Make a single prediction on the sample data and print results
var predictionResult = SentimentModel.Predict(sampleData);

Console.WriteLine("Using model to make single prediction -- Comparing actual Col1 with predicted Col1 from sample data...\n\n");

var sentiment = predictionResult.PredictedLabel == 1 ? "Positive" : "Negative";

Console.WriteLine($"Text: {sampleData.Col0}\nSentiment: {sentiment}");
Console.WriteLine($"Col1: {0F}");

Console.WriteLine("=============== End of process, hit any key to finish ===============");
Console.ReadKey();

