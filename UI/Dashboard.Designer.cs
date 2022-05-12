
namespace UI
{
    partial class Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.lblLoggedIn = new System.Windows.Forms.Label();
            this.lblLogged = new System.Windows.Forms.Label();
            this.btnIM = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnUM = new System.Windows.Forms.Button();
            this.lblHeadline = new System.Windows.Forms.Label();
            this.btnShowList = new System.Windows.Forms.Button();
            this.chartOpen = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartUrgent = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartUrgent)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLoggedIn
            // 
            this.lblLoggedIn.AutoSize = true;
            this.lblLoggedIn.Location = new System.Drawing.Point(651, 24);
            this.lblLoggedIn.Name = "lblLoggedIn";
            this.lblLoggedIn.Size = new System.Drawing.Size(29, 13);
            this.lblLoggedIn.TabIndex = 0;
            this.lblLoggedIn.Text = "User";
            // 
            // lblLogged
            // 
            this.lblLogged.AutoSize = true;
            this.lblLogged.Location = new System.Drawing.Point(576, 24);
            this.lblLogged.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogged.Name = "lblLogged";
            this.lblLogged.Size = new System.Drawing.Size(71, 13);
            this.lblLogged.TabIndex = 25;
            this.lblLogged.Text = "Logged in as:";
            // 
            // btnIM
            // 
            this.btnIM.Location = new System.Drawing.Point(304, 57);
            this.btnIM.Name = "btnIM";
            this.btnIM.Size = new System.Drawing.Size(141, 23);
            this.btnIM.TabIndex = 23;
            this.btnIM.Text = "Incident Management";
            this.btnIM.UseVisualStyleBackColor = true;
            this.btnIM.Click += new System.EventHandler(this.BtnIM_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(158, 57);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(141, 23);
            this.btnDashboard.TabIndex = 22;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            // 
            // btnUM
            // 
            this.btnUM.Location = new System.Drawing.Point(452, 57);
            this.btnUM.Name = "btnUM";
            this.btnUM.Size = new System.Drawing.Size(141, 23);
            this.btnUM.TabIndex = 21;
            this.btnUM.Text = "User Management";
            this.btnUM.UseVisualStyleBackColor = true;
            this.btnUM.Click += new System.EventHandler(this.BtnUM_Click);
            // 
            // lblHeadline
            // 
            this.lblHeadline.AutoSize = true;
            this.lblHeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadline.Location = new System.Drawing.Point(62, 108);
            this.lblHeadline.Name = "lblHeadline";
            this.lblHeadline.Size = new System.Drawing.Size(237, 31);
            this.lblHeadline.TabIndex = 35;
            this.lblHeadline.Text = "Current incidents";
            // 
            // btnShowList
            // 
            this.btnShowList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(225)))));
            this.btnShowList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowList.ForeColor = System.Drawing.Color.White;
            this.btnShowList.Location = new System.Drawing.Point(534, 108);
            this.btnShowList.Name = "btnShowList";
            this.btnShowList.Size = new System.Drawing.Size(113, 41);
            this.btnShowList.TabIndex = 36;
            this.btnShowList.Text = "SHOW LIST";
            this.btnShowList.UseVisualStyleBackColor = false;
            this.btnShowList.Click += new System.EventHandler(this.btnShowList_Click);
            // 
            // chartOpen
            // 
            chartArea1.Name = "ChartArea1";
            this.chartOpen.ChartAreas.Add(chartArea1);
            this.chartOpen.Location = new System.Drawing.Point(134, 199);
            this.chartOpen.Name = "chartOpen";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Name = "Series1";
            this.chartOpen.Series.Add(series1);
            this.chartOpen.Size = new System.Drawing.Size(240, 211);
            this.chartOpen.TabIndex = 37;
            this.chartOpen.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            title1.Name = "Title1";
            title1.Text = "Unsolved incidents";
            title2.Name = "Title2";
            title2.Text = "All tickets currently open";
            this.chartOpen.Titles.Add(title1);
            this.chartOpen.Titles.Add(title2);
            // 
            // chartUrgent
            // 
            chartArea2.Name = "ChartArea1";
            this.chartUrgent.ChartAreas.Add(chartArea2);
            this.chartUrgent.Location = new System.Drawing.Point(399, 199);
            this.chartUrgent.Name = "chartUrgent";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Name = "Series2";
            this.chartUrgent.Series.Add(series2);
            this.chartUrgent.Size = new System.Drawing.Size(248, 211);
            this.chartUrgent.TabIndex = 38;
            this.chartUrgent.Text = "chart2";
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            title3.Name = "Title1";
            title3.Text = "Incidents past deadline";
            title4.Name = "Title2";
            title4.Text = "These tickets need you immediate attention";
            this.chartUrgent.Titles.Add(title3);
            this.chartUrgent.Titles.Add(title4);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartUrgent);
            this.Controls.Add(this.chartOpen);
            this.Controls.Add(this.btnShowList);
            this.Controls.Add(this.lblHeadline);
            this.Controls.Add(this.lblLogged);
            this.Controls.Add(this.btnIM);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.btnUM);
            this.Controls.Add(this.lblLoggedIn);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.chartOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartUrgent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoggedIn;
        private System.Windows.Forms.Label lblLogged;
        private System.Windows.Forms.Button btnIM;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnUM;
        private System.Windows.Forms.Label lblHeadline;
        private System.Windows.Forms.Button btnShowList;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOpen;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartUrgent;
    }
}