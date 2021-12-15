using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace NoteSaver
{
	public partial class Form1 : Form
	{
		private bool _isDoubleClick = false;
		private int _textSelection = 0;
		private int _rowNumber = 0;
		private int _previousLineIndex = 0;
		private readonly char _charCodeF = '\u0006';

		public Form1()
		{
			InitializeComponent();
			LoadText();
		}

		private void LoadText()
		{
			if (richTextBox1 != null && richTextBox1.Text.Length > 0)
			{
				richTextBox1.Text = "";
			}

			if (treeView1 != null && treeView1.Nodes.Count > 0)
			{
				treeView1.Nodes.Clear();
			}

			try
			{
				richTextBox1.LoadFile(Path.GetPath(), RichTextBoxStreamType.RichText);
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}

			_rowNumber = 0;
			var level = 1;

			var lines = richTextBox1.Lines
				.Select((x, index) => new Line 
				{ 
					Index = index, 
					Text = x 
				})
				.ToList();

			richTextBox2.Lines = lines.Select(x => (x.Index + 1).ToString()).ToArray();

			treeView1.Nodes.AddRange(MakeTreeNode(lines, level, lines.Count() - 1));

			treeView1.ExpandAll();

			if (_textSelection != 0 || _textSelection != -1)
			{
				richTextBox1.Select(_textSelection, 0);
				richTextBox1.ScrollToCaret();
			}
		}

		private TreeNode[] MakeTreeNode(IEnumerable<Line> lines, int level, int sectionEnd)
		{
			ICollection<TreeNode> listTreeNode = new List<TreeNode>();

			var listLines = lines
				.Where(x => x.Text.StartsWith($"##{level}") && x.Index >= _rowNumber && x.Index < sectionEnd)
				.ToList();

			for (int i = 0; i < listLines.Count(); i++)
			{
				var LevelLines = lines
					.Where(x => x.Text.StartsWith($"##{level}") && x.Index >= _rowNumber && x.Index < sectionEnd)
					.Take(2)
					.ToList();

				var firstRow = LevelLines.FirstOrDefault();
				var lastRow = LevelLines.Count() > 1 ? LevelLines.LastOrDefault() : null;
				var treeNodes = MakeTreeNode(lines, level + 1, lastRow != null ? lastRow.Index : sectionEnd);

				if (treeNodes.Length != 0)
				{
					listTreeNode.Add(new TreeNode(firstRow.Text.Replace($"##{level}", ""), treeNodes));
				}
				else
				{
					listTreeNode.Add(new TreeNode(firstRow.Text.Replace($"##{level}", "")));
				}

				_rowNumber = lastRow != null ? lastRow.Index : listLines[i].Index;
			}

			return listTreeNode.ToArray();
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			richTextBox1.SaveFile(Path.GetPath(), RichTextBoxStreamType.RichText);
			LoadText();
		}

		private void treeView1_DoubleClick(object sender, EventArgs e)
		{
			int selectionIndex = richTextBox1.Find(treeView1.SelectedNode.Text.Replace("\r\n", ""));

			if (treeView1.SelectedNode != null && selectionIndex != -1)
			{
				_textSelection = selectionIndex;
				richTextBox1.Select(selectionIndex, 0);
				richTextBox1.ScrollToCaret();
			}

			_isDoubleClick = false;
		}

		private void treeView1_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
		{
			if (_isDoubleClick && e.Action == TreeViewAction.Collapse)
				e.Cancel = true;
		}

		private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
		{
			if (_isDoubleClick && e.Action == TreeViewAction.Expand)
				e.Cancel = true;
		}

		private void treeView1_MouseDown(object sender, MouseEventArgs e)
		{
			_isDoubleClick = e.Clicks > 1;
		}

		private void textBox1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				var text = textBox1.Text;

				if (!string.IsNullOrWhiteSpace(text))
				{
					ExecuteSearch(text);
				}
				else
				{
					richTextBox1.SelectAll();
					richTextBox1.SelectionBackColor = SystemColors.Window;
					textBox1.Text = string.Empty;
				}
			}
		}

		private void richTextBox1_VScroll(object sender, EventArgs e)
		{
			int firstVisibleChar = richTextBox1.GetCharIndexFromPosition(new Point(0, 0));
			int lineIndex = richTextBox1.GetLineFromCharIndex(firstVisibleChar);

			if (_previousLineIndex != lineIndex)
			{
				_previousLineIndex = lineIndex;
				richTextBox2.SelectionStart = richTextBox2.GetFirstCharIndexFromLine(lineIndex);
				richTextBox2.ScrollToCaret();
			}
		}

		private void richTextBox1_ContentsResized(object sender, ContentsResizedEventArgs e)
		{
			richTextBox2.ZoomFactor = richTextBox1.ZoomFactor;
		}

		private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			var selectedText = richTextBox1.SelectedText;
			var textLength = selectedText?.Length ?? 0;

			if (((ModifierKeys & Keys.Control) == Keys.Control) && e.KeyChar == _charCodeF && !string.IsNullOrWhiteSpace(selectedText) && textLength > 0 && textLength < 100)
			{
				textBox1.Text = selectedText;
				ExecuteSearch(selectedText);
			}
		}

		private void ExecuteSearch(string phrase)
		{
			var textLength = phrase?.Length ?? 0;
			var selectedTextPosition = richTextBox1.SelectionStart;

			richTextBox1.SelectAll();
			richTextBox1.SelectionBackColor = SystemColors.Window;

			for (int i = 0; i < richTextBox1.Text.Length - textLength; i++)
			{
				var text = richTextBox1.Text.Substring(i, textLength);

				if (text == phrase)
				{
					richTextBox1.Select(i, textLength);
					richTextBox1.SelectionBackColor = Color.Orange;
				}
			}

			richTextBox1.Select(selectedTextPosition, textLength);
		}

		private void buttonClearSearch_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectAll();
			richTextBox1.SelectionBackColor = SystemColors.Window;
			textBox1.Text = string.Empty;
		}
	}

	public static class Path
	{
		public static string GetPath()
		{
			var path = AppDomain.CurrentDomain.BaseDirectory.Replace("bin\\Debug\\", "App_Data\\") + "notes.rtf";

			if (File.Exists(path))
			{
				return path;
			}
			else
			{
				File.Create(path);
			}

			return path;
		}
	}

	public class Line
	{
		public int Index { get; set; }
		public string Text { get; set; }
	}
}
