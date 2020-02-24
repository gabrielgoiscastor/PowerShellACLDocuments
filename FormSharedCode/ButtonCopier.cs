using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerShellACLDocuments.FormSharedCode
{
    public class ButtonCopier
    {
        public Button copyModelObject(string text, Button baseButton, Panel container)
        {
            int controls = 0;
            foreach (var control in container.Controls)
            {
                if((control is Button) == false)
                {
                    continue;
                }
                controls++;
            }

            Button newBtn = new Button()
            {
                Text = text,
                Size = baseButton.Size,
                Location = new Point()
                {
                    X = baseButton.Location.X,
                    Y = (baseButton.Location.Y + baseButton.Size.Height) * (controls - 1) + 3
                },
                BackColor = baseButton.BackColor,
                Anchor = baseButton.Anchor,
                TextAlign = baseButton.TextAlign
            };

            return newBtn;
        }
    }
}
