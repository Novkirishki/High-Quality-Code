# Factory Method
___

## ��� �� ������� �� ������:
Factory Method

## ������ ��������:
�������� �� ������ "Factory Method" ������� ��������� �� ��������� �������.

## ��������:
����� ���������, ����������� ����� �� ������������� � ������ �� �������������� �� ������������ �� ������ �� ������ � ��������� �� ���������� �� ���.

## ���� �� ��������:
1/5

## UML ������� ��������:
![Factory Method UML Class Diagram](http://download.codeplex.com/download?ProjectName=csharpdesignpatterns&DownloadId=236767 "Factory Method UML Class Diagram")

## �������� ���������
+ ������������ ���� ������������ factory �����, ����� ����� �����. ����� ���� ��� ������� � �����, ����� �������� ����������� ������ �� ������.
+ ����� ��������� ���� ���������� ����������� factory ����� � ����� ���������� ����� � ���������� �� ���������.
+ � ��������� ������ �������� "Factory Method" � ��������� ��������, �� �� ������ �������� �� ��������, �� ���� �� ���� ��������� � ����� ������� �� ����� �� ��������� �� ������.

```cs
	public abstract class BookReader
    {
        public BookReader()
        {
            Book = BuyBook();
        }
 
        public Book Book { get; set; }
 
        public abstract Book BuyBook();

        
        public void DisplayOwnedBooks()
        {
            Console.WriteLine(Book.GetType().ToString());
        }
    }
 
    public class HorrorBookReader : BookReader
    {
        public override Book BuyBook()
        {
            return new Dracula();
        }
    }
 
    public class FantasyBookReader : BookReader
    {
        public override Book BuyBook()
        {
            return new LordOfTheRings();
        }
    }
 
    public class AdventureBookReader : BookReader
    {
        public override Book BuyBook()
        {
            return new TreasureIsland();
        }
    }
```

+ ������������ ���� �������� ����������� � ����������� �� ����� �� ������ ������������� ������ ���� ����������� �������-��������� � ������� factory ������.

```cs
    public abstract class Book
    {
    }
 
    public class Dracula : Book
    {
    }
 
    public class LordOfTheRings : Book
    {
    }
 
    public class TreasureIsland : Book
    {
    }
 
    public class Encyclopedia : Book
    {
    }
```

+ ���������� � ������������ �� ��������� �� �������� �� ����� C# �������, ����� �������� �������.

```cs
    public Book BuyBook<T>()
        where T : Book, new()
    {
        return new T();
    }
```

+ ��� ���������� ������ �������� ����� ���, �� �� �������� ������� � ������ ������������� �� �������.

```cs
	private static void FactoryMethod()
    {
        var bookReaderList = new List<BookReader>();
 
        bookReaderList.Add(new AdventureBookReader());
        bookReaderList.Add(new FantasyBookReader());
        bookReaderList.Add(new HorrorBookReader());
 
        foreach (var reader in bookReaderList)
        {
            Console.WriteLine(reader.GetType() .ToString());
            // language agnostic solution
            reader.DisplayOwnedBooks();
 
            Console.WriteLine();
        }
 
        // C# specific solution using generics
        var genericReader = new AdventureBookReader();
        Book book = genericReader.BuyBook<Encyclopedia>();
        Console.WriteLine(book.GetType().ToString());
 
        Console.ReadKey();
    }
```