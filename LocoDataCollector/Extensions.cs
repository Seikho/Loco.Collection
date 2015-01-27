using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loco.Collection
{
    static class Extensions
    {
        public async static void AppendTextAsync(this RichTextBox box, string text, Color color)
        {
            await new Task(() =>
            {
                box.SelectionStart = box.TextLength;
                box.SelectionLength = 0;

                box.SelectionColor = color;
                box.AppendText(text);
                box.SelectionColor = box.ForeColor;
            });
        }
    }
}
