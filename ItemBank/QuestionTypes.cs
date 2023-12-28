using Newtonsoft.Json;
using System.Runtime.Serialization;
using Newtonsoft.Json.Converters;

namespace LearnosityDotNetHelper;

[JsonConverter(typeof(StringEnumConverter))]
public enum QuestionTypes
{   [EnumMember(Value="association")]
    Association,
    
    [EnumMember(Value="audio")]
    Audio,
    [EnumMember(Value="chemistry")]
    Chemistry,
    
    [EnumMember(Value="chemistryessayV2")]
    ChemistryEssayV2,
    ChoiceMatrix,
    Classification,
    ClozeAssociation,
    ClozeChemistry,
    ClozeDropdown,
    ClozeFormula,
    ClozeFormulaV2,
    ClozeText,
    Drawing,
    FileUpload,
    FillShape,
    Formula,
    FormulaV2,
    FormulaEssay,
    FormulaEssayV2,
    GraphPlotting,
    Gridded,
    Highlight,
    Hotspot,
    ImageClozeAssociation,
    ImageClozeAssociationV2,
    ImageClozeChemistry,
    ImageClozeDropdown,
    ImageClozeFormula,
    ImageClozeFormulaV2,
    ImageClozeText,
    ImageUpload,
    LongText,
    LongTextV2,

    [EnumMember(Value="mcq")]
    Mcq,
    NumberLine,
    NumberLinePlot,
    OrderList,
    PlainText,
    Rating,
    ShortText,
    SimpleChart,
    SimpleShading,
    SortList,
    TextHighlight,
    TokenHighlight
}
