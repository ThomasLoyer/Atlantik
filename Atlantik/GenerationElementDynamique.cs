using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atlantik
{
    public class GenerationElementDynamique
    {
        public static Label GenererLabel(string nom, string text, int x, int y, int largeur, int hauteur)
        {
            Label label = new Label();
            label.Name = nom;
            label.Text = text;
            label.Location = new System.Drawing.Point(x, y);
            label.Size = new System.Drawing.Size(largeur,hauteur);
            return label;
        }
        public static TextBox GenererTextBox(string nom, int x, int y)
        {
            TextBox textBox = new TextBox();
            textBox.Name = nom;
            textBox.Location = new System.Drawing.Point(x, y);
            return textBox;
        }
        public static GroupBox GenererGroupBox(string text, int x, int y, int largeur, int hauteur)
        {
            GroupBox groupBox = new GroupBox();
            groupBox.Text = text;
            groupBox.Location = new Point(x, y);
            groupBox.Size = new Size(largeur, hauteur);
            return groupBox;
        }
    }
}
