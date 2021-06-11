﻿using HaCreator.CustomControls;

namespace HaCreator.GUI.EditorPanels
{
    partial class CommonPanel
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
            this.miscItemsContainer = new ThumbnailFlowLayoutPanel();
            this.SuspendLayout();
            // 
            // miscItemsContainer
            // 
            this.miscItemsContainer.BackColor = System.Drawing.Color.White;
            this.miscItemsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.miscItemsContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.miscItemsContainer.Location = new System.Drawing.Point(0, 0);
            this.miscItemsContainer.Name = "miscItemsContainer";
            this.miscItemsContainer.Size = new System.Drawing.Size(284, 658);
            this.miscItemsContainer.TabIndex = 2;
            this.miscItemsContainer.WrapContents = false;
            // 
            // CommonPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.miscItemsContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Name = "CommonPanel";
            this.Size = new System.Drawing.Size(284, 658);
            this.ResumeLayout(false);

        }

        #endregion

        private ThumbnailFlowLayoutPanel miscItemsContainer;
    }
}