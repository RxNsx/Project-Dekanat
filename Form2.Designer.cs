namespace WFA
{
	partial class Form2
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
			this.lastNameBoxForm2 = new System.Windows.Forms.TextBox();
			this.nameBoxBinding = new System.Windows.Forms.BindingSource(this.components);
			this.nameBoxForm2 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.nameBoxBinding)).BeginInit();
			this.SuspendLayout();
			// 
			// lastNameBoxForm2
			// 
			this.lastNameBoxForm2.Location = new System.Drawing.Point(13, 28);
			this.lastNameBoxForm2.Name = "lastNameBoxForm2";
			this.lastNameBoxForm2.Size = new System.Drawing.Size(154, 20);
			this.lastNameBoxForm2.TabIndex = 0;
			// 
			// nameBoxForm2
			// 
			this.nameBoxForm2.Location = new System.Drawing.Point(173, 28);
			this.nameBoxForm2.Name = "nameBoxForm2";
			this.nameBoxForm2.Size = new System.Drawing.Size(156, 20);
			this.nameBoxForm2.TabIndex = 1;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Linen;
			this.ClientSize = new System.Drawing.Size(828, 225);
			this.Controls.Add(this.nameBoxForm2);
			this.Controls.Add(this.lastNameBoxForm2);
			this.Name = "Form2";
			this.Load += new System.EventHandler(this.Form2_Load);
			((System.ComponentModel.ISupportInitialize)(this.nameBoxBinding)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox lastNameBoxForm2;
		private System.Windows.Forms.BindingSource nameBoxBinding;
		private System.Windows.Forms.TextBox nameBoxForm2;
	}
}