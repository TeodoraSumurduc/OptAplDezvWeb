using Tema1;

List<Persoana> Persoane = new List<Persoana>();

Produs banana = new Produs();
banana.Denumire = "Banana";
banana.Pret = 5;

Produs pepene = new Produs();
pepene.Denumire = "Pepene";
pepene.Pret = 20;

Produs paine = new Produs();
paine.Denumire = "Paine";
paine.Pret = 3;

Produs lapte= new Produs();
lapte.Denumire = "Lapte";
lapte.Pret = 7;

Persoana p1 = new Persoana(); 
p1.Prenume = "Ionut";
p1.ListaCumparaturi.Add(banana);
p1.ListaCumparaturi.Add(lapte);
p1.ListaCumparaturi.Add(paine);

Persoane.Add(p1);

Persoana p2 = new Persoana();
p2.Prenume = "Mihaela";
p2.ListaCumparaturi.Add(paine);
p2.ListaCumparaturi.Add(pepene);
p2.ListaCumparaturi.Add(lapte);

Persoana p3= new Persoana();
p3.Prenume = "Mircea";
p3.ListaCumparaturi.Add(lapte);
p3.ListaCumparaturi.Add(banana);

Persoane.Add(p2);
Persoane.Add(p3);

foreach(Persoana p in Persoane)
{
    foreach(Produs pr in p.ListaCumparaturi)
    {
        Console.WriteLine(pr.Denumire);
    }
    Console.WriteLine("\n");
}
