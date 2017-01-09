// CareerCup.Solution1.cpp : Defines the entry point for the console application.

/*
* Problem URl: https://www.careercup.com/question?id=5691693232816128
*
*
* Given a singly linked list: 1->2->3->4->5 Change it to 1->5->2->4->3 using
* O(1) space
*/



#include "stdafx.h"
#include <iostream>
#include "List.hpp"

using namespace std;

int _tmain(int argc, _TCHAR* argv[])
{

	SingleLinkedList* head = new SingleLinkedList(1, NULL);


	SingleLinkedList* iter = head;

	ListOperations listOper;

	for (int i = 1; i < 5; i++) {
		SingleLinkedList* node = new SingleLinkedList(i + 1, NULL);
		iter->next = node;
		iter = iter->next;
	}

	cout << "----------------------------------------------" << endl;
	listOper.printLinkedlist(head);
	cout << "----------------------------------------------" << endl;

	//listOper.reverseLinkedList(&head);
	listOper.PerformShuffle(&head);

	cout << "----------------------------------------------" << endl;
	listOper.printLinkedlist(head);
	cout << "----------------------------------------------" << endl;

	getchar();
	return 0;
}


