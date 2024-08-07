#include<iostream>
#include<vector>
#include<string>
using namespace std;
int main() {
	//if,else,else if的用法

	//在这里，if不执行的话，就会执行else
	int d = 0;
	cin >> d;
	if (d == 1)
		cout << "d的值为1" << endl;
	else
		cout << "d的值不为1" << endl;
	


	/*这样只会输出fj，因为在if......else if......else if..结构中只要某一个条件满足了，
	其他的else if不会进行了*/
	int a = 1;
	int b = 2;
	int c = 3;
	if (a == 1)
		cout << "fj" << endl;
	else	if (b == 2)
		cout << "abc" << endl;
	else if (c == 3)
		cout << "qwe" << endl;
	
	/*总的来说，if ....else 的用法很灵活，在上一个案例中，也可以在后面加一个else, 
	这样前面的条件都不满足就会执行else ,    并且在if或else 或else if中可以嵌套if，else ,或其它语句*/
}