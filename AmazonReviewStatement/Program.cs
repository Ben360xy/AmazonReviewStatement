using AmazonReviewStatement;


var review = @"this product is good but it gave my family cancer
";

//Load sample data
var sampleData = new DumbAi.ModelInput()
{
    Review_text = review,

};

//Load model and predict output
var result = DumbAi.Predict(sampleData);

Console.WriteLine("Review: " + review);

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