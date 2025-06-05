using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mosiac.UX.UIActions
{
    public  class UIactions
    {
        private static bool isDirty;

        public static bool IsDirty
        {
            get { return isDirty; }
            set {isDirty = value; }
        }
        public static void CheckForDirtyState(ListChangedEventArgs e, ToolStripButton saveButton)
        {
            if (e.ListChangedType == ListChangedType.ItemChanged)
            {
                saveButton.Enabled = true;
                isDirty = true;
                ToogleButtonStyle(isDirty, saveButton);
            }
            if (e.ListChangedType == ListChangedType.ItemDeleted)
            {
                saveButton.Enabled = true;
                isDirty = true;
                ToogleButtonStyle(isDirty, saveButton);
            }
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
                saveButton.Enabled = true;
                isDirty = true;
                ToogleButtonStyle(isDirty, saveButton);
            }
        }

        public static void ToogleButtonStyle(bool dirtyState, ToolStripButton saveButton)
        {
            if (dirtyState == true)
            {
                saveButton.BackColor = Color.MediumSlateBlue;
                
               // saveButton.FlatStyle = FlatStyle.Flat;
               // saveButton.FlatAppearance.BorderColor = Color.Red;
               // saveButton.FlatAppearance.BorderSize = 3;
            }

            else if (dirtyState == false)
            {
                saveButton.BackColor = Color.Gainsboro;
               // saveButton.FlatAppearance.BorderColor = Color.Cornsilk;
            }
        }

        public static void BuildProductGrid(DataGridView dg)
        {
            dg.AutoGenerateColumns = false;
            dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dg.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Currency Decimal Style
            DataGridViewCellStyle dstyleCurrency = new DataGridViewCellStyle();
            dstyleCurrency.Format = "C";
            dstyleCurrency.NullValue = "";
            dstyleCurrency.Alignment = DataGridViewContentAlignment.MiddleRight;
            // Currency Decimal Style
            DataGridViewCellStyle dstyleDecimal = new DataGridViewCellStyle();
            dstyleDecimal.Format = "N2";
            dstyleDecimal.NullValue = "0.00";
            dstyleDecimal.Alignment = DataGridViewContentAlignment.MiddleRight;
            // Wrapping Text Style
            DataGridViewCellStyle dstyleWrapText = new DataGridViewCellStyle();
            dstyleWrapText.NullValue = "";
            dstyleWrapText.Alignment = DataGridViewContentAlignment.TopLeft;
            dstyleWrapText.WrapMode = DataGridViewTriState.True;

            // ID Column --
            DataGridViewTextBoxColumn colID = new DataGridViewTextBoxColumn();
            colID.HeaderText = "ProductID";
            colID.DataPropertyName = "ProductID";
            colID.Width = 75;

            // Arch Description --
            DataGridViewTextBoxColumn colArchDescription = new DataGridViewTextBoxColumn();
            colArchDescription.HeaderText = "Contract Name";
            colArchDescription.DataPropertyName = "ArchDescription";
            colArchDescription.Width = 450;

            // UnitID --
            DataGridViewTextBoxColumn colUnitID = new DataGridViewTextBoxColumn();
            colUnitID.DefaultCellStyle = dstyleWrapText;
            colUnitID.HeaderText = "UnitID";
            colUnitID.DataPropertyName = "UnitID";
            colUnitID.Width = 100;

            // UnitName ----------
            DataGridViewTextBoxColumn colUnitName = new DataGridViewTextBoxColumn();
            colUnitName.Width = 400;
            colUnitName.HeaderText = "Unit Name";
            colUnitName.DataPropertyName = "UnitName";
            colUnitName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // W ----------
            DataGridViewTextBoxColumn colW = new DataGridViewTextBoxColumn();
            colW.Width = 140;
            colW.HeaderText = "W";
            colW.DataPropertyName = "W";
            colW.DefaultCellStyle = dstyleDecimal;
            // D ----------
            DataGridViewTextBoxColumn colD = new DataGridViewTextBoxColumn();
            colD.Width = 140;
            colD.HeaderText = "D";
            colD.DataPropertyName = "D";
            colD.DefaultCellStyle = dstyleDecimal;
            // H ----------
            DataGridViewTextBoxColumn colH = new DataGridViewTextBoxColumn();
            colH.Width = 140;
            colH.HeaderText = "H";
            colH.DataPropertyName = "H";
            colH.DefaultCellStyle = dstyleDecimal;

            // Make ----------
            DataGridViewCheckBoxColumn colMake = new DataGridViewCheckBoxColumn();
            colMake.Width = 45;
            colMake.HeaderText = "Make";
            colMake.DataPropertyName = "Make";

            // NIC ----------
            DataGridViewCheckBoxColumn colNIC = new DataGridViewCheckBoxColumn();
            colNIC.Width = 45;
            colNIC.HeaderText = "NIC";
            colNIC.DataPropertyName = "NIC";

            //colUnit.DataSource = _partService.Units();
            dg.Columns.AddRange(colID, colArchDescription, colUnitID, colUnitName, colW, colD, colH, colMake, colNIC);
        }

        public static void BuildSubAssemblyGrid(DataGridView dg)
        {
            dg.AutoGenerateColumns = false;
            dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dg.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Currency Decimal Style
            DataGridViewCellStyle dstyleCurrency = new DataGridViewCellStyle();
            dstyleCurrency.Format = "C";
            dstyleCurrency.NullValue = "";
            dstyleCurrency.Alignment = DataGridViewContentAlignment.MiddleRight;
            // Currency Decimal Style
            DataGridViewCellStyle dstyleDecimal = new DataGridViewCellStyle();
            dstyleDecimal.Format = "N2";
            dstyleDecimal.NullValue = "0.00";
            dstyleDecimal.Alignment = DataGridViewContentAlignment.MiddleRight;
            // Wrapping Text Style
            DataGridViewCellStyle dstyleWrapText = new DataGridViewCellStyle();
            dstyleWrapText.NullValue = "";
            dstyleWrapText.Alignment = DataGridViewContentAlignment.TopLeft;
            dstyleWrapText.WrapMode = DataGridViewTriState.True;

            // SubAssemblyID Column --
            DataGridViewTextBoxColumn colSubassemblyID = new DataGridViewTextBoxColumn();
            colSubassemblyID.HeaderText = "SubID";
            colSubassemblyID.DataPropertyName = "SubAssemblyID";
            colSubassemblyID.Width = 70;

            // Assembly Name --
            DataGridViewTextBoxColumn colSubAssemblyName = new DataGridViewTextBoxColumn();
            colSubAssemblyName.HeaderText = "Subassembly Name";
            colSubAssemblyName.DataPropertyName = "SubAssemblyName";
            colSubAssemblyName.Width = 550;


            // MakeFile ----------
            DataGridViewTextBoxColumn colMakeFile = new DataGridViewTextBoxColumn();
            colMakeFile.Width = 400;
            colMakeFile.HeaderText = "MakeFile";
            colMakeFile.DataPropertyName = "MakeFile";
            colMakeFile.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // W ----------
            DataGridViewTextBoxColumn colW = new DataGridViewTextBoxColumn();
            colW.Width = 110;
            colW.HeaderText = "W";
            colW.DataPropertyName = "W";
            colW.DefaultCellStyle = dstyleDecimal;
            // H ----------
            DataGridViewTextBoxColumn colH = new DataGridViewTextBoxColumn();
            colH.Width = 110;
            colH.HeaderText = "H";
            colH.DataPropertyName = "H";
            colH.DefaultCellStyle = dstyleDecimal;
            // D ----------
            DataGridViewTextBoxColumn colD = new DataGridViewTextBoxColumn();
            colD.Width = 110;
            colD.HeaderText = "D";
            colD.DataPropertyName = "D";
            colD.DefaultCellStyle = dstyleDecimal;

            //CPD_ID Column --
            DataGridViewTextBoxColumn colCPD_ID = new DataGridViewTextBoxColumn();
            colCPD_ID.HeaderText = "CPD-ID";
            colCPD_ID.DataPropertyName = "CPD_id";
            colCPD_ID.Width = 70;

            //GlassPartID Column --
            DataGridViewTextBoxColumn colGlassPartID = new DataGridViewTextBoxColumn();
            colGlassPartID.HeaderText = "GlassID";
            colGlassPartID.DataPropertyName = "GlassPartID";
            colGlassPartID.Width = 70;

            //OpCode Column --
            DataGridViewTextBoxColumn colOpCode = new DataGridViewTextBoxColumn();
            colOpCode.HeaderText = "Op Code";
            colOpCode.DataPropertyName = "OpCode";
            colOpCode.Width = 70;

            //OpCode Column --
            DataGridViewButtonColumn colMakeFileFind = new DataGridViewButtonColumn();
            colMakeFileFind.HeaderText = "?";
            colMakeFileFind.DataPropertyName = "OpCode";
            colMakeFileFind.Width = 30;



            //colUnit.DataSource = _partService.Units();
            dg.Columns.AddRange(colSubassemblyID, colSubAssemblyName, colMakeFile, colMakeFileFind, colW, colH, colD, colCPD_ID, colGlassPartID, colOpCode);
        }

        public static void BuildRecipeGrid(DataGridView dg)
        {
            dg.AutoGenerateColumns = false;
            dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dg.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Currency Decimal Style
            DataGridViewCellStyle dstyleCurrency = new DataGridViewCellStyle();
            dstyleCurrency.Format = "C";
            dstyleCurrency.NullValue = "";
            dstyleCurrency.Alignment = DataGridViewContentAlignment.MiddleRight;
            // Currency Decimal Style
            DataGridViewCellStyle dstyleDecimal = new DataGridViewCellStyle();
            dstyleDecimal.Format = "N2";
            dstyleDecimal.NullValue = "0.00";
            dstyleDecimal.Alignment = DataGridViewContentAlignment.MiddleRight;
            // Wrapping Text Style
            DataGridViewCellStyle dstyleWrapText = new DataGridViewCellStyle();
            dstyleWrapText.NullValue = "";
            dstyleWrapText.Alignment = DataGridViewContentAlignment.TopLeft;
            dstyleWrapText.WrapMode = DataGridViewTriState.True;

            // ID Column --
            DataGridViewTextBoxColumn colID = new DataGridViewTextBoxColumn();
            colID.HeaderText = "id";
            colID.DataPropertyName = "id";
            colID.Width = 75;

            // UnitID --
            DataGridViewTextBoxColumn colSourceName = new DataGridViewTextBoxColumn();
            colSourceName.DefaultCellStyle = dstyleWrapText;
            colSourceName.HeaderText = "amount";
            colSourceName.DataPropertyName = "amount";
            colSourceName.Width = 100;

            // UnitName ----------
            DataGridViewTextBoxColumn colLength = new DataGridViewTextBoxColumn();
            colLength.Width = 400;
            colLength.HeaderText = "length";
            colLength.DataPropertyName = "length";
            colLength.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // UnitName ----------
            DataGridViewTextBoxColumn colUnit = new DataGridViewTextBoxColumn();
            colUnit.Width = 400;
            colUnit.HeaderText = "unit";
            colUnit.DataPropertyName = "unit";
            colUnit.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //colUnit.DataSource = _partService.Units();
            dg.Columns.AddRange(colID, colSourceName, colLength, colUnit);
        }

        public static void BuildJobOrderListView(ListView lv)
        {
            lv.View = View.Details;
            lv.FullRowSelect = true;
            lv.MultiSelect = false;

            lv.Columns.Add("PO", 45, HorizontalAlignment.Center);
            lv.Columns.Add("Date", 70, HorizontalAlignment.Center);
            lv.Columns.Add("Supplier", 180, HorizontalAlignment.Left);
            

        }

       

    }
}
