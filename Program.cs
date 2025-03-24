using System.Numerics;
using System.Security.Cryptography.X509Certificates;

class Book {

}

class Program {
    static List<string> books = new List<string>();
    static int numOfBooks = 0;
    static string book1 = "";
    static string book2 = "";
    static string book3 = "";
    static string book4 = "";
    static string book5 = "";
    static int booksCheckedOut = 0;
    static string bookCheckOut1 = "";
    static string bookCheckOut2 = "";
    static string bookCheckOut3 = "";
    List<String> checkedOut = new List<string>();

    static void Main() {
        while (true) {
            Console.WriteLine("Choose an option :");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Remove Book");
            Console.WriteLine("3. Display Books");
            Console.WriteLine("4. Search");
            Console.WriteLine("5. CheckIn");
            Console.WriteLine("6. CheckOut");
            Console.WriteLine("7. Exit");
            Console.Write("Choose an option: ");
            // books.Add("dsdsd");
            // Console.WriteLine(books[0]);
            try {
                string choice = Console.ReadLine();
                switch (choice) 
                {
                    case "1" :
                        addBook();
                        break;
                    case "2" :
                        removeBook();
                        break;
                    case "3" :
                        displayBooks();
                        break;    
                    case "4" :
                        search();
                        break; 
                    case "5" :
                        checkIn();
                        break; 
                    case "6" :
                        checkOut();
                        break; 
                    case "7" :
                        return;
                    default :
                        Console.WriteLine("Please select a valid option");
                        break;        
                }
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }
    }

    static void addBook() {
        if (numOfBooks == 5) {
            Console.WriteLine("There are currently to many books to add another");
            return;
        }
        Console.WriteLine("Please enter the title of the book you would like to add");
        try {
            string bookToAdd = Console.ReadLine();
            if (string.IsNullOrEmpty(book1)) {
                book1 = bookToAdd;
                books.Add(book1);
                numOfBooks++;
                Console.WriteLine(books[1]);
            }     
            else if (string.IsNullOrEmpty(book2)) {
                book2 = bookToAdd;
                books.Add(book2);
                numOfBooks++;
            }
            else if (string.IsNullOrEmpty(book3)) {
                book3 = bookToAdd;
                books.Add(book3);
                numOfBooks++;
            }  
            else if (string.IsNullOrEmpty(book4)) {
                book4 = bookToAdd;
                books.Add(book4);
                numOfBooks++;
            }  
            else if (string.IsNullOrEmpty(book5)) {
                book5 = bookToAdd;
                books.Add(book5);
                numOfBooks++;
            }
            else {
                Console.WriteLine("Something went wrong");
            }
        }
        catch (Exception e) {
            Console.WriteLine(e.Message);
        }
    }

    static void removeBook() {
        if (numOfBooks == 0) {
            Console.WriteLine("No books to remove");
            return;
        }
        Console.WriteLine("Please enter the name of the book you would like to remove");
        try 
        {
            string bookToRemove = Console.ReadLine();
            if (book1 == bookToRemove) {
                book1 = "";
                books.Remove(book1);
                numOfBooks--;
            }     
            else if (book2 == bookToRemove) {
                book2 = "";
                books.Remove(book2);
                numOfBooks--;
            }
            else if (book3 == bookToRemove) {
                book3 = "";
                books.Remove(book3);
                numOfBooks--;
            }  
            else if (book4 == bookToRemove) {
                book4 = "";
                books.Remove(book4);
                numOfBooks--;
            }  
            else if (book5 == bookToRemove) {
                book5 = "";
                books.Remove(book5);
                numOfBooks--;
            }  
            else {
                Console.WriteLine("The title you entered was not found");
            }              
        }
            
        catch (Exception e) 
        {
            Console.WriteLine(e.Message);
        }
    }

    static void displayBooks() {
        Console.WriteLine("Available books:");
        if (!string.IsNullOrEmpty(book1)) Console.WriteLine(book1);
        if (!string.IsNullOrEmpty(book2)) Console.WriteLine(book2);
        if (!string.IsNullOrEmpty(book3)) Console.WriteLine(book3);
        if (!string.IsNullOrEmpty(book4)) Console.WriteLine(book4);
        if (!string.IsNullOrEmpty(book5)) Console.WriteLine(book5);
    }    

    static void search() {
        Console.WriteLine("Enter a book to search");
        try {
            String searchBook = Console.ReadLine();
            foreach (string book in books) {
                if (book == searchBook) {
                    Console.WriteLine("Book found");
                    return;
                }
            }
            Console.WriteLine("Book not found");
        }
        catch (Exception e) {
            Console.WriteLine(e.Message);
        }
    }    

    static void checkIn() {
        Console.WriteLine("Check In a book");
        try {
            String checkIn = Console.ReadLine();
            if (bookCheckOut1 == checkIn) {
                bookCheckOut1 = "";
            }     
            else if (bookCheckOut2 == checkIn) {
                bookCheckOut2 = "";
            }
            else if (bookCheckOut3 == checkIn) {
                bookCheckOut2 = "";
            }  
            else {
                Console.WriteLine("Book not found");
                return;
            }
            booksCheckedOut--;
        }
        catch (Exception e) {
            Console.WriteLine(e.Message);
        }
    }    

    static void checkOut() {
        if (booksCheckedOut == 3) {
            Console.WriteLine("you've reached the checkout limit");
            return;
        }
        Console.WriteLine("Check Out a book");
        try {
            String checkOut = Console.ReadLine();
            for (int i = 0; i < books.Count; i++) {
                String book = books[i];
                Console.WriteLine(book);
                if (book == checkOut) {
                    if (String.IsNullOrEmpty(bookCheckOut1)) bookCheckOut1 = book;
                    else if (String.IsNullOrEmpty(bookCheckOut2)) bookCheckOut2 = book;
                    else if (String.IsNullOrEmpty(bookCheckOut3)) bookCheckOut3 = book;
                    booksCheckedOut++;
                    break;
                }
            }
            // Console.WriteLine("cd");
        }
        catch (Exception e) {
            Console.WriteLine(e.Message);
        }
    }    
}