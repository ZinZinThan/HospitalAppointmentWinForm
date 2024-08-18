using Guna.UI2.WinForms;
using HospitalManagementSystem.DAO;
using HospitalManagementSystem.Entity;
using HospitalManagementSystem.UI.Configuration;
using HospitalManagementSystem.UI.Entry;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem.UI
{
    public partial class frmMain : Form
    {
        bool sideBarExpand;
        Form activeForm;
        Button tempBtn = new Button();

        public frmMain()
        {
            InitializeComponent();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sideBarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sideBarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sideBarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void btnMenuIcon_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            CreateMenu();
        }

        public void CreateMenu()
        {
            ResMenuEntity menuEntity = new ResMenuEntity();
            try
            {
                int y = 65;
                menuEntity = new MenuDao().GetAllMenuByRoleId();
                if (menuEntity != null && menuEntity.lstMenu.Count > 0)
                {
                    foreach (var item in menuEntity.lstMenu)
                    {
                        Button btn = new Button();
                        btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
                        btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
                        btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        btn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        btn.ForeColor = System.Drawing.Color.White;
                        btn.Location = new System.Drawing.Point(2, y);
                        btn.Image = Properties.Resources.user;
                        btn.ImageAlign = ContentAlignment.MiddleLeft;
                        btn.Name = "btn" + item.Name;
                        btn.Tag = item.Name;
                        btn.Size = new System.Drawing.Size(217, 46);
                        btn.Padding = new Padding(10);
                        btn.Margin = new Padding(10);
                        btn.TabIndex = 1;
                        btn.Text = item.MenuName;
                        btn.UseVisualStyleBackColor = false;
                        btn.Click += new System.EventHandler(btn_Click);
                        sidebar.Controls.Add(btn);
                        y += btn.Height + 2;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if(tempBtn != btn)
            {
                tempBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
                btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(133)))), ((int)(((byte)(229)))));
            }
            else
            {
                btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(133)))), ((int)(((byte)(229)))));
            }
            tempBtn = btn;
            switch (btn.Tag)
            {
                case "NameType":
                    openChildForm(new frmNameType());
                    break;
                case "MaritalStatus":
                    openChildForm(new frmMaritalStatus());
                    break;
                case "User":
                    openChildForm(new frmUser());
                    break;
                case "Speciality":
                    openChildForm(new frmSpeciality());
                    break;
                case "Doctor":
                    openChildForm(new frmDoctor());
                    break;
                case "Registration":
                    openChildForm(new frmRegistration());
                    break;
                case "RegistrationList":
                    openChildForm(new frmRegistrationListing(this));
                    break;
                case "Booking":
                    openChildForm(new frmBooking());
                    break;
                default:
                    break;
            }
        }

        public void openChildForm(Form childForm)
        {
            if(activeForm != null)
            {
                pnlChildForm.Controls.Remove(activeForm);
                activeForm.Close();
                activeForm.Dispose();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Add(childForm);
            childForm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin frm = new frmLogin();
            frm.Show();
        }

    }
}
