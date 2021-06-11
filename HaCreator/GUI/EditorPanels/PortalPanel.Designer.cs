﻿using HaCreator.CustomControls;

namespace HaCreator.GUI.EditorPanels
{
    partial class PortalPanel
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
            this.portalImageContainer = new ThumbnailFlowLayoutPanel();
            this.SuspendLayout();
            // 
            // portalImageContainer
            // 
            this.portalImageContainer.AutoScroll = true;
            this.portalImageContainer.BackColor = System.Drawing.Color.White;
            this.portalImageContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.portalImageContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.portalImageContainer.Location = new System.Drawing.Point(0, 0);
            this.portalImageContainer.Name = "portalImageContainer";
            this.portalImageContainer.Size = new System.Drawing.Size(284, 658);
            this.portalImageContainer.TabIndex = 2;
            this.portalImageContainer.WrapContents = false;
            // 
            // PortalPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.portalImageContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Name = "PortalPanel";
            this.Size = new System.Drawing.Size(284, 658);
            this.ResumeLayout(false);

        }

        #endregion

        private ThumbnailFlowLayoutPanel portalImageContainer;
    }
}