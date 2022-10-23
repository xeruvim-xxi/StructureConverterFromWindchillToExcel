using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace StructureConverterFromWindchillToExcel
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void bDialogSelectPathFileStructureWindchill_Click(object sender, EventArgs e)
        {
            DialogResult result = oFDPathFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtPathFileStructureWindchill.Text = oFDPathFile.FileName;
            }
        }

        private void bDialogSelectPathFilePickingList_Click(object sender, EventArgs e)
        {
            DialogResult result = oFDPathFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtPathFilePickingList.Text = oFDPathFile.FileName;
            }
        }

        private void bConvert_Click(object sender, EventArgs e)
        {
            string title = this.Text;
            this.Text = title + " - чтение данных ...";
            Excel.Application exl = new Excel.Application();
            try
            {
                if (File.Exists(txtPathFileStructureWindchill.Text))
                {
                    //Excel.Application exl = new Excel.Application();
                    Excel.Workbook workbookWindchill = exl.Workbooks.Open(txtPathFileStructureWindchill.Text);
                    Excel.Worksheet sheet = (Excel.Worksheet)exl.Worksheets.get_Item(1);
                    int calculated_level, previous_level = 0;
                    Stack<TempObject> StackObjects = new Stack<TempObject>();
                    List<TempObject> Objects = new List<TempObject>();

                    for (int i = 2; i < sheet.Rows.Count; i++)
                    {
                        if (sheet.Cells[i, 1].Value2 == null ) break;
                        calculated_level = 0;
                        string text_cell = (string)sheet.Cells[i, 1].Value2;
                        calculated_level = (text_cell.Length - text_cell.TrimStart(' ').Length) / 4;
                        if (calculated_level == 0)
                        {
                            string design = Convert.ToString(sheet.Cells[i, 2].Value2);
                            string name = Convert.ToString(sheet.Cells[i, 3].Value2);
                            int pos = 0;
                            if (sheet.Cells[i, 4].Value2 != null)
                            {
                                pos = Convert.ToInt32(sheet.Cells[i, 4].Value2);
                            }
                            double kol = 0;
                            if (sheet.Cells[i, 5].Value2 != null)
                            {
                                kol = Convert.ToDouble(sheet.Cells[i, 5].Value2);
                            }

                            double mass = 0;
                            if (sheet.Cells[i, 6].Value2 != null)
                            {
                                string m = (string)sheet.Cells[i, 6].Value2;
                                m = m.Remove(m.Length - 3);
                                mass = double.Parse(m);
                            }

                            string mat1 = Convert.ToString(sheet.Cells[i, 7].Value2);
                            string mat2 = Convert.ToString(sheet.Cells[i, 8].Value2);
                            string note = Convert.ToString(sheet.Cells[i, 9].Value2);

                            Objects.Add(new TempObject(calculated_level, Common.StrToSection(text_cell), design, name, pos, kol, mass,
                            mat1, mat2, note));
                            StackObjects.Push(Objects.LastOrDefault());
                            previous_level = calculated_level;
                            continue;
                        }
                        if (calculated_level > previous_level)
                        {
                            StackObjects.Push(Objects.LastOrDefault());
                            string design = Convert.ToString(sheet.Cells[i, 2].Value2);
                            string name = Convert.ToString(sheet.Cells[i, 3].Value2);
                            int pos = 0;
                            if (sheet.Cells[i, 4].Value2 != null)
                            {
                                pos = Convert.ToInt32(sheet.Cells[i, 4].Value2);
                            }
                            double kol = 0;
                            if (sheet.Cells[i, 5].Value2 != null)
                            {
                                kol = Convert.ToDouble(sheet.Cells[i, 5].Value2);
                            }

                            double mass = 0;
                            if (sheet.Cells[i, 6].Value2 != null)
                            {
                                string m = (string)sheet.Cells[i, 6].Value2;
                                m = m.Remove(m.Length - 3);
                                mass = double.Parse(m);
                            }

                            string mat1 = Convert.ToString(sheet.Cells[i, 7].Value2);
                            string mat2 = Convert.ToString(sheet.Cells[i, 8].Value2);
                            string note = Convert.ToString(sheet.Cells[i, 9].Value2);

                            Objects.Add(new TempObject(calculated_level, Common.StrToSection(text_cell), design, name, pos, kol, mass,
                            mat1, mat2, note, StackObjects.Peek().Design));
                            previous_level = calculated_level;
                            continue;
                        }

                        if (calculated_level == previous_level)
                        {
                            string design = Convert.ToString(sheet.Cells[i, 2].Value2);
                            string name = Convert.ToString(sheet.Cells[i, 3].Value2);
                            int pos = 0;
                            if (sheet.Cells[i, 4].Value2 != null)
                            {
                                pos = Convert.ToInt32(sheet.Cells[i, 4].Value2);
                            }
                            double kol = 0;
                            if (sheet.Cells[i, 5].Value2 != null)
                            {
                                kol = Convert.ToDouble(sheet.Cells[i, 5].Value2);
                            }

                            double mass = 0;
                            if (sheet.Cells[i, 6].Value2 != null)
                            {
                                string m = (string)sheet.Cells[i, 6].Value2;
                                m = m.Remove(m.Length - 3);
                                mass = double.Parse(m);
                            }

                            string mat1 = Convert.ToString(sheet.Cells[i, 7].Value2);
                            string mat2 = Convert.ToString(sheet.Cells[i, 8].Value2);
                            string note = Convert.ToString(sheet.Cells[i, 9].Value2);

                            Objects.Add(new TempObject(calculated_level, Common.StrToSection(text_cell), design, name, pos, kol, mass,
                            mat1, mat2, note, StackObjects.Peek().Design));

                            continue;
                        }

                        if (calculated_level < previous_level)
                        {
                            StackObjects.Pop();
                            string design = Convert.ToString(sheet.Cells[i, 2].Value2);
                            string name = Convert.ToString(sheet.Cells[i, 3].Value2);
                            int pos = 0;
                            if (sheet.Cells[i, 4].Value2 != null)
                            {
                                pos = Convert.ToInt32(sheet.Cells[i, 4].Value2);
                            }
                            double kol = 0;
                            if (sheet.Cells[i, 5].Value2 != null)
                            {
                                kol = Convert.ToDouble(sheet.Cells[i, 5].Value2);
                            }

                            double mass = 0;
                            if (sheet.Cells[i, 6].Value2 != null)
                            {
                                string m = (string)sheet.Cells[i, 6].Value2;
                                m = m.Remove(m.Length - 3);
                                mass = double.Parse(m);
                            }

                            string mat1 = Convert.ToString(sheet.Cells[i, 7].Value2);
                            string mat2 = Convert.ToString(sheet.Cells[i, 8].Value2);
                            string note = Convert.ToString(sheet.Cells[i, 9].Value2);

                            Objects.Add(new TempObject(calculated_level, Common.StrToSection(text_cell), design, name, pos, kol, mass,
                            mat1, mat2, note, StackObjects.Peek().Design));
                            previous_level = calculated_level;

                        }
                        this.Text = title + " - чтение данных (обработанно объектов - " + (i-1).ToString() + "...";
                    }
                    workbookWindchill.Close();

                    this.Text = title + " - запись обработанных данных ...";
                    Excel.Workbook workbookPickingList = exl.Workbooks.Open(txtPathFilePickingList.Text);
                    Excel.Worksheet sheet1 = (Excel.Worksheet)exl.Worksheets.get_Item(1);
                    sheet1.Cells[1, 1] = String.Format("Обозначение");
                    sheet1.Cells[1, 2] = String.Format("Наименование");
                    sheet1.Cells[1, 3] = String.Format("Куда входит");
                    sheet1.Cells[1, 4] = String.Format("Количество");
                    sheet1.Cells[1, 5] = String.Format("Масса, кг");

                    for (int i = 0; i < Objects.Count - 1; i++)
                    {                        
                        sheet1.Cells[i + 2, 1] = Objects[i].Design;
                        sheet1.Cells[i + 2, 2] = Objects[i].Name;
                        sheet1.Cells[i + 2, 3] = Objects[i].ParentDesign;
                        sheet1.Cells[i + 2, 4] = Objects[i].Quantity;
                        sheet1.Cells[i + 2, 5] = Objects[i].Mass;
                        this.Text = title + " - запись обработанных данных (обработанно объектов - " + (i + 1).ToString() + "...";
                    }
                    workbookPickingList.Save();
                    workbookPickingList.Close();
                }

            } catch (Exception ex)
            {
                lblEx.Text = ex.Message;
            } 
            finally
            {
                exl.Quit();
                this.Text = title + " - Выполнено!";
                System.Threading.Thread.Sleep(5000);
                this.Text = title;
            }
            
        }

    }
}
