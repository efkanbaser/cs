using System.Collections;
using System.ComponentModel;

ArrayList list = new ArrayList();

list.Add(1);
list.Add("efkan");
list.Add('k');
list.Add(15.2f);

list.RemoveAt(1); // Removes efkan, new list = [1, 'k', 15.2]

// You need to do unboxing 
char c = (char)list[1];
// int c2 = list[0] as int?; this will be used in value types

int Capacity = list.Capacity; // 4 objects = 4 capactiy but 5 objects = 8 capacity...
int Count = list.Count; // Actual amount of objects inside the collection



