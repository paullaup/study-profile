#include <iostream>
#include <iomanip>
using namespace std;
const int N = 10;
struct Date {
    int day;
    int month;
    int year;
};

struct Book {
    int id;
    double price;
    Date date;
};

struct Library {
    Book books[10];
    int num = 0;
};

void listOptions() {
    cout << "~~~~~~~~~Welcome!~~~~~~~~~~" << endl;
    cout << "0: Exit" << endl;
    cout << "1: Add" << endl;
    cout << "2: Show" << endl;
    cout << "3: Delete " << endl;
    cout << "4: Sort" << endl;
    cout << "~~~~~~~~~~~~~~~~~~~~~~~~~~~" << endl;
}

void add(Library *library) {
    if(library->num == 10) {
        cout << "Library is full" << endl;
        return;
    }
    int id, day, month, year;
    double price;
    cout << "Input Book ID:" << endl;
    cin >> id;
    for(int i = 0; i<library->num; i++) {
        if(library->books[i].id == id) {
            cout << "book already exsits" << endl;
            return;
        }
    }
    cout << "Input Price:" << endl;
    cin >> price;
    cout << "Input Date (dd mm yyyy):" << endl;
    cin >> day >> month >> year;
    Date date;
    date.day = day;
    date.month = month;
    date.year = year;
    library->books[library->num++] = {id, price, date};
    cout << endl;
}

void show(Library const *library) {
    for(int i = 0; i<library->num; i++) {
        cout << setw(3) << setfill('0') << library->books[i].id;
        cout << setw(10) << setfill(' ') << fixed << setprecision(2) << library->books[i].price;
        cout << setw(5) << library->books[i].date.day << '-' << library->books[i].date.month << '-' << library->books[i].date.year;
        cout << endl;
    }
    cout << endl;
}

void del(Library *library) {
    int id;
    cout << "Enter the ID to be deleted" << endl;
    cin >> id;
    int delIndex = -1;
    int num = library->num;
    for(int i = 0; i<num; i++) {
        if(library->books[i].id == id) {
            delIndex = i;
            library->num--;
        }
        if(delIndex != -1) {
            library->books[i] = library->books[i+1];
        }
    }
    if(delIndex == -1) {
        cout << "The ID cannot be found" << endl;
    }
    cout << endl;
}

void sort_id(Library *library) {
    for(int i = 0; i<library->num-1; i++) {
        for(int j = library->num - 1; j>i; j--) {
            if(library->books[j].id < library->books[j-1].id) {
                Book temp = library->books[j];
                library->books[j] = library->books[j-1];
                library->books[j-1] = temp;
            }
        }
    }
}

void sort_date(Library *library) {
    for(int i = 0; i<library->num-1; i++) {
        for(int j = library->num - 1; j>i; j--) {

            bool isJSmaller;
            if(library->books[j].date.year == library->books[j-1].date.year) {
                if(library->books[j].date.month == library->books[j-1].date.month) {
                    if(library->books[j].date.day == library->books[j-1].date.day) {
                        isJSmaller = library->books[j].id < library->books[j-1].id;
                    }
                    else {
                        isJSmaller = library->books[j].date.day < library->books[j-1].date.day;
                    }
                }
                else {
                    isJSmaller = library->books[j].date.month < library->books[j-1].date.month;
                }
            }
            else {
                isJSmaller = library->books[j].date.year < library->books[j-1].date.year;
            }

            if(isJSmaller) {
                Book temp = library->books[j];
                library->books[j] = library->books[j-1];
                library->books[j-1] = temp;
            }
        }
    }
}

void sort(Library *library) {
 int n;
 cout << "1: Sort by ID" << endl;
 cout << "2: Sort by Date" << endl;
 cin >> n;
 switch(n) {
    case 1:
        sort_id(library);
        break;
    case 2:
        sort_date(library);
        break;
 }
 cout << endl;
}

void init(Library *p) {
 p->books[p->num].id = 3;
 p->books[p->num].price = 10.5;
 p->books[p->num].date.day = 15;
 p->books[p->num].date.month = 1;
 p->books[p->num].date.year = 1990;
 (p->num)++;

 p->books[p->num].id = 2;
 p->books[p->num].price = 20.55;
 p->books[p->num].date.day = 15;
 p->books[p->num].date.month = 2;
 p->books[p->num].date.year = 2024;
 (p->num)++;

 p->books[p->num].id = 4;
 p->books[p->num].price = 10.5;
 p->books[p->num].date.day = 20;
 p->books[p->num].date.month = 2;
 p->books[p->num].date.year = 2021;
 (p->num)++;

 p->books[p->num].id = 1;
 p->books[p->num].price = 30.1;
 p->books[p->num].date.day = 20;
 p->books[p->num].date.month = 2;
 p->books[p->num].date.year = 2021;
 (p->num)++;
}

int main() {
 Library lib;
 lib.num = 0;
 init(&lib);

 int opt;

 do {
    listOptions();
    cin >> opt;
    switch(opt) {
        case 0:
            cout << "Bye!";
            break;
        case 1:
            add(&lib);
            break;
        case 2:
            show(&lib);
            break;
        case 3:
            del(&lib);
            break;
        case 4:
            sort(&lib);
            break;
    }
} while(opt != 0);

 return 0;
}