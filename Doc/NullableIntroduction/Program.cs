namespace NullableIntroduction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var surveyRun = new SurveyRun();
            surveyRun.AddQuestion(QuestionType.YesNo, "Has you code ever thrown a NullreferenceExeption?");
            surveyRun.AddQuestion(new SurveyQuestion(QuestionType.Number, "How many time?"));
            surveyRun.AddQuestion(QuestionType.Text, "What is your favorite color?");
            //surveyRun.AddQuestion(QuestionType.Text, default);
        }
    }
}
