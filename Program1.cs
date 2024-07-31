short c = 16;
Int16 c2 = 16;

int a = 15;
Int32 b = 20;

long l = 20;
Int64 l2 = 20;

float f = 15;
Single f2 = 20;

double d = 15;
Double d2 = 20;

decimal d3 = 15;
Decimal d4 = 15;


// ----------------------------------------------------------------------------------------------------------------
// Some Convert methods

int Sayi = 10;

byte sayi1 = Convert.ToByte(Sayi);
short sayi2 = Convert.ToInt16(Sayi);
int sayi3 = Convert.ToInt32(Sayi);
long sayi4 = Convert.ToInt64(Sayi);

float sayi5 = Convert.ToSingle(Sayi);
double sayi6 = Convert.ToDouble(Sayi);
decimal sayi7 = Convert.ToDecimal(Sayi);

// ----------------------------------------------------------------------------------------------------------------
// Some Parse methods

string strSayi = "100";

int pI = int.Parse(strSayi);
double pD = double.Parse(strSayi);

// ----------------------------------------------------------------------------------------------------------------
// Methods that turn other types to strings

byte vb = 20;
string metin1 = Convert.ToString(vb);
string metin2 = vb.ToString();
string metin3 = vb + "";





