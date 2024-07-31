namespace SchoolManagement
{
    partial class customchechkbox
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
            this.button1 = new System.Windows.Forms.Button();
            this.droptransition = new System.Windows.Forms.Timer(this.components);
            this.materialCheckedListBox = new MaterialSkin.Controls.MaterialCheckedListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(173, 99);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // materialCheckedListBox
            // 
            this.materialCheckedListBox.AutoScroll = true;
            this.materialCheckedListBox.BackColor = System.Drawing.Color.Gainsboro;
            this.materialCheckedListBox.Depth = 0;
            this.materialCheckedListBox.Location = new System.Drawing.Point(173, 126);
            this.materialCheckedListBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckedListBox.Name = "materialCheckedListBox";
            this.materialCheckedListBox.Size = new System.Drawing.Size(186, 121);
            this.materialCheckedListBox.Striped = false;
            this.materialCheckedListBox.StripeDarkColor = System.Drawing.Color.White;
            this.materialCheckedListBox.TabIndex = 5;
            // 
            // customchechkbox
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMargin = new System.Drawing.Size(0, 45);
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(568, 439);
            this.Controls.Add(this.materialCheckedListBox);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "customchechkbox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "customchechkbox";
            this.Load += new System.EventHandler(this.customchechkbox_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer droptransition;
        private System.Windows.Forms.Button button1;
        private MaterialSkin.Controls.MaterialCheckedListBox materialCheckedListBox;
    }
}