using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace Sitecore.CdpPracticeExamViewer
{
    public partial class PracticeForm : Form
    {
        private List<QuestionData> AllQuestions = new List<QuestionData>();

        private QuestionData CurrentQuestion;

        public PracticeForm()
        {
            this.InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.LoadQuestions();
        }

        private void LoadQuestions()
        {
            try
            {
                using (var wc = new WebClient())
                {
                    var json = wc.DownloadString("https://streza.dev/sitecore-cdp-practice-exam/data.json");
                    
                    var root = JsonConvert.DeserializeObject<Root>(json);
                    
                    this.AllQuestions = root.Questions;
                }

                var competencies = this.AllQuestions
                    .Select(q => q.Competency)
                    .Distinct()
                    .OrderBy(c => c)
                    .ToList();

                this.cmbCompetency.DataSource = competencies;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading questions: " + ex.Message);
            }
        }

        private void cmbCompetency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCompetency.SelectedItem == null)
            {
                return;
            }

            var selectedCompetency = this.cmbCompetency.SelectedItem.ToString();
            
            var filtered = this.AllQuestions
                .Where(q => q.Competency == selectedCompetency)
                .Select(q => q.Question)
                .ToList();

            this.lstQuestions.DataSource = filtered;

            this.grpOptions.Controls.Clear();

            this.lblAnswer.Text = string.Empty;
        }

        private void lstQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstQuestions.SelectedItem == null)
            {
                return;
            }

            var selectedText = this.lstQuestions.SelectedItem.ToString();

            this.CurrentQuestion = this.AllQuestions.FirstOrDefault(q => q.Question == selectedText);

            if (this.CurrentQuestion != null)
            {
                this.DisplayOptions(this.CurrentQuestion);
            }
        }

        private void DisplayOptions(QuestionData q)
        {
            this.grpOptions.Controls.Clear();

            this.lblAnswer.Text = string.Empty;

            this.lblQuestion.Text = $"Question: {q.Question}";

            var y = 20;

            foreach (var opt in q.Options)
            {
                RadioButton rb = new RadioButton
                {
                    Text = $"{opt.Key}: {opt.Value}",
                    Location = new System.Drawing.Point(10, y),
                    AutoSize = true,
                    Font = new System.Drawing.Font("Microsoft Sans Serif", 10F)
                };

                rb.CheckedChanged += (s, e) =>
                {
                    if (rb.Checked)
                    {
                        if (rb.Checked && opt.Key == q.Answer)
                        {
                            this.lblAnswer.Text = $"\u2714 Correct Answer: {q.Answer}";
                            this.lblAnswer.ForeColor = System.Drawing.Color.Green;
                        }
                        else
                        {
                            this.lblAnswer.Text = $"\u274C Incorrect Answer. Correct Answer: {q.Answer}";
                            this.lblAnswer.ForeColor = System.Drawing.Color.Red;
                        }
                    }
                };

                this.grpOptions.Controls.Add(rb);

                y += 25;
            }
        }
    }
}
