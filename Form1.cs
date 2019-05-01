using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace WSB_Editor
{
    public partial class frmMain : Form
    {

        XmlDocument doc = new XmlDocument();


        public frmMain()
        {
            InitializeComponent();
        }

        private void btnRemoveSharedFolder_Click(object sender, EventArgs e)
        {
            if (lstFolders.Items.Count > 0)
            {
                foreach (ListViewItem i in lstFolders.SelectedItems)
                {
                    lstFolders.Items.Remove(i);
                }
            }
        }

        private void btnAddSharedFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fldDialog = new FolderBrowserDialog();

            if (fldDialog.ShowDialog() == DialogResult.OK)
            {
                ListViewItem item = new ListViewItem(fldDialog.SelectedPath);
                // Readonly?
                DialogResult result = MessageBox.Show("Do you want to connect the folder read only?", "Read only?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    item.SubItems.Add("true");
                }
                else
                {
                    item.SubItems.Add("false");
                }

                lstFolders.Items.Add(item);
            }
           
        }

        /// <summary>
        /// reset all controls
        /// </summary>
        private void ClearAllControls()
        {
            chkGPUSharing.Checked = false;
            chkNetwork.Checked = false;
            if (lstFolders.Items.Count > 0)
            {
                foreach (ListViewItem i in lstFolders.Items)
                {
                    lstFolders.Items.Remove(i);
                }
            }
            txtCommand.Text = "";
            if (lstCommand.Items.Count > 0)
            {
                foreach (ListViewItem i in lstCommand.Items)
                {
                    lstCommand.Items.Remove(i);
                }
            }
        }

        private void btnLoadWSB_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "wsb files (*.wsb)|*.wsb|all files (*.*)|*.*";
            
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                bool Result = ReadFromWSB(openFile.FileName);
                if (Result)
                {
                    stslblStatus.Text = "File loaded";
                }
                else
                {
                    stslblStatus.Text = "Error on loading wsb file";
                    ClearAllControls();
                }
            }
        }

        /// <summary>
        /// Serialize all settings from the window into an xml
        /// </summary>
        /// <param name="FileName">Full name (incl.) path of the target file</param>
        /// <returns></returns>
        private bool WriteToWSB(string FileName)
        {
            try
            {
                // Creating a object with the settings
                Configuration config = new Configuration();

                if (chkGPUSharing.Checked)
                {
                    config.VGpu = "Enabled";
                }
                else
                {
                    config.VGpu = "Disabled";
                }

                if (chkNetwork.Checked)
                {
                    config.Networking = "Enabled";
                }
                else
                {
                    config.Networking = "Disabled";
                }

                if (lstFolders.Items.Count >= 1)
                {
                    config.mappedFolders = new MappedFolders();
                    config.mappedFolders.mappedFolder = new List<MappedFolder>();
                    foreach (ListViewItem item in lstFolders.Items)
                    {
                        MappedFolder folder = new MappedFolder();
                        folder.HostFolder = item.Text;
                        folder.ReadOnly = item.SubItems[1].Text;
                        config.mappedFolders.mappedFolder.Add(folder);
                    }
                }

                if (lstCommand.Items.Count >= 1)
                {
                    config.logonCommand = new LogonCommand();
                    config.logonCommand.Command = new List<string>();
                    foreach (ListViewItem item in lstCommand.Items)
                    {
                        config.logonCommand.Command.Add(item.Text);
                    }
                }

                XmlSerializerNamespaces ns = new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty });
                XmlWriterSettings setting = new XmlWriterSettings();
                setting.Indent = true;
                setting.OmitXmlDeclaration = true;
                XmlSerializer xml = new XmlSerializer(typeof(Configuration));
                //using (TextWriter writer = new StreamWriter(FileName)));
                using (XmlWriter xmlwriter = XmlWriter.Create(FileName, setting))
                {
                    xml.Serialize(xmlwriter, config, ns);
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on writeing to wsb file.");
                return false;
            }
        }

        /// <summary>
        /// Deserialize all settings from the xml and set the gui to correspond with the xml
        /// </summary>
        /// <param name="FileName">Full name (incl. path) of the source file</param>
        /// <returns></returns>
        private bool ReadFromWSB(string FileName)
        {

            try
            {
                // Deserialize the xml
                XmlSerializer xml = new XmlSerializer(typeof(Configuration));
                TextReader reader = new StreamReader(FileName);
                object obj = xml.Deserialize(reader);
                Configuration config = (Configuration)obj;
                reader.Close();

                // Reflect the xml setting with the UI
                switch (config.VGpu)
                {
                    case "Enabled":
                        chkGPUSharing.Checked = true;
                        break;
                    case "Disabled":
                        chkGPUSharing.Checked = false;
                        break;
                    default:
                        chkGPUSharing.Checked = false;
                        break;
                }

                switch (config.Networking)
                {
                    case "Enabled":
                        chkNetwork.Checked = true;
                        break;
                    case "Disabled":
                        chkNetwork.Checked = false;
                        break;
                    default:
                        chkNetwork.Checked = false;
                        break;
                }

                if (config.mappedFolders != null)
                {
                    if (config.mappedFolders.mappedFolder.Count >= 1)
                    {
                        foreach (MappedFolder folder in config.mappedFolders.mappedFolder)
                        {
                            ListViewItem item = new ListViewItem(folder.HostFolder);
                            item.SubItems.Add(folder.ReadOnly);
                            lstFolders.Items.Add(item);
                        }
                    }
                }
                
                
                if (config.logonCommand != null)
                {
                    if (config.logonCommand.Command.Count >= 1)
                    {
                        foreach (string command in config.logonCommand.Command)
                        {
                            ListViewItem item = new ListViewItem(command);
                            lstCommand.Items.Add(item);
                        }
                    }
                }
                
                
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on open wsb file");
            }
            return false;
        }

        private void txtCommand_TextChanged(object sender, EventArgs e)
        {
            if (txtCommand.Text.Length > 0)
                btnAddCommand.Enabled = true;
        }

        private void btnAddCommand_Click(object sender, EventArgs e)
        {
            lstCommand.Items.Add(new ListViewItem(txtCommand.Text));
            txtCommand.Text = "";
        }

        private void btnRemoveCommand_Click(object sender, EventArgs e)
        {
            if (lstCommand.Items.Count > 0)
            {
                foreach (ListViewItem i in lstCommand.SelectedItems)
                {
                    lstCommand.Items.Remove(i);
                }
            }
        }

        private void btnSaveWSB_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "wsb files (*.wsb)|*.wsb|all files (*.*)|*.*";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                if(WriteToWSB(saveFile.FileName))
                {
                    stslblStatus.Text = "File saved";
                    ClearAllControls();
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
