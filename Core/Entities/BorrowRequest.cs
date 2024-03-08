namespace grejzor.Core;

public class BorrowRequest
{
    public int Id { get; set; }
    public int ItemId { get; set; }
    public string Borrower { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public DateTime RequestDate { get; set; }
    public DateTime? AcceptDate { get; set; }
    public DateTime? ReturnDate { get; set; }

    public BorrowRequest(int itemId, string borrower)
    {
        ItemId = itemId;
        Borrower = borrower;
        Status = "Pending";
        RequestDate = DateTime.Now;
    }

    // public BorrowRequest() { }
}
