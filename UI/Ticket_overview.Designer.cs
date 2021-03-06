
namespace UI
{
    partial class Ticket_overview
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
            this.lblTicketView = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btnCreateTicket = new System.Windows.Forms.Button();
            this.dataTicket = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblLogin = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnIM = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnUM = new System.Windows.Forms.Button();
            this.transferBtn = new System.Windows.Forms.Button();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            this.lblArchive = new System.Windows.Forms.Label();
            this.cbTime = new System.Windows.Forms.ComboBox();
            this.btnArchive = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTicketView
            // 
            this.lblTicketView.AutoSize = true;
            this.lblTicketView.Font = new System.Drawing.Font("Arial Narrow", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketView.Location = new System.Drawing.Point(41, 76);
            this.lblTicketView.Name = "lblTicketView";
            this.lblTicketView.Size = new System.Drawing.Size(305, 52);
            this.lblTicketView.TabIndex = 0;
            this.lblTicketView.Text = "Overview tickets";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(50, 136);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(323, 20);
            this.txtFilter.TabIndex = 1;
            this.txtFilter.Text = "Filter by incident subject";
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // btnCreateTicket
            // 
            this.btnCreateTicket.Location = new System.Drawing.Point(622, 121);
            this.btnCreateTicket.Name = "btnCreateTicket";
            this.btnCreateTicket.Size = new System.Drawing.Size(126, 35);
            this.btnCreateTicket.TabIndex = 2;
            this.btnCreateTicket.Text = "Create Incident";
            this.btnCreateTicket.UseVisualStyleBackColor = true;
            this.btnCreateTicket.Click += new System.EventHandler(this.BtnCreateTicket_Click);
            // 
            // dataTicket
            // 
            this.dataTicket.AllowUserToAddRows = false;
            this.dataTicket.AllowUserToDeleteRows = false;
            this.dataTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTicket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Subject,
            this.User,
            this.Date,
            this.Priority,
            this.Deadline,
            this.Status});
            this.dataTicket.Location = new System.Drawing.Point(50, 191);
            this.dataTicket.Name = "dataTicket";
            this.dataTicket.ReadOnly = true;
            this.dataTicket.RowHeadersWidth = 51;
            this.dataTicket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTicket.Size = new System.Drawing.Size(698, 222);
            this.dataTicket.TabIndex = 4;
            this.dataTicket.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTicket_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 125;
            // 
            // Subject
            // 
            this.Subject.HeaderText = "Subject";
            this.Subject.MinimumWidth = 6;
            this.Subject.Name = "Subject";
            this.Subject.ReadOnly = true;
            this.Subject.Width = 125;
            // 
            // User
            // 
            this.User.HeaderText = "User";
            this.User.MinimumWidth = 6;
            this.User.Name = "User";
            this.User.ReadOnly = true;
            this.User.Width = 125;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 80;
            // 
            // Priority
            // 
            this.Priority.HeaderText = "Priority";
            this.Priority.MinimumWidth = 6;
            this.Priority.Name = "Priority";
            this.Priority.ReadOnly = true;
            this.Priority.Width = 80;
            // 
            // Deadline
            // 
            this.Deadline.HeaderText = "Deadline";
            this.Deadline.MinimumWidth = 6;
            this.Deadline.Name = "Deadline";
            this.Deadline.ReadOnly = true;
            this.Deadline.Width = 80;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 80;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(651, 24);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(29, 13);
            this.lblLogin.TabIndex = 24;
            this.lblLogin.Text = "User";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(576, 24);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Logged in as:";
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
            this.btnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
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
            // transferBtn
            // 
            this.transferBtn.Location = new System.Drawing.Point(490, 121);
            this.transferBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.transferBtn.Name = "transferBtn";
            this.transferBtn.Size = new System.Drawing.Size(126, 35);
            this.transferBtn.TabIndex = 26;
            this.transferBtn.Text = "Transfer";
            this.transferBtn.UseVisualStyleBackColor = true;
            this.transferBtn.Click += new System.EventHandler(this.transferBtn_Click);
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.Location = new System.Drawing.Point(398, 121);
            this.btnUpdateStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Size = new System.Drawing.Size(88, 35);
            this.btnUpdateStatus.TabIndex = 26;
            this.btnUpdateStatus.Text = "Update";
            this.btnUpdateStatus.UseVisualStyleBackColor = true;
            this.btnUpdateStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click);
            // 
            // lblArchive
            // 
            this.lblArchive.AutoSize = true;
            this.lblArchive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblArchive.Location = new System.Drawing.Point(50, 425);
            this.lblArchive.Name = "lblArchive";
            this.lblArchive.Size = new System.Drawing.Size(296, 16);
            this.lblArchive.TabIndex = 27;
            this.lblArchive.Text = "Move to archive tickets that are older than";
            // 
            // cbTime
            // 
            this.cbTime.FormattingEnabled = true;
            this.cbTime.Location = new System.Drawing.Point(365, 424);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(121, 21);
            this.cbTime.TabIndex = 28;
            // 
            // btnArchive
            // 
            this.btnArchive.Location = new System.Drawing.Point(622, 419);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(126, 23);
            this.btnArchive.TabIndex = 29;
            this.btnArchive.Text = "Move to Archive";
            this.btnArchive.UseVisualStyleBackColor = true;
            this.btnArchive.Click += new System.EventHandler(this.btnArchive_Click);
            // 
            // Ticket_overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnArchive);
            this.Controls.Add(this.cbTime);
            this.Controls.Add(this.lblArchive);
            this.Controls.Add(this.btnUpdateStatus);
            this.Controls.Add(this.transferBtn);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnIM);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.btnUM);
            this.Controls.Add(this.dataTicket);
            this.Controls.Add(this.btnCreateTicket);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.lblTicketView);
            this.Name = "Ticket_overview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket_overview";
            this.Load += new System.EventHandler(this.Ticket_overview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTicket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTicketView;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btnCreateTicket;
        private System.Windows.Forms.DataGridView dataTicket;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnIM;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deadline;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Button transferBtn;
        private System.Windows.Forms.Button btnUpdateStatus;
        private System.Windows.Forms.Label lblArchive;
        private System.Windows.Forms.ComboBox cbTime;
        private System.Windows.Forms.Button btnArchive;
    }
}