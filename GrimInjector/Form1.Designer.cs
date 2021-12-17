namespace GrimInjector
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.closebutton = new Guna.UI2.WinForms.Guna2Button();
            this.scriptarea = new FastColoredTextBoxNS.FastColoredTextBox();
            this.injectbutton = new Guna.UI2.WinForms.Guna2Button();
            this.erasebutton = new Guna.UI2.WinForms.Guna2Button();
            this.savebutton = new Guna.UI2.WinForms.Guna2Button();
            this.openbutton = new Guna.UI2.WinForms.Guna2Button();
            this.executebutton = new Guna.UI2.WinForms.Guna2Button();
            this.labelname = new System.Windows.Forms.Label();
            this.jDragControl1 = new JDragControl.JDragControl(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scriptarea)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.labelname);
            this.panel1.Controls.Add(this.closebutton);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // closebutton
            // 
            resources.ApplyResources(this.closebutton, "closebutton");
            this.closebutton.CheckedState.Parent = this.closebutton;
            this.closebutton.CustomImages.Parent = this.closebutton;
            this.closebutton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.closebutton.ForeColor = System.Drawing.Color.White;
            this.closebutton.HoverState.Parent = this.closebutton;
            this.closebutton.Name = "closebutton";
            this.closebutton.ShadowDecoration.Parent = this.closebutton;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // scriptarea
            // 
            this.scriptarea.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.scriptarea.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*" +
    "(?<range>:)\\s*(?<range>[^;]+);";
            resources.ApplyResources(this.scriptarea, "scriptarea");
            this.scriptarea.BackBrush = null;
            this.scriptarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.scriptarea.CharHeight = 14;
            this.scriptarea.CharWidth = 8;
            this.scriptarea.CommentPrefix = "--";
            this.scriptarea.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.scriptarea.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.scriptarea.ForeColor = System.Drawing.Color.White;
            this.scriptarea.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.scriptarea.IsReplaceMode = false;
            this.scriptarea.Language = FastColoredTextBoxNS.Language.Lua;
            this.scriptarea.LineNumberColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.scriptarea.Name = "scriptarea";
            this.scriptarea.Paddings = new System.Windows.Forms.Padding(0);
            this.scriptarea.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.scriptarea.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("scriptarea.ServiceColors")));
            this.scriptarea.ServiceLinesColor = System.Drawing.Color.Transparent;
            this.scriptarea.Zoom = 100;
            // 
            // injectbutton
            // 
            this.injectbutton.Animated = true;
            this.injectbutton.AutoRoundedCorners = true;
            this.injectbutton.BorderRadius = 14;
            this.injectbutton.CheckedState.Parent = this.injectbutton;
            this.injectbutton.CustomImages.Parent = this.injectbutton;
            this.injectbutton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            resources.ApplyResources(this.injectbutton, "injectbutton");
            this.injectbutton.ForeColor = System.Drawing.Color.White;
            this.injectbutton.HoverState.Parent = this.injectbutton;
            this.injectbutton.Name = "injectbutton";
            this.injectbutton.ShadowDecoration.Parent = this.injectbutton;
            this.injectbutton.Click += new System.EventHandler(this.injectbutton_Click);
            // 
            // erasebutton
            // 
            this.erasebutton.Animated = true;
            this.erasebutton.AutoRoundedCorners = true;
            this.erasebutton.BorderRadius = 14;
            this.erasebutton.CheckedState.Parent = this.erasebutton;
            this.erasebutton.CustomImages.Parent = this.erasebutton;
            this.erasebutton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            resources.ApplyResources(this.erasebutton, "erasebutton");
            this.erasebutton.ForeColor = System.Drawing.Color.White;
            this.erasebutton.HoverState.Parent = this.erasebutton;
            this.erasebutton.Name = "erasebutton";
            this.erasebutton.ShadowDecoration.Parent = this.erasebutton;
            this.erasebutton.Click += new System.EventHandler(this.erasebutton_Click);
            // 
            // savebutton
            // 
            this.savebutton.Animated = true;
            this.savebutton.AutoRoundedCorners = true;
            this.savebutton.BorderRadius = 14;
            this.savebutton.CheckedState.Parent = this.savebutton;
            this.savebutton.CustomImages.Parent = this.savebutton;
            this.savebutton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            resources.ApplyResources(this.savebutton, "savebutton");
            this.savebutton.ForeColor = System.Drawing.Color.White;
            this.savebutton.HoverState.Parent = this.savebutton;
            this.savebutton.Name = "savebutton";
            this.savebutton.ShadowDecoration.Parent = this.savebutton;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // openbutton
            // 
            this.openbutton.Animated = true;
            this.openbutton.AutoRoundedCorners = true;
            this.openbutton.BorderRadius = 14;
            this.openbutton.CheckedState.Parent = this.openbutton;
            this.openbutton.CustomImages.Parent = this.openbutton;
            this.openbutton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            resources.ApplyResources(this.openbutton, "openbutton");
            this.openbutton.ForeColor = System.Drawing.Color.White;
            this.openbutton.HoverState.Parent = this.openbutton;
            this.openbutton.Name = "openbutton";
            this.openbutton.ShadowDecoration.Parent = this.openbutton;
            this.openbutton.Click += new System.EventHandler(this.openbutton_Click);
            // 
            // executebutton
            // 
            this.executebutton.Animated = true;
            this.executebutton.AutoRoundedCorners = true;
            this.executebutton.BorderRadius = 14;
            this.executebutton.CheckedState.Parent = this.executebutton;
            this.executebutton.CustomImages.Parent = this.executebutton;
            this.executebutton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            resources.ApplyResources(this.executebutton, "executebutton");
            this.executebutton.ForeColor = System.Drawing.Color.White;
            this.executebutton.HoverState.Parent = this.executebutton;
            this.executebutton.Name = "executebutton";
            this.executebutton.ShadowDecoration.Parent = this.executebutton;
            this.executebutton.Click += new System.EventHandler(this.executebutton_Click);
            // 
            // labelname
            // 
            resources.ApplyResources(this.labelname, "labelname");
            this.labelname.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelname.Name = "labelname";
            this.labelname.Click += new System.EventHandler(this.label1_Click);
            // 
            // jDragControl1
            // 
            this.jDragControl1.GetForm = this;
            this.jDragControl1.TargetControl = this.panel1;
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.executebutton);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.openbutton);
            this.Controls.Add(this.erasebutton);
            this.Controls.Add(this.injectbutton);
            this.Controls.Add(this.scriptarea);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scriptarea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button closebutton;
        private FastColoredTextBoxNS.FastColoredTextBox scriptarea;
        private Guna.UI2.WinForms.Guna2Button injectbutton;
        private Guna.UI2.WinForms.Guna2Button erasebutton;
        private Guna.UI2.WinForms.Guna2Button savebutton;
        private Guna.UI2.WinForms.Guna2Button openbutton;
        private Guna.UI2.WinForms.Guna2Button executebutton;
        private System.Windows.Forms.Label labelname;
        private JDragControl.JDragControl jDragControl1;
    }
}

