
namespace Calculadora
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.boton_division = new System.Windows.Forms.Button();
            this.boton_delete = new System.Windows.Forms.Button();
            this.boton_clear = new System.Windows.Forms.Button();
            this.labelContador = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.boton_multi = new System.Windows.Forms.Button();
            this.boton_resta = new System.Windows.Forms.Button();
            this.boton_9 = new System.Windows.Forms.Button();
            this.boton_6 = new System.Windows.Forms.Button();
            this.boton_8 = new System.Windows.Forms.Button();
            this.boton_5 = new System.Windows.Forms.Button();
            this.boton_7 = new System.Windows.Forms.Button();
            this.boton_4 = new System.Windows.Forms.Button();
            this.boton_suma = new System.Windows.Forms.Button();
            this.boton_3 = new System.Windows.Forms.Button();
            this.boton_2 = new System.Windows.Forms.Button();
            this.boton_1 = new System.Windows.Forms.Button();
            this.boton_igual = new System.Windows.Forms.Button();
            this.boton_coma = new System.Windows.Forms.Button();
            this.boton_0 = new System.Windows.Forms.Button();
            this.boton_negacion = new System.Windows.Forms.Button();
            this.dataTableOperations = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableOperations)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.boton_division);
            this.panel1.Controls.Add(this.boton_delete);
            this.panel1.Controls.Add(this.boton_clear);
            this.panel1.Controls.Add(this.labelContador);
            this.panel1.Controls.Add(this.labelResult);
            this.panel1.Controls.Add(this.boton_multi);
            this.panel1.Controls.Add(this.boton_resta);
            this.panel1.Controls.Add(this.boton_9);
            this.panel1.Controls.Add(this.boton_6);
            this.panel1.Controls.Add(this.boton_8);
            this.panel1.Controls.Add(this.boton_5);
            this.panel1.Controls.Add(this.boton_7);
            this.panel1.Controls.Add(this.boton_4);
            this.panel1.Controls.Add(this.boton_suma);
            this.panel1.Controls.Add(this.boton_3);
            this.panel1.Controls.Add(this.boton_2);
            this.panel1.Controls.Add(this.boton_1);
            this.panel1.Controls.Add(this.boton_igual);
            this.panel1.Controls.Add(this.boton_coma);
            this.panel1.Controls.Add(this.boton_0);
            this.panel1.Controls.Add(this.boton_negacion);
            this.panel1.Location = new System.Drawing.Point(64, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 233);
            this.panel1.TabIndex = 0;
            this.panel1.UseWaitCursor = true;
            // 
            // boton_division
            // 
            this.boton_division.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.boton_division.CausesValidation = false;
            this.boton_division.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.boton_division.Location = new System.Drawing.Point(136, 87);
            this.boton_division.Margin = new System.Windows.Forms.Padding(1);
            this.boton_division.Name = "boton_division";
            this.boton_division.Size = new System.Drawing.Size(40, 25);
            this.boton_division.TabIndex = 18;
            this.boton_division.Text = "➗";
            this.boton_division.UseVisualStyleBackColor = false;
            this.boton_division.UseWaitCursor = true;
            this.boton_division.Click += new System.EventHandler(this.btn_division);
            // 
            // boton_delete
            // 
            this.boton_delete.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.boton_delete.CausesValidation = false;
            this.boton_delete.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.boton_delete.Location = new System.Drawing.Point(94, 87);
            this.boton_delete.Margin = new System.Windows.Forms.Padding(1);
            this.boton_delete.Name = "boton_delete";
            this.boton_delete.Size = new System.Drawing.Size(40, 25);
            this.boton_delete.TabIndex = 17;
            this.boton_delete.Text = "⩤";
            this.boton_delete.UseVisualStyleBackColor = false;
            this.boton_delete.UseWaitCursor = true;
            this.boton_delete.Click += new System.EventHandler(this.btn_delete);
            // 
            // boton_clear
            // 
            this.boton_clear.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.boton_clear.CausesValidation = false;
            this.boton_clear.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.boton_clear.Location = new System.Drawing.Point(53, 87);
            this.boton_clear.Margin = new System.Windows.Forms.Padding(1);
            this.boton_clear.Name = "boton_clear";
            this.boton_clear.Size = new System.Drawing.Size(40, 25);
            this.boton_clear.TabIndex = 16;
            this.boton_clear.Text = "C";
            this.boton_clear.UseVisualStyleBackColor = false;
            this.boton_clear.UseWaitCursor = true;
            this.boton_clear.Click += new System.EventHandler(this.btn_clear);
            // 
            // labelContador
            // 
            this.labelContador.BackColor = System.Drawing.Color.PowderBlue;
            this.labelContador.Location = new System.Drawing.Point(13, 34);
            this.labelContador.Name = "labelContador";
            this.labelContador.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.labelContador.Size = new System.Drawing.Size(163, 40);
            this.labelContador.TabIndex = 14;
            this.labelContador.Text = "0";
            this.labelContador.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.labelContador.UseWaitCursor = true;
            // 
            // labelResult
            // 
            this.labelResult.BackColor = System.Drawing.Color.LightBlue;
            this.labelResult.Location = new System.Drawing.Point(13, 16);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(163, 18);
            this.labelResult.TabIndex = 13;
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelResult.UseWaitCursor = true;
            // 
            // boton_multi
            // 
            this.boton_multi.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.boton_multi.CausesValidation = false;
            this.boton_multi.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.boton_multi.Location = new System.Drawing.Point(136, 114);
            this.boton_multi.Margin = new System.Windows.Forms.Padding(1);
            this.boton_multi.Name = "boton_multi";
            this.boton_multi.Size = new System.Drawing.Size(40, 25);
            this.boton_multi.TabIndex = 7;
            this.boton_multi.Text = "✖";
            this.boton_multi.UseVisualStyleBackColor = false;
            this.boton_multi.UseWaitCursor = true;
            this.boton_multi.Click += new System.EventHandler(this.btn_multipli);
            // 
            // boton_resta
            // 
            this.boton_resta.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.boton_resta.CausesValidation = false;
            this.boton_resta.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.boton_resta.Location = new System.Drawing.Point(136, 141);
            this.boton_resta.Margin = new System.Windows.Forms.Padding(1);
            this.boton_resta.Name = "boton_resta";
            this.boton_resta.Size = new System.Drawing.Size(40, 25);
            this.boton_resta.TabIndex = 11;
            this.boton_resta.Text = "➖";
            this.boton_resta.UseVisualStyleBackColor = false;
            this.boton_resta.UseWaitCursor = true;
            this.boton_resta.Click += new System.EventHandler(this.btn_resta);
            // 
            // boton_9
            // 
            this.boton_9.BackColor = System.Drawing.SystemColors.Menu;
            this.boton_9.CausesValidation = false;
            this.boton_9.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.boton_9.Location = new System.Drawing.Point(95, 114);
            this.boton_9.Margin = new System.Windows.Forms.Padding(1);
            this.boton_9.Name = "boton_9";
            this.boton_9.Size = new System.Drawing.Size(40, 25);
            this.boton_9.TabIndex = 6;
            this.boton_9.Text = "9";
            this.boton_9.UseVisualStyleBackColor = false;
            this.boton_9.UseWaitCursor = true;
            this.boton_9.Click += new System.EventHandler(this.btn_9);
            // 
            // boton_6
            // 
            this.boton_6.BackColor = System.Drawing.SystemColors.Menu;
            this.boton_6.CausesValidation = false;
            this.boton_6.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.boton_6.Location = new System.Drawing.Point(95, 141);
            this.boton_6.Margin = new System.Windows.Forms.Padding(1);
            this.boton_6.Name = "boton_6";
            this.boton_6.Size = new System.Drawing.Size(40, 25);
            this.boton_6.TabIndex = 10;
            this.boton_6.Text = "6";
            this.boton_6.UseVisualStyleBackColor = false;
            this.boton_6.UseWaitCursor = true;
            this.boton_6.Click += new System.EventHandler(this.btn_6);
            // 
            // boton_8
            // 
            this.boton_8.BackColor = System.Drawing.SystemColors.Menu;
            this.boton_8.CausesValidation = false;
            this.boton_8.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.boton_8.Location = new System.Drawing.Point(53, 114);
            this.boton_8.Margin = new System.Windows.Forms.Padding(1);
            this.boton_8.Name = "boton_8";
            this.boton_8.Size = new System.Drawing.Size(40, 25);
            this.boton_8.TabIndex = 5;
            this.boton_8.Text = "8";
            this.boton_8.UseVisualStyleBackColor = false;
            this.boton_8.UseWaitCursor = true;
            this.boton_8.Click += new System.EventHandler(this.btn_8);
            // 
            // boton_5
            // 
            this.boton_5.BackColor = System.Drawing.SystemColors.Menu;
            this.boton_5.CausesValidation = false;
            this.boton_5.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.boton_5.Location = new System.Drawing.Point(53, 141);
            this.boton_5.Margin = new System.Windows.Forms.Padding(1);
            this.boton_5.Name = "boton_5";
            this.boton_5.Size = new System.Drawing.Size(40, 25);
            this.boton_5.TabIndex = 9;
            this.boton_5.Text = "5";
            this.boton_5.UseVisualStyleBackColor = false;
            this.boton_5.UseWaitCursor = true;
            this.boton_5.Click += new System.EventHandler(this.btn_5);
            // 
            // boton_7
            // 
            this.boton_7.BackColor = System.Drawing.SystemColors.Menu;
            this.boton_7.CausesValidation = false;
            this.boton_7.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.boton_7.Location = new System.Drawing.Point(11, 114);
            this.boton_7.Margin = new System.Windows.Forms.Padding(1);
            this.boton_7.Name = "boton_7";
            this.boton_7.Size = new System.Drawing.Size(40, 25);
            this.boton_7.TabIndex = 4;
            this.boton_7.Text = "7";
            this.boton_7.UseVisualStyleBackColor = false;
            this.boton_7.UseWaitCursor = true;
            this.boton_7.Click += new System.EventHandler(this.btn_7);
            // 
            // boton_4
            // 
            this.boton_4.BackColor = System.Drawing.SystemColors.Menu;
            this.boton_4.CausesValidation = false;
            this.boton_4.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.boton_4.Location = new System.Drawing.Point(11, 141);
            this.boton_4.Margin = new System.Windows.Forms.Padding(1);
            this.boton_4.Name = "boton_4";
            this.boton_4.Size = new System.Drawing.Size(40, 25);
            this.boton_4.TabIndex = 8;
            this.boton_4.Text = "4";
            this.boton_4.UseVisualStyleBackColor = false;
            this.boton_4.UseWaitCursor = true;
            this.boton_4.Click += new System.EventHandler(this.btn_4);
            // 
            // boton_suma
            // 
            this.boton_suma.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.boton_suma.CausesValidation = false;
            this.boton_suma.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.boton_suma.Location = new System.Drawing.Point(136, 168);
            this.boton_suma.Margin = new System.Windows.Forms.Padding(1);
            this.boton_suma.Name = "boton_suma";
            this.boton_suma.Size = new System.Drawing.Size(40, 25);
            this.boton_suma.TabIndex = 7;
            this.boton_suma.Text = "➕";
            this.boton_suma.UseVisualStyleBackColor = false;
            this.boton_suma.UseWaitCursor = true;
            this.boton_suma.Click += new System.EventHandler(this.btn_suma);
            // 
            // boton_3
            // 
            this.boton_3.BackColor = System.Drawing.SystemColors.Menu;
            this.boton_3.CausesValidation = false;
            this.boton_3.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.boton_3.Location = new System.Drawing.Point(95, 168);
            this.boton_3.Margin = new System.Windows.Forms.Padding(1);
            this.boton_3.Name = "boton_3";
            this.boton_3.Size = new System.Drawing.Size(40, 25);
            this.boton_3.TabIndex = 6;
            this.boton_3.Text = "3";
            this.boton_3.UseVisualStyleBackColor = false;
            this.boton_3.UseWaitCursor = true;
            this.boton_3.Click += new System.EventHandler(this.btn_3);
            // 
            // boton_2
            // 
            this.boton_2.BackColor = System.Drawing.SystemColors.Menu;
            this.boton_2.CausesValidation = false;
            this.boton_2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.boton_2.Location = new System.Drawing.Point(53, 168);
            this.boton_2.Margin = new System.Windows.Forms.Padding(1);
            this.boton_2.Name = "boton_2";
            this.boton_2.Size = new System.Drawing.Size(40, 25);
            this.boton_2.TabIndex = 5;
            this.boton_2.Text = "2";
            this.boton_2.UseVisualStyleBackColor = false;
            this.boton_2.UseWaitCursor = true;
            this.boton_2.Click += new System.EventHandler(this.btn_2);
            // 
            // boton_1
            // 
            this.boton_1.BackColor = System.Drawing.SystemColors.Menu;
            this.boton_1.CausesValidation = false;
            this.boton_1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.boton_1.Location = new System.Drawing.Point(11, 168);
            this.boton_1.Margin = new System.Windows.Forms.Padding(1);
            this.boton_1.Name = "boton_1";
            this.boton_1.Size = new System.Drawing.Size(40, 25);
            this.boton_1.TabIndex = 4;
            this.boton_1.Text = "1";
            this.boton_1.UseVisualStyleBackColor = false;
            this.boton_1.UseWaitCursor = true;
            this.boton_1.Click += new System.EventHandler(this.btn_1);
            // 
            // boton_igual
            // 
            this.boton_igual.BackColor = System.Drawing.Color.Tan;
            this.boton_igual.CausesValidation = false;
            this.boton_igual.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.boton_igual.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.boton_igual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_igual.Location = new System.Drawing.Point(137, 195);
            this.boton_igual.Margin = new System.Windows.Forms.Padding(1);
            this.boton_igual.Name = "boton_igual";
            this.boton_igual.Size = new System.Drawing.Size(38, 25);
            this.boton_igual.TabIndex = 3;
            this.boton_igual.Text = "=";
            this.boton_igual.UseVisualStyleBackColor = false;
            this.boton_igual.UseWaitCursor = true;
            this.boton_igual.Click += new System.EventHandler(this.btn_igual);
            // 
            // boton_coma
            // 
            this.boton_coma.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.boton_coma.CausesValidation = false;
            this.boton_coma.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.boton_coma.Location = new System.Drawing.Point(95, 195);
            this.boton_coma.Margin = new System.Windows.Forms.Padding(1);
            this.boton_coma.Name = "boton_coma";
            this.boton_coma.Size = new System.Drawing.Size(40, 25);
            this.boton_coma.TabIndex = 2;
            this.boton_coma.Text = ",";
            this.boton_coma.UseVisualStyleBackColor = false;
            this.boton_coma.UseWaitCursor = true;
            this.boton_coma.Click += new System.EventHandler(this.btn_coma);
            // 
            // boton_0
            // 
            this.boton_0.BackColor = System.Drawing.SystemColors.Menu;
            this.boton_0.CausesValidation = false;
            this.boton_0.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.boton_0.Location = new System.Drawing.Point(11, 195);
            this.boton_0.Margin = new System.Windows.Forms.Padding(1);
            this.boton_0.Name = "boton_0";
            this.boton_0.Size = new System.Drawing.Size(82, 25);
            this.boton_0.TabIndex = 1;
            this.boton_0.Text = "0";
            this.boton_0.UseVisualStyleBackColor = false;
            this.boton_0.UseWaitCursor = true;
            this.boton_0.Click += new System.EventHandler(this.btn_0);
            // 
            // boton_negacion
            // 
            this.boton_negacion.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.boton_negacion.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.boton_negacion.CausesValidation = false;
            this.boton_negacion.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.boton_negacion.Location = new System.Drawing.Point(11, 87);
            this.boton_negacion.Margin = new System.Windows.Forms.Padding(1);
            this.boton_negacion.Name = "boton_negacion";
            this.boton_negacion.Size = new System.Drawing.Size(40, 25);
            this.boton_negacion.TabIndex = 0;
            this.boton_negacion.Text = "+/-";
            this.boton_negacion.UseVisualStyleBackColor = false;
            this.boton_negacion.UseWaitCursor = true;
            this.boton_negacion.Click += new System.EventHandler(this.btn_negacion);
            // 
            // dataTableOperations
            // 
            this.dataTableOperations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTableOperations.Location = new System.Drawing.Point(256, 28);
            this.dataTableOperations.Name = "dataTableOperations";
            this.dataTableOperations.Size = new System.Drawing.Size(116, 233);
            this.dataTableOperations.TabIndex = 1;
            this.dataTableOperations.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(580, 334);
            this.Controls.Add(this.dataTableOperations);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTableOperations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button boton_negacion;
        private System.Windows.Forms.Button boton_igual;
        private System.Windows.Forms.Button boton_coma;
        private System.Windows.Forms.Button boton_0;
        private System.Windows.Forms.Button boton_resta;
        private System.Windows.Forms.Button boton_6;
        private System.Windows.Forms.Button boton_5;
        private System.Windows.Forms.Button boton_4;
        private System.Windows.Forms.Button boton_suma;
        private System.Windows.Forms.Button boton_3;
        private System.Windows.Forms.Button boton_2;
        private System.Windows.Forms.Button boton_1;
        private System.Windows.Forms.Button boton_multi;
        private System.Windows.Forms.Button boton_9;
        private System.Windows.Forms.Button boton_8;
        private System.Windows.Forms.Button boton_7;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelContador;
        private System.Windows.Forms.Button boton_division;
        private System.Windows.Forms.Button boton_delete;
        private System.Windows.Forms.Button boton_clear;
        private System.Windows.Forms.DataGridView dataTableOperations;
    }
}

