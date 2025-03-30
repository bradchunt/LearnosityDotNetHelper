# Learnosity .Net Helper
A personal project. Not sponsored, endorsed, or supported by Learnosity. Learning as I am going.

This project is meant to make it easier for a C# developer to interact with the Learnosity APIs.

Example Usage:
```
//A Learnosity meta object that can be added to questions and items.
Meta meta = new();
meta.User.FirstName = "First";
meta.User.LastName = "Last";
meta.User.Email = "first.last@site.com";

//Create a list of questions that will be sent to the Learnosity API
Questions questions = new Questions();
questions.Meta = meta;

//Create the question first
Question question = new Question();
question.Type = QuestionTypes.Mcq;
question.Reference = "Unique-Reference-Value-Here";
question.Data.Stimulus = "What is the capital of Texas?";
question.Data.Options.Add(new Option() { Label = "Austin", Value = "A" });
question.Data.Options.Add(new Option() { Label = "Dallas", Value = "B" });
question.Data.Options.Add(new Option() { Label = "Waco", Value = "C" });
question.Data.Options.Add(new Option() { Label = "Lubbock", Value = "D" });
question.Data.Type = QuestionTypes.Mcq;
question.Data.Validation.ScoringType = "exactMatch";
question.Data.Validation.ValidResponse.Score = 1;
question.Data.Validation.ValidResponse.Value.Add("A");
questions.Question.Add(question);

//create a list of items that will be sent to the Learnosity API
Items items = new Items();
items.Meta = meta;

//add the question to an item
Item item = new Item();
item.Reference = "Unique-Reference-Value-Here";
item.Status = Statuses.Published;
item.QuestionReferences.Add(new QuestionReference() { Reference = question.Reference });
item.Definition.Widgets.Add(new Widget() { Reference = question.Reference });
items.Item.Add(item);

//Call SetQuestions and SetItems to create the items in Learnosity
itemBank.SetQuestions(questions);
itemBank.SetItems(items);
```

In your project, you will need to configure an appsettings.json file with needed Learnosity API information.

For example see below. Note the consumer key and secret below are publicly available and point to the Learnosity Demo site.
```
{
    "LearnositySettings": {
        "ConsumerKey": "yis0TYCu7U9V4o7M",
        "ConsumerSecret": "74c5fd430cf1242a527f6223aebd42d30464be22",
        "URLAssess": "https://assess.learnosity.com/v2025.1.LTS",
        "URLAuthorAPI": "https://authorapi.learnosity.com/v2025.1.LTS",
        "URLData": "https://data.learnosity.com/v2025.1.LTS",
        "URLItems": "https://items.learnosity.com/v2025.1.LTS",
        "URLReports": "https://reports.learnosity.com/v2025.1.LTS"
    }
}
  
```


