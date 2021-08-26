using System;
using Ringhel.Procesio.Action.Core;
using Ringhel.Procesio.Action.Core.ActionDecorators;
using Ringhel.Procesio.Action.Core.Utils;
using System.Threading.Tasks;

namespace ProcesioCustomAction
{
    [ClassDecorator(Name = "Trim", Shape = ActionShape.Square, Description = "Trim Action", Classification = Classification.cat1,
            Tooltip = "Tooltip of the action", IsTestable = false)]
    [FEDecorator(Label = "Configure formatting", Type = FeComponentType.Side_pannel, Tab = "Presentation", Parent = "Side_Panel_Parent", RowId = 1)]
    [Permissions(CanDelete = true, CanDuplicate = true, CanAddFromToolbar = true)]
    public class Class1 : IAction
    {

        [FEDecorator(Label = "Input string ", Type = FeComponentType.Text, Parent = "Side_Panel_Parent", RowId = 1)]
        [BEDecorator(IOProperty = Direction.Input)]
        [Validator(IsRequired = true, Expects = ExpectedType.String)]
        public string input { get; set; }

        [FEDecorator(Label = "Input string/character ", Type = FeComponentType.Text, Parent = "Side_Panel_Parent", RowId = 2)]
        [BEDecorator(IOProperty = Direction.Input)]
        [Validator(IsRequired = true, Expects = ExpectedType.String)]
        public string characters { get; set; }

        [FEDecorator(Label = "String after trim", Type = FeComponentType.Text, Parent = "Side_Panel_Parent", RowId = 3)]
        [BEDecorator(IOProperty = Direction.Output)]
        [Validator(IsRequired = true)]
        public string output { get; set; }

        public async Task Execute()
        {
            char[] chrs = characters.ToCharArray();
            output = input.Trim(chrs);
        }

    }
}
