// See https://aka.ms/new-console-template for more information
using TPModul4_Muh_Aqsa_Sirojudin_103082400004;

Console.WriteLine("=== Pengecekan Kode Pos ===");
KodePos kodePos = new KodePos();

// Contoh pemanggilan
string kel = "Batununggal";
Console.WriteLine($"Kode Pos {kel} : {kodePos.getKodePos(kel)}");

kel = "Wates";
Console.WriteLine($"Kode Pos {kel} : {kodePos.getKodePos(kel)}");

Console.WriteLine();