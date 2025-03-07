using System.Windows.Forms;

namespace DDR
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_up = new System.Windows.Forms.Button();
            this.btn_right = new System.Windows.Forms.Button();
            this.btn_down = new System.Windows.Forms.Button();
            this.btn_left = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.lbl_punteggio = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btn_up, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_right, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_down, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_left, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_Start, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(200, 250);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(400, 400);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_up
            // 
            this.btn_up.Image = global::DDR.Properties.Resources.UpOff;
            this.btn_up.Location = new System.Drawing.Point(136, 3);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(127, 127);
            this.btn_up.TabIndex = 0;
            this.btn_up.UseVisualStyleBackColor = true;
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // btn_right
            // 
            this.btn_right.Image = global::DDR.Properties.Resources.RightOff;
            this.btn_right.Location = new System.Drawing.Point(269, 136);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(128, 127);
            this.btn_right.TabIndex = 1;
            this.btn_right.UseVisualStyleBackColor = true;
            this.btn_right.Click += new System.EventHandler(this.btn_right_Click);
            // 
            // btn_down
            // 
            this.btn_down.Image = global::DDR.Properties.Resources.DownOff;
            this.btn_down.Location = new System.Drawing.Point(136, 269);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(127, 128);
            this.btn_down.TabIndex = 2;
            this.btn_down.UseVisualStyleBackColor = true;
            this.btn_down.Click += new System.EventHandler(this.btn_down_Click);
            // 
            // btn_left
            // 
            this.btn_left.Image = global::DDR.Properties.Resources.LeftOff;
            this.btn_left.Location = new System.Drawing.Point(3, 136);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(127, 127);
            this.btn_left.TabIndex = 3;
            this.btn_left.UseVisualStyleBackColor = true;
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.Location = new System.Drawing.Point(136, 136);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(127, 127);
            this.btn_Start.TabIndex = 2;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_punteggio
            // 
            this.lbl_punteggio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_punteggio.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_punteggio.Location = new System.Drawing.Point(21, 9);
            this.lbl_punteggio.Name = "lbl_punteggio";
            this.lbl_punteggio.Size = new System.Drawing.Size(143, 170);
            this.lbl_punteggio.TabIndex = 1;
            this.lbl_punteggio.Text = "Putneggio";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DDR.Properties.Resources._675486_cosi_ghiacciato_tony_1537;
            this.ClientSize = new System.Drawing.Size(784, 655);
            this.Controls.Add(this.lbl_punteggio);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Dance Dance Revolution!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_up;
        private System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.Button btn_down;
        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Label lbl_punteggio;
    }
}

