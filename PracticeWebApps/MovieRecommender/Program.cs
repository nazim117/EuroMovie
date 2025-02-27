﻿using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers;

MLContext mlContext = new MLContext();
(IDataView trainingDataView, IDataView testDataView) = LoadData(mlContext);
ITransformer model = BuildAndTrainModel(mlContext, trainingDataView);
EvaluateModel(mlContext, testDataView, model);

var predictionEngine = mlContext.Model.CreatePredictionEngine<MovieRating, MovieRatingPrediction>(model);
var testInput = new MovieRating { userId = 6, movieId = 10 };

var movieRatingPrediction = predictionEngine.Predict(testInput);

if (Math.Round(movieRatingPrediction.Score, 1) > 3.5)
{
    Console.WriteLine("Movie " + testInput.movieId + " is recommended for user " + testInput.userId);
}
else
{
    Console.WriteLine("Movie " + testInput.movieId + " is not recommended for user " + testInput.userId);
}

UseModelForSinglePrediction(mlContext, model);
SaveModel(mlContext, trainingDataView.Schema, model);
(IDataView training, IDataView test) LoadData(MLContext mlContext)
{
    string folderPath = "C:\\Sem2-project-repository\\individual-project-nazim-ahmedov-s2\\PracticeWebApps\\MovieRecommender\\";
    var trainingDataPath = Path.Combine(folderPath, "Data", "recommendation-ratings-train.txt");
    var testDataPath = Path.Combine(folderPath, "Data", "recommendation-ratings-test.txt");

    IDataView trainingDataView = mlContext.Data.LoadFromTextFile<MovieRating>(trainingDataPath, hasHeader: true, separatorChar: ',');
    IDataView testDataView = mlContext.Data.LoadFromTextFile<MovieRating>(testDataPath, hasHeader: true, separatorChar: ',');

    return (trainingDataView, testDataView);
}

ITransformer BuildAndTrainModel(MLContext mlContext, IDataView trainingDataView)
{
    IEstimator<ITransformer> estimator = mlContext.Transforms.Conversion.MapValueToKey(outputColumnName: "userIdEncoded", inputColumnName: "userId")
    .Append(mlContext.Transforms.Conversion.MapValueToKey(outputColumnName: "movieIdEncoded", inputColumnName: "movieId"));

    var options = new MatrixFactorizationTrainer.Options
    {
        MatrixColumnIndexColumnName = "userIdEncoded",
        MatrixRowIndexColumnName = "movieIdEncoded",
        LabelColumnName = "Label",
        NumberOfIterations = 20,
        ApproximationRank = 100
    };

    var trainerEstimator = estimator.Append(mlContext.Recommendation().Trainers.MatrixFactorization(options));
    Console.WriteLine("=============== Training the model ===============");
    ITransformer model = trainerEstimator.Fit(trainingDataView);

    return model;
}

void EvaluateModel(MLContext mlContext, IDataView testDataView, ITransformer model)
{
    Console.WriteLine("=============== Evaluating the model ===============");
    var prediction = model.Transform(testDataView);
    var metrics = mlContext.Regression.Evaluate(prediction, labelColumnName: "Label", scoreColumnName: "Score");
    Console.WriteLine("Root Mean Squared Error : " + metrics.RootMeanSquaredError.ToString());
    Console.WriteLine("RSquared: " + metrics.RSquared.ToString());
}
void UseModelForSinglePrediction(MLContext mlContext, ITransformer model)
{
    Console.WriteLine("=============== Making a prediction ===============");
    var predictionEngine = mlContext.Model.CreatePredictionEngine<MovieRating, MovieRatingPrediction>(model);
}

void SaveModel(MLContext mlContext, DataViewSchema trainingDataViewSchema, ITransformer model)
{
    string folderPath = "C:\\Sem2-project-repository\\individual-project-nazim-ahmedov-s2\\PracticeWebApps\\MovieRecommender\\Data\\MovieRecommenderModel.zip";

    Console.WriteLine("=============== Saving the model to a file ===============");
    mlContext.Model.Save(model, trainingDataViewSchema, folderPath);
}

public class MovieRating
{
    [LoadColumn(0)]
    public float userId;
    [LoadColumn(1)]
    public float movieId;
    [LoadColumn(2)]
    public float Label;
}
public class MovieRatingPrediction
{
    public float Label;
    public float Score;
}