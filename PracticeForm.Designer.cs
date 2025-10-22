using System.Windows.Forms;

namespace Sitecore.CdpPracticeExamViewer
{
    partial class PracticeForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblCompetency;
        private System.Windows.Forms.ComboBox cmbCompetency;
        private System.Windows.Forms.ListBox lstQuestions;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblQuestion;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cmbCompetency = new System.Windows.Forms.ComboBox();
            this.lblCompetency = new System.Windows.Forms.Label();
            this.lstQuestions = new System.Windows.Forms.ListBox();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();

            this.SuspendLayout();

            this.lblCompetency.AutoSize = true;
            this.lblCompetency.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblCompetency.Location = new System.Drawing.Point(12, 13);
            this.lblCompetency.Name = "lblCompetency";
            this.lblCompetency.Size = new System.Drawing.Size(0, 30);
            this.lblCompetency.TabIndex = 4;
            this.lblCompetency.Text = "Select Competency:";

            this.cmbCompetency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCompetency.FormattingEnabled = true;
            this.cmbCompetency.Location = new System.Drawing.Point(170, 12);
            this.cmbCompetency.Name = "cmbCompetency";
            this.cmbCompetency.Size = new System.Drawing.Size(400, 24);
            this.cmbCompetency.TabIndex = 0;
            this.cmbCompetency.SelectedIndexChanged += new System.EventHandler(this.cmbCompetency_SelectedIndexChanged);

            this.lstQuestions.FormattingEnabled = true;
            this.lstQuestions.ItemHeight = 16;
            this.lstQuestions.Location = new System.Drawing.Point(12, 50);
            this.lstQuestions.Name = "lstQuestions";
            this.lstQuestions.Size = new System.Drawing.Size(1300, 324);
            this.lstQuestions.TabIndex = 1;
            this.lstQuestions.SelectedIndexChanged += new System.EventHandler(this.lstQuestions_SelectedIndexChanged);

            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblQuestion.Location = new System.Drawing.Point(12, 390);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(0, 20);
            this.lblQuestion.TabIndex = 4;
            this.lblQuestion.MaximumSize = new System.Drawing.Size(1250, 0);

            this.grpOptions.Location = new System.Drawing.Point(12, 470);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(1300, 300);
            this.grpOptions.TabIndex = 2;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Options";

            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblAnswer.Location = new System.Drawing.Point(12, 650);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(0, 20);
            this.lblAnswer.TabIndex = 3;

            this.MaximizeBox = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 700);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.lstQuestions);
            this.Controls.Add(this.cmbCompetency);
            this.Controls.Add(this.lblCompetency);
            this.Controls.Add(this.lblQuestion);
            this.Name = "Sitecore CDP - Practice Exam Viewer";
            this.Text = "Sitecore CDP - Practice Exam Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
