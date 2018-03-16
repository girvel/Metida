using System.Windows;
using System.Windows.Controls;

namespace Metida.Controls
{
    public class DiagramCanvas : Canvas
    {
        static DiagramCanvas()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DiagramCanvas), new FrameworkPropertyMetadata(typeof(DiagramCanvas)));
        }
    }
}
