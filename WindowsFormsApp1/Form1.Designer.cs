using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class Form1
    {
        private DataGridView petDataView;
        private Button btnImportData;
        private Label lblStatusMessage;
        private Button btnClearData;
        private Panel panelHeader;
        private Label lblAppTitle;
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.petDataView = new System.Windows.Forms.DataGridView();
            this.btnImportData = new System.Windows.Forms.Button();
            this.lblStatusMessage = new System.Windows.Forms.Label();
            this.btnClearData = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblAppTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.petDataView)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();

            // petDataView
            this.petDataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
            this.petDataView.BackgroundColor = System.Drawing.Color.White;
            this.petDataView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.petDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.petDataView.Location = new System.Drawing.Point(20, 100);
            this.petDataView.Margin = new System.Windows.Forms.Padding(10);
            this.petDataView.Name = "petDataView";
            this.petDataView.Size = new System.Drawing.Size(744, 380);
            this.petDataView.TabIndex = 0;

            // btnImportData
            this.btnImportData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnImportData.FlatAppearance.BorderSize = 0;
            this.btnImportData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportData.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnImportData.ForeColor = System.Drawing.Color.White;
            this.btnImportData.Location = new System.Drawing.Point(564, 60);
            this.btnImportData.Name = "btnImportData";
            this.btnImportData.Size = new System.Drawing.Size(200, 30);
            this.btnImportData.TabIndex = 1;
            this.btnImportData.Text = "Импорт данных";
            this.btnImportData.UseVisualStyleBackColor = false;
            this.btnImportData.Click += new System.EventHandler(this.btnImportData_Click);

            // lblStatusMessage
            this.lblStatusMessage.AutoSize = true;
            this.lblStatusMessage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatusMessage.Location = new System.Drawing.Point(20, 70);
            this.lblStatusMessage.Name = "lblStatusMessage";
            this.lblStatusMessage.Size = new System.Drawing.Size(117, 15);
            this.lblStatusMessage.TabIndex = 2;
            this.lblStatusMessage.Text = "Готов к загрузке...";

            // btnClearData
            this.btnClearData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearData.BackColor = System.Drawing.Color.FromArgb(231, 76,60);
            this.btnClearData.FlatAppearance.BorderSize = 0;
            this.btnClearData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearData.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClearData.ForeColor = System.Drawing.Color.White;
            this.btnClearData.Location = new System.Drawing.Point(354, 60);
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.Size = new System.Drawing.Size(200, 30);
            this.btnClearData.TabIndex = 3;
            this.btnClearData.Text = "Очистить данные";
            this.btnClearData.UseVisualStyleBackColor = false;
            this.btnClearData.Click += new System.EventHandler(this.btnClearData_Click);

            // panelHeader
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panelHeader.Controls.Add(this.lblAppTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(784, 50);
            this.panelHeader.TabIndex = 4;

            // lblAppTitle
            this.lblAppTitle.AutoSize = true;
            this.lblAppTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAppTitle.ForeColor = System.Drawing.Color.White;
            this.lblAppTitle.Location = new System.Drawing.Point(20, 10);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(194, 25);
            this.lblAppTitle.TabIndex = 0;
            this.lblAppTitle.Text = "Учет животных";

            // PetDataForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 500);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnClearData);
            this.Controls.Add(this.lblStatusMessage);
            this.Controls.Add(this.btnImportData);
            this.Controls.Add(this.petDataView);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimumSize = new System.Drawing.Size(800, 539);
            this.Name = "PetDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Приложение";
            ((System.ComponentModel.ISupportInitialize)(this.petDataView)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}

