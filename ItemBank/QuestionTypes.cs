using Newtonsoft.Json;
using System.Runtime.Serialization;
using Newtonsoft.Json.Converters;

namespace LearnosityDotNetHelper;

[JsonConverter(typeof(StringEnumConverter))]
public enum QuestionTypes
{   
    [EnumMember(Value="association")]
    Association,

    [EnumMember(Value="audio")]
    Audio,

    [EnumMember(Value="chemistry")]
    Chemistry,

    [EnumMember(Value="chemistryessayV2")]
    ChemistryEssayV2,

    [EnumMember(Value="choicematrix")]
    ChoiceMatrix,

    [EnumMember(Value="classification")]
    Classification,

    [EnumMember(Value="clozeassociation")]
    ClozeAssociation,

    [EnumMember(Value="clozechemistry")]
    ClozeChemistry,

    [EnumMember(Value="clozedropdown")]
    ClozeDropdown,

    [EnumMember(Value="clozeformula")]
    ClozeFormula,

    [EnumMember(Value="clozeformulaV2")]
    ClozeFormulaV2,

    [EnumMember(Value="clozetext")]
    ClozeText,

    [EnumMember(Value="drawing")]
    Drawing,

    [EnumMember(Value="fileupload")]
    FileUpload,

    //[EnumMember(Value="fillshape")]
    //FillShape,

    //[EnumMember(Value="formula")]
    //Formula,

    //[EnumMember(Value="formulaV2")]
    //FormulaV2,

    //[EnumMember(Value="formulaEssay")]
    //FormulaEssay,

    [EnumMember(Value="formulaessayV2")]
    FormulaEssayV2,

    [EnumMember(Value="graphplotting")]
    GraphPlotting,

    [EnumMember(Value="gridded")]
    Gridded,

    //[EnumMember(Value="highlight")]
    //Highlight,

    [EnumMember(Value="hotspot")]
    Hotspot,

    //[EnumMember(Value="imageClozeAssociation")]
    //ImageClozeAssociation,

    [EnumMember(Value="imageclozeassociationV2")]
    ImageClozeAssociationV2,

    [EnumMember(Value="imageclozechemistry")]
    ImageClozeChemistry,

    [EnumMember(Value="imageclozedropdown")]
    ImageClozeDropdown,

    [EnumMember(Value="imageclozeformula")]
    ImageClozeFormula,

    [EnumMember(Value="imageclozeformulaV2")]
    ImageClozeFormulaV2,

    [EnumMember(Value="imageclozetext")]
    ImageClozeText,

    [EnumMember(Value="imageupload")]
    ImageUpload,

    //[EnumMember(Value="longtext")]
    //LongText,

    [EnumMember(Value="longtextV2")]
    LongTextV2,

    [EnumMember(Value="mcq")]
    Mcq,

    [EnumMember(Value="numberline")]
    NumberLine,

    [EnumMember(Value="numberlineplot")]
    NumberLinePlot,

    [EnumMember(Value="orderlist")]
    OrderList,

    [EnumMember(Value="plaintext")]
    PlainText,

    [EnumMember(Value="rating")]
    Rating,

    [EnumMember(Value="shorttext")]
    ShortText,

    [EnumMember(Value="simplechart")]
    SimpleChart,

    [EnumMember(Value="simpleshading")]
    SimpleShading,

    [EnumMember(Value="sortlist")]
    SortList,

    //[EnumMember(Value="textHighlight")]
    //TextHighlight,

    [EnumMember(Value="tokenhighlight")]
    TokenHighlight
}

