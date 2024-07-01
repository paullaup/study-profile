#include <iostream>
#include <cstring>

using namespace std;

class Book {
    private:
        char *Name;
        int Date;
        bool State;
    public:
        friend ostream& operator<<(ostream &cout, const Book &book) {
            cout << book.Name << ' ' << book.Date << ' ' << book.State;
            return cout;
        }
        Book() {
            Name = new char[10];
        }
        Book(char *n, int d, bool s) {
            Name = new char[10];
            strcpy(Name, n);
            Date = d;
            State = s;
        }
        void setState(bool s) {
            State = s;
        } 
        bool getState() {return State;}
        //compare name
        bool operator==(const Book &book) {
            return strcmp(this->Name, book.Name) == 0;
        }
        //compare date
        bool operator<(const Book &book) {
            return this->Date<book.Date;
        }

};

class Subject {
    private:
        int count;
        char *Name;
        Book books[100];
    public:
        Subject() {
            count = 0;
            Name = new char[10];
        }
        void setSubject(char *n) {
            strcpy(Name, n);
        }
        void addBook(Book book) {
            books[count] = book;
            count++;
        }
        void printBooks() {
            cout << Name << ":" << endl;
            for(int i = 0; i<count; i++) {
                cout << books[i] << endl;
            }
        }
        void swapBooks(Book &book1, Book &book2) {
            Book temp = book1;
            book1 = book2;
            book2 = temp;
        }
        void sortBooks() {
            for(int i = 0; i<count - 1; i++) {
                for(int j = count - 1; j>i; j--) {
                    if(books[j]<books[j-1]) {               //comparing date
                        swapBooks(books[j], books[j - 1]);
                    }
                }
            }
        }
        int getBookIndexByName(char *name) {
            Book temp(name, 0, true);
            for(int i = 0; i<count; i++) {
                if(books[i] == temp) {                      //comparing name
                    return i;
                }
            }
            return -1;
        }
        Book* getBookByIndex(int i) {return &books[i];}

};

class Library {
    private:
        char *Name;
        Subject subjects[3];
    public:
        Library(char *n = new char[10]) {
            Name = new char[10];
            strcpy(Name, n);
            char subjectName1[10] = "Art";
            char subjectName2[10] = "Science";
            char subjectName3[10] = "History";
            subjects[0].setSubject(subjectName1);
            subjects[1].setSubject(subjectName2);
            subjects[2].setSubject(subjectName3);
        }
        void addBooks() {
            int num;
            cout << "Input the number of books: " << endl;
            cin >> num;
            cout << "Input the information of books (name, date, state, subject): " << endl;
            for(int i = 0; i<num; i++) {
                char bookName[10], subjectName[10];
                int date, state;
                cin >> bookName >> date >> state >> subjectName;
                while((subjects[0].getBookIndexByName(bookName) != -1) || (subjects[1].getBookIndexByName(bookName) != -1) || (subjects[2].getBookIndexByName(bookName) != -1)) {
                    cout << "Book exist, input again" << endl;
                    cin >> bookName >> date >> state >> subjectName;
                }
                Book book(bookName, date, state==1);
                if(strcmp(subjectName, "Art") == 0) {
                    subjects[0].addBook(book);
                }
                else if(strcmp(subjectName, "Science") == 0) {
                    subjects[1].addBook(book);
                }
                else if(strcmp(subjectName, "History") == 0) {
                    subjects[2].addBook(book);
                }
            }
            subjects[0].sortBooks();
            subjects[1].sortBooks();
            subjects[2].sortBooks();
        }
        void printBooks() {
            cout << "Books in the library: " << endl;
            for(int i = 0; i<3; i++) {
                subjects[i].printBooks();
            }
        }
        void borrowBook() {
            char name[10];
            cout << "Input the name of the book you want to borrow: " << endl;
            cin >> name;
            int libraryNumber = -1;
            int bookIndex;
            for(int i = 0; i<3; i++) {
                bookIndex = subjects[i].getBookIndexByName(name);
                if(bookIndex!=-1 && subjects[i].getBookByIndex(bookIndex)->getState()) {
                    libraryNumber = i;
                    break;
                }
            }
            while(libraryNumber == -1) {
                cout << "Sorry, the book is not available. Try again:  " << endl;
                cin >> name;
                for(int i = 0; i<3; i++) {
                    bookIndex = subjects[i].getBookIndexByName(name);
                    if(bookIndex!=-1 && subjects[i].getBookByIndex(bookIndex)->getState()) {
                        libraryNumber = i;
                        break;
                    }
                }   
            }
            subjects[libraryNumber].getBookByIndex(bookIndex)->setState(false);
            cout << "Succeed! " << endl;
        }

        
};



int main() {
    Library library;
    library.addBooks();
    library.printBooks();
    library.borrowBook();
    return 0;
}