using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Data;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ConfigureAppearance();
        }
        private void ConfigureAppearance()
        {
            // Настройка цветовой схемы
            this.BackColor = Color.FromArgb(240, 245, 249);
            this.ForeColor = Color.FromArgb(52, 73, 94);

            // Стиль для таблицы
            petDataView.EnableHeadersVisualStyles = false;
            petDataView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 152, 219);
            petDataView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            petDataView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            petDataView.DefaultCellStyle.BackColor = Color.FromArgb(236, 240, 241);
            petDataView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(189, 195, 199);
            petDataView.GridColor = Color.FromArgb(149, 165, 166);
        }

        private void btnImportData_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.Title = "Выберите файл с данными о питомцах";
                fileDialog.Filter = "Файлы данных (*.xml)|*.xml|Все файлы (*.*)|*.*";
                fileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        DataTable petTable = new DataTable();
                        XmlDocument xmlDoc = new XmlDocument();
                        xmlDoc.Load(fileDialog.FileName);

                        XmlNodeList petNodes = xmlDoc.DocumentElement.SelectNodes("Pet");

                        if (petNodes.Count > 0)
                        {
                            // Добавляем колонки
                            petTable.Columns.Add("Кличка", typeof(string));
                            petTable.Columns.Add("Вид", typeof(string));
                            petTable.Columns.Add("Возраст", typeof(int));
                            petTable.Columns.Add("Особенности", typeof(string));

                            foreach (XmlNode petNode in petNodes)
                            {
                                DataRow row = petTable.NewRow();
                                row["Кличка"] = petNode.SelectSingleNode("Name")?.InnerText ?? "-";
                                row["Вид"] = petNode.SelectSingleNode("Type")?.InnerText ?? "-";
                                row["Возраст"] = int.TryParse(petNode.SelectSingleNode("Age")?.InnerText, out int age) ? age : 0;
                                row["Особенности"] = petNode.SelectSingleNode("Features")?.InnerText ?? "нет";
                                petTable.Rows.Add(row);
                            }
                        }

                        petDataView.DataSource = petTable;
                        lblStatusMessage.Text = $"Загружено {petTable.Rows.Count} записей | Файл: {fileDialog.SafeFileName}";
                        lblStatusMessage.ForeColor = Color.FromArgb(39, 174, 96);
                    }
                    catch (Exception ex)
                    {
                        lblStatusMessage.Text = "Ошибка загрузки данных";
                        lblStatusMessage.ForeColor = Color.FromArgb(231, 76, 60);
                        MessageBox.Show($"Не удалось загрузить данные: {ex.Message}",
                                      "Ошибка",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnClearData_Click(object sender, EventArgs e)
        {
            petDataView.DataSource = null;
            lblStatusMessage.Text = "Готов к загрузке данных";
            lblStatusMessage.ForeColor = Color.FromArgb(52, 73, 94);
        }


    }
}
