using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Runtime.Api;
using Microsoft.ML.Trainers;
using Microsoft.ML.Transforms;
using System;

namespace Irisdataclassification
{
    public class IrisData
    {
            [Column("0")]
            public float SepalLength;

            [Column("1")]
            public float SepalWidth;

            [Column("2")]
            public float PetalLength;

            [Column("3")]
            public float PetalWidth;

            [Column("4")]
            [ColumnName("Label")]
            public string Label;
    }
}