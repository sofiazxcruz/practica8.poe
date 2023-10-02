namespace practica8
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.IDlabel = new System.Windows.Forms.Label();
			this.NameLabel = new System.Windows.Forms.Label();
			this.ApellidoLabel = new System.Windows.Forms.Label();
			this.DireccionLabel = new System.Windows.Forms.Label();
			this.IDtextbox = new System.Windows.Forms.TextBox();
			this.NametextBox = new System.Windows.Forms.TextBox();
			this.ApellidotextBox = new System.Windows.Forms.TextBox();
			this.DirecciontextBox = new System.Windows.Forms.TextBox();
			this.ADDbutton = new System.Windows.Forms.Button();
			this.Editbutton = new System.Windows.Forms.Button();
			this.DeleteButton = new System.Windows.Forms.Button();
			this.DatosDataGridView = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// IDlabel
			// 
			this.IDlabel.AutoSize = true;
			this.IDlabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.IDlabel.Location = new System.Drawing.Point(12, 88);
			this.IDlabel.Name = "IDlabel";
			this.IDlabel.Size = new System.Drawing.Size(29, 20);
			this.IDlabel.TabIndex = 0;
			this.IDlabel.Text = "ID:";
			// 
			// NameLabel
			// 
			this.NameLabel.AutoSize = true;
			this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.NameLabel.Location = new System.Drawing.Point(12, 147);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(71, 20);
			this.NameLabel.TabIndex = 1;
			this.NameLabel.Text = "Nombre:";
			// 
			// ApellidoLabel
			// 
			this.ApellidoLabel.AutoSize = true;
			this.ApellidoLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.ApellidoLabel.Location = new System.Drawing.Point(12, 208);
			this.ApellidoLabel.Name = "ApellidoLabel";
			this.ApellidoLabel.Size = new System.Drawing.Size(71, 20);
			this.ApellidoLabel.TabIndex = 2;
			this.ApellidoLabel.Text = "Apellido:";
			// 
			// DireccionLabel
			// 
			this.DireccionLabel.AutoSize = true;
			this.DireccionLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.DireccionLabel.Location = new System.Drawing.Point(12, 269);
			this.DireccionLabel.Name = "DireccionLabel";
			this.DireccionLabel.Size = new System.Drawing.Size(78, 20);
			this.DireccionLabel.TabIndex = 3;
			this.DireccionLabel.Text = "Dirección:";
			// 
			// IDtextbox
			// 
			this.IDtextbox.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.IDtextbox.Location = new System.Drawing.Point(112, 78);
			this.IDtextbox.Name = "IDtextbox";
			this.IDtextbox.Size = new System.Drawing.Size(214, 27);
			this.IDtextbox.TabIndex = 4;
			// 
			// NametextBox
			// 
			this.NametextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.NametextBox.Location = new System.Drawing.Point(112, 140);
			this.NametextBox.Name = "NametextBox";
			this.NametextBox.Size = new System.Drawing.Size(214, 27);
			this.NametextBox.TabIndex = 5;
			// 
			// ApellidotextBox
			// 
			this.ApellidotextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.ApellidotextBox.Location = new System.Drawing.Point(112, 201);
			this.ApellidotextBox.Name = "ApellidotextBox";
			this.ApellidotextBox.Size = new System.Drawing.Size(214, 27);
			this.ApellidotextBox.TabIndex = 6;
			// 
			// DirecciontextBox
			// 
			this.DirecciontextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.DirecciontextBox.Location = new System.Drawing.Point(112, 262);
			this.DirecciontextBox.Name = "DirecciontextBox";
			this.DirecciontextBox.Size = new System.Drawing.Size(214, 27);
			this.DirecciontextBox.TabIndex = 7;
			// 
			// ADDbutton
			// 
			this.ADDbutton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.ADDbutton.Location = new System.Drawing.Point(8, 320);
			this.ADDbutton.Name = "ADDbutton";
			this.ADDbutton.Size = new System.Drawing.Size(85, 33);
			this.ADDbutton.TabIndex = 8;
			this.ADDbutton.Text = "Agregar";
			this.ADDbutton.UseVisualStyleBackColor = true;
			this.ADDbutton.Click += new System.EventHandler(this.ADDbutton_Click);
			// 
			// Editbutton
			// 
			this.Editbutton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.Editbutton.Location = new System.Drawing.Point(279, 320);
			this.Editbutton.Name = "Editbutton";
			this.Editbutton.Size = new System.Drawing.Size(85, 33);
			this.Editbutton.TabIndex = 9;
			this.Editbutton.Text = "Editar";
			this.Editbutton.UseVisualStyleBackColor = true;
			// 
			// DeleteButton
			// 
			this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.DeleteButton.Location = new System.Drawing.Point(147, 320);
			this.DeleteButton.Name = "DeleteButton";
			this.DeleteButton.Size = new System.Drawing.Size(85, 33);
			this.DeleteButton.TabIndex = 10;
			this.DeleteButton.Text = "Eliminar";
			this.DeleteButton.UseVisualStyleBackColor = true;
			// 
			// DatosDataGridView
			// 
			this.DatosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DatosDataGridView.Location = new System.Drawing.Point(381, 82);
			this.DatosDataGridView.Name = "DatosDataGridView";
			this.DatosDataGridView.ReadOnly = true;
			this.DatosDataGridView.RowTemplate.Height = 25;
			this.DatosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DatosDataGridView.Size = new System.Drawing.Size(376, 204);
			this.DatosDataGridView.TabIndex = 11;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.DatosDataGridView);
			this.Controls.Add(this.DeleteButton);
			this.Controls.Add(this.Editbutton);
			this.Controls.Add(this.ADDbutton);
			this.Controls.Add(this.DirecciontextBox);
			this.Controls.Add(this.ApellidotextBox);
			this.Controls.Add(this.NametextBox);
			this.Controls.Add(this.IDtextbox);
			this.Controls.Add(this.DireccionLabel);
			this.Controls.Add(this.ApellidoLabel);
			this.Controls.Add(this.NameLabel);
			this.Controls.Add(this.IDlabel);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Conexion de base de datos";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label IDlabel;
		private Label NameLabel;
		private Label ApellidoLabel;
		private Label DireccionLabel;
		private TextBox IDtextbox;
		private TextBox NametextBox;
		private TextBox ApellidotextBox;
		private TextBox DirecciontextBox;
		private Button ADDbutton;
		private Button Editbutton;
		private Button DeleteButton;
		private DataGridView DatosDataGridView;
	}
}