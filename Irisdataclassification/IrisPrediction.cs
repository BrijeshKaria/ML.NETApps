// IrisPrediction is the result returned from prediction operations
using Microsoft.ML.Runtime.Api;

public class IrisPrediction
        {
            [ColumnName("PredictedLabel")]
            public string PredictedLabels;
        }