﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class CustomControl1 : Control
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Ejemplo de pintura personalizada
            // Puedes modificar este código para personalizar tu control

            // Pintar un rectángulo rojo en el control
            using (Brush brush = new SolidBrush(Color.Red))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }

            // Pintar texto en el control
            using (Font font = new Font("Arial", 14))
            {
                e.Graphics.DrawString("Custom Control", font, Brushes.White, new PointF(10, 10));
            }
        }

        // Puedes agregar propiedades y métodos personalizados aquí
        public string CustomText { get; set; } = "Default Text";

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            // Ejemplo: Cambiar el color del control al hacer clic
            this.BackColor = this.BackColor == Color.Red ? Color.Blue : Color.Red;
            this.Invalidate(); // Forzar redibujado
        }
    }
}
