using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    bookService.BookReviewSampleServiceClient bsc = new bookService.BookReviewSampleServiceClient();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack) //run it the first time, but then leave it in its current state (don't constantly reload)
        Fill_Author_DropDown();
    }

    protected void Fill_Author_DropDown()
    {
        string[] authors = bsc.GetAuthors();
        AuthorDropDownList.DataSource = authors;
        AuthorDropDownList.DataBind();
    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        string author = AuthorDropDownList.SelectedItem.Text;
        bookService.BookLite[] books = bsc.GetBooks(author);
        BookGridView.DataSource = books;
        BookGridView.DataBind();
    }
}