﻿namespace EarlyUpdateCheck
{
	partial class Options
	{
		/// <summary> 
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Komponenten-Designer generierter Code

		/// <summary> 
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.gOneClickUpdate = new RookieUI.CheckedGroupBox();
			this.bUpdateTranslations = new System.Windows.Forms.Button();
			this.cbDownloadCurrentTranslation = new System.Windows.Forms.CheckBox();
			this.tbOneClickUpdateDesc = new System.Windows.Forms.TextBox();
			this.gCheckSync = new RookieUI.CheckedGroupBox();
			this.tbCheckSyncDesc = new System.Windows.Forms.TextBox();
			this.cbCheckSync = new System.Windows.Forms.CheckBox();
			this.gOneClickUpdate.SuspendLayout();
			this.gCheckSync.SuspendLayout();
			this.SuspendLayout();
			// 
			// gOneClickUpdate
			// 
			this.gOneClickUpdate.CheckboxOffset = new System.Drawing.Point(5, 0);
			this.gOneClickUpdate.Checked = true;
			this.gOneClickUpdate.Controls.Add(this.bUpdateTranslations);
			this.gOneClickUpdate.Controls.Add(this.cbDownloadCurrentTranslation);
			this.gOneClickUpdate.Controls.Add(this.tbOneClickUpdateDesc);
			this.gOneClickUpdate.DisableControlsIfUnchecked = false;
			this.gOneClickUpdate.Dock = System.Windows.Forms.DockStyle.Top;
			this.gOneClickUpdate.Location = new System.Drawing.Point(0, 169);
			this.gOneClickUpdate.Name = "gOneClickUpdate";
			this.gOneClickUpdate.Padding = new System.Windows.Forms.Padding(15, 5, 15, 5);
			this.gOneClickUpdate.Size = new System.Drawing.Size(753, 193);
			this.gOneClickUpdate.TabIndex = 11;
			this.gOneClickUpdate.TabStop = false;
			this.gOneClickUpdate.Text = "SimpleUpdate";
			// 
			// bUpdateTranslations
			// 
			this.bUpdateTranslations.Dock = System.Windows.Forms.DockStyle.Top;
			this.bUpdateTranslations.Location = new System.Drawing.Point(15, 158);
			this.bUpdateTranslations.Name = "bUpdateTranslations";
			this.bUpdateTranslations.Size = new System.Drawing.Size(723, 30);
			this.bUpdateTranslations.TabIndex = 7;
			this.bUpdateTranslations.Text = "Translation update";
			this.bUpdateTranslations.UseVisualStyleBackColor = true;
			this.bUpdateTranslations.Click += new System.EventHandler(this.bUpdateTranslations_Click);
			// 
			// cbDownloadCurrentTranslation
			// 
			this.cbDownloadCurrentTranslation.Dock = System.Windows.Forms.DockStyle.Top;
			this.cbDownloadCurrentTranslation.Location = new System.Drawing.Point(15, 134);
			this.cbDownloadCurrentTranslation.Name = "cbDownloadCurrentTranslation";
			this.cbDownloadCurrentTranslation.Size = new System.Drawing.Size(723, 24);
			this.cbDownloadCurrentTranslation.TabIndex = 5;
			this.cbDownloadCurrentTranslation.Text = "Download selected language";
			this.cbDownloadCurrentTranslation.UseVisualStyleBackColor = true;
			// 
			// tbOneClickUpdateDesc
			// 
			this.tbOneClickUpdateDesc.Dock = System.Windows.Forms.DockStyle.Top;
			this.tbOneClickUpdateDesc.Location = new System.Drawing.Point(15, 24);
			this.tbOneClickUpdateDesc.Multiline = true;
			this.tbOneClickUpdateDesc.Name = "tbOneClickUpdateDesc";
			this.tbOneClickUpdateDesc.ReadOnly = true;
			this.tbOneClickUpdateDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbOneClickUpdateDesc.Size = new System.Drawing.Size(723, 110);
			this.tbOneClickUpdateDesc.TabIndex = 6;
			// 
			// gCheckSync
			// 
			this.gCheckSync.CheckboxOffset = new System.Drawing.Point(5, 0);
			this.gCheckSync.Checked = true;
			this.gCheckSync.Controls.Add(this.tbCheckSyncDesc);
			this.gCheckSync.Controls.Add(this.cbCheckSync);
			this.gCheckSync.DisableControlsIfUnchecked = false;
			this.gCheckSync.Dock = System.Windows.Forms.DockStyle.Top;
			this.gCheckSync.Location = new System.Drawing.Point(0, 0);
			this.gCheckSync.Name = "gCheckSync";
			this.gCheckSync.Padding = new System.Windows.Forms.Padding(15, 5, 15, 5);
			this.gCheckSync.Size = new System.Drawing.Size(753, 169);
			this.gCheckSync.TabIndex = 10;
			this.gCheckSync.TabStop = false;
			this.gCheckSync.Text = "CheckSync";
			// 
			// tbCheckSyncDesc
			// 
			this.tbCheckSyncDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbCheckSyncDesc.Location = new System.Drawing.Point(15, 48);
			this.tbCheckSyncDesc.Multiline = true;
			this.tbCheckSyncDesc.Name = "tbCheckSyncDesc";
			this.tbCheckSyncDesc.ReadOnly = true;
			this.tbCheckSyncDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbCheckSyncDesc.Size = new System.Drawing.Size(723, 116);
			this.tbCheckSyncDesc.TabIndex = 3;
			// 
			// cbCheckSync
			// 
			this.cbCheckSync.AutoSize = true;
			this.cbCheckSync.Dock = System.Windows.Forms.DockStyle.Top;
			this.cbCheckSync.Location = new System.Drawing.Point(15, 24);
			this.cbCheckSync.Name = "cbCheckSync";
			this.cbCheckSync.Size = new System.Drawing.Size(723, 24);
			this.cbCheckSync.TabIndex = 2;
			this.cbCheckSync.Text = "CheckSync";
			this.cbCheckSync.UseVisualStyleBackColor = true;
			// 
			// Options
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.gOneClickUpdate);
			this.Controls.Add(this.gCheckSync);
			this.Name = "Options";
			this.Size = new System.Drawing.Size(753, 480);
			this.gOneClickUpdate.ResumeLayout(false);
			this.gOneClickUpdate.PerformLayout();
			this.gCheckSync.ResumeLayout(false);
			this.gCheckSync.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		internal RookieUI.CheckedGroupBox gCheckSync;
		private System.Windows.Forms.TextBox tbCheckSyncDesc;
		internal System.Windows.Forms.CheckBox cbCheckSync;
		internal RookieUI.CheckedGroupBox gOneClickUpdate;
		private System.Windows.Forms.Button bUpdateTranslations;
		internal System.Windows.Forms.CheckBox cbDownloadCurrentTranslation;
		private System.Windows.Forms.TextBox tbOneClickUpdateDesc;
	}
}
