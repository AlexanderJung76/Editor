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
        private string path = "";        //temp path for Save and OpenFileDialog
        private bool isSaved = true;        //bool for overwrite warning dialogs
        private bool firstSave = true;      // bool for save method


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
                RTB_Editor.Clear();     //RTB_Editor = Rich Text Box Edit Window <.> clear - method for RTB
                firstSave = true;
            }            
        }

        private void MI_Öffnen_Click(object sender, EventArgs e)
        {
            Open();     //selfwritten method
            firstSave = false;
        }

        private void MI_Speichern_Click(object sender, EventArgs e)
        {
            if (!firstSave)
            {
                try
                {
                    File.WriteAllLines(path, RTB_Editor.Lines);                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                isSaved = true;
                firstSave = false;
            }
            else Save();
        }

        private void MI_Speichern_Unter_Click(object sender, EventArgs e)
        {
            Save();     //selfwritten method            
        }

        private void MI_Ausschneiden_Click(object sender, EventArgs e)
        {
            RTB_Editor.Cut();       //RTB_Editor = Rich Text Box Edit Window <.> clear - method for RTB
        }

        private void MI_Kopieren_Click(object sender, EventArgs e)
        {
            RTB_Editor.Copy();      //RTB_Editor = Rich Text Box Edit Window <.> copy - method for RTB
        }

        private void MI_Einfügen_Click(object sender, EventArgs e)
        {
            RTB_Editor.Paste();     //RTB_Editor = Rich Text Box Edit Window <.> paste - method for RTB
        }

        private void MI_Info_Click(object sender, EventArgs e)
        {
            Form_Info Frm_Info = new Form_Info();
            Frm_Info.Show();        // open an second info window (Form_Info.cs)
        }

        private void TSB_Neu_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Achtung alle daten werden gelöscht!", "Warnung!!!",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))        // if dialog box return valuve is ok
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
            Open();
        }

        private void Save()
        {
            try
            {
                SaveFileDialog FD_Save = new SaveFileDialog();
                FD_Save.Filter = "txt files (*.txt)|*.txt|AllowDrop files (*.*)|*.*";
                FD_Save.InitialDirectory = @"C:\test\";

                if (DialogResult.OK ==FD_Save.ShowDialog())
                {
                    path = FD_Save.FileName;
                    File.WriteAllLines(path, RTB_Editor.Lines);
                    firstSave = false;
                }                
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
                OpenFileDialog FD_Open = new OpenFileDialog();
                FD_Open.Filter = "txt files (*.txt)|*.txt|AllowDrop files (*.*)|*.*";
                FD_Open.InitialDirectory = @"c:\test\";

                if (DialogResult.OK == FD_Open.ShowDialog())
                {
                    path = FD_Open.FileName;
                    RTB_Editor.Lines = File.ReadAllLines(path);
                }                
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
