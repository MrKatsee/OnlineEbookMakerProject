using UnityEngine.UI;
using UnityEngine.EventSystems;

public class BookButton : Button
{
    private Book book;
    public void SetBook(Book book)
    {
        this.book = book;
    }
    public override void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            OpenBook();
        }else if (eventData.button == PointerEventData.InputButton.Right)
        {
            RemoveBook();
        }
    }

    void OpenBook()
    {
        BookShelfManager.Instance.OpenBook(book);
    }

    void RemoveBook()
    {
        BookShelfManager.Instance.RemoveBook(book);
        Destroy(gameObject);
    }
    
}