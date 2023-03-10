namespace CalculoHoras
{
    partial class CalculoHoraForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            dateTimePickerEntrada1 = new DateTimePicker();
            label2 = new Label();
            dateTimePickerSaida1 = new DateTimePicker();
            dateTimePickerSaida2 = new DateTimePicker();
            dateTimePickerEntrada2 = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textTotal = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 31);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "1ª entrada";
            // 
            // dateTimePickerEntrada1
            // 
            dateTimePickerEntrada1.Location = new Point(102, 28);
            dateTimePickerEntrada1.Name = "dateTimePickerEntrada1";
            dateTimePickerEntrada1.Size = new Size(68, 23);
            dateTimePickerEntrada1.TabIndex = 4;
            dateTimePickerEntrada1.Value = new DateTime(2023, 3, 9, 18, 44, 0, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(189, 31);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 2;
            label2.Text = "1ª Saída";
            // 
            // dateTimePickerSaida1
            // 
            dateTimePickerSaida1.Location = new Point(244, 28);
            dateTimePickerSaida1.Name = "dateTimePickerSaida1";
            dateTimePickerSaida1.Size = new Size(68, 23);
            dateTimePickerSaida1.TabIndex = 5;
            dateTimePickerSaida1.Value = new DateTime(2023, 3, 9, 18, 44, 0, 0);
            // 
            // dateTimePickerSaida2
            // 
            dateTimePickerSaida2.Location = new Point(244, 69);
            dateTimePickerSaida2.Name = "dateTimePickerSaida2";
            dateTimePickerSaida2.Size = new Size(68, 23);
            dateTimePickerSaida2.TabIndex = 9;
            dateTimePickerSaida2.Value = new DateTime(2023, 3, 9, 18, 44, 0, 0);
            dateTimePickerSaida2.Leave += dateTimePickerSaida2_Leave;
            // 
            // dateTimePickerEntrada2
            // 
            dateTimePickerEntrada2.Location = new Point(102, 69);
            dateTimePickerEntrada2.Name = "dateTimePickerEntrada2";
            dateTimePickerEntrada2.Size = new Size(68, 23);
            dateTimePickerEntrada2.TabIndex = 8;
            dateTimePickerEntrada2.Value = new DateTime(2023, 3, 9, 18, 44, 0, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(189, 72);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 7;
            label3.Text = "2ª Saída";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 72);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 6;
            label4.Text = "2ª entrada";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 123);
            label5.Name = "label5";
            label5.Size = new Size(142, 15);
            label5.TabIndex = 10;
            label5.Text = "Total de horas trabalhada:";
            // 
            // textTotal
            // 
            textTotal.Location = new Point(184, 120);
            textTotal.Name = "textTotal";
            textTotal.Size = new Size(123, 23);
            textTotal.TabIndex = 11;
            // 
            // CalculoHoraForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 169);
            Controls.Add(textTotal);
            Controls.Add(label5);
            Controls.Add(dateTimePickerSaida2);
            Controls.Add(dateTimePickerEntrada2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(dateTimePickerSaida1);
            Controls.Add(dateTimePickerEntrada1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CalculoHoraForm";
            Text = "CalculoHoraForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private DateTimePicker dateTimePickerEntrada1;
        private Label label2;
        private DateTimePicker dateTimePickerSaida1;
        private DateTimePicker dateTimePickerSaida2;
        private DateTimePicker dateTimePickerEntrada2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textTotal;
    }
}