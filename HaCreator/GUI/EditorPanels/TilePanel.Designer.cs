﻿using HaCreator.CustomControls;

namespace HaCreator.GUI.EditorPanels
{
    partial class TilePanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tileBrowse = new System.Windows.Forms.Button();
            this.tileSetList = new System.Windows.Forms.ListBox();
            this.tileImagesContainer = new ThumbnailFlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tileImagesContainer);
            this.splitContainer1.Size = new System.Drawing.Size(284, 658);
            this.splitContainer1.SplitterDistance = 183;
            this.splitContainer1.TabIndex = 3;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tileBrowse);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tileSetList);
            this.splitContainer2.Size = new System.Drawing.Size(284, 183);
            this.splitContainer2.SplitterDistance = 42;
            this.splitContainer2.TabIndex = 1;
            // 
            // tileBrowse
            // 
            this.tileBrowse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileBrowse.Location = new System.Drawing.Point(0, 0);
            this.tileBrowse.Name = "tileBrowse";
            this.tileBrowse.Size = new System.Drawing.Size(284, 42);
            this.tileBrowse.TabIndex = 0;
            this.tileBrowse.Text = "Browse...";
            this.tileBrowse.UseVisualStyleBackColor = true;
            this.tileBrowse.Click += new System.EventHandler(this.tileBrowse_Click);
            // 
            // tileSetList
            // 
            this.tileSetList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileSetList.FormattingEnabled = true;
            this.tileSetList.Location = new System.Drawing.Point(0, 0);
            this.tileSetList.Name = "tileSetList";
            this.tileSetList.Size = new System.Drawing.Size(284, 137);
            this.tileSetList.TabIndex = 0;
            this.tileSetList.SelectedIndexChanged += new System.EventHandler(this.tileSetList_SelectedIndexChanged);
            // 
            // tileImagesContainer
            // 
            this.tileImagesContainer.AutoScroll = true;
            this.tileImagesContainer.BackColor = System.Drawing.Color.White;
            this.tileImagesContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileImagesContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.tileImagesContainer.Location = new System.Drawing.Point(0, 0);
            this.tileImagesContainer.Name = "tileImagesContainer";
            this.tileImagesContainer.Size = new System.Drawing.Size(284, 471);
            this.tileImagesContainer.TabIndex = 0;
            this.tileImagesContainer.WrapContents = false;
            // 
            // TilePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Name = "TilePanel";
            this.Size = new System.Drawing.Size(284, 658);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button tileBrowse;
        private System.Windows.Forms.ListBox tileSetList;
        private ThumbnailFlowLayoutPanel tileImagesContainer;
    }
}
