using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Logic;
using Model;

namespace UI
{
    //left to do: display object id as integer id
    public partial class Ticket_overview : Form
    {
        //creating the objects we will need later on
        private readonly User currentUser;
        private readonly TicketService ticketService = new TicketService();
        private ArchiveService archiveService = new ArchiveService();

        //passing the current user to the form
        public Ticket_overview(User user)
        {
            InitializeComponent();
            currentUser = user;
            lblLogin.Text = user.Last_name + ", " + user.First_name + " (" + user.Type + ")";

            cbTime.Items.Add("3 months");
            cbTime.Items.Add("6 months");
            cbTime.Items.Add("1 year");
        }
        //form loading depending on user type
        private void Ticket_overview_Load(object sender, EventArgs e)
        {
            Display_All();
            if (currentUser.Type == UserType.ServiceDesk || currentUser.Type == UserType.Admin)
            {
                btnCreateTicket.Enabled = true;
            }
            else
            {
                btnCreateTicket.Enabled = false;
            }
        }
        //display all tickets from database
        private void Display_All()
        {
            List<Ticket> tickets = ticketService.getAll();
            //foreach (Ticket ticket in tickets)
            //{
            //    //since we cant make a enum starting with a int, i did a simple if statement
            //    string deadline = "";
            //    if (ticket.Deadline == TicketDeadline.Days7)
            //    {
            //        deadline = "7 Days";
            //    }
            //    else if (ticket.Deadline == TicketDeadline.Days14)
            //    {
            //        deadline = "14 Days";
            //    }
            //    else if (ticket.Deadline == TicketDeadline.Days28)
            //    {
            //        deadline = "28 Days";
            //    }
            //    else
            //    {
            //        deadline = "6 months";
            //    }
            //    dataTicket.Rows.Add(ticket.id, ticket.Subject, ticket.User, ticket.Date.ToString("dd/MM//yyyy"), ticket.Priority, deadline, ticket.Status);
            //}
            
            // Using a for loop, so you can add a ticket to the tag as a Ticket object
            for (int i = 0; i < tickets.Count; i++)
            {
                Ticket ticket = tickets[i];
                string deadline = "";
                if (ticket.Deadline == TicketDeadline.Days7)
                {
                    deadline = "7 Days";
                }
                else if (ticket.Deadline == TicketDeadline.Days14)
                {
                    deadline = "14 Days";
                }
                else if (ticket.Deadline == TicketDeadline.Days28)
                {
                    deadline = "28 Days";
                }
                else
                {
                    deadline = "6 months";
                }

                dataTicket.Rows.Add(ticket.id, ticket.Subject, ticket.User, ticket.Date.ToString("dd/MM//yyyy"), ticket.Priority, deadline, ticket.Status);
                // Saving the Ticket in the tag of each row
                dataTicket.Rows[i].Tag = tickets[i];
            }
        }
        //filter tickets by subject
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            dataTicket.Rows.Clear();
            string search = txtFilter.Text;
            List<Ticket> tickets = ticketService.FilterTickets(x => x.Subject == search);
            foreach (Ticket ticket in tickets)
            {
                dataTicket.Rows.Add(ticket.id, ticket.Subject, ticket.User, ticket.Date.ToString("dd/MM//yyyy"), ticket.Priority, ticket.Deadline, ticket.Status);
            }

            

            if (txtFilter.Text == "")
            {
                Display_All();
            }
        }
        //create new ticket
        private void BtnCreateTicket_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewTicket createTicket = new NewTicket(currentUser);
            createTicket.ShowDialog();
            this.Close();
        }
        //go to dashboard
        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard(currentUser);
            dashboard.ShowDialog();
            this.Close();
        }
        //go to user view
        private void BtnUM_Click(object sender, EventArgs e)
        {
            this.Hide();
            User_overview userManagement = new User_overview(currentUser);
            userManagement.ShowDialog();
            this.Close();
        }
        //refresh
        private void BtnIM_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ticket_overview incidentManagement = new Ticket_overview(currentUser);
            incidentManagement.ShowDialog();
            this.Close();
        }

        private void transferBtn_Click(object sender, EventArgs e)
        {
            if (dataTicket.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataTicket.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataTicket.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["User"].Value);

                TransferTicket transferForm = new TransferTicket(cellValue);//passing user string value to new form
                transferForm.ShowDialog(this);

            }
            else
            {
                MessageBox.Show("Error whille selecting the ticket, please try again.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dataTicket.Rows.Clear();
            dataTicket.Refresh();
            Display_All();
        }


        // Opens the UpdatTicket view to update the ticket status (thank you Sasa)
        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (dataTicket.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataTicket.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataTicket.Rows[selectedrowindex];
                Ticket ticket = (Ticket)selectedRow.Tag;

                UpdateTicket update = new UpdateTicket(ticket, currentUser);//passing user string value to new form
                update.ShowDialog(this);

            }
            else
            {
                MessageBox.Show("Error whille selecting the ticket, please try again.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dataTicket.Rows.Clear();
            dataTicket.Refresh();
            Display_All();
        }

        // Checks if selected row's ticket is closed
        private void dataTicket_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(((Ticket)dataTicket.SelectedRows[0].Tag).Status == TicketStatus.Closed)
            {
                btnUpdateStatus.Enabled = false;
            }
            else
            {
                btnUpdateStatus.Enabled = true;
            }
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbTime.SelectedItem == null)
                {
                    MessageBox.Show("Please select time", "Error");
                    return;
                }

                int archived = 0;
                int days = 90;
                if (cbTime.SelectedIndex == 1)
                {
                    days = 180;
                }
                else if (cbTime.SelectedIndex == 2)
                {
                    days = 365;
                }

                List<Ticket> tickets = ticketService.getAll();

                foreach (Ticket t in tickets)
                {
                    if (t.Date.AddDays(days) < DateTime.Today)
                    {
                        archived++;
                        archiveService.AddTicket(t);
                        ticketService.RemoveTicket(t);
                    }
                }

                if (archived == 0)
                {
                    MessageBox.Show("System has no tickets older than " + cbTime.SelectedItem.ToString(), "Nothing to archive");
                }
                else
                {
                    MessageBox.Show("(" + archived + ") Tickets older than " + cbTime.SelectedItem.ToString() + " have been moved to archive databse", "Completed");
                    Display_All();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while archiving the tickets", "Error");
            }
        }
    }
}
