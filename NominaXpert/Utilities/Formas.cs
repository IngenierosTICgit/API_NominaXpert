using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NominaXpertCore.Utilities
{
    internal class Formas
    {

        private static IconButton currentBtn;
        private static Panel leftBorderBtn = new Panel() { Size = new Size(7, 60) };

        // Estructura para colores
        public struct RGBColors
        {
            public static Color ChangeColor = Color.FromArgb(12, 215, 253);
        }

        // Método para inicializar el panel de borde izquierdo en un contenedor
        public static void InitializePanel(Control parent)
        {
            if (leftBorderBtn == null || leftBorderBtn.IsDisposed)
            {
                leftBorderBtn = new Panel() { Size = new Size(7, 60) };
            }
            parent.Controls.Add(leftBorderBtn);
            leftBorderBtn.Visible = false;
        }

        // Método para activar un botón
        public static void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(59, 62, 68);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                // Configurar borde izquierdo
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Size = new Size(currentBtn.Width, 3);
                leftBorderBtn.Location = new Point(currentBtn.Location.X, currentBtn.Location.Y + currentBtn.Height);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        // Método para desactivar el botón actual
        public static void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(48, 51, 59);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = RGBColors.ChangeColor;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }


    }
}
