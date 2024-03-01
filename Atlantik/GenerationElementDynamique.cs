using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atlantik
{
    public class GenerationElementDynamique
    {
        public static Label GenererLabel(string nom, string text, int x, int y)
        {
            Label label = new Label();
            label.Name = nom;
            label.Text = text;
            label.Location = new System.Drawing.Point(x, y);
            label.Size = new System.Drawing.Size(150,20); //Penser à rentrer la taille dans les parametre plutôt qu'en dure
            return label;
        }
        public static TextBox GenererTextBox(string nom, int x, int y)
        {
            TextBox textBox = new TextBox();
            textBox.Name = nom;
            textBox.Location = new System.Drawing.Point(x, y);
            return textBox;
        }
    }
}
