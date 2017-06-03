using System;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace TinyPainter
{
    partial class mainPainter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void  Dispose(bool disposing)
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainPainter));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.CurStates = new System.Windows.Forms.ToolStripStatusLabel();
            this.cursorPos = new System.Windows.Forms.ToolStripStatusLabel();
            this.curstate = new System.Windows.Forms.ToolStripStatusLabel();
            this.operatebox = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Arrow = new System.Windows.Forms.ToolStripButton();
            this.Pencil = new System.Windows.Forms.ToolStripButton();
            this.Eraser = new System.Windows.Forms.ToolStripButton();
            this.Fill = new System.Windows.Forms.ToolStripButton();
            this.magicPencil = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Line = new System.Windows.Forms.ToolStripButton();
            this.Eclipse = new System.Windows.Forms.ToolStripButton();
            this.Rectangle = new System.Windows.Forms.ToolStripButton();
            this.Text = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.LineWidth = new System.Windows.Forms.ToolStripDropDownButton();
            this.SlimWidth = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumWidth = new System.Windows.Forms.ToolStripMenuItem();
            this.LargeWidth = new System.Windows.Forms.ToolStripMenuItem();
            this.WidthBox = new System.Windows.Forms.ToolStripTextBox();
            this.OkButton = new System.Windows.Forms.ToolStripMenuItem();
            this.colors = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.operatebox)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.new_pic);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.open_pic);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.save_pic);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveas_pic);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(152, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.Exit_App);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(42, 21);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copy_pic);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.paste_pic);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cut_pic);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clear_pic);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.About_App);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CurStates,
            this.cursorPos,
            this.curstate});
            this.statusStrip1.Location = new System.Drawing.Point(0, 389);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(584, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "Loaded";
            // 
            // CurStates
            // 
            this.CurStates.Name = "CurStates";
            this.CurStates.Size = new System.Drawing.Size(52, 17);
            this.CurStates.Text = "Loaded";
            // 
            // cursorPos
            // 
            this.cursorPos.Name = "cursorPos";
            this.cursorPos.Size = new System.Drawing.Size(131, 17);
            this.cursorPos.Text = "toolStripStatusLabel1";
            this.cursorPos.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pos_display);
            // 
            // curstate
            // 
            this.curstate.Name = "curstate";
            this.curstate.Size = new System.Drawing.Size(0, 17);
            // 
            // operatebox
            // 
            this.operatebox.BackColor = System.Drawing.SystemColors.Window;
            this.operatebox.InitialImage = null;
            this.operatebox.Location = new System.Drawing.Point(0, 50);
            this.operatebox.Name = "operatebox";
            this.operatebox.Size = new System.Drawing.Size(380, 240);
            this.operatebox.TabIndex = 3;
            this.operatebox.TabStop = false;
            this.operatebox.Paint += new System.Windows.Forms.PaintEventHandler(this.paintOnBox);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Arrow,
            this.Pencil,
            this.Eraser,
            this.Fill,
            this.magicPencil,
            this.toolStripSeparator2,
            this.Line,
            this.Eclipse,
            this.Rectangle,
            this.Text,
            this.toolStripSeparator3,
            this.LineWidth,
            this.colors});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(584, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Tool_Pressed);
            // 
            // Arrow
            // 
            this.Arrow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Arrow.Image = ((System.Drawing.Image)(resources.GetObject("Arrow.Image")));
            this.Arrow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Arrow.Name = "Arrow";
            this.Arrow.Size = new System.Drawing.Size(23, 22);
            this.Arrow.Text = "Arrow";
            // 
            // Pencil
            // 
            this.Pencil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Pencil.Image = ((System.Drawing.Image)(resources.GetObject("Pencil.Image")));
            this.Pencil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Pencil.Name = "Pencil";
            this.Pencil.Size = new System.Drawing.Size(23, 22);
            this.Pencil.Text = "Pencil";
            // 
            // Eraser
            // 
            this.Eraser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Eraser.Image = ((System.Drawing.Image)(resources.GetObject("Eraser.Image")));
            this.Eraser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Eraser.Name = "Eraser";
            this.Eraser.Size = new System.Drawing.Size(23, 22);
            this.Eraser.Text = "Eraser";
            // 
            // Fill
            // 
            this.Fill.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Fill.Image = ((System.Drawing.Image)(resources.GetObject("Fill.Image")));
            this.Fill.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Fill.Name = "Fill";
            this.Fill.Size = new System.Drawing.Size(23, 22);
            this.Fill.Text = "Fill";
            // 
            // magicPencil
            // 
            this.magicPencil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.magicPencil.Image = ((System.Drawing.Image)(resources.GetObject("magicPencil.Image")));
            this.magicPencil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.magicPencil.Name = "magicPencil";
            this.magicPencil.Size = new System.Drawing.Size(23, 22);
            this.magicPencil.Text = "toolStripButton1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // Line
            // 
            this.Line.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Line.Image = ((System.Drawing.Image)(resources.GetObject("Line.Image")));
            this.Line.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(23, 22);
            this.Line.Text = "Line";
            // 
            // Eclipse
            // 
            this.Eclipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Eclipse.Image = ((System.Drawing.Image)(resources.GetObject("Eclipse.Image")));
            this.Eclipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Eclipse.Name = "Eclipse";
            this.Eclipse.Size = new System.Drawing.Size(23, 22);
            this.Eclipse.Text = "Eclipse";
            // 
            // Rectangle
            // 
            this.Rectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Rectangle.Image = ((System.Drawing.Image)(resources.GetObject("Rectangle.Image")));
            this.Rectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(23, 22);
            this.Rectangle.Text = "Rectangle";
            // 
            // Text
            // 
            this.Text.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Text.Image = ((System.Drawing.Image)(resources.GetObject("Text.Image")));
            this.Text.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Text.Name = "Text";
            this.Text.Size = new System.Drawing.Size(23, 22);
            this.Text.Text = "Text";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // LineWidth
            // 
            this.LineWidth.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.LineWidth.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SlimWidth,
            this.mediumWidth,
            this.LargeWidth,
            this.WidthBox,
            this.OkButton});
            this.LineWidth.Image = ((System.Drawing.Image)(resources.GetObject("LineWidth.Image")));
            this.LineWidth.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LineWidth.Name = "LineWidth";
            this.LineWidth.Size = new System.Drawing.Size(55, 22);
            this.LineWidth.Text = "Width";
            // 
            // SlimWidth
            // 
            this.SlimWidth.Name = "SlimWidth";
            this.SlimWidth.Size = new System.Drawing.Size(160, 22);
            this.SlimWidth.Text = "Slim";
            this.SlimWidth.Click += new System.EventHandler(this.slimWidth);
            // 
            // mediumWidth
            // 
            this.mediumWidth.Name = "mediumWidth";
            this.mediumWidth.Size = new System.Drawing.Size(160, 22);
            this.mediumWidth.Text = "Medium";
            this.mediumWidth.Click += new System.EventHandler(this.mediumWidthe);
            // 
            // LargeWidth
            // 
            this.LargeWidth.Name = "LargeWidth";
            this.LargeWidth.Size = new System.Drawing.Size(160, 22);
            this.LargeWidth.Text = "Large";
            this.LargeWidth.Click += new System.EventHandler(this.largeWidth);
            // 
            // WidthBox
            // 
            this.WidthBox.Name = "WidthBox";
            this.WidthBox.Size = new System.Drawing.Size(100, 23);
            this.WidthBox.Click += new System.EventHandler(this.flushBox);
            // 
            // OkButton
            // 
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(160, 22);
            this.OkButton.Text = "OK";
            this.OkButton.Click += new System.EventHandler(this.selfmadeWidth);
            // 
            // colors
            // 
            this.colors.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.colors.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.colors.Name = "colors";
            this.colors.Size = new System.Drawing.Size(23, 22);
            this.colors.Text = "toolStripButton2";
            // 
            // mainPainter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.operatebox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainPainter";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.operatebox)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private PictureBox operatebox;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel CurStates;
        private ToolStripStatusLabel cursorPos;
        private ToolStrip toolStrip1;
        private ToolStripButton Arrow;
        private ToolStripButton Pencil;
        private ToolStripButton Eraser;
        private ToolStripButton Fill;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton Line;
        private ToolStripButton Eclipse;
        private ToolStripButton Rectangle;
        private ToolStripButton Text;
        private ToolStripStatusLabel curstate;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton magicPencil;
        private ToolStripDropDownButton LineWidth;
        private ToolStripMenuItem SlimWidth;
        private ToolStripMenuItem mediumWidth;
        private ToolStripMenuItem LargeWidth;
        private ToolStripTextBox WidthBox;
        private ToolStripMenuItem OkButton;
        private ToolStripButton colors;
    }
}

