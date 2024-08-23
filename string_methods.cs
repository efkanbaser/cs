string name = "Efkan";
string msg = "";
for (int i = 0; i < name.Length; i++)
{
    msg += name[i] + "\n";
}

bool b = name.Contains("E");

char[] arr = new char[name.Length];
name.CopyTo(arr);
name.CopyTo(0, arr, 0, name.Length);

b = name.StartsWith("D");
b = name.EndsWith("an");

// Starting from index 4, it removes 2 characters.
string nameClean = name.Remove(2, 2);

string nameReplaced = name.Replace("Efk", "Serk");

string splitMe = "Ali,Ahmet,Ayşe,Selim";
string[] names = splitMe.Split(',');
for (int i = 0; i < names.Length; i++)
{
    msg += names[i] + "\n";
}

// Removes "Ef" and gets appends "kan" to nameSubstring. 
string nameSubstring = name.Substring(2);
// Removes "Ef" and gets appends "ka" to nameSubstring. 
nameSubstring = name.Substring(2, 2);

char[] nameArr = name.ToCharArray();
string nameUpper = name.ToUpper();
string nameLower = name.ToLower();

"            efkan".TrimStart();
"efkan            ".TrimEnd();
"      efkan      ".Trim();
string padding = "45".PadLeft(8, '0');
