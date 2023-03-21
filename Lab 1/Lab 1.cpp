#include <iostream> 
#include <fstream> 
#include <string> 
#include <set> 
#include <map> 

using namespace std;

int main()
{
    setlocale(LC_ALL, "ru");
    ifstream fin;
    multimap <int, string> mp;
    set<string> mySet;
    multiset <string> multiSet;
    fin.open("input.txt");
    if (!fin.is_open())
        cout << "Файл не открыт" << endl;
    else
    {
        cout << "файл открыт " << endl;
        string str;
        while (!fin.eof())
        {
            str = "";
            fin >> str;
            mySet.insert(str);
            multiSet.insert(str);
        }
    }
    fin.close();
    set<string>::iterator it;
    multiset<string>::iterator itr;
    int count = 0;
    multimap <int, string>::reverse_iterator iter;
    for (it = mySet.begin(); it != mySet.end(); it++)
    {
        for (itr = multiSet.begin(); itr != multiSet.end(); itr++)
        {
            count = multiSet.count(*it);
        }
        mp.insert(make_pair(count, *it));
    }
    for (iter = mp.rbegin(); iter != mp.rend(); iter++)
    {
        cout << iter->second << " " << iter->first << endl;
    }
    return 0;
}