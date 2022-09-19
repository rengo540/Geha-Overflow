namespace GehaOverFlow.Views
{
    partial class FormQuestion
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
            this.questionTitle = new System.Windows.Forms.Label();
            this.questionBody = new System.Windows.Forms.Label();
            this.questionUser = new System.Windows.Forms.Label();
            this.answersGridView = new System.Windows.Forms.DataGridView();
            this.ansTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.answerBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.answersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // questionTitle
            // 
            this.questionTitle.AutoSize = true;
            this.questionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionTitle.Location = new System.Drawing.Point(121, 9);
            this.questionTitle.Name = "questionTitle";
            this.questionTitle.Size = new System.Drawing.Size(181, 31);
            this.questionTitle.TabIndex = 0;
            this.questionTitle.Text = "question title";
            this.questionTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // questionBody
            // 
            this.questionBody.AutoSize = true;
            this.questionBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionBody.Location = new System.Drawing.Point(123, 55);
            this.questionBody.Name = "questionBody";
            this.questionBody.Size = new System.Drawing.Size(44, 20);
            this.questionBody.TabIndex = 1;
            this.questionBody.Text = "body";
            // 
            // questionUser
            // 
            this.questionUser.AutoSize = true;
            this.questionUser.Location = new System.Drawing.Point(575, 102);
            this.questionUser.Name = "questionUser";
            this.questionUser.Size = new System.Drawing.Size(70, 16);
            this.questionUser.TabIndex = 2;
            this.questionUser.Text = "user name";
            // 
            // answersGridView
            // 
            this.answersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.answersGridView.Location = new System.Drawing.Point(105, 136);
            this.answersGridView.Name = "answersGridView";
            this.answersGridView.RowHeadersWidth = 51;
            this.answersGridView.RowTemplate.Height = 24;
            this.answersGridView.Size = new System.Drawing.Size(540, 246);
            this.answersGridView.TabIndex = 3;
            // 
            // ansTxt
            // 
            this.ansTxt.Location = new System.Drawing.Point(105, 439);
            this.ansTxt.Name = "ansTxt";
            this.ansTxt.Size = new System.Drawing.Size(540, 22);
            this.ansTxt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "answer ";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(13, 16);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 6;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // answerBtn
            // 
            this.answerBtn.Location = new System.Drawing.Point(693, 439);
            this.answerBtn.Name = "answerBtn";
            this.answerBtn.Size = new System.Drawing.Size(75, 23);
            this.answerBtn.TabIndex = 7;
            this.answerBtn.Text = "Post Answer";
            this.answerBtn.UseVisualStyleBackColor = true;
            this.answerBtn.Click += new System.EventHandler(this.answerBtn_Click);
            // 
            // FormQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 532);
            this.Controls.Add(this.answerBtn);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ansTxt);
            this.Controls.Add(this.answersGridView);
            this.Controls.Add(this.questionUser);
            this.Controls.Add(this.questionBody);
            this.Controls.Add(this.questionTitle);
            this.Name = "FormQuestion";
            this.Text = "FormQuestion";
            this.Load += new System.EventHandler(this.FormQuestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.answersGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionTitle;
        private System.Windows.Forms.Label questionBody;
        private System.Windows.Forms.Label questionUser;
        private System.Windows.Forms.DataGridView answersGridView;
        private System.Windows.Forms.TextBox ansTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button answerBtn;
    }
}