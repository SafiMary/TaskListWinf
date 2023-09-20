namespace TaskListWinf
{
    partial class UsersBase
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.Column_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_1,
            this.Column_2,
            this.Column_3,
            this.Column_4,
            this.Column_5});
            this.dataGridView1.Location = new System.Drawing.Point(12, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(658, 256);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(63, 382);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(107, 41);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "ДОБАВИТЬ";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(621, 382);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(116, 41);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "СОХРАНИТЬ";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(313, 382);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(107, 41);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "УДАЛИТЬ";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // Column_1
            // 
            this.Column_1.HeaderText = "№";
            this.Column_1.MinimumWidth = 6;
            this.Column_1.Name = "Column_1";
            this.Column_1.Width = 125;
            // 
            // Column_2
            // 
            this.Column_2.HeaderText = "Ответственный";
            this.Column_2.MinimumWidth = 6;
            this.Column_2.Name = "Column_2";
            this.Column_2.Width = 125;
            // 
            // Column_3
            // 
            this.Column_3.HeaderText = "Задача";
            this.Column_3.MinimumWidth = 6;
            this.Column_3.Name = "Column_3";
            this.Column_3.Width = 125;
            // 
            // Column_4
            // 
            this.Column_4.HeaderText = "Срок до";
            this.Column_4.MinimumWidth = 6;
            this.Column_4.Name = "Column_4";
            this.Column_4.Width = 125;
            // 
            // Column_5
            // 
            this.Column_5.HeaderText = "Отметка о выполнении";
            this.Column_5.MinimumWidth = 6;
            this.Column_5.Name = "Column_5";
            this.Column_5.Width = 125;
            // 
            // UsersBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 653);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UsersBase";
            this.Text = "Список задач";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_5;
    }
}