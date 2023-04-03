#define _CRT_SECURE_NO_WARNINGS
#include <iostream>
#include <string>
using namespace std;

class product
{
private:
    char* Name;
    char* Cipher;
    int Number;

public:
    product(product& smbWorker) // конструктор копирования
    {
        Name = new char[strlen(smbWorker.Name) + 1];
        strcpy(Name, smbWorker.Name);
        Cipher = new char[strlen(smbWorker.Cipher) + 1];
        strcpy(Cipher, smbWorker.Cipher);
        Number = smbWorker.Number;
    }

    product() // конструктор без параметров
    {
        Name = new char[5];
        strcpy(Name, "Name");
        Cipher = new char[7];
        strcpy(Cipher, "Cipher");
        Number = 0;
    }

    product(char* Name) // конструктор с 1 параметрам
    {
        this->Name = new char[strlen(Name) + 1];
        strcpy(this->Name, Name);
        Cipher = new char[7];
        strcpy(Cipher, "Cipher");
        Number = 0;
    }

    product(char* Name, char* Cipher) // конструктор с 2 параметрами
    {
        this->Name = new char[strlen(Name) + 1];
        strcpy(this->Name, Name);
        this->Cipher = new char[strlen(Cipher) + 1];
        strcpy(this->Cipher, Cipher);
        Number = 0;
    }

    product(char* Name, char* Cipher, int number) // конструктор с параметрами
    {
        this->Name = new char[strlen(Name) + 1];
        strcpy(this->Name, Name);
        this->Cipher = new char[strlen(Cipher) + 1];
        strcpy(this->Cipher, Cipher);
        this->Number = number;
    }

    void setName(char* Name) { strcpy(this->Name, Name); } 
    char* getName() { return Name; }  
    void setCipher(char* Cipher) { strcpy(this->Cipher, Cipher); } 
    char* getCipher() { return Cipher; } 
    void setNumber(int Number) { this->Number = Number; } 
    int getNumber() { return Number; } 
    ~product() {
        cout << "Деструктор " << this->Name << endl;
    }
    void Show() { cout << "Name - " << this->Name << endl << "Cipher - " << this->Cipher << endl << "Number - " << this->Number << endl << endl; }
    void Set(char* Name, char* Cipher, int Number) { strcpy(this->Name, Name); strcpy(this->Cipher, Cipher); this->Number = Number; } 
};
int main()
{
    setlocale(LC_ALL, "ru");
    // Конструктор с параметрами
    cout << "Конструктор с параметрами" << endl;
    char det1[] = "StockMaster"; char det2[] = "SM-2023";
    product StockMaster(det1, det2, 45);
    StockMaster.Show();
    //конструктор копирования, инициализация объекта другим объектом
    cout << "Rонструктор копирования, инициализация объекта другим объектом" << endl;
    product OtherStockMaster = StockMaster;
    OtherStockMaster.Show();
    //массив деталей размещается в статической памяти
    cout << "массив деталей размещается в статической памяти" << endl;
    char det3[] = "LabelPro"; char det4[] = "LP - 2023";
    product ArrayOfProducts[2];
    ArrayOfProducts[0].Set(det3, det4, 3);
    ArrayOfProducts[0].Show();
    ArrayOfProducts[1].Set(det1, det4, 12);
    ArrayOfProducts[1].Show();
    //работа с объектом через объект и через указатель на объект
    cout << "работа с объектом через объект и через указатель на объект" << endl;
    product obj, * pointer;
    pointer = &obj;
    obj.setName(det3);
    pointer->setCipher(det4);
    obj.setNumber(300);
    pointer->Show();
    return 0;
}


