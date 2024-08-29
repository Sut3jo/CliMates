using ProjectSE.Controller;
using ProjectSE.Model;
using System;
using System.Linq;
using System.Web.Services;
using System.Web.UI.WebControls;

namespace ProjectSE.Views
{
    public partial class RequestListPage : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!AuthController.UserIsAdmin())
            {
                Response.Redirect("HomePage.aspx");
            }

            if (!IsPostBack)
            {
                LoadUserList();
            }
        }

        protected void BtnShowUserList_Click(object sender, EventArgs e)
        {
            GridViewUserList.Visible = true;
            GridViewActivityList.Visible = false;
            LoadUserList();
        }

        protected void BtnShowActivityList_Click(object sender, EventArgs e)
        {
            GridViewActivityList.Visible = true;
            GridViewUserList.Visible = false;
            LoadActivityList();
        }

        private void LoadUserList()
        {
            GridViewUserList.DataSource = AuthController.GetMsUsersList();
            GridViewUserList.DataBind();
        }

        private void LoadActivityList()
        {
            GridViewActivityList.DataSource = ActivityController.GetAllActicity();
            GridViewActivityList.DataBind();
        }

        [WebMethod]
        public static MsUser ShowUserDetails(int userId)
        {
            var userDetails = AuthController.GetUserByID(userId);

            return userDetails;
        }

        protected void GridViewUserList_RowEditing(object sender, GridViewEditEventArgs e)
        {
            string userID = GridViewUserList.DataKeys[e.NewEditIndex]["userID"].ToString();
            Response.Redirect($"EditUserPage.aspx?id={userID}");
        }

        protected void GridViewUserList_Sorting(object sender, GridViewSortEventArgs e)
        {
            var dataSource = AuthController.GetMsUsersList();

            // Determine the current sort direction
            SortDirection sortDirection;
            if (ViewState["SortDirection"] == null)
            {
                sortDirection = SortDirection.Ascending;
                ViewState["SortDirection"] = sortDirection;
            }
            else
            {
                sortDirection = (SortDirection)ViewState["SortDirection"];
                // Toggle the sort direction
                sortDirection = sortDirection == SortDirection.Ascending ? SortDirection.Descending : SortDirection.Ascending;
                ViewState["SortDirection"] = sortDirection;
            }

            // Sort the data source based on the selected column
            switch (e.SortExpression)
            {
                case "userID":
                    dataSource = sortDirection == SortDirection.Ascending
                        ? dataSource.OrderBy(u => u.userID).ToList()
                        : dataSource.OrderByDescending(u => u.userID).ToList();
                    break;
                case "verifStatus":
                    dataSource = sortDirection == SortDirection.Ascending
                        ? dataSource.OrderBy(u => u.verifStatus).ToList()
                        : dataSource.OrderByDescending(u => u.verifStatus).ToList();
                    break;
            }

            GridViewUserList.DataSource = dataSource;
            GridViewUserList.DataBind();

            // Reset the CSS classes for all header cells
            foreach (TableCell cell in GridViewUserList.HeaderRow.Cells)
            {
                cell.CssClass = string.Empty;
            }

            // Set the CSS class for the sorted header cell
            foreach (DataControlFieldHeaderCell headerCell in GridViewUserList.HeaderRow.Cells)
            {
                if (headerCell.ContainingField.SortExpression == e.SortExpression)
                {
                    // Add condition to check if the column is sortable
                    if (headerCell.ContainingField.SortExpression != "")
                    {
                        headerCell.CssClass = sortDirection == SortDirection.Ascending ? "asc" : "desc";
                    }
                }
            }
        }

        protected void GridViewActivityList_RowEditing(object sender, GridViewEditEventArgs e)
        {
            string activityID = GridViewActivityList.DataKeys[e.NewEditIndex]["activityID"].ToString();
            Response.Redirect($"EditActivityPage.aspx?id={activityID}");
        }

        protected void GridViewActivityList_Sorting(object sender, GridViewSortEventArgs e)
        {
            var dataSource = ActivityController.GetAllActicity();

            // Determine the current sort direction
            SortDirection sortDirection;
            if (ViewState["SortDirection"] == null)
            {
                sortDirection = SortDirection.Ascending;
                ViewState["SortDirection"] = sortDirection;
            }
            else
            {
                sortDirection = (SortDirection)ViewState["SortDirection"];
                // Toggle the sort direction
                sortDirection = sortDirection == SortDirection.Ascending ? SortDirection.Descending : SortDirection.Ascending;
                ViewState["SortDirection"] = sortDirection;
            }

            // Sort the data source based on the selected column
            switch (e.SortExpression)
            {
                case "activityID":
                    dataSource = sortDirection == SortDirection.Ascending
                        ? dataSource.OrderBy(u => u.activityID).ToList()
                        : dataSource.OrderByDescending(u => u.activityID).ToList();
                    break;
                case "activityTitle":
                    dataSource = sortDirection == SortDirection.Ascending
                        ? dataSource.OrderBy(u => u.activityTitle).ToList()
                        : dataSource.OrderByDescending(u => u.activityTitle).ToList();
                    break;
                case "activityStatus":
                    dataSource = sortDirection == SortDirection.Ascending
                        ? dataSource.OrderBy(u => u.activityStatus).ToList()
                        : dataSource.OrderByDescending(u => u.activityStatus).ToList();
                    break;
            }

            GridViewActivityList.DataSource = dataSource;
            GridViewActivityList.DataBind();

            // Reset the CSS classes for all header cells
            foreach (TableCell cell in GridViewActivityList.HeaderRow.Cells)
            {
                cell.CssClass = string.Empty;
            }

            // Set the CSS class for the sorted header cell
            foreach (DataControlFieldHeaderCell headerCell in GridViewActivityList.HeaderRow.Cells)
            {
                if (headerCell.ContainingField.SortExpression == e.SortExpression)
                {
                    // Add condition to check if the column is sortable
                    if (headerCell.ContainingField.SortExpression != "")
                    {
                        headerCell.CssClass = sortDirection == SortDirection.Ascending ? "asc" : "desc";
                    }
                }
            }
        }
    }
}