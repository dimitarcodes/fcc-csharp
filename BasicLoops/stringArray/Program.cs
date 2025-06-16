string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int periodLocation;

foreach (string queriedString in myStrings)
{
    periodLocation = queriedString.IndexOf(".");
    string leftOverSentences = queriedString;
    bool over = false;
    do
    {
        if (periodLocation < 0)
        {
            Console.WriteLine(leftOverSentences);
            over = true;
        }
        else
        {
            Console.WriteLine(leftOverSentences.Substring(0, periodLocation));
            leftOverSentences = leftOverSentences.Substring(periodLocation + 1).Trim();
            periodLocation = leftOverSentences.IndexOf(".");
        }
    } while (!over);
}
