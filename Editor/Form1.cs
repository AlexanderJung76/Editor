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
namespace Editor
{
    public partial class FW_Editor : Form
    {
        private string path = @"c:\test\editor.txt";
        private bool isSaved = true;

        public FW_Editor()
        {
            InitializeComponent();
        }

        private void MI_Beenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MI_Neu_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Achtung alle daten werden gelöscht!", "Warnung!!!",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
            {
                RTB_Editor.Clear();
            }            
        }

        private void MI_Öffnen_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void MI_Speichern_Click(object sender, EventArgs e)
        {
            Save();
            isSaved = true;
        }

        private void MI_Speichern_Unter_Click(object sender, EventArgs e)
        {

        }

        private void MI_Ausschneiden_Click(object sender, EventArgs e)
        {

        }

        private void MI_Kopieren_Click(object sender, EventArgs e)
        {

        }

        private void MI_Einfügen_Click(object sender, EventArgs e)
        {

        }

        private void MI_Info_Click(object sender, EventArgs e)
        {

        }

        private void TSB_Neu_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Achtung alle daten werden gelöscht!", "Warnung!!!",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
            {
                RTB_Editor.Clear();
            }
        }

        private void TSB_Speichern_Click(object sender, EventArgs e)
        {
            Save();
            isSaved = true;
        }

        private void TSB_Öffnen_Click(object sender, EventArgs e)
        {

        }

        private void Save()
        {
            try
            {
                File.WriteAllLines(path, RTB_Editor.Lines);

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Open()
        {
            if (!isSaved)
            {
                if (DialogResult.OK != MessageBox.Show("Achtung alle daten werden gelöscht!", "Warnung!!!",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
                {
                    return;
                }
            }
            
            try
            {
                RTB_Editor.Lines = File.ReadAllLines(path);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        private void RTB_Editor_TextChanged(object sender, EventArgs e)
        {
            isSaved = false;
        }
    }
}
