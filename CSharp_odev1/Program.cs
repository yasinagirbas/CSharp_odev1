
// Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
Console.WriteLine("*****Çift sayi olanları bulma*****\n");
Console.Write("Girmek istediğiniz sayı adetini giriniz:");

int sayiAdeti = int.Parse(Console.ReadLine());
int[] sayiDizisi = new int[sayiAdeti];
for (int i=0; i<sayiAdeti; i++)
{
    Console.Write($"{i+1}. sayıyı giriniz:");
    sayiDizisi[i] = int.Parse(Console.ReadLine());
}
Console.Write("\nGirmiş olduğunuz sayılardan çift sayi olanlar aşağıdakilerdir:\n--> ");
int bolonebilenSayiAdeti = 0;
for (int i=0; i<sayiAdeti; i++)
{
    if (sayiDizisi[i]%2==0)
    {
        bolonebilenSayiAdeti++;
        Console.Write($"{sayiDizisi[i]} ");
    }
}
if(bolonebilenSayiAdeti ==0)
Console.WriteLine("Giridğiniz sayılar arasında çift sayı bulunmamaktadır!");


// Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.


Console.WriteLine("\n\n*****Bir sayıya tam bölünüp bölünmediğini bulma*****\n");
Console.WriteLine("Lütfen sayıları pozitif tam sayı olarak giriniz!\n");

Console.Write("Girmek istediğiniz pozitif tam sayı adetini yazınız:");
int sayiAdeti2 = int.Parse(Console.ReadLine());
Console.Write("Birazdan gireceğiniz sayıları hangi pozitif tam sayıya bölmek isteğinizi yazın:");
int bolecekSayi = int.Parse(Console.ReadLine());

int[] sayiDizisi2 = new int[sayiAdeti2];
for(int i=0; i<sayiAdeti2;i++)
{
    Console.Write($"{i+1}. sayıyı giriniz:");
    sayiDizisi2[i] = int.Parse(Console.ReadLine());
}

Console.Write($"Girmiş olduğunuz sayılardan {bolecekSayi} sayısına bölünebilenleri aşağıdaki gibidir:\n--> ");
int bolonebilenSayiAdeti2 = 0;
for(int i=0;i<sayiAdeti2;i++)
{
    if(sayiDizisi2[i]%bolecekSayi==0)
    {
        bolonebilenSayiAdeti2++;
        Console.Write($"{sayiDizisi2[i]} ");
    }
}
if(bolonebilenSayiAdeti2==0)
Console.WriteLine($"Girmiş olduğunuz sayılardan {bolecekSayi} sayısına bölünebilen bir sayı yok!");
// Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

Console.WriteLine("\n\n*** Girilecek kelimeleri sondan başa doğru yazma ***\n");
Console.WriteLine("Girmek istediğiniz kelime sayısını yazınız:");
int kelimeSayisi = int.Parse(Console.ReadLine());
string[] kelimeDizisi = new string[kelimeSayisi];
for(int i=0;i<kelimeSayisi;i++)
{
    Console.Write($"{i+1}. kelimeyi giriniz:");
    kelimeDizisi[i] = Console.ReadLine();
}
Array.Reverse(kelimeDizisi);
Console.Write("\nKelimelerin sondan başa doğru tekrar sıralanmış hali:\n --> ");
for(int i=0;i<kelimeSayisi;i++)
{
    Console.Write($"{kelimeDizisi[i]} ");
}
// Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

Console.WriteLine("\n\n***Bir cümledeki kelime ve harf sayısını bulma***\n");
Console.Write("Cümleyi yazınız:\n--> ");
string cumle = Console.ReadLine();
string[] kelimeler = cumle.Split(" ");
string yenidenCumle = String.Join("",kelimeler);
char[] harf = yenidenCumle.ToCharArray();

Console.WriteLine($"Cümledeki kelime sayısı: {kelimeler.Count()}");
Console.WriteLine($"Cümledeki harf sayısı: {harf.Count()}");

Console.WriteLine("\n*****Programın Sonu*****\n");
