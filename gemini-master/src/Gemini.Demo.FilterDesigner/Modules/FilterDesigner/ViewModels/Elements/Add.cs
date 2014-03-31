﻿using System.Windows.Media;
using System.Windows.Media.Effects;
using Gemini.Demo.FilterDesigner.Modules.FilterDesigner.ShaderEffects;
using Gemini.Modules.Toolbox;

namespace Gemini.Demo.FilterDesigner.Modules.FilterDesigner.ViewModels.Elements
{
    [ToolboxItem(typeof(GraphViewModel), "Add", "Maths")]
    public class Add : ShaderEffectElement
    {
        protected override Effect GetEffect()
        {
            return new AddEffect
            {
                Input1 = new ImageBrush(InputConnectors[0].Value),
                Input2 = new ImageBrush(InputConnectors[1].Value)
            };
        }

        public Add()
        {
            AddInputConnector("Left", Colors.DarkSeaGreen);
            AddInputConnector("Right", Colors.DarkSeaGreen);
        }
    }
}