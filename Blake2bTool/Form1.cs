using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using Isopoh.Cryptography.Blake2b;
using Isopoh.Cryptography.SecureArray;

namespace Blake2bTool;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        rbText.Checked = true;
        ToggleInputSource();
    }

    private void ToggleInputSource()
    {
        bool textMode = rbText.Checked;
        txtInput.Visible = textMode;
        txtFile.Visible = !textMode;
        btnBrowse.Visible = !textMode;
        lblCreation.Visible = !textMode;
        dtCreation.Visible = !textMode;
        lblWrite.Visible = !textMode;
        dtWrite.Visible = !textMode;
        lblAccess.Visible = !textMode;
        dtAccess.Visible = !textMode;
        btnReadTimes.Visible = !textMode;
        btnApplyTimes.Visible = !textMode;
    }

    private void rbText_CheckedChanged(object? sender, EventArgs e)
    {
        ToggleInputSource();
    }

    private void rbFile_CheckedChanged(object? sender, EventArgs e)
    {
        ToggleInputSource();
    }

    private void btnBrowse_Click(object? sender, EventArgs e)
    {
        using var ofd = new OpenFileDialog();
        ofd.Title = "选择文件";
        if (ofd.ShowDialog(this) == DialogResult.OK)
        {
            txtFile.Text = ofd.FileName;
        }
    }

    private void Form1_DragEnter(object? sender, DragEventArgs e)
    {
        if (e.Data != null && e.Data.GetDataPresent(DataFormats.FileDrop))
        {
            e.Effect = DragDropEffects.Copy;
        }
    }

    private void Form1_DragDrop(object? sender, DragEventArgs e)
    {
        if (e.Data != null && e.Data.GetDataPresent(DataFormats.FileDrop))
        {
            var files = e.Data.GetData(DataFormats.FileDrop) as string[];
            if (files != null && files.Length > 0)
            {
                txtFile.Text = files[0];
                rbFile.Checked = true;
            }
        }
    }

    private void btnCompute_Click(object? sender, EventArgs e)
    {
        try
        {
            byte[] data = rbText.Checked
                ? Encoding.UTF8.GetBytes(txtInput.Text ?? string.Empty)
                : ReadAllBytesSafe(txtFile.Text);

            if (data == null || data.Length == 0)
            {
                MessageBox.Show(this, "请输入文本或选择文件", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string algo = cmbAlgo.SelectedItem?.ToString() ?? "BLAKE2b";
            byte[] hash;
            if (string.Equals(algo, "MD5", StringComparison.OrdinalIgnoreCase))
            {
                using var md5 = MD5.Create();
                hash = md5.ComputeHash(data);
            }
            else
            {
                byte[] key = string.IsNullOrEmpty(txtKey.Text) ? Array.Empty<byte>() : Encoding.UTF8.GetBytes(txtKey.Text);
                int digestBytes = (int)numDigest.Value;
                var config = new Blake2BConfig
                {
                    OutputSizeInBytes = digestBytes,
                    Key = key.Length == 0 ? null : key
                };
                hash = Blake2B.ComputeHash(data, config, secureArrayCall: null);
            }

            string output;
            bool hexOut = cmbOutputFmt.SelectedIndex == 0; // 0=Hex, 1=Base64
            if (hexOut)
            {
                var sb = new StringBuilder(hash.Length * 2);
                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString(chkUppercase.Checked ? "X2" : "x2"));
                }
                output = sb.ToString();
            }
            else
            {
                output = Convert.ToBase64String(hash);
            }

            txtOutput.Text = output;
        }
        catch (FileNotFoundException)
        {
            MessageBox.Show(this, "文件不存在，请重新选择", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            MessageBox.Show(this, $"计算失败: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void cmbAlgo_SelectedIndexChanged(object? sender, EventArgs e)
    {
        bool isMd5 = cmbAlgo.SelectedItem?.ToString() == "MD5";
        txtKey.Enabled = !isMd5;
        lblKey.Enabled = !isMd5;
        numDigest.Enabled = !isMd5;
        lblDigest.Enabled = !isMd5;
    }

    private void btnReadTimes_Click(object? sender, EventArgs e)
    {
        var path = txtFile.Text;
        if (string.IsNullOrWhiteSpace(path) || !File.Exists(path))
        {
            MessageBox.Show(this, "请选择有效文件", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        var c = File.GetCreationTime(path);
        var m = File.GetLastWriteTime(path);
        var a = File.GetLastAccessTime(path);
        dtCreation.Value = c;
        dtWrite.Value = m;
        dtAccess.Value = a;
    }

    private void btnApplyTimes_Click(object? sender, EventArgs e)
    {
        var path = txtFile.Text;
        if (string.IsNullOrWhiteSpace(path) || !File.Exists(path))
        {
            MessageBox.Show(this, "请选择有效文件", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        try
        {
            File.SetCreationTime(path, dtCreation.Value);
            File.SetLastWriteTime(path, dtWrite.Value);
            File.SetLastAccessTime(path, dtAccess.Value);
            MessageBox.Show(this, "已应用文件时间", "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show(this, $"设置失败: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private static byte[] ReadAllBytesSafe(string? path)
    {
        if (string.IsNullOrWhiteSpace(path)) return Array.Empty<byte>();
        using var fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
        using var ms = new MemoryStream();
        fs.CopyTo(ms);
        return ms.ToArray();
    }

    private void btnCopy_Click(object? sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(txtOutput.Text))
        {
            Clipboard.SetText(txtOutput.Text);
        }
    }
}
