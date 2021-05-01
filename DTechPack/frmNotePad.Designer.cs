/*
 * Created by SharpDevelop.
 * User: Davood
 * Date: 6/27/2015
 * Time: 1:42 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace DTechPack
{
	partial class frmNotePad
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(104, 72);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(291, 222);
			this.panel1.TabIndex = 0;
			// 
			// frmNotePad
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(428, 316);
			this.Controls.Add(this.panel1);
			this.Name = "frmNotePad";
			this.Text = "frmNotePad";
			this.Load += new System.EventHandler(this.FrmNotePadLoad);
			this.ResumeLayout(false);

		}
	}
}
