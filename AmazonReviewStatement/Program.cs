using AmazonReviewStatement;




//Load sample data
var sampleData = new DumbAi.ModelInput()
{
    Review_text = @"Wow what a great game!",

};

//Load model and predict output
var result = DumbAi.Predict(sampleData);

Console.WriteLine("1 = Negative Review\n2 = Positive Review");

Console.WriteLine(result.PredictedLabel + " is the review score");


if (result.PredictedLabel == 1)
{
    Console.WriteLine("The Review is Negative :(");
}
else
{
    Console.WriteLine("The Review is Positive! :)");
}