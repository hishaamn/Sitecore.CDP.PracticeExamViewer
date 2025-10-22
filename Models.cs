using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sitecore.CdpPracticeExamViewer
{
    public class Root
    {
        [JsonPropertyName("metadata")]
        public object Metadata { get; set; }

        [JsonPropertyName("questions")]
        public List<QuestionData> Questions { get; set; }
    }

    public class QuestionData
    {
        [JsonPropertyName("competency")]
        public string Competency { get; set; }

        [JsonPropertyName("question")]
        public string Question { get; set; }

        [JsonPropertyName("options")]
        public Dictionary<string, string> Options { get; set; }

        [JsonPropertyName("answer")]
        public string Answer { get; set; }
    }
}
