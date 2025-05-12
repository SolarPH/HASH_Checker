namespace HASH_Checker
{
    internal partial class HashReaderForm : Form
    {
        internal HashReaderForm()
        {
            InitializeComponent();
            cmb_HashType.DataSource = Enum.GetValues(typeof(HashType));
            cmb_HashType.SelectedIndex = 2;

            Text = $"MARCsystems: Hash Code Checker Tool v{AppVersionReader.VersionString}";
        }

        private void addRow(HashObject hashObject)
        {
            dgv_FilePaths.Rows.Add("X", "", hashObject.FileName, hashObject.FilePath, "");
        }
        private void evaluateRow(HashObject hashObject, bool evaluation)
        {
            int row = 0;
            for (row = 0; row < hashObjects.Count; row++)
            {
                if (hashObjects[row] == hashObject)
                {
                    break;
                }
            }
            dgv_FilePaths.Rows[row].Cells[1].Style.BackColor = evaluation ? WeightColor.ComputeWeightColor(hashObject.HashScanVersion, hashCache.Count) : Color.Black;
            dgv_FilePaths.Rows[row].Cells[4].Value = hashObject.HashString;
            dgv_FilePaths.Rows[row].Cells[5].Style.BackColor = evaluation ? WeightColor.ComputeWeightColor(hashObject.HashScanVersion, hashCache.Count) : Color.Black;
        }

        private List<HashObject> hashObjects = new List<HashObject>();
        private void btn_AddFiles_Click(object sender, EventArgs e)
        {
            if (ofd_FileSelect.ShowDialog() == DialogResult.OK)
            {
                foreach (string filepath in ofd_FileSelect.FileNames)
                {
                    if (!HashObject.hasMatchingRecord(hashObjects, filepath))
                    {
                        hashObjects.Add(new HashObject(filepath));
                    }
                }
            }
            dgv_FilePaths.Rows.Clear();
            foreach (HashObject hashObject in hashObjects)
            {
                addRow(hashObject);
                evaluateRow(hashObject, false);
            }
        }

        private void btn_Inspect_Click(object sender, EventArgs e)
        {
            enableInteractables(false);
            if (!bgw_Processing.IsBusy)
            {
                bgw_Processing.RunWorkerAsync();
            }
        }

        private void enableInteractables(bool toggle)
        {
            cmb_HashType.Enabled = toggle;
            btn_AddFiles.Enabled = toggle;
            btn_Inspect.Enabled = toggle;
            dgv_FilePaths.Enabled = toggle;
        }

        private List<string> hashCache = new List<string>();
        private void bgw_Processing_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            hashCache.Clear();
            try
            {
                foreach (HashObject ho in hashObjects)
                {
                    int selectedIndex = 0;
                    Invoke((MethodInvoker)delegate ()
                    {
                        selectedIndex = cmb_HashType.SelectedIndex;
                    });
                    ho.HashString = HashReader.ReadHashFromFile(ho.FilePath, (HashType)selectedIndex);

                    if (!hashCache.Contains(ho.HashString))
                    {
                        hashCache.Add(ho.HashString);
                    }
                }

                foreach (HashObject ho in hashObjects)
                {
                    int hashIndex = hashCache.IndexOf(ho.HashString);
                    ho.HashScanVersion = hashIndex;
                }

                Invoke((MethodInvoker)delegate ()
                {
                    foreach (HashObject ho in hashObjects)
                    {
                        evaluateRow(ho, true);
                    }
                    enableInteractables(true);
                });
            }
            catch (Exception err)
            {
                MessageBox.Show($"Something went wrong!\r\n\r\n{err.Message}\r\n\r\n{err.StackTrace}");
            }
        }

        private void dgv_FilePaths_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_FilePaths.CurrentCell.ColumnIndex == 0)
            {
                if (MessageBox.Show("Delete this entry?", $"Remove \"{dgv_FilePaths.Rows[dgv_FilePaths.CurrentCell.RowIndex].Cells[2].Value}\"?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    for (int i = 0; i < hashObjects.Count; i++)
                    {
                        if (hashObjects[i].FilePath == dgv_FilePaths.Rows[dgv_FilePaths.CurrentCell.RowIndex].Cells[3].Value)
                        {
                            hashObjects.RemoveAt(i);
                            dgv_FilePaths.Rows.RemoveAt(dgv_FilePaths.CurrentCell.RowIndex);
                            break;
                        }
                    }
                }
                dgv_FilePaths.ClearSelection();
            }
        }
    }
}