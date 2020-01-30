using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Training2.Components
{
    public class Chart : ComponentBase
    {
        [Inject]
        NavigationManager navigationManager { get; set; }
        public String[] Farben { get; set; } = { "red", "aqua", "fuchsia", "green", "blue", "lime", "yellow", "purple", "silver" };
        [Parameter]
        public double[] Daten { get; set; }
        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            if (Daten == null)
            {
                return;
            }
            var seq = 0;
            double radius = 100;
            double winkel;
            double deltawinkel = 0;
            double summe = 360 / Daten.Sum();
            builder.OpenElement(seq, "figure");
            builder.OpenElement(++seq, "div");

            builder.OpenElement(++seq, "svg");
            builder.AddAttribute(++seq, "viewBox", "0 0 200  200");

            for (int i = 0; i < Daten.Count(); i++)
            {

                winkel = Daten[i] * summe;
                var winkelInRadians = (winkel - 90) * Math.PI / 180.0;
                builder.OpenElement(++seq, "path");
                builder.AddAttribute(++seq, "d", $"M{radius},{radius} L{radius}," +
                    $"0 A{radius},{radius} 1 {(winkel > 180 ? 1 : 0)} 1 " +
                    $"{(radius + radius * Math.Cos(winkelInRadians)).ToString("0.0", CultureInfo.InvariantCulture)}," +
                    $"{(radius + radius * Math.Sin(winkelInRadians)).ToString("0.0", CultureInfo.InvariantCulture)}  z");
                builder.AddAttribute(++seq, "transform", $"rotate({(deltawinkel).ToString("0.0", CultureInfo.InvariantCulture)}, {radius}, {radius})");

                builder.AddAttribute(++seq, "fill", Farben[i]);
                builder.CloseElement();
                deltawinkel += winkel;
            }

            builder.CloseElement();
            builder.CloseElement();
            builder.CloseElement();

            base.BuildRenderTree(builder);
        }

        protected override void OnInitialized()
        {
            base.OnInitialized();
        }
    }
}
