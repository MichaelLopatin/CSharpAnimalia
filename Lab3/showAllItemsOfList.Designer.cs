namespace Lab3
{
    partial class showAllItemsOfList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(showAllItemsOfList));
            this.listBoxShowAllItems = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxShowAllItems
            // 
            this.listBoxShowAllItems.FormattingEnabled = true;
            this.listBoxShowAllItems.HorizontalScrollbar = true;
            this.listBoxShowAllItems.Location = new System.Drawing.Point(-1, 0);
            this.listBoxShowAllItems.Name = "listBoxShowAllItems";
            this.listBoxShowAllItems.Size = new System.Drawing.Size(586, 277);
            this.listBoxShowAllItems.TabIndex = 0;
            this.listBoxShowAllItems.SelectedIndexChanged += new System.EventHandler(this.listBoxShowAllItems_SelectedIndexChanged);
            // 
            // showAllItemsOfList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 277);
            this.Controls.Add(this.listBoxShowAllItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "showAllItemsOfList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список млекопитающих";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxShowAllItems;
    }
}