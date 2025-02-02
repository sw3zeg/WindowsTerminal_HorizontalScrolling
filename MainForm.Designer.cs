using System.ComponentModel;

namespace WindowsTerminal_HorizontalScrolling;

partial class MainForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        MoveLeftHotKey_label = new System.Windows.Forms.Label();
        MoveRightHotKey_label = new System.Windows.Forms.Label();
        ResetHotKey_label = new System.Windows.Forms.Label();
        HotKeys_label = new System.Windows.Forms.Label();
        HideWindow_label = new System.Windows.Forms.Label();
        Step_label = new System.Windows.Forms.Label();
        MinLeftPadding_label = new System.Windows.Forms.Label();
        SettingsJsonFilePath_label = new System.Windows.Forms.Label();
        AddToStartup_button = new System.Windows.Forms.Button();
        RemoveFromStartup_button = new System.Windows.Forms.Button();
        Apply_button = new System.Windows.Forms.Button();
        MoveLeftHotKey_input = new System.Windows.Forms.TextBox();
        MoveRightHotKey_input = new System.Windows.Forms.TextBox();
        ResetHotKey_input = new System.Windows.Forms.TextBox();
        MinLeftPadding_input = new System.Windows.Forms.TextBox();
        SettingsJsonFilePath_input = new System.Windows.Forms.TextBox();
        HideWindow_input = new System.Windows.Forms.Button();
        Step_input = new System.Windows.Forms.TextBox();
        Header = new System.Windows.Forms.Panel();
        label1 = new System.Windows.Forms.Label();
        Minimize_button = new System.Windows.Forms.Button();
        Exit_button = new System.Windows.Forms.Button();
        Header.SuspendLayout();
        SuspendLayout();
        // 
        // MoveLeftHotKey_label
        // 
        MoveLeftHotKey_label.BackColor = System.Drawing.Color.FromArgb(((int)((byte)43)), ((int)((byte)80)), ((int)((byte)92)));
        MoveLeftHotKey_label.ForeColor = System.Drawing.SystemColors.Window;
        MoveLeftHotKey_label.Location = new System.Drawing.Point(23, 184);
        MoveLeftHotKey_label.Name = "MoveLeftHotKey_label";
        MoveLeftHotKey_label.Size = new System.Drawing.Size(100, 30);
        MoveLeftHotKey_label.TabIndex = 0;
        MoveLeftHotKey_label.Tag = "Move Left";
        MoveLeftHotKey_label.Text = "Move Left";
        MoveLeftHotKey_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // MoveRightHotKey_label
        // 
        MoveRightHotKey_label.BackColor = System.Drawing.Color.FromArgb(((int)((byte)43)), ((int)((byte)80)), ((int)((byte)92)));
        MoveRightHotKey_label.ForeColor = System.Drawing.SystemColors.Window;
        MoveRightHotKey_label.Location = new System.Drawing.Point(23, 219);
        MoveRightHotKey_label.Name = "MoveRightHotKey_label";
        MoveRightHotKey_label.Size = new System.Drawing.Size(100, 30);
        MoveRightHotKey_label.TabIndex = 1;
        MoveRightHotKey_label.Tag = "Move Left";
        MoveRightHotKey_label.Text = "Move Right";
        MoveRightHotKey_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // ResetHotKey_label
        // 
        ResetHotKey_label.BackColor = System.Drawing.Color.FromArgb(((int)((byte)43)), ((int)((byte)80)), ((int)((byte)92)));
        ResetHotKey_label.ForeColor = System.Drawing.SystemColors.Window;
        ResetHotKey_label.Location = new System.Drawing.Point(23, 254);
        ResetHotKey_label.Name = "ResetHotKey_label";
        ResetHotKey_label.Size = new System.Drawing.Size(100, 30);
        ResetHotKey_label.TabIndex = 2;
        ResetHotKey_label.Tag = "Move Left";
        ResetHotKey_label.Text = "Reset";
        ResetHotKey_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // HotKeys_label
        // 
        HotKeys_label.BackColor = System.Drawing.Color.FromArgb(((int)((byte)43)), ((int)((byte)80)), ((int)((byte)92)));
        HotKeys_label.ForeColor = System.Drawing.SystemColors.Window;
        HotKeys_label.Location = new System.Drawing.Point(9, 149);
        HotKeys_label.Name = "HotKeys_label";
        HotKeys_label.Size = new System.Drawing.Size(100, 30);
        HotKeys_label.TabIndex = 3;
        HotKeys_label.Tag = "Move Left";
        HotKeys_label.Text = "Hot Keys";
        HotKeys_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // HideWindow_label
        // 
        HideWindow_label.BackColor = System.Drawing.Color.FromArgb(((int)((byte)43)), ((int)((byte)80)), ((int)((byte)92)));
        HideWindow_label.ForeColor = System.Drawing.SystemColors.Window;
        HideWindow_label.Location = new System.Drawing.Point(292, 301);
        HideWindow_label.Name = "HideWindow_label";
        HideWindow_label.Size = new System.Drawing.Size(130, 35);
        HideWindow_label.TabIndex = 4;
        HideWindow_label.Tag = "Move Left";
        HideWindow_label.Text = "Hide Window";
        HideWindow_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // Step_label
        // 
        Step_label.BackColor = System.Drawing.Color.FromArgb(((int)((byte)43)), ((int)((byte)80)), ((int)((byte)92)));
        Step_label.ForeColor = System.Drawing.SystemColors.Window;
        Step_label.Location = new System.Drawing.Point(395, 219);
        Step_label.Name = "Step_label";
        Step_label.Size = new System.Drawing.Size(50, 30);
        Step_label.TabIndex = 5;
        Step_label.Tag = "Move Left";
        Step_label.Text = "Step";
        Step_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // MinLeftPadding_label
        // 
        MinLeftPadding_label.BackColor = System.Drawing.Color.FromArgb(((int)((byte)43)), ((int)((byte)80)), ((int)((byte)92)));
        MinLeftPadding_label.ForeColor = System.Drawing.SystemColors.Window;
        MinLeftPadding_label.Location = new System.Drawing.Point(395, 254);
        MinLeftPadding_label.Name = "MinLeftPadding_label";
        MinLeftPadding_label.Size = new System.Drawing.Size(160, 30);
        MinLeftPadding_label.TabIndex = 6;
        MinLeftPadding_label.Tag = "Move Left";
        MinLeftPadding_label.Text = "Min Left Padding";
        MinLeftPadding_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // SettingsJsonFilePath_label
        // 
        SettingsJsonFilePath_label.BackColor = System.Drawing.Color.FromArgb(((int)((byte)43)), ((int)((byte)80)), ((int)((byte)92)));
        SettingsJsonFilePath_label.ForeColor = System.Drawing.SystemColors.Window;
        SettingsJsonFilePath_label.Location = new System.Drawing.Point(9, 47);
        SettingsJsonFilePath_label.Name = "SettingsJsonFilePath_label";
        SettingsJsonFilePath_label.Size = new System.Drawing.Size(200, 30);
        SettingsJsonFilePath_label.TabIndex = 7;
        SettingsJsonFilePath_label.Tag = "Move Left";
        SettingsJsonFilePath_label.Text = "Settings Json File Path";
        SettingsJsonFilePath_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // AddToStartup_button
        // 
        AddToStartup_button.BackColor = System.Drawing.Color.FromArgb(((int)((byte)126)), ((int)((byte)105)), ((int)((byte)92)));
        AddToStartup_button.FlatAppearance.BorderSize = 0;
        AddToStartup_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)107)), ((int)((byte)89)), ((int)((byte)78)));
        AddToStartup_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)145)), ((int)((byte)120)), ((int)((byte)106)));
        AddToStartup_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        AddToStartup_button.Location = new System.Drawing.Point(9, 301);
        AddToStartup_button.Name = "AddToStartup_button";
        AddToStartup_button.Size = new System.Drawing.Size(110, 35);
        AddToStartup_button.TabIndex = 8;
        AddToStartup_button.Text = "+ autorun";
        AddToStartup_button.UseVisualStyleBackColor = false;
        AddToStartup_button.Click += AddToStartup_button_Click;
        // 
        // RemoveFromStartup_button
        // 
        RemoveFromStartup_button.BackColor = System.Drawing.Color.FromArgb(((int)((byte)126)), ((int)((byte)105)), ((int)((byte)92)));
        RemoveFromStartup_button.FlatAppearance.BorderSize = 0;
        RemoveFromStartup_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)107)), ((int)((byte)89)), ((int)((byte)78)));
        RemoveFromStartup_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)145)), ((int)((byte)120)), ((int)((byte)106)));
        RemoveFromStartup_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        RemoveFromStartup_button.Location = new System.Drawing.Point(129, 301);
        RemoveFromStartup_button.Name = "RemoveFromStartup_button";
        RemoveFromStartup_button.Size = new System.Drawing.Size(110, 35);
        RemoveFromStartup_button.TabIndex = 9;
        RemoveFromStartup_button.Text = "- autorun";
        RemoveFromStartup_button.UseVisualStyleBackColor = false;
        RemoveFromStartup_button.Click += RemoveFromStartup_button_Click;
        // 
        // Apply_button
        // 
        Apply_button.BackColor = System.Drawing.Color.FromArgb(((int)((byte)126)), ((int)((byte)105)), ((int)((byte)92)));
        Apply_button.FlatAppearance.BorderSize = 0;
        Apply_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)107)), ((int)((byte)89)), ((int)((byte)78)));
        Apply_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)145)), ((int)((byte)120)), ((int)((byte)106)));
        Apply_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        Apply_button.Location = new System.Drawing.Point(511, 301);
        Apply_button.Name = "Apply_button";
        Apply_button.Size = new System.Drawing.Size(100, 35);
        Apply_button.TabIndex = 10;
        Apply_button.Text = "APPLY";
        Apply_button.UseVisualStyleBackColor = false;
        Apply_button.Click += Apply_button_Click;
        // 
        // MoveLeftHotKey_input
        // 
        MoveLeftHotKey_input.BackColor = System.Drawing.Color.FromArgb(((int)((byte)230)), ((int)((byte)214)), ((int)((byte)193)));
        MoveLeftHotKey_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
        MoveLeftHotKey_input.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)26)), ((int)((byte)48)), ((int)((byte)63)));
        MoveLeftHotKey_input.Location = new System.Drawing.Point(129, 184);
        MoveLeftHotKey_input.Multiline = true;
        MoveLeftHotKey_input.Name = "MoveLeftHotKey_input";
        MoveLeftHotKey_input.PlaceholderText = "alt+left";
        MoveLeftHotKey_input.Size = new System.Drawing.Size(221, 30);
        MoveLeftHotKey_input.TabIndex = 12;
        MoveLeftHotKey_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // MoveRightHotKey_input
        // 
        MoveRightHotKey_input.BackColor = System.Drawing.Color.FromArgb(((int)((byte)230)), ((int)((byte)214)), ((int)((byte)193)));
        MoveRightHotKey_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
        MoveRightHotKey_input.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)26)), ((int)((byte)48)), ((int)((byte)63)));
        MoveRightHotKey_input.Location = new System.Drawing.Point(129, 219);
        MoveRightHotKey_input.Multiline = true;
        MoveRightHotKey_input.Name = "MoveRightHotKey_input";
        MoveRightHotKey_input.PlaceholderText = "alt+left";
        MoveRightHotKey_input.Size = new System.Drawing.Size(221, 30);
        MoveRightHotKey_input.TabIndex = 13;
        MoveRightHotKey_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // ResetHotKey_input
        // 
        ResetHotKey_input.BackColor = System.Drawing.Color.FromArgb(((int)((byte)230)), ((int)((byte)214)), ((int)((byte)193)));
        ResetHotKey_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
        ResetHotKey_input.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)26)), ((int)((byte)48)), ((int)((byte)63)));
        ResetHotKey_input.Location = new System.Drawing.Point(129, 254);
        ResetHotKey_input.Multiline = true;
        ResetHotKey_input.Name = "ResetHotKey_input";
        ResetHotKey_input.PlaceholderText = "alt+left";
        ResetHotKey_input.Size = new System.Drawing.Size(221, 30);
        ResetHotKey_input.TabIndex = 14;
        ResetHotKey_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // MinLeftPadding_input
        // 
        MinLeftPadding_input.BackColor = System.Drawing.Color.FromArgb(((int)((byte)230)), ((int)((byte)214)), ((int)((byte)193)));
        MinLeftPadding_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
        MinLeftPadding_input.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)26)), ((int)((byte)48)), ((int)((byte)63)));
        MinLeftPadding_input.Location = new System.Drawing.Point(561, 254);
        MinLeftPadding_input.Multiline = true;
        MinLeftPadding_input.Name = "MinLeftPadding_input";
        MinLeftPadding_input.PlaceholderText = "8";
        MinLeftPadding_input.Size = new System.Drawing.Size(50, 30);
        MinLeftPadding_input.TabIndex = 16;
        MinLeftPadding_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // SettingsJsonFilePath_input
        // 
        SettingsJsonFilePath_input.BackColor = System.Drawing.Color.FromArgb(((int)((byte)230)), ((int)((byte)214)), ((int)((byte)193)));
        SettingsJsonFilePath_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
        SettingsJsonFilePath_input.Font = new System.Drawing.Font("Segoe UI", 14F);
        SettingsJsonFilePath_input.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)26)), ((int)((byte)48)), ((int)((byte)63)));
        SettingsJsonFilePath_input.Location = new System.Drawing.Point(9, 82);
        SettingsJsonFilePath_input.Multiline = true;
        SettingsJsonFilePath_input.Name = "SettingsJsonFilePath_input";
        SettingsJsonFilePath_input.PlaceholderText = "...";
        SettingsJsonFilePath_input.Size = new System.Drawing.Size(602, 50);
        SettingsJsonFilePath_input.TabIndex = 17;
        SettingsJsonFilePath_input.Text = ("C:\\Users\\<USERNAME>\\AppData\\Local\\Packages\\Microsoft.WindowsTerminal_8wekyb3d8bbw" + "e\\LocalState\\settings.json");
        // 
        // HideWindow_input
        // 
        HideWindow_input.BackColor = System.Drawing.Color.FromArgb(((int)((byte)230)), ((int)((byte)214)), ((int)((byte)193)));
        HideWindow_input.FlatAppearance.BorderSize = 0;
        HideWindow_input.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)178)), ((int)((byte)160)), ((int)((byte)143)));
        HideWindow_input.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)178)), ((int)((byte)160)), ((int)((byte)143)));
        HideWindow_input.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        HideWindow_input.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)26)), ((int)((byte)48)), ((int)((byte)63)));
        HideWindow_input.Location = new System.Drawing.Point(428, 301);
        HideWindow_input.Name = "HideWindow_input";
        HideWindow_input.Size = new System.Drawing.Size(35, 35);
        HideWindow_input.TabIndex = 20;
        HideWindow_input.UseVisualStyleBackColor = false;
        HideWindow_input.Click += HideWindow_input_Click;
        // 
        // Step_input
        // 
        Step_input.BackColor = System.Drawing.Color.FromArgb(((int)((byte)230)), ((int)((byte)214)), ((int)((byte)193)));
        Step_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
        Step_input.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)26)), ((int)((byte)48)), ((int)((byte)63)));
        Step_input.Location = new System.Drawing.Point(451, 219);
        Step_input.Multiline = true;
        Step_input.Name = "Step_input";
        Step_input.PlaceholderText = "50";
        Step_input.Size = new System.Drawing.Size(40, 30);
        Step_input.TabIndex = 15;
        Step_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // Header
        // 
        Header.BackColor = System.Drawing.Color.FromArgb(((int)((byte)6)), ((int)((byte)24)), ((int)((byte)38)));
        Header.Controls.Add(label1);
        Header.Controls.Add(Minimize_button);
        Header.Controls.Add(Exit_button);
        Header.Location = new System.Drawing.Point(0, 0);
        Header.Name = "Header";
        Header.Size = new System.Drawing.Size(620, 40);
        Header.TabIndex = 21;
        Header.MouseDown += Header_MouseDown;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 12F);
        label1.Location = new System.Drawing.Point(0, 0);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(298, 40);
        label1.TabIndex = 22;
        label1.Text = "Windows Terminal Horizontal Scrolling";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // Minimize_button
        // 
        Minimize_button.BackColor = System.Drawing.Color.FromArgb(((int)((byte)6)), ((int)((byte)24)), ((int)((byte)38)));
        Minimize_button.FlatAppearance.BorderSize = 0;
        Minimize_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)5)), ((int)((byte)20)), ((int)((byte)32)));
        Minimize_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)7)), ((int)((byte)28)), ((int)((byte)44)));
        Minimize_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        Minimize_button.Font = new System.Drawing.Font("Segoe UI", 14F);
        Minimize_button.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)230)), ((int)((byte)214)), ((int)((byte)193)));
        Minimize_button.Location = new System.Drawing.Point(530, 0);
        Minimize_button.Margin = new System.Windows.Forms.Padding(0);
        Minimize_button.Name = "Minimize_button";
        Minimize_button.Size = new System.Drawing.Size(45, 40);
        Minimize_button.TabIndex = 1;
        Minimize_button.Text = "➖";
        Minimize_button.UseVisualStyleBackColor = false;
        Minimize_button.Click += Minimize_button_Click;
        // 
        // Exit_button
        // 
        Exit_button.BackColor = System.Drawing.Color.FromArgb(((int)((byte)6)), ((int)((byte)24)), ((int)((byte)38)));
        Exit_button.FlatAppearance.BorderSize = 0;
        Exit_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)5)), ((int)((byte)20)), ((int)((byte)32)));
        Exit_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)7)), ((int)((byte)28)), ((int)((byte)44)));
        Exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        Exit_button.Font = new System.Drawing.Font("Segoe UI", 14F);
        Exit_button.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)230)), ((int)((byte)214)), ((int)((byte)193)));
        Exit_button.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
        Exit_button.Location = new System.Drawing.Point(575, 0);
        Exit_button.Margin = new System.Windows.Forms.Padding(0);
        Exit_button.Name = "Exit_button";
        Exit_button.Size = new System.Drawing.Size(45, 40);
        Exit_button.TabIndex = 0;
        Exit_button.Text = "✕";
        Exit_button.UseVisualStyleBackColor = false;
        Exit_button.Click += Exit_button_Click;
        // 
        // MainForm
        // 
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)26)), ((int)((byte)48)), ((int)((byte)63)));
        ClientSize = new System.Drawing.Size(620, 345);
        Controls.Add(Header);
        Controls.Add(HideWindow_input);
        Controls.Add(SettingsJsonFilePath_input);
        Controls.Add(MinLeftPadding_input);
        Controls.Add(Step_input);
        Controls.Add(ResetHotKey_input);
        Controls.Add(MoveRightHotKey_input);
        Controls.Add(MoveLeftHotKey_input);
        Controls.Add(Apply_button);
        Controls.Add(RemoveFromStartup_button);
        Controls.Add(AddToStartup_button);
        Controls.Add(SettingsJsonFilePath_label);
        Controls.Add(MinLeftPadding_label);
        Controls.Add(Step_label);
        Controls.Add(HideWindow_label);
        Controls.Add(HotKeys_label);
        Controls.Add(ResetHotKey_label);
        Controls.Add(MoveRightHotKey_label);
        Controls.Add(MoveLeftHotKey_label);
        Font = new System.Drawing.Font("Segoe UI", 14F);
        ForeColor = System.Drawing.SystemColors.HighlightText;
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
        Margin = new System.Windows.Forms.Padding(6);
        Text = "MainForm";
        MouseDown += MainForm_MouseDown;
        Header.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Button Minimize_button;

    private System.Windows.Forms.Button Exit_button;

    private System.Windows.Forms.Panel Header;

    private System.Windows.Forms.Button HideWindow_input;

    private System.Windows.Forms.TextBox MoveRightHotKey_input;
    private System.Windows.Forms.TextBox ResetHotKey_input;
    private System.Windows.Forms.TextBox Step_input;
    private System.Windows.Forms.TextBox MinLeftPadding_input;
    private System.Windows.Forms.TextBox SettingsJsonFilePath_input;

    private System.Windows.Forms.TextBox MoveLeftHotKey_input;

    private System.Windows.Forms.Button Apply_button;

    private System.Windows.Forms.Button AddToStartup_button;

    private System.Windows.Forms.Button RemoveFromStartup_button;

    private System.Windows.Forms.Label SettingsJsonFilePath_label;

    private System.Windows.Forms.Label MinLeftPadding_label;

    private System.Windows.Forms.Label Step_label;

    private System.Windows.Forms.Label HideWindow_label;

    private System.Windows.Forms.Label HotKeys_label;

    private System.Windows.Forms.Label MoveRightHotKey_label;
    private System.Windows.Forms.Label ResetHotKey_label;

    private System.Windows.Forms.Label MoveLeftHotKey_label;

    #endregion
}