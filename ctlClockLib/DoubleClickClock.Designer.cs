namespace ctlClockLib
{
    partial class DoubleClickClock
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAlarm = new System.Windows.Forms.Label();
            this.btnAlarmOff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAlarm
            // 
            this.lblAlarm.AutoSize = true;
            this.lblAlarm.Location = new System.Drawing.Point(3, 33);
            this.lblAlarm.Name = "lblAlarm";
            this.lblAlarm.Size = new System.Drawing.Size(36, 13);
            this.lblAlarm.TabIndex = 1;
            this.lblAlarm.Text = "Alarm!";
            this.lblAlarm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAlarm.Visible = false;
            // 
            // btnAlarmOff
            // 
            this.btnAlarmOff.Location = new System.Drawing.Point(277, 177);
            this.btnAlarmOff.Name = "btnAlarmOff";
            this.btnAlarmOff.Size = new System.Drawing.Size(102, 23);
            this.btnAlarmOff.TabIndex = 2;
            this.btnAlarmOff.Tag = "Disable Alarm";
            this.btnAlarmOff.Text = "Disable Alarm";
            this.btnAlarmOff.UseVisualStyleBackColor = true;
            this.btnAlarmOff.Click += new System.EventHandler(this.btnAlarmOff_Click);
            // 
            // DoubleClickClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClockBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.btnAlarmOff);
            this.Controls.Add(this.lblAlarm);
            this.Name = "DoubleClickClock";
            this.Controls.SetChildIndex(this.lblAlarm, 0);
            this.Controls.SetChildIndex(this.btnAlarmOff, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAlarm;
        private System.Windows.Forms.Button btnAlarmOff;
    }
}
